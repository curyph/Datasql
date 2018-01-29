namespace DataAc
{
    partial class BirthList
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.txtDepDOB = new System.Windows.Forms.TextBox();
            this.btnInDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDepSelect = new System.Windows.Forms.Button();
            this.btnDelDep = new System.Windows.Forms.Button();
            this.btnSelDep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(64, 300);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(179, 20);
            this.txtDepName.TabIndex = 2;
            // 
            // txtDepDOB
            // 
            this.txtDepDOB.Location = new System.Drawing.Point(299, 300);
            this.txtDepDOB.Name = "txtDepDOB";
            this.txtDepDOB.Size = new System.Drawing.Size(170, 20);
            this.txtDepDOB.TabIndex = 4;
            // 
            // btnInDep
            // 
            this.btnInDep.Location = new System.Drawing.Point(475, 41);
            this.btnInDep.Name = "btnInDep";
            this.btnInDep.Size = new System.Drawing.Size(75, 23);
            this.btnInDep.TabIndex = 5;
            this.btnInDep.Text = "INSERT";
            this.btnInDep.UseVisualStyleBackColor = true;
            this.btnInDep.Click += new System.EventHandler(this.btnInDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Responsável";
            // 
            // btnDepSelect
            // 
            this.btnDepSelect.Location = new System.Drawing.Point(475, 12);
            this.btnDepSelect.Name = "btnDepSelect";
            this.btnDepSelect.Size = new System.Drawing.Size(75, 23);
            this.btnDepSelect.TabIndex = 9;
            this.btnDepSelect.Text = "SELECT";
            this.btnDepSelect.UseVisualStyleBackColor = true;
            this.btnDepSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelDep
            // 
            this.btnDelDep.Location = new System.Drawing.Point(475, 70);
            this.btnDelDep.Name = "btnDelDep";
            this.btnDelDep.Size = new System.Drawing.Size(75, 23);
            this.btnDelDep.TabIndex = 11;
            this.btnDelDep.Text = "DELETE";
            this.btnDelDep.UseVisualStyleBackColor = true;
            // 
            // btnSelDep
            // 
            this.btnSelDep.Location = new System.Drawing.Point(475, 99);
            this.btnSelDep.Name = "btnSelDep";
            this.btnSelDep.Size = new System.Drawing.Size(83, 38);
            this.btnSelDep.TabIndex = 12;
            this.btnSelDep.Text = "Dependentes";
            this.btnSelDep.UseVisualStyleBackColor = true;
            this.btnSelDep.Click += new System.EventHandler(this.button2_Click);
            // 
            // BirthList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 368);
            this.Controls.Add(this.btnSelDep);
            this.Controls.Add(this.btnDelDep);
            this.Controls.Add(this.btnDepSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInDep);
            this.Controls.Add(this.txtDepDOB);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "BirthList";
            this.Text = "BirthList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.TextBox txtDepDOB;
        private System.Windows.Forms.Button btnInDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepSelect;
        private System.Windows.Forms.Button btnDelDep;
        private System.Windows.Forms.Button btnSelDep;
    }
}