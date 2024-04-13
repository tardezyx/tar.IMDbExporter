using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using tar.IMDbExporter.Base;
using tar.IMDbExporter.Gui.Custom;
using tar.IMDbExporter.Models;
using tar.IMDbScraper.Base;
using tar.IMDbScraper.Enums;
using tar.IMDbScraper.Models;

namespace tar.IMDbExporter.Gui {
  public partial class MainForm : Form {
    #region --- constructor -----------------------------------------------------------------------
    public MainForm(string[] arguments) {
      InitializeComponent();

      Text = $"IMDbExporter v{Assembly.GetEntryAssembly()?.GetName().Version}";

      Settings.Current.Load();

      cbxCountryCode.Items.AddRange(
        Operator.GetCountries().Values
        .OrderBy(x => x)
        .ToArray()
			);

      string region2letter = RegionInfo.CurrentRegion.TwoLetterISORegionName;
      Operator.GetCountries().TryGetValue(region2letter, out string? region);

      cbxCountryCode.SelectedItem = region;
      nudUpdatePeriod.Value       = Settings.Current.Stored.UpdateHashesPeriodInDays;
      tbxCountryCode.Text         = region2letter;
      tbxExportFolder.Text        = Settings.Current.Stored.ExportFolder;
      tbxPathToHashFile.Text      = Settings.Current.Stored.PathToHashFile;

      if (arguments.Length > 0) {
        Match match = RegexIMDbID().Match(arguments[0]);
        if (match.Success) {
          _titles.Add(
            new() {
              Id = match.Value
            }
          );
        }
      }

      btnProcess.Enabled     =
      grbxExport.Enabled     =
      grbxScrape.Enabled     = chbxExportJson.Checked || chbxExportTxt.Checked;
      lblWarning.Visible     = (nudNews.Enabled && nudNews.Value == 0) || (nudUserReviews.Enabled && nudUserReviews.Value == 0);
      nudNews.Enabled        = chbxNews.Checked || chbxScrapeEverything.CheckState == CheckState.Checked;
      nudUserReviews.Enabled = chbxUserReviews.Checked || chbxScrapeEverything.Checked;
      tbxCountryCode.Enabled = chbxExportTxt.Checked;
    }
    #endregion
    #region --- fields ----------------------------------------------------------------------------
    private readonly HttpClient                        _httpClient    = new();
    private readonly Dictionary<string, Image>         _imageCache    = [];
    private          bool                              _isTaskRunning = false;
    private          string                            _searchValue   = string.Empty;
    private readonly SortableBindingList<SearchResult> _titles        = [];
    #endregion
    #region --- regex -----------------------------------------------------------------------------
    [GeneratedRegex(@"tt\d+", RegexOptions.IgnoreCase)]
    private static partial Regex RegexIMDbID();
    #endregion

