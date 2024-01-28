using Newtonsoft.Json;
    using System.Text.Json;
using System.IO;
using System.ComponentModel;

namespace FormyPodstawy
{
    
    internal static class Pliki
    {
        public static string sciezkaPliku = "listaKolarzy.json";
        public static void zapiszPlik()
        {
            string json = JsonConvert.SerializeObject(Program.listaKolarzy);
            File.WriteAllText(sciezkaPliku, json);
        }
        
        public static void odczytajPlik()
        {
            if (File.Exists(sciezkaPliku))
            {
                string jsonZPliku = File.ReadAllText(sciezkaPliku);
                Program.listaKolarzy = JsonConvert.DeserializeObject<BindingList<Kolarz>>(jsonZPliku);
            }
        }
    }


}