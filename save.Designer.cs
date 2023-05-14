namespace WindowsFormsApp1
{
    partial class save
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.def = new System.Windows.Forms.Label();
            this.intel = new System.Windows.Forms.Label();
            this.spd = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chapter = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(28, 22);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 124);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "힘";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "민첩";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "지력";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "방어력";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "불러온다";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // def
            // 
            this.def.AutoSize = true;
            this.def.Location = new System.Drawing.Point(212, 136);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(0, 12);
            this.def.TabIndex = 12;
            // 
            // intel
            // 
            this.intel.AutoSize = true;
            this.intel.Location = new System.Drawing.Point(212, 113);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(0, 12);
            this.intel.TabIndex = 11;
            // 
            // spd
            // 
            this.spd.AutoSize = true;
            this.spd.Location = new System.Drawing.Point(212, 91);
            this.spd.Name = "spd";
            this.spd.Size = new System.Drawing.Size(0, 12);
            this.spd.TabIndex = 10;
            this.spd.Click += new System.EventHandler(this.label8_Click);
            // 
            // str
            // 
            this.str.AutoSize = true;
            this.str.Location = new System.Drawing.Point(212, 70);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(0, 12);
            this.str.TabIndex = 9;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(212, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 12);
            this.name.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "챕터";
            // 
            // chapter
            // 
            this.chapter.AutoSize = true;
            this.chapter.Location = new System.Drawing.Point(212, 12);
            this.chapter.Name = "chapter";
            this.chapter.Size = new System.Drawing.Size(0, 12);
            this.chapter.TabIndex = 14;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(212, 50);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(0, 12);
            this.level.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "레벨";
            // 
            // save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(306, 210);
            this.ControlBox = false;
            this.Controls.Add(this.level);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chapter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.def);
            this.Controls.Add(this.intel);
            this.Controls.Add(this.spd);
            this.Controls.Add(this.str);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "save";
            this.Load += new System.EventHandler(this.save_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label def;
        private System.Windows.Forms.Label intel;
        private System.Windows.Forms.Label spd;
        private System.Windows.Forms.Label str;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label chapter;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label label8;
    }
}