using System;
using Model.Interfaces;
using Model.UtilitiesLibrary;
using System.Collections.Generic;
using System.Linq;

namespace Model.Models
{

	public class ListManager<T> : IListManager<T>
	{
		private List<T> _list;
		public int Count => _list.Count;
		/// <summary>Initializes a new instance of the <see cref="ListManager{T}" /> class.</summary>
		public ListManager()
		{
			_list = new List<T>();
		}
		/// <summary>Adds the specified value.</summary>
		/// <param name="value">The value.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool Add(T value)
		{
			if (value == null) return false;
			_list.Add(value);
			return true;
		}

		/// <summary>Replaces at.</summary>
		/// <param name="index">The index.</param>
		/// <param name="value">The value.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool ReplaceAt(int index, T value)
		{
			if (!CheckIndex(index)) return false;
			_list[index] = value;
			return true;
		}

		/// <summary>Checks the index.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool CheckIndex(int index)
			=> index < _list.Count && index >= 0;

		/// <summary>Removes all.</summary>
		/// <param name="value">The value.</param>
		public void RemoveAll(T value)
		{
			_list.Clear();
		}

		/// <summary>Removes at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public bool RemoveAt(int index)
		{
			if (!CheckIndex(index)) return false;
			_list.RemoveAt(index);
			return true;
		}

		/// <summary>Gets at.</summary>
		/// <param name="index">The index.</param>
		/// <returns>
		///   <br />
		/// </returns>
		public T GetAt(int index)
		{
			return !CheckIndex(index) ? default : _list[index];
		}

		/// <summary>Converts to stringarray.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public string[] ToStringArray()
		{
			return _list.Select(item => item.ToString()).ToArray();
		}

		/// <summary>Converts to stringlist.</summary>
		/// <returns>
		///   <br />
		/// </returns>
		public List<string> ToStringList()
		{
			return _list.Select(item => item.ToString()).ToList();
		}

		public bool BinarySerializer(string fileName)
		{
			if (BinSerializerUtility.Serialize(_list, fileName))
			{
				return true;
			}
			return false;
		}

		public bool BinaryDeSerializer(string fileName)
		{
			var results = BinSerializerUtility.Deserialize<T>(fileName);
			if (results.Any())
			{
				_list = results;
				return true;
			}
			return false;
		}

		public bool XmlSerialize(string fileName)
		{
			return XMLSerializerUtility.Serialize(_list, fileName);
		}
		public bool XmlDeserialize(string fileName)
		{
			var results = XMLSerializerUtility.Deserialize<List<T>>(fileName);
			if (results.Any())
			{
				_list = results;
				return true;
			}
			return false;
		}
	}
}