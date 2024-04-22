using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entitati
{
    public class Pachet:ProdusAbstract, IComparer<ProdusAbstract>
    {
        public List<IPackageable> Elemente_pachet { get; set; } = new List<IPackageable>();
        public int ProdNumber { get; set; }
        public int ServNumber { get; set; }

        public Pachet() 
        { 

        }

        public void setTheNumberOfProducts()
        {
            Console.WriteLine("Seteaza Numarul de produse din pachet: ");
            ProdNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            // serializare date in XML
            DataSet ds = new DataSet();

            // create a new table and add it to the dataset
            DataTable table = new DataTable("Settings");
            table.Columns.Add("Value", typeof(int));
            ds.Tables.Add(table);

            // add the value to the table
            ds.Tables["Settings"].Rows.Add(ProdNumber);

            Console.WriteLine("Seteaza Numarul de servicii din pachet: ");
            ServNumber = int.Parse(Console.ReadLine() ?? string.Empty);
            ds.Tables["settings"].Rows.Add(ServNumber);

            // save the dataset to an XML file
            ds.WriteXml("C:\\All folder\\C# POO\\POS\\ProiectLaboratorPOO1\\XML\\setting.xml");
        }

        public string ElemPachetToString()
        {
            if (Elemente_pachet == null)
            {
                return string.Empty;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach(ProdusAbstract el in this.Elemente_pachet)
                    sb.Append('\t' + el.ToString() + '\n');
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return "Pachet: " + base.ToString() + '\n' + ElemPachetToString();
        }



        public override bool canAddToPackage(Pachet pch)
        {
            return false;
        }


        public int CompareTo(ProdusAbstract x)
        {
            return Pret.CompareTo(x.Pret);
        }

        public int Compare(Pachet first, Pachet second)
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
