namespace WinFormString
{
    partial class Form2
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
            btn1 = new Button();
            txt_in_int = new TextBox();
            txt_out = new Label();
            comboBox1 = new ComboBox();
            txt_in_str = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 10F);
            btn1.Location = new Point(205, 167);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(135, 47);
            btn1.TabIndex = 0;
            btn1.Text = "เลือกรูปแบบ";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // txt_in_int
            // 
            txt_in_int.Location = new Point(122, 97);
            txt_in_int.Margin = new Padding(3, 2, 3, 2);
            txt_in_int.Multiline = true;
            txt_in_int.Name = "txt_in_int";
            txt_in_int.Size = new Size(134, 26);
            txt_in_int.TabIndex = 3;
            // 
            // txt_out
            // 
            txt_out.BackColor = SystemColors.ButtonHighlight;
            txt_out.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            txt_out.Location = new Point(417, 31);
            txt_out.Name = "txt_out";
            txt_out.Size = new Size(366, 292);
            txt_out.TabIndex = 5;
            txt_out.Text = "โปรดใส่ขนาดและเลือกรูปแบบ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 180);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 25);
            comboBox1.TabIndex = 6;
            // 
            // txt_in_str
            // 
            txt_in_str.Location = new Point(122, 45);
            txt_in_str.Margin = new Padding(3, 2, 3, 2);
            txt_in_str.Multiline = true;
            txt_in_str.Name = "txt_in_str";
            txt_in_str.Size = new Size(134, 26);
            txt_in_str.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(33, 48);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 8;
            label2.Text = "ใส่ตัวอักษร";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(33, 100);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 9;
            label3.Text = "ใส่จำนวนแถว";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SeaShell;
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_in_int);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_in_str);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 292);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "ใส่ขนาดที่จะสร้าง";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 440);
            Controls.Add(groupBox1);
            Controls.Add(txt_out);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "31.รูปแบบ";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private TextBox txt_in_int;
        private Label txt_out;
        private ComboBox comboBox1;
        private TextBox txt_in_str;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
    }
}