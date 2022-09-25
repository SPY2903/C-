namespace KT30
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Newbutton = new System.Windows.Forms.Button();
            this.Sumbutton = new System.Windows.Forms.Button();
            this.Maxbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.labelT = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(32, 84);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(200, 39);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Thêm vào danh sách";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(271, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 212);
            this.listBox1.TabIndex = 4;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(32, 150);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(200, 39);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Xóa khỏi danh sách";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Newbutton
            // 
            this.Newbutton.Location = new System.Drawing.Point(32, 210);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(200, 39);
            this.Newbutton.TabIndex = 5;
            this.Newbutton.Text = "Làm mới";
            this.Newbutton.UseVisualStyleBackColor = true;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // Sumbutton
            // 
            this.Sumbutton.Location = new System.Drawing.Point(525, 32);
            this.Sumbutton.Name = "Sumbutton";
            this.Sumbutton.Size = new System.Drawing.Size(130, 39);
            this.Sumbutton.TabIndex = 6;
            this.Sumbutton.Text = "Tính tổng";
            this.Sumbutton.UseVisualStyleBackColor = true;
            this.Sumbutton.Click += new System.EventHandler(this.Sumbutton_Click);
            // 
            // Maxbutton
            // 
            this.Maxbutton.Location = new System.Drawing.Point(525, 107);
            this.Maxbutton.Name = "Maxbutton";
            this.Maxbutton.Size = new System.Drawing.Size(130, 39);
            this.Maxbutton.TabIndex = 7;
            this.Maxbutton.Text = "Tìm Max";
            this.Maxbutton.UseVisualStyleBackColor = true;
            this.Maxbutton.Click += new System.EventHandler(this.Maxbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(525, 179);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(130, 39);
            this.Exitbutton.TabIndex = 8;
            this.Exitbutton.Text = "Thoát";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(690, 40);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(53, 21);
            this.labelT.TabIndex = 9;
            this.labelT.Text = "label1";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(690, 115);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(53, 21);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 328);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Maxbutton);
            this.Controls.Add(this.Sumbutton);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.Button Sumbutton;
        private System.Windows.Forms.Button Maxbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelMax;
    }
}

