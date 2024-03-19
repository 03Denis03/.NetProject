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
    internal class ProduseMgr:ProdusAbstractMgr
    {
        
        public Produs userInputData(int id)
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
        public void ReadAbsProds(int number)
        {
            Produs produs;
            int cnt = CountElemente;
            for (int i = cnt; i < cnt + number; i++)
            {
                produs = userInputData(Id);
                ReadAbsProd(produs);
            }
        }

    }

}
