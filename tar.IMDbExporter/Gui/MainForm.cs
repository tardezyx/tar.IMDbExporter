using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using tar.IMDbExporter.Base;
using tar.IMDbScraper.Base;

namespace tar.IMDbExporter.Gui {
  public partial class MainForm : Form {
    #region --- constructor -----------------------------------------------------------------------
    public MainForm(string[] arguments) {
      InitializeComponent();

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
      tbxIMDbID.Text              = "tt0133093"; // Matrix (1999)
      tbxPathToHashFile.Text      = Settings.Current.Stored.PathToHashFile;

      if (arguments.Length > 0) {
        Match match = RegexIMDbID().Match(arguments[0]);
        if (match.Success) {
          tbxIMDbID.Text = match.Value;
        }
      }

      btnProcess.Enabled     =
      grbxExport.Enabled     =
      grbxScrape.Enabled     = chbxExportJson.CheckState  == CheckState.Checked || chbxExportTxt.CheckState        == CheckState.Checked;
      nudNews.Enabled        = chbxNews.CheckState        == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked;
      nudUserReviews.Enabled = chbxUserReviews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked;
      tbxCountryCode.Enabled = chbxExportTxt.CheckState   == CheckState.Checked;
    }
    #endregion
    #region --- regex -----------------------------------------------------------------------------
    [GeneratedRegex(@"tt\d+", RegexOptions.IgnoreCase)]
    private static partial Regex RegexIMDbID();
    #endregion

