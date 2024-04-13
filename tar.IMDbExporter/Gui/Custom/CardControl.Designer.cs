namespace tar.IMDbExporter.Gui.Custom {
  partial class CardControl {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent() {
      pbx = new PictureBox();
      tbxType = new TextBox();
      rtbx = new RichTextBox();
      btnAdd = new Button();
      tbxYears = new TextBox();
      ((System.ComponentModel.ISupportInitialize)pbx).BeginInit();
      SuspendLayout();
      // 
      // pbx
      // 
      pbx.Location = new Point(3, 3);
      pbx.Name = "pbx";
      pbx.Size = new Size(100, 148);
      pbx.TabIndex = 0;
      pbx.TabStop = false;
      // 
      // tbxType
      // 
      tbxType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbxType.BackColor = Color.Beige;
      tbxType.BorderStyle = BorderStyle.None;
      tbxType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      tbxType.ForeColor = Color.DarkSlateGray;
      tbxType.Location = new Point(109, 3);
      tbxType.Name = "tbxType";
      tbxType.ReadOnly = true;
      tbxType.Size = new Size(79, 16);
      tbxType.TabIndex = 8;
      tbxType.Text = "TV Series";
      // 
      // rtbx
      // 
      rtbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      rtbx.BackColor = Color.Beige;
      rtbx.BorderStyle = BorderStyle.None;
      rtbx.ForeColor = SystemColors.ControlText;
      rtbx.Location = new Point(109, 29);
      rtbx.Name = "rtbx";
      rtbx.ReadOnly = true;
      rtbx.Size = new Size(147, 91);
      rtbx.TabIndex = 12;
      rtbx.Text = "";
      // 
      // btnAdd
      // 
      btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btnAdd.ForeColor = SystemColors.ControlText;
      btnAdd.Location = new Point(109, 126);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(147, 23);
      btnAdd.TabIndex = 13;
      btnAdd.Text = "Add to list";
      btnAdd.UseVisualStyleBackColor = true;
      // 
      // tbxYears
      // 
      tbxYears.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      tbxYears.BackColor = Color.Beige;
      tbxYears.BorderStyle = BorderStyle.None;
      tbxYears.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      tbxYears.ForeColor = Color.DarkSlateGray;
      tbxYears.Location = new Point(194, 3);
      tbxYears.Name = "tbxYears";
      tbxYears.ReadOnly = true;
      tbxYears.Size = new Size(62, 16);
      tbxYears.TabIndex = 14;
      tbxYears.Text = "1990-2010";
      tbxYears.TextAlign = HorizontalAlignment.Right;
      // 
      // CardControl
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.Beige;
      BorderStyle = BorderStyle.FixedSingle;
      Controls.Add(tbxYears);
      Controls.Add(btnAdd);
      Controls.Add(rtbx);
      Controls.Add(tbxType);
      Controls.Add(pbx);
      MaximumSize = new Size(400, 154);
      Name = "CardControl";
      Size = new Size(259, 152);
      ((System.ComponentModel.ISupportInitialize)pbx).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private PictureBox pbx;
    private TextBox tbxType;
    private RichTextBox rtbx;
    private Button btnAdd;
    private TextBox tbxYears;
  }
}
