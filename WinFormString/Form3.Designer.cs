namespace WinFormString
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtRectangleWidth = new TextBox();
            btnRectangleArea = new Button();
            txtRectangleHeight = new TextBox();
            lblResult = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            txtTime = new TextBox();
            btnCalculate = new Button();
            txtSpeed = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRectangleWidth);
            groupBox1.Controls.Add(btnRectangleArea);
            groupBox1.Controls.Add(txtRectangleHeight);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(45, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "สูตรที่1 คำนวณพื้นที่สี่เหลี่ยมผืนผ้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 96);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 5;
            label2.Text = "ความกว้าง";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 4;
            label1.Text = "ความสูง";
            // 
            // txtRectangleWidth
            // 
            txtRectangleWidth.Location = new Point(113, 93);
            txtRectangleWidth.Name = "txtRectangleWidth";
            txtRectangleWidth.Size = new Size(127, 25);
            txtRectangleWidth.TabIndex = 3;
            // 
            // btnRectangleArea
            // 
            btnRectangleArea.Location = new Point(283, 54);
            btnRectangleArea.Name = "btnRectangleArea";
            btnRectangleArea.Size = new Size(88, 46);
            btnRectangleArea.TabIndex = 2;
            btnRectangleArea.Text = "คำนวณ";
            btnRectangleArea.UseVisualStyleBackColor = true;
            btnRectangleArea.Click += btnRectangleArea_Click;
            // 
            // txtRectangleHeight
            // 
            txtRectangleHeight.Location = new Point(113, 38);
            txtRectangleHeight.Name = "txtRectangleHeight";
            txtRectangleHeight.Size = new Size(127, 25);
            txtRectangleHeight.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 192);
            lblResult.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(565, 153);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(187, 114);
            lblResult.TabIndex = 1;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTime);
            groupBox2.Controls.Add(btnCalculate);
            groupBox2.Controls.Add(txtSpeed);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(45, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 143);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "สูตรที่2 คำนวณระยะทาง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 96);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 5;
            label3.Text = "เวลา (ชั่วโมง)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 41);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 4;
            label4.Text = "ความเร็ว (ก.ม./ชม.)";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(113, 93);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(127, 25);
            txtTime.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(283, 54);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(88, 46);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "คำนวณ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(113, 38);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(127, 25);
            txtSpeed.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(lblResult);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "30.สูตรคณิต";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRectangleArea;
        private TextBox txtRectangleHeight;
        private TextBox txtRectangleWidth;
        private Label label2;
        private Label label1;
        private Label lblResult;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private TextBox txtTime;
        private Button btnCalculate;
        private TextBox txtSpeed;
    }
}