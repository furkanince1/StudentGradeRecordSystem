
namespace StudentGradeRecordSystem
{
    partial class FrmTeacherDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.MskNummer = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblUnsuccesfulStudent = new System.Windows.Forms.Label();
            this.LblSuccesfulStudent = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwStudent = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TbxSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxName);
            this.groupBox1.Controls.Add(this.MskNummer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Students";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbxSurname
            // 
            this.TbxSurname.Location = new System.Drawing.Point(115, 154);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(125, 30);
            this.TbxSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(115, 96);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(125, 30);
            this.TbxName.TabIndex = 2;
            // 
            // MskNummer
            // 
            this.MskNummer.Location = new System.Drawing.Point(115, 39);
            this.MskNummer.Mask = "0000";
            this.MskNummer.Name = "MskNummer";
            this.MskNummer.Size = new System.Drawing.Size(66, 30);
            this.MskNummer.TabIndex = 1;
            this.MskNummer.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtExam3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TxtExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtExam1);
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Notes";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(115, 157);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(125, 30);
            this.TxtExam3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Exam 3:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(115, 102);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(125, 30);
            this.TxtExam2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 1:";
//            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(115, 39);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(125, 30);
            this.TxtExam1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblUnsuccesfulStudent);
            this.groupBox3.Controls.Add(this.LblSuccesfulStudent);
            this.groupBox3.Controls.Add(this.LblAverage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(529, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 258);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Notes";
            // 
            // LblUnsuccesfulStudent
            // 
            this.LblUnsuccesfulStudent.AutoSize = true;
            this.LblUnsuccesfulStudent.Location = new System.Drawing.Point(213, 163);
            this.LblUnsuccesfulStudent.Name = "LblUnsuccesfulStudent";
            this.LblUnsuccesfulStudent.Size = new System.Drawing.Size(34, 24);
            this.LblUnsuccesfulStudent.TabIndex = 9;
            this.LblUnsuccesfulStudent.Text = "00";
            // 
            // LblSuccesfulStudent
            // 
            this.LblSuccesfulStudent.AutoSize = true;
            this.LblSuccesfulStudent.Location = new System.Drawing.Point(213, 108);
            this.LblSuccesfulStudent.Name = "LblSuccesfulStudent";
            this.LblSuccesfulStudent.Size = new System.Drawing.Size(34, 24);
            this.LblSuccesfulStudent.TabIndex = 8;
            this.LblSuccesfulStudent.Text = "00";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Location = new System.Drawing.Point(213, 45);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(34, 24);
            this.LblAverage.TabIndex = 4;
            this.LblAverage.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Unsuccessful Student:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Successful Student:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Average:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgwStudent);
            this.groupBox4.Location = new System.Drawing.Point(4, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(883, 324);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Notes";
//            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dgwStudent
            // 
            this.dgwStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwStudent.Location = new System.Drawing.Point(3, 26);
            this.dgwStudent.Name = "dgwStudent";
            this.dgwStudent.RowHeadersWidth = 51;
            this.dgwStudent.RowTemplate.Height = 29;
            this.dgwStudent.Size = new System.Drawing.Size(877, 295);
            this.dgwStudent.TabIndex = 0;
            this.dgwStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudent_CellClick);
//            this.dgwStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(888, 624);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmTeacherDetail";
            this.Text = "Teacher Detail";
            this.Load += new System.EventHandler(this.FrmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.MaskedTextBox MskNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblUnsuccesfulStudent;
        private System.Windows.Forms.Label LblSuccesfulStudent;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgwStudent;
    }
}