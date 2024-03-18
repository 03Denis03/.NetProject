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

        public bool CompareObject(Produs itemToAdd, Produs itemToCompare)
        {
            if (itemToCompare.Name == itemToAdd.Name && itemToCompare.CodIntern == itemToAdd.CodIntern &&
                    itemToCompare.Producator == itemToAdd.Producator)
            {
                return true;
            }
            return false;
        }

    }
}
