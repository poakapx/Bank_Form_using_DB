using System;
using System.Data;
using System.Data.SqlClient;
using System.Media;
using System.Windows.Forms;
namespace BankFormProject
{
    public partial class Form_AdminBankApp : Form
    {
        SqlConnection sqlConnection;

        public Form_AdminBankApp()
        {
            InitializeComponent();
        }
        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox_Users.Items.Clear();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Bankappforadmin]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    ListBox_Users.Items.Add
                        (
                        Convert.ToString(sqlReader["ID"]) + "\t\t\t\t" +
                        Convert.ToString(sqlReader["First_Name"]) + "\t\t\t\t" +
                        Convert.ToString(sqlReader["Surname"]) + "\t\t\t\t" +
                        Convert.ToString(sqlReader["Middle_Name"] + "\t\t\t\t" +
                        Convert.ToString(sqlReader["Money"]))
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            this.Close();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"data source = PC_OF_PAVLO\SQLEXPRESS; initial catalog = Bank; integrated security = True;";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Bankappforadmin]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    ListBox_Users.Items.Add
                        (
                        Convert.ToString(sqlReader["ID"]) + "\t\t\t\t" +
                        Convert.ToString(sqlReader["First_Name"]) + "\t\t\t\t" +
                        Convert.ToString(sqlReader["Surname"]) + "\t\t\t\t" +
                        Convert.ToString(sqlReader["Middle_Name"] + "\t\t\t\t" +
                        Convert.ToString(sqlReader["Money"]))
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"C:\Users\Pavlo\source\repos\WinForms-Bank\bin\Debug\click.wav");
            Simple.Play();

