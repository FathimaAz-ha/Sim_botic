using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sim_Botic
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            //profile button
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Guna2PictureBox4_Click(object sender, EventArgs e)
        {
            //playbutton
            GameBoard gameBoard = new GameBoard();
            gameBoard.Show();
            this.Hide();
        }

        private void Guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            //sign out
            Hello helloPage = new Hello();
            helloPage.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
