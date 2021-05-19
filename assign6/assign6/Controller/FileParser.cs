using System.IO;

namespace Controller
{
	public static class FileParser
	{

		public static string[] ReadFile(string path)
		{
			return File.ReadAllLines(path);
		}
	}
}