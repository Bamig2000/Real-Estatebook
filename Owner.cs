using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT5
{
    class Owner
    {
        protected internal string id, name, surname, address, email, dateofbirth;
        protected internal long phonenumber;

        public Owner(string id, string name, string surname, string address, long phonenumber, string email, string dateofbirth)
        {
            id = ID;
            name = Name;
            surname = Surname;
            address = Address;
            phonenumber = Phonenumber;
            email = Email;
            dateofbirth = Dateofbirth;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Dateofbirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }

        }
        public long Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }

    }


}
