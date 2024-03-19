using Entitati;
using System.Reflection.Metadata;
namespace ProiectLaboratorPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //citire si afisare obicte de tipul Produs
            Produs prod = new Produs();
            ProduseMgr produseMgr = new ProduseMgr();
            Console.Write("Nr. produse:");
            int nrProduse = int.Parse(Console.ReadLine() ?? string.Empty);
            produseMgr.ReadAbsProds(nrProduse);

            Serviciu serv = new Serviciu();
            ServiciiMgr serviciiMgr = new ServiciiMgr();
            Console.WriteLine("Nr. Servicii: ");
            int NrServicii = int.Parse(Console.ReadLine() ?? String.Empty);
            serviciiMgr.ReadAbsProds(NrServicii);
            
            produseMgr.Write2Console();
            serviciiMgr.Write2Console();
        }
    }
}
