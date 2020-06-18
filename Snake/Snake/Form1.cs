using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeDefinitiveEdition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer timer;
        int sizeMatrix;
        int[,] matrix;
        SnakeDirection snakeDirection;
        Point headPosition;
        int lastSegment;
        Random random;
        private bool pausa = false;
        private bool statoGioco = false;
        private bool statoGiocoBordi = false;
        int score = 0;
        //private bool gioco = true;

        enum MatrixObject
        {
            Food = -1,
            Spike = -2
        }

        enum SnakeDirection
        {
            Up,
            Right,
            Down,
            Left
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            timer = new Timer();
            timer.Interval = 100;
            //timer.Start();
            timer.Tick += Timer_Tick;
            sizeMatrix = 30;
            matrix = new int[sizeMatrix, sizeMatrix];
            labelScore.Text = score.ToString();

            Initialize();
        }



        private void Initialize()
        {
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            GenerateFood();
            headPosition = new Point(5, 5);
            matrix[5, 5] = 1;
            matrix[6, 5] = 2;
            matrix[7, 5] = 3;
            lastSegment = 3;
            snakeDirection = SnakeDirection.Left;
        }

        // At every seconds this function will be executed
        private void Timer_Tick(object sender, EventArgs e)
        {
            //GameLogicWithoutBord();
            //GameLogic();
            //Draw();

            if (statoGiocoBordi)
            {
                GameLogic();
                Draw();
            }
        }

        //private void StatoGioco()
        //{
        //    while (gioco)
        //    {
        //        GameLogic();
        //        Draw();

        //    }
        //}




        public void Draw()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.FillRectangle(Brushes.Black, 0, 0, pictureBox1.Width, pictureBox1.Height);

            SizeF sizeCell = new SizeF((float)pictureBox1.Width / sizeMatrix, (float)pictureBox1.Height / sizeMatrix);

            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        graphics.FillRectangle(Brushes.Black, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);
                    }
                    else if (matrix[i, j] == (int)MatrixObject.Food)
                    {
                        graphics.FillRectangle(Brushes.White, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.White, i * sizeCell.Width + 1, j * sizeCell.Height + 1, sizeCell.Width - 2, sizeCell.Height - 2);
                    }
                    
                }
            }

            pictureBox1.BackgroundImage = bitmap;
        }

        public void GameLogic()
        {
            Point walkPosition;
            switch (snakeDirection)
            {
                case SnakeDirection.Up:
                    walkPosition = new Point(headPosition.X, headPosition.Y - 1);
                    break;
                case SnakeDirection.Right:
                    walkPosition = new Point(headPosition.X + 1, headPosition.Y);
                    break;
                case SnakeDirection.Down:
                    walkPosition = new Point(headPosition.X, headPosition.Y + 1);
                    break;
                case SnakeDirection.Left:
                    walkPosition = new Point(headPosition.X - 1, headPosition.Y);
                    break;
                default:
                    throw new Exception("");
            }
            if (walkPosition.X < 0 || walkPosition.Y < 0 || walkPosition.X == sizeMatrix || walkPosition.Y == sizeMatrix || matrix[walkPosition.X, walkPosition.Y] > 0)
            {
                score = 0;
                labelScore.Text = score.ToString();
                Initialize();
                return;
            }
            if (matrix[walkPosition.X, walkPosition.Y] == (int)MatrixObject.Food)
            {
                lastSegment++;
                score += 1;
                labelScore.Text = score.ToString();
                GenerateFood();
            }            
            matrix[walkPosition.X, walkPosition.Y] = 1;
            matrix[headPosition.X, headPosition.Y]++;
            
            
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (headPosition.X == i && headPosition.Y == j)
                    {
                        continue;
                    }
                    if (matrix[i, j] == lastSegment)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] > 1)
                    {
                        matrix[i, j]++;
                    }
                }
            }

            headPosition = walkPosition;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    if (snakeDirection != SnakeDirection.Down)
                        snakeDirection = SnakeDirection.Up;                   
                    break;
                case 'd':
                    if (snakeDirection != SnakeDirection.Left)
                        snakeDirection = SnakeDirection.Right;
                    break;
                case 's':
                    if (snakeDirection != SnakeDirection.Up)
                        snakeDirection = SnakeDirection.Down;
                    break;
                case 'a':
                    if (snakeDirection != SnakeDirection.Right)
                        snakeDirection = SnakeDirection.Left;
                    break;
            }
        }

        private void GenerateFood()
        {
            Point foodPosition;

            do
            {
                foodPosition = new Point(random.Next() % sizeMatrix, random.Next() % sizeMatrix);
            } while (matrix[foodPosition.X, foodPosition.Y] != 0);

            matrix[foodPosition.X, foodPosition.Y] = (int)MatrixObject.Food;
        }

        private void Pausa()
        {
            if (pausa == true)
            {
                timer.Start();
                pausa = false;
            }
            else
            {
                timer.Stop();
                pausa = true;
            }
        }

        private void pausaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pausa();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conIBordiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!statoGioco)
            {
                timer.Start();
                statoGioco = true;
                statoGiocoBordi = true;
            }
            else if (pausa)
            {
                pausa = false;
                score = 0;
                labelScore.Text = score.ToString();
                timer.Start();
                Initialize();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void senzaBordiToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        public void GameLogicWithoutBord()
        {
            Point walkPosition;
            switch (snakeDirection)
            {
                case SnakeDirection.Up:
                    walkPosition = new Point(headPosition.X, headPosition.Y - 1);
                    break;
                case SnakeDirection.Right:
                    walkPosition = new Point(headPosition.X + 1, headPosition.Y);
                    break;
                case SnakeDirection.Down:
                    walkPosition = new Point(headPosition.X, headPosition.Y + 1);
                    break;
                case SnakeDirection.Left:
                    walkPosition = new Point(headPosition.X - 1, headPosition.Y);
                    break;
                default:
                    throw new Exception("");
            }
            if (walkPosition.X < 0)
            {
                walkPosition.X = sizeMatrix - 1;
            }
            else if (walkPosition.Y < 0)
            {
                walkPosition.Y = sizeMatrix - 1;
            }
            else if (walkPosition.X == sizeMatrix)
            {
                walkPosition.X = 0;
            }
            else if (walkPosition.Y == sizeMatrix)
            {
                walkPosition.Y = 0;
            }
            else if (matrix[walkPosition.X, walkPosition.Y] > 0)
            {
                score = 0;
                labelScore.Text = score.ToString();
                Initialize();
                return;
            }
            if (matrix[walkPosition.X, walkPosition.Y] == (int)MatrixObject.Food)
            {
                lastSegment++;
                score += 1;
                labelScore.Text = score.ToString();
                GenerateFood();
            }
            matrix[walkPosition.X, walkPosition.Y] = 1;
            matrix[headPosition.X, headPosition.Y]++;


            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (headPosition.X == i && headPosition.Y == j)
                    {
                        continue;
                    }
                    if (matrix[i, j] == lastSegment)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] > 1)
                    {
                        matrix[i, j]++;
                    }
                }
            }

            headPosition = walkPosition;
        }



    }
}
