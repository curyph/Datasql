using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DataAc
{
    
    public partial class Cadastros : Form
    {
        SqlCon connect = new SqlCon();
        public Cadastros()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM PESSOAS");
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO PESSOAS (Fname, Lname, Phone, DOB) values (@Fname, @Lname, @Phone, @DOB)", connect.myConnection);
                myCommand.Parameters.AddWithValue("Fname", txtFName.Text);
                myCommand.Parameters.AddWithValue("Lname", txtLName.Text);
                myCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
                myCommand.Parameters.AddWithValue("DOB", Convert.ToDateTime(txtDOB.Text));
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
            
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE PESSOAS SET FName=@Fname, Lname=@Lname, Phone=@Phone, DOB=@DOB WHERE ID=@ID ", connect.myConnection);
                myCommand.Parameters.AddWithValue("ID", ID);
                myCommand.Parameters.AddWithValue("Fname", txtFName.Text);
                myCommand.Parameters.AddWithValue("Lname", txtLName.Text);
                myCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
                myCommand.Parameters.AddWithValue("DOB", Convert.ToDateTime(txtDOB.Text));
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

        public string ID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var valorCelulas = dataGridView1.Rows[e.RowIndex];
            ID = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells["FName"].Value.ToString();
            txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells["LName"].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            txtDOB.Text = dataGridView1.Rows[e.RowIndex].Cells["DOB"].Value.ToString();            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("DELETE PESSOAS WHERE ID = @ID", connect.myConnection);
                myCommand.Parameters.AddWithValue("ID", ID);
                myCommand.Parameters.AddWithValue("Fname", txtFName.Text);
                myCommand.Parameters.AddWithValue("Lname", txtLName.Text);
                myCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
                myCommand.Parameters.AddWithValue("DOB", Convert.ToDateTime(txtDOB.Text));
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

        private void btnBirth_Click(object sender, EventArgs e)
        {
            BirthList formb = new BirthList();
            formb.Show();
        }
    }
}