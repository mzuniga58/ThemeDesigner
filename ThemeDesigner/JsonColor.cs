using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ThemeDesigner
{
	internal class JsonColor
	{
		public int R { get; set; }
		public int G { get; set; }
		public int B { get; set; }
		public int A { get; set; }

		public JsonColor()
		{
			R = 0;
			G = 0;
			B = 0;
			A = 0;
		}

		public JsonColor(Color c)
		{
			R = c.R;
			G = c.G;
			B = c.B;
			A = c.A;
		}

		[JsonIgnore]
		public Color Color {
			get { return Color.FromArgb(A, R, G, B); }
			set { R = value.R; G = value.G; B = value.B; A = value.A; }
		}
	}
}
