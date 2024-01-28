using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormyPodstawy
{
    public class Kolarz
    {
        private static int nextId = 1;

        public int Id { get; set;}
        public bool Wpisowe {  get; set; }
        public byte Wiek { get; set; }
        public string? Imie {  get; set; }
        public string? Nazwisko { get; set; }
        public string? Team {  get; set; }
        public int Ranking { get; set; }
        public string? Email { get; set; }

        public void nowyNumer()
        { Id =  nextId++; }

        public void aktualizujID(int _id)
        {
            Id = _id;
        }
    }
}
