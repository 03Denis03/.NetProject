﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public abstract class ProdusAbstract
    {
        public ProdusAbstract(String? name, String? codIntern, int id)
        {
            Name = name;
            CodIntern = codIntern;
            Id = id;
        }

        public ProdusAbstract() { }

        public string? Name { get; set; }
        public string? CodIntern { get; set; }
        public int Id { get; set; }

        public virtual string Descriere()
        {
            return Name + "[" + CodIntern + "] " + Id + " ";
        }
        public abstract string Descriere2();

        public virtual bool CompareObject(ProdusAbstract itemToAdd)
        {
            if (this.Name == itemToAdd.Name && this.CodIntern == itemToAdd.CodIntern)
            {
                return true;
            }
            return false;
        }
    }
}
