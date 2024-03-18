using Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorPOO1
{
    internal class ServiciiMgr
    {
        private int Count=0;
        Serviciu[] servicii = new Serviciu[100];
        int idS = 0;
        bool condition = false;
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

        public void ReadServicii(int nrServicii)
        {
            if(nrServicii == 1) 
            {
                ReadServiciu();
            }
            else if(nrServicii > 1) 
            {
                for (int cnt = 0; cnt < nrServicii; cnt++)
                {
                    ReadServiciu();
                }
            }
            
        }

        public void ReadServiciu()
        {
            
            Serviciu serv = userInputData(idS);
            if (Count == 0)
            {
                servicii[0] = serv;
                Count++;
                idS++;
            }
            else 
            {
                for (int i = 0; i < Count; i++)
                {
                    condition = serv.CompareObject(serv, servicii[i]);
                    if (condition)
                    {
                        break;
                    }
                }
                if (!condition)
                {
                    servicii[Count] = serv;
                    Count++;
                    idS++;
                }
            }
        }

        public void WriteServicii()
        {
            Serviciu serv = new Serviciu();
            for (int cnt = 0; cnt < Count; cnt++)
            {
                Console.WriteLine(servicii[cnt].Descriere());
            }
        }
    }
}
