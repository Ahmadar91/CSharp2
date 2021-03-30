using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Model.UtilitiesLibrary
{
	public class XMLSerializerUtility
	{
		public static bool Serialize<T>(T obj, string fileName)
		{
			using (var writer = new StreamWriter(fileName))
			{
				var serializer = new XmlSerializer(typeof(T));
				serializer.Serialize(writer, obj);
				writer.Flush();
			}
			return true;
		}
		public static T Deserialize<T>(string filePath)
		{
			object result = null;
			using (var reader = new StreamReader(filePath))
			{
				var serializer = new XmlSerializer(typeof(T));
				result = (T)serializer.Deserialize(reader);
			}
			return (T)result;
		}
	}
}