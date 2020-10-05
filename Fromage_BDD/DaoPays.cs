using System;
using System.Collections.Generic;
using System.Text;

namespace Fromage_BDD
{
    class DaoPays
    {
        private int _id;
        private string _nom;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }


        public void insert(int id, string nom)
        {
            dbal insert = new dbal();
            string PaysInsert;

            PaysInsert = ("INSERT INTO pays(id, nom) VALUES(" + id + ", '" + nom + "')");

            insert.Insert(PaysInsert);
        }

        public void delete(int id)
        {
            dbal delete = new dbal();
            string PaysDelete;
            PaysDelete = ("DELETE FROM pays where id = '"+ id + "';");

            delete.Delete(PaysDelete);

        }

        public void update(int id, string nom)
        {
            dbal update = new dbal();
            string PaysUpdate;

            PaysUpdate = ("update pays set id=" + id + ", nom='" + nom + "';");
            update.Update(PaysUpdate);

        }

    }
}
