using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace tar.IMDbExporter.Base {
  internal class Settings {
    #region --- local class: stored settings ------------------------------------------------------
    internal class StoredSettings {
      public string ExportFolder             { get; set; } = Path.Combine(Application.StartupPath, "Export");
      public string PathToHashFile           { get; set; } = Path.Combine(Application.StartupPath, "Data", "IMDbHashes.json");
      public int    UpdateHashesPeriodInDays { get; set; } = 7;
    }
    #endregion
    #region --- constructor: singleton ------------------------------------------------------------
    static Settings() {
      _instance = new Settings();
    }
    #endregion
    #region --- fields ----------------------------------------------------------------------------
    private static readonly Settings       _instance;
    private                 StoredSettings _storedSettings = new();
    #endregion
    #region --- properties ------------------------------------------------------------------------
    internal static Settings       Current { get { return _instance; } }
    internal        StoredSettings Stored  { get => _storedSettings; set => _storedSettings = value; }
    #endregion

    #region --- check before save -----------------------------------------------------------------
    internal void CheckBeforeSave() {
      string settingsPath = GetSettingsPath();

      StoredSettings? oldSettings = null;

      try {
        string json = File.ReadAllText(settingsPath);

        oldSettings = JsonSerializer.Deserialize<StoredSettings>(json);
      } catch { }

      if (
        oldSettings is not null
        && oldSettings.ExportFolder.Equals(_storedSettings.ExportFolder)
        && oldSettings.PathToHashFile.Equals(_storedSettings.PathToHashFile)
        && oldSettings.UpdateHashesPeriodInDays.Equals(_storedSettings.UpdateHashesPeriodInDays)
      ) {
        return;
      }

      DialogResult dialogResult = MessageBox.Show(
        $"Settings have been changed.{Environment.NewLine}"
        + "Do you want to save those?",
        "Save Settings?",
        MessageBoxButtons.YesNo
      );

      if (dialogResult == DialogResult.Yes) {
        Save();
      }
    }
    #endregion
    #region --- get settings path -----------------------------------------------------------------
    private static string GetSettingsPath() {
      return Path.Combine(
        Application.StartupPath,
        "Data",
        "IMDbExporter.json"
      );
    }
    #endregion
    #region --- load ------------------------------------------------------------------------------
    internal void Load() {
      string settingsPath = GetSettingsPath();

      if (!File.Exists(settingsPath)) {
        return;
      }

      try {
        string json = File.ReadAllText(settingsPath);

        _storedSettings = JsonSerializer.Deserialize<StoredSettings>(json)!;
      } catch { }
    }
    #endregion
    #region --- save ------------------------------------------------------------------------------
    internal void Save() {
      string settingsPath = GetSettingsPath();

      try {
        Directory.CreateDirectory(
          settingsPath.Remove(
            settingsPath.LastIndexOf(Path.DirectorySeparatorChar)
          )
        );

        TextEncoderSettings encoderSettings = new();
        encoderSettings.AllowRange(UnicodeRanges.All);

        JsonSerializerOptions options = new() {
          Encoder = JavaScriptEncoder.Create(encoderSettings),
          WriteIndented = true
        };

        string json = JsonSerializer.Serialize(_storedSettings, options);

        File.WriteAllText(settingsPath, json);
      } catch {
        string nl = Environment.NewLine;

        MessageBox.Show(
          $"Default settings could not be written into file:{nl}"
          + $"{settingsPath}{nl}{nl}"
          + "Please restart app as administrator!",
          "File error"
        );

        //Environment.Exit(1);
      }
    }
    #endregion
  }
}