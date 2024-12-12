namespace WinFormString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName="", fristname="", lastname="", title="";
            int x = 0;
            fullName = txtFullName.Text.Trim();

            if (fullName.StartsWith("นางสาว"))
            {
                x = 6;
                title = fullName.Substring(0, x);

            }
            else if (fullName.StartsWith("นาง") || fullName.StartsWith("นาย")) 
            {
                x = 3;
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กชาย")) 
            {
                x = 7;
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กหญิง"))
            {
                x = 8;
                title = fullName.Substring(0, x);
            }
            else
            {
                x = fullName.LastIndexOf('.') + 1;
                title = fullName.Substring(0, x);
            }

            fullName = fullName.Substring(x).Trim();
            MessageBox.Show(title + "\n" +  fullName);



            x = fullName.IndexOf (' ');

            fristname = fullName.Substring (0, x).Trim();

            lastname = fullName.Substring (x).Trim();

            txtTitle.Text = title;
            txtFirstName.Text = fristname;
            txtLastName.Text = lastname;

        }
    }
}
