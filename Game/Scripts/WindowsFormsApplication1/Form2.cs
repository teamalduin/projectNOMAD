using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        String name;
        String email;
        String username;
        String password;
        bool runRegisterScript()
        {
            using (System.Diagnostics.Process p = new System.Diagnostics.Process())
            {
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(@"ruby");
                info.Arguments = "C:\\Users\\Saulo\\Documents\\RPGVXAce\\projectNOMAD\\Scripts\\register.rb"+name+" "+email+" "+ username + " " + password; // set args
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.UseShellExecute = false;
                p.StartInfo = info;
                p.Start();
                String output = p.StandardOutput.ReadToEnd();
                // process output
                if (output == "0")
                {
                    MessageBox.Show("An error occoured, please try again");
                    return false;
                }
                else
                {
                    MessageBox.Show("Account Successfully created");
                    return true;
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = runRegisterScript();
            if (result == true) {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            username = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            password = textBox4.Text;
        }
    }
}
