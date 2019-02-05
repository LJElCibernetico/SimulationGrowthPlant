using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SimulationGrowthPlant
{
    public partial class PicturesViewer : Form
    {
        String img;
        int i = 0, cont = 0;
        String[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "/0" };

        public PicturesViewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*MessageBox.Show("Imagenes sacadas del siguiente video @https://www.youtube.com/watch?v=w77zPAtVTuI");
            img = "Day " + num[i] + ".png";
            ShowImage();*/
            Change.Enabled = true;
        }

        private void ShowImage()
        {
            PictureBox.Image = Image.FromFile(@"C:\Users\LJ\Desktop\Crecimiento de una Planta\" + img);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (i < 25)
            {
                if (i == 24)
                {
                    i = -1;
                }
                i++;
                img = "Day " + num[i] + ".png";
            }
            ShowImage();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = 25;
                img = "Day " + num[i] + ".png";
            }
            if (i > 0)
            {
                i--;
                img = "Day " + num[i] + ".png";
            }
            ShowImage();
        }

        private void Change_Tick(object sender, EventArgs e)
        {
            cont++;
            if(cont == 50)
            {
                img = "Day " + num[0] + ".png";
                ShowImage();
            }

            if(cont == 200)
            {
                img = "Day " + num[1] + ".png";
                ShowImage();
            }

            if (cont == 350)
            {
                img = "Day " + num[2] + ".png";
                ShowImage();
            }

            if (cont == 500)
            {
                img = "Day " + num[3] + ".png";
                ShowImage();
            }

            if (cont == 650)
            {
                img = "Day " + num[4] + ".png";
                ShowImage();
            }

            if (cont == 800)
            {
                img = "Day " + num[5] + ".png";
                ShowImage();
            }

            if (cont == 950)
            {
                img = "Day " + num[6] + ".png";
                ShowImage();
            }

            if (cont == 1100)
            {
                img = "Day " + num[7] + ".png";
                ShowImage();
            }

            if (cont == 1250)
            {
                img = "Day " + num[8] + ".png";
                ShowImage();
            }

            if (cont == 1400)
            {
                img = "Day " + num[9] + ".png";
                ShowImage();
            }

            if (cont == 1550)
            {
                img = "Day " + num[10] + ".png";
                ShowImage();
            }

            if (cont == 1700)
            {
                img = "Day " + num[11] + ".png";
                ShowImage();
            }

            if (cont == 1850)
            {
                img = "Day " + num[12] + ".png";
                ShowImage();
            }

            if (cont == 2000)
            {
                img = "Day " + num[13] + ".png";
                ShowImage();
            }

            if (cont == 2150)
            {
                img = "Day " + num[14] + ".png";
                ShowImage();
            }

            if (cont == 2300)
            {
                img = "Day " + num[15] + ".png";
                ShowImage();
            }

            if (cont == 2450)
            {
                img = "Day " + num[16] + ".png";
                ShowImage();
            }

            if (cont == 2600)
            {
                img = "Day " + num[17] + ".png";
                ShowImage();
            }

            if (cont == 2750)
            {
                img = "Day " + num[18] + ".png";
                ShowImage();
            }

            if (cont == 2900)
            {
                img = "Day " + num[19] + ".png";
                ShowImage();
            }

            if (cont == 3050)
            {
                img = "Day " + num[20] + ".png";
                ShowImage();
            }

            if (cont == 3200)
            {
                img = "Day " + num[21] + ".png";
                ShowImage();
            }

            if (cont == 3350)
            {
                img = "Day " + num[22] + ".png";
                ShowImage();
            }

            if (cont == 3500)
            {
                img = "Day " + num[23] + ".png";
                ShowImage();
            }

            if (cont == 3650)
            {
                img = "Day " + num[24] + ".png";
                ShowImage();
                MessageBox.Show("La planta ya crecio");
            }

            if (cont == 4000)
            {
                cont = 0;
                PictureBox.Image = null;
                Change.Stop();
                this.Close();
                //Change.Start(); Con esta linea puedo hacer que continue el ciclo de vida
            }
        }
    }
}

