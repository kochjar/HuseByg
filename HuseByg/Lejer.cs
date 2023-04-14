using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class Lejer
    {
        private string _id;
        private string _navn;
        private string _cpr_nr;
        private string _tlf_nr;
        private string _mail;
        private int _husdyr;
        private Hus _hus;
        private Lejemål _lejemål;
        private static int count = 0;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
       
        public string navn { 
            get { return _navn; } 
            set { _navn = value; } 
        }

        private string cpr_nr
        {
            get { return _cpr_nr; }
            set { _cpr_nr = value; }
        }
        public string tlf_nr
        {
            get { return _tlf_nr; }
            set { _tlf_nr = value; }
        }

        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public int husdyr
        {
            get { return _husdyr; }
            set { _husdyr = value; }
        }

        public Hus hus
        {
            get { return _hus; }    
            set { _hus = value; }
        }

        public Lejemål lejemål
        {
            get { return _lejemål;}
            set { _lejemål = value;}
        }

        public Lejer(string navn, string cpr_nr, string tlf_nr, string mail, int husdyr, Hus hus)
        {
            count++;
            this._id = $"L{count}";
            this.navn = navn;
            this.cpr_nr = cpr_nr;
            this.husdyr = husdyr;
            this.hus = hus;
            this.tlf_nr=tlf_nr;

        }


        public void TilføjLejemål(Lejemål lejemål)
        {
            this._lejemål = lejemål;
        }



    }
}
