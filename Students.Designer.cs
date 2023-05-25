namespace CRM_TRY4
{
    partial class Students
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOFBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPECIALTYCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONENUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.dATEOFBIRTHDataGridViewTextBoxColumn,
            this.gROUPNUMBERDataGridViewTextBoxColumn,
            this.sPECIALTYCODEDataGridViewTextBoxColumn,
            this.tELEPHONENUMBERDataGridViewTextBoxColumn,
            this.eMAILADDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            // 
            // dATEOFBIRTHDataGridViewTextBoxColumn
            // 
            this.dATEOFBIRTHDataGridViewTextBoxColumn.DataPropertyName = "DATEOFBIRTH";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.HeaderText = "DATEOFBIRTH";
            this.dATEOFBIRTHDataGridViewTextBoxColumn.Name = "dATEOFBIRTHDataGridViewTextBoxColumn";
            // 
            // gROUPNUMBERDataGridViewTextBoxColumn
            // 
            this.gROUPNUMBERDataGridViewTextBoxColumn.DataPropertyName = "GROUPNUMBER";
            this.gROUPNUMBERDataGridViewTextBoxColumn.HeaderText = "GROUPNUMBER";
            this.gROUPNUMBERDataGridViewTextBoxColumn.Name = "gROUPNUMBERDataGridViewTextBoxColumn";
            // 
            // sPECIALTYCODEDataGridViewTextBoxColumn
            // 
            this.sPECIALTYCODEDataGridViewTextBoxColumn.DataPropertyName = "SPECIALTYCODE";
            this.sPECIALTYCODEDataGridViewTextBoxColumn.HeaderText = "SPECIALTYCODE";
            this.sPECIALTYCODEDataGridViewTextBoxColumn.Name = "sPECIALTYCODEDataGridViewTextBoxColumn";
            // 
            // tELEPHONENUMBERDataGridViewTextBoxColumn
            // 
            this.tELEPHONENUMBERDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONENUMBER";
            this.tELEPHONENUMBERDataGridViewTextBoxColumn.HeaderText = "TELEPHONENUMBER";
            this.tELEPHONENUMBERDataGridViewTextBoxColumn.Name = "tELEPHONENUMBERDataGridViewTextBoxColumn";
            // 
            // eMAILADDRESSDataGridViewTextBoxColumn
            // 
            this.eMAILADDRESSDataGridViewTextBoxColumn.DataPropertyName = "EMAILADDRESS";
            this.eMAILADDRESSDataGridViewTextBoxColumn.HeaderText = "EMAILADDRESS";
            this.eMAILADDRESSDataGridViewTextBoxColumn.Name = "eMAILADDRESSDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            // 
            // managerCRMDataSet1
            // 
            // 
            // studentTableAdapter
            // 
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOFBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROUPNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECIALTYCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONENUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILADDRESSDataGridViewTextBoxColumn;
    }
}