using System;
using System.Collections.Generic;
using System.Text;

namespace metier
{
    class fromage
    {
        private int _id;
        private int _pays_origine_id;
        private string _nom;
        private datetime _creation;
        private string _image;

        public fromage (int id, int pays_origine_id, string nom, datetime creation, string image)
        {
            _id=id;
            _pays_origine_id=pays_origine_id;
            _nom=nom;
            _creation=creation;
            _image=image;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Pays_origine_id { get => _pays_origine_id; set => _pays_origine_id = value; }
        public datetime Creation { get => _creation; set => _creation = value; }
        public string Image { get => _image; set => _image = value; }
    }
    
}