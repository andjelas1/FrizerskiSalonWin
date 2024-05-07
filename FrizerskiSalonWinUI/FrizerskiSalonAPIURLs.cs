namespace FrizerskiSalonWinUI
{
    internal static class FrizerskiSalonAPIURLs
    {
        private static string domain = "http://localhost:5048";
        internal static string novaUslugaAPI = $"{domain}/usluga";
        internal static string sveUslugeAPI = $"{domain}/usluga/sveusluge";
        internal static string sviRadniciZaUsluguAPI = $"{domain}/usluga/tretmani";
        internal static string snimiUlsugaRadnikAPI = $"{domain}/usluga/snimiUlsugaRadnik";

        internal static string noviRadnikAPI = $"{domain}/radnik";
        internal static string sviRadniciAPI = $"{domain}/radnik/sviradnici";
        internal static string radnoVremeRadnikaAPI = $"{domain}/radnik/radnovreme";
        internal static string noviRasporedRadnikaAPI = $"{domain}/radnik/noviraspored";

        internal static string pronadjiTerminZaZahtev = $"{domain}/zakazivanje/pronadjitermin";
    }
}
