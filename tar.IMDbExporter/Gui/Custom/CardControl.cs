using System.Diagnostics;
using System.Drawing.Imaging;
using tar.IMDbExporter.Models;

namespace tar.IMDbExporter.Gui.Custom {
  public partial class CardControl : UserControl {
    #region --- constructor -----------------------------------------------------------------------
    public CardControl(SearchResult content) {
      Content = content;
      InitializeComponent();
    }
    #endregion
    #region --- fields ----------------------------------------------------------------------------
    private bool _isHovered = false;
    #endregion
    #region --- properties ------------------------------------------------------------------------
    public SearchResult Content { get; set; }
    #endregion

    #region --- get image with opacity ------------------------------------------------------------
    public Image? GetImageWithOpacity(Image? image, float opacity) {
      if (image is null) {
        return null;
      }

      using ImageAttributes attributes = new();
      attributes.SetColorMatrix(
        new() {
          Matrix33 = opacity
        },
        ColorMatrixFlag.Default,
        ColorAdjustType.Bitmap
      );

      Bitmap result = new(
        image.Width,
        image.Height
      );

      Rectangle resultRectangle = new(
        0,
        0,
        result.Width,
        result.Height
      );

      using Graphics graphics = Graphics.FromImage(result);
      graphics.DrawImage(
        image,
        resultRectangle,
        0,
        0,
        image.Width,
        image.Height,
        GraphicsUnit.Pixel,
        attributes
      );

      return result;
    }
    #endregion
    #region --- on load ---------------------------------------------------------------------------
    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);

      SetStyle(
        ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint,
        true
      );

      pbx.Image     = Content.Image;
      rtbx.Text     = $"{Content.Name}{Environment.NewLine}{Content.Notes}";
      tbxType.Text  = Char.ToUpper(Content.Type[0]) + Content.Type[1..];
      tbxYears.Text = Content.Years;

      rtbx.SelectionStart  = 0;
      rtbx.SelectionLength = Content.Name.Length;
      rtbx.SelectionFont   = new(rtbx.Font.FontFamily, 11f, FontStyle.Bold);
      rtbx.SelectionLength = 0;

      WireEvents();
    }
    #endregion
    #region --- leave picture ---------------------------------------------------------------------
    internal void LeavePicture() {
      if (_isHovered) {
        Point point = PointToClient(Cursor.Position);
        if (!pbx.ClientRectangle.Contains(point)) {
          _isHovered = false;

          pbx.Image = Content.Image;
          Cursor = Cursors.Default;
        }
      }
    }
    #endregion
    #region --- on mouse leave --------------------------------------------------------------------
    protected override void OnMouseLeave(EventArgs e) {
      base.OnMouseLeave(e);

      if (Parent is not null) {
        foreach (var item in Parent.Controls) {
          if (item is CardControl cardControl) {
            cardControl.LeavePicture();
          }
        }
      }
    }
    #endregion
    #region --- wire events -----------------------------------------------------------------------
    private void WireEvents() {
      btnAdd.Click += (s, e) => {
        if (FindForm() is MainForm mainForm) {
          mainForm.AddTitle(Content);
        }
      };

      pbx.Click += (s, e) => {
        Process.Start(
				  new ProcessStartInfo(Content.Url) {
					  UseShellExecute = true
				  }
			  );
      };
      
      pbx.MouseEnter += (s, e) => {
        if (!_isHovered) {
          _isHovered = true;

          pbx.Image = GetImageWithOpacity(Content.Image, 0.5f);
          Cursor = Cursors.Hand;

          if (Parent is not null) {
            foreach (var item in Parent.Controls) {
              if (item is CardControl cardControl && cardControl != this) {
                cardControl.LeavePicture();
              }
            }
          }
        }
      };

      pbx.MouseLeave += (s, e) => {
        LeavePicture();
      };
    }
    #endregion
  }
}