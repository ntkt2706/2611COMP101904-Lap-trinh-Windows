using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04_ProductManager
{
    public class Repository<T> where T : IEntity
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (FindById(item.Id) != null)
                throw new DuplicateProductException($"Mã '{item.Id}' đã tồn tại!");
            _items.Add(item);
        }

        public void Remove(string id)
        {
            var item = FindById(id);
            if (item == null)
                throw new ProductNotFoundException($"Không tìm thấy '{id}' để xóa!");
            _items.Remove(item);
        }

        public T FindById(string id)
        {
            return _items.FirstOrDefault(x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        // Func<T, bool> để tìm kiếm/lọc linh hoạt
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _items.Where(predicate);
        }

        public IEnumerable<T> GetAll() => _items;
    }
}