using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackStreet
{
    public partial class SecondResults : Form
    {
        public SecondResults()
        {
            InitializeComponent();
            popBar2.Maximum = 500;
            speechBar2.Maximum = 500;
            economyBar2.Maximum = 500;
            healthBar2.Maximum = 500;
            relationsBar2.Maximum = 500;
            policyBar2.Maximum = 500;
            jobBar2.Maximum = 500;
        }

        private void SecondResults_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            reElectLabel.Size = new Size(500, 250);
            List<President> sortList = new List<President>(PartyPick.presList);
            sortList.Sort();

            foreach (var item in sortList)
            {
                nameLbl.Text +=
                    "Party: " + item.Party.PadRight(20) +
                    "\nCanidate Name:" + item.Name.PadRight(20);
            }
                List<Attributes> sortatList = new List<Attributes>(Actions.atList);
                sortatList.Sort();
            
                foreach (var item2 in sortatList)
                {

                    popBar2.Value = item2.Popularity;
                popResultLabel.Text += "" + item2.Popularity;
                speechBar2.Value = item2.Presentation;
                speechResultsLabel.Text += "" + item2.Presentation;
                economyBar2.Value = item2.EconomyRise;
                econresultsLabel.Text += "" + item2.EconomyRise;
                healthBar2.Value = item2.PublicHealth;
                healthResultsLabel.Text += "" + item2.PublicHealth;
                relationsBar2.Value = item2.ForeignRelations;
                relationsResultsLabel.Text += "" + item2.ForeignRelations;
                policyBar2.Value = item2.Policy;
                policyResultsLabel.Text += "" + item2.Policy;
                jobBar2.Value = item2.Job;
                jobResultsLabel.Text += "" + item2.Job;


                if (item2.Popularity > 250||item2.Job>100 || item2.Policy > 100)
                {
                    newWinLabel.Text += "Congratulation! You have been re-lected to a Second Term!";
                }
                else
                {
                   newWinLabel.Text += "Sorry! You have been been denied Re-Election to a Second Term!";
                }
                {

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
