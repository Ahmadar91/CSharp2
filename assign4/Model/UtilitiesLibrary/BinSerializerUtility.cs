﻿using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Model.UtilitiesLibrary
{
	public static class BinSerializerUtility
	{
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
		public static List<T> Deserialize<T>(string fileName)
		{
			object obj = null;

			if (!File.Exists(fileName))
			{
				throw new FileNotFoundException("File Does Not Exist", fileName);
			}
			using (var fileStream = new FileStream(fileName, FileMode.Open))
			{
				var b = new BinaryFormatter();
				obj = b.Deserialize(fileStream);
			}
			return (List<T>)obj;
		}
	}
}