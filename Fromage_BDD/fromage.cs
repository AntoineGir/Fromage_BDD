using System;
using System.Collections.Generic;
using System.Text;

namespace Fromage_BDD
{
    class Fromage
    {
        private int id;
        private int pays_origine_id;
        private string nom;
        private int creation;
        private string image;

        public Fromage(int id, int pays_origine_id, string nom, int creation, string image)
        {
            this.id = id;
            this.pays_origine_id = pays_origine_id;
            this.nom = nom;
            this.creation = creation;
            this.image = image;
        }

        public int Id { get => id; set => id = value; }
        public int Pays_origine_id { get => pays_origine_id; set => pays_origine_id = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Creation { get => creation; set => creation = value; }
        public string Image { get => image; set => image = value; }
    }
}
