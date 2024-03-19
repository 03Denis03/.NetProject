using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public class Produs: ProdusAbstract
    {
        public Produs(int id, string? name, string? codIntern, string? producator):base(name, codIntern, id)
        {
            Producator = producator;
        }
        public Produs():base() { }

        
        public string? Producator { get; set; }


        public override string Descriere()
        {
            return "Produsul: " + base.Descriere() + Producator;
        }

        public override string Descriere2()
        {
            return "Produsul: " + this.Name + "[" + this.CodIntern
            + "] " + this.Producator;
        }

        public override bool CompareObject(ProdusAbstract itemToAdd)
        {
            if (base.CompareObject(itemToAdd) && this.Producator == ((Produs)itemToAdd).Producator)
            {
                return true;
            }
            return false;
        }

    }
}
