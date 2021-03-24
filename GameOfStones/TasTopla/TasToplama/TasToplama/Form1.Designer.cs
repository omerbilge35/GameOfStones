namespace TasToplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.G = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_wall_counter = new System.Windows.Forms.Label();
            this.lbl_player1_counter = new System.Windows.Forms.Label();
            this.lbl_player2_counter = new System.Windows.Forms.Label();
            this.lbl_target_counter = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_level1 = new System.Windows.Forms.RadioButton();
            this.rdb_level2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_singleplayer = new System.Windows.Forms.RadioButton();
            this.rdb_multiplayer = new System.Windows.Forms.RadioButton();
            this.btn_tasdiz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_whowin = new System.Windows.Forms.TextBox();
            this.btn_replay = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_target = new System.Windows.Forms.Button();
            this.btn_player1 = new System.Windows.Forms.Button();
            this.btn_player2 = new System.Windows.Forms.Button();
            this.btn_wall = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(10, 10);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(705, 705);
            this.G.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(752, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Target:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(752, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wall:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(752, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(752, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player 2:";
            // 
            // lbl_wall_counter
            // 
            this.lbl_wall_counter.AutoSize = true;
            this.lbl_wall_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_wall_counter.Location = new System.Drawing.Point(941, 393);
            this.lbl_wall_counter.Name = "lbl_wall_counter";
            this.lbl_wall_counter.Size = new System.Drawing.Size(0, 20);
            this.lbl_wall_counter.TabIndex = 14;
            // 
            // lbl_player1_counter
            // 
            this.lbl_player1_counter.AutoSize = true;
            this.lbl_player1_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_player1_counter.Location = new System.Drawing.Point(941, 471);
            this.lbl_player1_counter.Name = "lbl_player1_counter";
            this.lbl_player1_counter.Size = new System.Drawing.Size(0, 20);
            this.lbl_player1_counter.TabIndex = 15;
            // 
            // lbl_player2_counter
            // 
            this.lbl_player2_counter.AutoSize = true;
            this.lbl_player2_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_player2_counter.Location = new System.Drawing.Point(941, 550);
            this.lbl_player2_counter.Name = "lbl_player2_counter";
            this.lbl_player2_counter.Size = new System.Drawing.Size(0, 20);
            this.lbl_player2_counter.TabIndex = 16;
            // 
            // lbl_target_counter
            // 
            this.lbl_target_counter.AutoSize = true;
            this.lbl_target_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_target_counter.Location = new System.Drawing.Point(941, 317);
            this.lbl_target_counter.Name = "lbl_target_counter";
            this.lbl_target_counter.Size = new System.Drawing.Size(18, 20);
            this.lbl_target_counter.TabIndex = 18;
            this.lbl_target_counter.Text = "1";
            this.lbl_target_counter.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_level1);
            this.groupBox2.Controls.Add(this.rdb_level2);
            this.groupBox2.Location = new System.Drawing.Point(18, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Level:";
            // 
            // rdb_level1
            // 
            this.rdb_level1.AutoSize = true;
            this.rdb_level1.Checked = true;
            this.rdb_level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_level1.Location = new System.Drawing.Point(15, 19);
            this.rdb_level1.Name = "rdb_level1";
            this.rdb_level1.Size = new System.Drawing.Size(77, 24);
            this.rdb_level1.TabIndex = 12;
            this.rdb_level1.TabStop = true;
            this.rdb_level1.Text = "Level 1";
            this.rdb_level1.UseVisualStyleBackColor = true;
            // 
            // rdb_level2
            // 
            this.rdb_level2.AutoSize = true;
            this.rdb_level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_level2.Location = new System.Drawing.Point(150, 19);
            this.rdb_level2.Name = "rdb_level2";
            this.rdb_level2.Size = new System.Drawing.Size(77, 24);
            this.rdb_level2.TabIndex = 13;
            this.rdb_level2.Text = "Level 2";
            this.rdb_level2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_singleplayer);
            this.groupBox1.Controls.Add(this.rdb_multiplayer);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Mode:";
            // 
            // rdb_singleplayer
            // 
            this.rdb_singleplayer.AutoSize = true;
            this.rdb_singleplayer.Checked = true;
            this.rdb_singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_singleplayer.Location = new System.Drawing.Point(16, 30);
            this.rdb_singleplayer.Name = "rdb_singleplayer";
            this.rdb_singleplayer.Size = new System.Drawing.Size(118, 24);
            this.rdb_singleplayer.TabIndex = 10;
            this.rdb_singleplayer.TabStop = true;
            this.rdb_singleplayer.Text = "Single Player";
            this.rdb_singleplayer.UseVisualStyleBackColor = true;
            // 
            // rdb_multiplayer
            // 
            this.rdb_multiplayer.AutoSize = true;
            this.rdb_multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdb_multiplayer.Location = new System.Drawing.Point(151, 30);
            this.rdb_multiplayer.Name = "rdb_multiplayer";
            this.rdb_multiplayer.Size = new System.Drawing.Size(102, 24);
            this.rdb_multiplayer.TabIndex = 11;
            this.rdb_multiplayer.Text = "Multiplayer";
            this.rdb_multiplayer.UseVisualStyleBackColor = true;
            // 
            // btn_tasdiz
            // 
            this.btn_tasdiz.BackColor = System.Drawing.Color.OldLace;
            this.btn_tasdiz.Image = global::TasToplama.Properties.Resources.put;
            this.btn_tasdiz.Location = new System.Drawing.Point(117, 165);
            this.btn_tasdiz.Name = "btn_tasdiz";
            this.btn_tasdiz.Size = new System.Drawing.Size(114, 69);
            this.btn_tasdiz.TabIndex = 20;
            this.btn_tasdiz.UseVisualStyleBackColor = false;
            this.btn_tasdiz.Click += new System.EventHandler(this.btn_tasdiz_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_tasdiz);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(721, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 272);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(117, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Place Stones";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbl_whowin
            // 
            this.lbl_whowin.BackColor = System.Drawing.Color.Black;
            this.lbl_whowin.Enabled = false;
            this.lbl_whowin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_whowin.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_whowin.Location = new System.Drawing.Point(103, 730);
            this.lbl_whowin.Name = "lbl_whowin";
            this.lbl_whowin.Size = new System.Drawing.Size(863, 53);
            this.lbl_whowin.TabIndex = 22;
            this.lbl_whowin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_replay
            // 
            this.btn_replay.BackColor = System.Drawing.Color.OldLace;
            this.btn_replay.Image = global::TasToplama.Properties.Resources.replay;
            this.btn_replay.Location = new System.Drawing.Point(902, 635);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(123, 72);
            this.btn_replay.TabIndex = 19;
            this.btn_replay.UseVisualStyleBackColor = false;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.OldLace;
            this.btn_start.Enabled = false;
            this.btn_start.Image = global::TasToplama.Properties.Resources.play_button;
            this.btn_start.Location = new System.Drawing.Point(752, 635);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(123, 72);
            this.btn_start.TabIndex = 5;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_target
            // 
            this.btn_target.BackColor = System.Drawing.Color.OldLace;
            this.btn_target.Enabled = false;
            this.btn_target.Image = global::TasToplama.Properties.Resources.colored_checker;
            this.btn_target.Location = new System.Drawing.Point(838, 288);
            this.btn_target.Name = "btn_target";
            this.btn_target.Size = new System.Drawing.Size(75, 70);
            this.btn_target.TabIndex = 4;
            this.btn_target.UseVisualStyleBackColor = false;
            this.btn_target.Click += new System.EventHandler(this.btn_target_Click);
            // 
            // btn_player1
            // 
            this.btn_player1.BackColor = System.Drawing.Color.OldLace;
            this.btn_player1.Enabled = false;
            this.btn_player1.Image = global::TasToplama.Properties.Resources.blue_player;
            this.btn_player1.Location = new System.Drawing.Point(838, 441);
            this.btn_player1.Name = "btn_player1";
            this.btn_player1.Size = new System.Drawing.Size(75, 72);
            this.btn_player1.TabIndex = 3;
            this.btn_player1.UseVisualStyleBackColor = false;
            this.btn_player1.Click += new System.EventHandler(this.btn_player1_Click);
            // 
            // btn_player2
            // 
            this.btn_player2.BackColor = System.Drawing.Color.OldLace;
            this.btn_player2.Enabled = false;
            this.btn_player2.Image = global::TasToplama.Properties.Resources.brown_player;
            this.btn_player2.Location = new System.Drawing.Point(838, 520);
            this.btn_player2.Name = "btn_player2";
            this.btn_player2.Size = new System.Drawing.Size(75, 73);
            this.btn_player2.TabIndex = 2;
            this.btn_player2.UseVisualStyleBackColor = false;
            this.btn_player2.Click += new System.EventHandler(this.btn_player2_Click);
            // 
            // btn_wall
            // 
            this.btn_wall.BackColor = System.Drawing.Color.OldLace;
            this.btn_wall.Enabled = false;
            this.btn_wall.Image = global::TasToplama.Properties.Resources.wall;
            this.btn_wall.Location = new System.Drawing.Point(838, 364);
            this.btn_wall.Name = "btn_wall";
            this.btn_wall.Size = new System.Drawing.Size(75, 71);
            this.btn_wall.TabIndex = 1;
            this.btn_wall.UseVisualStyleBackColor = false;
            this.btn_wall.Click += new System.EventHandler(this.btn_wall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1074, 795);
            this.Controls.Add(this.lbl_whowin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.lbl_target_counter);
            this.Controls.Add(this.lbl_player2_counter);
            this.Controls.Add(this.lbl_player1_counter);
            this.Controls.Add(this.lbl_wall_counter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_target);
            this.Controls.Add(this.btn_player1);
            this.Controls.Add(this.btn_player2);
            this.Controls.Add(this.btn_wall);
            this.Controls.Add(this.G);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Stones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.Button btn_wall;
        private System.Windows.Forms.Button btn_player2;
        private System.Windows.Forms.Button btn_player1;
        private System.Windows.Forms.Button btn_target;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_wall_counter;
        private System.Windows.Forms.Label lbl_player1_counter;
        private System.Windows.Forms.Label lbl_player2_counter;
        private System.Windows.Forms.Label lbl_target_counter;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_level1;
        private System.Windows.Forms.RadioButton rdb_level2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_singleplayer;
        private System.Windows.Forms.RadioButton rdb_multiplayer;
        private System.Windows.Forms.Button btn_tasdiz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox lbl_whowin;
        private System.Windows.Forms.Label label5;
    }
}

