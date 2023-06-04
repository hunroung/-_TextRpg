using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NPC
    {
        public int skill_count_static=2; // revive 용

        public int exp = 0;
        public int defend = 10;//방어력
        public int damage = 10;//공격력
        public int gold = 15; // 드랍할 골드
        public int max_health = 100;
        public int real_health = 100;

        public int item_str = 0;
        public int item_intel = 0;
        public int item_spd = 0;
        public int item_def = 0;

        public int str = 5;
        public int intel = 5;
        public int spd = 5;
        public int def = 5;

        public int skill_count = 2; // 스킬 사용가능한 횟수
        public string name;
        public string skill_name;
        public Image img;
        public Image img_defend;
        public Image img_skill;
        public Image img_attack;
        public Image img_attacked;
        public Image img_dead;

        public int attack()
        {
            return damage+item_str;
        }

        public int defense(int dam)
        {
            dam = dam - (defend+item_def);
            if(dam<0)
            {
                dam = 0;
            }
            real_health -= dam;
            if (real_health <= 0)
            {
                real_health = 0;
                return 0;
            }
            return 1;
        }
        public int damaged(int dam)
        {
            real_health -= dam;
            if(real_health <= 0)
            {
                real_health = 0;
                return 0;
            }
            return 1;
        }

        virtual public int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "")
                {
                    skill_count--;
                    return 20;
                }
                
            }
            return 0;
        }
        public void item_clear()
        {
            item_str = 0;
            item_intel = 0;
            item_spd = 0;
            item_def = 0;
        }
        public void revive()
        {
            real_health = max_health;
            skill_count = skill_count_static;
        }

    }
    public class slime : NPC
    {
        public slime()
        {
            name = "슬라임";
            skill_name = "깨물기";
            img = Image.FromFile(".\\img\\slim.png");
            img_attack= Image.FromFile(".\\img\\slim_attack.png");
            img_defend= Image.FromFile(".\\img\\slim_defend.png");
            img_attacked=Image.FromFile(".\\img\\slim_attacked.png");
            img_skill= Image.FromFile(".\\img\\slim_skill.png");
            img_dead = Image.FromFile(".\\img\\slim_dead.png");
            max_health = 100;
            real_health = 100;
            defend = 10;
            damage = 10;
            
            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 80;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "깨물기")
                {
                    skill_count--;
                    return 20;
                }

            }
            return 0;
        }
    }

    public class Goblin : NPC
    {
        public Goblin()
        {
            name = "고블린";
            skill_name = "단검찌르기";
            img = Image.FromFile(".\\img\\goblin.png");
            img_attack = Image.FromFile(".\\img\\goblin_attack.png");
            img_defend = Image.FromFile(".\\img\\goblin_defend.png");
            img_attacked = Image.FromFile(".\\img\\goblin_attacked.png");
            img_skill = Image.FromFile(".\\img\\goblin_skill.png");
            img_dead = Image.FromFile(".\\img\\goblin_dead.png");
            max_health = 150;
            real_health = 150;
            defend = 5;
            damage = 20;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 120;
        }
        public override int skill(string skill_name)
        {
            
            if (skill_count > 0)
            {
                if (skill_name == "단검찌르기")
                {
                    skill_count--;
                    return 35;
                }

            }
            return 0;
        }
    }

    public class Ent : NPC
    {
        public Ent()
        {
            name = "고대 앤트";
            skill_name = "넝쿨 채찍";
            img = Image.FromFile(".\\img\\slim.png");
            img_attack = Image.FromFile(".\\img\\slim_attack.png");
            img_defend = Image.FromFile(".\\img\\slim_defend.png");
            img_attacked = Image.FromFile(".\\img\\slim_attacked.png");
            img_skill = Image.FromFile(".\\img\\slim_skill.png");
            img_dead = Image.FromFile(".\\img\\slim_dead.png");
            max_health = 300;
            real_health = 300;
            defend = 30;
            damage = 5;

            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 120;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "넝쿨 채찍")
                {
                    skill_count--;
                    return 35;
                }

            }
            return 0;
        }
    }
        public class red_slime : NPC
        {
            public red_slime()
            {
                name = "붉은 슬라임";
                skill_name = "가시 찌르기";
                img = Image.FromFile(".\\img\\red_slim.PNG");
                img_attack = Image.FromFile(".\\img\\red_slim_attack.PNG");
                img_defend = Image.FromFile(".\\img\\red_slim_defend.PNG");
                img_attacked = Image.FromFile(".\\img\\red_slim_attacked.PNG");
                img_skill = Image.FromFile(".\\img\\red_slim_skill.PNG");
                img_dead = Image.FromFile(".\\img\\red_slim_dead.PNG");
                max_health = 100;
                real_health = 100;
                defend = 12;
                damage = 12;

                skill_count_static = 3;
                skill_count = skill_count_static;
                exp = 100;
            }
            public override int skill(string skill_name)
            {
                if (skill_count > 0)
                {
                    if (skill_name == "가시 찌르기")
                    {
                        skill_count--;
                        return 15;
                    }

                }
                return 0;
            }
        }

        public class blue_shadow : NPC
        {
            public blue_shadow()
            {
                name = "푸른 그림자";
                skill_name = "투과";
                img = Image.FromFile(".\\img\\blue_shadow.PNG");
                img_attack = Image.FromFile(".\\img\\blue_shadow_attack.PNG");
                img_defend = Image.FromFile(".\\img\\blue_shadow_defend.PNG");
                img_attacked = Image.FromFile(".\\img\\blue_shadow_attacked.PNG");
                img_skill = Image.FromFile(".\\img\\blue_shadow_skill.PNG");
                img_dead = Image.FromFile(".\\img\\blue_shadow_dead.PNG");
                max_health = 200;
                real_health = 200;
                defend = 5;
                damage = 15;

                skill_count_static = 3;
                skill_count = skill_count_static;
                exp = 150;
            }
            public override int skill(string skill_name)
            {
                if (skill_count > 0)
                {
                    if (skill_name == "투과")
                    {
                        skill_count--;
                        return 20;
                    }

                }
                return 0;
            }
        }
    public class shark : NPC
    {
        public shark()
        {
            name = "해적상어";
            skill_name = "이빨물기";
            img = Image.FromFile(".\\img\\shark.png");
            img_attack = Image.FromFile(".\\img\\shark_attack.png");
            img_defend = Image.FromFile(".\\img\\shark_defend.png");
            img_attacked = Image.FromFile(".\\img\\shark_attacked.png");
            img_skill = Image.FromFile(".\\img\\shark_skill.png");
            img_dead = Image.FromFile(".\\img\\shark_dead.png");
            max_health = 200;
            real_health = 200;
            defend = 5;
            damage = 20;

            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 110;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "이빨물기")
                {
                    skill_count--;
                    return 30;
                }

            }
            return 0;
        }
    }

    public class eel : NPC
    {
        public eel()
        {
            name = "전기 뱀장어";
            skill_name = "100만 볼트";
            img = Image.FromFile(".\\img\\eel.png");
            img_attack = Image.FromFile(".\\img\\eel_attack.png");
            img_defend = Image.FromFile(".\\img\\eel_defend.png");
            img_attacked = Image.FromFile(".\\img\\eel_attacked.png");
            img_skill = Image.FromFile(".\\img\\eel_skill.png");
            img_dead = Image.FromFile(".\\img\\eel_dead.png");
            max_health = 70;
            real_health = 70;
            defend = 10;
            damage = 15;

            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 70;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "100만 볼트")
                {
                    skill_count--;
                    return 20;
                }

            }
            return 0;
        }
    }

    public class whale : NPC
    {
        public whale()
        {
            name = "매우 큰 고래";
            skill_name = "날아 오르기";
            img = Image.FromFile(".\\img\\whale.png");
            img_attack = Image.FromFile(".\\img\\whale_attack.png");
            img_defend = Image.FromFile(".\\img\\whale_defend.png");
            img_attacked = Image.FromFile(".\\img\\whale_attacked.png");
            img_skill = Image.FromFile(".\\img\\whale_skill.png");
            img_dead = Image.FromFile(".\\img\\whale_dead.png");
            max_health = 300;
            real_health = 300;
            defend = 30;
            damage = 5;

            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 100;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "날아 오르기")
                {
                    skill_count--;
                    return 30;
                }

            }
            return 0;
        }
    }
    public class  Mist_Fairy: NPC
    {
        public Mist_Fairy()
        {
            name = "안개 요정";
            skill_name = "안개 소용돌이";
            img = Image.FromFile(".\\img\\Mist_Fairy.PNG");
            img_attack = Image.FromFile(".\\img\\Mist_Fairy_attack.PNG");
            img_defend = Image.FromFile(".\\img\\Mist_Fairy_defend.PNG");
            img_attacked = Image.FromFile(".\\img\\Mist_Fairy_attacked.PNG");
            img_skill = Image.FromFile(".\\img\\Mist_Fairy_skill.PNG");
            img_dead = Image.FromFile(".\\img\\Mist_Fairy_dead.PNG");
            max_health = 150;
            real_health = 150;
            defend = 10;
            damage = 20;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 120;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "안개 소용돌이")
                {
                    skill_count--;
                    return 35;
                }

            }
            return 0;
        }
    }
    public class Crocodile_Spirit : NPC
    {
        public Crocodile_Spirit()
        {
            name = "악어 신령";
            skill_name = "비열한 이빨";
            img = Image.FromFile(".\\img\\Crocodile_Spirit.PNG");
            img_attack = Image.FromFile(".\\img\\Crocodile_Spirit_attack.PNG");
            img_defend = Image.FromFile(".\\img\\Crocodile_Spirit_defend.PNG");
            img_attacked = Image.FromFile(".\\img\\Crocodile_Spirit_attacked.PNG");
            img_skill = Image.FromFile(".\\img\\Crocodile_Spirit_skill.PNG");
            img_dead = Image.FromFile(".\\img\\Crocodile_Spirit_dead.PNG");
            max_health = 150;
            real_health = 150;
            defend = 20;
            damage = 30;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 120;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "비열한 이빨")
                {
                    skill_count--;
                    return 35;
                }

            }
            return 0;
        }
    }
    public class Turtle_God : NPC
    {
        public Turtle_God()
        {
            name = "거북 신선";
            skill_name = "심연의 저주";
            img = Image.FromFile(".\\img\\Turtle_God.PNG");
            img_attack = Image.FromFile(".\\img\\Turtle_God_attack.PNG");
            img_defend = Image.FromFile(".\\img\\Turtle_God_defend.PNG");
            img_attacked = Image.FromFile(".\\img\\Turtle_God_attacked.PNG");
            img_skill = Image.FromFile(".\\img\\Turtle_God_skill.PNG");
            img_dead = Image.FromFile(".\\img\\Turtle_God_dead.PNG");
            max_health = 150;
            real_health = 150;
            defend = 35;
            damage = 20;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 120;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "심연의 저주")
                {
                    skill_count--;
                    return 35;
                }

            }
            return 0;
        }
    }
    public class Little_Rabbit : NPC
    {
        public Little_Rabbit()
        {
            name = "작은 토끼";
            skill_name = "들이받기";
            img = Image.FromFile(".\\img\\Little_Rabbit.png");
            img_attack = Image.FromFile(".\\img\\Little_Rabbit_attack.png");
            img_defend = Image.FromFile(".\\img\\Little_Rabbit_defend.png");
            img_attacked = Image.FromFile(".\\img\\Little_Rabbit_attacked.png");
            img_skill = Image.FromFile(".\\img\\Little_Rabbit_skill.png");
            img_dead = Image.FromFile(".\\img\\Little_Rabbit_dead.png");
            max_health = 100;
            real_health = 100;
            defend = 10;
            damage = 15;

            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 100;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "들이받기")
                {
                    skill_count--;
                    return 15;
                }

            }
            return 0;
        }
    }
    public class MaxLv_Rabbit : NPC
    {
        public MaxLv_Rabbit()
        {
            name = "만렙토끼";
            skill_name = "레프트 훅";
            img = Image.FromFile(".\\img\\MaxLv_Rabbit.png");
            img_attack = Image.FromFile(".\\img\\MaxLv_Rabbit_attack.png");
            img_defend = Image.FromFile(".\\img\\MaxLv_Rabbit_defend.png");
            img_attacked = Image.FromFile(".\\img\\MaxLv_Rabbit_attacked.png");
            img_skill = Image.FromFile(".\\img\\MaxLv_Rabbit_skill.png");
            img_dead = Image.FromFile(".\\img\\MaxLv_Rabbit_dead.png");
            max_health = 300;
            real_health = 300;
            defend = 20;
            damage = 25;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 200;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "레프트 훅")
                {
                    skill_count--;
                    return 35;
                }

            }
            return 0;
        }
    }

    public class Fire_Guardian : NPC
    {
        public Fire_Guardian()
        {
            name = "불 수호자";
            skill_name = "방화";
            img = Image.FromFile(".\\img\\Fire_Guardian.png");
            img_attack = Image.FromFile(".\\img\\Fire_Guardian_attack.png");
            img_defend = Image.FromFile(".\\img\\Fire_Guardian_defend.png");
            img_attacked = Image.FromFile(".\\img\\Fire_Guardian_attacked.png");
            img_skill = Image.FromFile(".\\img\\Fire_Guardian_skill.png");
            img_dead = Image.FromFile(".\\img\\Fire_Guardian_dead.png");
            max_health = 250;
            real_health = 250;
            defend = 30;
            damage = 30;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 300;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "방화")
                {
                    skill_count--;
                    return 45;
                }

            }
            return 0;
        }
    }
    public class Temple_Assassin : NPC
    {
        public Temple_Assassin()
        {
            name = "사원의 암살자";
            skill_name = "사악한 비수";
            img = Image.FromFile(".\\img\\Temple_Assassin.png");
            img_attack = Image.FromFile(".\\img\\Temple_Assassin_attack.png");
            img_defend = Image.FromFile(".\\img\\Temple_Assassin_defend.png");
            img_attacked = Image.FromFile(".\\img\\Temple_Assassin_attacked.png");
            img_skill = Image.FromFile(".\\img\\Temple_Assassin_skill.png");
            img_dead = Image.FromFile(".\\img\\Temple_Assassin_dead.png");
            max_health = 200;
            real_health = 200;
            defend = 15;
            damage = 35;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 350;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "사악한 비수")
                {
                    skill_count--;
                    return 60;
                }

            }
            return 0;
        }
    }
    public class Temple_Knight : NPC
    {
        public Temple_Knight()
        {
            name = "사원의 기사";
            skill_name = "불 가르기";
            img = Image.FromFile(".\\img\\Temple_Knight.png");
            img_attack = Image.FromFile(".\\img\\Temple_Knight_attack.png");
            img_defend = Image.FromFile(".\\img\\Temple_Knight_defend.png");
            img_attacked = Image.FromFile(".\\img\\Temple_Knight_attacked.png");
            img_skill = Image.FromFile(".\\img\\Temple_Knight_skill.png");
            img_dead = Image.FromFile(".\\img\\Temple_Knight_dead.png");
            max_health = 300;
            real_health = 300;
            defend = 30;
            damage = 30;

            skill_count_static = 3;
            skill_count = skill_count_static;
            exp = 400;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "불 가르기")
                {
                    skill_count--;
                    return 45;
                }

            }
            return 0;
        }
    }
    public class ice_ghost : NPC
    {
        public ice_ghost()
        {
            name = "얼음 유령";
            skill_name = "고드름";
            img = Image.FromFile(".\\img\\red_slim.PNG");
            img_attack = Image.FromFile(".\\img\\red_slim_attack.PNG");
            img_defend = Image.FromFile(".\\img\\red_slim_defend.PNG");
            img_attacked = Image.FromFile(".\\img\\red_slim_attacked.PNG");
            img_skill = Image.FromFile(".\\img\\red_slim_skill.PNG");
            img_dead = Image.FromFile(".\\img\\red_slim_dead.PNG");
            max_health = 60;
            real_health = 60;
            defend = 10;
            damage = 20;

            skill_count_static = 2;
            skill_count = skill_count_static;
            exp = 150;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "고드름")
                {
                    skill_count--;
                    return 25;
                }

            }
            return 0;
        }
    }

    public class fire_ghost : NPC
    {
        public fire_ghost()
        {
            name = "화염 유령";
            skill_name = "파이어볼";
            img = Image.FromFile(".\\img\\red_slim.PNG");
            img_attack = Image.FromFile(".\\img\\red_slim_attack.PNG");
            img_defend = Image.FromFile(".\\img\\red_slim_defend.PNG");
            img_attacked = Image.FromFile(".\\img\\red_slim_attacked.PNG");
            img_skill = Image.FromFile(".\\img\\red_slim_skill.PNG");
            img_dead = Image.FromFile(".\\img\\red_slim_dead.PNG");
            max_health = 80;
            real_health = 80;
            defend = 5;
            damage = 25;

            skill_count_static = 1;
            skill_count = skill_count_static;
            exp = 200;
        }
        public override int skill(string skill_name)
        {
            if (skill_count > 0)
            {
                if (skill_name == "파이어볼")
                {
                    skill_count--;
                    return 40;
                }

            }
            return 0;
        }
    }

    public class Boss_Bear : NPC
    {
        public Boss_Bear()
        {
            name = "반달가슴 곰";
            skill_name = "곰은 사람을 찢어!!";
            img = Image.FromFile(".\\img\\Boss_Bear.png");
            img_attack = Image.FromFile(".\\img\\Boss_Bear_attack.png");
            img_defend = Image.FromFile(".\\img\\Boss_Bear_defend.png");
            img_attacked = Image.FromFile(".\\img\\Boss_Bear_attacked.png");
            img_skill = Image.FromFile(".\\img\\Boss_Bear_skill.png");
            img_dead = Image.FromFile(".\\img\\Boss_Bear_dead.png");
            max_health = 500;
            real_health = 500;
            defend = 40;
            damage = 20;

            skill_count_static = 4;
            skill_count = skill_count_static;
            exp = 500;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "곰은 사람을 찢어!!")
                {
                    skill_count--;
                    return 40;
                }

            }
            return 0;
        }
    }
    public class Boss_snake : NPC
    {
        public Boss_snake()
        {
            name = "천년묵은 이무기";
            skill_name = "이무기 브레스";
            img = Image.FromFile(".\\img\\Boss_snake.png");
            img_attack = Image.FromFile(".\\img\\Boss_snake_attack.png");
            img_defend = Image.FromFile(".\\img\\Boss_snake_defend.png");
            img_attacked = Image.FromFile(".\\img\\Boss_snake_attacked.png");
            img_skill = Image.FromFile(".\\img\\Boss_snake_skill.png");
            img_dead = Image.FromFile(".\\img\\Boss_snake_dead.png");
            max_health = 500;
            real_health = 500;
            defend = 40;
            damage = 20;

            skill_count_static = 10;
            skill_count = skill_count_static;
            exp = 500;
        }
        public override int skill(string skill_name)
        {

            if (skill_count > 0)
            {
                if (skill_name == "이무기 브레스")
                {
                    skill_count--;
                    return 40;
                }

            }
            return 0;
        }
    }
}
