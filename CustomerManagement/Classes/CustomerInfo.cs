using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerManagement.Classes
{
    public class CustomerInfo
    {
        private readonly int _id;
        public int Id {
            get { return _id; }
        }

        private readonly string _name;
        public string Name {
            get { return _name; }
        }

        private readonly string _phone_number;
        public string PhoneNumber {
            get { return _phone_number; }
        }


        public CustomerInfo(int id, string name, string phone_number)
        {
            this._id = id;
            this._name = name;
            this._phone_number = phone_number;
        }
    }
}
