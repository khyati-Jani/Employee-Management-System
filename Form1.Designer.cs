namespace Employee_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            cmbcountry = new ComboBox();
            cmbcity = new ComboBox();
            cmbstate = new ComboBox();
            cmbdesignation = new ComboBox();
            txtid = new TextBox();
            txtname = new TextBox();
            dtpdoj = new DateTimePicker();
            dtpdob = new DateTimePicker();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            btnprofile = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btndisplay = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 16);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 68);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Country :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 139);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "City :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 149);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "State :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 28);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 5;
            label6.Text = "DOJ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 61);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 6;
            label7.Text = "DOB :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 104);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 7;
            label8.Text = "Desigantion :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1092, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 8;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbcountry
            // 
            cmbcountry.FormattingEnabled = true;
            cmbcountry.Items.AddRange(new object[] { "India" });
            cmbcountry.Location = new Point(99, 104);
            cmbcountry.Name = "cmbcountry";
            cmbcountry.Size = new Size(151, 28);
            cmbcountry.TabIndex = 9;
            cmbcountry.DropDownClosed += cmbcountry_DropDownClosed;
            // 
            // cmbcity
            // 
            cmbcity.FormattingEnabled = true;
            cmbcity.Items.AddRange(new object[] { "surat" });
            cmbcity.Location = new Point(481, 136);
            cmbcity.Name = "cmbcity";
            cmbcity.Size = new Size(151, 28);
            cmbcity.TabIndex = 10;
            cmbcity.DropDownClosed += cmbcity_DropDownClosed;
            // 
            // cmbstate
            // 
            cmbstate.FormattingEnabled = true;
            cmbstate.Items.AddRange(new object[] { "", "Gujarat" });
            cmbstate.Location = new Point(99, 149);
            cmbstate.Name = "cmbstate";
            cmbstate.Size = new Size(151, 28);
            cmbstate.TabIndex = 11;
            // 
            // cmbdesignation
            // 
            cmbdesignation.FormattingEnabled = true;
            cmbdesignation.Items.AddRange(new object[] { "aaaaa" });
            cmbdesignation.Location = new Point(481, 96);
            cmbdesignation.Name = "cmbdesignation";
            cmbdesignation.Size = new Size(151, 28);
            cmbdesignation.TabIndex = 12;
            // 
            // txtid
            // 
            txtid.Location = new Point(99, 16);
            txtid.Name = "txtid";
            txtid.Size = new Size(151, 27);
            txtid.TabIndex = 13;
            // 
            // txtname
            // 
            txtname.Location = new Point(99, 61);
            txtname.Name = "txtname";
            txtname.Size = new Size(151, 27);
            txtname.TabIndex = 14;
            // 
            // dtpdoj
            // 
            dtpdoj.Location = new Point(470, 23);
            dtpdoj.Name = "dtpdoj";
            dtpdoj.Size = new Size(250, 27);
            dtpdoj.TabIndex = 15;
            // 
            // dtpdob
            // 
            dtpdob.Location = new Point(470, 59);
            dtpdob.Name = "dtpdob";
            dtpdob.Size = new Size(250, 27);
            dtpdob.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1207, 275);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(771, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnprofile
            // 
            btnprofile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprofile.Location = new Point(1048, 68);
            btnprofile.Name = "btnprofile";
            btnprofile.Size = new Size(158, 30);
            btnprofile.TabIndex = 19;
            btnprofile.Text = "Select Profile";
            btnprofile.UseVisualStyleBackColor = true;
            btnprofile.Click += btnprofile_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(1111, 113);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 20;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(1108, 153);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 21;
            btnupdate.Text = "update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndisplay
            // 
            btndisplay.Location = new Point(970, 165);
            btndisplay.Name = "btndisplay";
            btndisplay.Size = new Size(94, 29);
            btndisplay.TabIndex = 22;
            btndisplay.Text = "display";
            btndisplay.UseVisualStyleBackColor = true;
            btndisplay.Click += btndisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 487);
            Controls.Add(btndisplay);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnprofile);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(dtpdob);
            Controls.Add(dtpdoj);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(cmbdesignation);
            Controls.Add(cmbstate);
            Controls.Add(cmbcity);
            Controls.Add(cmbcountry);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private ComboBox cmbcountry;
        private ComboBox cmbcity;
        private ComboBox cmbstate;
        private ComboBox cmbdesignation;
        private TextBox txtid;
        private TextBox txtname;
        private DateTimePicker dtpdoj;
        private DateTimePicker dtpdob;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btnprofile;
        private Button btndelete;
        private Button btnupdate;
        private Button btndisplay;
    }
}
