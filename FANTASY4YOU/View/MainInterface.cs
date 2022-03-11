using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FANTASY4YOU;



namespace FANTASY4YOU
{
    

    

    public partial class MainInterface : Form
    {
        WelcomeScreen welcomeScreen = new WelcomeScreen();
        LogicController logic = new LogicController();
        Thread characters;
        DatabaseController connection = new DatabaseController();


        public MainInterface()
        {
            InitializeComponent();
            connection.OpenCon();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            
            string uname = User.Username;
            label2.Text = uname;

           int id = logic.SelectUserId();


            label4.Text = id.ToString();
            
        }

        public static void SetApartmentState(ApartmentState sTA)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            characters = new Thread(OpenCharacters);
            characters.SetApartmentState(ApartmentState.STA);
            characters.Start();
            this.Close();
        }

        private void OpenCharacters(object? obj)
        {
           Application.Run(new Characters());
        }

    }
}
