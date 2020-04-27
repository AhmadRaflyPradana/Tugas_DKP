using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Snack{
        public static void PaketBiasa(){
            Console.WriteLine("Keripik Tempe dan Peyek Kacang");
            Console.WriteLine("Total Harga : 10000");
        }
        public static void PaketSedang(){
            Console.WriteLine("Keripik Tempe, Peyek Teri, dan Peyek Kacang");
            Console.WriteLine("Total Harga : 15000");
        }
        public static void PaketJumbo(){
            Console.WriteLine("Keripik Tempe, Peyek Teri, Keripik Pisang, dan Peyek Kacang");
            Console.WriteLine("Total Harga : 20000");
        }
    }
    public class Ahmad
    {
        static void Main(string[] args)
        {
            string Nama, Beli, Pilihan, Metode, Rekening, Transaksi;
            int a, b,c, exit=0;
            Console.WriteLine("\t\tAhmad Snack Raja dari Semua Snack\n");
        awal:
            Console.WriteLine("Silahkan Masukkan Nama Anda :");
            Nama = Console.ReadLine();
            Console.WriteLine("Selamat Datang {0} di Ahmad Snack, Selamat berbelanja",Nama);
            do
            {
                Console.WriteLine("Apakah Anda akan Membeli Produk Snack Kami? Y/T :");
                Beli = Console.ReadLine();
                if (Beli == "Y")
                {
                    Console.WriteLine("Pilih Menu Anda :");
                    Console.WriteLine("1. Paket Biasa");
                    Console.WriteLine("2. Paket Sedang");
                    Console.WriteLine("3. Paket Jumbo");
                    Console.WriteLine("Silahkan Masukan Pilihan Anda :");
                    Pilihan = Console.ReadLine();
                    int.TryParse(Pilihan, out a);
                    switch (Pilihan)
                    {
                        case "1":
                            Snack.PaketBiasa();
                            break;
                        case "2":
                            Snack.PaketSedang();
                            break;
                        case "3":
                            Snack.PaketJumbo();
                            break;
                    }
                    Console.WriteLine("Pilih Metode Pembayaran :");
                    Console.WriteLine("1. BNI");
                    Console.WriteLine("2. BTN");
                    Console.WriteLine("3. BRI");
                    Console.WriteLine("4. BCA");
                    Console.WriteLine("Pilihan Anda :");
                    Metode = Console.ReadLine();
                    int.TryParse(Metode, out b);
                    Console.WriteLine("Masukkan No Rekening Anda :");
                    Rekening = Console.ReadLine();
                    int.TryParse(Rekening, out c);
                    Console.WriteLine("Selamat Transaksi dari {0} dengan nomer rekening {1} telah berhasil", Nama, Rekening);
                }
                else if (Beli == "T")
                {
                    Console.WriteLine("Terimakasih telah datang ke Ahmad Snack");
                    Console.ReadLine();
                    return;

                }
                Console.WriteLine("Apakah anda ingin membeli Snack kembali ? Y/T : ");
                Transaksi = Console.ReadLine();
                if (Transaksi == "Y")
                {
                    goto awal;
                }
                else if (Transaksi == "T")
                {
                    Console.WriteLine("Terimakasih sudah berbelanja di Ahmad Snack");
                    Console.ReadLine();
                    return;
                }           
            } while (exit==0);

            

        }
    }
}
