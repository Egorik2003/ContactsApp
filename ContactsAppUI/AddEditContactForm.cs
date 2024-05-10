using ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactsAppUI
{
    /// <summary>
    /// Форма, позволяющая добавлять новые и редоактировать текущие контакты
    /// </summary>
    public partial class AddEditContactForm : Form
    {
        Contact _currentContact;
        /// <summary>
        /// Редактируемый/добавляемый контакт
        /// </summary>
        public Contact CurrentContact
        {
            get { return _currentContact; }
            set { _currentContact = value; }
        }
        public AddEditContactForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Ок"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameTextBox.Text;
                string surname = SurnameTextBox.Text;
                string email = EmailTextBox.Text;
                string idVK = VKTextBox.Text;
                DateTime birthDate = BirthdayDateTime.Value;
                PhoneNumber phoneNumber = new PhoneNumber((long)Convert.ToDouble(PhoneTextBox.Text));
                if (CurrentContact == null)
                {
                    CurrentContact = new Contact(name, surname, email, idVK, birthDate, phoneNumber);
                }
                else
                {
                    CurrentContact.Name = name;
                    CurrentContact.Surname = surname;
                    CurrentContact.Email = email;
                    CurrentContact.IdVK = idVK;
                    CurrentContact.BirthDate = birthDate;
                    CurrentContact.ContactNumber = phoneNumber;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            /// <summary>
            /// Обработчик события появления этой формы
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

        }

        private void AddEditContactForm_Shown(object sender, EventArgs e)
        {
            if (CurrentContact != null)
            {
                NameTextBox.Text = CurrentContact.Name;
                SurnameTextBox.Text = CurrentContact.Surname;
                EmailTextBox.Text = CurrentContact.Email;
                VKTextBox.Text = CurrentContact.IdVK;
                BirthdayDateTime.Value = CurrentContact.BirthDate;
                PhoneTextBox.Text = CurrentContact.ContactNumber.Number.ToString();
            }
        }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
