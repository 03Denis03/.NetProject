using Entitati;

namespace ProiectLaboratorPOO1
{
    internal class MeniuInteractiv
    {
        ProduseMgr prod = new ProduseMgr();
        ServiciiMgr serv = new ServiciiMgr();
        Pachet pch = new Pachet();
        PachetMgr pchMgr = new PachetMgr();
        public void Menu()
        {

            Console.WriteLine("Salut! Ne bucuram ca ai ales programul nostru pentru organizarea produselor tale.");
            Console.WriteLine("Cu ce te putem ajuta azi?");
            int op;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                optiuniMeniu();
                Console.Write("Alege o optiune: ");
                op = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.ForegroundColor = ConsoleColor.Gray;
                actiuniMeniu(op);
            } while (op != 0);
        }
        private void optiuniMeniu()
        {
            Console.WriteLine("0. Inchide programul");
            Console.WriteLine("1. Incarca produsele si serviciile din fisierul Xml");
            Console.WriteLine("2. Introdu produse de la tastatura");
            Console.WriteLine("3. Introdu servicii de la tastatura");
            Console.WriteLine("4. Cauta un produs dupa toate informatiile sale");
            Console.WriteLine("5. Cauta un serviciu dupa toate informatiile sale");
            Console.WriteLine("6. Cauta produse cu acelasi nume");
            Console.WriteLine("7. Cauta servicii cu acelasi nume");
            Console.WriteLine("8. Afiseaza produsele");
            Console.WriteLine("9. Afiseaza serviciile");
            Console.WriteLine("10. Afiseaza produsele si serviciile");
            Console.WriteLine("11. Actualizeaza setarile");
            Console.WriteLine("12. Adauga pachete de la tastatura");
            Console.WriteLine("13. Afiseaza pachetele");
            Console.WriteLine("14. Incarca pachetele din xml");
            Console.WriteLine("15. Filtrare dupa categorie");
            Console.WriteLine("16. Filtrare dupa pret");
        }
        private void actiuniMeniu(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("Multumim ca ati ales programul nostru.");
                    break;
                case 1:
                    Console.Clear();
                    prod.InitListafromXML();
                    serv.InitListafromXML();
                    prod.Sortare();
                    serv.Sortare();
                    Console.WriteLine("Incarcarea a avut succes!");
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Nr. produse:");
                    int nrProduse = int.Parse(Console.ReadLine() ?? string.Empty);
                    prod.ReadAbsProds(nrProduse);
                    prod.Sortare();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Nr. Servicii: ");
                    int NrServicii = int.Parse(Console.ReadLine() ?? String.Empty);
                    serv.ReadAbsProds(NrServicii);
                    serv.Sortare();
                    break;
                case 4:
                    Console.Clear();
                    prod.Exista();
                    break;
                case 5:
                    Console.Clear();
                    serv.Exista();
                    break;
                case 6:
                    Console.Clear();
                    prod.CautaDupaNume();
                    break;
                case 7:
                    Console.Clear();
                    serv.CautaDupaNume();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Produsele sunt");
                    prod.afisare();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Serviciile sunt");
                    serv.afisare();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Produsele si serviciile sunt: ");
                    prod.afisare();
                    serv.afisare();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("Seteaza numarul de produse si servicii");
                    pch.setTheNumberOfProducts();
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("Introdu Pachete");
                    Console.Write("cate Pachete introduci: ");
                    int number = int.Parse(Console.ReadLine() ?? string.Empty);
                    pchMgr.readPachet(number);
                    pchMgr.Sortare();
                    break;
                case 13:
                    Console.Clear();
                    pchMgr.afis();
                    break;
                case 14:
                    Console.Clear();
                    pchMgr.InitListafromXML();
                    pchMgr.Sortare();
                    Console.WriteLine("Incarcarea a avut loc cu succes!");
                    break;
                case 15:
                    Console.Clear();
                    Console.WriteLine("Introdu categoria dorita: ");
                    pchMgr.FiltrareDupaCategorieProd();
                    break;
                case 16:
                    Console.Clear();
                    Console.WriteLine("Introdu filtrul de pret: ");
                    pchMgr.FiltrareDupaPretProd();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Nu avem optiunea solicitata!");

                    break;
            }
        }

    }
}
