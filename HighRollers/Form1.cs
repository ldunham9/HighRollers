using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighRollers
{
    public partial class frmHighRollers : Form
    {
        public Random random = new Random();
        const int MONEY_GOAL = 20000;
        int rollOne = 0;
        int rollTwo = 0;
        int player1Money = 5000;
        int player2Money = 5000;
        int betMoney = 500;
        int turnCounter = 1;
        int rollTotal = 0;

        

        public frmHighRollers()
        {
            InitializeComponent();
        }

        public void moneyManage()
        {
            if(turnCounter == 1)
            {
                if (rollTotal % 2 == 0 && rollTotal != 2)
                {
                    player1Money = player1Money - betMoney;
                    lblStatus.Text = "Bad Roll";

                }
                else if (rollTotal % 2 != 0 && rollTotal != 7)
                {
                    player1Money = player1Money + betMoney;
                    lblStatus.Text = "Nice Roll!";

                }
                else if (rollTotal == 2)
                {
                    player1Money = player1Money - (betMoney * 5);
                    lblStatus.Text = "Ouch!";

                }
                else if (rollTotal == 7)
                {
                    player1Money = player1Money + (betMoney * 2);
                    lblStatus.Text = "Wow!";
                }
                lblP1Money.Text = "P1: $" + player1Money;
            }

            if(turnCounter == 2)
            {
                if(rollTotal % 2 == 0 && rollTotal != 2)
                {
                    player2Money = player2Money - betMoney;
                    lblStatus.Text = "Bad Roll";
                    
                }
                else if(rollTotal % 2 != 0 && rollTotal != 7)
                {
                    player2Money = player2Money + betMoney;
                    lblStatus.Text = "Nice Roll!";
                }
                else if(rollTotal == 2)
                {
                    player2Money = player2Money - (betMoney * 5);
                    lblStatus.Text = "Ouch!";
                }
                else if(rollTotal == 7)
                {
                    player2Money = player2Money + (betMoney * 2);
                    lblStatus.Text = "Wow!";
                }
                lblP2Money.Text = "P2: $" + player2Money;
            }

            if(player1Money >= MONEY_GOAL || player2Money <= 0)
            {
                lblStatus.Text = "P1 Wins!";
                btnRoll.Enabled = false;
            }
            else if(player2Money >= MONEY_GOAL || player1Money <= 0)
            {
                lblStatus.Text = "P2 Wins!";
                btnRoll.Enabled = false;
            }
               
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rollOne = rnd.Next(1, 6);
            rollTwo = rnd.Next(1, 6);
            rollTotal = rollOne + rollTwo;

            picDie11.Visible = false;
            picDie12.Visible = false;
            picDie13.Visible = false;
            picDie14.Visible = false;
            picDie15.Visible = false;
            picDie16.Visible = false;

            picDie21.Visible = false;
            picDie22.Visible = false;
            picDie23.Visible = false;
            picDie24.Visible = false;
            picDie25.Visible = false;
            picDie26.Visible = false;

            switch (rollOne)
            {
                case 1:
                    picDie11.Visible = true;
                    break;
                case 2:
                    picDie12.Visible = true;
                    break;
                case 3:
                    picDie13.Visible = true;
                    break;
                case 4:
                    picDie14.Visible = true;
                    break;
                case 5:
                    picDie15.Visible = true;
                    break;
                case 6:
                    picDie16.Visible = true;
                    break;
            }

            switch (rollTwo)
            {
                case 1:
                    picDie21.Visible = true;
                    break;
                case 2:
                    picDie22.Visible = true;
                    break;
                case 3:
                    picDie23.Visible = true;
                    break;
                case 4:
                    picDie24.Visible = true;
                    break;
                case 5:
                    picDie25.Visible = true;
                    break;
                case 6:
                    picDie26.Visible = true;
                    break;
                   
            }

            moneyManage();
            if (turnCounter == 1)
            {
                turnCounter += 1;
                lblPlayerTurn.Text = "Player Two's Turn";
                    
            }
            else
            {
                turnCounter -= 1;
                lblPlayerTurn.Text = "Player One's Turn";

            }

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if(betMoney <= 4500)
            {
                betMoney += 500;
                lblBets.Text = "$" + betMoney.ToString();
            }
                
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            if(betMoney >= 1000)
            {
                betMoney -= 500;
                lblBets.Text = "$" + betMoney.ToString();
            }
        }
    }
}
