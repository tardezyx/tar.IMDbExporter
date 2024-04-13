using System.ComponentModel;
using System.Drawing.Imaging;
using tar.IMDbScraper.Base;

namespace tar.IMDbExporter.Gui.Custom {
  internal class DataGridViewProgressCell : DataGridViewImageCell {
    #region --- constructor -----------------------------------------------------------------------
    public DataGridViewProgressCell() {
      ValueType = typeof(IMDbTitleProgress);
    }
    #endregion
    #region --- fields ----------------------------------------------------------------------------
    // Used to make custom cell consistent with a DataGridViewImageCell
    private readonly static Image _emptyImage = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
    #endregion

    #region --- get formatted value ---------------------------------------------------------------
    // Method required to make the Progress Cell consistent with the default Image Cell. 
    // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is not an Image.
    protected override object GetFormattedValue(
      object value,
      int rowIndex,
      ref DataGridViewCellStyle cellStyle,
      TypeConverter valueTypeConverter,
      TypeConverter formattedValueTypeConverter,
      DataGridViewDataErrorContexts context
    ) {
      return _emptyImage;
    }
    #endregion
    #region --- paint -----------------------------------------------------------------------------
    protected override void Paint(
      Graphics graphics,
      Rectangle clipBounds,
      Rectangle cellBounds,
      int rowIndex,
      DataGridViewElementStates elementState,
      object value,
      object formattedValue,
      string errorText,
      DataGridViewCellStyle cellStyle,
      DataGridViewAdvancedBorderStyle advancedBorderStyle,
      DataGridViewPaintParts paintParts
    ) {
      try {
        // Draws the cell grid
        base.Paint(
          graphics,
          clipBounds,
          cellBounds,
          rowIndex,
          elementState,
          value,
          formattedValue,
          errorText,
          cellStyle,
          advancedBorderStyle,
          paintParts & ~DataGridViewPaintParts.ContentForeground
        );

        IMDbTitleProgress progress = (IMDbTitleProgress)value;
        float percentage = (float)progress.Value / 100.0f;
        Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
        Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);

        if (percentage > 0.0) {
          // Draw the progress bar and the text
          graphics.FillRectangle(
            new SolidBrush(Color.FromArgb(203, 235, 108)),
            cellBounds.X + 2,
            cellBounds.Y + 2,
            Convert.ToInt32(percentage * cellBounds.Width - 4),
            cellBounds.Height - 4
          );

          graphics.DrawString(
            $"{progress.Value} %: {progress.Description}",
            cellStyle.Font,
            foreColorBrush,
            new RectangleF(
              cellBounds.X + 6,
              cellBounds.Y + 2,
              cellBounds.Width - 6,
              cellBounds.Height - 2
            )
          );
        } else {
          // draw the text
          if (DataGridView is not null && DataGridView.CurrentRow.Index == rowIndex) {
            graphics.DrawString(
              $"{progress.Value} %: {progress.Description}",
              cellStyle.Font,
              new SolidBrush(cellStyle.SelectionForeColor),
              new RectangleF(
                cellBounds.X + 6,
                cellBounds.Y + 2,
                cellBounds.Width - 6,
                cellBounds.Height - 2
              )
            );
          } else {
            graphics.DrawString(
              $"{progress.Value} %: {progress.Description}",
              cellStyle.Font,
              foreColorBrush,
              new RectangleF(
                cellBounds.X + 6,
                cellBounds.Y + 2,
                cellBounds.Width - 6,
                cellBounds.Height - 2
              )
            );
          }
        }
      } catch { }
    }
    #endregion
  }
}