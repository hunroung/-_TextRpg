using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Boss : Form
    {
        NPC boss;
        int chapter_;
        public Boss()
        {
            InitializeComponent();
        }
        public Boss(NPC boss,int chapter)
        {
            InitializeComponent();
            this.boss = boss;
            picture_npc.Visible = false;
            chapter_ = chapter;
        }

        private void Boss_Load(object sender, EventArgs e)
        {
            switch(chapter_)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(".\\img\\Background_1.png");
                    Delay(1000);
                    pictureBox1.Image = Image.FromFile(".\\img\\Background_2.png");
                    Delay(1000);
                    pictureBox1.Image = Image.FromFile(".\\img\\Background_3.png");
                    Delay(1000);
                    pictureBox1.Image = Image.FromFile(".\\img\\Background_4.png");
                    Delay(1000);
                    pictureBox1.Image = Image.FromFile(".\\img\\Background_5.png");
                    Delay(1000);
                    pictureBox1.Image = Image.FromFile(".\\img\\Background_6.png");
                    Delay(1000);
                    picture_npc.Visible = true;
                    picture_npc.Image = boss.img;
                    Delay(1000);
                    break;
            }
            
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void Boss_Load_1(object sender, EventArgs e)
        {

        }
    }
}
