using System;
using System.Collections.Generic;
using System.Text;
using Fromage_BDD;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace metier
{
    class Pays
    {
        private int id;
        private string nom;

        public Pays(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public Pays()
        {
            id = 0;
            nom = ".";
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }


        

    }

}
