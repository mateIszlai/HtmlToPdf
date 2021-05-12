using System;
using System.Collections.Generic;

namespace HtmlToPdf.Models
{
    public class SzervizJelentes
    {
        //FejAzonosito
        public int Id { get; set; }
        public string Sorszam { get; set; }
        public UgyfelItem Ugyfel { get; set; }
        public DateTime TervezettDatum { get; set; }
        public string Megjegyzes { get; set; }
        //Majd int lesz valoszinu
        public string Statusz { get; set; }
        public DateTime Datum { get; set; }
        public string FelhasznaloAzonosito { get; set; }
        public List<SzervizJelentesTetel> Tetelek { get; set; }

        public SzervizJelentes()
        {
            Tetelek = new List<SzervizJelentesTetel>();
        }
    }

    public class SzervizJelentesTetel
    {
        public int TetelId { get; set; }
        public int FejId { get; set; }
        public Kerekpar Kerekpar { get; set; }
        public string Megjegyzes { get; set; }
        //Majd int lesz valoszinu
        public string Tipus { get; set; }
        //Majd int lesz valoszinu
        public string Statusz { get; set; }
    }

    public class MunkalapSablonAdatok
    {
        public string MunkalapFejKod { get; set; }
        public string UgyfelNev { get; set; }
        public string UgyfelNevBefejezes { get; set; }
        public string Irsz { get; set; }
        public string Varos { get; set; }
        public string Cim { get; set; }
        public string KerekparMegnevezes { get; set; }
        public string SzoftverVerzio { get; set; }
        public int Km { get; set; }
        public string LanckopasNev { get; set; }
        public string GumikopasNev { get; set; }
        public string AkkuAllapotNev { get; set; }
        public DateTime DatumKezdet { get; set; }
        public DateTime DatumVeg { get; set; }
        public int SzervizHossz { get; set; }
        public string Megjegyzes { get; set; }
        public string EgyebTevekenysegek { get; set; }
        public List<MunkalapTetelSablonAdat> Tetelek { get; set; }

        public MunkalapSablonAdatok()
        {
            Tetelek = new List<MunkalapTetelSablonAdat>();
        }
    }

    public class MunkalapTetelSablonAdat
    {
        public string AlkatreszNev { get; set; }
        public int Mennyiseg { get; set; }
        public string Megjegyzes { get; set; }
        public decimal Onkoltseg { get; set; }
    }
}
