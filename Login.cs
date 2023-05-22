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

namespace CRM_TRY4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "managerCRMDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.managerCRMDataSet.users);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KMA0UCB;Initial Catalog=ManagerCRM;Integrated Security=True");
            string query = "select * from users where username = " + "'" + comboBox1.Text.Trim() + "'" + " and password = " + "'"+textBox2.Text.Trim()+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon); 
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                MenuMain obj = new MenuMain();
                this.Hide();
                obj.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
