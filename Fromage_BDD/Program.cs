using System;
using System.Collections;
using System.Collections.Generic;

namespace Fromage_BDD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DaoPays Pays1 = new DaoPays();
            DaoFromage Fromage1 = new DaoFromage();

            //Pays1.insert(1, "france");
            //Pays1.delete(20);
            //Fromage1.insert(1, 1, "Camenbert", "etc.");
            //Fromage1.update(1, 1, "Rebloche", "etc.");

            Pays1.update(1, "Haute");

        }
    }
}
