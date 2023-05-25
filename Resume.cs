using DevExpress.Utils.Filtering.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace CRM_TRY4
{
    public partial class Resume : Form
    {
        public Resume()
        {
            InitializeComponent();
        }

        private void Resume_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mYSQLDataSet3.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.mYSQLDataSet3.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mYSQLDataSet1.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.mYSQLDataSet1.Student);

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void secName_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-KMA0UCB;Initial Catalog=MYSQL;Integrated Security=True");
            string sqlquery = "SELECT STUDENTNAME FROM Student WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            SqlCommand command = new SqlCommand(sqlquery, sqlcon);
            sqlcon.Open();
            object scalarobject;
            scalarobject = command.ExecuteScalar();
            StudName.Text = scalarobject.ToString();

            sqlquery = "SELECT GROUPNUMBER FROM Student WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            command = new SqlCommand(sqlquery, sqlcon);
            scalarobject = command.ExecuteScalar();
            secName.Text = scalarobject.ToString();

            sqlquery = "SELECT TELEPHONENUMBER FROM Student WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            command = new SqlCommand(sqlquery, sqlcon);
            scalarobject = command.ExecuteScalar();
            Primar.Text = scalarobject.ToString();

            sqlquery = "SELECT DRIVERLICENSE FROM Driver_License WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            command = new SqlCommand(sqlquery, sqlcon);
            scalarobject = command.ExecuteScalar();
            drLic.Text = scalarobject.ToString();

            sqlquery = "SELECT YearOfEnding FROM Year_Of_Ending WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            command = new SqlCommand(sqlquery, sqlcon);
            scalarobject = command.ExecuteScalar();
            yearEnd.Text = scalarobject.ToString();

            sqlquery = "SELECT ESTABLISHMENT FROM Student_Education WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            command = new SqlCommand(sqlquery, sqlcon);
            scalarobject = command.ExecuteScalar();
            educ.Text = scalarobject.ToString();

            sqlquery = "SELECT SoftSkills FROM Soft_Skills WHERE ID = " + "'" + boxId.Text.Trim() + "'";

            command = new SqlCommand(sqlquery, sqlcon);
            scalarobject = command.ExecuteScalar();
            softSkills.Text = scalarobject.ToString();

            sqlcon.Close();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
