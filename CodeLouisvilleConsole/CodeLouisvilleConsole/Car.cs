using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleConsole
{
    public class Car
    {
        private int _id;
        private string _make;
        private string _model;
        private DateTime _year;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    _id = 0;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public DateTime Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
}
