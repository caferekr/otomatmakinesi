namespace otomatmakinesi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
 
            {
                
                string[] urunler = { "Çikolata", "Cips", "Su","Meyve Suyu","çekirdek" };
                double[] fiyatlar = { 5.0, 3.5, 1.0,10.0,7.5 };
                int urunSayisi = urunler.Length;

                while (true)
                {
                    
                    Console.WriteLine("Ürünler:");
                    for (int i = 0; i < urunSayisi; i++)
                    {
                        Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
                    }

                    
                    Console.Write("Satın almak istediğiniz ürün numarasını girin (1-3) veya çıkmak için 0 girin: ");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    
                    if (secim == 0)
                    {
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    }

                   
                    if (secim < 1 || secim > urunSayisi)
                    {
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        continue;
                    }

                    
                    double urunFiyati = fiyatlar[secim - 1];
                    Console.WriteLine($"Seçtiğiniz ürün: {urunler[secim - 1]} - Fiyat: {urunFiyati} TL");

                    
                    double para;
                    while (true)
                    {           
                        Console.Write("Lütfen para girin: ");
                        try
                        {
                            para = Convert.ToDouble(Console.ReadLine());
                            if (para < urunFiyati)
                            {
                                Console.WriteLine($"Yetersiz bakiye! Ürünün fiyatı {urunFiyati} TL'dir.");
                            }
                            else
                            {
                                break; 
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                        }
                    }

                    
                    Console.WriteLine($"Ürünü aldınız: {urunler[secim - 1]}");
                    double paraIade = para - urunFiyati; 
                    if (paraIade > 0)
                    {
                        Console.WriteLine($"İade edilen para: {paraIade} TL");
                        
                    }
                }
            }
        }

    }
}

