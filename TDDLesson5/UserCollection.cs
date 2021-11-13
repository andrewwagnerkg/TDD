using System.Collections.Generic;

namespace TDDLesson5
{
    class UserCollection<T>
    {
        private List<T> _storage = new List<T>();

        public void Add(T item) => _storage.Add(item);

        public void Remove(T item) => _storage.Remove(item);

        public int Count => _storage.Count;
    }
}
