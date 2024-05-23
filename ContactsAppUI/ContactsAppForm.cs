using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ContactsApp.Project;
using System.Windows.Forms;
using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactsAppUI
{
    /// <summary>
    /// Основная форма приложения
    /// </summary>
    public partial class ContactsAppForm : Form
    {
        Project _contactsProject;
        /// <summary>
        /// Список всех контактов
        /// </summary>
        public Project ContactsProject
        {
            get
            { return _contactsProject; }
            set
            { _contactsProject = value; }
        }
        public ContactsAppForm()
        {
             InitializeComponent();
            ContactsProject = ProjectManager.LoadFromFile();
            FindTextBox.Text = "";
            if (ContactsProject == null)
            {
                PhoneNumber phone = new PhoneNumber(78005553535);
                ContactsProject = new Project(new List<Contact>() { { new Contact("Потапов", "Егор", "e@mail.ru", "id546221", DateTime.Now, phone) } });
            }
            else
            {
                var contact = ContactsProject.CurrentContact;
                if (contact == null)
                {
                    NameTextBox.Text = "";
                    SurnameTextBox.Text = "";
                    EmailTextBox.Text = "@";
                    VKTextBox.Text = "";
                    BirthdayDateTime.Text = DateTime.Now.ToString();
                    PhoneTextBox.Text = 78005553535.ToString();
                }
                else
                {
                    NameTextBox.Text = contact.Name;
                    SurnameTextBox.Text = contact.Surname;
                    EmailTextBox.Text = contact.Email;
                    VKTextBox.Text = contact.IdVK;
                    BirthdayDateTime.Text = contact.BirthDate.ToString();
                    PhoneTextBox.Text = contact.ContactNumber.Number.ToString();
                }               
            }
            List<Contact> contactsWithBirthday = ContactsProject.GetContactsWithBirthday(DateTime.Now);
            if (contactsWithBirthday.Count == 0)
            {
                birthdayListRichTextBox.Text = "Сегодня нет контактов с днем рождения";
            }
            else
            {
                birthdayListRichTextBox.Text = "Сегодня день рождения:\n";
                foreach (var conact in contactsWithBirthday)
                {
                    birthdayListRichTextBox.Text += conact.Surname + " " + conact.Name + "\n";
                }
            }
            CreateContactList();
        }
        /// <summary>
        /// Пересоздаёт лист со всеми контактами
        /// </summary>
        /// <param name="defaultSelectedIndex">номер контакта, который будет выделен после пересоздания</param>
        void RecreateContactList(string selectedName)
        {
            List<Contact> contacts = new List<Contact>();
            contacts = ContactsProject.GetSortedContacts(selectedName);
            ContactsListBox.Items.Clear();
            foreach (var contact in contacts)
            {
                ContactsListBox.Items.Add(contact.Surname + " " + contact.Name);
            }
        }
        void CreateContactList()
        {
            List<Contact> contacts = ContactsProject.Contacts;
            contacts.Sort(new ContactComparer());
            ContactsListBox.Items.Clear();
            foreach (var contact in contacts)
            {
                ContactsListBox.Items.Add(contact.Surname + " " + contact.Name);
            }
        }
        /// <summary>
        /// Обработка кнопки "Добавить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Contact contact = addEditContactForm.CurrentContact;
                ContactsProject.Contacts.Add(contact);
                CreateContactList();
                ProjectManager.SaveToFile(ContactsProject);
            }
        }

        /// <summary>
        /// Обработка кнопки "Редактировать контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            Contact contact = ContactsProject.Contacts[ContactsListBox.SelectedIndex];
            addEditContactForm.CurrentContact = contact;
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CreateContactList();
            }
        }
        /// <summary>
        /// Обработка кнопки "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить контакт?", "Удаление контакта", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ContactsProject.Contacts.Remove(ContactsProject.Contacts[ContactsListBox.SelectedIndex]);
                CreateContactList();
                ProjectManager.SaveToFile(ContactsProject);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutProgramForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Изменение выделения текущего контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedItem != null)
            {
                string surnameListBox = (string)ContactsListBox.SelectedItem;
                List<Contact> contacts = new List<Contact>();
                contacts = ContactsProject.Contacts;
                foreach (var contact in contacts)
                {
                    string contactValue = contact.Surname + " " + contact.Name;
                    if (surnameListBox == contactValue)
                    {
                        NameTextBox.Text = contact.Name;
                        SurnameTextBox.Text = contact.Surname;
                        EmailTextBox.Text = contact.Email;
                        VKTextBox.Text = contact.IdVK;
                        BirthdayDateTime.Text = contact.BirthDate.ToString("d");
                        PhoneTextBox.Text = contact.ContactNumber.Number.ToString();

                        ContactsProject.CurrentContact = contact;
                        ProjectManager.SaveToFile(ContactsProject);
                    }
                }
            }
        }

        /// <summary>
        /// Сохранение всех контактов при выходе из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(ContactsProject);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "")
            {
                CreateContactList();
            }
            else
            {
                RecreateContactList(FindTextBox.Text);
            }
            //if (ContactsListBox.Items.Count == 0)
            //{
            //    Title.Text = "Без названия";
            //    Category.Text = "-";
            //}
        }

        private void ContactsAppForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                RemoveContactButton_Click(RemoveContactButton, null);
            }
        }
    }
}
