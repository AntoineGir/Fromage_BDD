using System;
using System.Collections.Generic;
using System.Text;

namespace Fromage_BDD
{
    class DaoFromage
    {
        private int _id;
        private int pays_origine_id;
        private string _nom;
        //private DateTime _creation;
        private string _image;

        public int Id { get => _id; set => _id = value; }
        public int Pays_origine_id { get => pays_origine_id; set => pays_origine_id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        //public DateTime Creation { get => _creation; set => _creation = value; }
        public string Image { get => _image; set => _image = value; }

        public void insert(int id, int pays_origine_id, string nom, string image)
        {
            dbal insert = new dbal();
            string FromageInsert;

            FromageInsert = ("INSERT INTO fromage(id,pays_origine_id, nom, image ) VALUES(" + id + "," + pays_origine_id +
                ",'" + nom + "','" + image + "')");

            insert.Insert(FromageInsert);
        }

        public void delete(int id)
        {
            dbal delete = new dbal();
            string FromageDelete;

            FromageDelete = ("DELETE FROM fromage where id = '" + id + "';");

            delete.Delete(FromageDelete);
        }

        public void update(int id, int pays_origine_id, string nom, string image)
        {
            dbal update = new dbal();
            string FromageUpdate;

            FromageUpdate =("update fromage set id=" + id + ", pays_origine_id=" + pays_origine_id + ",nom='" + nom + "',image='" + image + "';");

        }
    }
}
