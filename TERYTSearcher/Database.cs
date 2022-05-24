using System;
using System.IO;
using System.Xml.Serialization;

namespace TERYTSearcher
{
    class Database
    {
        private const string tercDataLocation = "./../../TERC.xml";
        private const string simcDataLocation = "./../../SIMC.xml";
        private const string ulicDataLocation = "./../../ULIC.xml";

        public static teryt tercData { get; set; }
        public static SIMC simcData { get; set; }
        public static ULIC ulicData { get; set; }

        public static void loadTERCData()
        {
            var xml_serializer = new XmlSerializer(typeof(teryt));

            try
            {
                using (var fs = new FileStream(tercDataLocation, FileMode.Open))
                {
                    tercData = (teryt)xml_serializer.Deserialize(fs);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine($"ERROR: File not found: {tercDataLocation}");
                Environment.Exit(1);
            }
        }

        public static void loadSIMCData()
        {
            var xml_serializer = new XmlSerializer(typeof(SIMC));

            try
            {
                using (var fs = new FileStream(simcDataLocation, FileMode.Open))
                {
                    simcData = (SIMC)xml_serializer.Deserialize(fs);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine($"ERROR: File not found: {simcDataLocation}");
                Environment.Exit(1);
            }
        }

        public static void loadULICData()
        {
            var xml_serializer = new XmlSerializer(typeof(ULIC));

            try
            {
                using (var fs = new FileStream(ulicDataLocation, FileMode.Open))
                {
                    ulicData = (ULIC)xml_serializer.Deserialize(fs);
                }

            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine($"ERROR: File not found: {ulicDataLocation}");
                Environment.Exit(1);
            }


        }
    }
}
