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

namespace Generic02WinForm
{
    public partial class frmMainWindow : Form
    {
        //-------------------------------------------------------
        //Image bkg = Image.FromFile(@"D:\Documents\New folder\bkg0728.PNG");
        Image ArrowDown = Image.FromFile(@"C:\Users\aziml\source\repos\Generic02WinForm\Generic02WinForm\Images\btnDown.png");
        Image ArrowUp = Image.FromFile(@"C:\Users\aziml\source\repos\Generic02WinForm\Generic02WinForm\Images\btnUp.png");

        Image AboutEmpty = Image.FromFile(@"C:\Users\aziml\source\repos\Generic02WinForm\Generic02WinForm\Images\btnAboutSquareBlue.png");
        Image AboutGreen = Image.FromFile(@"C:\Users\aziml\source\repos\Generic02WinForm\Generic02WinForm\Images\btnAboutSquareGreen.png");
        
        //----- Modules for the interface------------------------
        int varmoveLeft = 0;
        int AppMenue = 0;
        int VarAbout = 0;
        //-------------------------------------------------------
        public frmMainWindow()
        {
            //------------------Thread created for the Splash screen
            Thread t = new Thread(new ThreadStart(LoadigSplash));
            t.Start();
            //------------------------------------------------------
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort(); // Complete
        }
        //---------------Splash form loading -------------
        public void LoadigSplash()
        {
            SplashGen02 frm = new SplashGen02();
            Application.Run(frm);
        }
        //------------------------------------------------


        private void BtnHamburger_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 300)
            {
                panelMenu.Width = 60;
            }
            else
            {
                panelMenu.Width = 300;
            }
        }

        //----------------------- Form load   ---------------------------------
        private void FrmMain_Load(object sender, EventArgs e)
        {



        }
        //---------------------------------------------------------------------
        //------------------Soub Menu Controls --------------------------------
        int varMenu = 0;

        public void varMenuState()
        {
            if (varMenu == 0)
            {
                varMenu = 1;
            }
            else
            {
                varMenu = 0;
            }

        }
        //--------------------------------------------------------------------
        private void BtnMenu01_Click(object sender, EventArgs e)
        {
            if (varMenu == 0)
            {
                panelMenu01.Height = 55;
                BtnMenu01.BackgroundImage = ArrowDown;

            }

            if (varMenu == 1)
            {
                panelMenu01.Height = 165;
                BtnMenu01.BackgroundImage = ArrowUp;
            }
            varMenuState();
        }
        //--------------------------------------------------------------------
        private void BtnMenu02_Click(object sender, EventArgs e)
        {
            if (varMenu == 0)
            {
                panelMenu02.Height = 55;
                BtnMenu02.BackgroundImage = ArrowDown;

            }

            if (varMenu == 1)
            {
                panelMenu02.Height = 165;
                BtnMenu02.BackgroundImage = ArrowUp;
            }
            varMenuState();
        }
        //--------------------------------------------------------------------
        private void BtnMenu03_Click(object sender, EventArgs e)
        {
            if (varMenu == 0)
            {
                panelMenu03.Height = 55;
                BtnMenu03.BackgroundImage = ArrowDown;

            }

            if (varMenu == 1)
            {
                panelMenu03.Height = 165;
                BtnMenu03.BackgroundImage = ArrowUp;
            }
            varMenuState();
        }
        //--------------------------------------------------------------------
        private void BtnMenu04_Click(object sender, EventArgs e)
        {
            if (varMenu == 0)
            {
                panelMenu04.Height = 55;
                BtnMenu04.BackgroundImage = ArrowDown;

            }

            if (varMenu == 1)
            {
                panelMenu04.Height = 165;
                BtnMenu04.BackgroundImage = ArrowUp;
            }
            varMenuState();
        }

        //---------------------------------------------------------
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            if (VarAbout == 0) { VarAbout = 1;} else { VarAbout = 0; }
        }

        //---------------------------------------------------------

        private void BtnAbout_MouseHover(object sender, EventArgs e)
        {
            BtnAbout.BackgroundImage = AboutGreen;
        }

        private void BtnAbout_MouseLeave(object sender, EventArgs e)
        {
            BtnAbout.BackgroundImage = AboutEmpty;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        private void timerMain_Tick(object sender, EventArgs e) 
        {
            if (VarAbout == 0)
            {
                if (panelAbout.Top > -395)
                {
                    panelAbout.Top = panelAbout.Top - 20;
                }

            }
            if (VarAbout == 1)
            {
                if (panelAbout.Top < -20)
                {
                    panelAbout.Top = panelAbout.Top + 20;

                }

            }

            //------------------------------------------------------------------------

            if (AppMenue == 0)
            {
                if (panelFrame01.Left >= -580)
                {
                    panelFrame01.Left = panelFrame01.Left - 20;

                }

                if (panelFrame02.Left >= -580)
                {
                    panelFrame02.Left = panelFrame02.Left - 20;

                }

                if (panelFrame03.Left >= -580)
                {
                    panelFrame03.Left = panelFrame03.Left - 20;

                }
            }
            //------------------------------------------------------------------------
            if (AppMenue == 1)
            {
                if (panelFrame01.Left <= 350)
                {
                    panelFrame01.Left = panelFrame01.Left + 20;
                    //------------------------------------------
                    string strx = varmoveLeft.ToString();
                    
                    varmoveLeft++;
                }

                if (panelFrame02.Left >= -580)
                {
                    panelFrame02.Left = panelFrame02.Left - 20;
                   
                }

                if (panelFrame03.Left >= -580)
                {
                    panelFrame03.Left = panelFrame03.Left - 20;

                }
            }

            //------------------------------------------------------------------------
            if (AppMenue == 2)
            {
                if (panelFrame02.Left <= 350)
                {
                    panelFrame02.Left = panelFrame02.Left + 20;
                    //------------------------------------------
                    string strx = varmoveLeft.ToString();

                    varmoveLeft++;
                }

                if (panelFrame01.Left >= -580)
                {
                    panelFrame01.Left = panelFrame01.Left - 20;

                }

                if (panelFrame03.Left >= -580)
                {
                    panelFrame03.Left = panelFrame03.Left - 20;

                }
            }

            if (AppMenue == 3)
            {
                if (panelFrame03.Left <= 350)
                {
                    panelFrame03.Left = panelFrame03.Left + 20;
                    //------------------------------------------
                    string strx = varmoveLeft.ToString();

                    varmoveLeft++;
                }

                if (panelFrame01.Left >= -580)
                {
                    panelFrame01.Left = panelFrame01.Left - 20;

                }

                if (panelFrame02.Left >= -580)
                {
                    panelFrame02.Left = panelFrame02.Left - 20;

                }
            }

        }

        private void BtnFrame01_Click(object sender, EventArgs e)
        {
            AppMenue = 1;
        }

        private void BtnFrame02_Click(object sender, EventArgs e)
        {
            AppMenue = 2;
        }

        private void BtnFrame03_Click(object sender, EventArgs e)
        {
            AppMenue = 3;
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
