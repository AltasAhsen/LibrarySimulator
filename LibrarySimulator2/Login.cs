using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySimulator2
{
    public partial class Login_page : Form
    {
        public bool willClose = true;
        public Login_page()
        {
            InitializeComponent();
        }

        public readonly string connectionString = "Data Source=DESKTOP-FKCKQJ0;Initial Catalog=LibraryData;User ID=sa;Password=1;Encrypt=True;TrustServerCertificate=True";


        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand show = new SqlCommand("SELECT * FROM Librarians", connect);

            try
            {
                SqlDataReader reader = show.ExecuteReader();

                // Librarians Table on console
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured : " + ex.Message);
            }

            connect.Close();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            willClose = false;
            SqlCommand find = new SqlCommand("SELECT COUNT(*) FROM Librarians WHERE id=@Id AND pass=@Pass",connect);
            find.Parameters.AddWithValue("@Id", id_textbox.Text);
            find.Parameters.AddWithValue("@Pass", password_textbox.Text);
            if (Convert.ToInt32(find.ExecuteScalar()) == 0)
            {
                warn_msg.Visible = true;
            }
            else
            {
                this.Close();
                Operations operations = new Operations();
                operations.Show();
            }
                    
            
        }

        private void Login_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (willClose)
            {
                Application.Exit();
            }
        }


    }



}
