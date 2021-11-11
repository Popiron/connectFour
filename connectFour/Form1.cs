using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace connectFour
{
    public partial class connectFourForm : Form
    {
        Graphics g;
        public connectFourForm()
        {
            InitializeComponent();
        }


        private void gameBoardPanel_Paint(object sender, PaintEventArgs e)
        {
            g = gameBoardPanel.CreateGraphics();
            DrawBoard();
            DrawState(Game.state);

            if (Game.checkWin(Game.state)=="x")
            {
                gameStatusLabel.Text = "x";
            }

            if (Game.checkWin(Game.state) == "o")
            {
                gameStatusLabel.Text = "o";
            }

            if (Game.checkWin(Game.state) == "tie")
            {
                gameStatusLabel.Text = "tie";
            }

            col0Button.Enabled = Game.isPlayerCurrentTurn;
            col1Button.Enabled = Game.isPlayerCurrentTurn;
            col2Button.Enabled = Game.isPlayerCurrentTurn;
            col3Button.Enabled = Game.isPlayerCurrentTurn;
            col4Button.Enabled = Game.isPlayerCurrentTurn;
            col5Button.Enabled = Game.isPlayerCurrentTurn;
            col6Button.Enabled = Game.isPlayerCurrentTurn;

            if (!Game.isPlayerCurrentTurn)
            {
                Bot.bestStep(Game.state);
                gameBoardPanel.Refresh();
            }
        }

        private void DrawBoard()
        {
            for (int x = 0; x < gameBoardPanel.Size.Width; x+=gameBoardPanel.Size.Width/7)
            {
                g.DrawLine(Pens.Black, new Point(x, 0), new Point(x, gameBoardPanel.Size.Height));
            }
            g.DrawLine(Pens.Black, new Point(gameBoardPanel.Size.Width - 1,0), new Point(gameBoardPanel.Size.Width - 1, gameBoardPanel.Size.Height));
            g.DrawLine(Pens.Black, new Point(0, gameBoardPanel.Size.Height-1), new Point(gameBoardPanel.Size.Width-1, gameBoardPanel.Size.Height-1));
        }

        private void DrawState(String[,] state)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    switch (state[i,j])
                    {
                        case "x":
                            g.FillEllipse(Brushes.Red, i * (gameBoardPanel.Size.Width / 7), j * (gameBoardPanel.Size.Height / 6), 100, 100);
                            break;
                        case "o":
                            g.FillEllipse(Brushes.Blue, i * (gameBoardPanel.Size.Width / 7), j * (gameBoardPanel.Size.Height / 6), 100, 100);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void col0Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(0);
                gameBoardPanel.Refresh();
            }
            
        }

        private void col1Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(1);
                gameBoardPanel.Refresh();
            }
        }

        private void col2Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(2);
                gameBoardPanel.Refresh();
            }
        }

        private void col3Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(3);
                gameBoardPanel.Refresh();
            }
        }

        private void col4Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(4);
                gameBoardPanel.Refresh();
            }
        }

        private void col5Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(5);
                gameBoardPanel.Refresh();
            }
        }

        private void col6Button_Click(object sender, EventArgs e)
        {
            if (Game.isPlayerCurrentTurn)
            {
                Game.doStep(6);
                gameBoardPanel.Refresh();
            }
        }

        private void playerStepRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            Game.isPlayerFirstTurn = true;
            Game.isPlayerCurrentTurn = true;
        }

        private void botStepRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            Game.isPlayerFirstTurn = false;
            Game.isPlayerCurrentTurn = false;
        }

        private void connectFourForm_Shown(object sender, EventArgs e)
        {
            gameBoardPanel.Refresh();
            col0Button.Enabled = false;
            col1Button.Enabled = false;
            col2Button.Enabled = false;
            col3Button.Enabled = false;
            col4Button.Enabled = false;
            col5Button.Enabled = false;
            col6Button.Enabled = false;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            if (!Game.isGameStarted)
            {
                Game.isGameStarted = true;
                restartButton.Text = "Restart";
                firstStepSettingsBox.Enabled = false;
                gameBoardPanel.Refresh();
            } else
            {
                Game.isGameStarted = false;
                firstStepSettingsBox.Enabled = true;
                restartButton.Text = "Start";
                Game.Init();
                gameBoardPanel.Refresh();
                col0Button.Enabled = false;
                col1Button.Enabled = false;
                col2Button.Enabled = false;
                col3Button.Enabled = false;
                col4Button.Enabled = false;
                col5Button.Enabled = false;
                col6Button.Enabled = false;
            }
        }
    }
}
