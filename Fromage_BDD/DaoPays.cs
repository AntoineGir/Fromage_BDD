using System;
using System.Collections.Generic;
using System.Text;
using Fromage_BDD;
using modele;
using metier;

namespace modele
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
            NewDbal.Insert("INSERT INTO pays(id, nom) VALUES(" + pays.Id + ", '" + pays.Nom + "')");

            
        }

        public void delete(Pays pays)
        {
            
            NewDbal.Delete("DELETE FROM pays where id = '"+ pays.Id + "';");

 

        }

        public void update(Pays pays)
        {
            NewDbal.Update("update pays set id=" + pays.Id + ", nom='" + pays.Nom + "';");
        }

    }
}
