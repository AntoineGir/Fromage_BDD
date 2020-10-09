using System;
using System.Collections.Generic;
using System.Text;
using Fromage_BDD;
using Model.business;
using Model.data;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Model.data
{
    class DaoPays
    {


        dbal NewDbal = new dbal();

        public DaoPays(dbal mydbal)
        {
            this.NewDbal = mydbal;
        }

        public void insert(Pays pays)
        {
            NewDbal.Insert("INSERT INTO pays(id, nom) VALUES(" + pays.Id + ", '" + pays.Nom.Replace("'", "''") + "')");


        }

        public void delete(Pays pays)
        {

            NewDbal.Delete("DELETE FROM pays where id = '" + pays.Id + "';");



        }

        public void update(Pays pays)
        {
            NewDbal.Update("update pays set id=" + pays.Id + ", nom='" + pays.Nom + "';");
        }

        public void insertfil()
        {
            using (var reader = new StreamReader("pays.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var record = new Pays();
                IEnumerable<Pays> records = csv.EnumerateRecords(record);
                Console.WriteLine(records);
                foreach (var r in records)
                {
                    insert(r);
                }
            }
        }
        

    }
}
