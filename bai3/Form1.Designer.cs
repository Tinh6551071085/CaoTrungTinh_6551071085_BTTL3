namespace bai3
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
            txtHo = new TextBox();
            txtTen = new TextBox();
            btn_ten = new Button();
            btnHo = new Button();
            btn_exit = new Button();
            btnHoTen = new Button();
            lblHoTen = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 81);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Ho lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 151);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Ten";
            label2.Click += label2_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(190, 85);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(469, 27);
            txtHo.TabIndex = 2;
            txtHo.TextChanged += txtHo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(190, 151);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(469, 27);
            txtTen.TabIndex = 3;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // btn_ten
            // 
            btn_ten.Location = new Point(336, 250);
            btn_ten.Name = "btn_ten";
            btn_ten.Size = new Size(103, 42);
            btn_ten.TabIndex = 4;
            btn_ten.Text = "Ten";
            btn_ten.UseVisualStyleBackColor = true;
            btn_ten.Click += btn_ten_Click;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(117, 341);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(103, 42);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(336, 341);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(103, 42);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát chương trình";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(556, 341);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(103, 42);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.Location = new Point(130, 12);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(538, 55);
            lblHoTen.TabIndex = 8;
            lblHoTen.Click += label3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 217);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "6551071085";
            label3.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblHoTen);
            Controls.Add(btnHoTen);
            Controls.Add(btn_exit);
            Controls.Add(btnHo);
            Controls.Add(btn_ten);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btn_ten;
        private Button btnHo;
        private Button btn_exit;
        private Button btnHoTen;
        private Label lblHoTen;
        private Label label3;
    }
}
