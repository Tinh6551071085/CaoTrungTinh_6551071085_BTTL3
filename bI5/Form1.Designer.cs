namespace bI5
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
            label1 = new Label();
            textBox1 = new TextBox();

            gb_color = new GroupBox();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();

            gp_font = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();

            label2 = new Label();
            lblLapTrinh = new Label();
            exit = new Button();

            gb_color.SuspendLayout();
            gp_font.SuspendLayout();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên";

            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(545, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;

            // 
            // gb_color
            // 
            gb_color.Controls.Add(radBlack);
            gb_color.Controls.Add(radGreen);
            gb_color.Controls.Add(radBlue);
            gb_color.Controls.Add(radRed);
            gb_color.Location = new Point(73, 98);
            gb_color.Name = "gb_color";
            gb_color.Size = new Size(190, 275);
            gb_color.TabIndex = 3;
            gb_color.TabStop = false;
            gb_color.Text = "Color";

            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(6, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(53, 24);
            radRed.TabIndex = 0;
            radRed.Text = "red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;

            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(6, 69);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(60, 24);
            radBlue.TabIndex = 1;
            radBlue.Text = "blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;

            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(6, 112);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(69, 24);
            radGreen.TabIndex = 2;
            radGreen.Text = "green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;

            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(6, 155);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(66, 24);
            radBlack.TabIndex = 3;
            radBlack.Text = "black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;

            // 
            // gp_font
            // 
            gp_font.Controls.Add(checkBox5);
            gp_font.Controls.Add(checkBox6);
            gp_font.Controls.Add(checkBox7);
            gp_font.Location = new Point(519, 98);
            gp_font.Name = "gp_font";
            gp_font.Size = new Size(190, 275);
            gp_font.TabIndex = 4;
            gp_font.TabStop = false;
            gp_font.Text = "Font";

            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0
            );
            checkBox5.Location = new Point(6, 39);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(80, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "In đậm";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;

            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Italic,
                GraphicsUnit.Point,
                0
            );
            checkBox6.Location = new Point(6, 95);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(96, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "in nghiên";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;

            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Underline,
                GraphicsUnit.Point,
                0
            );
            checkBox7.Location = new Point(6, 125);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(98, 24);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "gạch chân";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 400);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Lập trình bởi";

            // 
            // lblLapTrinh
            // 
            lblLapTrinh.AutoSize = true;
            lblLapTrinh.Location = new Point(213, 400);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(0, 20);
            lblLapTrinh.TabIndex = 6;

            // 
            // exit
            // 
            exit.Location = new Point(425, 392);
            exit.Name = "exit";
            exit.Size = new Size(181, 41);
            exit.TabIndex = 8;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(exit);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(gp_font);
            Controls.Add(gb_color);
            Controls.Add(textBox1);
            Controls.Add(label1);

            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;

            gb_color.ResumeLayout(false);
            gb_color.PerformLayout();

            gp_font.ResumeLayout(false);
            gp_font.PerformLayout();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;

        private GroupBox gb_color;
        private RadioButton radRed;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radBlack;

        private GroupBox gp_font;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;

        private Label label2;
        private Label lblLapTrinh;
        private Button exit;
    }
}