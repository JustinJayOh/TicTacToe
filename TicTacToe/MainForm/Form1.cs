using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        // Fields
        Player user = new Player();
        Player user2 = new Player();
        int turn = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gameInfoLabel.Text = "New game started";
            
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            gameInfoLabel.Text = "New game started";
            ClearMap();
        }

        /** 
         * Clears Map of game pieces
         * */
         public void ClearMap()
        {
            topLeftButton.Text = "";
            topMiddleButton.Text = "";
            topRightButton.Text = "";
            middleLeftButton.Text = "";
            middleButton.Text = "";
            middleRightButton.Text = "";
            bottomLeftButton.Text = "";
            bottomMiddleButton.Text = "";
            bottomRightButton.Text = "";
            user.ClearPieces();
        }

        private void topLeftButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(8))
            {
                if (turn % 2 == 0)
                {
                    topLeftButton.Text = "X";
                    user.SetPiece(8);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    topLeftButton.Text = "O";
                    user2.SetPiece(8);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void topMiddleButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(1))
            {
                if (turn % 2 == 0)
                {
                    topMiddleButton.Text = "X";
                    user.SetPiece(1);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    topMiddleButton.Text = "O";
                    user2.SetPiece(1);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void topRightButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(6))
            {
                if (turn % 2 == 0)
                {
                    topRightButton.Text = "X";
                    user.SetPiece(6);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    topRightButton.Text = "O";
                    user2.SetPiece(6);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void middleLeftButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(3))
            {
                if (turn % 2 == 0)
                {
                    middleLeftButton.Text = "X";
                    user.SetPiece(3);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    middleLeftButton.Text = "O";
                    user2.SetPiece(3);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(5))
            {
                if (turn % 2 == 0)
                {
                    middleButton.Text = "X";
                    user.SetPiece(5);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    middleButton.Text = "O";
                    user2.SetPiece(5);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void middleRightButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(7))
            {
                if (turn % 2 == 0)
                {
                    middleRightButton.Text = "X";
                    user.SetPiece(7);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    middleRightButton.Text = "O";
                    user2.SetPiece(7);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void bottomLeftButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(4))
            {
                if (turn % 2 == 0)
                {
                    bottomLeftButton.Text = "X";
                    user.SetPiece(4);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    bottomLeftButton.Text = "O";
                    user2.SetPiece(4);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void bottomMiddleButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(9))
            {
                if (turn % 2 == 0)
                {
                    bottomMiddleButton.Text = "X";
                    user.SetPiece(9);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    bottomMiddleButton.Text = "O";
                    user2.SetPiece(9);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void bottomRightButton_Click(object sender, EventArgs e)
        {
            if (Grid.ContainsPiece(2))
            {
                if (turn % 2 == 0)
                {
                    bottomRightButton.Text = "X";
                    user.SetPiece(2);
                    if (user.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 1 won";
                    }
                }
                else
                {
                    bottomRightButton.Text = "O";
                    user2.SetPiece(2);
                    if (user2.CheckWin())
                    {
                        ClearLabel();
                        gameInfoLabel.Text = "Player 2 Wins";
                    }
                }
                turn++;
            }
            else
            {
                ClearLabel();
                gameInfoLabel.Text += "That Place is already taken";
            }
        }

        private void ClearLabel()
        {
            gameInfoLabel.Text = "";
        }
    }
}
