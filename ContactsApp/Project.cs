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
        public List<Contact> Contacts { get => _contacts; set => _contacts = value; }
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }
        public class ContactComparer : IComparer<Contact>
        {
            public int Compare(Contact x, Contact y)
            {
                if (y.Surname == x.Surname)
                {
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    return x.Surname.CompareTo(y.Surname);
                }               
            }
        }

        public List<Contact> GetSortedContacts(string selectedName)
        {
            List<Contact> contacts = new List<Contact>();
            var contactNames = this.Contacts.ToArray();
            for (int i = 0; i < contactNames.Length; i++)
            {
                if (contactNames[i].Name.Contains(selectedName) || contactNames[i].Surname.Contains(selectedName))
                    contacts.Add(contactNames[i]);
            }
            contacts.Sort(new ContactComparer());
            return contacts;
        }

        private Contact _currentContact;
        public Contact CurrentContact
        {
            get { return _currentContact; }
            set { _currentContact = value; }
        }

        public List<Contact> GetContactsWithBirthday(DateTime choosenDate)
        {
            List<Contact> contacts = new List<Contact>();
            var contactBirthday = this.Contacts.ToArray();
            for (int i = 0; i < contactBirthday.Length; i++)
            {
                if (contactBirthday[i].BirthDate.Month == choosenDate.Month && contactBirthday[i].BirthDate.Day == choosenDate.Day)
                    contacts.Add(contactBirthday[i]);
            }
            return contacts;
        }
    }
}