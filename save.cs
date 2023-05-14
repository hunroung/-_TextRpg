using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class save : Form
    {
        public character ch;
        character[] characters;
        public string[] files;
        public save()
        {
            InitializeComponent();
        }

        public save(ref character character)
        {
            InitializeComponent();
            ch = character;
            files = Directory.GetFiles(".\\saves\\", "*.txt");
            characters = new character[files.Length];
            int i = 0;
            foreach (string file in files)
            {
                characters[i] = new character();
                characters[i].load(file);
                i++;
            }
            for (int j = 0; j < files.Length; j++)
            {
                if (characters[j].name != null)
                {
                    if (characters[j].name != "")
                    {
                        listBox.Items.Add(characters[j].name);
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void save_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex == -1)
            {
                return;
            }
            int i = listBox.SelectedIndex;
            chapter.Text = characters[i].chapter.ToString();
            name.Text = characters[i].name;
            level.Text= characters[i].leb.ToString();
            str.Text= characters[i].str.ToString();
            spd.Text= characters[i].spd.ToString();
            intel.Text= characters[i].intel.ToString();
            def.Text= characters[i].def.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex ==-1)
            {
                MessageBox.Show("캐릭터를 선택하세요");
            }
            else
            {
                ch.load(".\\saves\\" + characters[listBox.SelectedIndex].name+".txt");
                this.Close();
            }
        }
    }
}
