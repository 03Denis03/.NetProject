using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public class Serviciu:ProdusAbstract
    {
        public Serviciu(int id, string? nume, string? codIntern):base(nume, codIntern, id)
        {
            
        }
        public Serviciu():base() { }
        public override string Descriere()
        {
            return base.Descriere();
        }


        public bool CompareObject(Serviciu itemToAdd, Serviciu itemForCompare)
        {
            if (itemForCompare.Name == itemToAdd.Name && itemForCompare.CodIntern == itemToAdd.CodIntern)
            {
                return true;
            }
            return false;
        }
    }

}