            if(!string.IsNullOrEmpty(TextBox_First_Name_REGISTER.Text) && !string.IsNullOrWhiteSpace(TextBox_First_Name_REGISTER.Text) && !string.IsNullOrEmpty(TextBox_Surname_REGISTER.Text) && !string.IsNullOrWhiteSpace(TextBox_Surname_REGISTER.Text) && !string.IsNullOrEmpty(TextBox_Middle_Name_REGISTER.Text) && !string.IsNullOrWhiteSpace(TextBox_Middle_Name_REGISTER.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Bankappforadmin] (First_Name, Surname, Middle_Name, Money)VALUES(@First_Name, @Surname, @Middle_Name, 0)", sqlConnection);
                command.Parameters.AddWithValue("First_Name", TextBox_First_Name_REGISTER.Text);
                command.Parameters.AddWithValue("Surname", TextBox_Surname_REGISTER.Text);
                command.Parameters.AddWithValue("Middle_Name", TextBox_Middle_Name_REGISTER.Text);
                await command.ExecuteNonQueryAsync();
                Label_REGISTER.ForeColor = System.Drawing.Color.Gold;
                Label_REGISTER.BackColor = System.Drawing.Color.Green;
                Label_REGISTER.Text = "Юзер зареган!";
            }
            else
            {
                Label_REGISTER.ForeColor = System.Drawing.Color.Yellow;
                Label_REGISTER.Text = "Поля «Имя», «Фамилия» и «Отчество» должны быть заполнены!";
            }
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"C:\Users\Pavlo\source\repos\WinForms-Bank\bin\Debug\click.wav");
            Simple.Play();

            SqlConnection sqlconnection = new SqlConnection(@"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;");
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM [Bankappforadmin] WHERE [ID]=@ID", sqlconnection);
            sqlconnection.Open();
            sqlcommand.Parameters.AddWithValue("@ID", TextBox_ID_EDIT.Text);
            SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
            if (sqldatareader.HasRows != true)
            {
                Label_EDIT.ForeColor = System.Drawing.Color.OrangeRed;
                Label_EDIT.Text = "Нет такого юзера!";
                if (TextBox_ID_EDIT.Text == "" && TextBox_First_Name_EDIT.Text == "" || TextBox_Surname_EDIT.Text == "" || TextBox_Middle_Name_EDIT.Text == "")
                {
                    Label_EDIT.ForeColor = System.Drawing.Color.Yellow;
                    Label_EDIT.Text = "Поля «ID», «Имя», «Фамилия» и «Отчество» должны быть заполнены!";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(TextBox_ID_EDIT.Text) && !string.IsNullOrWhiteSpace(TextBox_ID_EDIT.Text) && !string.IsNullOrEmpty(TextBox_First_Name_EDIT.Text) && !string.IsNullOrWhiteSpace(TextBox_First_Name_EDIT.Text) && !string.IsNullOrEmpty(TextBox_Surname_EDIT.Text) && !string.IsNullOrWhiteSpace(TextBox_Surname_EDIT.Text) && !string.IsNullOrEmpty(TextBox_Middle_Name_EDIT.Text) && !string.IsNullOrWhiteSpace(TextBox_Middle_Name_EDIT.Text))
                {
                    SqlCommand command = new SqlCommand("UPDATE [Bankappforadmin] SET [First_Name]=@First_Name, [Surname]=@Surname, [Middle_Name]=@Middle_Name WHERE [ID]=@ID", sqlConnection);
                    command.Parameters.AddWithValue("ID", TextBox_ID_EDIT.Text);
                    command.Parameters.AddWithValue("First_Name", TextBox_First_Name_EDIT.Text);
                    command.Parameters.AddWithValue("Surname", TextBox_Surname_EDIT.Text);
                    command.Parameters.AddWithValue("Middle_Name", TextBox_Middle_Name_EDIT.Text);
                    await command.ExecuteNonQueryAsync();
                    Label_EDIT.ForeColor = System.Drawing.Color.Gold;
                    Label_EDIT.BackColor = System.Drawing.Color.Green;
                    Label_EDIT.Text = "Юзер отредактирован!";
                }
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"C:\Users\Pavlo\source\repos\WinForms-Bank\bin\Debug\click.wav");
            Simple.Play();

            SqlConnection sqlconnection = new SqlConnection(@"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;");
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM [Bankappforadmin] WHERE [ID]=@ID", sqlconnection);
            sqlconnection.Open();
            sqlcommand.Parameters.AddWithValue("@ID", TextBox_ID_DELETE.Text);
            SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
            if (sqldatareader.HasRows != true)
            {
                Label_DELETE.ForeColor = System.Drawing.Color.OrangeRed;
                Label_DELETE.Text = "Нет такого юзера!";
                if (TextBox_ID_DELETE.Text == "")
                {
                    Label_DELETE.ForeColor = System.Drawing.Color.Yellow;
                    Label_DELETE.Text = "Поле «ID» должно быть заполнено!";
                }
            }
            else if (!string.IsNullOrEmpty(TextBox_ID_DELETE.Text) && !string.IsNullOrWhiteSpace(TextBox_ID_DELETE.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Bankappforadmin] WHERE [ID]=@ID", sqlConnection);
                command.Parameters.AddWithValue("ID", TextBox_ID_DELETE.Text);
                await command.ExecuteNonQueryAsync();
                Label_DELETE.ForeColor = System.Drawing.Color.Gold;
                Label_DELETE.BackColor = System.Drawing.Color.Green;
                Label_DELETE.Text = "Юзер удалён!";
            }
        }
        private async void Button_TRANSACTION_Click(object sender, EventArgs e)
        {
            SoundPlayer Simple = new SoundPlayer(@"C:\Users\Pavlo\source\repos\WinForms-Bank\bin\Debug\click.wav");
            Simple.Play();

            SqlConnection sqlconnectionID1 = new SqlConnection(@"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;");
            SqlCommand sqlcommandID1 = new SqlCommand("SELECT * FROM [Bankappforadmin] WHERE [ID]=@ID", sqlconnectionID1);
            sqlconnectionID1.Open();
            sqlcommandID1.Parameters.AddWithValue("@ID", TextBox_ID1_TRANSACTION.Text);
            SqlDataReader sqldatareaderID1 = sqlcommandID1.ExecuteReader();
            SqlConnection sqlconnectionID2 = new SqlConnection(@"Data Source=PC_OF_PAVLO\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True;");
            SqlCommand sqlcommandID2 = new SqlCommand("SELECT * FROM [Bankappforadmin] WHERE [ID]=@ID", sqlconnectionID2);
            sqlconnectionID2.Open();
            sqlcommandID2.Parameters.AddWithValue("@ID", TextBox_ID2_TRANSACTION.Text);
            SqlDataReader sqldatareaderID2 = sqlcommandID2.ExecuteReader();

            if (sqldatareaderID1.HasRows != true)
            {
                Label_TRANSACTION.ForeColor = System.Drawing.Color.OrangeRed;
                Label_TRANSACTION.Visible = true;
                Label_TRANSACTION.Text = "Нет такого юзера! " + "(" + TextBox_ID1_TRANSACTION.Text + ")";
                if (TextBox_ID1_TRANSACTION.Text == "")
                {
                    Label_TRANSACTION.ForeColor = System.Drawing.Color.Yellow;
                    Label_TRANSACTION.Visible = true;
                    Label_TRANSACTION.Text = "Поля должны быть заполнены!";
                }
                else if (sqldatareaderID2.HasRows == false && sqldatareaderID1.HasRows == false)
                {
                    Label_TRANSACTION.ForeColor = System.Drawing.Color.OrangeRed;
                    Label_TRANSACTION.Visible = true;
                    Label_TRANSACTION.Text = "Нет таких юзеров юзера! " + "(" + TextBox_ID2_TRANSACTION.Text + " и " + TextBox_ID1_TRANSACTION.Text + ")";
                }
            }

            else if (sqldatareaderID2.HasRows != true)
            {
                Label_TRANSACTION.ForeColor = System.Drawing.Color.OrangeRed;
                Label_TRANSACTION.Visible = true;
                Label_TRANSACTION.Text = "Нет такого юзера! " + "("+ TextBox_ID2_TRANSACTION.Text + ")";
                if (TextBox_ID2_TRANSACTION.Text == "")
                {
                    Label_TRANSACTION.ForeColor = System.Drawing.Color.Yellow;
                    Label_TRANSACTION.Visible = true;
                    Label_TRANSACTION.Text = "Поля должны быть заполнены!";
                }
                else if (sqldatareaderID2.HasRows == false && sqldatareaderID1.HasRows == false)
                {
                    Label_TRANSACTION.ForeColor = System.Drawing.Color.OrangeRed;
                    Label_TRANSACTION.Visible = true;
                    Label_TRANSACTION.Text = "Нет таких юзеров юзера! " + "(" + TextBox_ID2_TRANSACTION.Text + " и " + TextBox_ID1_TRANSACTION.Text + ")";
                }
            }

            else if (sqldatareaderID2.HasRows == sqldatareaderID1.HasRows)
            {
                Label_TRANSACTION.ForeColor = System.Drawing.Color.OrangeRed;
                Label_TRANSACTION.Visible = true;
                Label_TRANSACTION.Text = "Всё равно, что самому себе лайки ставить...";
            }

            else
            {
                if
                (
                !string.IsNullOrEmpty(TextBox_ID2_TRANSACTION.Text) &&
                !string.IsNullOrWhiteSpace(TextBox_ID2_TRANSACTION.Text) &&
                !string.IsNullOrEmpty(TextBox_ID1_TRANSACTION.Text) &&
                !string.IsNullOrWhiteSpace(TextBox_ID1_TRANSACTION.Text) &&
                !string.IsNullOrEmpty(TextBox_MONEY_TRANSACTION.Text) &&
                !string.IsNullOrWhiteSpace(TextBox_MONEY_TRANSACTION.Text)
                )
                {
                    SqlCommand command1 = new SqlCommand("UPDATE [Bankappforadmin] SET [Money]=[Money]-@Money WHERE [ID]=@ID", sqlConnection);
                    command1.Parameters.AddWithValue("Money", TextBox_MONEY_TRANSACTION.Text);
                    command1.Parameters.AddWithValue("ID", TextBox_ID1_TRANSACTION.Text);
                    await command1.ExecuteNonQueryAsync();
                    SqlCommand command2 = new SqlCommand("UPDATE [Bankappforadmin] SET [Money]=[Money]+@Money WHERE [ID]=@ID", sqlConnection);
                    command2.Parameters.AddWithValue("Money", TextBox_MONEY_TRANSACTION.Text);
                    command2.Parameters.AddWithValue("ID", TextBox_ID2_TRANSACTION.Text);
                    await command2.ExecuteNonQueryAsync();
                    Label_TRANSACTION.ForeColor = System.Drawing.Color.Gold;
                    Label_TRANSACTION.Visible = true;
                    Label_TRANSACTION.Text = "Транзакция успешно пройдена!";
                }
            }
        }
    }
}