using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtSendMsg.Text = "";
        }

        private void btnAddSpeed_Click(object sender, EventArgs e)
        {
            txtSendMsg.Text = "移動速度";
            this.Close();
        }

        private void btnAddCityWallHP_Click(object sender, EventArgs e)
        {
            txtSendMsg.Text = "城牆生命值";
            this.Close();
        }

        private void BtnAddReLoadSpeed_Click(object sender, EventArgs e)
        {
            txtSendMsg.Text = "裝填速度";
            this.Close();
        }


    }
}
