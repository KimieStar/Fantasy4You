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
        private Rectangle buttonCharacterOriginal;
        private Rectangle FormSizeOriginalSize;

        LogicController logic = new LogicController();
        Thread characters;
        DatabaseController connection = new DatabaseController();
        
       

        

       // public string LabelUsername(string username)
       // {
       //      username = log.ReadUsername(username);
       //      return username;
       // }



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
            //FormSizeOriginalSize = new Rectangle(this.Location.X,this.Location.Y,this.Width,this.Height);
            //buttonCharacterOriginal = new Rectangle(YourCharactersButton.Location.X, YourCharactersButton.Location.Y, YourCharactersButton.Width,YourCharactersButton.Height);
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

        //private void ResizeControl(Rectangle r, Control c)
        //{
        //    float xRatio = (float)(this.Width) / (float)(FormSizeOriginalSize.Width);
        //    float yRatio = (float)(this.Height) / (float)(FormSizeOriginalSize.Height);
        //
        //    int newX = (int)(r.Location.X * xRatio);
        //    int newY = (int)(r.Location.Y * yRatio);
        //
        //    int newWidth = (int)(r.Width * xRatio);
        //    int newHeight = (int)(r.Height * yRatio);
        //        
        //    c.Location = new Point(newX, newY);
        //    c.Size = new Size(newWidth, newHeight);
        //}
        //private void MainInterface_Resize(object sender, EventArgs e)
        //{
        //    ResizeControl(buttonCharacterOriginal, YourCharactersButton);
        //}
    }
}
