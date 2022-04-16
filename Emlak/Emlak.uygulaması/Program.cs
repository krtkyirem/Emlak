using System;

namespace Emlak.uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Emlak Uygulamasına hoşgeldiniz ");
            string[] Sehir = new string[0];
            int[] Kat1 = new int[0];//KAç katlı
            int[] Kat2 = new int[0];//KAçıncı kat 
            while (true)
            {
                Console.WriteLine("Apartman Ekle(1)-Apartman Listele(2)-Apartman Güncelle(3)-Çıkış(0)");
                char enter = Console.ReadKey().KeyChar;
                if (enter == '1')
                {
                    Console.WriteLine();
                    Console.Write("Şehir Giriniz: ");
                    string sehir = Console.ReadLine();
                    Console.Write("Kaç katlı Giriniz: ");
                    int kat1 = int.Parse(Console.ReadLine());
                    Console.Write("Kaçıncı Giriniz: ");
                    int kat2 = int.Parse(Console.ReadLine());
                    Array.Resize(ref Sehir, Sehir.Length + 1);
                    Array.Resize(ref Kat1, Kat1.Length + 1);
                    Array.Resize(ref Kat2, Kat2.Length + 1);
                    Sehir[Sehir.Length - 1] = sehir;
                    Kat1[Kat1.Length - 1] = kat1;
                    Kat2[Kat2.Length - 1] = kat2;

                }
                else if (enter == '2')
                {
                    Console.WriteLine();
                    for (int i = 0; i < Sehir.Length; i++)
                    {
                        Console.WriteLine($"Şehir:{Sehir[i]}  Kaç Katlı:{Kat1[i]}  Kaçıncı Kat:{Kat2[i]} ");
                    }
                }
                else if (enter == '3')
                {
                    Console.WriteLine();
                    Console.Write("Güncelleme Yapılacak Şehri Yazınız: ");
                    string sehir = Console.ReadLine();
                    for (int i = 0; i < Sehir.Length; i++)
                    {
                        if (sehir.ToLower() == Sehir[i].ToLower())
                        {
                            Console.WriteLine($"Şehir:{Sehir[i]}  Kaç Katlı:{Kat1[i]}  Kaçıncı Kat:{Kat2[i]} ");
                            Console.Write("Güncelleme yapılacak KAtegoriyi Seçin: Şehir(1)- Kaç Katlı(2)-KAçıncı Kat(3)-Hepsi(4)");
                            char enter1 = Console.ReadKey().KeyChar;
                            if (enter1 == '1')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel Şehiri yazınız: ");
                                string GuncelSehir = Console.ReadLine();
                                Sehir[i] = GuncelSehir;
                            }
                            else if (enter1 == '2')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel Kaç Kat yazınız: ");
                                int GuncelKat1 = int.Parse(Console.ReadLine());
                                Kat1[i] = GuncelKat1;
                            }
                            else if (enter1 == '3')
                            {
                                Console.WriteLine();
                                Console.Write("Güncel Kaçıncı  Kat yazınız: ");
                                int GuncelKat2 = int.Parse(Console.ReadLine());
                                Kat2[i] = GuncelKat2;
                            }
                            else if (enter1 == '4')
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("Güncel Şehiri yazınız: ");
                                string GuncelSehir = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Güncel Kaç Kat yazınız: ");
                                int GuncelKat1 = int.Parse(Console.ReadLine());
                                Console.Write("Güncel Kaçıncı  Kat yazınız: ");
                                int GuncelKat2 = int.Parse(Console.ReadLine());
                                Kat1[i] = GuncelKat1;
                                Sehir[i] = GuncelSehir;
                                Kat2[i] = GuncelKat2;

                            }
                            Console.WriteLine($"Güncellenen:Şehir {Sehir[i]} KAt {Kat1[i]} Kaçıncı kat{Kat2[i]}");


                        }

                    }

                }
                else if (enter == '0')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Girişş");
                }
            }
        }
    }
}
