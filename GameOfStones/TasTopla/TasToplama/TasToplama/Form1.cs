using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n, x;
        int r = 0;
        int player1_win, player2_win;
        int[,] piece_num = new int[10, 10];

        PictureBox[,] P;

        int target_locx, target_locy;
        int distance_x, distance_y;

        int board_x1, board_y1;
        private void Form1_Load(object sender, EventArgs e)
        {
            n = 10;
            P = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };

            btn_target.Enabled = false;
            btn_wall.Enabled = false;
            btn_player1.Enabled = false;
            btn_player2.Enabled = false;

            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[0] = Color.Black; colors[1] = Color.White; }
                for (int j = 0; j < n; j++)
                {
                    P[j, i] = new PictureBox();
                    P[j, i].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[j, i].Location = new Point(left, top);
                    P[j, i].Size = new Size(70, 70);
                    left += 70;

                    P[j, i].Name = j + " " + i;

                    P[j, i].SizeMode = PictureBoxSizeMode.CenterImage;
                    P[j, i].MouseClick += (sender2, e2) =>
                    {
                        int board_x, board_y;
                        
                        PictureBox p = sender2 as PictureBox;
                        if (r == 1)
                        {

                            if (p.Image != null)
                            {
                                
                                board_x = Calculator(p.Location.X);
                                board_y = Calculator(p.Location.Y);
                                if (P[board_x, board_y].Name == "player1" || P[board_x, board_y].Name == "player2")
                                {
                                    board_x1 = board_x;
                                    board_y1 = board_y;

                                    Cleaner();
                                   if (board_x > 0)
                                    {
                                        if (P[board_x - 1, board_y].Image == null)
                                        {
                                            P[board_x - 1, board_y].Image = Properties.Resources.selection;
                                            P[board_x - 1, board_y].Name = "selector";
                                        }

                                        else if (P[board_x - 1, board_y].Name == "target")
                                        {
                                            P[board_x - 1, board_y].Name = "target2";
                                        }
                                    }
                                       
                                   if (board_x < 9)
                                    {
                                        if (P[board_x + 1, board_y].Image == null)
                                        {
                                            P[board_x + 1, board_y].Image = Properties.Resources.selection;
                                            P[board_x + 1, board_y].Name = "selector";
                                        }

                                        else if (P[board_x + 1, board_y].Name == "target")
                                        {
                                            P[board_x + 1, board_y].Name = "target2";
                                        }
                                    }
                                    
                                   if ( board_y > 0)
                                    {
                                        if (P[board_x, board_y - 1].Image == null)
                                        {
                                            P[board_x, board_y - 1].Image = Properties.Resources.selection;
                                            P[board_x, board_y - 1].Name = "selector";
                                        }

                                        else if (P[board_x, board_y - 1].Name == "target")
                                        {
                                            P[board_x, board_y - 1].Name = "target2";
                                        }
                                    }
                                    
                                   if (board_y < 9 )
                                    {
                                        if (P[board_x, board_y + 1].Image == null)
                                        {
                                            P[board_x, board_y + 1].Image = Properties.Resources.selection;
                                            P[board_x, board_y + 1].Name = "selector";
                                        }

                                        else if (P[board_x, board_y + 1].Name == "target")
                                        {
                                            P[board_x, board_y + 1].Name = "target2";
                                        }
                                    }
                                }

                                if (p.Name == "selector")
                                {
                                    board_x = Calculator(p.Location.X);
                                    board_y = Calculator(p.Location.Y);
                                    P[board_x, board_y].Name = P[board_x1, board_y1].Name;
                                    P[board_x1, board_y1].Name = board_x1 + " " + board_y1;
                                    if (P[board_x, board_y].Name == "player1")
                                    {
                                        p.Image = Properties.Resources.blue_player;
                                        P[board_x1, board_y1].Image = null;

                                        Distance_Printer(board_x1, board_y1, p);
                                    }
                                    else if (P[board_x, board_y].Name == "player2")
                                    {
                                        p.Image = Properties.Resources.brown_player;
                                        P[board_x1, board_y1].Image = null;

                                        Distance_Printer(board_x1, board_y1, p);
                                    }
                                    Cleaner();

                                }
                                else if (p.Name == "target2")
                                {
                                    board_x = Calculator(p.Location.X);
                                    board_y = Calculator(p.Location.Y);

                                    if (P[board_x1, board_y1].Name == "player1")
                                    {
                                        player1_win--;
                                        if (player1_win == 0)
                                        {
                                            lbl_whowin.Text = " Player 1 WON! CONGRATULATIONS! ";
                                            timer1.Enabled = true;
                                            btn_start.Enabled = false;
                                            G.Enabled = false;
                                        }
                                    }

                                    else if (P[board_x1, board_y1].Name == "player2")
                                    {
                                        player2_win--;
                                        if (player2_win == 0)
                                        {
                                            lbl_whowin.Text = " Player 2 WON! CONGRATULATIONS! ";
                                            timer1.Enabled = true;
                                            btn_start.Enabled = false;
                                            G.Enabled = false;

                                        }
                                    }

                                    P[board_x1, board_y1].Name = board_x1 + " " + board_y1;
                                    P[board_x1, board_y1].Image = null;
                                    p.Name = "target";
                                    Cleaner();
                                }

                            }          
                        }
                        else
                        {
                            if (p.Image == null)
                            {
                                int c;

                                switch (x)
                                {
                                    case 1:

                                        if (Convert.ToInt32(lbl_target_counter.Text) > 0)
                                        {

                                            c = Convert.ToInt32(lbl_target_counter.Text);
                                            c--;
                                            if (c == 0)
                                            {
                                                btn_target.Enabled = false;
                                                btn_wall.Enabled = true;
                                            }
                                            lbl_target_counter.Text = Convert.ToString(c);

                                            board_x = Calculator(p.Location.X);
                                            board_y = Calculator(p.Location.Y);
                                            P[board_x, board_y].Name = "target";

                                            p.Image = Properties.Resources.colored_checker;

                                            target_locx = p.Location.X;
                                            target_locy = p.Location.Y;
                                        }
                                        break;

                                    case 2:

                                        if (Convert.ToInt32(lbl_wall_counter.Text) > 0)
                                        {

                                            c = Convert.ToInt32(lbl_wall_counter.Text);
                                            c--;
                                            if (c == 0)
                                            {
                                                btn_wall.Enabled = false;                                            
                                                btn_player1.Enabled = true;
                                            }
                                            lbl_wall_counter.Text = Convert.ToString(c);

                                            board_x = Calculator(p.Location.X);
                                            board_y = Calculator(p.Location.Y);
                                            P[board_x, board_y].Name = "wall";

                                            p.Image = Properties.Resources.wall;

                                        }
                                        break;

                                    case 3:

                                        if (Convert.ToInt32(lbl_player1_counter.Text) > 0)
                                        {

                                            c = Convert.ToInt32(lbl_player1_counter.Text);
                                            c--;
                                            if (c == 0)
                                            {
                                                btn_player1.Enabled = false;
                                                btn_player2.Enabled = true;
                                                if (rdb_multiplayer.Checked == true)
                                                {
                                                    btn_start.Enabled = false;                                  
                                                }
                                                else
                                                {
                                                    btn_start.Enabled = true;
                                                }
                                            }
                                            lbl_player1_counter.Text = Convert.ToString(c);

                                            board_x = Calculator(p.Location.X);
                                            board_y = Calculator(p.Location.Y);
                                            P[board_x, board_y].Name = "player1";

                                            p.Image = Properties.Resources.blue_player;
                                            p.Paint += new PaintEventHandler((sender3, e3) =>
                                            {
                                                distance_x = p.Location.X - target_locx;
                                                distance_y = p.Location.Y - target_locy;
                                                piece_num[board_x, board_y] = distance_calculator(distance_x, distance_y);

                                                string text = Convert.ToString(distance_calculator(distance_x, distance_y));

                                                SizeF textSize = e3.Graphics.MeasureString(text, Font);
                                                PointF locationToDraw = new PointF();
                                                locationToDraw.X = (p.Width / 2) - (textSize.Width / 2);
                                                locationToDraw.Y = (p.Height / 2) - (textSize.Height / 2);

                                                e3.Graphics.DrawString(text, Font, Brushes.Red, locationToDraw);
                                                
                                            });
                                        }
                                        break;

                                    case 4:

                                        if (Convert.ToInt32(lbl_player2_counter.Text) > 0)
                                        {

                                            c = Convert.ToInt32(lbl_player2_counter.Text);
                                            c--;
                                            if (c == 0)
                                            {
                                                btn_player2.Enabled = false;
                                                btn_start.Enabled = true;
                                            }
                                            lbl_player2_counter.Text = Convert.ToString(c);

                                            board_x = Calculator(p.Location.X);
                                            board_y = Calculator(p.Location.Y);
                                            P[board_x, board_y].Name = "player2";

                                            p.Image = Properties.Resources.brown_player;
                                            p.Paint += new PaintEventHandler((sender4, e4) =>
                                            {
                                                distance_x = p.Location.X - target_locx;
                                                distance_y = p.Location.Y - target_locy;

                                                piece_num[board_x, board_y] = distance_calculator(distance_x, distance_y);

                                                string text = Convert.ToString(distance_calculator(distance_x, distance_y));

                                                SizeF textSize = e4.Graphics.MeasureString(text, Font);
                                                PointF locationToDraw = new PointF();
                                                locationToDraw.X = (p.Width / 2) - (textSize.Width / 2);
                                                locationToDraw.Y = (p.Height / 2) - (textSize.Height / 2);

                                                e4.Graphics.DrawString(text, Font, Brushes.Red, locationToDraw);
                                            });

                                        }

                                        break;


                                }
                            }
                        }
                    };

                    G.Controls.Add(P[j, i]);
                }
                top += 70;
            }
        }

        public int distance_calculator(int h, int p)
        {
            if (h < 0)
            {
                h = h * -1;
            }
            if (p < 0)
            {
                p = p * -1;
            }
            return (p + h) / 70;
        }

        private int Calculator(int x)
        {
            x = x - 2;
            if (x == 0)
            {
                return 0;
            }
            else
                return x / 70;
        }

        public void Cleaner()
        {
            int x1, y1;

            for(x1 = 0; x1 < 10; x1++ )
            {
                for(y1 = 0; y1 < 10; y1++)
                {
                    if(P[x1 , y1].Name == "selector")
                    {
                        P[x1, y1].Image = null;
                    }
                    if ( P[x1, y1].Name == "target2")
                     {
                        P[x1, y1].Name = "target";
                     }
                }
            }
        }

        /*
        private void Distance_Cleaner (int x , int y)
        {
            P[x, y].Paint += new PaintEventHandler((sender3, e3) =>
             {
                 string text = null;

                 SizeF textSize = e3.Graphics.MeasureString(text, Font);
                 PointF locationToDraw = new PointF();
                 locationToDraw.X = (P[x, y].Width / 2) - (textSize.Width / 2);
                 locationToDraw.Y = (P[x, y].Height / 2) - (textSize.Height / 2);

                 e3.Graphics.DrawString(text, Font, Brushes.Red, locationToDraw);

             });
        }
        */

        private void Distance_Printer(int x, int y, PictureBox p)
        {
            p.Paint += new PaintEventHandler((sender3, e3) =>
            {


                string text = Convert.ToString(piece_num[x, y] - 1);
                piece_num[Calculator(p.Location.X), Calculator(p.Location.Y)] = piece_num[x, y] - 1;
                if (piece_num[Calculator(p.Location.X), Calculator(p.Location.Y)] == 0)
                {
                    if (P[Calculator(p.Location.X), Calculator(p.Location.Y)].Name == "player1")
                    {
                        lbl_whowin.Text = " Player 1 Lost. GAME OVER! Press Restart! ";
                        timer1.Enabled = true;
                        btn_start.Enabled = false;
                        G.Enabled = false;                
                    }
                    else if (P[Calculator(p.Location.X), Calculator(p.Location.Y)].Name == "player2")
                    {
                        lbl_whowin.Text = " Player 2 Lost. GAME OVER! Press Restart! ";
                        timer1.Enabled = true;
                        btn_start.Enabled = false;
                        G.Enabled = false;
                    }
                }

                SizeF textSize = e3.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (p.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (p.Height / 2) - (textSize.Height / 2);

                e3.Graphics.DrawString(text, Font, Brushes.Red, locationToDraw);
            });

        }


            private void btn_target_Click(object sender, EventArgs e)
        {
            x = 1;
        }

        private void btn_wall_Click(object sender, EventArgs e)
        {
            x = 2;
        }

        private void btn_player1_Click(object sender, EventArgs e)
        {
            x = 3; 
        }

        private void btn_player2_Click(object sender, EventArgs e)
        {
            x = 4;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_whowin.Text = lbl_whowin.Text.Substring(1) + lbl_whowin.Text.Substring(0, 1);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            r = 1;
            btn_start.Enabled = false;
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Restart();
        }

        private void btn_tasdiz_Click(object sender, EventArgs e)
        {
            if (rdb_singleplayer.Checked == true)
            {
                label4.Visible = false;
                btn_player2.Visible = false;
                lbl_player2_counter.Visible = false;

               btn_target.Enabled = true;
                groupBox3.Enabled = false;
            }

            if (rdb_multiplayer.Checked == true)
            {
                label4.Visible = true;
                btn_player2.Visible = true;
                lbl_player2_counter.Visible = true;

                btn_target.Enabled = true;
                groupBox3.Enabled = false;
            }

            if(rdb_level1.Checked == true)
            {
                lbl_player1_counter.Text = "6";
                lbl_player2_counter.Text = "6";
                lbl_wall_counter.Text = "3";
                player1_win = 6;
                player2_win = 6;
            }
            if(rdb_level2.Checked == true)
            {
                lbl_player1_counter.Text = "7";
                lbl_player2_counter.Text = "7";
                lbl_wall_counter.Text = "4";
                player1_win = 7;
                player2_win = 7;
            }
            lbl_target_counter.Visible = true;
        }
    }
}
