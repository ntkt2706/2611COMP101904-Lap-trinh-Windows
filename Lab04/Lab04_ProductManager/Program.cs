using System;
using System.Linq;

namespace Lab04_ProductManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ProductService productService = new ProductService();

            // Đăng ký Event
            productService.OnProductAdded += (p) =>
                Console.WriteLine($"=> [EVENT] Đã thêm thành công sản phẩm: {p.TenSP}");

            productService.OnProductRemoved += (id) =>
                Console.WriteLine($"=> [EVENT] Đã xóa thành công sản phẩm mã: {id}");

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n===== PRODUCT MANAGER =====");
                Console.WriteLine("1. Them san pham");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Tim theo ma");
                Console.WriteLine("4. Tim theo ten");
                Console.WriteLine("5. Loc theo khoang gia");
                Console.WriteLine("6. Xoa san pham");
                Console.WriteLine("7. Tinh tong gia tri kho");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");

                string choice = Console.ReadLine();
                Console.WriteLine("---------------------------");

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Nhập mã SP: "); string id = Console.ReadLine();
                            Console.Write("Nhập tên SP: "); string name = Console.ReadLine();
                            Console.Write("Nhập đơn giá: "); decimal price = decimal.Parse(Console.ReadLine());
                            Console.Write("Nhập số lượng: "); int qty = int.Parse(Console.ReadLine());
                            productService.AddProduct(new Product(id, name, price, qty));
                            break;
                        case "2":
                            var ds = productService.GetAllProducts().ToList();
                            if (!ds.Any()) Console.WriteLine("=> Danh sách rỗng.");
                            else ds.ForEach(p => Console.WriteLine(p.ToString()));
                            break;
                        case "3":
                            Console.Write("Nhập mã cần tìm: ");
                            var pMa = productService.FindById(Console.ReadLine());
                            if (pMa != null) Console.WriteLine(pMa.ToString());
                            else Console.WriteLine("=> Không tìm thấy.");
                            break;
                        case "4":
                            Console.Write("Nhập tên cần tìm: ");
                            var dsTen = productService.SearchByName(Console.ReadLine()).ToList();
                            if (!dsTen.Any()) Console.WriteLine("=> Không tìm thấy.");
                            else dsTen.ForEach(p => Console.WriteLine(p.ToString()));
                            break;
                        case "5":
                            Console.Write("Giá thấp nhất: "); decimal min = decimal.Parse(Console.ReadLine());
                            Console.Write("Giá cao nhất: "); decimal max = decimal.Parse(Console.ReadLine());
                            var dsGia = productService.Filter(p => p.Price >= min && p.Price <= max).ToList();
                            if (!dsGia.Any()) Console.WriteLine("=> Không có sản phẩm.");
                            else dsGia.ForEach(p => Console.WriteLine(p.ToString()));
                            break;
                        case "6":
                            Console.Write("Nhập mã cần xóa: ");
                            productService.RemoveProduct(Console.ReadLine());
                            break;
                        case "7":
                            Console.WriteLine($"=> Tổng giá trị kho: {productService.CalculateTotal():C}");
                            break;
                        case "0":
                            isRunning = false;
                            Console.WriteLine("=> Đã thoát.");
                            break;
                        default:
                            Console.WriteLine("=> Lựa chọn không hợp lệ!");
                            break;
                    }
                }
                catch (FormatException) { Console.WriteLine("=> [LỖI] Dữ liệu nhập sai định dạng!"); }
                catch (DuplicateProductException ex) { Console.WriteLine($"=> [LỖI NGHIỆP VỤ] {ex.Message}"); }
                catch (ProductNotFoundException ex) { Console.WriteLine($"=> [LỖI NGHIỆP VỤ] {ex.Message}"); }
                catch (ArgumentException ex) { Console.WriteLine($"=> [LỖI DỮ LIỆU] {ex.Message}"); }
            }
        }
    }
}