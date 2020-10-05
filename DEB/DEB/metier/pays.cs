using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    class pays
    {
        private int _id;
        private string _nom;

        public pays (int id, string nom)
        {
            _id = id;
            _nom = nom;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
    }
}