using metier;
using System;
using System.Collections.Generic;
using System.Text;
using model;

namespace model
{
    class DAOPays 
    {
        private dbal _dbal;

        public DAOPays (dbal mydbal)
        {
            this._dbal = mydbal;
        }

        public void insert (pays pays)
        {
          
            string query = " pays values " + "(" + pays.Id + ",'" + pays.Nom + "');";
            _dbal.Insert(query);
        }

        public void delete (pays pays)
        {
            string query = " FROM pays where id = " + pays.Id + ";" ;
            _dbal.Delete(query);
        }

        public void update (pays pays)
        {
            string query = " pays set nom = 'Allemagne' where id = "+pays.Id+";";
            _dbal.Update(query);
        }


    }
}