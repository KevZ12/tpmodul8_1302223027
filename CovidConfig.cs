using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul8_1302223027
{
    internal class CovidConfig
    {
        public string satuan_suhu;
        public int batas_hari_demam;
        public string pesan_ditolak;
        public string pesan_diterima;

        public CovidConfig() { 
            
        }

        public CovidConfig readJson()
        {
            if (File.Exists("D:\\Tugas pendahuluan\\KPL\\PROJECT\\tpmodul8_1302223027\\covid_config.json"))
            {
                string jsonContent = File.ReadAllText("D:\\Tugas pendahuluan\\KPL\\PROJECT\\tpmodul8_1302223027\\covid_config.json");
                CovidConfig config = JsonConvert.DeserializeObject<CovidConfig>(jsonContent);

                this.satuan_suhu = config.satuan_suhu;
                this.batas_hari_demam = config.batas_hari_demam;
                this.pesan_ditolak = config.pesan_ditolak;
                this.pesan_diterima = config.pesan_diterima;

               
                return config;
            }
            else {
                
                this.satuan_suhu = "celcius";
                this. batas_hari_demam = 14;
                this.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                this.pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
                return this;
            }
        }

        public void UbahSatuan()
        {
            this.satuan_suhu = (this.satuan_suhu == "celcius") ? "fahrenheit" : (this.satuan_suhu == "fahrenheit") ? "celcius" : satuan_suhu;

        }


    }
}
