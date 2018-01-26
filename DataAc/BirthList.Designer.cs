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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 335);
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
            this.dataGridView1.Size = new System.Drawing.Size(399, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(32, 300);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(179, 20);
            this.txtDepName.TabIndex = 2;
            // 
            // txtDepDOB
            // 
            this.txtDepDOB.Location = new System.Drawing.Point(261, 300);
            this.txtDepDOB.Name = "txtDepDOB";
            this.txtDepDOB.Size = new System.Drawing.Size(170, 20);
            this.txtDepDOB.TabIndex = 4;
            // 
            // btnInDep
            // 
            this.btnInDep.Location = new System.Drawing.Point(465, 56);
            this.btnInDep.Name = "btnInDep";
            this.btnInDep.Size = new System.Drawing.Size(75, 23);
            this.btnInDep.TabIndex = 5;
            this.btnInDep.Text = "INSERT";
            this.btnInDep.UseVisualStyleBackColor = true;
            this.btnInDep.Click += new System.EventHandler(this.btnInDep_Click);
            // 
            // BirthList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 368);
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
    }
}