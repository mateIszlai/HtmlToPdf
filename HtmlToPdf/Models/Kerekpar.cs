namespace HtmlToPdf.Models
{
    public class Kerekpar
    {
        public int KerekparId { get; set; }
        public int GyartoId { get; set; }
        public string Megnevezes { get; set; }
        public int VazTipusId { get; set; }
        public int MotorTipusId { get; set; }
        public int GumiTipusId { get; set; }
        public string KulcsAzonosito { get; set; }
        public string Szin { get; set; }
        public int MeretId { get; set; }
        public int KategoriaId { get; set; }
        public string HvAzonosito { get; set; }
        public string GpsAzonosito { get; set; }
        public string SzoftverVerzio { get; set; }
        public int Km { get; set; }
        public string Megjegyzes { get; set; }
    }
}