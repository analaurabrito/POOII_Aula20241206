using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula20240606AgendaTelefonica
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        public List<Contato> agenda;
        public Form1()
        {
            InitializeComponent();
            agenda = new List<Contato>();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Aula20240606;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            AtualizaLista();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            AtualizaLista();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AtualizaLista()
        {
            try
            {
                conexao.Open();
                var selectCmd = conexao.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Contato;";

                SqlDataReader leitorDados = selectCmd.ExecuteReader();

                while (leitorDados.Read())
                {

                    Contato c = new Contato();
                    c.id = Convert.ToInt32(leitorDados["Id"]);
                    c.name = Convert.ToString(leitorDados["Nome"]);
                    c.telefone = Convert.ToString(leitorDados["Telefone"]);

                    agenda.Add(c);

                }
                MessageBox.Show("FOi;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRo");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
