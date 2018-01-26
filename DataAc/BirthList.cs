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

namespace DataAc
{
    
    public partial class BirthList : Form
    {
        SqlCon connect = new SqlCon();
        public BirthList()
        {
            InitializeComponent();
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT FName, LName from Pessoas", connect.myConnection);

                SqlDataReader reader = myCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("FName", typeof(string));
                dt.Columns.Add("LName", typeof(string));
                dt.Load(reader);

                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "FName";
                comboBox1.DataSource = dt;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }

        private void btnInDep_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO Dependentes (Dep_Name, Dep_DOB, ID) values (@DepName, @DepDOB, @ID)", connect.myConnection);
                myCommand.Parameters.AddWithValue("Dep_Name", txtDepName.Text);
                myCommand.Parameters.AddWithValue(" Dep_DOB", Convert.ToDateTime(txtDepDOB.Text));
                myCommand.Parameters.AddWithValue("ID", Convert.ToInt16(comboBox1.ValueMember));                
                myCommand.ExecuteNonQuery();
                InterfaceOperations.ClearTextBoxes();
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
