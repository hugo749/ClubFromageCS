using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    class DAOPays
    {
        private dbal _dbal = new dbal();

        public void insert (pays unpays)
        {
            string query = " pays values " + "(" + unpays.getIdPays() + ",'" + unpays.getNom() + "');";
            _dbal.Insert(query);
        }

    }
}