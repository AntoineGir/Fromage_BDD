using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Model.business;
using Model.data;
using System.Data;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Model.data
{
    class DaoFromage
    {

        dbal NewDbal = new dbal();

        public DaoFromage(dbal mydbal)
        {
            this.NewDbal = mydbal;
        }


        public void insert(Fromage fromage)
        {
            NewDbal.Insert("INSERT INTO fromage(id,pays_origine_id,nom, creation, image ) VALUES(" + fromage.Id + "," + fromage.Pays_origine_id +
                ",'" + fromage.Nom + "','" + fromage.Creation + "','" + fromage.Image + "')");
        }

        public void delete(Fromage fromage)
        {

            NewDbal.Delete("DELETE FROM fromage where id = '" + fromage.Id + "';");
        }

        public void update(Fromage fromage)
        {
            NewDbal.Update("update fromage set id=" + fromage.Id + ",pays_origine_id=" + fromage.Pays_origine_id + ",nom='" + fromage.Nom + "',creation=" + fromage.Creation + ",image='" + fromage.Image + "' where id=" + fromage.Id + ";");
        }

       public void insertfil()
        {
            using (var reader = new StreamReader("fromages.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var record = new Fromage();
                IEnumerable<Fromage> records = csv.EnumerateRecords(record);
                Console.WriteLine(records);
                foreach (var r in records)
                {
                    insert(r);
                }

            }
        }
        
        public List<Fromage> selecAll()
        {
            List<Fromage> ListFromage = new List<Fromage>();

            foreach (DataRow r in NewDbal.SelectAll("Fromage").Rows)
            {
                ListFromage.Add(new Fromage((int)r["id"], (int)r["pays_origine_id"], (string)r["nom"], (int)r["creation"], (string)r["image"]));
            }

            foreach (Fromage x in ListFromage)
            {
                Console.WriteLine("id : " + x.Id + "  " + "nom : " + x.Nom);
            }
            return ListFromage;
        }


        public Fromage SelectById(int id)
        {

        }


        /*
        public Fromage SelectByName(string nameFromage )
        {
            DataRow r = NewDbal.SelectByField("fromage", "nom like '" + nameFromage + "'").Rows[0];

        }*/
    }
}
