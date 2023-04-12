using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuseByg
{
    public class Lejemål
    {
        private string _id;
        private DateTime _startdato;
        private DateTime _slutdato;
        private static int count = 0;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime startdato
        {
            get { return _startdato; }
            set { _startdato = value; }
        }
        public DateTime slutdato
        {
            get { return _slutdato; }
            set { _slutdato = value; }
        }

        public Lejemål(DateTime startdato, DateTime slutdato)
        {
            count++;
            this._id = $"#{count}";
            this._startdato = startdato;
            this._slutdato= slutdato;
        }
    }
}
