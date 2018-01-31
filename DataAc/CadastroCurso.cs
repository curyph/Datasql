using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Linq;

using System.Windows.Forms;

namespace DataAc
{
    public partial class CadastroCurso : Form
    {
        SqlCon connect = new SqlCon();
        public CadastroCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO COURSES (NAME_COURSE, COST_COURSE, PERIOD_COURSE) VALUES(@NAME_COURSE, @COST_COURSE, @PERIOD_COURSE)", connect.myConnection);
                myCommand.Parameters.AddWithValue("NAME_COURSE", txtNomeCurso.Text);
                myCommand.Parameters.AddWithValue("COST_COURSE", Convert.ToDouble(txtValorCurso.Text));
                myCommand.Parameters.AddWithValue("PERIOD_COURSE", txtPeriodoCurso.Text);
                myCommand.ExecuteNonQuery();
                InterfaceOperations.ClearTextBoxes(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.myConnection.Close();
            }
        }
    }
}
