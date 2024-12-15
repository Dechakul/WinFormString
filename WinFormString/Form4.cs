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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // รับข้อมูลจาก TextBox และแปลงเป็น Array
                string input = inputTextBox.Text;
                int[] numbers = input.Split(',').Select(int.Parse).ToArray();

                // คำนวณค่าเฉลี่ยทั้งสองวิธี
                double averageFor = CalculateAverageFor(numbers);
                double averageForeach = CalculateAverageForeach(numbers);

                // แสดงผลลัพธ์
                resultTextBox.Text = $"Average (using for loop): {averageFor:F2}\r\n" +
                                     $"Average (using foreach loop): {averageForeach:F2}";
            }
            catch (Exception ex)
            {
                resultTextBox.Text = "Invalid input! Please enter only numbers separated by commas.";
            }
        }
        public static double CalculateAverageFor(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }

        // Method สำหรับคำนวณค่าเฉลี่ยแบบ foreach
        public static double CalculateAverageForeach(int[] numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        // Entry Point
        [STAThread]
        public static void Cal()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form4());
        }

    }
}
