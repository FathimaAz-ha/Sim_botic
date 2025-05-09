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
    public partial class ScoreBoard : Form
    {
        private int score;
        public ScoreBoard(int score)
        {

            InitializeComponent();
            this.score = score;
        }
        private void PerformanceForm_Load(object sender, EventArgs e)
        {
            // ✅ Properly display the score on the label
            guna2HtmlLabel1.Text = "";
        }
        private void ScoreBoard_Load(object sender, EventArgs e)
{
    guna2HtmlLabel1.Text = $" {score}";
}

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.Show();
            this.Hide();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