    #region --- add title -------------------------------------------------------------------------
    internal void AddTitle(SearchResult title) {
      if (_titles.FirstOrDefault(x => x.Id == title.Id) is null) {
        _titles.Add(title);
      }
    }
    #endregion
    #region --- download image -------------------------------------------------------- (async) ---
    private async Task<Image?> DownloadImageAsync(string? url) {
      if (string.IsNullOrEmpty(url)) {
        return null;
      }

      if (_imageCache.TryGetValue(url, out Image? result)) {
        return result;
      }

      var ext    = Path.GetExtension(url);
      var newUrl = $"{url[..^ext.Length]}._V1_QL75_UY148_CR9,0,100,148_{ext}";

      byte[] imageBytes = await _httpClient.GetByteArrayAsync(newUrl);
      Image image = Image.FromStream(new MemoryStream(imageBytes));

      _imageCache.Add(url, image);

      return image;
    }
    #endregion
    #region --- get imdb title settings -----------------------------------------------------------
    private IMDbTitleSettings GetImdbTitleSettings() {
      return new() {
        AlternateTitles = chbxAlternateTitles.Checked || chbxScrapeEverything.Checked,
        AlternateVersions = chbxAlternateVersions.Checked || chbxScrapeEverything.Checked,
        Awards = chbxAwards.Checked || chbxScrapeEverything.Checked,
        Companies = chbxCompanies.Checked || chbxScrapeEverything.Checked,
        Connections = chbxConnections.Checked || chbxScrapeEverything.Checked,
        CrazyCredits = chbxCrazyCredits.Checked || chbxScrapeEverything.Checked,
        Crew = chbxCrew.Checked || chbxScrapeEverything.Checked,
        CriticReviews = chbxCriticReviews.Checked || chbxScrapeEverything.Checked,
        EpisodesCard = chbxEpisodesCard.Checked || chbxScrapeEverything.Checked,
        ExternalReviews = chbxExternalReviews.Checked || chbxScrapeEverything.Checked,
        ExternalSites = chbxExternalSites.Checked || chbxScrapeEverything.Checked,
        FAQPage = chbxFAQPage.Checked || chbxScrapeEverything.Checked,
        FilmingDates = chbxFilmingDates.Checked || chbxScrapeEverything.Checked,
        FilmingLocations = chbxFilmingLocations.Checked || chbxScrapeEverything.Checked,
        Goofs = chbxGoofs.Checked || chbxScrapeEverything.Checked,
        Keywords = chbxKeywords.Checked || chbxScrapeEverything.Checked,
        LocationsPage = chbxLocationsPage.Checked || chbxScrapeEverything.Checked,
        MainNews = chbxMainNews.Checked || chbxScrapeEverything.Checked,
        MainPage = chbxMainPage.Checked || chbxScrapeEverything.Checked,
        News = chbxNews.Checked || chbxScrapeEverything.Checked,
        NewsRequests = (int)nudNews.Value,
        NextEpisode = chbxNextEpisode.Checked || chbxScrapeEverything.Checked,
        ParentalGuidePage = chbxParentalGuidePage.Checked || chbxScrapeEverything.Checked,
        PlotSummaries = chbxPlotSummaries.Checked || chbxScrapeEverything.Checked,
        Quotes = chbxQuotes.Checked || chbxScrapeEverything.Checked,
        RatingsPage = chbxRatingsPage.Checked || chbxScrapeEverything.Checked,
        ReferencePage = chbxReferencePage.Checked || chbxScrapeEverything.Checked,
        ReleaseDates = chbxReleaseDates.Checked || chbxScrapeEverything.Checked,
        Seasons = chbxSeasons.Checked || chbxScrapeEverything.Checked,
        Soundtrack = chbxSoundtrack.Checked || chbxScrapeEverything.Checked,
        Storyline = chbxStoryline.Checked || chbxScrapeEverything.Checked,
        Taglines = chbxTaglines.Checked || chbxScrapeEverything.Checked,
        TechnicalPage = chbxTechnicalPage.Checked || chbxScrapeEverything.Checked,
        Topics = chbxTopics.Checked || chbxScrapeEverything.Checked,
        TriviaEntries = chbxTriviaEntries.Checked || chbxScrapeEverything.Checked,
        UserReviews = chbxUserReviews.Checked || chbxScrapeEverything.Checked,
        UserReviewsRequests = (int)nudUserReviews.Value
      };
    }
    #endregion
    #region --- init dgv --------------------------------------------------------------------------
		private void InitDGV() {
      dgv.AutoGenerateColumns = false;

      dgv.Columns.AddRange(
        [
				  new DataGridViewButtonColumn()   { Name = "Remove", Text = "X", UseColumnTextForButtonValue = true, Width = 60 },
				  new DataGridViewTextBoxColumn()  { DataPropertyName = Name = "Id",    HeaderText = "ID",    Width = 60 },
				  new DataGridViewTextBoxColumn()  { DataPropertyName = Name = "Name",  HeaderText = "Name",  Width = 80 },
				  new DataGridViewTextBoxColumn()  { DataPropertyName = Name = "Type",  HeaderText = "Type",  Width = 80 },
				  new DataGridViewTextBoxColumn()  { DataPropertyName = Name = "Years", HeaderText = "Years", Width = 80 },
				  new DataGridViewProgressColumn() { DataPropertyName = Name = "Progress", HeaderText = "Progress", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
        ]
      );

      dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

      dgv.DataSource = _titles;
		}
		#endregion
		#region --- on closing ------------------------------------------------------------------------
		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			Settings.Current.CheckBeforeSave();
		}
		#endregion
    #region --- on load ---------------------------------------------------------------------------
    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);

