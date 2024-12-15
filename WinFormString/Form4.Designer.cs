namespace WinFormString
{
    partial class Form4
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
            label = new Label();
            inputTextBox = new TextBox();
            CalculateButton = new Button();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10F);
            label.Location = new Point(56, 64);
            label.Name = "label";
            label.Size = new Size(56, 19);
            label.TabIndex = 0;
            label.Text = "ใส่ตัวเลข";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(130, 63);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(170, 23);
            inputTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(329, 62);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "คำนวณ";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(84, 156);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(320, 118);
            resultTextBox.TabIndex = 3;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 313);
            Controls.Add(resultTextBox);
            Controls.Add(CalculateButton);
            Controls.Add(inputTextBox);
            Controls.Add(label);
            Name = "Form4";
            Text = "32.ค่าเฉลี่ย";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox inputTextBox;
        private Button CalculateButton;
        private TextBox resultTextBox;
    }
}