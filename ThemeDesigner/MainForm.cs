using System.Runtime.Serialization;

namespace ThemeDesigner
{
	public partial class MainForm : Form
	{
		private readonly ThemeManager themeManager = new ThemeManager();
		private Theme? theme = null;

		public MainForm()
		{
			InitializeComponent();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			foreach (var theme in themeManager.GetThemes().OrderBy(s => s.Name).ToList())
			{
				ThemeList.Items.Add(theme);
			}

			if (ThemeList.Items.Count > 0)
			{
				ThemeList.SelectedIndex = 0;
			}
		}

		private void OnFrameColorClicked(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				FrameColor.BackColor = colorDialog1.Color;

				if (theme != null)
				{
					theme.FrameColor = colorDialog1.Color;
					themeManager.Save();
				}
			}
		}

		protected void OnAddNewTheme(object sender, EventArgs e)
		{
			var theTheme = new Theme();
			theTheme.Name = "New Theme";

			themeManager.AddTheme(theTheme);

			ThemeList.Items.Clear();
			foreach (var theme in themeManager.GetThemes().OrderBy(s => s.Name).ToList())
			{
				ThemeList.Items.Add(theme);
			}

			for (int i = 0; i < ThemeList.Items.Count; i++)
			{
				var candidate = ThemeList.Items[i];

				if (candidate == theTheme)
				{
					ThemeList.SelectedIndex = i;
					break;
				}
			}

			themeManager.Save();
		}

		protected void OnThemeSelected(object sender, EventArgs e)
		{
			theme = ThemeList.SelectedItem as Theme;

			if (theme != null)
			{
				ThemeName.Text = theme.Name;
				CaptionHeight.Value = theme.CaptionHeight;
				BorderSize.Value = theme.FrameBorderSize;
				CornerRadius.Value = theme.FrameCornerRadius;
				FrameColor.BackColor = theme.FrameColor;
				FrameHighlight.BackColor = theme.FrameHighlight;
				HighlightPressed.BackColor = theme.FramePressedHighlight;
			}
		}

		protected void OnThemeNameChanged(object sender, EventArgs e)
		{
			if (theme != null)
			{
				theme.Name = ThemeName.Text;
				themeManager.Save();
				ThemeList.Invalidate();
			}
		}

		private void OnCaptionHeightChanged(object sender, EventArgs e)
		{
			if (theme != null)
			{
				theme.CaptionHeight = Convert.ToInt32(CaptionHeight.Value);
				themeManager.Save();
			}
		}

		private void OnBorderSizeChanged(object sender, EventArgs e)
		{
			if (theme != null)
			{
				theme.FrameBorderSize = Convert.ToInt32(BorderSize.Value);
				themeManager.Save();
			}
		}

		private void OnCornerRadiusChanged(object sender, EventArgs e)
		{
			if (theme != null)
			{
				theme.FrameCornerRadius = Convert.ToInt32(CornerRadius.Value);
				themeManager.Save();
			}
		}
	}
}
