namespace tar.IMDbExporter.Gui.Custom {
  internal class DataGridViewProgressColumn : DataGridViewImageColumn {
    public DataGridViewProgressColumn() {
      CellTemplate = new DataGridViewProgressCell();
    }
  }
}