namespace ContactsAppUI
{
    partial class ContactsAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsAppForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.addContactToolStripMenuItem.Text = "Add contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.editContactToolStripMenuItem.Text = "Edit contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.removeContactToolStripMenuItem.Text = "Remove contact";
            this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.removeContactToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RemoveContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.ContactsListBox);
            this.splitContainer1.Panel1.Controls.Add(this.FindTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 420);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 16;
            this.ContactsListBox.Location = new System.Drawing.Point(6, 31);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(257, 340);
            this.ContactsListBox.TabIndex = 2;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(45, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(218, 22);
            this.FindTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BirthdayDateTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SurnameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhoneTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EmailTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.VKTextBox, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birthday:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-mail:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "vk.com:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthdayDateTime
            // 
            this.BirthdayDateTime.Location = new System.Drawing.Point(131, 55);
            this.BirthdayDateTime.Name = "BirthdayDateTime";
            this.BirthdayDateTime.Size = new System.Drawing.Size(200, 22);
            this.BirthdayDateTime.TabIndex = 6;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(131, 3);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(381, 22);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(131, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(381, 22);
            this.NameTextBox.TabIndex = 8;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(131, 81);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(381, 22);
            this.PhoneTextBox.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(131, 107);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(381, 22);
            this.EmailTextBox.TabIndex = 10;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(131, 133);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(381, 22);
            this.VKTextBox.TabIndex = 11;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.free_icon_trash_5947010;
            this.RemoveContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveContactButton.Location = new System.Drawing.Point(122, 389);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(31, 28);
            this.RemoveContactButton.TabIndex = 5;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.free_icon_edit_5934812;
            this.EditContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditContactButton.Location = new System.Drawing.Point(63, 389);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(31, 28);
            this.EditContactButton.TabIndex = 4;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.free_icon_add_button_7170178;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddContactButton.Location = new System.Drawing.Point(6, 389);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(31, 28);
            this.AddContactButton.TabIndex = 3;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ContactsAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContactsAppForm";
            this.Text = "ContactsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactsAppForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker BirthdayDateTime;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VKTextBox;
    }
}