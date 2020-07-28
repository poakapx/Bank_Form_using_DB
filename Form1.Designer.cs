using System.Drawing;

namespace BankFormProject
{
    partial class Form_AdminBankApp
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminBankApp));
            this.MenuStrip_Form = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Form = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl_Form = new System.Windows.Forms.TabControl();
            this.TabPage_Users = new System.Windows.Forms.TabPage();
            this.ListBox_Users = new System.Windows.Forms.ListBox();
            this.TabPage_REGISTER = new System.Windows.Forms.TabPage();
            this.TextBox_Middle_Name_REGISTER = new System.Windows.Forms.TextBox();
            this.Label_Middle_Name_REGISTER = new System.Windows.Forms.Label();
            this.Label_REGISTER = new System.Windows.Forms.Label();
            this.Button_REGISTER = new System.Windows.Forms.Button();
            this.Label_Surname_REGISTER = new System.Windows.Forms.Label();
            this.Label_First_Name_REGISTER = new System.Windows.Forms.Label();
            this.TextBox_Surname_REGISTER = new System.Windows.Forms.TextBox();
            this.TextBox_First_Name_REGISTER = new System.Windows.Forms.TextBox();
            this.TabPage_EDIT = new System.Windows.Forms.TabPage();
            this.TextBox_Middle_Name_EDIT = new System.Windows.Forms.TextBox();
            this.Label_Middle_Name_EDIT = new System.Windows.Forms.Label();
            this.Label_EDIT = new System.Windows.Forms.Label();
            this.TextBox_ID_EDIT = new System.Windows.Forms.TextBox();
            this.Label_ID_EDIT = new System.Windows.Forms.Label();
            this.Button_EDIT = new System.Windows.Forms.Button();
            this.Label_Surname_EDIT = new System.Windows.Forms.Label();
            this.Label_First_Name_EDIT = new System.Windows.Forms.Label();
            this.TextBox_Surname_EDIT = new System.Windows.Forms.TextBox();
            this.TextBox_First_Name_EDIT = new System.Windows.Forms.TextBox();
            this.TabPage_DELETE = new System.Windows.Forms.TabPage();
            this.Label_DELETE = new System.Windows.Forms.Label();
            this.Button_DELETE = new System.Windows.Forms.Button();
            this.TextBox_ID_DELETE = new System.Windows.Forms.TextBox();
            this.Label_ID_DELETE = new System.Windows.Forms.Label();
            this.TabPage_TRANSACTION = new System.Windows.Forms.TabPage();
            this.Label_TRANSACTION = new System.Windows.Forms.Label();
            this.Button_TRANSACTION = new System.Windows.Forms.Button();
            this.Label_MONEY_TRANSACTION = new System.Windows.Forms.Label();
            this.TextBox_MONEY_TRANSACTION = new System.Windows.Forms.TextBox();
            this.TextBox_ID2_TRANSACTION = new System.Windows.Forms.TextBox();
            this.TextBox_ID1_TRANSACTION = new System.Windows.Forms.TextBox();
            this.Label_ID2_TRANSACTION = new System.Windows.Forms.Label();
            this.Label_ID1_TRANSACTION = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MenuStrip_Form.SuspendLayout();
            this.TabControl_Form.SuspendLayout();
            this.TabPage_Users.SuspendLayout();
            this.TabPage_REGISTER.SuspendLayout();
            this.TabPage_EDIT.SuspendLayout();
            this.TabPage_DELETE.SuspendLayout();
            this.TabPage_TRANSACTION.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Form
            // 
            this.MenuStrip_Form.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip_Form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Form,
            this.ToolStripMenuItem_Tools});
            this.MenuStrip_Form.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Form.Name = "MenuStrip_Form";
            this.MenuStrip_Form.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStrip_Form.Size = new System.Drawing.Size(984, 24);
            this.MenuStrip_Form.TabIndex = 0;
            this.MenuStrip_Form.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Form
            // 
            this.ToolStripMenuItem_Form.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_Form.Name = "ToolStripMenuItem_Form";
            this.ToolStripMenuItem_Form.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuItem_Form.Text = "Форма";
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(108, 22);
            this.ToolStripMenuItem_Exit.Text = "Выход";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Tools
            // 
            this.ToolStripMenuItem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Refresh});
            this.ToolStripMenuItem_Tools.Name = "ToolStripMenuItem_Tools";
            this.ToolStripMenuItem_Tools.Size = new System.Drawing.Size(95, 20);
            this.ToolStripMenuItem_Tools.Text = "Инструменты";
            // 
            // ToolStripMenuItem_Refresh
            // 
            this.ToolStripMenuItem_Refresh.Name = "ToolStripMenuItem_Refresh";
            this.ToolStripMenuItem_Refresh.Size = new System.Drawing.Size(128, 22);
            this.ToolStripMenuItem_Refresh.Text = "Обновить";
            this.ToolStripMenuItem_Refresh.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // TabControl_Form
            // 
            this.TabControl_Form.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl_Form.Controls.Add(this.TabPage_Users);
            this.TabControl_Form.Controls.Add(this.TabPage_REGISTER);
            this.TabControl_Form.Controls.Add(this.TabPage_EDIT);
            this.TabControl_Form.Controls.Add(this.TabPage_DELETE);
            this.TabControl_Form.Controls.Add(this.TabPage_TRANSACTION);
            this.TabControl_Form.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabControl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Form.ImageList = this.imageList1;
            this.TabControl_Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabControl_Form.ItemSize = new System.Drawing.Size(120, 30);
            this.TabControl_Form.Location = new System.Drawing.Point(0, 24);
            this.TabControl_Form.Multiline = true;
            this.TabControl_Form.Name = "TabControl_Form";
            this.TabControl_Form.SelectedIndex = 0;
            this.TabControl_Form.Size = new System.Drawing.Size(984, 463);
            this.TabControl_Form.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl_Form.TabIndex = 1;
            // 
            // TabPage_Users
            // 
            this.TabPage_Users.Controls.Add(this.ListBox_Users);
            this.TabPage_Users.ImageIndex = 4;
            this.TabPage_Users.Location = new System.Drawing.Point(34, 4);
            this.TabPage_Users.Name = "TabPage_Users";
            this.TabPage_Users.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Users.Size = new System.Drawing.Size(946, 455);
            this.TabPage_Users.TabIndex = 0;
            this.TabPage_Users.UseVisualStyleBackColor = true;
            // 
            // ListBox_Users
            // 
            this.ListBox_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Users.FormattingEnabled = true;
            this.ListBox_Users.Location = new System.Drawing.Point(3, 3);
            this.ListBox_Users.Name = "ListBox_Users";
            this.ListBox_Users.Size = new System.Drawing.Size(940, 449);
            this.ListBox_Users.TabIndex = 0;
            // 
            // TabPage_REGISTER
            // 
            this.TabPage_REGISTER.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_REGISTER.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabPage_REGISTER.BackgroundImage")));
            this.TabPage_REGISTER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabPage_REGISTER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabPage_REGISTER.Controls.Add(this.TextBox_Middle_Name_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.Label_Middle_Name_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.Label_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.Button_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.Label_Surname_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.Label_First_Name_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.TextBox_Surname_REGISTER);
            this.TabPage_REGISTER.Controls.Add(this.TextBox_First_Name_REGISTER);
            this.TabPage_REGISTER.ImageIndex = 3;
            this.TabPage_REGISTER.Location = new System.Drawing.Point(34, 4);
            this.TabPage_REGISTER.Name = "TabPage_REGISTER";
            this.TabPage_REGISTER.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_REGISTER.Size = new System.Drawing.Size(946, 455);
            this.TabPage_REGISTER.TabIndex = 1;
            // 
            // TextBox_Middle_Name_REGISTER
            // 
            this.TextBox_Middle_Name_REGISTER.Location = new System.Drawing.Point(378, 282);
            this.TextBox_Middle_Name_REGISTER.Name = "TextBox_Middle_Name_REGISTER";
            this.TextBox_Middle_Name_REGISTER.Size = new System.Drawing.Size(199, 20);
            this.TextBox_Middle_Name_REGISTER.TabIndex = 7;
            // 
            // Label_Middle_Name_REGISTER
            // 
            this.Label_Middle_Name_REGISTER.AutoSize = true;
            this.Label_Middle_Name_REGISTER.Location = new System.Drawing.Point(321, 285);
            this.Label_Middle_Name_REGISTER.Name = "Label_Middle_Name_REGISTER";
            this.Label_Middle_Name_REGISTER.Size = new System.Drawing.Size(57, 13);
            this.Label_Middle_Name_REGISTER.TabIndex = 6;
            this.Label_Middle_Name_REGISTER.Text = "Отчество:";
            // 
            // Label_REGISTER
            // 
            this.Label_REGISTER.AutoSize = true;
            this.Label_REGISTER.BackColor = System.Drawing.Color.Green;
            this.Label_REGISTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_REGISTER.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_REGISTER.Location = new System.Drawing.Point(284, 160);
            this.Label_REGISTER.Name = "Label_REGISTER";
            this.Label_REGISTER.Size = new System.Drawing.Size(166, 13);
            this.Label_REGISTER.TabIndex = 5;
            this.Label_REGISTER.Text = "Регестрировать юзеров здесь!";
            // 
            // Button_REGISTER
            // 
            this.Button_REGISTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_REGISTER.Location = new System.Drawing.Point(343, 325);
            this.Button_REGISTER.Name = "Button_REGISTER";
            this.Button_REGISTER.Size = new System.Drawing.Size(261, 33);
            this.Button_REGISTER.TabIndex = 4;
            this.Button_REGISTER.Text = "Зарегистрировать";
            this.Button_REGISTER.UseVisualStyleBackColor = true;
            this.Button_REGISTER.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Surname_REGISTER
            // 
            this.Label_Surname_REGISTER.AutoSize = true;
            this.Label_Surname_REGISTER.Location = new System.Drawing.Point(295, 244);
            this.Label_Surname_REGISTER.Name = "Label_Surname_REGISTER";
            this.Label_Surname_REGISTER.Size = new System.Drawing.Size(59, 13);
            this.Label_Surname_REGISTER.TabIndex = 3;
            this.Label_Surname_REGISTER.Text = "Фамилия:";
            // 
            // Label_First_Name_REGISTER
            // 
            this.Label_First_Name_REGISTER.AutoSize = true;
            this.Label_First_Name_REGISTER.Location = new System.Drawing.Point(284, 205);
            this.Label_First_Name_REGISTER.Name = "Label_First_Name_REGISTER";
            this.Label_First_Name_REGISTER.Size = new System.Drawing.Size(32, 13);
            this.Label_First_Name_REGISTER.TabIndex = 2;
            this.Label_First_Name_REGISTER.Text = "Имя:";
            // 
            // TextBox_Surname_REGISTER
            // 
            this.TextBox_Surname_REGISTER.Location = new System.Drawing.Point(354, 241);
            this.TextBox_Surname_REGISTER.Name = "TextBox_Surname_REGISTER";
            this.TextBox_Surname_REGISTER.Size = new System.Drawing.Size(199, 20);
            this.TextBox_Surname_REGISTER.TabIndex = 1;
            // 
            // TextBox_First_Name_REGISTER
            // 
            this.TextBox_First_Name_REGISTER.Location = new System.Drawing.Point(314, 202);
            this.TextBox_First_Name_REGISTER.Name = "TextBox_First_Name_REGISTER";
            this.TextBox_First_Name_REGISTER.Size = new System.Drawing.Size(199, 20);
            this.TextBox_First_Name_REGISTER.TabIndex = 0;
            // 
            // TabPage_EDIT
            // 
            this.TabPage_EDIT.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_EDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabPage_EDIT.BackgroundImage")));
            this.TabPage_EDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabPage_EDIT.Controls.Add(this.TextBox_Middle_Name_EDIT);
            this.TabPage_EDIT.Controls.Add(this.Label_Middle_Name_EDIT);
            this.TabPage_EDIT.Controls.Add(this.Label_EDIT);
            this.TabPage_EDIT.Controls.Add(this.TextBox_ID_EDIT);
            this.TabPage_EDIT.Controls.Add(this.Label_ID_EDIT);
            this.TabPage_EDIT.Controls.Add(this.Button_EDIT);
            this.TabPage_EDIT.Controls.Add(this.Label_Surname_EDIT);
            this.TabPage_EDIT.Controls.Add(this.Label_First_Name_EDIT);
            this.TabPage_EDIT.Controls.Add(this.TextBox_Surname_EDIT);
            this.TabPage_EDIT.Controls.Add(this.TextBox_First_Name_EDIT);
            this.TabPage_EDIT.ImageIndex = 0;
            this.TabPage_EDIT.Location = new System.Drawing.Point(34, 4);
            this.TabPage_EDIT.Name = "TabPage_EDIT";
            this.TabPage_EDIT.Size = new System.Drawing.Size(946, 455);
            this.TabPage_EDIT.TabIndex = 2;
            // 
            // TextBox_Middle_Name_EDIT
            // 
            this.TextBox_Middle_Name_EDIT.Location = new System.Drawing.Point(415, 323);
            this.TextBox_Middle_Name_EDIT.Name = "TextBox_Middle_Name_EDIT";
            this.TextBox_Middle_Name_EDIT.Size = new System.Drawing.Size(199, 20);
            this.TextBox_Middle_Name_EDIT.TabIndex = 14;
            // 
            // Label_Middle_Name_EDIT
            // 
            this.Label_Middle_Name_EDIT.AutoSize = true;
            this.Label_Middle_Name_EDIT.Location = new System.Drawing.Point(352, 330);
            this.Label_Middle_Name_EDIT.Name = "Label_Middle_Name_EDIT";
            this.Label_Middle_Name_EDIT.Size = new System.Drawing.Size(57, 13);
            this.Label_Middle_Name_EDIT.TabIndex = 13;
            this.Label_Middle_Name_EDIT.Text = "Отчество:";
            // 
            // Label_EDIT
            // 
            this.Label_EDIT.AutoSize = true;
            this.Label_EDIT.BackColor = System.Drawing.Color.Green;
            this.Label_EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_EDIT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_EDIT.Location = new System.Drawing.Point(284, 160);
            this.Label_EDIT.Name = "Label_EDIT";
            this.Label_EDIT.Size = new System.Drawing.Size(202, 13);
            this.Label_EDIT.TabIndex = 12;
            this.Label_EDIT.Text = "Редактировать данные юзеров здесь!";
            // 
            // TextBox_ID_EDIT
            // 
            this.TextBox_ID_EDIT.Location = new System.Drawing.Point(308, 201);
            this.TextBox_ID_EDIT.Name = "TextBox_ID_EDIT";
            this.TextBox_ID_EDIT.Size = new System.Drawing.Size(199, 20);
            this.TextBox_ID_EDIT.TabIndex = 11;
            // 
            // Label_ID_EDIT
            // 
            this.Label_ID_EDIT.AutoSize = true;
            this.Label_ID_EDIT.Location = new System.Drawing.Point(281, 208);
            this.Label_ID_EDIT.Name = "Label_ID_EDIT";
            this.Label_ID_EDIT.Size = new System.Drawing.Size(21, 13);
            this.Label_ID_EDIT.TabIndex = 10;
            this.Label_ID_EDIT.Text = "ID:";
            // 
            // Button_EDIT
            // 
            this.Button_EDIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_EDIT.Location = new System.Drawing.Point(382, 368);
            this.Button_EDIT.Name = "Button_EDIT";
            this.Button_EDIT.Size = new System.Drawing.Size(261, 32);
            this.Button_EDIT.TabIndex = 9;
            this.Button_EDIT.Text = "Изменить";
            this.Button_EDIT.UseVisualStyleBackColor = true;
            this.Button_EDIT.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label_Surname_EDIT
            // 
            this.Label_Surname_EDIT.AutoSize = true;
            this.Label_Surname_EDIT.Location = new System.Drawing.Point(317, 287);
            this.Label_Surname_EDIT.Name = "Label_Surname_EDIT";
            this.Label_Surname_EDIT.Size = new System.Drawing.Size(59, 13);
            this.Label_Surname_EDIT.TabIndex = 8;
            this.Label_Surname_EDIT.Text = "Фамилия:";
            // 
            // Label_First_Name_EDIT
            // 
            this.Label_First_Name_EDIT.AutoSize = true;
            this.Label_First_Name_EDIT.Location = new System.Drawing.Point(300, 247);
            this.Label_First_Name_EDIT.Name = "Label_First_Name_EDIT";
            this.Label_First_Name_EDIT.Size = new System.Drawing.Size(32, 13);
            this.Label_First_Name_EDIT.TabIndex = 7;
            this.Label_First_Name_EDIT.Text = "Имя:";
            // 
            // TextBox_Surname_EDIT
            // 
            this.TextBox_Surname_EDIT.Location = new System.Drawing.Point(382, 280);
            this.TextBox_Surname_EDIT.Name = "TextBox_Surname_EDIT";
            this.TextBox_Surname_EDIT.Size = new System.Drawing.Size(199, 20);
            this.TextBox_Surname_EDIT.TabIndex = 6;
            // 
            // TextBox_First_Name_EDIT
            // 
            this.TextBox_First_Name_EDIT.Location = new System.Drawing.Point(338, 240);
            this.TextBox_First_Name_EDIT.Name = "TextBox_First_Name_EDIT";
            this.TextBox_First_Name_EDIT.Size = new System.Drawing.Size(199, 20);
            this.TextBox_First_Name_EDIT.TabIndex = 5;
            // 
            // TabPage_DELETE
            // 
            this.TabPage_DELETE.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_DELETE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabPage_DELETE.BackgroundImage")));
            this.TabPage_DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabPage_DELETE.Controls.Add(this.Label_DELETE);
            this.TabPage_DELETE.Controls.Add(this.Button_DELETE);
            this.TabPage_DELETE.Controls.Add(this.TextBox_ID_DELETE);
            this.TabPage_DELETE.Controls.Add(this.Label_ID_DELETE);
            this.TabPage_DELETE.ImageIndex = 1;
            this.TabPage_DELETE.Location = new System.Drawing.Point(34, 4);
            this.TabPage_DELETE.Name = "TabPage_DELETE";
            this.TabPage_DELETE.Size = new System.Drawing.Size(946, 455);
            this.TabPage_DELETE.TabIndex = 3;
            // 
            // Label_DELETE
            // 
            this.Label_DELETE.AutoSize = true;
            this.Label_DELETE.BackColor = System.Drawing.Color.Green;
            this.Label_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_DELETE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_DELETE.Location = new System.Drawing.Point(284, 160);
            this.Label_DELETE.Name = "Label_DELETE";
            this.Label_DELETE.Size = new System.Drawing.Size(127, 13);
            this.Label_DELETE.TabIndex = 15;
            this.Label_DELETE.Text = "Удалять юзеров здесь!";
            // 
            // Button_DELETE
            // 
            this.Button_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DELETE.Location = new System.Drawing.Point(390, 330);
            this.Button_DELETE.Name = "Button_DELETE";
            this.Button_DELETE.Size = new System.Drawing.Size(223, 32);
            this.Button_DELETE.TabIndex = 14;
            this.Button_DELETE.Text = "Удалить";
            this.Button_DELETE.UseVisualStyleBackColor = true;
            this.Button_DELETE.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextBox_ID_DELETE
            // 
            this.TextBox_ID_DELETE.Location = new System.Drawing.Point(320, 230);
            this.TextBox_ID_DELETE.Name = "TextBox_ID_DELETE";
            this.TextBox_ID_DELETE.Size = new System.Drawing.Size(199, 20);
            this.TextBox_ID_DELETE.TabIndex = 13;
            // 
            // Label_ID_DELETE
            // 
            this.Label_ID_DELETE.AutoSize = true;
            this.Label_ID_DELETE.Location = new System.Drawing.Point(293, 233);
            this.Label_ID_DELETE.Name = "Label_ID_DELETE";
            this.Label_ID_DELETE.Size = new System.Drawing.Size(21, 13);
            this.Label_ID_DELETE.TabIndex = 12;
            this.Label_ID_DELETE.Text = "ID:";
            // 
            // TabPage_TRANSACTION
            // 
            this.TabPage_TRANSACTION.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage_TRANSACTION.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabPage_TRANSACTION.BackgroundImage")));
            this.TabPage_TRANSACTION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabPage_TRANSACTION.Controls.Add(this.Label_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.Button_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.Label_MONEY_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.TextBox_MONEY_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.TextBox_ID2_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.TextBox_ID1_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.Label_ID2_TRANSACTION);
            this.TabPage_TRANSACTION.Controls.Add(this.Label_ID1_TRANSACTION);
            this.TabPage_TRANSACTION.ImageIndex = 2;
            this.TabPage_TRANSACTION.Location = new System.Drawing.Point(34, 4);
            this.TabPage_TRANSACTION.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage_TRANSACTION.Name = "TabPage_TRANSACTION";
            this.TabPage_TRANSACTION.Padding = new System.Windows.Forms.Padding(2);
            this.TabPage_TRANSACTION.Size = new System.Drawing.Size(946, 455);
            this.TabPage_TRANSACTION.TabIndex = 4;
            // 
            // Label_TRANSACTION
            // 
            this.Label_TRANSACTION.AutoSize = true;
            this.Label_TRANSACTION.BackColor = System.Drawing.Color.Green;
            this.Label_TRANSACTION.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_TRANSACTION.Location = new System.Drawing.Point(285, 162);
            this.Label_TRANSACTION.Name = "Label_TRANSACTION";
            this.Label_TRANSACTION.Size = new System.Drawing.Size(291, 13);
            this.Label_TRANSACTION.TabIndex = 16;
            this.Label_TRANSACTION.Text = "Помогать юзерам совершать переводы средств здесь!";
            // 
            // Button_TRANSACTION
            // 
            this.Button_TRANSACTION.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_TRANSACTION.Location = new System.Drawing.Point(318, 344);
            this.Button_TRANSACTION.Margin = new System.Windows.Forms.Padding(2);
            this.Button_TRANSACTION.Name = "Button_TRANSACTION";
            this.Button_TRANSACTION.Size = new System.Drawing.Size(277, 32);
            this.Button_TRANSACTION.TabIndex = 15;
            this.Button_TRANSACTION.Text = "Перевод";
            this.Button_TRANSACTION.UseVisualStyleBackColor = true;
            this.Button_TRANSACTION.Click += new System.EventHandler(this.Button_TRANSACTION_Click);
            // 
            // Label_MONEY_TRANSACTION
            // 
            this.Label_MONEY_TRANSACTION.AutoSize = true;
            this.Label_MONEY_TRANSACTION.Location = new System.Drawing.Point(331, 264);
            this.Label_MONEY_TRANSACTION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_MONEY_TRANSACTION.Name = "Label_MONEY_TRANSACTION";
            this.Label_MONEY_TRANSACTION.Size = new System.Drawing.Size(44, 13);
            this.Label_MONEY_TRANSACTION.TabIndex = 14;
            this.Label_MONEY_TRANSACTION.Text = "Сумма:";
            // 
            // TextBox_MONEY_TRANSACTION
            // 
            this.TextBox_MONEY_TRANSACTION.Location = new System.Drawing.Point(379, 257);
            this.TextBox_MONEY_TRANSACTION.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_MONEY_TRANSACTION.Name = "TextBox_MONEY_TRANSACTION";
            this.TextBox_MONEY_TRANSACTION.Size = new System.Drawing.Size(187, 20);
            this.TextBox_MONEY_TRANSACTION.TabIndex = 13;
            // 
            // TextBox_ID2_TRANSACTION
            // 
            this.TextBox_ID2_TRANSACTION.Location = new System.Drawing.Point(389, 299);
            this.TextBox_ID2_TRANSACTION.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_ID2_TRANSACTION.Name = "TextBox_ID2_TRANSACTION";
            this.TextBox_ID2_TRANSACTION.Size = new System.Drawing.Size(187, 20);
            this.TextBox_ID2_TRANSACTION.TabIndex = 12;
            // 
            // TextBox_ID1_TRANSACTION
            // 
            this.TextBox_ID1_TRANSACTION.Location = new System.Drawing.Point(389, 215);
            this.TextBox_ID1_TRANSACTION.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_ID1_TRANSACTION.Name = "TextBox_ID1_TRANSACTION";
            this.TextBox_ID1_TRANSACTION.Size = new System.Drawing.Size(187, 20);
            this.TextBox_ID1_TRANSACTION.TabIndex = 11;
            // 
            // Label_ID2_TRANSACTION
            // 
            this.Label_ID2_TRANSACTION.AutoSize = true;
            this.Label_ID2_TRANSACTION.Location = new System.Drawing.Point(304, 306);
            this.Label_ID2_TRANSACTION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_ID2_TRANSACTION.Name = "Label_ID2_TRANSACTION";
            this.Label_ID2_TRANSACTION.Size = new System.Drawing.Size(81, 13);
            this.Label_ID2_TRANSACTION.TabIndex = 10;
            this.Label_ID2_TRANSACTION.Text = "ID получателя:";
            // 
            // Label_ID1_TRANSACTION
            // 
            this.Label_ID1_TRANSACTION.AutoSize = true;
            this.Label_ID1_TRANSACTION.Location = new System.Drawing.Point(296, 222);
            this.Label_ID1_TRANSACTION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_ID1_TRANSACTION.Name = "Label_ID1_TRANSACTION";
            this.Label_ID1_TRANSACTION.Size = new System.Drawing.Size(89, 13);
            this.Label_ID1_TRANSACTION.TabIndex = 9;
            this.Label_ID1_TRANSACTION.Text = "ID переводчика:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit.png");
            this.imageList1.Images.SetKeyName(1, "minus.png");
            this.imageList1.Images.SetKeyName(2, "money.png");
            this.imageList1.Images.SetKeyName(3, "plus.png");
            this.imageList1.Images.SetKeyName(4, "users.png");
            // 
            // Form_AdminBankApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 487);
            this.Controls.Add(this.TabControl_Form);
            this.Controls.Add(this.MenuStrip_Form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Form;
            this.MaximumSize = new System.Drawing.Size(1000, 525);
            this.MinimumSize = new System.Drawing.Size(1000, 525);
            this.Name = "Form_AdminBankApp";
            this.Text = "AdminBankApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip_Form.ResumeLayout(false);
            this.MenuStrip_Form.PerformLayout();
            this.TabControl_Form.ResumeLayout(false);
            this.TabPage_Users.ResumeLayout(false);
            this.TabPage_REGISTER.ResumeLayout(false);
            this.TabPage_REGISTER.PerformLayout();
            this.TabPage_EDIT.ResumeLayout(false);
            this.TabPage_EDIT.PerformLayout();
            this.TabPage_DELETE.ResumeLayout(false);
            this.TabPage_DELETE.PerformLayout();
            this.TabPage_TRANSACTION.ResumeLayout(false);
            this.TabPage_TRANSACTION.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.MenuStrip MenuStrip_Form;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Form;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.TabPage TabPage_Users;
        private System.Windows.Forms.ListBox ListBox_Users;
        private System.Windows.Forms.TabPage TabPage_REGISTER;
        private System.Windows.Forms.Label Label_Surname_REGISTER;
        private System.Windows.Forms.Label Label_First_Name_REGISTER;
        private System.Windows.Forms.TextBox TextBox_Surname_REGISTER;
        private System.Windows.Forms.TextBox TextBox_First_Name_REGISTER;
        private System.Windows.Forms.TabPage TabPage_EDIT;
        private System.Windows.Forms.TabPage TabPage_DELETE;
        private System.Windows.Forms.Button Button_REGISTER;
        private System.Windows.Forms.Button Button_EDIT;
        private System.Windows.Forms.Label Label_Surname_EDIT;
        private System.Windows.Forms.Label Label_First_Name_EDIT;
        private System.Windows.Forms.TextBox TextBox_Surname_EDIT;
        private System.Windows.Forms.TextBox TextBox_First_Name_EDIT;
        private System.Windows.Forms.TextBox TextBox_ID_EDIT;
        private System.Windows.Forms.Label Label_ID_EDIT;
        private System.Windows.Forms.Button Button_DELETE;
        private System.Windows.Forms.TextBox TextBox_ID_DELETE;
        private System.Windows.Forms.Label Label_ID_DELETE;
        private System.Windows.Forms.Label Label_REGISTER;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Tools;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Refresh;
        private System.Windows.Forms.Label Label_EDIT;
        private System.Windows.Forms.Label Label_DELETE;
        private System.Windows.Forms.TextBox TextBox_Middle_Name_REGISTER;
        private System.Windows.Forms.Label Label_Middle_Name_REGISTER;
        private System.Windows.Forms.TextBox TextBox_Middle_Name_EDIT;
        private System.Windows.Forms.Label Label_Middle_Name_EDIT;
        private System.Windows.Forms.TabPage TabPage_TRANSACTION;
        private System.Windows.Forms.Button Button_TRANSACTION;
        private System.Windows.Forms.Label Label_MONEY_TRANSACTION;
        private System.Windows.Forms.TextBox TextBox_MONEY_TRANSACTION;
        private System.Windows.Forms.TextBox TextBox_ID2_TRANSACTION;
        private System.Windows.Forms.TextBox TextBox_ID1_TRANSACTION;
        private System.Windows.Forms.Label Label_ID2_TRANSACTION;
        private System.Windows.Forms.Label Label_ID1_TRANSACTION;
        private System.Windows.Forms.TabControl TabControl_Form;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Label_TRANSACTION;
    }
}