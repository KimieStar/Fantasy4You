using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FANTASY4YOU;



namespace FANTASY4YOU
{
    

    

    public partial class MainInterface1 : Form
    {
        LogicController logic = new LogicController();
        Thread characters;
        DatabaseController connection = new DatabaseController();


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MainInterface1()
        {
            InitializeComponent();
            connection.OpenCon();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            //WindowTopBar.BackColor = Color.FromArgb(165, Color.Black);
            string uname = User.Username;
            label2.Text = uname;

           int id = logic.SelectUserId();


            label4.Text = id.ToString();
            
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
