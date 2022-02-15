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
using LOGIC;


namespace MAIN_INTERFACE
{


    

    public partial class MainInterface : Form
    {

        Logic log = new Logic();
        UserInfo uinfo = new UserInfo();
        string username;
        string username1;
        int id1;
       

        

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
            
            
            string uname = log.ReadUID(username);
            label2.Text = uname;

            string usernamee = log.ReadUID(username1);
            int id = log.SelectUserId(id1, usernamee);


            label4.Text = id.ToString();
        }

        public static void SetApartmentState(ApartmentState sTA)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
