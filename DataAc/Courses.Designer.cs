namespace DataAc
{
    partial class Courses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgMatricula = new System.Windows.Forms.DataGridView();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCadastroCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNomeAluno = new System.Windows.Forms.ComboBox();
            this.cbNomeCurso = new System.Windows.Forms.ComboBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMatricula
            // 
            this.dgMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatricula.Location = new System.Drawing.Point(12, 12);
            this.dgMatricula.Name = "dgMatricula";
            this.dgMatricula.Size = new System.Drawing.Size(444, 269);
            this.dgMatricula.TabIndex = 0;
            // 
            // btnMatricula
            // 
            this.btnMatricula.Location = new System.Drawing.Point(475, 57);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(75, 34);
            this.btnMatricula.TabIndex = 1;
            this.btnMatricula.Text = "Matricular";
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(475, 97);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 39);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar Cadastros";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCadastroCurso
            // 
            this.btnCadastroCurso.Location = new System.Drawing.Point(475, 12);
            this.btnCadastroCurso.Name = "btnCadastroCurso";
            this.btnCadastroCurso.Size = new System.Drawing.Size(75, 39);
            this.btnCadastroCurso.TabIndex = 3;
            this.btnCadastroCurso.Text = "Cadastrar Curso";
            this.btnCadastroCurso.UseVisualStyleBackColor = true;
            this.btnCadastroCurso.Click += new System.EventHandler(this.btnCadastroCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Curso";
            // 
            // cbNomeAluno
            // 
            this.cbNomeAluno.FormattingEnabled = true;
            this.cbNomeAluno.Location = new System.Drawing.Point(55, 293);
            this.cbNomeAluno.Name = "cbNomeAluno";
            this.cbNomeAluno.Size = new System.Drawing.Size(186, 21);
            this.cbNomeAluno.TabIndex = 13;
            // 
            // cbNomeCurso
            // 
            this.cbNomeCurso.FormattingEnabled = true;
            this.cbNomeCurso.Location = new System.Drawing.Point(301, 293);
            this.cbNomeCurso.Name = "cbNomeCurso";
            this.cbNomeCurso.Size = new System.Drawing.Size(155, 21);
            this.cbNomeCurso.TabIndex = 14;
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(486, 293);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(61, 21);
            this.cbID.TabIndex = 15;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 326);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.cbNomeCurso);
            this.Controls.Add(this.cbNomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastroCurso);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.dgMatricula);
            this.Name = "Courses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMatricula;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCadastroCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNomeAluno;
        private System.Windows.Forms.ComboBox cbNomeCurso;
        private System.Windows.Forms.ComboBox cbID;
    }
}