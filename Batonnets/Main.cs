using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batonnets
{
    public partial class Main : Form
    {
        bool J1 = false;
        int bat = 0;
        int scoreJ1 = 0;
        int scoreJ2 = 0;

        public Main()
        {
            InitializeComponent();
            buttonUN.Enabled = false;
            buttonDEUX.Enabled = false;
            buttonTROIS.Enabled = false;
        } 

        private void buttonUN_Click(object sender, EventArgs e)
        {
            ActionBouton(1);
        }

        private void buttonDEUX_Click(object sender, EventArgs e)
        {
            if ((15 - bat) >= 2)
            ActionBouton(2);
        }

        private void buttonTROIS_Click(object sender, EventArgs e)
        {
            if ((15 - bat) >= 3)
            ActionBouton(3);
        }

        public void ActionBouton (int b)
        {
            int nb = 1;
            foreach (PictureBox c in groupBatonnets.Controls)
            {
                if (c.BackColor == System.Drawing.Color.RosyBrown && nb < (1+b))
                {
                    c.BackColor = System.Drawing.Color.White;
                    nb++;
                }
            }
            bat = bat + b;
            fin_tour();
        }

        public void fin_tour()
        {
            //on change de tour
            if (J1 == true)
            {
                J1 = false;
                textMain.Text = "Le Joueur 2 joue";
            }
            else
            {
                J1 = true;
                textMain.Text = "Le Joueur 1 joue";
            }

            //vérification gagnant
            if (bat >= 15)
            {
                if (J1 == true)
                {
                    textMain.Text = "Le Joueur 2 gagne !";
                    scoreJ2++;
                    textBoxJ2.Text = Convert.ToString(scoreJ2);
                }
                else
                {
                    textMain.Text = "Le Joueur 1 gagne !";
                    scoreJ1++;
                    textBoxJ1.Text = Convert.ToString(scoreJ1);
                }

                var result = MessageBox.Show("Continuer ?", "Fin de partie", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    //réinitialisation
                    foreach (PictureBox c in groupBatonnets.Controls)
                    {
                        c.BackColor = System.Drawing.Color.RosyBrown;
                    }

                    buttonUN.Enabled = true;
                    buttonDEUX.Enabled = true;
                    buttonTROIS.Enabled = true;
                    bat = 0;

                    if (J1 == true)
                    {
                        textMain.Text = "Le Joueur 1 joue";
                    }
                    else
                    {
                        textMain.Text = "Le Joueur 2 joue";
                    }
                }
            }
        }

        public void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //réinitialisation
            foreach (PictureBox c in groupBatonnets.Controls)
            {
                c.BackColor = System.Drawing.Color.RosyBrown;
            }

            buttonUN.Enabled = true;
            buttonDEUX.Enabled = true;
            buttonTROIS.Enabled = true;
            bat = 0;
            scoreJ1 = 0;
            scoreJ2 = 0;
            textBoxJ1.Text = Convert.ToString(scoreJ1);
            textBoxJ2.Text = Convert.ToString(scoreJ2);

            //selection du 1er joueur
            using (New_Game frm = new New_Game())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    textMain.Text = "Le " + frm.GetValue + " joue";
                if (frm.GetValue == "Joueur 1")
                    J1 = true;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
