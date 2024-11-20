namespace CRUDproject
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            txtEmail = new TextBox();
            txtUser = new TextBox();
            txtName = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Verdana", 8F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(185, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Verdana", 8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(266, 219);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 1;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Verdana", 8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(347, 219);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 2;
            button3.Text = "READ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Font = new Font("Verdana", 8F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(428, 219);
            button4.Name = "button4";
            button4.Size = new Size(81, 28);
            button4.TabIndex = 3;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8F);
            label1.Location = new Point(185, 47);
            label1.Name = "label1";
            label1.Size = new Size(21, 13);
            label1.TabIndex = 4;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 8F);
            label2.Location = new Point(185, 74);
            label2.Name = "label2";
            label2.Size = new Size(38, 13);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8F);
            label3.Location = new Point(185, 105);
            label3.Name = "label3";
            label3.Size = new Size(65, 13);
            label3.TabIndex = 6;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8F);
            label4.Location = new Point(185, 139);
            label4.Name = "label4";
            label4.Size = new Size(40, 13);
            label4.TabIndex = 7;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 8F);
            label5.Location = new Point(185, 168);
            label5.Name = "label5";
            label5.Size = new Size(61, 13);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button5.Font = new Font("Verdana", 8F);
            button5.ForeColor = Color.FromArgb(192, 0, 0);
            button5.Location = new Point(636, 219);
            button5.Name = "button5";
            button5.Size = new Size(86, 29);
            button5.TabIndex = 14;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(347, 42);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(375, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(790, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(640, 151);
            dataGridView1.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(347, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(375, 23);
            txtEmail.TabIndex = 17;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(347, 105);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(375, 23);
            txtUser.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(347, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(375, 23);
            txtName.TabIndex = 19;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(347, 163);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(375, 23);
            txtPass.TabIndex = 20;
            txtPass.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1324, 595);
            Controls.Add(dataGridView1);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(txtUser);
            Controls.Add(txtEmail);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private TextBox txtEmail;
        private TextBox txtUser;
        private TextBox txtName;
        private TextBox txtPass;
    }
}
