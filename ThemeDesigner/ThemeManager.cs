using System.Text.Json;

namespace ThemeDesigner
{
	public class ThemeManager
	{
		private readonly List<Theme> themes = [];

		public ThemeManager()
		{
			Load();
		}

		public void Load()
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Drafix\\PROlandscapeThemes.json");

			if (File.Exists(path))
			{
				using StreamReader r = new(path);
				string json = r.ReadToEnd();

				var theList = JsonSerializer.Deserialize<List<JsonTheme>>(json);

				if (theList != null)
				{
					foreach ( var theme in theList)
					{
						themes.Add(new Theme(theme));
					}
				}	
			}
		}

		public void Save()
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Drafix");
			Directory.CreateDirectory(path);

			path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Drafix\\PROlandscapeThemes.json");

			using StreamWriter r = new(path, false);

			List<JsonTheme> jsonList = new List<JsonTheme>();
			foreach (var theme in themes)
			{
				jsonList.Add(theme.Json);
			}

			r.Write(JsonSerializer.Serialize(jsonList));
		}

		public List<Theme> GetThemes()
		{
			return themes;
		}

		public Theme? GetTheme(string name)
		{
			return themes?.FirstOrDefault(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
		}

		public void AddTheme(Theme theme)
		{
			themes?.Add(theme);
		}
	}
}
