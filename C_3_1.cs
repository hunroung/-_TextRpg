using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class C_3_1 : Form
    {
        public C_3_1()
        {
            InitializeComponent();
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
        private void C_3_1_Load(object sender, EventArgs e)
        {
            move_btn_enable();
            textBox1.AppendText ( "회랑을 따라 걷던 당신은 저편의 어둠 속에서 붉게 빛나는 안광을 발견한다.\r\n");
            this.Refresh();
            Delay(2000);
            textBox1.AppendText ( "어둠 속에서 사제의 복장을 한 사람이 걸어나온다.\r\n");
            this.Refresh();
            Delay(2000);
            textBox1.AppendText ( "영원의 불을 지키는 사제는 그 소임을 다하기 위해 당신을 가로막는다.\r\n");

            this.Refresh();
            Delay(2000);
            monster = new Fire_Guardian();
            fight = 1;
            setting(ch);
            picture_npc.Image = monster.img;
            textBox1.AppendText ( npc_name.Text + " (이)가 나왔다! \r\n");

            item_btn_able(ch);
            act_btn_able();

        }
        public int visit = 0;
        public character ch;
        public int fight = 0;
        public NPC monster = new NPC();
        //public slime slime = new slime();
        private void btn_close_Click(object sender, EventArgs e)
        {
            ch.close = 1;
            this.Close();
        }
        public C_3_1(ref character character)
        {


            //string name = "슬라임";
            //slime.name = name;
            ch = character;

            InitializeComponent();


            setting(character);
            item_btn_enable();
            act_btn_enable();
            picture_main.Image = character.main;
        }

        //폼 로딩시 세팅 단계
        public void setting(character character)
        {
            //따로 추가
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
            Delay(100);
            setting(ch);
            Delay(100);
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
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void btn_right_move_Click(object sender, EventArgs e)
        {
            C_3_2 form = new C_3_2(ref ch);
            this.Hide();
            form.ShowDialog();

            if (ch.real_health <= 0 || ch.close == 1)
            {
                this.Close();
            }
            this.Show();
            update();
            this.Refresh();
        }

        private void btn_attack_Click(object sender, EventArgs e)
        {
            move_btn_enable();
            act_btn_enable();
            item_btn_enable();
            Random rand = new Random();
            int k = rand.Next(3);
            if (k == 1)
            {
                if (monster.defense(ch.attack()) == 1)//변경 필요
                {
                    picture_main.Image = ch.main_attack;
                    picture_npc.Image = monster.img_defend;//변경 필요
                    textBox1.AppendText ( npc_name.Text + "이 방어를 선택했다\r\n");

                }
                else
                {
                    ch.skill_re();
                    ch.exp_gain(monster.exp);//변경 필요
                    ch.item_gain(0, 3);//변경 필요
                    textBox1.AppendText ( npc_name.Text + "이 죽었다. exp : " + monster.exp.ToString() + " 획득, 회복 포션 3개 획득\r\n");
                    picture_npc.Image = monster.img_dead;
                    picture_main.Image = ch.main_attack;

                }
            }

            else if (monster.damaged(ch.attack()) == 1)//변경 필요
            {
                picture_main.Image = ch.main_attack;
                picture_npc.Image = monster.img_attacked;//변경 필요
                update();
                this.Refresh();
                switch (k)
                {
                    case 0://슬라임도 공격을 선택한 경우

                        textBox1.AppendText ( npc_name.Text + "이 공격을 선택했다\r\n");

                        if (ch.damaged(monster.attack()) != 1)// 슬라임 공격으로 사망 //변경 필요
                        {
                            picture_main.Image = ch.main_attacked;
                            picture_npc.Image = monster.img_attack;//변경 필요
                            textBox1.AppendText ( "당신은 죽었다\r\n");
                            picture_npc.Image = monster.img;//변경 필요

                        }
                        else
                        {
                            picture_main.Image = ch.main_attacked;
                            picture_npc.Image = monster.img_attack;//변경 필요
                        }
                        break;
                    case 2: //슬라임이 스킬을 사용한 경우

                        int temp = monster.skill(monster.skill_name);//변경 필요

                        if (temp == 0)
                        {
                            textBox1.AppendText ( npc_name.Text + "이 스킬을 사용에 실패했다\r\n");
                        }
                        else if (ch.damaged(temp) != 1)//변경 필요
                        {
                            textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                            picture_main.Image = ch.main_dead;
                            picture_npc.Image = monster.img_skill;//변경 필요
                            update();
                            this.Refresh();

                            textBox1.AppendText ( "당신은 죽었다\r\n");
                            picture_npc.Image = monster.img;//변경 필요
                        }
                        else
                        {
                            textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                            picture_main.Image = ch.main_attacked;
                            picture_npc.Image = monster.img_skill;//변경 필요

                        }
                        break;

                }

            }
            else
            {
                ch.skill_re();
                ch.exp_gain(monster.exp);//변경 필요
                ch.item_gain(0, 3);//변경 필요
                textBox1.AppendText ( npc_name.Text + "이 죽었다. exp : " + monster.exp.ToString() + " 획득, 회복 포션 3개 획득\r\n");//변경 필요
                picture_npc.Image = monster.img_dead;//변경 필요
                picture_main.Image = ch.main_attack;

            }
            update();
            this.Refresh();
            if (ch.real_health <= 0)
            {
                MessageBox.Show("당신은 " + npc_name.Text + "에 패배하였습니다.");
                this.Close();
            }
            if (monster.real_health > 0)//변경 필요
            {
                picture_main.Image = ch.main;
                picture_npc.Image = monster.img;//변경 필요
                item_btn_able(ch);
                act_btn_able();
            }
            else
            {
                picture_main.Image = ch.main;
                picture_npc.Image = monster.img_dead;//변경 필요
                //btn_up_move.Text = "다시 싸운다";
                move_btn_able();
            }
            monster.item_clear();//변경 필요
            ch.item_clear();
            update();

        }


        private void btn_skill_Click(object sender, EventArgs e)
        {
            if (ch.skill_point <= 0)
            {
                MessageBox.Show("스킬포인트가 부족합니다.");
            }
            else if (cmb_skill.SelectedIndex >= 0 && cmb_skill.Items[cmb_skill.SelectedIndex].ToString() != "")
            {
                move_btn_enable();
                act_btn_enable();
                item_btn_enable();
                Random rand = new Random();
                int k = rand.Next(3);

                if (k == 1)
                {
                    if (monster.defense(ch.skill_use(cmb_skill.Items[cmb_skill.SelectedIndex].ToString())) == 1)//변경 필요
                    {
                        picture_main.Image = ch.main_skill;
                        picture_npc.Image = monster.img_defend;//변경 필요
                        textBox1.AppendText ( npc_name.Text + "이 방어를 선택했다\r\n");

                    }
                    else
                    {
                        ch.skill_re();
                        picture_main.Image = ch.main_skill;
                        ch.exp_gain(monster.exp);//변경 필요
                        //ch.item_gain(0, 3);//변경 필요
                        textBox1.AppendText ( npc_name.Text + "이 죽었다. exp : " + monster.exp.ToString() + " 획득\r\n");//변경 필요
                        picture_npc.Image = monster.img_dead;//변경 필요

                    }
                }

                else if (monster.damaged(ch.skill_use(cmb_skill.Items[cmb_skill.SelectedIndex].ToString())) == 1)//변경 필요
                {
                    picture_main.Image = ch.main_skill;
                    picture_npc.Image = monster.img_attacked;//변경 필요
                    update();
                    this.Refresh();
                    switch (k)
                    {
                        case 0://슬라임도 공격을 선택한 경우

                            textBox1.AppendText ( npc_name.Text + "이 공격을 선택했다\r\n");

                            if (ch.damaged(monster.attack()) != 1)// 슬라임 공격으로 사망 //변경 필요
                            {
                                picture_main.Image = ch.main_dead;
                                picture_npc.Image = monster.img_attack;//변경 필요
                                textBox1.AppendText ( "당신은 죽었다\r\n");
                                picture_npc.Image = monster.img;//변경 필요

                            }
                            else
                            {
                                picture_npc.Image = monster.img_attack;//변경 필요
                                picture_main.Image = ch.main_attacked;
                            }
                            break;
                        case 2: //슬라임이 스킬을 사용한 경우

                            int temp = monster.skill(monster.skill_name);//변경 필요

                            if (temp == 0)
                            {
                                textBox1.AppendText ( npc_name.Text + "이 스킬을 사용에 실패했다\r\n");
                            }
                            else if (ch.damaged(temp) != 1)
                            {
                                textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                                picture_main.Image = ch.main_dead;
                                picture_npc.Image = monster.img_skill;//변경 필요
                                update();
                                this.Refresh();

                                textBox1.AppendText ( "당신은 죽었다\r\n");
                                picture_npc.Image = monster.img;//변경 필요

                            }
                            else
                            {
                                textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                                picture_npc.Image = monster.img_skill;//변경 필요
                                picture_main.Image = ch.main_attacked;

                            }
                            break;

                    }
                }
                else
                {
                    ch.skill_re();
                    picture_main.Image = ch.main_skill;
                    ch.exp_gain(monster.exp);//변경 필요
                    //ch.item_gain(0, 3);//변경 필요
                    textBox1.AppendText ( npc_name.Text + "이 죽었다. exp : " + monster.exp.ToString() + " 획득\r\n");
                    picture_npc.Image = monster.img_dead;//변경 필요

                }
                update();
                this.Refresh();
                if (ch.real_health <= 0)
                {
                    MessageBox.Show("당신은 " + npc_name.Text + "에 패배하였습니다.");
                    this.Close();
                }
                if (monster.real_health > 0)//변경 필요
                {
                    picture_main.Image = ch.main;
                    picture_npc.Image = monster.img;//변경 필요
                    item_btn_able(ch);
                    act_btn_able();
                }
                else
                {
                    picture_main.Image = ch.main;
                    picture_npc.Image = monster.img_dead;//변경 필요
                    //btn_up_move.Text = "다시 싸운다";
                    move_btn_able();
                }
                monster.item_clear();//변경 필요
                ch.item_clear();
                update();

            }
        }

        private void btn_defend_Click(object sender, EventArgs e)
        {
            move_btn_enable();
            act_btn_enable();
            item_btn_enable();
            Random rand = new Random();
            int k = rand.Next(3);
            switch (k)
            {
                case 0://슬라임이 공격을 선택한 경우

                    textBox1.AppendText ( npc_name.Text + "이 공격을 선택했다\r\n");

                    if (ch.defense(monster.attack()) != 1)// 슬라임 공격으로 사망 //변경 필요
                    {
                        picture_main.Image = ch.main_dead;
                        picture_npc.Image = monster.img_attack;//변경 필요
                        textBox1.AppendText ( "당신은 죽었다\r\n");
                        picture_npc.Image = monster.img;//변경 필요

                    }
                    else
                    {
                        picture_npc.Image = monster.img_attack;//변경 필요
                        picture_main.Image = ch.main_defend;
                    }
                    break;
                case 1://서로 방어한 경우
                    textBox1.AppendText ( npc_name.Text + "이 방어를 선택했다\r\n");
                    picture_main.Image = ch.main_defend;
                    picture_npc.Image = monster.img_defend;//변경 필요
                    break;
                case 2: //슬라임이 스킬을 사용한 경우

                    int temp = monster.skill(monster.skill_name);//변경 필요

                    if (temp == 0)
                    {
                        picture_main.Image = ch.main_defend;
                        textBox1.AppendText ( npc_name.Text + "이 스킬을 사용에 실패했다\r\n");
                    }
                    else if (ch.defense(temp) != 1)
                    {
                        textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                        picture_main.Image = ch.main_defend;
                        picture_npc.Image = monster.img_skill;//변경 필요
                        update();
                        this.Refresh();

                        textBox1.AppendText ( "당신은 죽었다\r\n");
                        picture_npc.Image = monster.img;//변경 필요
                        picture_main.Image = ch.main_dead;
                    }
                    else
                    {
                        textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                        picture_npc.Image = monster.img_skill;//변경 필요
                        picture_main.Image = ch.main_defend;

                    }
                    break;

            }
            update();
            this.Refresh();
            if (ch.real_health <= 0)
            {
                MessageBox.Show("당신은 " + npc_name.Text + "에 패배하였습니다.");
                this.Close();
            }
            if (monster.real_health > 0)//변경 필요
            {
                picture_main.Image = ch.main;
                picture_npc.Image = monster.img;//변경 필요
                item_btn_able(ch);
                act_btn_able();
            }
            else
            {
                picture_main.Image = ch.main;
                picture_npc.Image = monster.img_dead;//변경 필요
                //btn_up_move.Text = "다시 싸운다";
                move_btn_able();
            }
            monster.item_clear();//변경 필요
            ch.item_clear();
            update();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            move_btn_enable();
            act_btn_enable();
            item_btn_enable();
            if (ch.spd > monster.spd)
            {
                Random rand = new Random();
                int k = rand.Next(10);
                if (k > 2)
                {
                    ch.skill_re();
                    textBox1.AppendText ( "당신은 도망쳤다.\r\n");
                    this.Close();
                }
                else
                {
                    textBox1.AppendText ( "당신은 도망치려 했으나 실패했다.\r\n");
                    k = rand.Next(2);
                    switch (k)
                    {
                        case 0://슬라임이 공격을 선택한 경우

                            textBox1.AppendText ( npc_name.Text + "이 공격을 선택했다\r\n");

                            if (ch.damaged(monster.attack()) != 1)// 슬라임 공격으로 사망 //변경 필요
                            {
                                picture_main.Image = ch.main_dead;
                                picture_npc.Image = monster.img_attack;//변경 필요
                                textBox1.AppendText ( "당신은 죽었다\r\n");
                                picture_npc.Image = monster.img;//변경 필요

                            }
                            else
                            {
                                picture_npc.Image = monster.img_attack;//변경 필요
                                picture_main.Image = ch.main_attacked;
                            }
                            break;
                        case 1: //슬라임이 스킬을 사용한 경우

                            int temp = monster.skill(monster.skill_name);//변경 필요

                            if (temp == 0)
                            {
                                textBox1.AppendText ( npc_name.Text + "이 스킬을 사용에 실패했다\r\n");
                            }
                            else if (ch.damaged(temp) != 1)
                            {
                                textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                                picture_main.Image = ch.main_dead;
                                picture_npc.Image = monster.img_skill;//변경 필요
                                update();
                                this.Refresh();

                                textBox1.AppendText ( "당신은 죽었다\r\n");
                                picture_npc.Image = monster.img;//변경 필요

                            }
                            else
                            {
                                textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                                picture_npc.Image = monster.img_skill;//변경 필요
                                picture_main.Image = ch.main_attacked;

                            }
                            break;

                    }
                    update();
                    this.Refresh();
                    if (ch.real_health <= 0)
                    {
                        MessageBox.Show("당신은 " + npc_name.Text + "에 패배하였습니다.");
                        this.Close();
                    }
                    if (monster.real_health > 0)//변경 필요
                    {
                        picture_main.Image = ch.main;
                        picture_npc.Image = monster.img;//변경 필요
                        item_btn_able(ch);
                        act_btn_able();
                    }
                    else
                    {
                        picture_main.Image = ch.main;
                        picture_npc.Image = monster.img_dead;//변경 필요
                        //btn_up_move.Text = "다시 싸운다";
                        move_btn_able();
                    }
                    monster.item_clear();//변경 필요
                    ch.item_clear();
                    update();
                }
            }
            else
            {
                Random rand = new Random();
                int k = rand.Next(3);
                textBox1.AppendText ( "당신은 너무 느려 도망칠 수 없다.\r\n");
                switch (k)
                {
                    case 0://슬라임이 공격을 선택한 경우

                        textBox1.AppendText ( npc_name.Text + "이 공격을 선택했다\r\n");

                        if (ch.damaged(monster.attack()) != 1)// 슬라임 공격으로 사망 //변경 필요
                        {
                            picture_main.Image = ch.main_dead;
                            picture_npc.Image = monster.img_attack;//변경 필요
                            textBox1.AppendText ( "당신은 죽었다\r\n");
                            picture_npc.Image = monster.img;//변경 필요

                        }
                        else
                        {
                            picture_npc.Image = monster.img_attack;//변경 필요
                            picture_main.Image = ch.main_attacked;
                        }
                        break;
                    case 2: //슬라임이 스킬을 사용한 경우

                        int temp = monster.skill(monster.skill_name);//변경 필요

                        if (temp == 0)
                        {
                            textBox1.AppendText ( npc_name.Text + "이 스킬을 사용에 실패했다\r\n");
                        }
                        else if (ch.damaged(temp) != 1)
                        {
                            textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                            picture_main.Image = ch.main_dead;
                            picture_npc.Image = monster.img_skill;//변경 필요
                            update();
                            this.Refresh();

                            textBox1.AppendText ( "당신은 죽었다\r\n");
                            picture_npc.Image = monster.img;//변경 필요

                        }
                        else
                        {
                            textBox1.AppendText ( npc_name.Text + "이(가) " + monster.skill_name + " 스킬을 사용했다\r\n");
                            picture_npc.Image = monster.img_skill;//변경 필요
                            picture_main.Image = ch.main_attacked;

                        }
                        break;

                }
                update();
                this.Refresh();
                if (ch.real_health <= 0)
                {
                    MessageBox.Show("당신은 " + npc_name.Text + "에 패배하였습니다.");
                    this.Close();

                }
                if (monster.real_health > 0)//변경 필요
                {
                    picture_main.Image = ch.main;
                    picture_npc.Image = monster.img;//변경 필요
                    item_btn_able(ch);
                    act_btn_able();
                }
                else
                {
                    picture_main.Image = ch.main;
                    picture_npc.Image = monster.img_dead;//변경 필요
                    //btn_travel.Text = "다시 싸운다";
                    move_btn_able();
                }
                monster.item_clear();//변경 필요
                ch.item_clear();
                update();
            }
        }
        private void btn_left_move_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ch.save();
        }


        private void btn_up_move_Click(object sender, EventArgs e)
        {
            /*
            C_3_1_0 form = new C_3_1_0(ref ch);
            this.Hide();
            form.ShowDialog();

            if (ch.real_health <= 0 || ch.close == 1)
            {
                this.Close();
            }
            this.Show();
            update();
            this.Refresh();
            */
        }

        private void C_2_1_Shown(object sender, EventArgs e)
        {

        }

        private void C_2_1_Load_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (monster.real_health <= 0)//변경 필요
            {
                picture_npc.Image = monster.img;//변경 필요
                monster.real_health = monster.max_health;//변경 필요
                monster.revive();//변경 필요
                textBox1.Text = "또 다른 " + npc_name.Text + "이 나타났다.\r\n";
                setting(ch);
                move_btn_enable();
                item_btn_able(ch);
                act_btn_able();

            }
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
            Button button = (Button)sender;
            switch (button.Name.ToString())
            {
                case "btn_item_1":
                    ch.item_use(0);
                    break;
                case "btn_item_2":
                    ch.item_use(1);
                    break;
                case "btn_item_3":
                    ch.item_use(2);
                    break;
                case "btn_item_4":
                    ch.item_use(3);
                    break;
                case "btn_item_5":
                    ch.item_use(4);
                    break;
                case "btn_item_6":
                    ch.item_use(5);
                    break;
                case "btn_item_7":
                    ch.item_use(6);
                    break;
                case "btn_item_8":
                    ch.item_use(7);
                    break;
                default:
                    break;
            }
            update();
        }

        private void C_3_1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
