using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String username;
        String password;
        public Form1()
        {
            InitializeComponent();
        }
        void runGame()
        {
            using (System.Diagnostics.Process a = new System.Diagnostics.Process())
            {
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("C:");
                info.Arguments = "\\Users\\Saulo\\Documents\\RPGVXAce\\projectNOMAD\\Game.exe"; // set args
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.UseShellExecute = false;
                a.StartInfo = info;
                a.Start();
                String output = a.StandardOutput.ReadToEnd();
                // process output
            }
        }
        bool runLoginScript()
        {
            using (Process p = new Process())
            {
                ProcessStartInfo info = new ProcessStartInfo(@"ruby");
                info.Arguments = "C:\\Users\\Saulo\\Documents\\RPGVXAce\\projectNOMAD\\Scripts\\login.rb" +" "+ username + " " + password; // set args
                info.RedirectStandardInput = true;
                info.RedirectStandardOutput = true;
                info.UseShellExecute = false;
                p.StartInfo = info;
                p.Start();
                String output = p.StandardOutput.ReadToEnd();
                // process output
                if (output == "0")
                {
                    MessageBox.Show("Incorrect password or username");
                    return false;
                }
                else
                {
                    MessageBox.Show("Welcome!");
                    return true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = runLoginScript();
            if (result == true)
            {
                Process.Start("C:\\Users\\Saulo\\Documents\\RPGVXAce\\projectNOMAD\\Game.exe");
 //               while (true)
   //             {
                    //   Process.Start("C:\\Users\\Saulo\\Documents\\RPGVXAce\\projectNOMAD\\Scripts\\test.rb");
     //           }
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
