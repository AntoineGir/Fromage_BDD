using System;

namespace Fromage_BDD
{
    class Program
    {
        static void Main(string[] args)
        {
            dbal db = new dbal();
            
            
            db.ExecQuery("INSERT INTO pays (id, nom) VALUES (11, 'savoie' )");

        }
    }
}
