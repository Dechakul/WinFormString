using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormString
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRectangleArea_Click(object sender, EventArgs e)
        {
            try
            {
                // รับค่าจาก TextBox (สมมติว่า TextBox มีชื่อ txtWidth และ txtHeight)
                double width = Convert.ToDouble(txtRectangleWidth.Text);
                double height = Convert.ToDouble(txtRectangleHeight.Text);

                // เรียกใช้ Method CalculateRectangleArea
                double area = CalculateRectangleArea(width, height);

                // แสดงผลลัพธ์ใน Label (สมมติ Label มีชื่อ lblResult)
                lblResult.Text = $"Area of Rectangle: {area}";
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณาใส่ตัวเลขและใส่ข้อมูลให้ครบ", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

    }
}
