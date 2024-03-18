using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Entitati;

namespace ProiectLaboratorPOO1
{
    internal class ProduseMgr
    {
        Produs[] produse = new Produs[100];

        public int Count { get; set; } = 0;

        private Produs userInputData(int id)
        {
            String? nume;
            String? codIntern;
            String? producator;

            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            nume = Console.ReadLine();

            Console.Write("Codul intern:");
            codIntern = Console.ReadLine();
            Console.Write("Producator:");
            producator = Console.ReadLine();
            return new Produs(id, nume, codIntern, producator);
        }// citim datele unui produs
        int idP = 0;
        
        public void ReadProduse(int nrProduse)
        {
            
            if (nrProduse == 1) 
            {
                ReadProdus();
            }
            else if(nrProduse > 1) 
            {
                for (int cnt = 0; cnt < nrProduse; cnt++)
                {
                    ReadProdus();
                }
            }
            
        }
        public void ReadProdus()
        {
            bool condition = false;
            Produs prod = userInputData(idP);
            if(Count == 0)
            {
                produse[0] = prod;
                Count++;
                idP++;
            }
            else 
            {
                for (int i = 0; i < Count; i++)
                {
                    condition = prod.CompareObject(prod, produse[i]);
                    if (condition)
                    {
                        break;
                    }
                }
                if (!condition)
                {
                    produse[Count] = prod;
                    Count++;
                    idP++;
                }
            }
        }
        public void WriteProduse()
        {
            Produs prod = new Produs();
            for (int cnt = 0; cnt < Count; cnt++)
            {
                Console.WriteLine(produse[cnt].Descriere());
            }
        }
    }

}
