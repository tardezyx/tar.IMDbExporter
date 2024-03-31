using tar.IMDbExporter.Gui;

namespace tar.IMDbExporter.Base {
  internal static class Program {
    [STAThread]
    static void Main(string[] args) {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
      Application.Run(new MainForm(args));
    }
  }
}