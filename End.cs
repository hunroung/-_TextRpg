using System;
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
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@form 복사시에 아래 부분 복사 후 Form2 를 새로 만든 폼 이름으로 바꿀것.
        //해당 부분 copy 필요
        public int visit = 0;
        public character ch;
        public int fight = 0;
        public NPC monster = new NPC();
        public End(ref character character)
        {
            ch = character;
            InitializeComponent();
            setting(character);
            //item_btn_enable();
            act_btn_enable();
            picture_main.Image = character.main;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            ch.save();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            ch.close = 1;
            this.Close();
        }

        //폼 로딩시 세팅 단계
        public void setting(character character)
        {
            if (fight == 1)
            {
                npc_name.Text = monster.name;
                npc_health.Text = monster.real_health.ToString();
            }

            if (character.item_str > 0)
            {
                str.Text = character.str.ToString() + " +" + character.item_str.ToString();
            }
            else
            {
                str.Text = character.str.ToString();
            }
            if (character.item_intel > 0)
            {
                intel.Text = character.intel.ToString() + " +" + character.item_intel.ToString();
            }
            else
            {
                intel.Text = character.intel.ToString();
            }
            if (character.item_spd > 0)
            {
                spd.Text = character.spd.ToString() + " +" + character.item_spd.ToString();
            }
            else
            {
                spd.Text = character.spd.ToString();
            }
            if (character.item_def > 0)
            {
                def.Text = character.def.ToString() + " +" + character.item_def.ToString();
            }
            else
            {
                def.Text = character.def.ToString();
            }

            //item_btn_able(ch);

            //label2.Text = ch.skill_point.ToString();
            name.Text = character.name;
            exp.Text = character.exp_per.ToString() + '%';
            leb.Text = character.leb.ToString();
            point.Text = character.stat_point.ToString();
            real_health.Text = character.real_health.ToString() + " / " + character.max_health.ToString();

            if (character.stat_point < 1)
            {
                stat_btn_setting(false);
            }
            else
            {
                stat_btn_setting(true);
            }
            if (cmb_skill.Items.Count < ch.skill_count)
            {
                cmb_skill.Items.Clear();
                for (int i = 0; i < ch.skill_count; i++)
                {
                    cmb_skill.Items.Add(ch.skill[i]);
                }
            }

        }
        //공격, 방어, 스킬, 도망 버튼 비활성화
        public void act_btn_enable()
        {
            btn_attack.Enabled = false;
            btn_defend.Enabled = false;
            btn_skill.Enabled = false;
            //btn_run.Enabled = false;
        }
        //공격, 방어, 스킬, 도망 버튼 활성화
        public void act_btn_able()
        {
            btn_attack.Enabled = true;
            btn_defend.Enabled = true;
            btn_skill.Enabled = true;
           // btn_run.Enabled = true;
        }

        //stat 포인트에 따라 버튼 활성화 , 비활성화
        public void stat_btn_setting(bool bl)
        {
            if (bl)
            {
                btn_str.Enabled = true;
                btn_intel.Enabled = true;
                btn_spd.Enabled = true;
                btn_def.Enabled = true;
            }
            else
            {

                btn_str.Enabled = false;
                btn_intel.Enabled = false;
                btn_spd.Enabled = false;
                btn_def.Enabled = false;
            }
        }
        //아이템 버튼 비활성화 하기
        
        //업데이트 용
        public void update()
        {
            Delay(100);
            setting(ch);
            Delay(100);
        }

        private void btn_str_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name.ToString())
            {
                case "btn_str":
                    ch.str += 1;
                    ch.stat_use();
                    break;
                case "btn_intel":
                    ch.intel += 1;
                    ch.stat_use();
                    break;
                case "btn_spd":
                    ch.spd += 1;
                    ch.stat_use();
                    break;
                case "btn_def":
                    ch.def += 1;
                    ch.stat_use();
                    break;
                default:
                    break;
            }
            update();
        }
        //아이템 사용
        private void btn_item_Click(object sender, EventArgs e)
        {

        }
        //아이템 버튼 활성화 하기


        private void End_Load(object sender, EventArgs e)
        {
            //@@@@@@@@@@@@@@@@@@@@한줄 대사@@@@@@@@@@@@@@@@@@@@@
            textBox1.AppendText("당신은 모든 보스를 쓰러트렸다. \r\n");
            this.Refresh();
            Delay(2000);
            //@@@@@@@@@@@@@@@@@@@@@한줄 대사@@@@@@@@@@@@@@@@@@@@@@
            textBox1.AppendText(ch.name+": 이제 돌아갈 수 있는건가… \r\n");
            this.Refresh();
            Delay(2000);
            //@@@@@@@@@@@@@@@@@@@@몬스터 등장@@@@@@@@@@@@@@@@@@
            textBox1.AppendText("@@1[+^_•?=>가 난입합니다! \r\n");
            Delay(2000);
            pictureBox12.Image = Image.FromFile(".\\img\\End_1.png");
            Delay(1000);
            this.Refresh();
            pictureBox12.Image = Image.FromFile(".\\img\\End_2.png");
            pictureBox12.Parent = this;
            Delay(1000);
            this.Refresh();
            pictureBox12.Image = Image.FromFile(".\\img\\End_3.png");
            Delay(1000);
            this.Refresh();
            pictureBox12.Image = Image.FromFile(".\\img\\End_4.png");
            textBox1.AppendText("@@1[+^_•?=>가 일격을 날립니다! \r\n");
            Delay(1000);
            this.Refresh();
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ch.damaged(1000000);
            picture_main.Image = ch.main_dead;
            this.Refresh();
            Delay(1000);
            MessageBox.Show("당신은 죽었습니다.");
            MessageBox.Show("플레이해주셔서 감사합니다");
            this.Close();
        }

        private void End_Load_1(object sender, EventArgs e)
        {

        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    }
}
