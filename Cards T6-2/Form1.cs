using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards_T6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades" :
                    ShowAceSpades();
                    break;
                case "10 of Hearts" :
                    ShowTenHearts();
                    break;
                case "King of Clubs" :
                    ShowKingClubs();
                    break;
            }
        }

        private void ShowAceSpades()
        {
            acePictureBox.Visible = true;
            tenPictureBox.Visible = false;
            kingPictureBox.Visible = false;
        }

        private void ShowTenHearts()
        {
            acePictureBox.Visible = false;
            tenPictureBox.Visible = true;
            kingPictureBox.Visible = false;
        }

        private void ShowKingClubs()
        {
            acePictureBox.Visible = false;
            tenPictureBox.Visible = false;
            kingPictureBox.Visible = true;
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from the list box.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
