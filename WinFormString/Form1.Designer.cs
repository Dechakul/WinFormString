namespace WinFormString
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
            btnSplitName = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            SuspendLayout();
            // 
            // btnSplitName
            // 
            btnSplitName.Location = new Point(520, 73);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(75, 23);
            btnSplitName.TabIndex = 0;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = true;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 77);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 138);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 185);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 3;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 236);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "นามสกุล";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 74);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(336, 23);
            txtFullName.TabIndex = 5;
            txtFullName.Text = "นายเดชากุล จินตฤทธิ์";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(150, 135);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(181, 23);
            txtTitle.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 182);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 233);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(181, 23);
            txtLastName.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSplitName);
            Name = "Form1";
            Text = "29.แยกชื่อ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSplitName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}
