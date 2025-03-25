namespace ThemeDesigner
{
	public class Theme
	{
		public string Name { get; set; }
		public Color FrameColor { get; set; }
		public Color ActiveCaption { get; set; }
		public Color InactiveCaption { get; set; }
		public Color FrameBackground { get; set; }
		public Color FrameHighlight { get; set; }
		public Color CloseBackground { get; set; }
		public Color ClosePressedBackground { get; set; }
		public Color ClosePressedForecolor { get; set; }
		public int FrameBorderSize { get; set; }
		public int FrameResizeBorderSize { get; set; }
		public int FrameCornerRadius { get; set; }
		public int CaptionHeight { get; set; }
		public Color FramePressedHighlight { get; set; }
		public Color ToolboxBackground { get; set; }
		public Color WorkspaceBackground { get; set; }
		public Color WorkspaceForeground { get; set; }
		public Font CaptionFont { get; set; }

		public Theme()
		{
			Name = "PROLandscape";
			FrameColor = Color.FromArgb(16, 124, 65);
			ActiveCaption = Color.White;
			InactiveCaption = Color.DarkGray;
			CaptionHeight = 47;
			CaptionFont = new Font(FontFamily.GenericSansSerif, 9.0f);
			FrameBorderSize = 1;
			FrameResizeBorderSize = 4;
			FrameCornerRadius = 8;
			FrameHighlight = Color.FromArgb(15, 112, 59);
			FramePressedHighlight = Color.FromArgb(9, 70, 36);
			FrameBackground = Color.FromArgb(237, 230, 231);
			CloseBackground = Color.FromArgb(232, 17, 35);
			ClosePressedBackground = Color.FromArgb(241, 112, 122);
			ClosePressedForecolor = Color.Black;
			ToolboxBackground = Color.FromArgb(237, 230, 231);
			WorkspaceBackground = Color.WhiteSmoke;
			WorkspaceForeground = Color.Black;
		}

		internal Theme(JsonTheme source)
		{
			Name = source.Name;
			FrameColor = source.FrameColor.Color;
			ActiveCaption =source.ActiveCaption.Color;
			InactiveCaption = source.InactiveCaption.Color;
			FrameBackground = source.FrameBackground.Color;
			FrameHighlight = source.FrameHighlight.Color;
			CloseBackground = source.CloseBackground.Color;
			ClosePressedBackground = source.ClosePressedBackground.Color;	
			ClosePressedForecolor = source.ClosePressedForecolor.Color;
			FrameBorderSize = source.FrameBorderSize;
			FrameResizeBorderSize = source.FrameResizeBorderSize;
			FrameCornerRadius = source.FrameCornerRadius;
			CaptionHeight = source.CaptionHeight;
			ToolboxBackground = source.ToolboxBackground.Color;
			WorkspaceBackground = source.WorkspaceBackground.Color;
			WorkspaceForeground = source.WorkspaceForeground.Color;
			CaptionFont = source.CaptionFont.Font;
		}

		internal JsonTheme Json
		{
			get
			{
				var theme = new JsonTheme();
				theme.Name = Name;
				theme.FrameColor = new JsonColor(FrameColor);
				theme.ActiveCaption = new JsonColor(ActiveCaption);
				theme.InactiveCaption = new JsonColor(InactiveCaption);
				theme.FrameBackground = new JsonColor(FrameBackground);
				theme.FrameHighlight = new JsonColor(FrameHighlight);
				theme.CloseBackground = new JsonColor(CloseBackground);
				theme.ClosePressedBackground = new JsonColor(ClosePressedBackground);
				theme.ClosePressedForecolor = new JsonColor(ClosePressedForecolor);
				theme.FrameBorderSize = FrameBorderSize;
				theme.FrameResizeBorderSize = FrameResizeBorderSize;
				theme.FrameCornerRadius = FrameCornerRadius;
				theme.CaptionHeight = CaptionHeight;
				theme.ToolboxBackground = new JsonColor(ToolboxBackground);
				theme.WorkspaceBackground = new JsonColor(WorkspaceBackground);
				theme.WorkspaceForeground = new JsonColor(WorkspaceForeground);
				theme.CaptionFont = new JsonFont(CaptionFont);

				return theme;
			}
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
