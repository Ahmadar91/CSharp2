using System.IO;

namespace Controller
{
	public static class FileParser
	{

		/// <summary>Reads the file.</summary>
		/// <param name="path">The path.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public static string[] ReadFile(string path)
		{
			return File.ReadAllLines(path);
		}
	}
}