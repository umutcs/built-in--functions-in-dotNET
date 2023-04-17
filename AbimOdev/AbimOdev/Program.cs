using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;

namespace AbimOdev
{



    internal class Program
    {


        static void Main()
        {

            //MATEMATİK BAŞLAR


            //Math.Acos(): Asin metodu gibi bir işlemin tersini gerçekleştireceğini başındaki A harfinden anlayabiliriz. Parametre olarak atanacak kosinüs değeri alır ve radyan cinsinden bizlere elde edilen değeri gösterir.

            //arccos 

            double a = Math.PI;
            Console.WriteLine(Math.Acos(a));
            Console.WriteLine(Math.Asin(a));

            //math.sin == sin hesaplamada kullanılır. içine girilini radyan olarak kabul eder
            Console.WriteLine(Math.Sin(a));
            Console.WriteLine(Math.Cos(a));
            //math tan tanjant olarak yapıyor

            Console.WriteLine(Math.Tan(a));
            Console.WriteLine(Math.Atan(a));

            int b = 4;
            Console.WriteLine(Math.Sqrt(b));

            Console.WriteLine(Math.Min(a, b));

            Console.WriteLine(Math.Max(a, b));
            int c = -5;
            Console.WriteLine(Math.Abs(c));
            double sayi = 4.2018;
            //Girilen sayıyı yukarı yuvarlar.
            Console.WriteLine(Math.Ceiling(sayi));
            //yuvarlama öncekine
            Console.WriteLine(Math.Floor(sayi));
            //Girilen sayıyı en yakın tamsayıya yuvarlar
            Console.WriteLine(Math.Round(sayi));

            //pow üst alma
            Console.WriteLine(Math.Pow(3, b));


            //Sign işarete göre yorum yapıyo işte

            Console.WriteLine(Math.Sign(a));


            //sfırdan büyükse 1 küçükse -1 eişte 0 olacak şekilde



            //Logaritma fonksiyonlarını yazdmadım bilerek, log bilmiyom anlatırken de log bilmek gerektirecek şekilde anlatmış 
            // exp de logaritm


            //MATEMATİK BİTER




            //txt dosyasının içeripini alcam
            var dosyayolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "belge.txt");


            //Uygulamanın çalıştığı dizine dosya açmak için burdan gidiyo işte calisiyo 

            string text = File.ReadAllText(dosyayolu);
            //bos mudolu mu falan diye kontrol
            if (!string.IsNullOrEmpty(text))
            {
                int uzunluk = text.Length;
                string upper, lower;
                upper = text.ToUpper();
                lower = text.ToLower();
                string string1 = text.Substring(0, 10);
                string string2 = text.Substring(10, 20);


                //compare karşılaştırma
                var compare = string.Compare
                    (string1, string2);
                /*
                 
                 s1==s2 returns 0  
s1>s2 returns 1  
s1<s2 returns -1  
                 */
                //text olarak aynı mı farklı mı diye kontrol eder

                //Concat = toplama işlemi
                string string3 = text.Substring(20, 30);
                string string4 = text.Substring(31, 40);
                var concat = string.Concat(string3, string4);
                var replace = string1.Replace("Lorem ipsu", "Umut");

                /*
                 Trim()
Geçerli dizeden baştaki ve sondaki tüm boşluk karakterlerini kaldırır.
                d
Trim(Char[])
Bir dizide belirtilen karakter kümesinin tüm baştaki ve sondaki oluşumlarını geçerli dizeden kaldırır.

Trim(Char)
Geçerli dizeden bir karakterin tüm baştaki ve sondaki örneklerini kaldırır.
                
                 */
                //True false olarak döndürür
                //işte bi string diğerini içeriyo mu diye 
                //mesemla umut,umut yurduguül ----> s2 s1'i içeriyo o zaman true gibi




                string string5 = "   Merhaba Ben Umut     ";
                //Baştan ve sondan karakter kaldırıyor
                var trim = string5.Trim();

                string join = string.Join(string3, string4);
                bool contains = string3.Contains(string4);
                bool contains2 = string4.Contains(string3);
                Console.WriteLine(trim);
                Console.WriteLine($"Dosyada {uzunluk} tane karakter var.");

                char[] delimiterChars = { ' ', ',', '.', ':' };
                string[] kelimeler = string3.Split(delimiterChars);

                foreach (var kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }


                bool s3a = string3.StartsWith("A");
                bool s3b = string3.EndsWith("A");
                DosyayaYaz(Convert.ToString(s3b), "EndsWith.txt");
                DosyayaYaz(text.Substring(0, 10), "Substring_0_10.txt");
                DosyayaYaz(Convert.ToString(uzunluk), "Uzunluk.txt");
                DosyayaYaz(concat + string2, "Replace.txt");
                DosyayaYaz(upper, "ToUpper.txt");
                DosyayaYaz(lower, "Tolower.txt");
                DosyayaYaz(concat, "Concat.txt");
                DosyayaYaz(Convert.ToString(compare), "Compare.txt");
                DosyayaYaz(string5, "Trim");
                DosyayaYaz(join, "Join.txt");
                DosyayaYaz(contains + " " + contains2, "Contains.txt");

            }

