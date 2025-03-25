namespace ThemeDesigner
{
	internal class JsonTheme
	{
		public string Name { get; set; } = "";
		public JsonColor FrameColor { get; set; } = new JsonColor();
		public JsonColor ActiveCaption { get; set; } = new JsonColor();
		public JsonColor InactiveCaption { get; set; } = new JsonColor();
		public JsonColor FrameBackground { get; set; } = new JsonColor();
		public JsonColor FrameHighlight { get; set; } = new JsonColor();
		public JsonColor CloseBackground { get; set; } = new JsonColor();
		public JsonColor ClosePressedBackground { get; set; } = new JsonColor();
		public JsonColor ClosePressedForecolor { get; set; } = new JsonColor();
		public int FrameBorderSize { get; set; }
		public int FrameResizeBorderSize { get; set; }
		public int FrameCornerRadius { get; set; }
		public int CaptionHeight { get; set; }
		public JsonColor FramePressedHighlight { get; set; } = new JsonColor();
		public JsonColor ToolboxBackground { get; set; } = new JsonColor();
		public JsonColor WorkspaceBackground { get; set; } = new JsonColor();
		public JsonColor WorkspaceForeground { get; set; } = new JsonColor();
		public JsonFont CaptionFont { get; set; } = new JsonFont();
	}
}
