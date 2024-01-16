namespace DateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime tarih = DateTime.Now; //şu an ki sistem tarihini gösteriyor
            //string gun = tarih.ToString("dddd");
            //string gunSayisi = tarih.ToString("dd");
            //string ay = tarih.ToString("MMMM");
            //string yeniTarih = tarih.ToString("dd mm yy");

            //Console.WriteLine($"Şu anki Tarih: {tarih}");
            //Console.WriteLine($"Gün: {gun}");
            //Console.WriteLine($"Gün Sayısı: {gunSayisi}");
            //Console.WriteLine($"Ay: {ay}");
            //Console.WriteLine($" Yeni Tarih Formatı: {yeniTarih}");

            //string fullTime = tarih.ToString("HH:mm ss");
            //Console.WriteLine(fullTime);


            //while (true)
            //{
            //    DateTime tarih = DateTime.Now;
            //    string saniye = tarih.ToString("ss");
            //    Console.WriteLine(saniye);
            //    Thread.Sleep(1000);
            //    Console.Clear();

            //}

            int saniye = 0;
            int dakika = 0;
            int saat = 0;
            int bitisSaniye = 30;
            int bitisDakika = 0;
            int bitisSaat = 0;
            while (true)
            {
                saniye++;
                if (saniye == 60)
                {
                    dakika++;
                    saniye = 0;

                    if (dakika == 60)
                    {
                        saat++;
                        dakika = 0;
                        if (saat == 24)
                        {
                            saat = 0;
                        }
                    }
                }

                if (saniye == bitisSaniye && dakika==bitisDakika && saat == bitisSaat)
                {
                    Console.WriteLine("Süre Doldu...");
                    for (int i = 0; i <10; i++)
                    {
                        Console.Beep();
                        Thread.Sleep(1000-(i*100));
                    }
                    break;
                };
                string saniyeString = saniye < 10 ? "0" + saniye : saniye.ToString();
                string dakikaString = dakika < 10 ? "0" + dakika : dakika.ToString();
                string saatString = saat < 10 ? "0" + saat : saat.ToString();
                Console.WriteLine($"{saatString}:{dakikaString}:{saniyeString}");
                Thread.Sleep(100);
                Console.Clear();
            }

            Console.ReadLine();



















        }
    }
}