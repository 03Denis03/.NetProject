using Entitati;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ProiectLaboratorPOO1
{
    internal class PachetMgr:ProdusAbstractMgr
    {
        public int IdP { get; set; } = 0;

        private Pachet userInputData()
        {
            string? nume;
            string? codIntern;
            string? categorie;
            
            Console.WriteLine("Introdu un pachet");
            Console.Write("Numele:");
            nume = Console.ReadLine();

            Console.Write("Codul intern:");
            codIntern = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            categorie = Console.ReadLine();
            
            Pachet pch;
            IdP++;
            pch= ReadProdServ();
            pch.CodIntern = codIntern;
            pch.Categorie = categorie;
            pch.Name = nume;
            
            return pch;
        }
        public Pachet ReadProdServ()
        {
            float pret = 0;
            Pachet pch = new Pachet();
            ProduseMgr prodmgr = new ProduseMgr();
            ServiciiMgr servmgr = new ServiciiMgr();

            // Read the XML file into a string
            string xmlContent = File.ReadAllText("C:\\All folder\\C# POO\\POS\\ProiectLaboratorPOO1\\XML\\setting.xml");

            // Parse the XML string into an XDocument
            XDocument xmlDoc = XDocument.Parse(xmlContent);

            // Get the values of the first two elements in the XML file
            int prodNumber = int.Parse(xmlDoc.Root.Elements().First().Value);
            int servNumber = int.Parse(xmlDoc.Root.Elements().ElementAt(1).Value);

            // Create the necessary number of Produs and Serviciu objects and add them to the Pachet object
            for (int i = 0; i < prodNumber; i++)
            {
                Produs prod = prodmgr.userInputData(Id);
                    if(prod.canAddToPackage(pch))
                    {
                        pch.Elemente_pachet.Add(prod);
                        Id++;
                        pret = pret + prod.Pret;
                    } 
            }

            for (int i = 0; i < servNumber; i++)
            {
                Serviciu serv = servmgr.userInputData(Id);
                if (serv.canAddToPackage(pch))
                {
                    pch.Elemente_pachet.Add(serv);
                    Id++;
                    pret = pret + serv.Pret;
                }
            }
            pch.Pret = pret;
            return pch;
        }

        public void readPachet(int number)
        {
            for(int i = 0;i < number; i++)
            {
                elemente.Add(userInputData());
            }
        }
        
        public void afis()
        {
            foreach(Pachet pachet in elemente)
            {
                Console.WriteLine(pachet.ToString());
            }
        }

        public void InitListafromXML()
        {
            //initializare lista dintr-un fisier XML
            XmlDocument doc = new XmlDocument();
            //incarca fisierul
            
            doc.Load("C:\\All folder\\C# POO\\POS\\ProiectLaboratorPOO1\\XML\\Pachete.xml"); //calea spre fisier
                                                                                        //selecteaza nodurile
            XmlNodeList lista_noduri = doc.SelectNodes("/pachete/pachet/infoPach");
            foreach (XmlNode nod in lista_noduri)
            {
                Pachet pachet = new Pachet();
                float pret = 0;
                pachet.Name = nod["nume"].InnerText;
                pachet.CodIntern = nod["codIntern"].InnerText;
                pachet.Categorie = nod["categorie"].InnerText;
                XmlNodeList lista_prod = nod.SelectNodes("../produs");
                foreach(XmlNode nodp in lista_prod)
                {
                    string nume = nodp["nume"].InnerText;
                    string codIntern = nodp["codIntern"].InnerText;
                    string producator = nodp["producator"].InnerText;
                    float pretp = float.Parse(nodp["pret"].InnerText);
                    string categorie = nodp["categorie"].InnerText;
                    pret = pret + pretp;
                    //adauga in lista produse
                    pachet.Elemente_pachet.Add(new Produs(Id, nume, codIntern, producator, categorie, pretp));
                    Id++;
                }

                XmlNodeList lista_serv = nod.SelectNodes("../serviciu");
                foreach(XmlNode nodS in lista_serv)
                {
                    //itereaza si selecteaza simpurile fiecarui nod si
                    //informatia continuta in cadrul proprietatii InnerText
                    string nume = nodS["nume"].InnerText;
                    string codIntern = nodS["codIntern"].InnerText;
                    float pretS = float.Parse(nodS["pret"].InnerText);
                    string categorie = nodS["categorie"].InnerText;
                    pret = pret + pretS;
                    //adauga in lista produse
                    pachet.Elemente_pachet.Add(new Serviciu(Id, nume, codIntern, categorie, pretS));
                    Id++;
                }
                pachet.Pret = pret;
                elemente.Add(pachet);
            }
        }

    }

    
}
