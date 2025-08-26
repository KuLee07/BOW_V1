using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace BOW
{
    public partial class Form1 : Form
    {
        int LeaderSpeed = 3;//主角行進速度
        int LeaderHp = 70;//主角生命
        int LeaderMoney = 10;//主角金錢
        int BowSpeed = 10;//弓箭速度
        int BowReLoadSpeed = 20;//弓箭裝填速度
        int EnemySpeed = 1;//敵人速度
        int EnemyAttackSpeed = 50;//來襲速度:數字越大，來襲越慢
        int EnemyDie = 0;//敵人擊倒數
        //Wave1->2人,Wave2->4人,Wave3->6人,Wave4->8人,Wave5->10人
        //Wave6->11人,Wave7->12人,Wave8->13人,Wave9->14人,Wave10->15人

        int FPS = 16;//60Hz,約16.7秒左右
        bool IsGameStart = false;
        bool GamePause = false;//中途暫停
        string KeyDownSave = "";//保留使用者按下的按鈕
        int NowUseBow = 1;
        int NowUseEnemy = 1;

        DataTable LeaderData = new DataTable("主角資訊");
        DataTable WorldLocation = new DataTable("世界位置");
        string BowLocation;//弓箭實時位置，用字串速度比DataTable快
        Detection Detection = new Detection();
        Hashtable BowHT = new Hashtable();
        Hashtable EnemyHT = new Hashtable();
        Random Rd = new Random();
        Form2 Form2 = new Form2();

        delegate void ReNew(PictureBox Who, string Direction, int Speed);
        delegate void ReNew2();

        public Form1()
        {
            InitializeComponent();

            //世界位置初始化
            WorldLocation.Columns.Add("物體", typeof(string));
            WorldLocation.Columns.Add("特殊條件", typeof(string));
            WorldLocation.Columns.Add("X", typeof(int));
            WorldLocation.Columns.Add("Y", typeof(int));
            WorldLocation.Columns.Add("Width", typeof(int));
            WorldLocation.Columns.Add("Height", typeof(int));
            WorldLocation.Rows.Add("Wall","", 0, 0, this.Width-15, this.Height-45);//矯正視窗異常
            WorldLocation.Rows.Add(CityWall.Name, "", CityWall.Location.X, CityWall.Location.Y, CityWall.Size.Width, CityWall.Size.Height);
            WorldLocation.Rows.Add(Leader.Name, "", Leader.Location.X, Leader.Location.Y, Leader.Size.Width, Leader.Size.Height);

            //主角初始化
            LeaderData.Columns.Add("時間", typeof(DateTime));
            LeaderData.Columns.Add("生命", typeof(int));
            LeaderData.Columns.Add("金錢", typeof(int));
            LeaderData.Columns.Add("武器", typeof(string));
            LeaderData.Columns.Add("道具1", typeof(string));
            LeaderData.Columns.Add("道具2", typeof(string));
            LeaderData.Columns.Add("道具3", typeof(string));
            LeaderData.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            LeaderHp,
            LeaderMoney,
            "",
            "",
            "",
            "");

            //弓箭初始化
            BowHT.Add((int)1, Bow_1);
            BowHT.Add((int)2, Bow_2);
            BowHT.Add((int)3, Bow_3);
            BowHT.Add((int)4, Bow_4);
            BowHT.Add((int)5, Bow_5);
            BowHT.Add((int)6, Bow_6);
            BowHT.Add((int)7, Bow_7);
            BowHT.Add((int)8, Bow_8);
            BowHT.Add((int)9, Bow_9);
            BowHT.Add((int)10, Bow_10);

            //敵人初始化
            EnemyHT.Add(1, Enemy1);
            EnemyHT.Add(2, Enemy2);
            EnemyHT.Add(3, Enemy3);
            EnemyHT.Add(4, Enemy4);
            EnemyHT.Add(5, Enemy5);
            EnemyHT.Add(6, Enemy6);
            EnemyHT.Add(7, Enemy7);
            EnemyHT.Add(8, Enemy8);
            EnemyHT.Add(9, Enemy9);
            EnemyHT.Add(10, Enemy10);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(LeaderWalk);
            Task.Factory.StartNew(Enemy);
            Task.Factory.StartNew(EnemyAttactCount);
            Task.Factory.StartNew(BowNowLocationUpdate);
            IsGameStart = true;
            btnStartGame.Visible = false;
            GameTitle.Visible = false;
            TeachPanel.Visible = false;
            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsGameStart == false) return;
            if (e.KeyData == Keys.W && KeyDownSave.Contains("W") == false) KeyDownSave += "W";
            if (e.KeyData == Keys.S && KeyDownSave.Contains("S") == false) KeyDownSave += "S";
            if (e.KeyData == Keys.A && KeyDownSave.Contains("A") == false) KeyDownSave += "A";
            if (e.KeyData == Keys.D && KeyDownSave.Contains("D") == false) KeyDownSave += "D";
            if (e.KeyData == Keys.Space && KeyDownSave.Contains("空白鍵") == false && txtFireReady.Text.Contains("100"))
            {
                txtFireReady.Text = "裝填 : 0%";
                KeyDownSave += "空白鍵";
                Task.Factory.StartNew(LeaderFireCharge);
                Task.Factory.StartNew(FireReadyCount);
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsGameStart == false) return;
            if (e.KeyData == Keys.W) KeyDownSave = KeyDownSave.Replace("W", "");
            if (e.KeyData == Keys.S) KeyDownSave = KeyDownSave.Replace("S", "");
            if (e.KeyData == Keys.A) KeyDownSave = KeyDownSave.Replace("A", "");
            if (e.KeyData == Keys.D) KeyDownSave = KeyDownSave.Replace("D", "");
            if (e.KeyData == Keys.Space) KeyDownSave = KeyDownSave.Replace("空白鍵", "");
        }
        
        private void LeaderWalk()
        {
            ReNew Rx = WalkFunction;
            while (true)
            {
                if (GamePause == false)
                {
                    Thread.Sleep(FPS);
                    if (KeyDownSave.Contains("W")) Invoke(Rx, Leader, "W", LeaderSpeed);
                    if (KeyDownSave.Contains("S")) Invoke(Rx, Leader, "S", LeaderSpeed);
                    if (KeyDownSave.Contains("A")) Invoke(Rx, Leader, "A", LeaderSpeed);
                    if (KeyDownSave.Contains("D")) Invoke(Rx, Leader, "D", LeaderSpeed);
                }
            }
        }

        private void LeaderFireCharge()
        {
            ReNew Rx = WalkFunction;
            int TimeBox = 0;

            ReNew2 Rxx = BowCorrection;
            PictureBox TempPic = (PictureBox)BowHT[NowUseBow];
            Invoke(Rxx);
            while (TimeBox < 50)
            {
                if (GamePause == false)
                {
                    Thread.Sleep(FPS);
                    TimeBox++;//發射距離
                    Invoke(Rx, TempPic, "W", BowSpeed);
                }
            }
        }

        private void BowCorrection()
        {
            if (NowUseBow == 11) NowUseBow = 1;
            PictureBox TempPic = (PictureBox)BowHT[NowUseBow];
            
            int X = (Leader.Location.X + Leader.Width / 2) - TempPic.Width / 2;
            int Y = (Leader.Location.Y + Leader.Height / 2) - TempPic.Height / 2;
            TempPic.Location = new Point(X, Y);
            NowUseBow++;
            if (NowUseBow == 11) NowUseBow = 1;
        }

        private void WalkFunction(PictureBox Who, string Direction, int Speed)
        {
            if (Who.Name == "Leader")
            {
                for (int i = 0; i < Speed; i++)
                {
                    switch (Direction)
                    {
                        case "W":
                            if (Detection.LeaderDetection(Leader.Location.X, Leader.Location.Y - 1, Leader.Width, Leader.Height, WorldLocation) == false)
                            { return; }
                            Leader.Location = new Point(Leader.Location.X, Leader.Location.Y - 1);
                            LeaderData.Rows[0][0] = DateTime.Now.ToString("f");
                            LeaderData.Rows[0][1] = Leader.Location.X;
                            LeaderData.Rows[0][2] = Leader.Location.Y;

                            break;

                        case "S":
                            if (Detection.LeaderDetection(Leader.Location.X, Leader.Location.Y + 1, Leader.Width, Leader.Height, WorldLocation) == false)
                            { return; }
                            Leader.Location = new Point(Leader.Location.X, Leader.Location.Y + 1);
                            LeaderData.Rows[0][0] = DateTime.Now.ToString("f");
                            LeaderData.Rows[0][1] = Leader.Location.X;
                            LeaderData.Rows[0][2] = Leader.Location.Y;

                            break;

                        case "A":
                            if (Detection.LeaderDetection(Leader.Location.X - 1, Leader.Location.Y, Leader.Width, Leader.Height, WorldLocation) == false)
                            { return; }
                            Leader.Location = new Point(Leader.Location.X - 1, Leader.Location.Y);
                            LeaderData.Rows[0][0] = DateTime.Now.ToString("f");
                            LeaderData.Rows[0][1] = Leader.Location.X;
                            LeaderData.Rows[0][2] = Leader.Location.Y;

                            break;

                        case "D":
                            if (Detection.LeaderDetection(Leader.Location.X + 1, Leader.Location.Y, Leader.Width, Leader.Height, WorldLocation) == false)
                            { return; }
                            Leader.Location = new Point(Leader.Location.X + 1, Leader.Location.Y);
                            LeaderData.Rows[0][0] = DateTime.Now.ToString("f");
                            LeaderData.Rows[0][1] = Leader.Location.X;
                            LeaderData.Rows[0][2] = Leader.Location.Y;

                            break;
                    }
                }
            }
            else if(Who.Name.Contains("Bow"))
            {
                switch (Direction)
                {
                    case "W":
                        for(int i = 0;i < Speed; i++)
                        {
                            Who.Location = new Point(Who.Location.X, Who.Location.Y - 1);
                        }
                        break;
                }
            }
            else if(Who.Name.Contains("Enemy"))
            {
                switch (Direction)
                {

                    case "S":
                        for (int i = 0; i < Speed; i++)
                        {
                            Who.Location = new Point(Who.Location.X , Who.Location.Y+1);
                            if (Detection.BowToEnemyDetection(Who.Location.X, Who.Location.Y, Who.Width, Who.Height, BowLocation) == false)
                            {
                                Who.Location = new Point(650, 650);//移出視窗
                                EnemyDie++;
                                int TmpeLeftEnemy = Convert.ToInt32(txtLeftEnemy.Text.Replace("剩餘敵人 : ", ""));
                                txtLeftEnemy.Text = "剩餘敵人 : " + (TmpeLeftEnemy - 1).ToString();
                                EnemyWave();
                            }
                            else if (Detection.EnemyDetection(Who.Location.X, Who.Location.Y, Who.Width, Who.Height, WorldLocation) == false)
                            {
                                int TmpeCityWallHP = Convert.ToInt32(txtCityWallHP.Text.Replace("城牆生命值 : ", ""));
                                txtCityWallHP.Text = "城牆生命值 : " + (TmpeCityWallHP - 1).ToString();
                                Who.Location = new Point(650, 650);//移出視窗
                                if (TmpeCityWallHP - 1 == 0)
                                {
                                    GamePause = true;
                                    GameTitle.Text = "GAME\n  OVER";
                                    GameTitle.Visible = true;
                                }
                            }
                        }
                        break;

                    case "A":
                        for (int i = 0; i < Speed; i++)
                        {
                            Who.Location = new Point(Who.Location.X-1, Who.Location.Y);
                        }
                        break;

                    case "D":
                        for (int i = 0; i < Speed; i++)
                        {
                            Who.Location = new Point(Who.Location.X+1, Who.Location.Y);

                        }
                        break;
                }
            }
        }

        private void FireReadyCount()
        {
            ReNew2 Rx = FireReadyUpdate;
            int TempFireReady = 0;
            while (TempFireReady < 100)
            {
                Thread.Sleep(BowReLoadSpeed);
                Invoke(Rx);
                string Temptxt = txtFireReady.Text.Replace("裝填 : ", "").Replace("%", "");
                TempFireReady =Convert.ToInt32(Temptxt);
            }
        }

        private void FireReadyUpdate()
        {
            string Temptxt = txtFireReady.Text.Replace("裝填 : ", "").Replace("%", "");
            int TempFireReady = Convert.ToInt32(Temptxt);
            TempFireReady++;
            txtFireReady.Text = "裝填 : "+ TempFireReady + "%";
        }

        private void EnemyAttactCount()
        {
            ReNew2 Rx = EnemyAttackUpdate;
            while (true)
            {
                if (GamePause == false)
                {
                    Thread.Sleep(EnemyAttackSpeed);//控制來襲速度
                    Invoke(Rx);
                    if (EnemyAttackBar.Value == 100) Task.Factory.StartNew(Enemy);
                }
            }
        }

        private void EnemyAttackUpdate()
        {
            if (EnemyAttackBar.Value == 100) EnemyAttackBar.Value = 0;
            EnemyAttackBar.Value++;
        }

        private void Enemy()
        {
            ReNew Rx = WalkFunction;
            ReNew2 Rxx = EnemyCorrection;
            PictureBox TempPic = (PictureBox)EnemyHT[NowUseEnemy];
            Invoke(Rxx);
            while (true)
            {
                if (GamePause == false)
                {
                    Thread.Sleep(FPS);
                    Invoke(Rx, TempPic, "S", EnemySpeed);
                    if (TempPic.Location.X == 650) return;
                }
            }
        }

        private void EnemyCorrection()
        {
            PictureBox TempPic = (PictureBox)EnemyHT[NowUseEnemy];
            int First_X = Rd.Next(20, 450);
            TempPic.Location = new Point(First_X, -10);
            NowUseEnemy++;
            if (NowUseEnemy == 11) NowUseEnemy = 1;
        }

        //弓箭位置持續更新
        private void BowNowLocationUpdate()
        {
            for (int i = 1; i <= 10; i++)
            {
                PictureBox TempPic = (PictureBox)BowHT[i];
                string Bow_X = TempPic.Location.X.ToString();
                string Bow_Y = TempPic.Location.Y.ToString();
                string Bow_Width = TempPic.Width.ToString();
                string Bow_Height = TempPic.Height.ToString();
                if (i == 1) BowLocation = i.ToString()+","+Bow_X + "," + Bow_Y + "," + Bow_Width + "," + Bow_Height;
                else BowLocation += ";" + i.ToString() + "," + Bow_X + "," + Bow_Y + "," + Bow_Width + "," + Bow_Height;
            }
            
            while (true)
            {
                for (int i = 1; i <= 10; i++)
                {
                    PictureBox TempPic = (PictureBox)BowHT[i];
                    string Bow_X = TempPic.Location.X.ToString();
                    string Bow_Y = TempPic.Location.Y.ToString();
                    string Bow_Width = TempPic.Width.ToString();
                    string Bow_Height = TempPic.Height.ToString();
                    string Temp = BowLocation.Split(';')[i - 1];
                    BowLocation = BowLocation.Replace(Temp, i.ToString() + "," + Bow_X + "," + Bow_Y + "," + Bow_Width + "," + Bow_Height);
                }
            }
        }

        private void EnemyWave()
        {
            int i;
            switch (EnemyDie)
            {
                case 2:
                    UpdateFunction();
                    i = 2;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemyAttackSpeed = 30;
                    txtLeftEnemy.Text = "剩餘敵人 : 3";
                    break;

                case 5:
                    UpdateFunction();
                    i = 3;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemyAttackSpeed = 15;
                    txtLeftEnemy.Text = "剩餘敵人 : 4";
                    break;

                case 9:
                    UpdateFunction();
                    i = 4;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 4";
                    break;

                case 13:
                    UpdateFunction();
                    i = 5;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 4";
                    break;

                case 17:
                    UpdateFunction();
                    i = 6;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 5";
                    break;

                case 22:
                    UpdateFunction();
                    i = 7;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 6";
                    break;

                case 28:
                    UpdateFunction();
                    i = 8;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 7";
                    break;

                case 35:
                    UpdateFunction();
                    i = 9;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 8";
                    break;

                case 43:
                    UpdateFunction();
                    i = 10;
                    txtWAVE.Text = "WAVE : " + i.ToString();
                    EnemyAttackSpeed = 1;
                    EnemySpeed += 1;
                    txtLeftEnemy.Text = "剩餘敵人 : 9";
                    break;
                case 52:
                    GamePause = true;
                    GameTitle.Text = "GAME\n  PASS";
                    GameTitle.Visible = true;

                    break;
            }
        }
           
        private void UpdateFunction()
        {
            GamePause = true;
            Form2.ShowDialog();
            string TempWord = Form2.txtSendMsg.Text;
            if (TempWord == "移動速度")
            {
                LeaderSpeed += 2;
            }
            else if (TempWord == "城牆生命值")
            {
                int TmpeCityWallHP = Convert.ToInt32(txtCityWallHP.Text.Replace("城牆生命值 : ", ""));
                txtCityWallHP.Text = "城牆生命值 : " + (TmpeCityWallHP + 5).ToString();
            }
            else if (TempWord == "裝填速度")
            {
                BowReLoadSpeed -= 2;
            }
            KeyDownSave = "";//防止切回來後主角不受控制
            this.Focus();
            GamePause = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
