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
    public partial class Courses : Form
    {
        SqlCon connect = new SqlCon();
        SqlCommand myCommand;
        SqlDataReader reader;
        DataTable dt;
        public int ID;
        public Courses()
        {
            InitializeComponent();
            try
            {
                connect.myConnection.Open();
                myCommand = new SqlCommand("SELECT IDDEP, DEP_NAME FROM DEPENDENTES", connect.myConnection);
                reader = myCommand.ExecuteReader();
                dt = new DataTable();
                dt.Columns.Add("ID_DEP", typeof(string));
                dt.Columns.Add("DEP_NAME", typeof(string));
                dt.Load(reader);

                cbNomeAluno.ValueMember = "IDdep";                
                cbNomeAluno.DisplayMember = "Dep_Name";
                cbNomeAluno.DataSource = dt;

               
                myCommand = new SqlCommand("SELECT ID_COURSE, NAME_COURSE, COST_COURSE, PERIOD_COURSE FROM COURSES", connect.myConnection);
                reader = myCommand.ExecuteReader();
                dt = new DataTable();
                dt.Columns.Add("ID_COURSE", typeof(string));
                dt.Columns.Add("NAME_COURSE", typeof(string));
                dt.Load(reader);

                cbNomeCurso.ValueMember = "ID_COURSE";
                cbNomeCurso.DisplayMember = "NAME_COURSE";
                cbNomeCurso.DataSource = dt;

                myCommand = new SqlCommand("SELECT ID FROM DEPENDENTES ", connect.myConnection);
                reader = myCommand.ExecuteReader();
                dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Load(reader);

                cbID.ValueMember = "ID";
                cbID.DisplayMember = "FName";
                cbID.DataSource = dt;


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

        private void btnCadastroCurso_Click(object sender, EventArgs e)
        {
            CadastroCurso cadNewCurso = new CadastroCurso();
            cadNewCurso.Show();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                SqlCommand myCommand = new SqlCommand("INSERT INTO MATRICULA (IDDEP, ID_COURSE, ID) VALUES(@IDDEP, @ID_COURSE, @ID)", connect.myConnection);
                myCommand.Parameters.AddWithValue("IDDEP", cbNomeAluno.SelectedValue);
                myCommand.Parameters.AddWithValue("ID_COURSE", cbNomeCurso.SelectedValue);
                myCommand.Parameters.AddWithValue("ID", ID);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Matrícula efetuada com sucesso");
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                connect.myConnection.Open();
                myCommand = new SqlCommand("SELECT m.ID, p.FName, c.NAME_COURSE, c.COST_COURSE "
                                           + "from MATRICULA as m "
                                           + "join courses as c on c.ID_course = m.ID_COURSE "
                                           + "join pessoas as p on m.id = p.id");
                var dataAdapter = new SqlDataAdapter(myCommand.CommandText, connect.myConnection);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgMatricula.ReadOnly = true;
                dgMatricula.DataSource = ds.Tables[0];

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
