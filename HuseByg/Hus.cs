using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class Hus
    {
        private string _id;
        private string _adresse;
        private static int count = 0;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public Hus(string adresse)
        {
            count++;
            this._id = $"#{count}"; 
            this._adresse = adresse;
        }
    }
}
