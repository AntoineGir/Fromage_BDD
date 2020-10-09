using System;
using System.Collections.Generic;
using System.Text;
using modele;

namespace Fromage_BDD
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
    }
}
