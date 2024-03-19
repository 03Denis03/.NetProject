using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Entitati;

namespace ProiectLaboratorPOO1
{
    public class ProduseMgr:ProdusAbstractMgr
    {
        
        public Produs userInputData(int id)
        {
            string? nume;
            string? codIntern;
            string? producator;

            string? categorie;
            float pret;

            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            nume = Console.ReadLine();

            Console.Write("Codul intern:");
            codIntern = Console.ReadLine();
            Console.Write("Producator:");
            producator = Console.ReadLine();
            Console.WriteLine("Categoria: ");
            categorie = Console.ReadLine();

            Console.WriteLine("Pret: ");
            pret = float.Parse(Console.ReadLine() ?? string.Empty);
            return new Produs(id, nume, codIntern, producator, categorie, pret);
        }// citim datele unui produs
        public void ReadAbsProds(int number)
        {
            Produs produs;
            
            for (int i = 0; i < number; i++)
            {
                produs = userInputData(Id);
                ReadAbsProd(produs);
            }
        }

        public void InitListafromXML()
        {
            //initializare lista dintr-un fisier XML
            XmlDocument doc = new XmlDocument();
            //incarca fisierul
            doc.Load("C:\\All folder\\C# POO\\POS\\ProiectLaboratorPOO1\\XML\\produse.xml"); //calea spre fisier
                                        //selecteaza nodurile
            XmlNodeList lista_noduri = doc.SelectNodes("/produse/produs");
            foreach (XmlNode nod in lista_noduri)
            {
                //itereaza si selecteaza simpurile fiecarui nod si
                //informatia continuta in cadrul proprietatii InnerText
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                string producator = nod["Producator"].InnerText;
                float pret = float.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;
                //adauga in lista produse
                elemente.Add(new Produs(elemente.Count + 1, nume, codIntern, producator, categorie, pret));
            }
        }
        public void Exista()
        {
            Console.WriteLine("Cauta un produs dupa toata descrierea sa: ");

            Produs produs = userInputData(-1);
            if (Contine(produs))
                Console.WriteLine("Am gasit produsul in lista de produse");
            else Console.WriteLine("Acest produs nu exista in lista noastra de produse");
        }

        
        

    }

}
