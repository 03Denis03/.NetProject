using Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorPOO1
{
    internal class ServiciiMgr:ProdusAbstractMgr
    {
        private Serviciu userInputData(int id)
        {
            String? nume;
            String? codIntern;

            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            nume = Console.ReadLine();

            Console.Write("Codul intern:");
            codIntern = Console.ReadLine();

            return new Serviciu(id, nume, codIntern);
        }

        public void ReadAbsProds(int number)
        {
            Serviciu serviciu;
            int cnt = CountElemente;
            for (int i = cnt; i < cnt + number; i++)
            {
                serviciu = userInputData(Id);
                ReadAbsProd(serviciu);
            }
        }


    }
}
