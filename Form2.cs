using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace BankFormProject
{
    public partial class Form_ACCESS : Form
    {
        public Form_ACCESS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (TextBox_LOGIN.Text == "1" && TextBox_PASSWORD.Text == "1")
            {
                Form_AdminBankApp form1 = new Form_AdminBankApp();
                form1.Show();
                Visible = false;
            }
            else
            {
                label3.Visible = true;
                label3.ForeColor = Color.DarkRed;
                label3.Text = "Пароль и логин должны быть верны ('1' и '1')";
            }*/

            /*SqlConnection sqlconnection = new SqlConnection(@"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;");
            SqlDataAdapter sqldataadapter = new SqlDataAdapter("SELECT COUNT(*) FROM [BankappforadminPasswordandLogin] WHERE Login = '" + TextBox_LOGIN.Text + "' AND Password = '" + TextBox_PASSWORD.Text + "'", sqlconnection);
            DataTable datatable = new DataTable();
            sqldataadapter.Fill(datatable);

            if (datatable.Rows[0][0].ToString() == "1")
            {
                this.Hide(); //Visible = false;
                Form_AdminBankApp form1 = new Form_AdminBankApp();
                form1.Show();
            }
            else
            {
                Label_ACCESS.Visible = true;
                Label_ACCESS.ForeColor = Color.DarkRed;
                Label_ACCESS.Text = "Пароль и логин должны быть верны";
            }*/

            /*SqlConnection sqlconnection = new SqlConnection();
            sqlconnection.ConnectionString = @"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;";
            var sqlExp = $"SELECT * FROM [dbo].[BankappforadminPasswordandLogin] WHERE [Login]='{TextBox_LOGIN.Text}' AND [Password]='{TextBox_PASSWORD.Text}'";
            using (SqlCommand sqlcommand = new SqlCommand(sqlExp, sqlconnection))
            {
                sqlconnection.Open();

                if (sqlcommand.ExecuteNonQuery() == 1)
                {
                    this.Hide(); //Visible = false;
                    Form_AdminBankApp form1 = new Form_AdminBankApp();
                    form1.Show();
                }
                else
                {
                    Label_ACCESS.Visible = true;
                    Label_ACCESS.ForeColor = Color.DarkRed;
                    Label_ACCESS.Text = "Пароль и логин должны быть верны";
                }
            }*/


            SqlConnection sqlconnection = new SqlConnection(@"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;");
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM [BankappforadminPasswordandLogin] WHERE [Login]=@Login AND [Password]=@Password", sqlconnection);
            sqlconnection.Open();
            sqlcommand.Parameters.AddWithValue("@Login", TextBox_LOGIN.Text);
            sqlcommand.Parameters.AddWithValue("@Password", TextBox_PASSWORD.Text);
            SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
            if (sqldatareader.HasRows == true)
            {
                this.Hide(); //Visible = false;
                Form_AdminBankApp form1 = new Form_AdminBankApp();
                form1.Show();
            }
            else
            {
                Label_ACCESS.Visible = true;
                Label_ACCESS.ForeColor = Color.DarkRed;
                Label_ACCESS.Text = "Пароль и логин должны быть верны";
            }
        }
    }
}