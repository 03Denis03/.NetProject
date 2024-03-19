using Entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorPOO1
{
    internal abstract class ProdusAbstractMgr
    {
        protected ProdusAbstract[] elemente = new ProdusAbstract[100];
        public int CountElemente { get; set; } = 0;
        public int Id { get; set; } = 0;

        public void Write2Console()
        {
            for (int i = 0; i < CountElemente; i++)
            {
                Console.WriteLine(elemente[i].Descriere2());
                
            }
        }

        protected bool VerifyUnicity(ProdusAbstract item)
        {
            for (int i = 0; i < CountElemente; i++)
            {
                if (elemente[i].CompareObject(item))
                {
                    return true;
                }
            }
            return false;
        }


        public void ReadAbsProd(ProdusAbstract item)
        {
            if (!VerifyUnicity(item))
            {
                elemente[CountElemente] = item;
                CountElemente++; 
                Id++;
            }
        }
        
    }
}
