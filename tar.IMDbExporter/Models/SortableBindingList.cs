using System.ComponentModel;

namespace tar.IMDbExporter.Models {
  public class FilterProperty<T>(string name, Func<T, object?>? valueProvider = null) {
    public string Name { get; set; } = name;
    public Func<T, object?>? ValueProvider { get; set; } = valueProvider;

    public static implicit operator FilterProperty<T>(string name) { return new(name); }
  }

  public class SortableBindingList<T>(params FilterProperty<T>[] filterableProperties) : BindingList<T>, IBindingListView where T : new() {
    #region --- constructor -----------------------------------------------------------------------
    public SortableBindingList(IList<T> list, params FilterProperty<T>[] filterableProperties) : this(filterableProperties) {
      foreach (T item in list) {
        Add(item);
      }

      _unfilteredList = new(list);
    }
    #endregion
    #region --- fields ----------------------------------------------------------------------------
    private bool _isFiltering = false;
    private bool _isSorted;
    private string? _filter;
    private readonly Dictionary<string, FilterProperty<T>> _filterProperties = filterableProperties.ToDictionary(f => f.Name, f => f);
    private ListSortDirection _sortDirection = ListSortDirection.Ascending;
    private PropertyDescriptor? _sortProperty;
    private readonly List<T> _unfilteredList = [];
    #endregion
    #region --- properties ------------------------------------------------------------------------
    public string? Filter { get { return _filter; } set { if (_filter == value) { return; } _filter = value; ApplyFilter(); } }
    protected override bool IsSortedCore { get { return _isSorted; } }
    public ListSortDescriptionCollection SortDescriptions { get { return SortPropertyCore is null ? [] : new ListSortDescriptionCollection([new ListSortDescription(SortPropertyCore, SortDirectionCore)]); } }
    protected override ListSortDirection SortDirectionCore { get { return _sortDirection; } }
    protected override PropertyDescriptor? SortPropertyCore { get { return _sortProperty; } }
    public bool SupportsAdvancedSorting { get { return false; } }
    public bool SupportsFiltering { get { return true; } }
    protected override bool SupportsSortingCore { get { return true; } }
    #endregion
    
    #region --- apply filter ----------------------------------------------------------------------
    public void ApplyFilter() {
      if (_filterProperties.Count == 0)
        return;

      var properties = _filterProperties.Select(propertyInfo => {
        Func<T, object?>? property = propertyInfo.Value?.ValueProvider ?? ((T item) => typeof(T).GetProperty(propertyInfo.Key)?.GetValue(item));

        return property is null
          ? throw new Exception($"Property {propertyInfo.Key} is not accessible in type {typeof(T).FullName} and there is no value provider.")
          : property;
      }).ToList();

      List<T> filteredList = [];
      _isFiltering = true;

      try {
        if (!string.IsNullOrWhiteSpace(Filter)) {
          string filter = Filter.ToLower();

          foreach (var item in _unfilteredList) {
            var foo = properties.First()(item);

            if (properties.Any(property => property(item)?.ToString()?.ToLower()?.Contains(filter) == true))
              filteredList.Add(item);
          }
        } else {
          filteredList.AddRange(_unfilteredList);
        }

        ClearItems();

        foreach (var item in filteredList) {
          Add(item);
        }

        base.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
      } finally {
        _isFiltering = false;
      }
    }
    #endregion
    #region --- apply sort ------------------------------------------------------------------------
    public void ApplySort(ListSortDescriptionCollection sorts) {
      if (sorts.Count != 0 && sorts[0] is ListSortDescription sort && sort.PropertyDescriptor is not null)
        ApplySortCore(sort.PropertyDescriptor, sort.SortDirection);
    }
    #endregion
    #region --- apply sort core -------------------------------------------------------------------
    protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction) {
      _sortProperty = property;
      _sortDirection = direction;

      if (Items is not List<T> list) {
        return;
      }

      list.Sort(Compare);

      _isSorted = true;

      OnListChanged(
        new ListChangedEventArgs(
        ListChangedType.Reset,
        -1
        )
      );
    }
    #endregion
    #region --- compare ---------------------------------------------------------------------------
    private int Compare(T lhs, T rhs) {
      int result = OnComparison(lhs, rhs);

      if (_sortDirection == ListSortDirection.Descending) {
        result = -result; // invert if descending
      }

      return result;
    }
    #endregion
    #region --- on comparison ---------------------------------------------------------------------
    private int OnComparison(T lhs, T rhs) {
      object? lhsValue = lhs == null
        ? null
        : _sortProperty?.GetValue(lhs);

      object? rhsValue = rhs == null
        ? null
        : _sortProperty?.GetValue(rhs);

      if (lhsValue == null) {
        return rhsValue == null
          ? 0   // both null
          : -1; // first null, second has value
      }

      if (rhsValue == null) {
        return 1; // first has value, second null
      }

      if (lhsValue is IComparable comparable) {
        return comparable
          .CompareTo(rhsValue);
      }

      if (lhsValue.Equals(rhsValue)) {
        return 0; // both are the same
      }

      // not comparable, compare ToString
      return lhsValue
        .ToString()!
        .CompareTo(rhsValue.ToString());
    }
    #endregion
    #region --- on list changed -------------------------------------------------------------------
    protected override void OnListChanged(ListChangedEventArgs e) {
      if (_isFiltering)
        return;

      base.OnListChanged(e);

      _unfilteredList.Clear();
      _unfilteredList.AddRange(this);
    }
    #endregion
    #region --- remove filter ---------------------------------------------------------------------
    public void RemoveFilter() {
      Filter = null;
    }
    #endregion
    #region --- remove sort core ------------------------------------------------------------------
    protected override void RemoveSortCore() {
      _isSorted = false;
      _sortDirection = ListSortDirection.Ascending;
      _sortProperty = null;
    }
    #endregion
    #region --- set sort --------------------------------------------------------------------------
    public void SetSort(SortableBindingList<T> sortableBindingList) {
      _sortDirection = sortableBindingList._sortDirection;
      _sortProperty = sortableBindingList._sortProperty;
    }
    #endregion
    #region --- sort ------------------------------------------------------------------------------
    public void Sort() {
      if (_sortProperty is not null) {
        ApplySortCore(
          _sortProperty,
          _sortDirection
        );
      }
    }
    #endregion
    #region --- sort by ---------------------------------------------------------------------------
    public void SortBy(string propertyName, ListSortDirection direction) {
      ApplySortCore(
        TypeDescriptor.GetProperties(typeof(T))[propertyName]!,
        direction
      );
    }
    #endregion
  }
}