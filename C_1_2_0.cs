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

namespace WindowsFormsApp1
{
    public partial class C_1_2_0 : Form
    {
        public C_1_2_0()
        {
            InitializeComponent();
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@form 복사시에 아래 부분 복사 후 Form2 를 새로 만든 폼 이름으로 바꿀것.
        //해당 부분 copy 필요
        public int visit = 0;
        public character ch;
        //public slime slime = new slime();
        public C_1_2_0(ref character character)
        {


            //string name = "슬라임";
            //slime.name = name;
            ch = character;

            InitializeComponent();


            setting(character);
            item_btn_enable();
            act_btn_enable();
            picture_main.Image = character.main;
            //picture_npc.Image = slime.img;
            //스킬 옮겨 담기
        }

        //폼 로딩시 세팅 단계
        public int fight = 0;
        public NPC monster = new NPC();
        private void btn_save_Click(object sender, EventArgs e)
        {
            ch.save();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            ch.close = 1;
            this.Close();
        }
        public void setting(character character)
        {
            //따로 추가
            if (fight == 1)
            {
                npc_name.Text = monster.name;
                npc_health.Text = monster.real_health.ToString();
            }
            //따로 추가
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

            item_btn_able(ch);

            label2.Text = ch.skill_point.ToString();
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
            btn_run.Enabled = false;
        }
        //공격, 방어, 스킬, 도망 버튼 활성화
        public void act_btn_able()
        {
            btn_attack.Enabled = true;
            btn_defend.Enabled = true;
            btn_skill.Enabled = true;
            btn_run.Enabled = true;
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
        public void item_btn_enable()
        {
            item_1.Text = ch.item_have(0).ToString();
            item_2.Text = ch.item_have(1).ToString();
            item_3.Text = ch.item_have(2).ToString();
            item_4.Text = ch.item_have(3).ToString();
            item_5.Text = ch.item_have(4).ToString();
            item_6.Text = ch.item_have(5).ToString();
            item_7.Text = ch.item_have(6).ToString();
            item_8.Text = ch.item_have(7).ToString();

            btn_item_1.Enabled = false;
            btn_item_2.Enabled = false;
            btn_item_3.Enabled = false;
            btn_item_4.Enabled = false;
            btn_item_5.Enabled = false;
            btn_item_6.Enabled = false;
            btn_item_7.Enabled = false;
            btn_item_8.Enabled = false;
        }
        //업데이트 용
        public void update()
        {
            Thread.Sleep(100);
            setting(ch);
            Thread.Sleep(100);
        }
        public void move_btn_enable()
        {
            btn_travel.Enabled = false;
            btn_down_move.Enabled = false;
            btn_left_move.Enabled = false;
            btn_right_move.Enabled = false;
            btn_up_move.Enabled = false;
        }



        public void move_btn_able()
        {
            btn_travel.Enabled = true;
            btn_down_move.Enabled = true;
            btn_left_move.Enabled = true;
            btn_right_move.Enabled = true;
            btn_up_move.Enabled = true;
        }
        //아이템 버튼 활성화 하기
        public void item_btn_able(character character)
        {
            for (int i = 0; i < character.max_item; i++)
            {

                switch (i)
                {
                    case 0:
                        item_1.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_1.Enabled = true;
                        else
                            btn_item_1.Enabled = false;
                        break;
                    case 1:
                        item_2.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_2.Enabled = true;
                        else
                            btn_item_2.Enabled = false;

                        break;
                    case 2:
                        item_3.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_3.Enabled = true;
                        else
                            btn_item_3.Enabled = false;

                        break;
                    case 3:
                        item_4.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_4.Enabled = true;
                        else
                            btn_item_4.Enabled = false;

                        break;
                    case 4:
                        item_5.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_5.Enabled = true;
                        else
                            btn_item_5.Enabled = false;

                        break;
                    case 5:
                        item_6.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_6.Enabled = true;
                        else
                            btn_item_6.Enabled = false;

                        break;
                    case 6:
                        item_7.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_7.Enabled = true;
                        else
                            btn_item_7.Enabled = false;
                        break;
                    case 7:
                        item_8.Text = character.item_have(i).ToString();
                        if (character.item_have(i) > 0)
                            btn_item_8.Enabled = true;
                        else
                            btn_item_8.Enabled = false;
                        break;
                    default:
                        break;

                }

            }
        }

        private void btn_right_move_Click(object sender, EventArgs e)
        {
            C_1_2_1 form = new C_1_2_1(ref ch);
            this.Hide();
            form.ShowDialog();

            if (ch.real_health <= 0 || ch.close==1)
            {
                this.Close();
            }
            this.Show();
            update();
            this.Refresh();
        }

        private void btn_down_move_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void C_1_2_0_Load(object sender, EventArgs e)
        {
            if(ch.secret_shop01 == 0)
            {
                move_btn_enable();
                btn_attack.Visible = false;
                btn_defend.Visible = false;
                btn_shop_item1.Visible = false;
                btn_shop_item2.Visible = false;
                btn_shop_item3.Visible = false;
                btn_shopout.Visible = false;
                btn_yes.Enabled = false;
                btn_no.Enabled = false;
                textBox1.AppendText ( "던전을 탐색하던 도중 자욱한 연기 사이에서 비밀 상점이 나타났다. \r\n");
                this.Refresh();
                Thread.Sleep(2000);
                textBox1.AppendText("한 번 둘러볼까? \r\n\r\n");
                this.Refresh();
                Thread.Sleep(2000);
                btn_yes.Enabled = true;
                btn_no.Enabled = true;
            }

        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            btn_yes.Visible = false;
            btn_no.Visible = false;
            btn_shop_item1.Visible = true;
            btn_shop_item2.Visible = true;
            btn_shop_item3.Visible = true;
            btn_shopout.Visible = true;
            btn_shop_item1.Enabled = false;
            btn_shop_item2.Enabled = false;
            btn_shop_item3.Enabled = false;
            btn_shopout.Enabled = false;
            textBox1.AppendText("비밀 상점에서는 던전을 탐험하는데 도움이 되는 아이템들이 많았다.\r\n");
            this.Refresh();
            Thread.Sleep(2000);
            textBox1.AppendText("소지하고 있는 코인으로 다양한 아이템을 구매할 수 있어 보인다.\r\n\r\n");
            this.Refresh();
            Thread.Sleep(2000);
            btn_shop_item1.Enabled = true;
            btn_shop_item2.Enabled = true;
            btn_shop_item3.Enabled = true;
            btn_shopout.Enabled = true;
            textBox1.AppendText("[비밀 상점 아이템 목록]\r\n");
            textBox1.AppendText("① 회복물약 3개 - 체력을 10 회복합니다. [ 구매가격 : 코인 1개 ]\r\n\r\n");
            textBox1.AppendText("② 대형회복물약 1개 - 체력을 30 회복합니다. 스킬사용횟수가 1회 추가됩니다. [ 구매가격 : 코인 1개 ]\r\n\r\n");
            textBox1.AppendText("③ 스킬회복물약 1개 - 스킬사용횟수가 3회 추가됩니다. [ 구매가격 : 코인 1개 ] \r\n\r\n");
            
        }

        private void btn_shop_item1_Click(object sender, EventArgs e)
        {
            if (ch.item[7] > 0) 
            {
                ch.item_gain(0, 3);
                ch.item[7]--;
                update();
                MessageBox.Show("회복물약 3개를 구매하였습니다.");
            }
            else if (ch.item[7] == 0)
            {
                update();
                MessageBox.Show("코인이 부족하여 아이템을 구매할 수 없습니다.");
            }
        }

        private void btn_shop_item2_Click(object sender, EventArgs e)
        {
            if (ch.item[7] > 0)
            {
                ch.item_gain(1, 1);
                ch.item[7]--;
                update();
                MessageBox.Show("대형회복물약 1개를 구매하였습니다.");
            }
            else if (ch.item[7] == 0)
            {
                update();
                MessageBox.Show("코인이 부족하여 아이템을 구매할 수 없습니다.");
            }
        }

        private void btn_shop_item3_Click(object sender, EventArgs e)
        {
            if (ch.item[7] > 0)
            {
                ch.item_gain(2, 1);
                ch.item[7]--;
                update();
                MessageBox.Show("스킬회복물약 1개를 구매하였습니다.");
            }
            else if (ch.item[7] == 0)
            {
                update();
                MessageBox.Show("코인이 부족하여 아이템을 구매할 수 없습니다.");
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("비밀 상점을 뒤로한 채 당신은 던전을 탐험하기로 결정했다. \r\n");
            this.Refresh();
            Thread.Sleep(2000);
            textBox1.AppendText("곧이어, 비밀 상점은 자욱한 연기에 가려져 흔적도 없이 사라졌다. \r\n");
            this.Refresh();
            Thread.Sleep(2000);
            btn_yes.Visible = false;
            btn_no.Visible = false;
            btn_attack.Visible = true;
            btn_defend.Visible = true;
            ch.secret_shop01 = 1;
            move_btn_able();
        }

        private void btn_shopout_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("비밀 상점에서 나온 당신은 다시 던전을 탐험하기로 결정했다. \r\n");
            this.Refresh();
            Thread.Sleep(2000);
            textBox1.AppendText("곧이어, 비밀 상점은 자욱한 연기에 가려져 흔적도 없이 사라졌다. \r\n");
            this.Refresh();
            Thread.Sleep(2000);
            btn_yes.Visible = false;
            btn_no.Visible = false;
            btn_shop_item1.Visible = false;
            btn_shop_item2.Visible = false;
            btn_shop_item3.Visible = false;
            btn_shopout.Visible = false;
            btn_attack.Visible = true;
            btn_defend.Visible = true;
            ch.secret_shop01 = 1;
            move_btn_able();
        }

        private void C_1_2_0_Load_1(object sender, EventArgs e)
        {

        }



        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    }
}
