using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (ContactsProject == null)
            {
                ContactsProject = new Project(new List<Contact>() { { new Contact("Потапов", "Егор", "уууу", "2123", DateTime.Now, new PhoneNumber(79130440063)) } });
            }
            RecreateContactList();
        }
        /// <summary>
        /// Пересоздаёт лист со всеми контактами
        /// </summary>
        /// <param name="defaultSelectedIndex">номер контакта, который будет выделен после пересоздания</param>
        void RecreateContactList(int defaultSelectedIndex = 0)
        {
            var contactNames = ContactsProject.Contacts.ToArray();
            ContactsListBox.Items.Clear();
            for (int i = 0; i < contactNames.Length; i++)
            {
                ContactsListBox.Items.Add(contactNames[i].Surname + " " + contactNames[i].Name);
            }
            ContactsListBox.SelectedIndex = defaultSelectedIndex;
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
                RecreateContactList(ContactsProject.Contacts.ToArray().Length - 1);
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
                RecreateContactList(ContactsListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Обработка кнопки "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            ContactsProject.Contacts.Remove(ContactsProject.Contacts[ContactsListBox.SelectedIndex]);
            RecreateContactList();
            ProjectManager.SaveToFile(ContactsProject);
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
            var contact = ContactsProject.Contacts[ContactsListBox.SelectedIndex];

            NameTextBox.Text = contact.Name;
            SurnameTextBox.Text = contact.Surname;
            EmailTextBox.Text = contact.Email;
            VKTextBox.Text = contact.IdVK;
            BirthdayDateTime.Text = contact.BirthDate.ToString("d");
            PhoneTextBox.Text = contact.ContactNumber.Number.ToString();
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

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Contact contact = addEditContactForm.CurrentContact;
                ContactsProject.Contacts.Add(contact);
                RecreateContactList(ContactsProject.Contacts.ToArray().Length - 1);
                ProjectManager.SaveToFile(ContactsProject);
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            Contact contact = ContactsProject.Contacts[ContactsListBox.SelectedIndex];
            addEditContactForm.CurrentContact = contact;
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                RecreateContactList(ContactsListBox.SelectedIndex);
            }
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactsProject.Contacts.Remove(ContactsProject.Contacts[ContactsListBox.SelectedIndex]);
            RecreateContactList();
            ProjectManager.SaveToFile(ContactsProject);
        }
    }
}
