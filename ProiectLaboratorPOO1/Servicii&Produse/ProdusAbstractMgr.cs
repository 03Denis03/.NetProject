using Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProiectLaboratorPOO1
{
    public abstract class ProdusAbstractMgr
    {
        public List<ProdusAbstract> elemente = new List<ProdusAbstract>();
        //public int CountElemente { get; set; } = 0;
        public int Id { get; set; } = 0;

        public void Write2Console()
        {
            foreach (ProdusAbstract elem in elemente)
            {
                Console.WriteLine(elem.ToString());
                //redefineste toString
            }
        }

        protected bool VerifyUnicity(ProdusAbstract item)
        {
            foreach(ProdusAbstract elem in elemente)
            {
                if (elem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void ReadAbsProd(ProdusAbstract item)
        {
            if (!elemente.Contains(item))
            {
                elemente.Add(item);
                //CountElemente+=1; 
                Id++;
            }
        }

        public bool Contine(ProdusAbstract item)
        {
            return VerifyUnicity(item);
        }

        public List<ProdusAbstract> Contine(String nume)
        {
            List<ProdusAbstract> rezultate = new List<ProdusAbstract>();
            foreach(ProdusAbstract elem in elemente)
            {
                if (elem.Name == nume)
                {
                    rezultate.Add(elem);
            
                }
            }
            return rezultate;
        }

        public void CautaDupaNume()
        {
            Console.WriteLine("Introdu numele produsului");
            string nume = Console.ReadLine();
            IEnumerable<ProdusAbstract> interogare_linq =
            from elem in elemente
            where elem.Name == nume
            select elem;
            foreach(ProdusAbstract elem in interogare_linq)
            {
                Console.WriteLine(elem.ToString());
            }
        }

        public void afisare() 
        { 
            foreach(ProdusAbstract e in elemente)
            {
                Console.WriteLine(e.ToString());
            }
        }

        

    }
}
