using System;

namespace Lab04_ProductManager
{
    public class Product : IEntity
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0) throw new ArgumentException("Đơn giá không được âm!");
                price = value;
            }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0) throw new ArgumentException("Số lượng không được âm!");
                quantity = value;
            }
        }

        public string Id => MaSP; // Ràng buộc từ IEntity

        public Product(string maSP, string tenSP, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");

            MaSP = maSP;
            TenSP = tenSP;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Mã: {MaSP,-10} | Tên: {TenSP,-20} | Giá: {Price,10:C} | SL: {Quantity,5}";
        }
    }
}