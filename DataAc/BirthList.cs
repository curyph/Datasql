using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                SqlCommand myCommand = new SqlCommand("SELECT ID, FName, LName from Pessoas", connect.myConnection);

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
                SqlCommand myCommand = new SqlCommand("INSERT INTO Dependentes (Dep_Name, Dep_DOB, ID) values (@Dep_Name, @Dep_DOB, @ID)", connect.myConnection);
                myCommand.Parameters.AddWithValue("Dep_Name", txtDepName.Text);
                myCommand.Parameters.AddWithValue("Dep_DOB", Convert.ToDateTime(txtDepDOB.Text));
                myCommand.Parameters.AddWithValue("ID", Convert.ToInt16(comboBox1.SelectedValue));
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM DEPENDENTES");
                var dataAdapter = new SqlDataAdapter(myCommand.CommandText, connect.myConnection);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlCommand myCommand = new SqlCommand("select r.FName, r.LName, d.Dep_Name from Pessoas as r join Dependentes as d on r.ID = d.ID order by FName");
            var ds = new DataSet();
            var dataAdapter = new SqlDataAdapter(myCommand.CommandText, connect.myConnection);           
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Courses cadCurso = new Courses();
            cadCurso.Show();
        }
               
    }
}