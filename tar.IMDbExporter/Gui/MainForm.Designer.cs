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
      if (disposing && (components != null)) {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      tbxIMDbID = new TextBox();
      lblIMDbID = new Label();
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
      groupBox3 = new GroupBox();
      chbxAlternateTitles = new CheckBox();
      chbxAwards = new CheckBox();
      chbxCompanies = new CheckBox();
      chbxSoundtrack = new CheckBox();
      chbxConnections = new CheckBox();
      chbxExternalReviews = new CheckBox();
      chbxStoryline = new CheckBox();
      chbxExternalSites = new CheckBox();
      chbxTechnicalPage = new CheckBox();
      chbxQuotes = new CheckBox();
      chbxTaglines = new CheckBox();
      chbxPlotSummaries = new CheckBox();
      chbxReferencePage = new CheckBox();
      chbxKeywords = new CheckBox();
      chbxRatingsPage = new CheckBox();
      chbxGoofs = new CheckBox();
      chbxParentalGuidePage = new CheckBox();
      chbxFilmingLocations = new CheckBox();
      chbxMainPage = new CheckBox();
      chbxFilmingDates = new CheckBox();
      chbxCrew = new CheckBox();
      chbxReleaseDates = new CheckBox();
      chbxCriticReviews = new CheckBox();
      chbxTopics = new CheckBox();
      chbxFAQPage = new CheckBox();
      chbxTriviaEntries = new CheckBox();
      chbxLocationsPage = new CheckBox();
      chbxAlternateVersions = new CheckBox();
      chbxMainNews = new CheckBox();
      chbxCrazyCredits = new CheckBox();
      groupBox2 = new GroupBox();
      chbxNews = new CheckBox();
      chbxUserReviews = new CheckBox();
      label1 = new Label();
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
      lblUrl = new Label();
      tbxUrl = new TextBox();
      btnUpdateHashes = new Button();
      grbxHashes = new GroupBox();
      lblDays = new Label();
      lblUpdatePeriod = new Label();
      nudUpdatePeriod = new NumericUpDown();
      lblJsonPath = new Label();
      tbxPathToHashFile = new TextBox();
      btnPathToHashFile = new Button();
      statusStrip.SuspendLayout();
      grbxScrape.SuspendLayout();
      groupBox3.SuspendLayout();
      groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)nudNews).BeginInit();
      ((System.ComponentModel.ISupportInitialize)nudUserReviews).BeginInit();
      groupBox1.SuspendLayout();
      grbxExport.SuspendLayout();
      grbxHashes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)nudUpdatePeriod).BeginInit();
      SuspendLayout();
      // 
      // tbxIMDbID
      // 
      tbxIMDbID.BackColor = Color.PaleGoldenrod;
      tbxIMDbID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
      tbxIMDbID.ForeColor = SystemColors.ControlText;
      tbxIMDbID.Location = new Point(84, 43);
      tbxIMDbID.Name = "tbxIMDbID";
      tbxIMDbID.Size = new Size(102, 25);
      tbxIMDbID.TabIndex = 2;
      // 
      // lblIMDbID
      // 
      lblIMDbID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      lblIMDbID.Location = new Point(12, 47);
      lblIMDbID.Name = "lblIMDbID";
      lblIMDbID.Size = new Size(66, 17);
      lblIMDbID.TabIndex = 1;
      lblIMDbID.Text = "IMDb ID";
      lblIMDbID.TextAlign = ContentAlignment.MiddleRight;
      // 
      // btnProcess
      // 
      btnProcess.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnProcess.BackColor = Color.Gold;
      btnProcess.FlatStyle = FlatStyle.Flat;
      btnProcess.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      btnProcess.Location = new Point(687, 43);
      btnProcess.Name = "btnProcess";
      btnProcess.Size = new Size(75, 29);
      btnProcess.TabIndex = 3;
      btnProcess.Text = "Process";
      btnProcess.UseVisualStyleBackColor = false;
      // 
      // statusStrip
      // 
      statusStrip.ImageScalingSize = new Size(24, 24);
      statusStrip.Items.AddRange(new ToolStripItem[] { progressBar, lblStatus });
      statusStrip.Location = new Point(0, 519);
      statusStrip.Name = "statusStrip";
      statusStrip.Size = new Size(780, 22);
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
      llblExportFolder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      llblExportFolder.Location = new Point(6, 19);
      llblExportFolder.Name = "llblExportFolder";
      llblExportFolder.Size = new Size(102, 17);
      llblExportFolder.TabIndex = 4;
      llblExportFolder.Text = "Export Folder";
      llblExportFolder.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxExportFolder
      // 
      tbxExportFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxExportFolder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      tbxExportFolder.Location = new Point(114, 15);
      tbxExportFolder.Name = "tbxExportFolder";
      tbxExportFolder.Size = new Size(555, 23);
      tbxExportFolder.TabIndex = 0;
      // 
      // btnExportFolder
      // 
      btnExportFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnExportFolder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      btnExportFolder.Location = new Point(675, 15);
      btnExportFolder.Name = "btnExportFolder";
      btnExportFolder.Size = new Size(75, 23);
      btnExportFolder.TabIndex = 1;
      btnExportFolder.Text = ". . .";
      btnExportFolder.UseVisualStyleBackColor = true;
      // 
      // lblCountryCode
      // 
      lblCountryCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      lblCountryCode.Location = new Point(6, 47);
      lblCountryCode.Name = "lblCountryCode";
      lblCountryCode.Size = new Size(102, 17);
      lblCountryCode.TabIndex = 5;
      lblCountryCode.Text = "Country Code";
      lblCountryCode.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxCountryCode
      // 
      tbxCountryCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      tbxCountryCode.Location = new Point(114, 44);
      tbxCountryCode.Name = "tbxCountryCode";
      tbxCountryCode.ReadOnly = true;
      tbxCountryCode.Size = new Size(29, 23);
      tbxCountryCode.TabIndex = 6;
      // 
      // grbxScrape
      // 
      grbxScrape.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      grbxScrape.Controls.Add(groupBox3);
      grbxScrape.Controls.Add(groupBox2);
      grbxScrape.Controls.Add(groupBox1);
      grbxScrape.Controls.Add(chbxScrapeEverything);
      grbxScrape.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      grbxScrape.Location = new Point(12, 157);
      grbxScrape.Name = "grbxScrape";
      grbxScrape.Size = new Size(756, 272);
      grbxScrape.TabIndex = 7;
      grbxScrape.TabStop = false;
      grbxScrape.Text = "Scrape Settings";
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
      groupBox3.Controls.Add(chbxTechnicalPage);
      groupBox3.Controls.Add(chbxQuotes);
      groupBox3.Controls.Add(chbxTaglines);
      groupBox3.Controls.Add(chbxPlotSummaries);
      groupBox3.Controls.Add(chbxReferencePage);
      groupBox3.Controls.Add(chbxKeywords);
      groupBox3.Controls.Add(chbxRatingsPage);
      groupBox3.Controls.Add(chbxGoofs);
      groupBox3.Controls.Add(chbxParentalGuidePage);
      groupBox3.Controls.Add(chbxFilmingLocations);
      groupBox3.Controls.Add(chbxMainPage);
      groupBox3.Controls.Add(chbxFilmingDates);
      groupBox3.Controls.Add(chbxCrew);
      groupBox3.Controls.Add(chbxReleaseDates);
      groupBox3.Controls.Add(chbxCriticReviews);
      groupBox3.Controls.Add(chbxTopics);
      groupBox3.Controls.Add(chbxFAQPage);
      groupBox3.Controls.Add(chbxTriviaEntries);
      groupBox3.Controls.Add(chbxLocationsPage);
      groupBox3.Controls.Add(chbxAlternateVersions);
      groupBox3.Controls.Add(chbxMainNews);
      groupBox3.Controls.Add(chbxCrazyCredits);
      groupBox3.Location = new Point(6, 47);
      groupBox3.Name = "groupBox3";
      groupBox3.Size = new Size(554, 220);
      groupBox3.TabIndex = 49;
      groupBox3.TabStop = false;
      groupBox3.Text = "General";
      // 
      // chbxAlternateTitles
      // 
      chbxAlternateTitles.AutoSize = true;
      chbxAlternateTitles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxAlternateTitles.Location = new Point(6, 22);
      chbxAlternateTitles.Name = "chbxAlternateTitles";
      chbxAlternateTitles.Size = new Size(129, 19);
      chbxAlternateTitles.TabIndex = 0;
      chbxAlternateTitles.Text = "Alternate Titles (All)";
      chbxAlternateTitles.UseVisualStyleBackColor = true;
      // 
      // chbxAwards
      // 
      chbxAwards.AutoSize = true;
      chbxAwards.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxAwards.Location = new Point(6, 72);
      chbxAwards.Name = "chbxAwards";
      chbxAwards.Size = new Size(90, 19);
      chbxAwards.TabIndex = 1;
      chbxAwards.Text = "Awards (All)";
      chbxAwards.UseVisualStyleBackColor = true;
      // 
      // chbxCompanies
      // 
      chbxCompanies.AutoSize = true;
      chbxCompanies.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxCompanies.Location = new Point(6, 97);
      chbxCompanies.Name = "chbxCompanies";
      chbxCompanies.Size = new Size(111, 19);
      chbxCompanies.TabIndex = 2;
      chbxCompanies.Text = "Companies (All)";
      chbxCompanies.UseVisualStyleBackColor = true;
      // 
      // chbxSoundtrack
      // 
      chbxSoundtrack.AutoSize = true;
      chbxSoundtrack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxSoundtrack.Location = new Point(432, 22);
      chbxSoundtrack.Name = "chbxSoundtrack";
      chbxSoundtrack.Size = new Size(86, 19);
      chbxSoundtrack.TabIndex = 35;
      chbxSoundtrack.Text = "Soundtrack";
      chbxSoundtrack.UseVisualStyleBackColor = true;
      // 
      // chbxConnections
      // 
      chbxConnections.AutoSize = true;
      chbxConnections.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxConnections.Location = new Point(6, 122);
      chbxConnections.Name = "chbxConnections";
      chbxConnections.Size = new Size(118, 19);
      chbxConnections.TabIndex = 3;
      chbxConnections.Text = "Connections (All)";
      chbxConnections.UseVisualStyleBackColor = true;
      // 
      // chbxExternalReviews
      // 
      chbxExternalReviews.AutoSize = true;
      chbxExternalReviews.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxExternalReviews.Location = new Point(141, 22);
      chbxExternalReviews.Name = "chbxExternalReviews";
      chbxExternalReviews.Size = new Size(138, 19);
      chbxExternalReviews.TabIndex = 4;
      chbxExternalReviews.Text = "External Reviews (All)";
      chbxExternalReviews.UseVisualStyleBackColor = true;
      // 
      // chbxStoryline
      // 
      chbxStoryline.AutoSize = true;
      chbxStoryline.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxStoryline.Location = new Point(432, 47);
      chbxStoryline.Name = "chbxStoryline";
      chbxStoryline.Size = new Size(72, 19);
      chbxStoryline.TabIndex = 34;
      chbxStoryline.Text = "Storyline";
      chbxStoryline.UseVisualStyleBackColor = true;
      // 
      // chbxExternalSites
      // 
      chbxExternalSites.AutoSize = true;
      chbxExternalSites.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxExternalSites.Location = new Point(141, 47);
      chbxExternalSites.Name = "chbxExternalSites";
      chbxExternalSites.Size = new Size(120, 19);
      chbxExternalSites.TabIndex = 5;
      chbxExternalSites.Text = "External Sites (All)";
      chbxExternalSites.UseVisualStyleBackColor = true;
      // 
      // chbxTechnicalPage
      // 
      chbxTechnicalPage.AutoSize = true;
      chbxTechnicalPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxTechnicalPage.Location = new Point(432, 97);
      chbxTechnicalPage.Name = "chbxTechnicalPage";
      chbxTechnicalPage.Size = new Size(104, 19);
      chbxTechnicalPage.TabIndex = 33;
      chbxTechnicalPage.Text = "Technical Page";
      chbxTechnicalPage.UseVisualStyleBackColor = true;
      // 
      // chbxQuotes
      // 
      chbxQuotes.AutoSize = true;
      chbxQuotes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxQuotes.Location = new Point(292, 122);
      chbxQuotes.Name = "chbxQuotes";
      chbxQuotes.Size = new Size(89, 19);
      chbxQuotes.TabIndex = 6;
      chbxQuotes.Text = "Quotes (All)";
      chbxQuotes.UseVisualStyleBackColor = true;
      // 
      // chbxTaglines
      // 
      chbxTaglines.AutoSize = true;
      chbxTaglines.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxTaglines.Location = new Point(432, 72);
      chbxTaglines.Name = "chbxTaglines";
      chbxTaglines.Size = new Size(68, 19);
      chbxTaglines.TabIndex = 32;
      chbxTaglines.Text = "Taglines";
      chbxTaglines.UseVisualStyleBackColor = true;
      // 
      // chbxPlotSummaries
      // 
      chbxPlotSummaries.AutoSize = true;
      chbxPlotSummaries.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxPlotSummaries.Location = new Point(292, 97);
      chbxPlotSummaries.Name = "chbxPlotSummaries";
      chbxPlotSummaries.Size = new Size(134, 19);
      chbxPlotSummaries.TabIndex = 7;
      chbxPlotSummaries.Text = "Plot Summaries (All)";
      chbxPlotSummaries.UseVisualStyleBackColor = true;
      // 
      // chbxReferencePage
      // 
      chbxReferencePage.AutoSize = true;
      chbxReferencePage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxReferencePage.Location = new Point(292, 172);
      chbxReferencePage.Name = "chbxReferencePage";
      chbxReferencePage.Size = new Size(107, 19);
      chbxReferencePage.TabIndex = 29;
      chbxReferencePage.Text = "Reference Page";
      chbxReferencePage.UseVisualStyleBackColor = true;
      // 
      // chbxKeywords
      // 
      chbxKeywords.AutoSize = true;
      chbxKeywords.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxKeywords.Location = new Point(141, 172);
      chbxKeywords.Name = "chbxKeywords";
      chbxKeywords.Size = new Size(102, 19);
      chbxKeywords.TabIndex = 8;
      chbxKeywords.Text = "Keywords (All)";
      chbxKeywords.UseVisualStyleBackColor = true;
      // 
      // chbxRatingsPage
      // 
      chbxRatingsPage.AutoSize = true;
      chbxRatingsPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxRatingsPage.Location = new Point(292, 147);
      chbxRatingsPage.Name = "chbxRatingsPage";
      chbxRatingsPage.Size = new Size(94, 19);
      chbxRatingsPage.TabIndex = 28;
      chbxRatingsPage.Text = "Ratings Page";
      chbxRatingsPage.UseVisualStyleBackColor = true;
      // 
      // chbxGoofs
      // 
      chbxGoofs.AutoSize = true;
      chbxGoofs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxGoofs.Location = new Point(141, 147);
      chbxGoofs.Name = "chbxGoofs";
      chbxGoofs.Size = new Size(82, 19);
      chbxGoofs.TabIndex = 9;
      chbxGoofs.Text = "Goofs (All)";
      chbxGoofs.UseVisualStyleBackColor = true;
      // 
      // chbxParentalGuidePage
      // 
      chbxParentalGuidePage.AutoSize = true;
      chbxParentalGuidePage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxParentalGuidePage.Location = new Point(292, 72);
      chbxParentalGuidePage.Name = "chbxParentalGuidePage";
      chbxParentalGuidePage.Size = new Size(132, 19);
      chbxParentalGuidePage.TabIndex = 27;
      chbxParentalGuidePage.Text = "Parental Guide Page";
      chbxParentalGuidePage.UseVisualStyleBackColor = true;
      // 
      // chbxFilmingLocations
      // 
      chbxFilmingLocations.AutoSize = true;
      chbxFilmingLocations.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxFilmingLocations.Location = new Point(141, 122);
      chbxFilmingLocations.Name = "chbxFilmingLocations";
      chbxFilmingLocations.Size = new Size(145, 19);
      chbxFilmingLocations.TabIndex = 10;
      chbxFilmingLocations.Text = "Filming Locations (All)";
      chbxFilmingLocations.UseVisualStyleBackColor = true;
      // 
      // chbxMainPage
      // 
      chbxMainPage.AutoSize = true;
      chbxMainPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxMainPage.Location = new Point(292, 47);
      chbxMainPage.Name = "chbxMainPage";
      chbxMainPage.Size = new Size(82, 19);
      chbxMainPage.TabIndex = 24;
      chbxMainPage.Text = "Main Page";
      chbxMainPage.UseVisualStyleBackColor = true;
      // 
      // chbxFilmingDates
      // 
      chbxFilmingDates.AutoSize = true;
      chbxFilmingDates.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxFilmingDates.Location = new Point(141, 97);
      chbxFilmingDates.Name = "chbxFilmingDates";
      chbxFilmingDates.Size = new Size(123, 19);
      chbxFilmingDates.TabIndex = 11;
      chbxFilmingDates.Text = "Filming Dates (All)";
      chbxFilmingDates.UseVisualStyleBackColor = true;
      // 
      // chbxCrew
      // 
      chbxCrew.AutoSize = true;
      chbxCrew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxCrew.Location = new Point(6, 172);
      chbxCrew.Name = "chbxCrew";
      chbxCrew.Size = new Size(53, 19);
      chbxCrew.TabIndex = 23;
      chbxCrew.Text = "Crew";
      chbxCrew.UseVisualStyleBackColor = true;
      // 
      // chbxReleaseDates
      // 
      chbxReleaseDates.AutoSize = true;
      chbxReleaseDates.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxReleaseDates.Location = new Point(292, 197);
      chbxReleaseDates.Name = "chbxReleaseDates";
      chbxReleaseDates.Size = new Size(122, 19);
      chbxReleaseDates.TabIndex = 12;
      chbxReleaseDates.Text = "Release Dates (All)";
      chbxReleaseDates.UseVisualStyleBackColor = true;
      // 
      // chbxCriticReviews
      // 
      chbxCriticReviews.AutoSize = true;
      chbxCriticReviews.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxCriticReviews.Location = new Point(6, 197);
      chbxCriticReviews.Name = "chbxCriticReviews";
      chbxCriticReviews.Size = new Size(99, 19);
      chbxCriticReviews.TabIndex = 22;
      chbxCriticReviews.Text = "Critic Reviews";
      chbxCriticReviews.UseVisualStyleBackColor = true;
      // 
      // chbxTopics
      // 
      chbxTopics.AutoSize = true;
      chbxTopics.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxTopics.Location = new Point(432, 122);
      chbxTopics.Name = "chbxTopics";
      chbxTopics.Size = new Size(84, 19);
      chbxTopics.TabIndex = 14;
      chbxTopics.Text = "Topics (All)";
      chbxTopics.UseVisualStyleBackColor = true;
      // 
      // chbxFAQPage
      // 
      chbxFAQPage.AutoSize = true;
      chbxFAQPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxFAQPage.Location = new Point(141, 72);
      chbxFAQPage.Name = "chbxFAQPage";
      chbxFAQPage.Size = new Size(77, 19);
      chbxFAQPage.TabIndex = 20;
      chbxFAQPage.Text = "FAQ Page";
      chbxFAQPage.UseVisualStyleBackColor = true;
      // 
      // chbxTriviaEntries
      // 
      chbxTriviaEntries.AutoSize = true;
      chbxTriviaEntries.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxTriviaEntries.Location = new Point(432, 147);
      chbxTriviaEntries.Name = "chbxTriviaEntries";
      chbxTriviaEntries.Size = new Size(116, 19);
      chbxTriviaEntries.TabIndex = 15;
      chbxTriviaEntries.Text = "Trivia Entries (All)";
      chbxTriviaEntries.UseVisualStyleBackColor = true;
      // 
      // chbxLocationsPage
      // 
      chbxLocationsPage.AutoSize = true;
      chbxLocationsPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxLocationsPage.Location = new Point(141, 197);
      chbxLocationsPage.Name = "chbxLocationsPage";
      chbxLocationsPage.Size = new Size(106, 19);
      chbxLocationsPage.TabIndex = 19;
      chbxLocationsPage.Text = "Locations Page";
      chbxLocationsPage.UseVisualStyleBackColor = true;
      // 
      // chbxAlternateVersions
      // 
      chbxAlternateVersions.AutoSize = true;
      chbxAlternateVersions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxAlternateVersions.Location = new Point(6, 47);
      chbxAlternateVersions.Name = "chbxAlternateVersions";
      chbxAlternateVersions.Size = new Size(120, 19);
      chbxAlternateVersions.TabIndex = 16;
      chbxAlternateVersions.Text = "Alternate Versions";
      chbxAlternateVersions.UseVisualStyleBackColor = true;
      // 
      // chbxMainNews
      // 
      chbxMainNews.AutoSize = true;
      chbxMainNews.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxMainNews.Location = new Point(292, 22);
      chbxMainNews.Name = "chbxMainNews";
      chbxMainNews.Size = new Size(85, 19);
      chbxMainNews.TabIndex = 18;
      chbxMainNews.Text = "Main News";
      chbxMainNews.UseVisualStyleBackColor = true;
      // 
      // chbxCrazyCredits
      // 
      chbxCrazyCredits.AutoSize = true;
      chbxCrazyCredits.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxCrazyCredits.Location = new Point(6, 147);
      chbxCrazyCredits.Name = "chbxCrazyCredits";
      chbxCrazyCredits.Size = new Size(95, 19);
      chbxCrazyCredits.TabIndex = 17;
      chbxCrazyCredits.Text = "Crazy Credits";
      chbxCrazyCredits.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(chbxNews);
      groupBox2.Controls.Add(chbxUserReviews);
      groupBox2.Controls.Add(label1);
      groupBox2.Controls.Add(nudNews);
      groupBox2.Controls.Add(lblUserReviewsRequests);
      groupBox2.Controls.Add(nudUserReviews);
      groupBox2.Controls.Add(lblNewsRequests);
      groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      groupBox2.Location = new Point(566, 153);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(191, 114);
      groupBox2.TabIndex = 48;
      groupBox2.TabStop = false;
      groupBox2.Text = "High Load";
      // 
      // chbxNews
      // 
      chbxNews.AutoSize = true;
      chbxNews.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      chbxNews.Location = new Point(6, 22);
      chbxNews.Name = "chbxNews";
      chbxNews.Size = new Size(53, 17);
      chbxNews.TabIndex = 25;
      chbxNews.Text = "News";
      chbxNews.UseVisualStyleBackColor = true;
      // 
      // chbxUserReviews
      // 
      chbxUserReviews.AutoSize = true;
      chbxUserReviews.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      chbxUserReviews.Location = new Point(6, 47);
      chbxUserReviews.Name = "chbxUserReviews";
      chbxUserReviews.Size = new Size(92, 17);
      chbxUserReviews.TabIndex = 31;
      chbxUserReviews.Text = "User Reviews";
      chbxUserReviews.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      label1.ForeColor = Color.DarkRed;
      label1.Location = new Point(6, 67);
      label1.Name = "label1";
      label1.Size = new Size(173, 42);
      label1.TabIndex = 46;
      label1.Text = "0 means:\r\nall entries will be scraped";
      label1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // nudNews
      // 
      nudNews.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      nudNews.Location = new Point(98, 21);
      nudNews.Name = "nudNews";
      nudNews.Size = new Size(41, 20);
      nudNews.TabIndex = 36;
      nudNews.TextAlign = HorizontalAlignment.Right;
      nudNews.UpDownAlign = LeftRightAlignment.Left;
      nudNews.Value = new decimal(new int[] { 3, 0, 0, 0 });
      // 
      // lblUserReviewsRequests
      // 
      lblUserReviewsRequests.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      lblUserReviewsRequests.Location = new Point(145, 47);
      lblUserReviewsRequests.Name = "lblUserReviewsRequests";
      lblUserReviewsRequests.Size = new Size(29, 17);
      lblUserReviewsRequests.TabIndex = 45;
      lblUserReviewsRequests.Text = "x 25";
      lblUserReviewsRequests.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // nudUserReviews
      // 
      nudUserReviews.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      nudUserReviews.Location = new Point(98, 46);
      nudUserReviews.Name = "nudUserReviews";
      nudUserReviews.Size = new Size(41, 20);
      nudUserReviews.TabIndex = 37;
      nudUserReviews.TextAlign = HorizontalAlignment.Right;
      nudUserReviews.UpDownAlign = LeftRightAlignment.Left;
      nudUserReviews.Value = new decimal(new int[] { 3, 0, 0, 0 });
      // 
      // lblNewsRequests
      // 
      lblNewsRequests.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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
      groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      groupBox1.Location = new Point(566, 47);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(108, 100);
      groupBox1.TabIndex = 47;
      groupBox1.TabStop = false;
      groupBox1.Text = "Series";
      // 
      // chbxEpisodesCard
      // 
      chbxEpisodesCard.AutoSize = true;
      chbxEpisodesCard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxEpisodesCard.Location = new Point(6, 22);
      chbxEpisodesCard.Name = "chbxEpisodesCard";
      chbxEpisodesCard.Size = new Size(100, 19);
      chbxEpisodesCard.TabIndex = 21;
      chbxEpisodesCard.Text = "Episodes Card";
      chbxEpisodesCard.UseVisualStyleBackColor = true;
      // 
      // chbxSeasons
      // 
      chbxSeasons.AutoSize = true;
      chbxSeasons.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxSeasons.Location = new Point(6, 72);
      chbxSeasons.Name = "chbxSeasons";
      chbxSeasons.Size = new Size(93, 19);
      chbxSeasons.TabIndex = 13;
      chbxSeasons.Text = "Seasons (All)";
      chbxSeasons.UseVisualStyleBackColor = true;
      // 
      // chbxNextEpisode
      // 
      chbxNextEpisode.AutoSize = true;
      chbxNextEpisode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxNextEpisode.Location = new Point(6, 47);
      chbxNextEpisode.Name = "chbxNextEpisode";
      chbxNextEpisode.Size = new Size(95, 19);
      chbxNextEpisode.TabIndex = 26;
      chbxNextEpisode.Text = "Next Episode";
      chbxNextEpisode.UseVisualStyleBackColor = true;
      // 
      // chbxScrapeEverything
      // 
      chbxScrapeEverything.AutoSize = true;
      chbxScrapeEverything.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      chbxScrapeEverything.Location = new Point(12, 22);
      chbxScrapeEverything.Name = "chbxScrapeEverything";
      chbxScrapeEverything.Size = new Size(82, 19);
      chbxScrapeEverything.TabIndex = 38;
      chbxScrapeEverything.Text = "Everything";
      chbxScrapeEverything.UseVisualStyleBackColor = true;
      // 
      // chbxExportJson
      // 
      chbxExportJson.AutoSize = true;
      chbxExportJson.Checked = true;
      chbxExportJson.CheckState = CheckState.Checked;
      chbxExportJson.Location = new Point(192, 47);
      chbxExportJson.Name = "chbxExportJson";
      chbxExportJson.Size = new Size(102, 19);
      chbxExportJson.TabIndex = 39;
      chbxExportJson.Text = "Export as .json";
      chbxExportJson.UseVisualStyleBackColor = true;
      // 
      // chbxExportTxt
      // 
      chbxExportTxt.AutoSize = true;
      chbxExportTxt.Location = new Point(300, 47);
      chbxExportTxt.Name = "chbxExportTxt";
      chbxExportTxt.Size = new Size(165, 19);
      chbxExportTxt.TabIndex = 40;
      chbxExportTxt.Text = "Export as .txt (incomplete)";
      chbxExportTxt.UseVisualStyleBackColor = true;
      // 
      // grbxExport
      // 
      grbxExport.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      grbxExport.Controls.Add(cbxCountryCode);
      grbxExport.Controls.Add(llblExportFolder);
      grbxExport.Controls.Add(tbxCountryCode);
      grbxExport.Controls.Add(tbxExportFolder);
      grbxExport.Controls.Add(lblCountryCode);
      grbxExport.Controls.Add(btnExportFolder);
      grbxExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      grbxExport.Location = new Point(12, 74);
      grbxExport.Name = "grbxExport";
      grbxExport.Size = new Size(756, 77);
      grbxExport.TabIndex = 41;
      grbxExport.TabStop = false;
      grbxExport.Text = "Export Settings";
      // 
      // cbxCountryCode
      // 
      cbxCountryCode.DropDownStyle = ComboBoxStyle.DropDownList;
      cbxCountryCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      cbxCountryCode.FormattingEnabled = true;
      cbxCountryCode.Location = new Point(149, 44);
      cbxCountryCode.Name = "cbxCountryCode";
      cbxCountryCode.Size = new Size(294, 23);
      cbxCountryCode.TabIndex = 7;
      // 
      // lblUrl
      // 
      lblUrl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      lblUrl.Location = new Point(12, 16);
      lblUrl.Name = "lblUrl";
      lblUrl.Size = new Size(66, 17);
      lblUrl.TabIndex = 42;
      lblUrl.Text = "URL";
      lblUrl.TextAlign = ContentAlignment.MiddleRight;
      // 
      // tbxUrl
      // 
      tbxUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxUrl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
      tbxUrl.Location = new Point(84, 12);
      tbxUrl.Name = "tbxUrl";
      tbxUrl.Size = new Size(684, 25);
      tbxUrl.TabIndex = 43;
      // 
      // btnUpdateHashes
      // 
      btnUpdateHashes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnUpdateHashes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      btnUpdateHashes.Location = new Point(679, 50);
      btnUpdateHashes.Name = "btnUpdateHashes";
      btnUpdateHashes.Size = new Size(75, 23);
      btnUpdateHashes.TabIndex = 44;
      btnUpdateHashes.Text = "Update";
      btnUpdateHashes.UseVisualStyleBackColor = true;
      // 
      // grbxHashes
      // 
      grbxHashes.Controls.Add(lblDays);
      grbxHashes.Controls.Add(lblUpdatePeriod);
      grbxHashes.Controls.Add(nudUpdatePeriod);
      grbxHashes.Controls.Add(lblJsonPath);
      grbxHashes.Controls.Add(btnUpdateHashes);
      grbxHashes.Controls.Add(tbxPathToHashFile);
      grbxHashes.Controls.Add(btnPathToHashFile);
      grbxHashes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      grbxHashes.Location = new Point(12, 435);
      grbxHashes.Name = "grbxHashes";
      grbxHashes.Size = new Size(760, 83);
      grbxHashes.TabIndex = 45;
      grbxHashes.TabStop = false;
      grbxHashes.Text = "Hashes";
      // 
      // lblDays
      // 
      lblDays.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      lblDays.Location = new Point(180, 52);
      lblDays.Name = "lblDays";
      lblDays.Size = new Size(44, 17);
      lblDays.TabIndex = 50;
      lblDays.Text = "Days";
      lblDays.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // lblUpdatePeriod
      // 
      lblUpdatePeriod.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      lblUpdatePeriod.Location = new Point(6, 52);
      lblUpdatePeriod.Name = "lblUpdatePeriod";
      lblUpdatePeriod.Size = new Size(102, 17);
      lblUpdatePeriod.TabIndex = 49;
      lblUpdatePeriod.Text = "Update Period";
      lblUpdatePeriod.TextAlign = ContentAlignment.MiddleRight;
      // 
      // nudUpdatePeriod
      // 
      nudUpdatePeriod.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      nudUpdatePeriod.Location = new Point(114, 50);
      nudUpdatePeriod.Name = "nudUpdatePeriod";
      nudUpdatePeriod.Size = new Size(60, 23);
      nudUpdatePeriod.TabIndex = 49;
      nudUpdatePeriod.ThousandsSeparator = true;
      nudUpdatePeriod.Value = new decimal(new int[] { 7, 0, 0, 0 });
      // 
      // lblJsonPath
      // 
      lblJsonPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
      tbxPathToHashFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      tbxPathToHashFile.Location = new Point(114, 21);
      tbxPathToHashFile.Name = "tbxPathToHashFile";
      tbxPathToHashFile.Size = new Size(559, 23);
      tbxPathToHashFile.TabIndex = 46;
      // 
      // btnPathToHashFile
      // 
      btnPathToHashFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnPathToHashFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
      btnPathToHashFile.Location = new Point(679, 21);
      btnPathToHashFile.Name = "btnPathToHashFile";
      btnPathToHashFile.Size = new Size(75, 23);
      btnPathToHashFile.TabIndex = 47;
      btnPathToHashFile.Text = ". . .";
      btnPathToHashFile.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(780, 541);
      Controls.Add(grbxHashes);
      Controls.Add(btnProcess);
      Controls.Add(lblUrl);
      Controls.Add(chbxExportTxt);
      Controls.Add(tbxUrl);
      Controls.Add(grbxExport);
      Controls.Add(chbxExportJson);
      Controls.Add(grbxScrape);
      Controls.Add(statusStrip);
      Controls.Add(lblIMDbID);
      Controls.Add(tbxIMDbID);
      FormBorderStyle = FormBorderStyle.Fixed3D;
      Icon = (Icon)resources.GetObject("$this.Icon");
      MaximumSize = new Size(800, 584);
      MinimumSize = new Size(800, 584);
      Name = "MainForm";
      Text = "IMDb Exporter";
      statusStrip.ResumeLayout(false);
      statusStrip.PerformLayout();
      grbxScrape.ResumeLayout(false);
      grbxScrape.PerformLayout();
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
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox tbxIMDbID;
    private Label lblIMDbID;
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
    private Label lblUrl;
    private TextBox tbxUrl;
    private Label lblNewsRequests;
    private Label lblUserReviewsRequests;
    private GroupBox groupBox2;
    private Label label1;
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
  }
}