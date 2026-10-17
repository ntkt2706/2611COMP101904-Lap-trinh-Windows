using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04_ProductManager
{
    public class ProductService
    {
        private Repository<Product> _repo;

        // Định nghĩa Event
        public event Action<Product> OnProductAdded;
        public event Action<string> OnProductRemoved;

        public ProductService()
        {
            _repo = new Repository<Product>();
        }

        public void AddProduct(Product product)
        {
            _repo.Add(product);
            OnProductAdded?.Invoke(product); // Phát Event khi thêm thành công
        }

        public void RemoveProduct(string maSP)
        {
            _repo.Remove(maSP);
            OnProductRemoved?.Invoke(maSP); // Phát Event khi xóa thành công
        }

        public IEnumerable<Product> GetAllProducts() => _repo.GetAll();

        public Product FindById(string maSP) => _repo.FindById(maSP);

        public IEnumerable<Product> SearchByName(string keyword)
        {
            return _repo.Find(p => p.TenSP.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public IEnumerable<Product> Filter(Func<Product, bool> predicate)
        {
            return _repo.Find(predicate);
        }

        public decimal CalculateTotal()
        {
            return _repo.GetAll().Sum(p => p.Price * p.Quantity);
        }
    }
}