using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Fromage_BDD;
using metier;
using modele;

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
            //DaoFromage DaoFromage1 = new DaoFromage(NewDBal);
            //DaoFromage1.delete(Fromage1);

            //DaoFromage1.update(Fromage1);
            Console.WriteLine("test");
            //DaoPays1.update(pays1);
            //DaoPays1.update(pays1);

            DaoPays1.insertfil();

            Console.WriteLine("fin program");
        }
    }
}
