using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public abstract class ProdusAbstract:IPackageable, IComparer<ProdusAbstract>
    {
        public string? Name { get; set; }
        public string? CodIntern { get; set; }
        public int Id { get; set; }
        public string? Categorie { get; set; }
        public int Pret { get; set; }
        public ProdusAbstract(String? name, String? codIntern, int id, string? categorie, int pret)
        {
            Name = name;
            CodIntern = codIntern;
            Id = id;
            Categorie = categorie;
            Pret = pret;
        }

        public ProdusAbstract() { }

        /*public virtual string Descriere()
        {
            return Name + "[" + CodIntern + "] " + Id + " ";
        }*/
        //public abstract string Descriere2();

        public virtual bool CompareObject(ProdusAbstract itemToAdd)
        {
            if (this.Name == itemToAdd.Name && this.CodIntern == itemToAdd.CodIntern)
            {
                return true;
            }
            return false;
        }

        public virtual bool canAddToPackage(Pachet pch)
        {
            return false;
        }
        public override string ToString()
        {
            return $"{Name}[{CodIntern}] {Categorie} {Pret}";
        }

        public int CompareTo(ProdusAbstract x)
        {
            return Pret.CompareTo(x.Pret);
        }

        public int Compare(ProdusAbstract first, ProdusAbstract second)
        {
            if (first != null && second != null)
            {
                // We can compare both properties.
                return first.Pret.CompareTo(second.Pret);
            }

            if (first == null && second == null)
            {
                // We can't compare any properties, so they are essentially equal.
                return 0;
            }

            if (first != null)
            {
                // Only the first instance is not null, so prefer that.
                return -1;
            }

            // Only the second instance is not null, so prefer that.
            return 1;
        }
    }
}
