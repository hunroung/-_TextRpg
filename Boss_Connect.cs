using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextRpg_packet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Boss_Connect : Form
    {
        public TcpClient m_client_;
        public NetworkStream m_stream_;
        public NPC boss_;
        int boss_type_;
        int chapter_;
        public Boss_Connect()
        {
            InitializeComponent();
        }
        public Boss_Connect(ref TcpClient m_client,ref NPC boss,ref NetworkStream m_stream,int boss_type, int chapter)
        {
            InitializeComponent();
            m_client_= m_client;
            m_stream_= m_stream;
            boss_ = boss;
            boss_type_ = boss_type;
            chapter_ = chapter;
        }
        public void select_boss(ref NPC boss,int a)
        {
            switch(chapter_)
            {
                case 1:
                    switch (a)
                    {
                        case 0:
                            boss = new Boss_Bear();
                            break;
                        case 1:
                            boss = new Boss_snake();
                            break;
                        case 2:
                            boss = new Goblin();
                            boss.name = "무자비한 고블린";
                            boss.real_health = 200;
                            boss.max_health = 200;
                            boss.skill_count_static = 20;
                            boss.skill_count = boss.skill_count_static;
                            break;
                    }
                    break;
                case 2:
                    switch (a)
                    {
                        case 0:
                            boss = new MaxLv_Rabbit();
                            boss.name = "초월한 토끼";
                            boss.real_health = 300;
                            boss.max_health = 300;
                            boss.skill_count_static = 20;
                            boss.skill_count = boss.skill_count_static;
                            break;
                        case 1:
                            boss = new Turtle_God();
                            boss.name = "신에 가까운 거북";
                            boss.real_health = 300;
                            boss.max_health = 300;
                            boss.skill_count_static = 20;
                            boss.skill_count = boss.skill_count_static;
                            break;
                    }
                    break;
                case 3:
                    switch (a)
                    {
                        case 0:
                            boss = new Poor_king();
                            boss.name = "각성한 왕초";
                            boss.real_health = 500;
                            boss.max_health = 500;
                            boss.skill_count_static = 20;
                            boss.skill_count = boss.skill_count_static;
                            break;
                        case 1:
                            boss = new Temple_Assassin();
                            boss.name = "정예 암살자";
                            boss.real_health = 500;
                            boss.max_health = 500;
                            boss.skill_count_static = 20;
                            boss.skill_count = boss.skill_count_static;
                            break;
                        case 2:
                            boss = new Temple_Knight();
                            boss.name = "정예 기사";
                            boss.real_health = 500;
                            boss.max_health = 500;
                            boss.skill_count_static = 20;
                            boss.skill_count = boss.skill_count_static;
                            break;
                    }
                    break;
            }
            
        }

        private void Boss_Connect_Load(object sender, EventArgs e)
        {
            bool b_try = true;

            while (b_try)
            {
                m_client_ = new TcpClient();
                try
                {
                    byte[] readBuffer = new byte[256];
                    byte[] sendBuffer = new byte[256];
                    m_client_.Connect("223.194.45.82", 32338);
                    b_try = false;
                    m_stream_ = m_client_.GetStream();
                    TextRpg_packet.Boss Boss_packet = new TextRpg_packet.Boss();
                    Boss_packet.Typee = (int)TextRpg_packet.Packet_Type.보스;
                    Boss_packet.value = boss_type_;
                    progressBar1.Value = 40;
                    Packet.Serialize(Boss_packet).CopyTo(sendBuffer, 0);

                    m_stream_.Write(sendBuffer, 0, sendBuffer.Length);
                    progressBar1.Value = 60;
                    m_stream_.Flush();
                    m_stream_.Read(readBuffer, 0, readBuffer.Length);
                    progressBar1.Value = 70;
                    Packet packet = (Packet)Packet.Desserialize(readBuffer);
                    if (packet.Typee == (int)TextRpg_packet.Packet_Type.보스)
                    {
                        progressBar1.Value = 80;
                        Boss_packet = (TextRpg_packet.Boss)Packet.Desserialize(readBuffer);
                        select_boss(ref boss_, Boss_packet.value);
                    }
                }
                catch
                {
                    Console.WriteLine("접속 실패");
                    if (MessageBox.Show("서버 연결 실패 재시도하시겠습니까?", "Connect Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        continue;
                    else
                    {
                        b_try = false;
                        Random rand = new Random();
                        int a = rand.Next(0, boss_type_);
                        select_boss(ref boss_, a);
                    }
                }
            }
            progressBar1.Value = 100;
            Boss b = new Boss(boss_,chapter_);
            b.ShowDialog();
            this.Close();
        }

        private void Boss_Connect_Load_1(object sender, EventArgs e)
        {

        }
    }
}