      SetStyle(
        ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint,
        true
      );

      CenterToScreen();
      InitDGV();
      UpdateControlsByCheckBoxes();
      WireEvents();
    }
    #endregion
    #region --- pre check -------------------------------------------------------------------------
    private bool PreCheck() {
      if (tbxExportFolder.Text.Length == 0) {
        lblStatus.Text = "(ERROR) Please set export folder!";
        return false;
      }

      if (_titles.Count == 0) {
        lblStatus.Text = "(ERROR) Please add IMDb title(s)!";
        return false;
      }

      if (Operator.GetCountryNameByCode(tbxCountryCode.Text) is null) {
        lblStatus.Text = "(ERROR) Please set correct country code!";
        return false;
      }

      return true;
    }
    #endregion
    #region --- process --------------------------------------------------------------- (async) ---
    private async Task ProcessAsync() {
      void UpdateStatus(int steps, int step, string description) {
        int percentage = (int)((step / (float)steps) * 100);
        lblStatus.Text    = $"{percentage} %: {description}";
        progressBar.Value = percentage;
      }

      if (!PreCheck()) {
        return;
      }

      ToggleControls();

      int steps = _titles.Count + 1;
      int step  = 1;

      // set hash file location and update hashes if period days have past
      if (InvokeRequired) {
        Invoke(() => UpdateStatus(steps, step, $"Hash update check. If browser opens, wait until it is closed automatically!"));
      } else { 
        UpdateStatus(steps, step, $"Hash update check. If browser opens, wait until it is closed automatically!");
      }
      
      await Scraper.ScrapeAllOperationHashesAsync(
        Settings.Current.Stored.PathToHashFile,
        DateTime.Now.AddDays(Settings.Current.Stored.UpdateHashesPeriodInDays * -1)
      );

      foreach (SearchResult title in _titles) {
        if (InvokeRequired) {
          Invoke(() => UpdateStatus(steps, step, $"{title.Name} [{title.Id}]"));
        } else { 
          UpdateStatus(steps, step, $"{title.Name} [{title.Id}]");
        }

        IMDbTitle? imdbTitle = await title.ScrapeAsync(GetImdbTitleSettings());

        if (imdbTitle is null) {
          continue;
        }

        if (chbxExportJson.CheckState == CheckState.Checked || chbxExportTxt.CheckState == CheckState.Checked) {
          Directory.CreateDirectory(Settings.Current.Stored.ExportFolder);

          string filePath = Path.Combine(
            Settings.Current.Stored.ExportFolder,
            title.Id
          );

          if (chbxExportJson.CheckState == CheckState.Checked) {
            string exportJson = imdbTitle.GetJson();
            
            await File.WriteAllTextAsync(
              $"{filePath}.json",
              exportJson
            );

            title.Progress.Description = ".json file written";
          }

          if (chbxExportTxt.CheckState == CheckState.Checked) {
            string exportText = Operator.Parse(
              imdbTitle,
              tbxCountryCode.Text
            );

            await File.WriteAllTextAsync(
              $"{filePath}.txt",
              exportText
            );

          }

          title.Progress.Description = chbxExportJson.CheckState == CheckState.Checked && chbxExportTxt.CheckState == CheckState.Checked
            ? "(OK) Files written"
            : "(OK) File written";

          dgv.Invalidate();
        }

        step++;
      }

      if (InvokeRequired) {
        Invoke(() => UpdateStatus(steps, step, $"All titles processed."));
      } else { 
        UpdateStatus(steps, step, $"All titles processed.");
      }

      ToggleControls(true);
    }
    #endregion
		#region --- remove title ----------------------------------------------------------------------
		private void RemoveTitle(SearchResult title) {
      _titles.Remove(title);
      dgv.AutoResizeColumns();
    }
    #endregion
    #region --- search ----------------------------------------------------------------------------
    private async Task Search() {
      #region --- stop task -----------------------------------------------------------------------
      bool StopTask() {
        if (_searchValue == tbxSearch.Text) {
          return false;
        }

        _isTaskRunning = false;
        return true;
      }
      #endregion

      while (_isTaskRunning) {
        await Task.Delay(50);
      }

      if (_searchValue == tbxSearch.Text) {
        return;
      }

      _isTaskRunning = true;
      _searchValue = tbxSearch.Text;

      await Task.Delay(400);

      if (StopTask()) {
        return;
      }
      
      flpnl.Controls.Clear();

      List<Suggestion> suggestions = await Scraper.ScrapeSuggestionsAsync(
        tbxSearch.Text,
        SuggestionsCategory.Titles,
        true
      );

      foreach (Suggestion suggestion in suggestions) {
        if (StopTask()) {
          return;
        }

        string id       = string.IsNullOrEmpty(suggestion.ID)       ? string.Empty : suggestion.ID;
        Image? image    = await DownloadImageAsync(suggestion.ImageURL);
        string imageUrl = string.IsNullOrEmpty(suggestion.ImageURL) ? string.Empty : suggestion.ImageURL;
        string name     = string.IsNullOrEmpty(suggestion.Name)     ? string.Empty : suggestion.Name;
        string notes    = string.IsNullOrEmpty(suggestion.Notes)    ? string.Empty : suggestion.Notes;
        string type     = string.IsNullOrEmpty(suggestion.Type)     ? string.Empty : suggestion.Type;
        string url      = string.IsNullOrEmpty(suggestion.URL)      ? string.Empty : suggestion.URL;
        string yearFrom = suggestion.YearFrom is null               ? string.Empty : $"{suggestion.YearFrom}";
        string yearTo   = suggestion.YearTo is null                 ? string.Empty : $"-{suggestion.YearTo}";

        CardControl cardControl = new(
          new() {
            Id       = id,
            Image    = image,
            ImageUrl = imageUrl,
            Name     = name,
            Notes    = notes,
            Type     = type,
            Url      = url,
            Years    = yearFrom + yearTo
          }
        );

        if (InvokeRequired) {
          Invoke(
            () => flpnl.Controls.Add(cardControl)
          );
        } else {
          flpnl.Controls.Add(cardControl);
        }
      }

      _isTaskRunning = false;
    }
    #endregion
    #region --- select export folder --------------------------------------------------------------
    private void SelectExportFolder() {
      FolderBrowserDialog dialog = new();

      if (dialog.ShowDialog() == DialogResult.OK) {
        tbxExportFolder.Text = dialog.SelectedPath;
      }
    }
    #endregion
    #region --- select path to hash file ----------------------------------------------------------
    private void SelectPathToHashFile() {
      SaveFileDialog dialog = new() {
         Filter = "JSON files|*.json|All Files|*.*",
         RestoreDirectory = true
      };

      if (dialog.ShowDialog() == DialogResult.OK) {
        tbxPathToHashFile.Text = dialog.FileName;
      }
    }
    #endregion
    #region --- toggle controls -------------------------------------------------------------------
    private void ToggleControls(bool enable = false) {
      void action() {
        btnExportFolder.Enabled = enable;
        btnPathToHashFile.Enabled = enable;
        btnProcess.Enabled = enable;
        btnUpdateHashes.Enabled = enable;
        tbxCountryCode.Enabled = enable;
        tbxExportFolder.Enabled = enable;
      }

      if (InvokeRequired) {
        Invoke(action);
      } else {
        action();
      }
    }
    #endregion
    #region --- update controls by check boxes ----------------------------------------------------
    private void UpdateControlsByCheckBoxes() {
      btnProcess.Enabled            =
      btnExportFolder.Enabled       =
      grbxScrape.Enabled            =
      tbxExportFolder.Enabled       = chbxExportJson.Checked || chbxExportTxt.Checked;

      cbxCountryCode.Enabled        = chbxExportTxt.Checked;

      chbxAlternateTitles.Enabled   =
      chbxAlternateVersions.Enabled =
      chbxAwards.Enabled            =
      chbxCompanies.Enabled         =
      chbxConnections.Enabled       =
      chbxCrazyCredits.Enabled      =
      chbxCrew.Enabled              =
      chbxCriticReviews.Enabled     =
      chbxEpisodesCard.Enabled      =
      chbxExternalReviews.Enabled   =
      chbxExternalSites.Enabled     =
      chbxFAQPage.Enabled           =
      chbxFilmingDates.Enabled      =
      chbxFilmingLocations.Enabled  =
      chbxGoofs.Enabled             =
      chbxKeywords.Enabled          =
      chbxLocationsPage.Enabled     =
      chbxMainNews.Enabled          =
      chbxMainPage.Enabled          =
      chbxNews.Enabled              =
      chbxNextEpisode.Enabled       =
      chbxParentalGuidePage.Enabled =
      chbxPlotSummaries.Enabled     =
      chbxQuotes.Enabled            =
      chbxRatingsPage.Enabled       =
      chbxReferencePage.Enabled     =
      chbxReleaseDates.Enabled      =
      chbxSeasons.Enabled           =
      chbxSoundtrack.Enabled        =
      chbxStoryline.Enabled         =
      chbxTaglines.Enabled          =
      chbxTechnicalPage.Enabled     =
      chbxTopics.Enabled            =
      chbxTriviaEntries.Enabled     =
      chbxUserReviews.Enabled       = !chbxScrapeEverything.Checked;
      nudNews.Enabled               = chbxNews.Checked || chbxScrapeEverything.CheckState == CheckState.Checked;
      nudUserReviews.Enabled        = chbxUserReviews.Checked || chbxScrapeEverything.Checked;
    }
    #endregion
    #region --- wire events -----------------------------------------------------------------------
    private void WireEvents() {
      btnExportFolder.Click                  +=       (s, e) => SelectExportFolder();
      btnPathToHashFile.Click                +=       (s, e) => SelectPathToHashFile();
      btnProcess.Click                       += async (s, e) => await ProcessAsync();
      btnUpdateHashes.Click                  += async (s, e) => await Scraper.ScrapeAllOperationHashesAsync(Settings.Current.Stored.PathToHashFile, DateTime.Now);
      cbxCountryCode.SelectedValueChanged    +=       (s, e) => tbxCountryCode.Text = Operator.GetCountries().First(x => x.Value == (string)cbxCountryCode.SelectedItem!).Key;
      chbxExportJson.CheckStateChanged       +=       (s, e) => UpdateControlsByCheckBoxes();
      chbxExportTxt.CheckStateChanged        +=       (s, e) => UpdateControlsByCheckBoxes();
      chbxNews.CheckStateChanged             +=       (s, e) => UpdateControlsByCheckBoxes();
      chbxScrapeEverything.CheckStateChanged +=       (s, e) => UpdateControlsByCheckBoxes();
      chbxUserReviews.CheckStateChanged      +=       (s, e) => UpdateControlsByCheckBoxes();
      dgv.CellClick                          +=       (s, e) => { if (e.RowIndex > -1 && dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn) { RemoveTitle((SearchResult)dgv.Rows[e.RowIndex].DataBoundItem); } };
      nudNews.EnabledChanged                 +=       (s, e) => lblWarning.Visible = (nudNews.Enabled && nudNews.Value == 0) || (nudUserReviews.Enabled && nudUserReviews.Value == 0);
      nudNews.ValueChanged                   +=       (s, e) => lblWarning.Visible = (nudNews.Enabled && nudNews.Value == 0) || (nudUserReviews.Enabled && nudUserReviews.Value == 0);
      nudUpdatePeriod.ValueChanged           +=       (s, e) => Settings.Current.Stored.UpdateHashesPeriodInDays = (int)nudUpdatePeriod.Value;
      nudUserReviews.EnabledChanged          +=       (s, e) => lblWarning.Visible = (nudNews.Enabled && nudNews.Value == 0) || (nudUserReviews.Enabled && nudUserReviews.Value == 0);
      nudUserReviews.ValueChanged            +=       (s, e) => lblWarning.Visible = (nudNews.Enabled && nudNews.Value == 0) || (nudUserReviews.Enabled && nudUserReviews.Value == 0);
      tbxExportFolder.TextChanged            +=       (s, e) => Settings.Current.Stored.ExportFolder = tbxExportFolder.Text;
      tbxPathToHashFile.TextChanged          +=       (s, e) => Settings.Current.Stored.PathToHashFile = tbxPathToHashFile.Text;
      tbxSearch.TextChanged                  += async (s, e) => await Search();
      tbxUrl.TextChanged                     +=       (s, e) => {
        Match match = RegexIMDbID().Match(tbxUrl.Text);
        if (match.Success) {
          tbxSearch.Text = match.Value;
        }
      };
    }
    #endregion
  }
}