using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SimulationGrowthPlant
{
    public partial class PicturesViewer : Form
    {
        String img;
        int i = 0;
        String[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "/0" };
        Stopwatch s = new Stopwatch();
        long mini;

        public PicturesViewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Imagenes sacadas del siguiente video @https://www.youtube.com/watch?v=w77zPAtVTuI");
            img = "Day " + num[i] + ".png";
            ShowImage();
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

            mini = s.ElapsedMilliseconds;
            MessageBox.Show(mini.ToString());
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

        }
    }
}

