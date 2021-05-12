using HtmlToPdf.Models;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Layout.Font;
using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace HtmlToPdf
{
    class Program
    {
        
        private static readonly string ATADAS_ATVETEL_PDFPATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\Atadas_atvetel.pdf";
        private static readonly string ATADAS_ATVETEL_TEXT_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\Atadas_atvetel.txt";
        private static readonly string ATADAS_ATVETEL_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\HtmlToPdf\HtmlToPdf\Templates\AtadasAtvetelSablon.cshtml";
        private static readonly string MUNKALAP_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\HtmlToPdf\HtmlToPdf\Templates\SzervizJelentesMunkalap.cshtml";
        private static readonly string MUNKALAP_TEXT_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\Munkalap.txt";
        private static readonly string MUNKALAP_PDF_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\Munalap.pdf";
        private static readonly string MINTA_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\minta_template.html";
        private static readonly string MINTA_PDF_PATH = @"C:\Users\iszim\Documents\Tutorialok\iText 7\Minta.pdf";
        static void Main(string[] args)
        {
            if (AppDomain.CurrentDomain.IsDefaultAppDomain())
            {
                AppDomainSetup adSetup = new AppDomainSetup
                {
                    ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase
                };
                AppDomain current = AppDomain.CurrentDomain;
                var domain = AppDomain.CreateDomain("MyMainDomain", null, current.SetupInformation, new PermissionSet(PermissionState.Unrestricted), null);
                domain.ExecuteAssembly(Assembly.GetExecutingAssembly().Location);
                AppDomain.Unload(domain);
                return;
            }
            /*Console.WriteLine("Processing Atadas-Atvetel...");
            string atadasAtvetel = CreateAtadasAtvetelSource();
            CreatePdf(atadasAtvetel, ATADAS_ATVETEL_PDFPATH);
            Console.WriteLine("Processing Munkalap...");
            string munkalap = CreateMunkalapSource();
            CreatePdf(munkalap, MUNKALAP_PDF_PATH);*/
            Console.WriteLine("Processing minta...");
            string mintaHtml = File.ReadAllText(MINTA_PATH);
            CreatePdf(mintaHtml, MINTA_PDF_PATH);
           
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void CreatePdf(string source, string dest)
        {
            
            ConverterProperties properties = new ConverterProperties();
            FontProvider fontProvider = new FontProvider();
            fontProvider.AddStandardPdfFonts();
            fontProvider.AddSystemFonts();
            properties.SetFontProvider(fontProvider);
            HtmlConverter.ConvertToPdf(source, new PdfWriter(dest), properties);
        }

        private static string CreateMunkalapSource()
        {
            var file = File.ReadAllBytes(MUNKALAP_PATH);
            var base64file = Convert.ToBase64String(file);
            string template = System.Text.Encoding.UTF8.GetString(file);
            File.WriteAllText(MUNKALAP_TEXT_PATH, template);
            return Engine.Razor.RunCompile(template, "munkalap", typeof(MunkalapSablonAdatok), new MunkalapSablonAdatok
            {
                MunkalapFejKod = "12s3efr58ght4878",
                UgyfelNev = "Kiss János",
                UgyfelNevBefejezes = "Nagy Jakab",
                Irsz = "1095",
                Varos = "Budapest",
                Cim = "Májos tészta út 22.",
                KerekparMegnevezes = "Merida s50",
                SzoftverVerzio = "v1.0",
                Km = 300,
                LanckopasNev = "Közepes",
                GumikopasNev = "Közepes",
                AkkuAllapotNev = "Jó állapotú",
                DatumKezdet = DateTime.Now,
                DatumVeg = DateTime.Now.AddMinutes(30),
                SzervizHossz = 30,
                Megjegyzes = "Megjegyzés",
                Tetelek = new List<MunkalapTetelSablonAdat>
                {
                    new MunkalapTetelSablonAdat
                    {
                        AlkatreszNev = "Lánc",
                        Mennyiseg = 1,
                        Onkoltseg = 1500
                    },
                    new MunkalapTetelSablonAdat
                    {
                        AlkatreszNev = "pedál",
                        Mennyiseg = 2,
                        Megjegyzes = "Fémből készültre cserélve",
                        Onkoltseg = 2000
                    }
                }
            });
        }

        private static string CreateAtadasAtvetelSource()
        {
            var file = File.ReadAllBytes(ATADAS_ATVETEL_PATH);
            var base64file = Convert.ToBase64String(file);
            string template = System.Text.Encoding.UTF8.GetString(file);
            File.WriteAllText(ATADAS_ATVETEL_TEXT_PATH, template);
            return Engine.Razor.RunCompile(template, "atadasatvetelreport", typeof(AtadasAtvetelSablonAdatok), new AtadasAtvetelSablonAdatok
            {
                AtadasKod = "12345678",
                AtadasTipus = "átadás",
                UgyfelNev = "Kiss Géza",
                Irsz = "1091",
                Varos = "Kiskunmajsa",
                Cim = "Kossuth Lajos utca 5.",
                AtadasDatum = DateTime.Now,
                Megjegyzes = "Megjegyzés",
                Tetelek = new List<AtadasAtvetelTetelSablonAdat>
                {
                    new AtadasAtvetelTetelSablonAdat
                    {
                        AtadasTipusNev = "átadás",
                        KerekparMegnevezes = "Bmx 650",
                        Km = 0,
                        GumikopasNev = "Nincs kopás",
                        LanckopasNev = "Nincs kopás",
                        AkkuAllapotNev = "Tökéletes",
                        SzoftverVerzio = "v1.0",
                        Megjegyzes = "Megjegyzés"
                    },
                    new AtadasAtvetelTetelSablonAdat
                    {
                        AtadasTipusNev = "átvétel",
                        KerekparMegnevezes = "MTB 120",
                        Km = 20,
                        GumikopasNev = "Alacsony",
                        LanckopasNev = "Közepes",
                        AkkuAllapotNev = "Magas",
                        SzoftverVerzio = "v1.0"
                    }
                }
            });
        }
    }
}
