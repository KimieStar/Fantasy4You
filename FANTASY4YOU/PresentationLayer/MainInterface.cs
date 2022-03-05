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

        Logic logic = new Logic();
        Thread characters;
        
       

        

       // public string LabelUsername(string username)
       // {
       //      username = log.ReadUsername(username);
       //      return username;
       // }



        public MainInterface()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            
            
            string uname = logic.ReadUsernameFromUsernameFile();
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

        private void MainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            logic.deleteCharSelectedToEditFile();
        }
    }
}
