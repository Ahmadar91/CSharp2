using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Model.UtilitiesLibrary
{
	public static class BinSerializerUtility
	{
		/// <summary>Serializes the specified object.</summary>
		/// <param name="obj">The object.</param>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public static bool Serialize(object obj, string fileName)
		{

			using (var fileStream = new FileStream(fileName, FileMode.Create))
			{
				var b = new BinaryFormatter();
				b.Serialize(fileStream, obj);
				fileStream.Flush();
			}
			return true;
		}
		/// <summary>Deserializes the specified file name.</summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="fileName">Name of the file.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public static List<T> Deserialize<T>(string fileName)
		{
			object obj = null;
			using (var fileStream = new FileStream(fileName, FileMode.Open))
			{
				var b = new BinaryFormatter();
				obj = b.Deserialize(fileStream);
			}
			return (List<T>)obj;
		}
	}
}
