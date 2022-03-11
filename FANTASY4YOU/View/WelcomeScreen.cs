using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using FANTASY4YOU;

namespace FANTASY4YOU
{
    public partial class WelcomeScreen : Form
    {
        DatabaseController databaseController = new DatabaseController();
        Thread MainInterface;

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string uname = User.Username;
            label2.Text = uname;


        }

        private void OpenMainInterface(object? obj)
        {
            Application.Run(new MainInterface());
        }

        private void WelcomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainInterface = new Thread(OpenMainInterface);
            MainInterface.SetApartmentState(ApartmentState.STA);
            MainInterface.Start();
            databaseController.UpdateIsUserNew();
        }
    }
}