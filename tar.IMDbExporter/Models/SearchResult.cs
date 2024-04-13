using tar.IMDbScraper.Base;

namespace tar.IMDbExporter.Models {
  public class SearchResult: INPC {
    #region --- fields ----------------------------------------------------------------------------
    private string            _id       = string.Empty;
    private Image?            _image;
    private string            _imageUrl = string.Empty;
    private string            _name     = string.Empty;
    private string            _notes    = string.Empty;
    private IMDbTitleProgress _progress = new();
    private string            _type     = string.Empty;
    private string            _url      = string.Empty;
    private string            _years    = string.Empty;
    #endregion
    #region --- properties ------------------------------------------------------------------------
    public string            Id       { get { return _id;       } set { SetField(ref _id,       value); } }
    public Image?            Image    { get { return _image;    } set { SetField(ref _image,    value); } }
    public string            ImageUrl { get { return _imageUrl; } set { SetField(ref _imageUrl, value); } }
    public string            Name     { get { return _name;     } set { SetField(ref _name,     value); } }
    public string            Notes    { get { return _notes;    } set { SetField(ref _notes,    value); } }
    public IMDbTitleProgress Progress { get { return _progress; } set { SetField(ref _progress, value); } }
    public string            Type     { get { return _type;     } set { SetField(ref _type,     value); } }
    public string            Url      { get { return _url;      } set { SetField(ref _url,      value); } }
    public string            Years    { get { return _years;    } set { SetField(ref _years,    value); } }
    #endregion

    #region --- scrape ---------------------------------------------------------------- (async) ---
    internal async Task<IMDbTitle?> ScrapeAsync(IMDbTitleSettings settings) {
      IMDbTitle result = new(Id, settings);

      result.Updated += new Action<IMDbTitleProgress>(UpdateStatusByProgress);
      await result.ScrapeAsync();
      result.Updated -= new Action<IMDbTitleProgress>(UpdateStatusByProgress);

      if (result is null) {
        Progress.Description = $"(ERROR) IMDb title could not be scraped!";
      }

      return result;
    }
    #endregion
    #region --- update status by progress ---------------------------------------------------------
    private void UpdateStatusByProgress(IMDbTitleProgress progress) {
      Progress = progress;
    }
    #endregion
  }
}