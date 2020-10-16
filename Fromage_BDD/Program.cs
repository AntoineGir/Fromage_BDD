using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Fromage_BDD;
using Model.business;
using Model.data;

namespace Fromage_BDD
{
    class Program
    {
        static void Main(string[] args)
        {

            dbal NewDBal = new dbal();
            //Pays pays1 = new Pays(1, "france");
            DaoPays DaoPays1 = new DaoPays(NewDBal);
            //DaoPays1.delete(pays1);

            //DaoPays1.insert(pays1);
            //DaoPays1.update(pays1);
            //Fromage Fromage1 = new Fromage(1, 1, "Camenbert", 12, "cc");
            DaoFromage DaoFromage1 = new DaoFromage(NewDBal);
            //DaoFromage1.delete(Fromage1);

            //DaoFromage1.update(Fromage1);
            Console.WriteLine("test");
            //DaoPays1.update(pays1);
            //DaoPays1.update(pays1);

            //DaoPays1.insertfil();

            //Console.WriteLine("fin program");

            DataSet lespays = NewDBal.RQuery("select * from pays");
            /*
           foreach (DataRow r in lespays.Tables[0].Rows)
           {
               Console.WriteLine(r["nom"]);

           }
           
            //selectALL
            foreach (DataRow r in NewDBal.SelectAll("Pays").Rows)
            {
                Console.WriteLine(r["id"] + "    " + r["nom"]);
            }

            Console.WriteLine("SelectByFIeld :");

            //SelectByFIeld
            foreach (DataRow r in NewDBal.SelectByField("pays", " nom like 'P%'").Rows)
            {
                Console.WriteLine(r["id"] + "    " + r["nom"]);
            }

            Console.WriteLine("SelectByld :");
            DataRow id1 = NewDBal.SelectByld("pays", 1);
            Console.WriteLine(id1["id"] + "    " + id1["nom"]);

            */


            /*DaoPays1.selectAll();*/


            /*DaoPays1.SelectByName("France");

            DaoPays1.SelectById(50);*/
            //DaoFromage1.insertfil();
            DaoFromage1.selecAll();


        }
    }
} 