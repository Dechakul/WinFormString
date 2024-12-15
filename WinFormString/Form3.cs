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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // อ่านค่าจาก TextBox
                double speed = double.Parse(txtSpeed.Text);
                double time = double.Parse(txtTime.Text);

                // คำนวณระยะทาง
                double distance = CalculateDistance(speed, time);

                // แสดงผลลัพธ์
                lblResult.Text = "ระยะทาง: " + distance + " กิโลเมตร";
            }
            catch (FormatException)
            {
                MessageBox.Show("กรุณากรอกตัวเลขที่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ฟังก์ชันคำนวณระยะทาง
        /// </summary>
        /// <param name="speed">ความเร็ว</param>
        /// <param name="time">เวลา</param>
        /// <returns>ระยะทาง</returns>
        private double CalculateDistance(double speed, double time)
        {
            return speed * time;
        }
    }    
}
