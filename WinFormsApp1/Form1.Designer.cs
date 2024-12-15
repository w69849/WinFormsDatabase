namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddUser = new Button();
            label1 = new Label();
            listOfUsers = new ListBox();
            enterName = new TextBox();
            CreateTable = new Button();
            AddToDatabase = new Button();
            FindById = new Button();
            enterId = new TextBox();
            SuspendLayout();
            // 
            // AddUser
            // 
            AddUser.Location = new Point(397, 120);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(165, 80);
            AddUser.TabIndex = 0;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 51);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "List of users";
            label1.Click += label1_Click;
            // 
            // listOfUsers
            // 
            listOfUsers.FormattingEnabled = true;
            listOfUsers.ItemHeight = 15;
            listOfUsers.Location = new Point(81, 69);
            listOfUsers.Name = "listOfUsers";
            listOfUsers.Size = new Size(211, 229);
            listOfUsers.TabIndex = 2;
            listOfUsers.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // enterName
            // 
            enterName.Location = new Point(397, 91);
            enterName.Name = "enterName";
            enterName.Size = new Size(165, 23);
            enterName.TabIndex = 3;
            // 
            // CreateTable
            // 
            CreateTable.Location = new Point(639, 91);
            CreateTable.Name = "CreateTable";
            CreateTable.Size = new Size(121, 46);
            CreateTable.TabIndex = 4;
            CreateTable.Text = "Create table";
            CreateTable.UseVisualStyleBackColor = true;
            CreateTable.Click += CreateTable_Click;
            // 
            // AddToDatabase
            // 
            AddToDatabase.Location = new Point(81, 304);
            AddToDatabase.Name = "AddToDatabase";
            AddToDatabase.Size = new Size(211, 37);
            AddToDatabase.TabIndex = 5;
            AddToDatabase.Text = "Add To Database";
            AddToDatabase.UseVisualStyleBackColor = true;
            AddToDatabase.Click += AddToDatabase_Click;
            // 
            // FindById
            // 
            FindById.Location = new Point(298, 304);
            FindById.Name = "FindById";
            FindById.Size = new Size(211, 37);
            FindById.TabIndex = 6;
            FindById.Text = "Find by id";
            FindById.UseVisualStyleBackColor = true;
            FindById.Click += FindById_Click;
            // 
            // enterId
            // 
            enterId.Location = new Point(349, 275);
            enterId.Name = "enterId";
            enterId.Size = new Size(112, 23);
            enterId.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enterId);
            Controls.Add(FindById);
            Controls.Add(AddToDatabase);
            Controls.Add(CreateTable);
            Controls.Add(enterName);
            Controls.Add(listOfUsers);
            Controls.Add(label1);
            Controls.Add(AddUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddUser;
        private Label label1;
        private ListBox listOfUsers;
        private TextBox enterName;
        private Button CreateTable;
        private Button AddToDatabase;
        private Button FindById;
        private TextBox enterId;
    }
}
