namespace CRM_TRY4
{
    partial class Resume
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.boxId = new System.Windows.Forms.ComboBox();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mYSQLDataSet1 = new CRM_TRY4.MYSQLDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.softSkills = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.educ = new System.Windows.Forms.TextBox();
            this.yearEnd = new System.Windows.Forms.TextBox();
            this.drLic = new System.Windows.Forms.TextBox();
            this.Primar = new System.Windows.Forms.TextBox();
            this.secName = new System.Windows.Forms.TextBox();
            this.StudName = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new CRM_TRY4.MYSQLDataSet1TableAdapters.StudentTableAdapter();
            this.mYSQLDataSet3 = new CRM_TRY4.MYSQLDataSet3();
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new CRM_TRY4.MYSQLDataSet3TableAdapters.StudentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYSQLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYSQLDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.boxId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.softSkills);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.educ);
            this.panel1.Controls.Add(this.yearEnd);
            this.panel1.Controls.Add(this.drLic);
            this.panel1.Controls.Add(this.Primar);
            this.panel1.Controls.Add(this.secName);
            this.panel1.Controls.Add(this.StudName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(61, 53);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 23;
            this.iconButton1.Text = "ОБНОВИТЬ";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // boxId
            // 
            this.boxId.DataSource = this.studentBindingSource3;
            this.boxId.DisplayMember = "ID";
            this.boxId.FormattingEnabled = true;
            this.boxId.Location = new System.Drawing.Point(61, 26);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(121, 21);
            this.boxId.TabIndex = 22;
            this.boxId.ValueMember = "ID";
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this.mYSQLDataSet1;
            // 
            // mYSQLDataSet1
            // 
            this.mYSQLDataSet1.DataSetName = "MYSQLDataSet1";
            this.mYSQLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(12, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Личные навыки";
            // 
            // softSkills
            // 
            this.softSkills.Location = new System.Drawing.Point(176, 318);
            this.softSkills.Multiline = true;
            this.softSkills.Name = "softSkills";
            this.softSkills.ReadOnly = true;
            this.softSkills.Size = new System.Drawing.Size(202, 104);
            this.softSkills.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Образование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Год окончания учёбы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Водительское удостоверение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ФИО";
            // 
            // educ
            // 
            this.educ.Location = new System.Drawing.Point(176, 292);
            this.educ.Name = "educ";
            this.educ.ReadOnly = true;
            this.educ.Size = new System.Drawing.Size(100, 20);
            this.educ.TabIndex = 9;
            // 
            // yearEnd
            // 
            this.yearEnd.Location = new System.Drawing.Point(176, 266);
            this.yearEnd.Name = "yearEnd";
            this.yearEnd.ReadOnly = true;
            this.yearEnd.Size = new System.Drawing.Size(100, 20);
            this.yearEnd.TabIndex = 8;
            // 
            // drLic
            // 
            this.drLic.Location = new System.Drawing.Point(176, 240);
            this.drLic.Name = "drLic";
            this.drLic.ReadOnly = true;
            this.drLic.Size = new System.Drawing.Size(100, 20);
            this.drLic.TabIndex = 7;
            // 
            // Primar
            // 
            this.Primar.Location = new System.Drawing.Point(176, 214);
            this.Primar.Name = "Primar";
            this.Primar.ReadOnly = true;
            this.Primar.Size = new System.Drawing.Size(100, 20);
            this.Primar.TabIndex = 6;
            // 
            // secName
            // 
            this.secName.Location = new System.Drawing.Point(176, 188);
            this.secName.Name = "secName";
            this.secName.ReadOnly = true;
            this.secName.Size = new System.Drawing.Size(100, 20);
            this.secName.TabIndex = 5;
            this.secName.TextChanged += new System.EventHandler(this.secName_TextChanged);
            // 
            // StudName
            // 
            this.StudName.Location = new System.Drawing.Point(176, 162);
            this.StudName.Name = "StudName";
            this.StudName.ReadOnly = true;
            this.StudName.Size = new System.Drawing.Size(100, 20);
            this.StudName.TabIndex = 2;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // mYSQLDataSet3
            // 
            this.mYSQLDataSet3.DataSetName = "MYSQLDataSet3";
            this.mYSQLDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataMember = "Student";
            this.studentBindingSource4.DataSource = this.mYSQLDataSet3;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Resume";
            this.Text = "Resume";
            this.Load += new System.EventHandler(this.Resume_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYSQLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mYSQLDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TextBox StudName;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox educ;
        private System.Windows.Forms.TextBox yearEnd;
        private System.Windows.Forms.TextBox drLic;
        private System.Windows.Forms.TextBox Primar;
        private System.Windows.Forms.TextBox secName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox softSkills;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.ComboBox boxId;
        private MYSQLDataSet1 mYSQLDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private MYSQLDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MYSQLDataSet3 mYSQLDataSet3;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private MYSQLDataSet3TableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}