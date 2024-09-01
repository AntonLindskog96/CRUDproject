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
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Verdana", 12F);
            button1.Location = new Point(185, 377);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 0;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Verdana", 12F);
            button2.Location = new Point(310, 377);
            button2.Name = "button2";
            button2.Size = new Size(96, 40);
            button2.TabIndex = 1;
            button2.Text = "CREATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGreen;
            button3.Font = new Font("Verdana", 12F);
            button3.Location = new Point(443, 377);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 2;
            button3.Text = "READ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Khaki;
            button4.Font = new Font("Verdana", 12F);
            button4.Location = new Point(559, 377);
            button4.Name = "button4";
            button4.Size = new Size(100, 40);
            button4.TabIndex = 3;
            button4.Text = "UPDATE";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F);
            label1.Location = new Point(185, 47);
            label1.Name = "label1";
            label1.Size = new Size(27, 18);
            label1.TabIndex = 4;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(185, 105);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(185, 156);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 6;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(185, 202);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 7;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F);
            label5.Location = new Point(185, 258);
            label5.Name = "label5";
            label5.Size = new Size(85, 18);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Verdana", 12F);
            button5.Location = new Point(706, 377);
            button5.Name = "button5";
            button5.Size = new Size(109, 40);
            button5.TabIndex = 14;
            button5.Text = "DELETE";
            button5.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(602, 47);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(640, 151);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(602, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(120, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(602, 151);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(120, 23);
            txtUser.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(602, 202);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 19;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(602, 262);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(120, 23);
            txtPass.TabIndex = 20;
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
