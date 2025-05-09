using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Sim_Botic
{
    public partial class GameBoard : Form
    {
        private int timeLeft;
        private int score = 0;
        private int currentQuestionIndex = 0;
        private int questionTimeLimit = 10;
        private string selectedDifficulty = "Easy";
        // private Random random = new Random();
        private ProgressBar progressBarGame;
        private int robotPositionX;
        private const int moveDistance = 10;
        private Timer timer = new Timer();

        private List<string> questions = new List<string>
        {
            "What is the output of: Console.WriteLine(5 + 3 * 2);", // Answer: 11
            "Which keyword is used to declare a method in C#?",   // Answer: void
            "What is the result of: 10 % 3?",                     // Answer: 1
            "How do you declare a constant in C#?",               // Answer: const
            "What loop repeats until a condition is false?",     // Answer: while
            "What is the default value of int in Java?",
            "Which keyword is used to inherit a class in Java?",
            "Which data structure uses LIFO?",
            "Which function is used to output text in PHP?"
        };

        //private int gameScore;

        private List<string> answers = new List<string>
        {
            "11", "void", "1", "const", "while", "0", "extends","Stack","echo"
        };
        public GameBoard()
        {
            InitializeComponent();
            LoadDifficultyLevels();
            InitializeProgressBar();
            LoadQuestion();
            questionTimer.Interval = 1000; // 1 second interval
            questionTimer.Tick += questionTimer_Tick;
        }

        private void Guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void LoadQuestion()
        {
          
            if (currentQuestionIndex < questions.Count)
            {
                label2.Text = questions[currentQuestionIndex];
                txtAnswer.Clear();
                SetTimeLimit();
            }
            else
            {
                questionTimer.Stop();
                MessageBox.Show($"Game Over! ");
                btnSubmit.Enabled = false;
            }
        }

        private void LoadDifficultyLevels()
        {
            cmbDifficulty.Items.AddRange(new string[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.SelectedIndex = 0;
            cmbDifficulty.SelectedIndexChanged += cmbDifficulty_SelectedIndexChanged;
        }

        private string difficultyLevel;

        private void SetTimeLimit()
        {
            switch (selectedDifficulty)
            {
                case "Easy": questionTimeLimit = 25; break;
                case "Medium": questionTimeLimit = 20; break;
                case "Hard": questionTimeLimit = 15; break;
            }
            timeLeft = questionTimeLimit;
            label1.Text = $"Time Left: {timeLeft}s";
            questionTimer.Start();
        }

        private void InitializeProgressBar()
        {
            progressBarGame = new ProgressBar
            {
                Maximum = questions.Count,
                Value = 0,
                Location = new Point(300, 500),
                Size = new Size(280, 25),
                ForeColor = Color.Blue
            };
            Controls.Add(progressBarGame);
        }

        private void UpdateProgressBar()
        {
            if (currentQuestionIndex < progressBarGame.Maximum)
            {
                progressBarGame.Value = currentQuestionIndex + 1;
            }
            else
            {
                progressBarGame.Value = progressBarGame.Maximum; // Prevent overflow
            }
        }

        private void CheckAnswer()
        {
            questionTimer.Stop();
            string userAnswer = txtAnswer.Text.Trim().ToLower();
            if (userAnswer == answers[currentQuestionIndex].ToLower())
            {
                score += 10;
                //lblscore.Text = $"Score: {score}";
                //guna2HtmlLabel1.Text = $"Score: {score}";
                MessageBox.Show("Correct!");
                //timer2.Start();
            }
            else
            {
                MessageBox.Show($"Incorrect! The correct answer was: {answers[currentQuestionIndex]}");
                //timer2.Stop();
            }

            UpdateProgressBar();
            currentQuestionIndex++;
            LoadQuestion();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckAnswer();

        }


        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                label1.Text = $"Time Left: {timeLeft}s";
            }
            else
            {
                questionTimer.Stop();
                MessageBox.Show("Time's up! Moving to the next question.");
                currentQuestionIndex++;
                UpdateProgressBar();
                LoadQuestion();
            }
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDifficulty = cmbDifficulty.SelectedItem.ToString();
            SetTimeLimit();
        }

        private void btn_Final_Click(object sender, EventArgs e)
        {
            ScoreBoard scoreboard = new ScoreBoard(score);
            scoreboard.Show();
            this.Hide();
        }

      
    }
}
