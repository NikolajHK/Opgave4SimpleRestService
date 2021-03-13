using System;

namespace Opgave4SimpleRestService.Model
{
    public class Beer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _abv;

        public Beer(int id, string name, int price, int abv)
        {
            Id = id;
            _name = name;
            _price = price;
            _abv = abv;
        }

        public int Id
        {
            get { return _id;}
            set { _id = value; } 

        }

        public string Name
        {
            get { return _name;}

            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name must not be null");
                if (value.Length < 4) throw new ArgumentOutOfRangeException("name","Name must be at least 4 characters long");
                _name = value;
            }

        }

        public int Price
        {
            get { return _price; }

            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("price", "Price must be higher than 0");
                _price = value;
            }

        }

        public int Abv
        {
            get { return _abv; }

            set
            {
                if (value < 0 || value > 100 ) throw new ArgumentOutOfRangeException("abv", "Alcohol by value must be between 0 and 100");
                _abv = value;
            }

        }

    }
}
