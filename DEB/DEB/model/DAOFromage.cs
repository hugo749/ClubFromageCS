using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using metier;
using model;

namespace model
{
    class DAOFromage 
    {
        private dbal _dbal;

        public DAOFromage(dbal mydbal)
        {
            this._dbal = mydbal;
        }

        public void insert(fromage lefromage)
        {

            string query = " fromage values " + "(" + lefromage.Id + "," + lefromage.Paysorigineid + ","+ lefromage.Nom + ","+lefromage.Creation+","+lefromage.Image+");";
            _dbal.Insert(query);
        }

        public void delete(fromage lefromage)
        {
            string query = " FROM fromage where id = " + lefromage.Id + ";";
            _dbal.Delete(query);
        }

        public void update(fromage lefromage)
        {
            string query = " fromage set nom = 'tome' where id = " + lefromage.Id + ";";
            _dbal.Update(query);
        }

    }
}