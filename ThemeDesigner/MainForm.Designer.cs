namespace ThemeDesigner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			ThemeList = new ListBox();
			ThemeName = new TextBox();
			NewThemeButton = new Button();
			groupBox1 = new GroupBox();
			HighlightPressed = new Button();
			label7 = new Label();
			FrameHighlight = new Button();
			label6 = new Label();
			CornerRadius = new NumericUpDown();
			label5 = new Label();
			FrameColor = new Button();
			label4 = new Label();
			BorderSize = new NumericUpDown();
			label3 = new Label();
			CaptionHeight = new NumericUpDown();
			label2 = new Label();
			label1 = new Label();
			colorDialog1 = new ColorDialog();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CornerRadius).BeginInit();
			((System.ComponentModel.ISupportInitialize)BorderSize).BeginInit();
			((System.ComponentModel.ISupportInitialize)CaptionHeight).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(ThemeList);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(ThemeName);
			splitContainer1.Panel2.Controls.Add(NewThemeButton);
			splitContainer1.Panel2.Controls.Add(groupBox1);
			splitContainer1.Panel2.Controls.Add(label1);
			splitContainer1.Size = new Size(993, 450);
			splitContainer1.SplitterDistance = 127;
			splitContainer1.TabIndex = 0;
			// 
			// ThemeList
			// 
			ThemeList.BorderStyle = BorderStyle.None;
			ThemeList.Dock = DockStyle.Fill;
			ThemeList.FormattingEnabled = true;
			ThemeList.ItemHeight = 15;
			ThemeList.Location = new Point(0, 0);
			ThemeList.Margin = new Padding(0);
			ThemeList.Name = "ThemeList";
			ThemeList.Size = new Size(127, 450);
			ThemeList.TabIndex = 0;
			ThemeList.SelectedIndexChanged += OnThemeSelected;
			// 
			// ThemeName
			// 
			ThemeName.Location = new Point(60, 6);
			ThemeName.Name = "ThemeName";
			ThemeName.Size = new Size(303, 23);
			ThemeName.TabIndex = 4;
			ThemeName.TextChanged += OnThemeNameChanged;
			// 
			// NewThemeButton
			// 
			NewThemeButton.Location = new Point(716, 5);
			NewThemeButton.Name = "NewThemeButton";
			NewThemeButton.Size = new Size(118, 23);
			NewThemeButton.TabIndex = 3;
			NewThemeButton.Text = "Add new theme";
			NewThemeButton.UseVisualStyleBackColor = true;
			NewThemeButton.Click += OnAddNewTheme;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(HighlightPressed);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(FrameHighlight);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(CornerRadius);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(FrameColor);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(BorderSize);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(CaptionHeight);
			groupBox1.Controls.Add(label2);
			groupBox1.Location = new Point(15, 40);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(819, 205);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Frame Attributes";
			// 
			// HighlightPressed
			// 
			HighlightPressed.BackColor = SystemColors.ActiveCaption;
			HighlightPressed.FlatStyle = FlatStyle.Flat;
			HighlightPressed.Location = new Point(344, 91);
			HighlightPressed.Margin = new Padding(0);
			HighlightPressed.Name = "HighlightPressed";
			HighlightPressed.Size = new Size(23, 23);
			HighlightPressed.TabIndex = 11;
			HighlightPressed.UseVisualStyleBackColor = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(241, 97);
			label7.Name = "label7";
			label7.Size = new Size(100, 15);
			label7.TabIndex = 10;
			label7.Text = "Highlight Pressed";
			// 
			// FrameHighlight
			// 
			FrameHighlight.BackColor = SystemColors.ActiveCaption;
			FrameHighlight.FlatStyle = FlatStyle.Flat;
			FrameHighlight.Location = new Point(344, 62);
			FrameHighlight.Margin = new Padding(0);
			FrameHighlight.Name = "FrameHighlight";
			FrameHighlight.Size = new Size(23, 23);
			FrameHighlight.TabIndex = 9;
			FrameHighlight.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(241, 66);
			label6.Name = "label6";
			label6.Size = new Size(57, 15);
			label6.TabIndex = 8;
			label6.Text = "Highlight";
			// 
			// CornerRadius
			// 
			CornerRadius.Location = new Point(128, 93);
			CornerRadius.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			CornerRadius.Name = "CornerRadius";
			CornerRadius.Size = new Size(55, 23);
			CornerRadius.TabIndex = 7;
			CornerRadius.Value = new decimal(new int[] { 10, 0, 0, 0 });
			CornerRadius.ValueChanged += OnCornerRadiusChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(10, 95);
			label5.Name = "label5";
			label5.Size = new Size(112, 15);
			label5.TabIndex = 6;
			label5.Text = "Frame corner radius";
			// 
			// FrameColor
			// 
			FrameColor.BackColor = SystemColors.ActiveCaption;
			FrameColor.FlatStyle = FlatStyle.Flat;
			FrameColor.Location = new Point(344, 33);
			FrameColor.Margin = new Padding(0);
			FrameColor.Name = "FrameColor";
			FrameColor.Size = new Size(23, 23);
			FrameColor.TabIndex = 5;
			FrameColor.TextAlign = ContentAlignment.BottomRight;
			FrameColor.UseVisualStyleBackColor = false;
			FrameColor.Click += OnFrameColorClicked;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(241, 37);
			label4.Name = "label4";
			label4.Size = new Size(72, 15);
			label4.TabIndex = 4;
			label4.Text = "Frame Color";
			// 
			// BorderSize
			// 
			BorderSize.Location = new Point(128, 64);
			BorderSize.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			BorderSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			BorderSize.Name = "BorderSize";
			BorderSize.Size = new Size(55, 23);
			BorderSize.TabIndex = 3;
			BorderSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
			BorderSize.ValueChanged += OnBorderSizeChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(10, 66);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 2;
			label3.Text = "Border Size";
			// 
			// CaptionHeight
			// 
			CaptionHeight.Location = new Point(128, 35);
			CaptionHeight.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
			CaptionHeight.Name = "CaptionHeight";
			CaptionHeight.Size = new Size(55, 23);
			CaptionHeight.TabIndex = 1;
			CaptionHeight.Value = new decimal(new int[] { 20, 0, 0, 0 });
			CaptionHeight.ValueChanged += OnCaptionHeightChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(10, 37);
			label2.Name = "label2";
			label2.Size = new Size(88, 15);
			label2.TabIndex = 0;
			label2.Text = "Caption Height";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 9);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(993, 450);
			Controls.Add(splitContainer1);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "MainForm";
			Text = "Theme Designer";
			Load += OnLoad;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)CornerRadius).EndInit();
			((System.ComponentModel.ISupportInitialize)BorderSize).EndInit();
			((System.ComponentModel.ISupportInitialize)CaptionHeight).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private ListBox ThemeList;
		private GroupBox groupBox1;
		private Label label4;
		private NumericUpDown BorderSize;
		private Label label3;
		private NumericUpDown CaptionHeight;
		private Label label2;
		private Label label1;
		private Button FrameColor;
		private ColorDialog colorDialog1;
		private Button NewThemeButton;
		private TextBox ThemeName;
		private NumericUpDown CornerRadius;
		private Label label5;
		private Button FrameHighlight;
		private Label label6;
		private Button HighlightPressed;
		private Label label7;
	}
}
