
//namespace GarageHomeWork5
//{
//    internal class Product
//    {

//        public string Name;
//        public int Price;
//        public int Count;
//        public int TotalIncome;


//        public void FullInfo()
//        {
//            Console.WriteLine($"Product name: {Name},Product price: {Price},Product count: {Count}, Product TotalIncome: {TotalIncome}");
//        }
//        public void AddProduct()
//        {
//            Console.WriteLine("Mehsulumun qiymeti");
//            Price = int.Parse(Console.ReadLine());
//            Console.WriteLine("Mehsulumun sayi");
//            Count = int.Parse(Console.ReadLine());
//        }
//        public void Sell(Product product)
//        {
            
//            if (product == null)
//            {
//                Console.WriteLine("Satis bas vere bilmez");
//            }
//            Console.WriteLine("Mehsuldan nece eded isteyirsiz?");
//            int eded = int.Parse(Console.ReadLine());
//            while (eded > product.Count)
//            {
//                Console.WriteLine($"Mehsuldan {product.Count} eded qalib");
//                Console.WriteLine("Sayi yeniden daxil edin");
//                eded = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine($"Odenis edin: {product.Price * eded}");
//            product.Count -= eded;
//            product.TotalIncome = product.Price * eded;
//            Console.WriteLine("Tesekkur edirik");
            

//        }

//        public Product(string name)
//        {
//            Name = name;
//        }
//    }
//}
