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

        public override string Descriere2()
        {
            return "Serviciul: " + this.Name + "[" + this.CodIntern
            + "] ";
        }
        public override bool CompareObject(ProdusAbstract itemToAdd)
        {
            return base.CompareObject(itemToAdd);
        }
    }

}
