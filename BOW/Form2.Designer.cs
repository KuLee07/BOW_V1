
namespace BOW
{
    partial class Form2
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
            this.btnAddSpeed = new System.Windows.Forms.Button();
            this.btnAddCityWallHP = new System.Windows.Forms.Button();
            this.BtnAddReLoadSpeed = new System.Windows.Forms.Button();
            this.txtSendMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSpeed
            // 
            this.btnAddSpeed.Location = new System.Drawing.Point(20, 13);
            this.btnAddSpeed.Name = "btnAddSpeed";
            this.btnAddSpeed.Size = new System.Drawing.Size(170, 250);
            this.btnAddSpeed.TabIndex = 0;
            this.btnAddSpeed.Text = "增加移動速度";
            this.btnAddSpeed.UseVisualStyleBackColor = true;
            this.btnAddSpeed.Click += new System.EventHandler(this.btnAddSpeed_Click);
            // 
            // btnAddCityWallHP
            // 
            this.btnAddCityWallHP.Location = new System.Drawing.Point(196, 13);
            this.btnAddCityWallHP.Name = "btnAddCityWallHP";
            this.btnAddCityWallHP.Size = new System.Drawing.Size(170, 250);
            this.btnAddCityWallHP.TabIndex = 2;
            this.btnAddCityWallHP.Text = "增加城牆生命值";
            this.btnAddCityWallHP.UseVisualStyleBackColor = true;
            this.btnAddCityWallHP.Click += new System.EventHandler(this.btnAddCityWallHP_Click);
            // 
            // BtnAddReLoadSpeed
            // 
            this.BtnAddReLoadSpeed.Location = new System.Drawing.Point(372, 13);
            this.BtnAddReLoadSpeed.Name = "BtnAddReLoadSpeed";
            this.BtnAddReLoadSpeed.Size = new System.Drawing.Size(170, 250);
            this.BtnAddReLoadSpeed.TabIndex = 3;
            this.BtnAddReLoadSpeed.Text = "增加裝填速度";
            this.BtnAddReLoadSpeed.UseVisualStyleBackColor = true;
            this.BtnAddReLoadSpeed.Click += new System.EventHandler(this.BtnAddReLoadSpeed_Click);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.AutoSize = true;
            this.txtSendMsg.Location = new System.Drawing.Point(20, 343);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(51, 19);
            this.txtSendMsg.TabIndex = 4;
            this.txtSendMsg.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(560, 278);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.BtnAddReLoadSpeed);
            this.Controls.Add(this.btnAddCityWallHP);
            this.Controls.Add(this.btnAddSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "升級選單";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSpeed;
        private System.Windows.Forms.Button btnAddCityWallHP;
        private System.Windows.Forms.Button BtnAddReLoadSpeed;
        public System.Windows.Forms.Label txtSendMsg;
    }
}