namespace WindowsFormsApp1
{
    partial class End
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.point = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.picture_main = new System.Windows.Forms.PictureBox();
            this.picture_npc = new System.Windows.Forms.PictureBox();
            this.btn_skill = new System.Windows.Forms.Button();
            this.btn_defend = new System.Windows.Forms.Button();
            this.btn_attack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_def = new System.Windows.Forms.Button();
            this.btn_spd = new System.Windows.Forms.Button();
            this.btn_intel = new System.Windows.Forms.Button();
            this.btn_str = new System.Windows.Forms.Button();
            this.def = new System.Windows.Forms.Label();
            this.spd = new System.Windows.Forms.Label();
            this.intel = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.Label();
            this.leb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.npc_health = new System.Windows.Forms.Label();
            this.cmb_skill = new System.Windows.Forms.ComboBox();
            this.npc_name = new System.Windows.Forms.Label();
            this.real_health = new System.Windows.Forms.Label();
            this.체력 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_npc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Location = new System.Drawing.Point(136, 61);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(11, 12);
            this.point.TabIndex = 9;
            this.point.Text = "0";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(897, 0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 23);
            this.btn_save.TabIndex = 182;
            this.btn_save.Text = "저장하기";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(971, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 23);
            this.btn_close.TabIndex = 181;
            this.btn_close.Text = "종료하기";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // picture_main
            // 
            this.picture_main.BackColor = System.Drawing.SystemColors.Control;
            this.picture_main.Location = new System.Drawing.Point(14, 66);
            this.picture_main.Name = "picture_main";
            this.picture_main.Size = new System.Drawing.Size(150, 176);
            this.picture_main.TabIndex = 154;
            this.picture_main.TabStop = false;
            // 
            // picture_npc
            // 
            this.picture_npc.BackColor = System.Drawing.Color.Transparent;
            this.picture_npc.Location = new System.Drawing.Point(881, 45);
            this.picture_npc.Name = "picture_npc";
            this.picture_npc.Size = new System.Drawing.Size(150, 176);
            this.picture_npc.TabIndex = 156;
            this.picture_npc.TabStop = false;
            // 
            // btn_skill
            // 
            this.btn_skill.Location = new System.Drawing.Point(974, 335);
            this.btn_skill.Name = "btn_skill";
            this.btn_skill.Size = new System.Drawing.Size(65, 23);
            this.btn_skill.TabIndex = 165;
            this.btn_skill.Text = "스킬사용";
            this.btn_skill.UseVisualStyleBackColor = true;
            // 
            // btn_defend
            // 
            this.btn_defend.Location = new System.Drawing.Point(889, 302);
            this.btn_defend.Name = "btn_defend";
            this.btn_defend.Size = new System.Drawing.Size(150, 23);
            this.btn_defend.TabIndex = 164;
            this.btn_defend.Text = "방어한다";
            this.btn_defend.UseVisualStyleBackColor = true;
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(889, 270);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(150, 23);
            this.btn_attack.TabIndex = 163;
            this.btn_attack.Text = "기본 공격한다";
            this.btn_attack.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.point);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_def);
            this.groupBox2.Controls.Add(this.btn_spd);
            this.groupBox2.Controls.Add(this.btn_intel);
            this.groupBox2.Controls.Add(this.btn_str);
            this.groupBox2.Controls.Add(this.def);
            this.groupBox2.Controls.Add(this.spd);
            this.groupBox2.Controls.Add(this.intel);
            this.groupBox2.Controls.Add(this.str);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 117);
            this.groupBox2.TabIndex = 162;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "스텟";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "포인트";
            // 
            // btn_def
            // 
            this.btn_def.Location = new System.Drawing.Point(86, 88);
            this.btn_def.Name = "btn_def";
            this.btn_def.Size = new System.Drawing.Size(29, 16);
            this.btn_def.TabIndex = 19;
            this.btn_def.Text = "^";
            this.btn_def.UseVisualStyleBackColor = true;
            // 
            // btn_spd
            // 
            this.btn_spd.Location = new System.Drawing.Point(86, 64);
            this.btn_spd.Name = "btn_spd";
            this.btn_spd.Size = new System.Drawing.Size(29, 16);
            this.btn_spd.TabIndex = 18;
            this.btn_spd.Text = "^";
            this.btn_spd.UseVisualStyleBackColor = true;
            // 
            // btn_intel
            // 
            this.btn_intel.Location = new System.Drawing.Point(86, 39);
            this.btn_intel.Name = "btn_intel";
            this.btn_intel.Size = new System.Drawing.Size(29, 16);
            this.btn_intel.TabIndex = 17;
            this.btn_intel.Text = "^";
            this.btn_intel.UseVisualStyleBackColor = true;
            // 
            // btn_str
            // 
            this.btn_str.Location = new System.Drawing.Point(86, 15);
            this.btn_str.Name = "btn_str";
            this.btn_str.Size = new System.Drawing.Size(29, 16);
            this.btn_str.TabIndex = 16;
            this.btn_str.Text = "^";
            this.btn_str.UseVisualStyleBackColor = true;
            // 
            // def
            // 
            this.def.AutoSize = true;
            this.def.Location = new System.Drawing.Point(69, 90);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(11, 12);
            this.def.TabIndex = 15;
            this.def.Text = "5";
            // 
            // spd
            // 
            this.spd.AutoSize = true;
            this.spd.Location = new System.Drawing.Point(69, 66);
            this.spd.Name = "spd";
            this.spd.Size = new System.Drawing.Size(11, 12);
            this.spd.TabIndex = 14;
            this.spd.Text = "5";
            // 
            // intel
            // 
            this.intel.AutoSize = true;
            this.intel.Location = new System.Drawing.Point(69, 41);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(11, 12);
            this.intel.TabIndex = 13;
            this.intel.Text = "5";
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(69, 17);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(11, 12);
            this.str.TabIndex = 12;
            this.str.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "방어력";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "민첩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "지력";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "힘";
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Location = new System.Drawing.Point(66, 245);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(21, 12);
            this.exp.TabIndex = 159;
            this.exp.Text = "0%";
            // 
            // leb
            // 
            this.leb.AutoSize = true;
            this.leb.Location = new System.Drawing.Point(135, 245);
            this.leb.Name = "leb";
            this.leb.Size = new System.Drawing.Size(11, 12);
            this.leb.TabIndex = 161;
            this.leb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 160;
            this.label3.Text = "레벨";
            // 
            // npc_health
            // 
            this.npc_health.AutoSize = true;
            this.npc_health.Location = new System.Drawing.Point(969, 248);
            this.npc_health.Name = "npc_health";
            this.npc_health.Size = new System.Drawing.Size(23, 12);
            this.npc_health.TabIndex = 173;
            this.npc_health.Text = "100";
            // 
            // cmb_skill
            // 
            this.cmb_skill.FormattingEnabled = true;
            this.cmb_skill.Location = new System.Drawing.Point(889, 336);
            this.cmb_skill.Name = "cmb_skill";
            this.cmb_skill.Size = new System.Drawing.Size(79, 20);
            this.cmb_skill.TabIndex = 172;
            // 
            // npc_name
            // 
            this.npc_name.AutoSize = true;
            this.npc_name.Location = new System.Drawing.Point(939, 48);
            this.npc_name.Name = "npc_name";
            this.npc_name.Size = new System.Drawing.Size(0, 12);
            this.npc_name.TabIndex = 171;
            // 
            // real_health
            // 
            this.real_health.AutoSize = true;
            this.real_health.Location = new System.Drawing.Point(83, 22);
            this.real_health.Name = "real_health";
            this.real_health.Size = new System.Drawing.Size(23, 12);
            this.real_health.TabIndex = 169;
            this.real_health.Text = "100";
            // 
            // 체력
            // 
            this.체력.AutoSize = true;
            this.체력.Location = new System.Drawing.Point(8, 22);
            this.체력.Name = "체력";
            this.체력.Size = new System.Drawing.Size(29, 12);
            this.체력.TabIndex = 168;
            this.체력.Text = "체력";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(895, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 174;
            this.label17.Text = "체력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 158;
            this.label1.Text = "경험치";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 167;
            this.name.Text = "이름";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(187, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(679, 559);
            this.textBox1.TabIndex = 183;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(201, 182);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(647, 410);
            this.pictureBox12.TabIndex = 185;
            this.pictureBox12.TabStop = false;
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1049, 616);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.picture_main);
            this.Controls.Add(this.picture_npc);
            this.Controls.Add(this.btn_skill);
            this.Controls.Add(this.btn_defend);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.leb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.npc_health);
            this.Controls.Add(this.cmb_skill);
            this.Controls.Add(this.npc_name);
            this.Controls.Add(this.real_health);
            this.Controls.Add(this.체력);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End";
            this.Load += new System.EventHandler(this.End_Load_1);
            this.Shown += new System.EventHandler(this.End_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_npc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox picture_main;
        private System.Windows.Forms.PictureBox picture_npc;
        private System.Windows.Forms.Button btn_skill;
        private System.Windows.Forms.Button btn_defend;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_def;
        private System.Windows.Forms.Button btn_spd;
        private System.Windows.Forms.Button btn_intel;
        private System.Windows.Forms.Button btn_str;
        private System.Windows.Forms.Label def;
        private System.Windows.Forms.Label spd;
        private System.Windows.Forms.Label intel;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Label leb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label npc_health;
        private System.Windows.Forms.ComboBox cmb_skill;
        private System.Windows.Forms.Label npc_name;
        private System.Windows.Forms.Label real_health;
        private System.Windows.Forms.Label 체력;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}