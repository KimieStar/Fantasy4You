using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOGIC;

namespace Fantasy4You
{
    public partial class Form1 : Form


    {
        Logic log1 = new Logic();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //log1.ConTry();
            button1.Text = "Click";
        }

        private void label1_Click(object sender, EventArgs e)
        {


            //string list = string.Join("\n", log1.RetrieveList().Select(l => string.Join(",", l)));
            string firstName = log1.firstName();

            label1.Text = firstName;
            //label1.Text = "hi";

        }
    }
}