namespace tar.IMDbExporter.Gui {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components is not null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      btnProcess = new Button();
      statusStrip = new StatusStrip();
      progressBar = new ToolStripProgressBar();
      lblStatus = new ToolStripStatusLabel();
      llblExportFolder = new Label();
      tbxExportFolder = new TextBox();
      btnExportFolder = new Button();
      lblCountryCode = new Label();
      tbxCountryCode = new TextBox();
      grbxScrape = new GroupBox();
      grbxPages = new GroupBox();
      chbxFAQPage = new CheckBox();
      chbxLocationsPage = new CheckBox();
      chbxParentalGuidePage = new CheckBox();
      chbxMainPage = new CheckBox();
      chbxRatingsPage = new CheckBox();
      chbxReferencePage = new CheckBox();
      chbxTechnicalPage = new CheckBox();
      groupBox3 = new GroupBox();
      chbxAlternateTitles = new CheckBox();
      chbxAwards = new CheckBox();
      chbxCompanies = new CheckBox();
      chbxSoundtrack = new CheckBox();
      chbxConnections = new CheckBox();
      chbxExternalReviews = new CheckBox();
      chbxStoryline = new CheckBox();
      chbxExternalSites = new CheckBox();
      chbxQuotes = new CheckBox();
      chbxTaglines = new CheckBox();
      chbxPlotSummaries = new CheckBox();
      chbxKeywords = new CheckBox();
      chbxGoofs = new CheckBox();
      chbxFilmingLocations = new CheckBox();
      chbxFilmingDates = new CheckBox();
      chbxCrew = new CheckBox();
      chbxReleaseDates = new CheckBox();
      chbxCriticReviews = new CheckBox();
      chbxTopics = new CheckBox();
      chbxTriviaEntries = new CheckBox();
      chbxAlternateVersions = new CheckBox();
      chbxMainNews = new CheckBox();
      chbxCrazyCredits = new CheckBox();
      groupBox2 = new GroupBox();
      chbxNews = new CheckBox();
      chbxUserReviews = new CheckBox();
      lblWarning = new Label();
      nudNews = new NumericUpDown();
      lblUserReviewsRequests = new Label();
      nudUserReviews = new NumericUpDown();
      lblNewsRequests = new Label();
      groupBox1 = new GroupBox();
      chbxEpisodesCard = new CheckBox();
      chbxSeasons = new CheckBox();
      chbxNextEpisode = new CheckBox();
      chbxScrapeEverything = new CheckBox();
      chbxExportJson = new CheckBox();
      chbxExportTxt = new CheckBox();
      grbxExport = new GroupBox();
      cbxCountryCode = new ComboBox();
      btnUpdateHashes = new Button();
      grbxHashes = new GroupBox();
      lblDays = new Label();
      lblUpdatePeriod = new Label();
      nudUpdatePeriod = new NumericUpDown();
      lblJsonPath = new Label();
      tbxPathToHashFile = new TextBox();
      btnPathToHashFile = new Button();
      lblSearch = new Label();
      tbxSearch = new TextBox();
      flpnl = new FlowLayoutPanel();
      grbxTitles = new GroupBox();
      dgv = new DataGridView();
      tbxUrl = new TextBox();
      lblUrl = new Label();
      statusStrip.SuspendLayout();
      grbxScrape.SuspendLayout();
      grbxPages.SuspendLayout();
      groupBox3.SuspendLayout();
      groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)nudNews).BeginInit();
      ((System.ComponentModel.ISupportInitialize)nudUserReviews).BeginInit();
      groupBox1.SuspendLayout();
      grbxExport.SuspendLayout();
      grbxHashes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)nudUpdatePeriod).BeginInit();
      grbxTitles.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
      SuspendLayout();
      // 
      // btnProcess
      // 
      btnProcess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnProcess.BackColor = Color.Gold;
      btnProcess.FlatStyle = FlatStyle.Flat;
      btnProcess.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnProcess.Location = new Point(661, 79);
      btnProcess.Name = "btnProcess";
      btnProcess.Size = new Size(75, 32);
      btnProcess.TabIndex = 7;
      btnProcess.Text = "Process";
      btnProcess.UseVisualStyleBackColor = false;
      // 
      // statusStrip
      // 
      statusStrip.ImageScalingSize = new Size(24, 24);
      statusStrip.Items.AddRange(new ToolStripItem[] { progressBar, lblStatus });
      statusStrip.Location = new Point(0, 711);
      statusStrip.Name = "statusStrip";
      statusStrip.Size = new Size(1304, 22);
      statusStrip.SizingGrip = false;
      statusStrip.TabIndex = 3;
      // 
      // progressBar
      // 
      progressBar.Name = "progressBar";
      progressBar.Size = new Size(100, 16);
      // 
      // lblStatus
      // 
      lblStatus.Name = "lblStatus";
      lblStatus.Size = new Size(0, 17);
      // 
      // llblExportFolder
      // 
      llblExportFolder.Font = new Font("Segoe UI", 9F);
      llblExportFolder.Location = new Point(6, 51);
      llblExportFolder.Name = "llblExportFolder";
      llblExportFolder.Size = new Size(102, 17);
      llblExportFolder.TabIndex = 4;
      llblExportFolder.Text = "Export Folder";
      llblExportFolder.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxExportFolder
      // 
      tbxExportFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxExportFolder.Font = new Font("Segoe UI", 9F);
      tbxExportFolder.Location = new Point(114, 47);
      tbxExportFolder.Name = "tbxExportFolder";
      tbxExportFolder.Size = new Size(541, 23);
      tbxExportFolder.TabIndex = 4;
      // 
      // btnExportFolder
      // 
      btnExportFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnExportFolder.Font = new Font("Segoe UI", 9F);
      btnExportFolder.Location = new Point(661, 48);
      btnExportFolder.Name = "btnExportFolder";
      btnExportFolder.Size = new Size(75, 23);
      btnExportFolder.TabIndex = 5;
      btnExportFolder.Text = ". . .";
      btnExportFolder.UseVisualStyleBackColor = true;
      // 
      // lblCountryCode
      // 
      lblCountryCode.Font = new Font("Segoe UI", 9F);
      lblCountryCode.Location = new Point(6, 79);
      lblCountryCode.Name = "lblCountryCode";
      lblCountryCode.Size = new Size(102, 17);
      lblCountryCode.TabIndex = 5;
      lblCountryCode.Text = "Country Code";
      lblCountryCode.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxCountryCode
      // 
      tbxCountryCode.Font = new Font("Segoe UI", 9F);
      tbxCountryCode.Location = new Point(114, 76);
      tbxCountryCode.Name = "tbxCountryCode";
      tbxCountryCode.ReadOnly = true;
      tbxCountryCode.Size = new Size(50, 23);
      tbxCountryCode.TabIndex = 6;
      tbxCountryCode.TabStop = false;
      // 
      // grbxScrape
      // 
      grbxScrape.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      grbxScrape.Controls.Add(grbxPages);
      grbxScrape.Controls.Add(groupBox3);
      grbxScrape.Controls.Add(groupBox2);
      grbxScrape.Controls.Add(groupBox1);
      grbxScrape.Controls.Add(chbxScrapeEverything);
      grbxScrape.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      grbxScrape.Location = new Point(550, 347);
      grbxScrape.Name = "grbxScrape";
      grbxScrape.Size = new Size(742, 272);
      grbxScrape.TabIndex = 7;
      grbxScrape.TabStop = false;
      grbxScrape.Text = "Scrape Settings";
      // 
      // grbxPages
      // 
      grbxPages.Controls.Add(chbxFAQPage);
      grbxPages.Controls.Add(chbxLocationsPage);
      grbxPages.Controls.Add(chbxParentalGuidePage);
      grbxPages.Controls.Add(chbxMainPage);
      grbxPages.Controls.Add(chbxRatingsPage);
      grbxPages.Controls.Add(chbxReferencePage);
      grbxPages.Controls.Add(chbxTechnicalPage);
      grbxPages.Location = new Point(427, 47);
      grbxPages.Name = "grbxPages";
      grbxPages.Size = new Size(112, 219);
      grbxPages.TabIndex = 50;
      grbxPages.TabStop = false;
      grbxPages.Text = "Pages";
      // 
      // chbxFAQPage
      // 
      chbxFAQPage.AutoSize = true;
      chbxFAQPage.Font = new Font("Segoe UI", 9F);
      chbxFAQPage.Location = new Point(6, 22);
      chbxFAQPage.Name = "chbxFAQPage";
      chbxFAQPage.Size = new Size(48, 19);
      chbxFAQPage.TabIndex = 20;
      chbxFAQPage.TabStop = false;
      chbxFAQPage.Text = "FAQ";
      chbxFAQPage.UseVisualStyleBackColor = true;
      // 
      // chbxLocationsPage
      // 
      chbxLocationsPage.AutoSize = true;
      chbxLocationsPage.Font = new Font("Segoe UI", 9F);
      chbxLocationsPage.Location = new Point(6, 47);
      chbxLocationsPage.Name = "chbxLocationsPage";
      chbxLocationsPage.Size = new Size(77, 19);
      chbxLocationsPage.TabIndex = 19;
      chbxLocationsPage.TabStop = false;
      chbxLocationsPage.Text = "Locations";
      chbxLocationsPage.UseVisualStyleBackColor = true;
      // 
      // chbxParentalGuidePage
      // 
      chbxParentalGuidePage.AutoSize = true;
      chbxParentalGuidePage.Font = new Font("Segoe UI", 9F);
      chbxParentalGuidePage.Location = new Point(6, 97);
      chbxParentalGuidePage.Name = "chbxParentalGuidePage";
      chbxParentalGuidePage.Size = new Size(103, 19);
      chbxParentalGuidePage.TabIndex = 27;
      chbxParentalGuidePage.TabStop = false;
      chbxParentalGuidePage.Text = "Parental Guide";
      chbxParentalGuidePage.UseVisualStyleBackColor = true;
      // 
      // chbxMainPage
      // 
      chbxMainPage.AutoSize = true;
      chbxMainPage.Font = new Font("Segoe UI", 9F);
      chbxMainPage.Location = new Point(6, 72);
      chbxMainPage.Name = "chbxMainPage";
      chbxMainPage.Size = new Size(53, 19);
      chbxMainPage.TabIndex = 24;
      chbxMainPage.TabStop = false;
      chbxMainPage.Text = "Main";
      chbxMainPage.UseVisualStyleBackColor = true;
      // 
      // chbxRatingsPage
      // 
      chbxRatingsPage.AutoSize = true;
      chbxRatingsPage.Font = new Font("Segoe UI", 9F);
      chbxRatingsPage.Location = new Point(6, 122);
      chbxRatingsPage.Name = "chbxRatingsPage";
      chbxRatingsPage.Size = new Size(65, 19);
      chbxRatingsPage.TabIndex = 28;
      chbxRatingsPage.TabStop = false;
      chbxRatingsPage.Text = "Ratings";
      chbxRatingsPage.UseVisualStyleBackColor = true;
      // 
      // chbxReferencePage
      // 
      chbxReferencePage.AutoSize = true;
      chbxReferencePage.Font = new Font("Segoe UI", 9F);
      chbxReferencePage.Location = new Point(6, 147);
      chbxReferencePage.Name = "chbxReferencePage";
      chbxReferencePage.Size = new Size(78, 19);
      chbxReferencePage.TabIndex = 29;
      chbxReferencePage.TabStop = false;
      chbxReferencePage.Text = "Reference";
      chbxReferencePage.UseVisualStyleBackColor = true;
      // 
      // chbxTechnicalPage
      // 
      chbxTechnicalPage.AutoSize = true;
      chbxTechnicalPage.Font = new Font("Segoe UI", 9F);
      chbxTechnicalPage.Location = new Point(6, 172);
      chbxTechnicalPage.Name = "chbxTechnicalPage";
      chbxTechnicalPage.Size = new Size(75, 19);
      chbxTechnicalPage.TabIndex = 33;
      chbxTechnicalPage.TabStop = false;
      chbxTechnicalPage.Text = "Technical";
      chbxTechnicalPage.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      groupBox3.Controls.Add(chbxAlternateTitles);
      groupBox3.Controls.Add(chbxAwards);
      groupBox3.Controls.Add(chbxCompanies);
      groupBox3.Controls.Add(chbxSoundtrack);
      groupBox3.Controls.Add(chbxConnections);
      groupBox3.Controls.Add(chbxExternalReviews);
      groupBox3.Controls.Add(chbxStoryline);
      groupBox3.Controls.Add(chbxExternalSites);
      groupBox3.Controls.Add(chbxQuotes);
      groupBox3.Controls.Add(chbxTaglines);
      groupBox3.Controls.Add(chbxPlotSummaries);
      groupBox3.Controls.Add(chbxKeywords);
      groupBox3.Controls.Add(chbxGoofs);
      groupBox3.Controls.Add(chbxFilmingLocations);
      groupBox3.Controls.Add(chbxFilmingDates);
      groupBox3.Controls.Add(chbxCrew);
      groupBox3.Controls.Add(chbxReleaseDates);
      groupBox3.Controls.Add(chbxCriticReviews);
      groupBox3.Controls.Add(chbxTopics);
      groupBox3.Controls.Add(chbxTriviaEntries);
      groupBox3.Controls.Add(chbxAlternateVersions);
      groupBox3.Controls.Add(chbxMainNews);
      groupBox3.Controls.Add(chbxCrazyCredits);
      groupBox3.Location = new Point(6, 47);
      groupBox3.Name = "groupBox3";
      groupBox3.Size = new Size(415, 220);
      groupBox3.TabIndex = 49;
      groupBox3.TabStop = false;
      groupBox3.Text = "General";
      // 
      // chbxAlternateTitles
      // 
      chbxAlternateTitles.AutoSize = true;
      chbxAlternateTitles.Font = new Font("Segoe UI", 9F);
      chbxAlternateTitles.Location = new Point(6, 22);
      chbxAlternateTitles.Name = "chbxAlternateTitles";
      chbxAlternateTitles.Size = new Size(129, 19);
      chbxAlternateTitles.TabIndex = 7;
      chbxAlternateTitles.TabStop = false;
      chbxAlternateTitles.Text = "Alternate Titles (All)";
      chbxAlternateTitles.UseVisualStyleBackColor = true;
      // 
      // chbxAwards
      // 
      chbxAwards.AutoSize = true;
      chbxAwards.Font = new Font("Segoe UI", 9F);
      chbxAwards.Location = new Point(6, 72);
      chbxAwards.Name = "chbxAwards";
      chbxAwards.Size = new Size(90, 19);
      chbxAwards.TabIndex = 9;
      chbxAwards.TabStop = false;
      chbxAwards.Text = "Awards (All)";
      chbxAwards.UseVisualStyleBackColor = true;
      // 
      // chbxCompanies
      // 
      chbxCompanies.AutoSize = true;
      chbxCompanies.Font = new Font("Segoe UI", 9F);
      chbxCompanies.Location = new Point(6, 97);
      chbxCompanies.Name = "chbxCompanies";
      chbxCompanies.Size = new Size(111, 19);
      chbxCompanies.TabIndex = 10;
      chbxCompanies.TabStop = false;
      chbxCompanies.Text = "Companies (All)";
      chbxCompanies.UseVisualStyleBackColor = true;
      // 
      // chbxSoundtrack
      // 
      chbxSoundtrack.AutoSize = true;
      chbxSoundtrack.Font = new Font("Segoe UI", 9F);
      chbxSoundtrack.Location = new Point(292, 72);
      chbxSoundtrack.Name = "chbxSoundtrack";
      chbxSoundtrack.Size = new Size(86, 19);
      chbxSoundtrack.TabIndex = 35;
      chbxSoundtrack.TabStop = false;
      chbxSoundtrack.Text = "Soundtrack";
      chbxSoundtrack.UseVisualStyleBackColor = true;
      // 
      // chbxConnections
      // 
      chbxConnections.AutoSize = true;
      chbxConnections.Font = new Font("Segoe UI", 9F);
      chbxConnections.Location = new Point(6, 122);
      chbxConnections.Name = "chbxConnections";
      chbxConnections.Size = new Size(118, 19);
      chbxConnections.TabIndex = 11;
      chbxConnections.TabStop = false;
      chbxConnections.Text = "Connections (All)";
      chbxConnections.UseVisualStyleBackColor = true;
      // 
      // chbxExternalReviews
      // 
      chbxExternalReviews.AutoSize = true;
      chbxExternalReviews.Font = new Font("Segoe UI", 9F);
      chbxExternalReviews.Location = new Point(141, 22);
      chbxExternalReviews.Name = "chbxExternalReviews";
      chbxExternalReviews.Size = new Size(138, 19);
      chbxExternalReviews.TabIndex = 4;
      chbxExternalReviews.TabStop = false;
      chbxExternalReviews.Text = "External Reviews (All)";
      chbxExternalReviews.UseVisualStyleBackColor = true;
      // 
      // chbxStoryline
      // 
      chbxStoryline.AutoSize = true;
      chbxStoryline.Font = new Font("Segoe UI", 9F);
      chbxStoryline.Location = new Point(292, 97);
      chbxStoryline.Name = "chbxStoryline";
      chbxStoryline.Size = new Size(72, 19);
      chbxStoryline.TabIndex = 34;
      chbxStoryline.TabStop = false;
      chbxStoryline.Text = "Storyline";
      chbxStoryline.UseVisualStyleBackColor = true;
      // 
      // chbxExternalSites
      // 
      chbxExternalSites.AutoSize = true;
      chbxExternalSites.Font = new Font("Segoe UI", 9F);
      chbxExternalSites.Location = new Point(141, 47);
      chbxExternalSites.Name = "chbxExternalSites";
      chbxExternalSites.Size = new Size(120, 19);
      chbxExternalSites.TabIndex = 5;
      chbxExternalSites.TabStop = false;
      chbxExternalSites.Text = "External Sites (All)";
      chbxExternalSites.UseVisualStyleBackColor = true;
      // 
      // chbxQuotes
      // 
      chbxQuotes.AutoSize = true;
      chbxQuotes.Font = new Font("Segoe UI", 9F);
      chbxQuotes.Location = new Point(292, 22);
      chbxQuotes.Name = "chbxQuotes";
      chbxQuotes.Size = new Size(89, 19);
      chbxQuotes.TabIndex = 6;
      chbxQuotes.TabStop = false;
      chbxQuotes.Text = "Quotes (All)";
      chbxQuotes.UseVisualStyleBackColor = true;
      // 
      // chbxTaglines
      // 
      chbxTaglines.AutoSize = true;
      chbxTaglines.Font = new Font("Segoe UI", 9F);
      chbxTaglines.Location = new Point(292, 122);
      chbxTaglines.Name = "chbxTaglines";
      chbxTaglines.Size = new Size(68, 19);
      chbxTaglines.TabIndex = 32;
      chbxTaglines.TabStop = false;
      chbxTaglines.Text = "Taglines";
      chbxTaglines.UseVisualStyleBackColor = true;
      // 
      // chbxPlotSummaries
      // 
      chbxPlotSummaries.AutoSize = true;
      chbxPlotSummaries.Font = new Font("Segoe UI", 9F);
      chbxPlotSummaries.Location = new Point(141, 197);
      chbxPlotSummaries.Name = "chbxPlotSummaries";
      chbxPlotSummaries.Size = new Size(134, 19);
      chbxPlotSummaries.TabIndex = 7;
      chbxPlotSummaries.TabStop = false;
      chbxPlotSummaries.Text = "Plot Summaries (All)";
      chbxPlotSummaries.UseVisualStyleBackColor = true;
      // 
      // chbxKeywords
      // 
      chbxKeywords.AutoSize = true;
      chbxKeywords.Font = new Font("Segoe UI", 9F);
      chbxKeywords.Location = new Point(141, 147);
      chbxKeywords.Name = "chbxKeywords";
      chbxKeywords.Size = new Size(102, 19);
      chbxKeywords.TabIndex = 8;
      chbxKeywords.TabStop = false;
      chbxKeywords.Text = "Keywords (All)";
      chbxKeywords.UseVisualStyleBackColor = true;
      // 
      // chbxGoofs
      // 
      chbxGoofs.AutoSize = true;
      chbxGoofs.Font = new Font("Segoe UI", 9F);
      chbxGoofs.Location = new Point(141, 122);
      chbxGoofs.Name = "chbxGoofs";
      chbxGoofs.Size = new Size(82, 19);
      chbxGoofs.TabIndex = 9;
      chbxGoofs.TabStop = false;
      chbxGoofs.Text = "Goofs (All)";
      chbxGoofs.UseVisualStyleBackColor = true;
      // 
      // chbxFilmingLocations
      // 
      chbxFilmingLocations.AutoSize = true;
      chbxFilmingLocations.Font = new Font("Segoe UI", 9F);
      chbxFilmingLocations.Location = new Point(141, 97);
      chbxFilmingLocations.Name = "chbxFilmingLocations";
      chbxFilmingLocations.Size = new Size(145, 19);
      chbxFilmingLocations.TabIndex = 10;
      chbxFilmingLocations.TabStop = false;
      chbxFilmingLocations.Text = "Filming Locations (All)";
      chbxFilmingLocations.UseVisualStyleBackColor = true;
      // 
      // chbxFilmingDates
      // 
      chbxFilmingDates.AutoSize = true;
      chbxFilmingDates.Font = new Font("Segoe UI", 9F);
      chbxFilmingDates.Location = new Point(141, 72);
      chbxFilmingDates.Name = "chbxFilmingDates";
      chbxFilmingDates.Size = new Size(123, 19);
      chbxFilmingDates.TabIndex = 11;
      chbxFilmingDates.TabStop = false;
      chbxFilmingDates.Text = "Filming Dates (All)";
      chbxFilmingDates.UseVisualStyleBackColor = true;
      // 
      // chbxCrew
      // 
      chbxCrew.AutoSize = true;
      chbxCrew.Font = new Font("Segoe UI", 9F);
      chbxCrew.Location = new Point(6, 172);
      chbxCrew.Name = "chbxCrew";
      chbxCrew.Size = new Size(53, 19);
      chbxCrew.TabIndex = 23;
      chbxCrew.TabStop = false;
      chbxCrew.Text = "Crew";
      chbxCrew.UseVisualStyleBackColor = true;
      // 
      // chbxReleaseDates
      // 
      chbxReleaseDates.AutoSize = true;
      chbxReleaseDates.Font = new Font("Segoe UI", 9F);
      chbxReleaseDates.Location = new Point(292, 47);
      chbxReleaseDates.Name = "chbxReleaseDates";
      chbxReleaseDates.Size = new Size(122, 19);
      chbxReleaseDates.TabIndex = 12;
      chbxReleaseDates.TabStop = false;
      chbxReleaseDates.Text = "Release Dates (All)";
      chbxReleaseDates.UseVisualStyleBackColor = true;
      // 
      // chbxCriticReviews
      // 
      chbxCriticReviews.AutoSize = true;
      chbxCriticReviews.Font = new Font("Segoe UI", 9F);
      chbxCriticReviews.Location = new Point(6, 197);
      chbxCriticReviews.Name = "chbxCriticReviews";
      chbxCriticReviews.Size = new Size(99, 19);
      chbxCriticReviews.TabIndex = 22;
      chbxCriticReviews.TabStop = false;
      chbxCriticReviews.Text = "Critic Reviews";
      chbxCriticReviews.UseVisualStyleBackColor = true;
      // 
      // chbxTopics
      // 
      chbxTopics.AutoSize = true;
      chbxTopics.Font = new Font("Segoe UI", 9F);
      chbxTopics.Location = new Point(292, 147);
      chbxTopics.Name = "chbxTopics";
      chbxTopics.Size = new Size(84, 19);
      chbxTopics.TabIndex = 14;
      chbxTopics.TabStop = false;
      chbxTopics.Text = "Topics (All)";
      chbxTopics.UseVisualStyleBackColor = true;
      // 
      // chbxTriviaEntries
      // 
      chbxTriviaEntries.AutoSize = true;
      chbxTriviaEntries.Font = new Font("Segoe UI", 9F);
      chbxTriviaEntries.Location = new Point(292, 172);
      chbxTriviaEntries.Name = "chbxTriviaEntries";
      chbxTriviaEntries.Size = new Size(116, 19);
      chbxTriviaEntries.TabIndex = 15;
      chbxTriviaEntries.TabStop = false;
      chbxTriviaEntries.Text = "Trivia Entries (All)";
      chbxTriviaEntries.UseVisualStyleBackColor = true;
      // 
      // chbxAlternateVersions
      // 
      chbxAlternateVersions.AutoSize = true;
      chbxAlternateVersions.Font = new Font("Segoe UI", 9F);
      chbxAlternateVersions.Location = new Point(6, 47);
      chbxAlternateVersions.Name = "chbxAlternateVersions";
      chbxAlternateVersions.Size = new Size(120, 19);
      chbxAlternateVersions.TabIndex = 8;
      chbxAlternateVersions.TabStop = false;
      chbxAlternateVersions.Text = "Alternate Versions";
      chbxAlternateVersions.UseVisualStyleBackColor = true;
      // 
      // chbxMainNews
      // 
      chbxMainNews.AutoSize = true;
      chbxMainNews.Font = new Font("Segoe UI", 9F);
      chbxMainNews.Location = new Point(141, 172);
      chbxMainNews.Name = "chbxMainNews";
      chbxMainNews.Size = new Size(85, 19);
      chbxMainNews.TabIndex = 18;
      chbxMainNews.TabStop = false;
      chbxMainNews.Text = "Main News";
      chbxMainNews.UseVisualStyleBackColor = true;
      // 
      // chbxCrazyCredits
      // 
      chbxCrazyCredits.AutoSize = true;
      chbxCrazyCredits.Font = new Font("Segoe UI", 9F);
      chbxCrazyCredits.Location = new Point(6, 147);
      chbxCrazyCredits.Name = "chbxCrazyCredits";
      chbxCrazyCredits.Size = new Size(95, 19);
      chbxCrazyCredits.TabIndex = 17;
      chbxCrazyCredits.TabStop = false;
      chbxCrazyCredits.Text = "Crazy Credits";
      chbxCrazyCredits.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(chbxNews);
      groupBox2.Controls.Add(chbxUserReviews);
      groupBox2.Controls.Add(lblWarning);
      groupBox2.Controls.Add(nudNews);
      groupBox2.Controls.Add(lblUserReviewsRequests);
      groupBox2.Controls.Add(nudUserReviews);
      groupBox2.Controls.Add(lblNewsRequests);
      groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      groupBox2.Location = new Point(545, 153);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(191, 114);
      groupBox2.TabIndex = 48;
      groupBox2.TabStop = false;
      groupBox2.Text = "High Load";
      // 
      // chbxNews
      // 
      chbxNews.AutoSize = true;
      chbxNews.Font = new Font("Microsoft Sans Serif", 8.25F);
      chbxNews.Location = new Point(6, 22);
      chbxNews.Name = "chbxNews";
      chbxNews.Size = new Size(53, 17);
      chbxNews.TabIndex = 25;
      chbxNews.TabStop = false;
      chbxNews.Text = "News";
      chbxNews.UseVisualStyleBackColor = true;
      // 
      // chbxUserReviews
      // 
      chbxUserReviews.AutoSize = true;
      chbxUserReviews.Font = new Font("Microsoft Sans Serif", 8.25F);
      chbxUserReviews.Location = new Point(6, 47);
      chbxUserReviews.Name = "chbxUserReviews";
      chbxUserReviews.Size = new Size(92, 17);
      chbxUserReviews.TabIndex = 31;
      chbxUserReviews.TabStop = false;
      chbxUserReviews.Text = "User Reviews";
      chbxUserReviews.UseVisualStyleBackColor = true;
      // 
      // lblWarning
      // 
      lblWarning.Font = new Font("Microsoft Sans Serif", 8.25F);
      lblWarning.ForeColor = Color.DarkRed;
      lblWarning.Location = new Point(6, 67);
      lblWarning.Name = "lblWarning";
      lblWarning.Size = new Size(173, 42);
      lblWarning.TabIndex = 46;
      lblWarning.Text = "WARNING:\r\n0 means all entries will be scraped\r\nwhich can take very long!";
      lblWarning.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // nudNews
      // 
      nudNews.Font = new Font("Microsoft Sans Serif", 8.25F);
      nudNews.Location = new Point(98, 21);
      nudNews.Name = "nudNews";
      nudNews.Size = new Size(41, 20);
      nudNews.TabIndex = 36;
      nudNews.TabStop = false;
      nudNews.TextAlign = HorizontalAlignment.Right;
      nudNews.UpDownAlign = LeftRightAlignment.Left;
      nudNews.Value = new decimal(new int[] { 3, 0, 0, 0 });
      // 
      // lblUserReviewsRequests
      // 
      lblUserReviewsRequests.Font = new Font("Microsoft Sans Serif", 8.25F);
      lblUserReviewsRequests.Location = new Point(145, 47);
      lblUserReviewsRequests.Name = "lblUserReviewsRequests";
      lblUserReviewsRequests.Size = new Size(29, 17);
      lblUserReviewsRequests.TabIndex = 45;
      lblUserReviewsRequests.Text = "x 25";
      lblUserReviewsRequests.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // nudUserReviews
      // 
      nudUserReviews.Font = new Font("Microsoft Sans Serif", 8.25F);
      nudUserReviews.Location = new Point(98, 46);
      nudUserReviews.Name = "nudUserReviews";
      nudUserReviews.Size = new Size(41, 20);
      nudUserReviews.TabIndex = 37;
      nudUserReviews.TabStop = false;
      nudUserReviews.TextAlign = HorizontalAlignment.Right;
      nudUserReviews.UpDownAlign = LeftRightAlignment.Left;
      nudUserReviews.Value = new decimal(new int[] { 3, 0, 0, 0 });
      // 
      // lblNewsRequests
      // 
      lblNewsRequests.Font = new Font("Microsoft Sans Serif", 8.25F);
      lblNewsRequests.Location = new Point(145, 22);
      lblNewsRequests.Name = "lblNewsRequests";
      lblNewsRequests.Size = new Size(34, 17);
      lblNewsRequests.TabIndex = 44;
      lblNewsRequests.Text = "x 250";
      lblNewsRequests.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(chbxEpisodesCard);
      groupBox1.Controls.Add(chbxSeasons);
      groupBox1.Controls.Add(chbxNextEpisode);
      groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      groupBox1.Location = new Point(545, 47);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(108, 100);
      groupBox1.TabIndex = 47;
      groupBox1.TabStop = false;
      groupBox1.Text = "Series";
      // 
      // chbxEpisodesCard
      // 
      chbxEpisodesCard.AutoSize = true;
      chbxEpisodesCard.Font = new Font("Segoe UI", 9F);
      chbxEpisodesCard.Location = new Point(6, 22);
      chbxEpisodesCard.Name = "chbxEpisodesCard";
      chbxEpisodesCard.Size = new Size(100, 19);
      chbxEpisodesCard.TabIndex = 21;
      chbxEpisodesCard.TabStop = false;
      chbxEpisodesCard.Text = "Episodes Card";
      chbxEpisodesCard.UseVisualStyleBackColor = true;
      // 
      // chbxSeasons
      // 
      chbxSeasons.AutoSize = true;
      chbxSeasons.Font = new Font("Segoe UI", 9F);
      chbxSeasons.Location = new Point(6, 72);
      chbxSeasons.Name = "chbxSeasons";
      chbxSeasons.Size = new Size(93, 19);
      chbxSeasons.TabIndex = 13;
      chbxSeasons.TabStop = false;
      chbxSeasons.Text = "Seasons (All)";
      chbxSeasons.UseVisualStyleBackColor = true;
      // 
      // chbxNextEpisode
      // 
      chbxNextEpisode.AutoSize = true;
      chbxNextEpisode.Font = new Font("Segoe UI", 9F);
      chbxNextEpisode.Location = new Point(6, 47);
      chbxNextEpisode.Name = "chbxNextEpisode";
      chbxNextEpisode.Size = new Size(95, 19);
      chbxNextEpisode.TabIndex = 26;
      chbxNextEpisode.TabStop = false;
      chbxNextEpisode.Text = "Next Episode";
      chbxNextEpisode.UseVisualStyleBackColor = true;
      // 
      // chbxScrapeEverything
      // 
      chbxScrapeEverything.AutoSize = true;
      chbxScrapeEverything.Font = new Font("Segoe UI", 9F);
      chbxScrapeEverything.Location = new Point(12, 22);
      chbxScrapeEverything.Name = "chbxScrapeEverything";
      chbxScrapeEverything.Size = new Size(82, 19);
      chbxScrapeEverything.TabIndex = 6;
      chbxScrapeEverything.TabStop = false;
      chbxScrapeEverything.Text = "Everything";
      chbxScrapeEverything.UseVisualStyleBackColor = true;
      // 
      // chbxExportJson
      // 
      chbxExportJson.AutoSize = true;
      chbxExportJson.Checked = true;
      chbxExportJson.CheckState = CheckState.Checked;
      chbxExportJson.Font = new Font("Segoe UI", 9F);
      chbxExportJson.Location = new Point(114, 22);
      chbxExportJson.Name = "chbxExportJson";
      chbxExportJson.Size = new Size(102, 19);
      chbxExportJson.TabIndex = 2;
      chbxExportJson.Text = "Export as .json";
      chbxExportJson.UseVisualStyleBackColor = true;
      // 
      // chbxExportTxt
      // 
      chbxExportTxt.AutoSize = true;
      chbxExportTxt.Font = new Font("Segoe UI", 9F);
      chbxExportTxt.Location = new Point(222, 22);
      chbxExportTxt.Name = "chbxExportTxt";
      chbxExportTxt.Size = new Size(165, 19);
      chbxExportTxt.TabIndex = 3;
      chbxExportTxt.Text = "Export as .txt (incomplete)";
      chbxExportTxt.UseVisualStyleBackColor = true;
      // 
      // grbxExport
      // 
      grbxExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      grbxExport.Controls.Add(cbxCountryCode);
      grbxExport.Controls.Add(llblExportFolder);
      grbxExport.Controls.Add(tbxCountryCode);
      grbxExport.Controls.Add(tbxExportFolder);
      grbxExport.Controls.Add(btnProcess);
      grbxExport.Controls.Add(lblCountryCode);
      grbxExport.Controls.Add(btnExportFolder);
      grbxExport.Controls.Add(chbxExportTxt);
      grbxExport.Controls.Add(chbxExportJson);
      grbxExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      grbxExport.Location = new Point(550, 224);
      grbxExport.Name = "grbxExport";
      grbxExport.Size = new Size(742, 117);
      grbxExport.TabIndex = 41;
      grbxExport.TabStop = false;
      grbxExport.Text = "Export Settings";
      // 
      // cbxCountryCode
      // 
      cbxCountryCode.DropDownStyle = ComboBoxStyle.DropDownList;
      cbxCountryCode.Font = new Font("Segoe UI", 9F);
      cbxCountryCode.FormattingEnabled = true;
      cbxCountryCode.Location = new Point(170, 76);
      cbxCountryCode.Name = "cbxCountryCode";
      cbxCountryCode.Size = new Size(294, 23);
      cbxCountryCode.TabIndex = 6;
      // 
      // btnUpdateHashes
      // 
      btnUpdateHashes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnUpdateHashes.Font = new Font("Segoe UI", 9F);
      btnUpdateHashes.Location = new Point(661, 48);
      btnUpdateHashes.Name = "btnUpdateHashes";
      btnUpdateHashes.Size = new Size(75, 23);
      btnUpdateHashes.TabIndex = 11;
      btnUpdateHashes.Text = "Update";
      btnUpdateHashes.UseVisualStyleBackColor = true;
      // 
      // grbxHashes
      // 
      grbxHashes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      grbxHashes.Controls.Add(lblDays);
      grbxHashes.Controls.Add(lblUpdatePeriod);
      grbxHashes.Controls.Add(nudUpdatePeriod);
      grbxHashes.Controls.Add(lblJsonPath);
      grbxHashes.Controls.Add(btnUpdateHashes);
      grbxHashes.Controls.Add(tbxPathToHashFile);
      grbxHashes.Controls.Add(btnPathToHashFile);
      grbxHashes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      grbxHashes.Location = new Point(550, 625);
      grbxHashes.Name = "grbxHashes";
      grbxHashes.Size = new Size(742, 83);
      grbxHashes.TabIndex = 45;
      grbxHashes.TabStop = false;
      grbxHashes.Text = "Hashes";
      // 
      // lblDays
      // 
      lblDays.Font = new Font("Segoe UI", 9F);
      lblDays.Location = new Point(180, 52);
      lblDays.Name = "lblDays";
      lblDays.Size = new Size(44, 17);
      lblDays.TabIndex = 50;
      lblDays.Text = "Days";
      lblDays.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // lblUpdatePeriod
      // 
      lblUpdatePeriod.Font = new Font("Segoe UI", 9F);
      lblUpdatePeriod.Location = new Point(6, 52);
      lblUpdatePeriod.Name = "lblUpdatePeriod";
      lblUpdatePeriod.Size = new Size(102, 17);
      lblUpdatePeriod.TabIndex = 49;
      lblUpdatePeriod.Text = "Update Period";
      lblUpdatePeriod.TextAlign = ContentAlignment.MiddleRight;
      // 
      // nudUpdatePeriod
      // 
      nudUpdatePeriod.Font = new Font("Segoe UI", 9F);
      nudUpdatePeriod.Location = new Point(114, 50);
      nudUpdatePeriod.Name = "nudUpdatePeriod";
      nudUpdatePeriod.Size = new Size(60, 23);
      nudUpdatePeriod.TabIndex = 10;
      nudUpdatePeriod.ThousandsSeparator = true;
      nudUpdatePeriod.Value = new decimal(new int[] { 7, 0, 0, 0 });
      // 
      // lblJsonPath
      // 
      lblJsonPath.Font = new Font("Segoe UI", 9F);
      lblJsonPath.Location = new Point(6, 25);
      lblJsonPath.Name = "lblJsonPath";
      lblJsonPath.Size = new Size(102, 17);
      lblJsonPath.TabIndex = 48;
      lblJsonPath.Text = "Path to .json File";
      lblJsonPath.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxPathToHashFile
      // 
      tbxPathToHashFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxPathToHashFile.Font = new Font("Segoe UI", 9F);
      tbxPathToHashFile.Location = new Point(114, 21);
      tbxPathToHashFile.Name = "tbxPathToHashFile";
      tbxPathToHashFile.Size = new Size(541, 23);
      tbxPathToHashFile.TabIndex = 8;
      // 
      // btnPathToHashFile
      // 
      btnPathToHashFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnPathToHashFile.Font = new Font("Segoe UI", 9F);
      btnPathToHashFile.Location = new Point(661, 19);
      btnPathToHashFile.Name = "btnPathToHashFile";
      btnPathToHashFile.Size = new Size(75, 23);
      btnPathToHashFile.TabIndex = 9;
      btnPathToHashFile.Text = ". . .";
      btnPathToHashFile.UseVisualStyleBackColor = true;
      // 
      // lblSearch
      // 
      lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      lblSearch.Location = new Point(12, 14);
      lblSearch.Name = "lblSearch";
      lblSearch.Size = new Size(49, 17);
      lblSearch.TabIndex = 46;
      lblSearch.Text = "Search";
      lblSearch.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxSearch
      // 
      tbxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxSearch.Font = new Font("Segoe UI", 9F);
      tbxSearch.Location = new Point(67, 12);
      tbxSearch.Name = "tbxSearch";
      tbxSearch.Size = new Size(477, 23);
      tbxSearch.TabIndex = 0;
      // 
      // flpnl
      // 
      flpnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      flpnl.AutoScroll = true;
      flpnl.BorderStyle = BorderStyle.FixedSingle;
      flpnl.Location = new Point(12, 72);
      flpnl.Name = "flpnl";
      flpnl.Size = new Size(532, 634);
      flpnl.TabIndex = 48;
      // 
      // grbxTitles
      // 
      grbxTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      grbxTitles.Controls.Add(dgv);
      grbxTitles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      grbxTitles.Location = new Point(550, 12);
      grbxTitles.Name = "grbxTitles";
      grbxTitles.Size = new Size(742, 206);
      grbxTitles.TabIndex = 49;
      grbxTitles.TabStop = false;
      grbxTitles.Text = "Titles";
      // 
      // dgv
      // 
      dgv.AllowUserToAddRows = false;
      dgv.AllowUserToDeleteRows = false;
      dgv.AllowUserToResizeRows = false;
      dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
      dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = SystemColors.Control;
      dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = SystemColors.Window;
      dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
      dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
      dgv.DefaultCellStyle = dataGridViewCellStyle2;
      dgv.Dock = DockStyle.Fill;
      dgv.Location = new Point(3, 19);
      dgv.MultiSelect = false;
      dgv.Name = "dgv";
      dgv.ReadOnly = true;
      dgv.RowHeadersVisible = false;
      dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgv.Size = new Size(736, 184);
      dgv.TabIndex = 0;
      dgv.TabStop = false;
      // 
      // tbxUrl
      // 
      tbxUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxUrl.Font = new Font("Segoe UI", 9F);
      tbxUrl.Location = new Point(67, 41);
      tbxUrl.Name = "tbxUrl";
      tbxUrl.Size = new Size(477, 23);
      tbxUrl.TabIndex = 1;
      // 
      // lblUrl
      // 
      lblUrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      lblUrl.Location = new Point(12, 43);
      lblUrl.Name = "lblUrl";
      lblUrl.Size = new Size(49, 17);
      lblUrl.TabIndex = 52;
      lblUrl.Text = "URL";
      lblUrl.TextAlign = ContentAlignment.MiddleRight;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1304, 733);
      Controls.Add(lblUrl);
      Controls.Add(tbxUrl);
      Controls.Add(grbxExport);
      Controls.Add(grbxTitles);
      Controls.Add(flpnl);
      Controls.Add(tbxSearch);
      Controls.Add(lblSearch);
      Controls.Add(grbxHashes);
      Controls.Add(grbxScrape);
      Controls.Add(statusStrip);
      FormBorderStyle = FormBorderStyle.Fixed3D;
      Icon = (Icon)resources.GetObject("$this.Icon");
      MinimumSize = new Size(1320, 772);
      Name = "MainForm";
      Text = "IMDb Exporter";
      statusStrip.ResumeLayout(false);
      statusStrip.PerformLayout();
      grbxScrape.ResumeLayout(false);
      grbxScrape.PerformLayout();
      grbxPages.ResumeLayout(false);
      grbxPages.PerformLayout();
      groupBox3.ResumeLayout(false);
      groupBox3.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)nudNews).EndInit();
      ((System.ComponentModel.ISupportInitialize)nudUserReviews).EndInit();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      grbxExport.ResumeLayout(false);
      grbxExport.PerformLayout();
      grbxHashes.ResumeLayout(false);
      grbxHashes.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)nudUpdatePeriod).EndInit();
      grbxTitles.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Button btnProcess;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel lblStatus;
    private ToolStripProgressBar progressBar;
    private Label llblExportFolder;
    private TextBox tbxExportFolder;
    private Button btnExportFolder;
    private Label lblCountryCode;
    private TextBox tbxCountryCode;
    private GroupBox grbxScrape;
    private CheckBox chbxFilmingDates;
    private CheckBox chbxFilmingLocations;
    private CheckBox chbxGoofs;
    private CheckBox chbxKeywords;
    private CheckBox chbxPlotSummaries;
    private CheckBox chbxQuotes;
    private CheckBox chbxExternalSites;
    private CheckBox chbxExternalReviews;
    private CheckBox chbxConnections;
    private CheckBox chbxCompanies;
    private CheckBox chbxAwards;
    private CheckBox chbxAlternateTitles;
    private CheckBox chbxSoundtrack;
    private CheckBox chbxStoryline;
    private CheckBox chbxTechnicalPage;
    private CheckBox chbxTaglines;
    private CheckBox chbxUserReviews;
    private CheckBox chbxReferencePage;
    private CheckBox chbxRatingsPage;
    private CheckBox chbxParentalGuidePage;
    private CheckBox chbxNextEpisode;
    private CheckBox chbxNews;
    private CheckBox chbxMainPage;
    private CheckBox chbxCrew;
    private CheckBox chbxCriticReviews;
    private CheckBox chbxEpisodesCard;
    private CheckBox chbxFAQPage;
    private CheckBox chbxLocationsPage;
    private CheckBox chbxMainNews;
    private CheckBox chbxCrazyCredits;
    private CheckBox chbxAlternateVersions;
    private CheckBox chbxTriviaEntries;
    private CheckBox chbxTopics;
    private CheckBox chbxSeasons;
    private CheckBox chbxReleaseDates;
    private NumericUpDown nudUserReviews;
    private NumericUpDown nudNews;
    private CheckBox chbxScrapeEverything;
    private CheckBox chbxExportJson;
    private CheckBox chbxExportTxt;
    private GroupBox grbxExport;
    private Label lblNewsRequests;
    private Label lblUserReviewsRequests;
    private GroupBox groupBox2;
    private Label lblWarning;
    private GroupBox groupBox1;
    private GroupBox groupBox3;
    private Button btnUpdateHashes;
    private GroupBox grbxHashes;
    private Label lblJsonPath;
    private TextBox tbxPathToHashFile;
    private Button btnPathToHashFile;
    private Label lblDays;
    private Label lblUpdatePeriod;
    private NumericUpDown nudUpdatePeriod;
    private ComboBox cbxCountryCode;
    private Label lblSearch;
    private TextBox tbxSearch;
    private FlowLayoutPanel flpnl;
    private GroupBox grbxTitles;
    private DataGridView dgv;
    private TextBox tbxUrl;
    private Label lblUrl;
    private GroupBox grbxPages;
  }
}