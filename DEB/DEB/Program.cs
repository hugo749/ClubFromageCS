using System;
using MySql;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections;

namespace DEB
{
    class Program
    {
       
        static void Main(string[] arg)
        {
            DBConnect FP = new DBConnect();
            //FP.Execquery("INSERT INTO Pays (id, nom) values (1, 'France')");
            pays unpays = new pays(2, "Suisse");
            DAOPays pays = new DAOPays();
            pays.INSERT(unpays);
        }

    }
}
