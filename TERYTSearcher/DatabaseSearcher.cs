using System;
using System.Collections.Generic;
using System.Linq;
using static TERYTSearcher.Database;


namespace TERYTSearcher
{
    class DatabaseSearcher
    {

        public static bool validateTERYT(string teryt)
        {
            byte temp;

            if (!(teryt.Length == 7 || teryt.Length == 4 || teryt.Length == 2))
                return false;


            if(teryt.Length <= 7)
            {
                temp = byte.Parse(teryt.Substring(4, 2));
                if (temp == 0) return false;
                temp = byte.Parse(teryt.Substring(6, 1));
                if (temp == 0) return false;
            }

            if (teryt.Length <= 4)
            {
                temp = byte.Parse(teryt.Substring(2, 2));
                if (temp == 0) return false;
            }

            temp = byte.Parse(teryt.Substring(0, 2));
            if (temp % 2 != 0 || temp == 0) return false;

            return true;
        }


        public static void printStreets(IEnumerable<ULICCatalogRow> streetsCollection)
        {
            foreach (var item in streetsCollection)
            {
                Console.WriteLine($"Nazwa: {item.NAZWA_1}  Cecha: {item.CECHA}");
            }
        }


        public static void printLocalities(IEnumerable<SIMCCatalogRow> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.NAZWA);
            }
        }

        public static terytCatalogRow findMunicipality(string teryt)
        {
            if (tercData == null)
                loadTERCData();

            foreach (var m in tercData.catalog.row)
            {
                if (m.WOJ == byte.Parse(teryt.Substring(0, 2)) &&
                    m.POW == teryt.Substring(2, 2) &&
                    m.GMI == teryt.Substring(4, 2) && 
                    m.RODZ == teryt.Substring(6, 1))
                    return m;
            }

            return null;
        }

        public static SIMCCatalogRow findLocality(string sym)
        {
            if (tercData == null)
                loadSIMCData();

            foreach (var m in simcData.catalog.row)
            {
                if (m.SYM == uint.Parse(sym))
                    return m;
            }

            return null;
        }


        public static IEnumerable<SIMCCatalogRow> readLocalities(string teryt)
        {
            if (simcData == null)
                loadSIMCData();

            var res = from s in simcData.catalog.row
                      where s.WOJ == byte.Parse(teryt.Substring(0, 2)) &&
                      s.POW == byte.Parse(teryt.Substring(2, 2)) &&
                      s.GMI == byte.Parse(teryt.Substring(4, 2)) &&
                      s.RODZ_GMI == byte.Parse(teryt.Substring(6, 1))
                      select s;

            return res;
        }


        public static IEnumerable<ULICCatalogRow> readStreets(string sym)
        {
            if (ulicData == null)
                loadULICData();

            var res = from u in ulicData.catalog.row
                      where u.SYM == uint.Parse(sym)
                      select u;

            return res;
        }
    }
}
