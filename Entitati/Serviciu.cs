using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati
{
    public class Serviciu:ProdusAbstract
    {
        public int ServiceNumber { get; set; }
        public Serviciu(int id, string? nume, string? codIntern, string? categorie, float pret):base(nume, codIntern, id, categorie, pret)
        {
            
        }
        public Serviciu():base() { }
        /* public override string Descriere()
         {
             return base.Descriere();
         }

         public override string Descriere2()
         {
             return "Serviciul: " + this.Name + "[" + this.CodIntern
             + "] ";
         }*/

        public void setTheNumberOfServices()
        {
            Console.WriteLine("Seteaza Numarul de produse din pachet: ");
            ServiceNumber = int.Parse(Console.ReadLine() ?? string.Empty);

            // serializare date in XML
            DataSet ds = new DataSet();
            ds.Tables[0].Columns.Add("Setting", typeof(int));

            // add a new row to the first table of the DataSet
            DataRow newRow = ds.Tables[0].NewRow();
            newRow["Setting"] = ServiceNumber;
            ds.Tables[0].Rows.Add(newRow);

            ds.WriteXml("setting.xml");
        }
        public override bool CompareObject(ProdusAbstract itemToAdd)
        {
            return base.CompareObject(itemToAdd);
        }


        public static bool operator ==(Serviciu serv1, Serviciu serv2)
            => ((serv1.Name == serv2.Name) && (serv1.CodIntern == serv2.CodIntern));
        public static bool operator !=(Serviciu serv1, Serviciu serv2)
            => ((serv1.Name != serv2.Name) && (serv1.CodIntern != serv2.CodIntern));

        public override bool Equals(object? obj)
        {
            if ((obj is Serviciu) && (this == (Serviciu)obj))
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"Serviciul: {Name}[{CodIntern}] {Categorie} {Pret}";
        }

        public override bool canAddToPackage(Pachet pch)
        {
            foreach (Serviciu e in pch.Elemente_pachet)
            {
                if (e.CompareObject(this))
                    return true;
            }
            return false;

        }

    }

}
