using System;
using System.Collections.Generic;

namespace HtmlToPdf.Models
{
    public class AtadasAtvetelSablonAdatok
    {
        public string AtadasKod { get; set; }
        public string AtadasTipus { get; set; }
        public string UgyfelNev { get; set; }
        public string Irsz { get; set; }
        public string Varos { get; set; }
        public string Cim { get; set; }
        public DateTime AtadasDatum { get; set; }
        public string Megjegyzes { get; set; }
        public List<AtadasAtvetelTetelSablonAdat> Tetelek { get; set; }

        public AtadasAtvetelSablonAdatok()
        {
            Tetelek = new List<AtadasAtvetelTetelSablonAdat>();
        }
    }

    public class AtadasAtvetelTetelSablonAdat
    {
        public string AtadasTipusNev { get; set; }
        public string KerekparMegnevezes { get; set; }
        public string SzoftverVerzio { get; set; }
        public int Km { get; set; }
        public string LanckopasNev { get; set; }
        public string GumikopasNev { get; set; }
        public string AkkuAllapotNev { get; set; }
        public string Megjegyzes { get; set; }
    }
}
