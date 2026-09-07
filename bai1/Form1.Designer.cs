namespace bai1
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
            btn_hienthi = new Button();
            btn_cn = new Button();
            btn_exit = new Button();
            txt_hienthi = new Label();
            txtpass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btn_hienthi
            // 
            btn_hienthi.Location = new Point(108, 338);
            btn_hienthi.Name = "btn_hienthi";
            btn_hienthi.Size = new Size(94, 29);
            btn_hienthi.TabIndex = 0;
            btn_hienthi.Text = "Hiển thị";
            btn_hienthi.UseVisualStyleBackColor = true;
            btn_hienthi.Click += btn_hienthi_Click;
            // 
            // btn_cn
            // 
            btn_cn.Location = new Point(359, 338);
            btn_cn.Name = "btn_cn";
            btn_cn.Size = new Size(94, 29);
            btn_cn.TabIndex = 1;
            btn_cn.Text = "Tiếp";
            btn_cn.UseVisualStyleBackColor = true;
            btn_cn.Click += btn_cn_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(597, 338);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Đóng";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // txt_hienthi
            // 
            txt_hienthi.AutoSize = true;
            txt_hienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_hienthi.Location = new Point(200, 188);
            txt_hienthi.Name = "txt_hienthi";
            txt_hienthi.Size = new Size(64, 20);
            txt_hienthi.TabIndex = 3;
            txt_hienthi.Text = "Hiển thị";
            txt_hienthi.Click += txt_hienthi_Click;
            // 
            // txtpass
            // 
            txtpass.AutoSize = true;
            txtpass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(170, 79);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(118, 20);
            txtpass.TabIndex = 3;
            txtpass.Text = "Nhập password";
            txtpass.Click += txtpass_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 76);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '#';
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtpass);
            Controls.Add(txt_hienthi);
            Controls.Add(btn_exit);
            Controls.Add(btn_cn);
            Controls.Add(btn_hienthi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_hienthi;
        private Button btn_cn;
        private Button btn_exit;
        private Label txt_hienthi;
        private Label txtpass;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
