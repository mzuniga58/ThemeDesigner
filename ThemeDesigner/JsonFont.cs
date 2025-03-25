using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThemeDesigner
{
	internal class JsonFont
	{
		public string FontFamily { get; set; }
		public float EmSize { get; set; }
		public FontStyle FontStyle { get; set; }

		public JsonFont()
		{
			FontFamily = System.Drawing.FontFamily.GenericSansSerif.Name;
			EmSize = 9.0f;
			FontStyle = FontStyle.Regular;	
		}

		public JsonFont(Font source)
		{
			FontFamily = source.FontFamily.Name;
			EmSize = source.Size;
			FontStyle = source.Style;
		}

		[JsonIgnore]
		public Font Font
		{
			get 
			{
				return new Font(FontFamily, EmSize, FontStyle);
			}

			set
			{
				FontFamily = value.FontFamily.Name;
				EmSize = value.Size;
				FontStyle = value.Style;
			}
		}
	}
}
