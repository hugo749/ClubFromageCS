using System;
using MySql;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections;
using model;
using metier;

namespace DEB
{
    class Program
    {

 
        static void Main(string[] arg)
        {

            dbal ledbal = new dbal();
            //FP.Execquery("INSERT INTO Pays (id, nom) values (1, 'France')");
            pays unpays = new pays(2, "France");
            DAOPays pays = new DAOPays(ledbal);
            
            //pays.insert(unpays);
            //pays.delete(unpays);
            //pays.update(unpays);


            fromage fromage = new fromage(1, 1, "'raclette'", "'09/09/2020'", "image");
            DAOFromage lefromage = new DAOFromage(ledbal);

            lefromage.insert(fromage);
            //fromage.delete(lefromage);
            //fromage.update(lefromage);
        }

    }
}