            else
            {

                Console.WriteLine("Boyle bi dosya yok kardes!");
            }



            string cumle = text.Substring(0, 10);
            string[] word = cumle.Split(' ');
            List<string> words = new List<string>(word);


            words.Add("Merhaba");
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            string aranan = "Merhaba";
            string sonuc = words.Find(x => x == aranan);
            if (sonuc != null)
            {
                Console.WriteLine(sonuc);

            }
            else
            {
                Console.WriteLine("Bulunamadı!");
            }


            List<string> sonuclar = words.FindAll(x => x.Contains("b"));
            if (sonuclar.Count > 0)
            {
                Console.WriteLine("Hello world!");
            }
            else
            {
                Console.WriteLine(sonuclar);
            }

            List<int> notlar = new List<int>() { 70, 59, 43, 27, 80, 100 };
            int aranan2 = notlar.FindIndex(x => x > 50);

            //-1 dedik burada count gibi eğer sayısı 0'dan küçük değilse işlem yapacak
            if (aranan2 != -1)
            {
                Console.WriteLine("Sas");
            }

            bool contains3 = words.Contains("Merhaba");
            Console.WriteLine(contains3);





            string text5 = "Umut Yurdugül";
            words.Insert(0, text5);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }


            words.Remove("Merhaba");
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            words.RemoveAll(x => x.Contains("A"));
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            words.RemoveAt(0);


            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            words.Reverse();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }



            int count = words.Count;
            Console.WriteLine(count);


            Console.WriteLine("---------------");


            List<string> strings = new List<string>() { "Umut", "Oktay" };

            string joinmethod = string.Join("*/*", strings);
            Console.WriteLine(joinmethod);
            Console.WriteLine("---------------");


            strings.Sort();
            foreach (var item in strings)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            strings.OrderBy(x => x.Contains("t"));
            foreach (var item in strings)
            {

                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");


            var y = strings.ToArray();


            foreach (var item in y)
            {

                Console.WriteLine(item);
            }

            var z = y.ToList();
            foreach (var item in z)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");


            List<string> strings2 = new List<string>() { "Umut", "Oktay","Ömürcan","Aysel"};
            int index = strings2.IndexOf("Umut");
            Console.WriteLine(index);

            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");

            List<string> kuzen = new List<string> {"Zehra","Aytuğ","Zeynep" };
            string[] strings9 = strings2.ToArray();
            string[] concatString = strings9.Concat(kuzen).ToArray();

            foreach (var item in concatString)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            words.Clear();
            if (words.Count == 0)
            {
                Console.WriteLine("temizlendi!");
            }


            Console.ReadLine();
        }
        static void DosyayaYaz(string yazilacakSatir, string dosyaAdi)
        {
            // Debug altinda text dosyasını ac

            string dosyayolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{dosyaAdi}.txt");
            StreamWriter file = new StreamWriter(dosyayolu);

            //yazıyı yazdır
            file.Write(yazilacakSatir);

            //dosyayı kapat
            file.Close();

        }

    }


}