    #region --- get imdb id -----------------------------------------------------------------------
    private void GetImdbId() {
      if (tbxUrl.Text.Length > 0) {
        Match match = RegexIMDbID().Match(tbxUrl.Text);
        if (match.Success) {
          tbxIMDbID.Text = match.Value;
        }
      }
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
      WireEvents();
    }
    #endregion
    #region --- pre check -------------------------------------------------------------------------
    private bool PreCheck() {
      if (tbxExportFolder.Text.Length == 0) {
        lblStatus.Text = "(ERROR) Please set export folder!";
        return false;
      }

      if (tbxIMDbID.Text.Length == 0) {
        lblStatus.Text = "(ERROR) Please set IMDb ID!";
        return false;
      }

      if (Operator.GetCountryNameByCode(tbxCountryCode.Text) == null) {
        lblStatus.Text = "(ERROR) Please set correct country code!";
        return false;
      }

      return true;
    }
    #endregion
    #region --- process --------------------------------------------------------------- (async) ---
    private async Task ProcessAsync() {
      if (!PreCheck()) {
        return;
      }

      ToggleControls();

      // set hash file location and update hashes if period days have past
      lblStatus.Text = "Hash update check. If browser opens, wait until it is closed automatically!";
      await Scraper.ScrapeAllOperationHashesAsync(
        Settings.Current.Stored.PathToHashFile,
        DateTime.Now.AddDays(Settings.Current.Stored.UpdateHashesPeriodInDays * -1)
      );

      #region --- get imdb title ------------------------------------------------------------------
      string iMDbID = tbxIMDbID.Text;

      IMDbTitleSettings settings = new() {
        AlternateTitles = chbxAlternateTitles.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        AlternateVersions = chbxAlternateVersions.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Awards = chbxAwards.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Companies = chbxCompanies.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Connections = chbxConnections.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        CrazyCredits = chbxCrazyCredits.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Crew = chbxCrew.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        CriticReviews = chbxCriticReviews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        EpisodesCard = chbxEpisodesCard.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        ExternalReviews = chbxExternalReviews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        ExternalSites = chbxExternalSites.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        FAQPage = chbxFAQPage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        FilmingDates = chbxFilmingDates.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        FilmingLocations = chbxFilmingLocations.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Goofs = chbxGoofs.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Keywords = chbxKeywords.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        LocationsPage = chbxLocationsPage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        MainNews = chbxMainNews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        MainPage = chbxMainPage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        News = chbxNews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        NewsRequests = (int)nudNews.Value,
        NextEpisode = chbxNextEpisode.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        ParentalGuidePage = chbxParentalGuidePage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        PlotSummaries = chbxPlotSummaries.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Quotes = chbxQuotes.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        RatingsPage = chbxRatingsPage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        ReferencePage = chbxReferencePage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        ReleaseDates = chbxReleaseDates.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Seasons = chbxSeasons.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Soundtrack = chbxSoundtrack.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Storyline = chbxStoryline.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Taglines = chbxTaglines.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        TechnicalPage = chbxTechnicalPage.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        Topics = chbxTopics.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        TriviaEntries = chbxTriviaEntries.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        UserReviews = chbxUserReviews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked,
        UserReviewsRequests = (int)nudUserReviews.Value
      };

      IMDbTitle? imdbTitle = await Operator.ScrapeIMDbTitleAsync(
        this,
        iMDbID,
        settings
      );

      if (imdbTitle == null) {
        lblStatus.Text = $"(ERROR) IMDb title '{iMDbID}' could not be scraped!";
        ToggleControls(true);
        return;
      }
      #endregion
      #region --- export file(s) ------------------------------------------------------------------
      if (chbxExportJson.CheckState == CheckState.Checked || chbxExportTxt.CheckState == CheckState.Checked) {
        Directory.CreateDirectory(Settings.Current.Stored.ExportFolder);

        string filePath = Path.Combine(
          Settings.Current.Stored.ExportFolder,
          iMDbID
        );

        if (chbxExportJson.CheckState == CheckState.Checked) {
          string exportJson = imdbTitle.GetJson();
          await File.WriteAllTextAsync(
            $"{filePath}.json",
            exportJson
          );
        }

        if (chbxExportTxt.CheckState == CheckState.Checked) {
          string exportText = Operator.Parse(
            imdbTitle,
            tbxCountryCode.Text.ToLower()
          );

          await File.WriteAllTextAsync(
            $"{filePath}.txt",
            exportText
          );
        }
      }

      lblStatus.Text = chbxExportJson.CheckState == CheckState.Checked && chbxExportTxt.CheckState == CheckState.Checked
        ? "(OK) Files written"
        : "(OK) File written";
      #endregion

      ToggleControls(true);
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
        tbxIMDbID.Enabled = enable;
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
      grbxExport.Enabled            =
      grbxScrape.Enabled            = chbxExportJson.CheckState == CheckState.Checked || chbxExportTxt.CheckState == CheckState.Checked;

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
      chbxUserReviews.Enabled       = chbxScrapeEverything.CheckState != CheckState.Checked;
      nudNews.Enabled               = chbxNews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked;
      nudUserReviews.Enabled        = chbxUserReviews.CheckState == CheckState.Checked || chbxScrapeEverything.CheckState == CheckState.Checked;
      tbxCountryCode.Enabled        = chbxExportTxt.CheckState == CheckState.Checked;
    }
    #endregion
    #region --- update status by progress ---------------------------------------------------------
    public void UpdateStatusByProgress(IMDbTitleProgress progress) {
      void action() {
        lblStatus.Text = progress.Description;
        progressBar.Value = progress.Value;
      }

      if (InvokeRequired) {
        Invoke(action);
      } else {
        action();
      }
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
      nudUpdatePeriod.ValueChanged           +=       (s, e) => Settings.Current.Stored.UpdateHashesPeriodInDays = (int)nudUpdatePeriod.Value;
      tbxExportFolder.TextChanged            +=       (s, e) => Settings.Current.Stored.ExportFolder = tbxExportFolder.Text;
      tbxPathToHashFile.TextChanged          +=       (s, e) => Settings.Current.Stored.PathToHashFile = tbxPathToHashFile.Text;
      tbxUrl.Validated                       +=       (s, e) => GetImdbId();
    }
    #endregion
  }
}