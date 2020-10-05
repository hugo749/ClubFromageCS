using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    class DAOFromage
    {
        private dbal _dbal = new dbal();

        public void insert (fromage unfromage)
        {
            string query = " pays values " + "(" + unfromage.getIdPays() + ",'" + unfromage.getNom() + "');";
            _dbal.Insert(query);
        }

    }
}