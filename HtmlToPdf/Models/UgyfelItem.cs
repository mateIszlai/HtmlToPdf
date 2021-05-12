namespace HtmlToPdf.Models
{
    public class UgyfelItem
    {
        public int UgyfelId { get; set; }
        public string Nev { get; set; }
        public string Nev2 { get; set; }
        public string SzekhelyOrszag { get; set; }
        public string SzekhelyIrsz { get; set; }
        public string SzekhelyMegye { get; set; }
        public string SzekhelyTelepules { get; set; }
        public string SzekhelyCim { get; set; }
        public string SzekhelyCim2 { get; set; }
        public string SzamlazasOrszag { get; set; }
        public string SzamlazasIrsz { get; set; }
        public string SzamlazasMegye { get; set; }
        public string SzamlazasTelepules { get; set; }
        public string SzamlazasCim { get; set; }
        public string SzallitasOrszag { get; set; }
        public string SzallitasIrsz { get; set; }
        public string SzallitasMegye { get; set; }
        public string SzallitasTelepules { get; set; }
        public string SzallitasCim { get; set; }
        public string SzallitasCim2 { get; set; }
        public string Adoszam { get; set; }
        public string EusAdoszam { get; set; }
        public int PenznemId { get; set; }
        public string Penznem { get; set; }
        public int FizetesiModId { get; set; }
        public string FizetesiMod { get; set; }
        public string KontaktNeve { get; set; }
        public string KontaktTelefon { get; set; }
        public string KontaktEmail { get; set; }
        public string Megjegyzes { get; set; }
        public int UgyfelStatuszId { get; set; }
        public string UgyfelStatusz { get; set; }
        public string Bankszamlaszam { get; set; }
        public int UgyfelKategoriaId { get; set; }
        public string UgyfelKategoria { get; set; }
        public int FizetesiHataridoNap { get; set; }
    }
}