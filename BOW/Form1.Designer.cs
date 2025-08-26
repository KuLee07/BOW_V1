
namespace BOW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Leader = new System.Windows.Forms.PictureBox();
            CityWall = new System.Windows.Forms.PictureBox();
            Enemy1 = new System.Windows.Forms.PictureBox();
            GameTitle = new System.Windows.Forms.Label();
            btnStartGame = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtCityWallHP = new System.Windows.Forms.Label();
            txtWAVE = new System.Windows.Forms.Label();
            Bow_1 = new System.Windows.Forms.PictureBox();
            Bow_2 = new System.Windows.Forms.PictureBox();
            Bow_3 = new System.Windows.Forms.PictureBox();
            Bow_6 = new System.Windows.Forms.PictureBox();
            Bow_5 = new System.Windows.Forms.PictureBox();
            Bow_4 = new System.Windows.Forms.PictureBox();
            Bow_10 = new System.Windows.Forms.PictureBox();
            Bow_9 = new System.Windows.Forms.PictureBox();
            Bow_8 = new System.Windows.Forms.PictureBox();
            Bow_7 = new System.Windows.Forms.PictureBox();
            Enemy2 = new System.Windows.Forms.PictureBox();
            Enemy3 = new System.Windows.Forms.PictureBox();
            Enemy4 = new System.Windows.Forms.PictureBox();
            Enemy5 = new System.Windows.Forms.PictureBox();
            Enemy6 = new System.Windows.Forms.PictureBox();
            Enemy7 = new System.Windows.Forms.PictureBox();
            Enemy8 = new System.Windows.Forms.PictureBox();
            Enemy9 = new System.Windows.Forms.PictureBox();
            Enemy10 = new System.Windows.Forms.PictureBox();
            EnemyAttackBar = new System.Windows.Forms.ProgressBar();
            txtFireReady = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Enemy11 = new System.Windows.Forms.PictureBox();
            Enemy12 = new System.Windows.Forms.PictureBox();
            Enemy13 = new System.Windows.Forms.PictureBox();
            Enemy14 = new System.Windows.Forms.PictureBox();
            Enemy15 = new System.Windows.Forms.PictureBox();
            TeachPanel = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            txtLeftEnemy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)Leader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CityWall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bow_7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy15).BeginInit();
            TeachPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Leader
            // 
            Leader.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            Leader.Location = new System.Drawing.Point(180, 382);
            Leader.Name = "Leader";
            Leader.Size = new System.Drawing.Size(20, 20);
            Leader.TabIndex = 0;
            Leader.TabStop = false;
            // 
            // CityWall
            // 
            CityWall.BackColor = System.Drawing.Color.Gray;
            CityWall.Location = new System.Drawing.Point(-23, 327);
            CityWall.Name = "CityWall";
            CityWall.Size = new System.Drawing.Size(530, 23);
            CityWall.TabIndex = 1;
            CityWall.TabStop = false;
            // 
            // Enemy1
            // 
            Enemy1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy1.Location = new System.Drawing.Point(576, 119);
            Enemy1.Name = "Enemy1";
            Enemy1.Size = new System.Drawing.Size(20, 20);
            Enemy1.TabIndex = 2;
            Enemy1.TabStop = false;
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 48F);
            GameTitle.Location = new System.Drawing.Point(59, 61);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new System.Drawing.Size(363, 102);
            GameTitle.TabIndex = 3;
            GameTitle.Text = "射箭遊戲";
            GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F);
            btnStartGame.Location = new System.Drawing.Point(147, 166);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new System.Drawing.Size(175, 63);
            btnStartGame.TabIndex = 4;
            btnStartGame.Text = "開始遊戲";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            pictureBox1.Location = new System.Drawing.Point(-7, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(496, 46);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtCityWallHP
            // 
            txtCityWallHP.AutoSize = true;
            txtCityWallHP.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            txtCityWallHP.Location = new System.Drawing.Point(363, 10);
            txtCityWallHP.Name = "txtCityWallHP";
            txtCityWallHP.Size = new System.Drawing.Size(113, 19);
            txtCityWallHP.TabIndex = 7;
            txtCityWallHP.Text = "城牆生命值 : 10";
            // 
            // txtWAVE
            // 
            txtWAVE.AutoSize = true;
            txtWAVE.BackColor = System.Drawing.SystemColors.Control;
            txtWAVE.Location = new System.Drawing.Point(378, 406);
            txtWAVE.Name = "txtWAVE";
            txtWAVE.Size = new System.Drawing.Size(72, 19);
            txtWAVE.TabIndex = 9;
            txtWAVE.Text = "WAVE : 1";
            // 
            // Bow_1
            // 
            Bow_1.BackColor = System.Drawing.Color.RosyBrown;
            Bow_1.Location = new System.Drawing.Point(644, 362);
            Bow_1.Name = "Bow_1";
            Bow_1.Size = new System.Drawing.Size(5, 50);
            Bow_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_1.TabIndex = 11;
            Bow_1.TabStop = false;
            // 
            // Bow_2
            // 
            Bow_2.BackColor = System.Drawing.Color.RosyBrown;
            Bow_2.Location = new System.Drawing.Point(671, 362);
            Bow_2.Name = "Bow_2";
            Bow_2.Size = new System.Drawing.Size(5, 50);
            Bow_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_2.TabIndex = 12;
            Bow_2.TabStop = false;
            // 
            // Bow_3
            // 
            Bow_3.BackColor = System.Drawing.Color.RosyBrown;
            Bow_3.Location = new System.Drawing.Point(698, 362);
            Bow_3.Name = "Bow_3";
            Bow_3.Size = new System.Drawing.Size(5, 50);
            Bow_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_3.TabIndex = 13;
            Bow_3.TabStop = false;
            // 
            // Bow_6
            // 
            Bow_6.BackColor = System.Drawing.Color.RosyBrown;
            Bow_6.Location = new System.Drawing.Point(781, 362);
            Bow_6.Name = "Bow_6";
            Bow_6.Size = new System.Drawing.Size(5, 50);
            Bow_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_6.TabIndex = 16;
            Bow_6.TabStop = false;
            // 
            // Bow_5
            // 
            Bow_5.BackColor = System.Drawing.Color.RosyBrown;
            Bow_5.Location = new System.Drawing.Point(754, 362);
            Bow_5.Name = "Bow_5";
            Bow_5.Size = new System.Drawing.Size(5, 50);
            Bow_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_5.TabIndex = 15;
            Bow_5.TabStop = false;
            // 
            // Bow_4
            // 
            Bow_4.BackColor = System.Drawing.Color.RosyBrown;
            Bow_4.Location = new System.Drawing.Point(727, 362);
            Bow_4.Name = "Bow_4";
            Bow_4.Size = new System.Drawing.Size(5, 50);
            Bow_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_4.TabIndex = 14;
            Bow_4.TabStop = false;
            // 
            // Bow_10
            // 
            Bow_10.BackColor = System.Drawing.Color.RosyBrown;
            Bow_10.Location = new System.Drawing.Point(727, 435);
            Bow_10.Name = "Bow_10";
            Bow_10.Size = new System.Drawing.Size(5, 50);
            Bow_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_10.TabIndex = 20;
            Bow_10.TabStop = false;
            // 
            // Bow_9
            // 
            Bow_9.BackColor = System.Drawing.Color.RosyBrown;
            Bow_9.Location = new System.Drawing.Point(700, 435);
            Bow_9.Name = "Bow_9";
            Bow_9.Size = new System.Drawing.Size(5, 50);
            Bow_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_9.TabIndex = 19;
            Bow_9.TabStop = false;
            // 
            // Bow_8
            // 
            Bow_8.BackColor = System.Drawing.Color.RosyBrown;
            Bow_8.Location = new System.Drawing.Point(673, 435);
            Bow_8.Name = "Bow_8";
            Bow_8.Size = new System.Drawing.Size(5, 50);
            Bow_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_8.TabIndex = 18;
            Bow_8.TabStop = false;
            // 
            // Bow_7
            // 
            Bow_7.BackColor = System.Drawing.Color.RosyBrown;
            Bow_7.Location = new System.Drawing.Point(644, 435);
            Bow_7.Name = "Bow_7";
            Bow_7.Size = new System.Drawing.Size(5, 50);
            Bow_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Bow_7.TabIndex = 17;
            Bow_7.TabStop = false;
            // 
            // Enemy2
            // 
            Enemy2.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy2.Location = new System.Drawing.Point(613, 119);
            Enemy2.Name = "Enemy2";
            Enemy2.Size = new System.Drawing.Size(20, 20);
            Enemy2.TabIndex = 21;
            Enemy2.TabStop = false;
            // 
            // Enemy3
            // 
            Enemy3.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy3.Location = new System.Drawing.Point(644, 119);
            Enemy3.Name = "Enemy3";
            Enemy3.Size = new System.Drawing.Size(20, 20);
            Enemy3.TabIndex = 22;
            Enemy3.TabStop = false;
            // 
            // Enemy4
            // 
            Enemy4.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy4.Location = new System.Drawing.Point(683, 119);
            Enemy4.Name = "Enemy4";
            Enemy4.Size = new System.Drawing.Size(20, 20);
            Enemy4.TabIndex = 23;
            Enemy4.TabStop = false;
            // 
            // Enemy5
            // 
            Enemy5.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy5.Location = new System.Drawing.Point(576, 157);
            Enemy5.Name = "Enemy5";
            Enemy5.Size = new System.Drawing.Size(20, 20);
            Enemy5.TabIndex = 24;
            Enemy5.TabStop = false;
            // 
            // Enemy6
            // 
            Enemy6.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy6.Location = new System.Drawing.Point(613, 157);
            Enemy6.Name = "Enemy6";
            Enemy6.Size = new System.Drawing.Size(20, 20);
            Enemy6.TabIndex = 25;
            Enemy6.TabStop = false;
            // 
            // Enemy7
            // 
            Enemy7.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy7.Location = new System.Drawing.Point(644, 157);
            Enemy7.Name = "Enemy7";
            Enemy7.Size = new System.Drawing.Size(20, 20);
            Enemy7.TabIndex = 26;
            Enemy7.TabStop = false;
            // 
            // Enemy8
            // 
            Enemy8.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy8.Location = new System.Drawing.Point(685, 157);
            Enemy8.Name = "Enemy8";
            Enemy8.Size = new System.Drawing.Size(20, 20);
            Enemy8.TabIndex = 27;
            Enemy8.TabStop = false;
            // 
            // Enemy9
            // 
            Enemy9.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy9.Location = new System.Drawing.Point(576, 196);
            Enemy9.Name = "Enemy9";
            Enemy9.Size = new System.Drawing.Size(20, 20);
            Enemy9.TabIndex = 28;
            Enemy9.TabStop = false;
            // 
            // Enemy10
            // 
            Enemy10.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy10.Location = new System.Drawing.Point(613, 196);
            Enemy10.Name = "Enemy10";
            Enemy10.Size = new System.Drawing.Size(20, 20);
            Enemy10.TabIndex = 29;
            Enemy10.TabStop = false;
            // 
            // EnemyAttackBar
            // 
            EnemyAttackBar.ForeColor = System.Drawing.Color.Red;
            EnemyAttackBar.Location = new System.Drawing.Point(147, 19);
            EnemyAttackBar.Name = "EnemyAttackBar";
            EnemyAttackBar.Size = new System.Drawing.Size(175, 19);
            EnemyAttackBar.TabIndex = 30;
            // 
            // txtFireReady
            // 
            txtFireReady.AutoSize = true;
            txtFireReady.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            txtFireReady.Location = new System.Drawing.Point(9, 10);
            txtFireReady.Name = "txtFireReady";
            txtFireReady.Size = new System.Drawing.Size(90, 19);
            txtFireReady.TabIndex = 31;
            txtFireReady.Text = "裝填 : 100%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            label1.Location = new System.Drawing.Point(205, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 19);
            label1.TabIndex = 32;
            label1.Text = "來襲指標";
            // 
            // Enemy11
            // 
            Enemy11.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy11.Location = new System.Drawing.Point(644, 196);
            Enemy11.Name = "Enemy11";
            Enemy11.Size = new System.Drawing.Size(20, 20);
            Enemy11.TabIndex = 33;
            Enemy11.TabStop = false;
            // 
            // Enemy12
            // 
            Enemy12.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy12.Location = new System.Drawing.Point(685, 196);
            Enemy12.Name = "Enemy12";
            Enemy12.Size = new System.Drawing.Size(20, 20);
            Enemy12.TabIndex = 34;
            Enemy12.TabStop = false;
            // 
            // Enemy13
            // 
            Enemy13.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy13.Location = new System.Drawing.Point(576, 235);
            Enemy13.Name = "Enemy13";
            Enemy13.Size = new System.Drawing.Size(20, 20);
            Enemy13.TabIndex = 35;
            Enemy13.TabStop = false;
            // 
            // Enemy14
            // 
            Enemy14.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy14.Location = new System.Drawing.Point(613, 235);
            Enemy14.Name = "Enemy14";
            Enemy14.Size = new System.Drawing.Size(20, 20);
            Enemy14.TabIndex = 36;
            Enemy14.TabStop = false;
            // 
            // Enemy15
            // 
            Enemy15.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            Enemy15.Location = new System.Drawing.Point(644, 235);
            Enemy15.Name = "Enemy15";
            Enemy15.Size = new System.Drawing.Size(20, 20);
            Enemy15.TabIndex = 37;
            Enemy15.TabStop = false;
            // 
            // TeachPanel
            // 
            TeachPanel.Controls.Add(label3);
            TeachPanel.Controls.Add(label2);
            TeachPanel.Controls.Add(button5);
            TeachPanel.Controls.Add(button4);
            TeachPanel.Controls.Add(button3);
            TeachPanel.Controls.Add(button2);
            TeachPanel.Controls.Add(button1);
            TeachPanel.Location = new System.Drawing.Point(15, 235);
            TeachPanel.Name = "TeachPanel";
            TeachPanel.Size = new System.Drawing.Size(455, 86);
            TeachPanel.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F);
            label3.Location = new System.Drawing.Point(227, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 36);
            label3.TabIndex = 6;
            label3.Text = "攻擊";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F);
            label2.Location = new System.Drawing.Point(8, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 36);
            label2.TabIndex = 5;
            label2.Text = "移動";
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new System.Drawing.Point(304, 30);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(148, 30);
            button5.TabIndex = 4;
            button5.Text = "SPACE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new System.Drawing.Point(157, 45);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(30, 30);
            button4.TabIndex = 3;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new System.Drawing.Point(85, 45);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(30, 30);
            button3.TabIndex = 2;
            button3.Text = "A";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(121, 45);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(30, 30);
            button2.TabIndex = 1;
            button2.Text = "S";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new System.Drawing.Point(121, 9);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 30);
            button1.TabIndex = 0;
            button1.Text = "W";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtLeftEnemy
            // 
            txtLeftEnemy.AutoSize = true;
            txtLeftEnemy.Location = new System.Drawing.Point(378, 425);
            txtLeftEnemy.Name = "txtLeftEnemy";
            txtLeftEnemy.Size = new System.Drawing.Size(89, 19);
            txtLeftEnemy.TabIndex = 39;
            txtLeftEnemy.Text = "剩餘敵人 : 2";
            // 
            // Form1
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(482, 453);
            Controls.Add(txtLeftEnemy);
            Controls.Add(TeachPanel);
            Controls.Add(EnemyAttackBar);
            Controls.Add(label1);
            Controls.Add(txtCityWallHP);
            Controls.Add(txtFireReady);
            Controls.Add(Bow_10);
            Controls.Add(Bow_9);
            Controls.Add(Bow_8);
            Controls.Add(Bow_7);
            Controls.Add(Bow_6);
            Controls.Add(Bow_5);
            Controls.Add(Bow_4);
            Controls.Add(Bow_3);
            Controls.Add(Bow_2);
            Controls.Add(Bow_1);
            Controls.Add(txtWAVE);
            Controls.Add(pictureBox1);
            Controls.Add(btnStartGame);
            Controls.Add(GameTitle);
            Controls.Add(CityWall);
            Controls.Add(Leader);
            Controls.Add(Enemy15);
            Controls.Add(Enemy14);
            Controls.Add(Enemy13);
            Controls.Add(Enemy12);
            Controls.Add(Enemy11);
            Controls.Add(Enemy10);
            Controls.Add(Enemy9);
            Controls.Add(Enemy8);
            Controls.Add(Enemy7);
            Controls.Add(Enemy6);
            Controls.Add(Enemy5);
            Controls.Add(Enemy4);
            Controls.Add(Enemy3);
            Controls.Add(Enemy2);
            Controls.Add(Enemy1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "射箭遊戲";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)Leader).EndInit();
            ((System.ComponentModel.ISupportInitialize)CityWall).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_10).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_9).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bow_7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy7).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy9).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy10).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy11).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy12).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy13).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy14).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy15).EndInit();
            TeachPanel.ResumeLayout(false);
            TeachPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Leader;
        private System.Windows.Forms.PictureBox CityWall;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCityWallHP;
        private System.Windows.Forms.Label txtWAVE;
        private System.Windows.Forms.PictureBox Bow_1;
        private System.Windows.Forms.PictureBox Bow_2;
        private System.Windows.Forms.PictureBox Bow_3;
        private System.Windows.Forms.PictureBox Bow_6;
        private System.Windows.Forms.PictureBox Bow_5;
        private System.Windows.Forms.PictureBox Bow_4;
        private System.Windows.Forms.PictureBox Bow_10;
        private System.Windows.Forms.PictureBox Bow_9;
        private System.Windows.Forms.PictureBox Bow_8;
        private System.Windows.Forms.PictureBox Bow_7;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.PictureBox Enemy4;
        private System.Windows.Forms.PictureBox Enemy5;
        private System.Windows.Forms.PictureBox Enemy6;
        private System.Windows.Forms.PictureBox Enemy7;
        private System.Windows.Forms.PictureBox Enemy8;
        private System.Windows.Forms.PictureBox Enemy9;
        private System.Windows.Forms.PictureBox Enemy10;
        private System.Windows.Forms.ProgressBar EnemyAttackBar;
        private System.Windows.Forms.Label txtFireReady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Enemy11;
        private System.Windows.Forms.PictureBox Enemy12;
        private System.Windows.Forms.PictureBox Enemy13;
        private System.Windows.Forms.PictureBox Enemy14;
        private System.Windows.Forms.PictureBox Enemy15;
        private System.Windows.Forms.Panel TeachPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtLeftEnemy;
    }
}

