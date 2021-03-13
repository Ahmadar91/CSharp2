using Model.Interfaces;
using System.Collections.Generic;

namespace Model.Models
{
	public class ListManager<T> : IListManager<T>
	{
		private readonly List<T> _list;
		public int Count { get; }

		public ListManager()
		{
			_list = new List<T>();
			Count = _list.Count;
		}
		public bool Add(T value)
		{
			if (value == null) return false;
			_list.Add(value);
			return true;
		}

		public bool ReplaceAt(int index, T value)
		{
			if (!CheckIndex(index)) return false;
			_list[index] = value;
			return true;
		}

		public bool CheckIndex(int index)
			=> index < _list.Count && index >= 0;

		public void RemoveAll(T value)
		{
			_list.Clear();
		}

		public bool RemoveAt(int index)
		{
			if (!CheckIndex(index)) return false;
			_list.RemoveAt(index);
			return true;
		}

		public T GetAt(int index)
		{
			return !CheckIndex(index) ? default : _list[index];
		}

		public List<T> GetAll()
		{
			return _list;
		}
		public string[] ToStringArray()
		{
			throw new System.NotImplementedException();
		}

		public List<string> ToStringList()
		{
			throw new System.NotImplementedException();
		}
	}
}