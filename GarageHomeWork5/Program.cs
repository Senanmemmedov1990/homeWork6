
// Task - 1
// 2 arrayımız var. Birinci arrayda olan və eynizamanda ikincidə olmayan bütün elementləri print edin.
// (diaqram ilə). Misal üçün: numbers1 = [4, 5, 2, 6, 4, 3] numbers2 = [7, 4, 2, 76, 45, 65]
// Output - da yalnız 5, 6 və 3 olmalıdır.

using GarageHomeWork5;

int[] numbers1 = { 4, 5, 2, 6, 4, 3 };

int[] numbers2 = { 7, 4, 2, 76, 45, 65 };
NotDigit notDigit = new NotDigit();
notDigit.Digit(numbers1,numbers2);


// Task - 2
// Asagidaki member-lerden ibaret Product class-i yaradin:
// Name - mehsulun adi
// Price - mehsulun qiymeti
// Count - mehsulun sayi
// TotalIncome - bu mehsulun satislarindan elde olunan umumi gelir
// Sell() -mehsulun satisi metodu.Bu metod Product-dan bir eded satilmasini ifade edir.
// Satis bas verdikde say azalir (productin sayi sifirdisa satis bas vere bilmez) ,
// income artir Name fieldinin valuesu teyin olunmamish bir product obyekti yaradila bilinmemelidir.


//using GarageHomeWork5;

//Product product = new Product("Mehsul");
//product.AddProduct();
//product.Sell(product);
//product.FullInfo();



//User user = new User();
//user.Register();






// Task - 3
// Asagidaki member-lerden ibaret User class-i yaradin:

// UserName - istifadeci adini ifade edir
// Password - istifadeci sifresini ifade edir

// UserName deyeri teyin olunmamis User obyekti yaradila bilinmemelidir. UserName deyerinin uzunlugu minimum 8 olmalidr.
// Password deyerinin uzunlugu minimum 8 olmalidir ve icinde en az 1 boyuk herf,1 kicik herf ve 1 reqem olmalidir.
// Eks teqdirde password deyeri set oluna bilinmemelidir.



// Task - 4
// CalcAvg metodu - Gonderilmis imtahanlar qiymeti siyahisina (integer array)
// esasen hemin qiymetlerin ortalamasini qaytaran metod yazin. Main metodunda bu metodu call edib,
// burdan qayidan deyere esasen ortalama 60-dan boyukdursa
// console-da "mezun oldunuz" eks halda "mezun ola bilmediniz" yazisi yazdirin



//Avarage avarage = new Avarage();

//if (avarage.CalcAvg() > 60)
//{
//    Console.WriteLine("Mezun oldunuz");
//}
//else Console.WriteLine("Mezun ola bilmediniz");


//Console.WriteLine("1-ci mehsulun deyeri:");
//double deyer1 = double.Parse(Console.ReadLine());
//Console.WriteLine("2-ci mehsulun deyeri:");
//double deyer2 = double.Parse(Console.ReadLine());
//Console.WriteLine("3-ci mehsulun deyeri:");
//double deyer3 = double.Parse(Console.ReadLine());
//HiperMarket hiperMarket = new HiperMarket();
//Console.WriteLine(hiperMarket.Market(deyer1, deyer2, deyer3));

