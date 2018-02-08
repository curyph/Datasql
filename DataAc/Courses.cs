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

                myCommand = new SqlCommand("SELECT distinct d.ID, p.FName "
                                          + "FROM Dependentes AS d "
                                          + "JOIN Pessoas AS p on d.ID = p.ID "
                                            , connect.myConnection);
                reader = myCommand.ExecuteReader();
                dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Load(reader);


                //int idteste = 0;

                //connect.myConnection.Open();
                //myCommand = new SqlCommand("SELECT IDDEP FROM DEPENDENTES WHERE PARAMETRO = " + , connect.myConnection);
                //idteste = myCommand.ExecuteScalar();
                
                //SELECT D.FName[RESPONSÁVEL], C.Dep_Name[DEPENDENTE], B.NAME_COURSE[CURSO],B.COST_COURSE[CUSTO],B.PERIOD_COURSE[PERIODO] 
                //FROM MATRICULA A 
                //INNER JOIN COURSES B ON A.ID_COURSE = B.ID_COURSE
                //INNER JOIN Dependentes C ON A.IDdep = C.IDdep
                //INNER JOIN Pessoas D ON C.ID = D.ID


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
                SqlCommand myCommand = new SqlCommand("INSERT INTO MATRICULA (IDDEP, ID_COURSE) VALUES(@IDDEP, @ID_COURSE)", connect.myConnection);              
                myCommand.Parameters.AddWithValue("IDDEP", cbNomeAluno.SelectedValue);
                myCommand.Parameters.AddWithValue("ID_COURSE", cbNomeCurso.SelectedValue);
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
                myCommand = new SqlCommand("select d.ID, p.Fname, j.name_course, j.cost_course " 
                                           + "from Dependentes as d "
                                           + "join Pessoas as p on p.ID = d.ID "
                                           + "join MATRICULA as c on d.IDdep = c.IDdep "
                                           + "JOIN COURSES as j on j.ID_COURSE = c.ID_COURSE ");
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
