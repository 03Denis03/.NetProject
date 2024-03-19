using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public abstract class ProdusAbstract:IPackageable
    {
        public string? Name { get; set; }
        public string? CodIntern { get; set; }
        public int Id { get; set; }
        public string? Categorie { get; set; }
        public float Pret { get; set; }
        public ProdusAbstract(String? name, String? codIntern, int id, string? categorie, float pret)
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
    }
}
