using System;
using System.Globalization;

namespace tpmodul8_1302223027
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek CovidConfig
            CovidConfig config = new CovidConfig().readJson();
            Console.WriteLine(config.satuan_suhu);

            Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
            double suhu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir demam: ");
            int hari = int.Parse(Console.ReadLine());

            

            if (config.satuan_suhu == "celcius")
            {
                if ((suhu >= 36.5 && suhu <= 37.5) && hari < config.batas_hari_demam)
                {
                    Console.WriteLine(config.pesan_diterima);
                }
                else
                {
                    Console.WriteLine(config.pesan_ditolak);
                }
            }

            config.UbahSatuan();

            Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu);
             suhu = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir demam: ");
             hari = int.Parse(Console.ReadLine());

            if (config.satuan_suhu == "fahrenheit")
            {
                if ((suhu >= 97.7 && suhu <= 99.5) && hari < config.batas_hari_demam)
                {
                    Console.WriteLine(config.pesan_diterima);
                }
                else
                {
                    Console.WriteLine(config.pesan_diterima);
                }
            }



        }
    }
}
