using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        private List<Contact> _contacts;
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }
    }
}