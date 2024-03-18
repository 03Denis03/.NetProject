using Entitati;
using System.Reflection.Metadata;
namespace ProiectLaboratorPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //citire si afisare obicte de tipul Produs
            ProduseMgr produseMgr = new ProduseMgr();
            Console.Write("Nr. produse:");
            int nrProduse = int.Parse(Console.ReadLine() ?? string.Empty);
            produseMgr.ReadProduse(nrProduse);
            produseMgr.WriteProduse();


            ServiciiMgr serviciiMgr = new ServiciiMgr();
            Console.WriteLine("Nr. Servicii: ");
            int NrServicii = int.Parse(Console.ReadLine() ?? String.Empty);
            serviciiMgr.ReadServicii(NrServicii);
            serviciiMgr.WriteServicii();
        }
    }
}
