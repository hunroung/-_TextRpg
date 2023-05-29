using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public character character;
        public Form1()
        {
            InitializeComponent();
            character= new character();
        }

        // 복사 필수

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int k = 1;
            if (namebox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요");
            }
            else
            {
                if (k == 0)
                {
                    character.name = namebox.Text;
                    Form2 form2 = new Form2(ref character);
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                }
                else
                {
                    character.skill_gain("심판");
                    character.item_gain(0, 5);
                    character.name = namebox.Text;
                    C_1_0 form2 = new C_1_0(ref character);
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                    if(character.real_health==0 || character.close == 1)
                    {
                        character= new character();
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save save = new save(ref character);
            save.ShowDialog();
            if(character.name!=null)
            {
                //character.chapter=2;
                switch (character.chapter)
                {
                    case 1:
                        C_1_0 form2 = new C_1_0(ref character);
                        form2.ShowDialog();
                        if (character.real_health == 0||character.close==1)
                        {
                            character = new character();
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
