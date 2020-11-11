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
    public partial class TakeAction : Form
    {
        public static List<Attributes> atNewList = new List<Attributes>();
        public TakeAction()
        {
            InitializeComponent();
        }

        private void TakeAction_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Random rnd = new Random();
            int votes = rnd.Next(270, 320);

            List<President> sortNewList = new List<President>(PartyPick.presList);
            sortNewList.Sort();

            foreach (var item in sortNewList)
            {
                resultLabel.Text +=
                "Representing the :" + item.Party.PadRight(20) +
                "\n Canidate Name" + item.Name.PadRight(20);
                
        }
            voteLabel.Text +=
                "Total Electoral Votes:" +
                "\n*Needed 270*:"+ 
                "\n"+votes;

            List<Attributes> sortnewAtList = new List<Attributes>(Actions.atList);
            sortnewAtList.Sort();
            foreach(var item2 in sortnewAtList)
            {
                pointsLabel.Text +=
                        "\nPopularity: " + item2.Popularity.ToString().PadRight(20) +
                        "\tSpeech: " + item2.Presentation.ToString().PadRight(20) +
                        "\nEconomy:" + item2.EconomyRise.ToString().PadRight(20) +
                        "\tPublic Health: " + item2.PublicHealth.ToString().PadRight(20) +
                        "\nForeign Relations: " + item2.ForeignRelations.ToString().PadRight(20) +
                        "\tPolicy: " + item2.Policy.ToString().PadRight(20) +
                        "\nJob in US: " + item2.Job.ToString().PadRight(20);

                if(item2.Popularity > 100 ||item2.Presentation >75 || item2.EconomyRise < 50|| item2.PublicHealth<65|| item2.ForeignRelations>40|| item2.Policy<60|| item2.Job<50)
                {
                    checkBox1.Text += "Focus on public speeches";
                    checkBox2.Text += "Focus on Jobs in US:";
                    checkBox3.Text += "Focus on Policy:";
                    checkBox4.Text += "Focus on Health:";

                    //if and else to determine what to increase for campaign
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        item2.Presentation += 35;
                        item2.EconomyRise += 25;
                        item2.Job += 25;
                    }
                    else if (checkBox1.Checked && checkBox3.Checked)
                    {
                        item2.Presentation += 35;
                        //item2.EconomyRise += 25;
                        item2.Policy += 30;

                    }
                    else if (checkBox1.Checked && checkBox4.Checked)
                    {
                        item2.Presentation += 35;
                        item2.EconomyRise -= 15;
                        item2.PublicHealth += 20;
                    }
                    else if (checkBox2.Checked && checkBox3.Checked)
                    {
                        item2.Job += 25;
                        item2.Policy += 30;
                    }
                    else if (checkBox2.Checked && checkBox4.Checked)
                    {
                        item2.Job += 25;
                        item2.PublicHealth += 20;
                    }
                    else
                    {
                        item2.Job += 30;
                        item2.Policy += 20;
                    }
                }

            
                else if(item2.Popularity<100 || item2.Presentation<75||item2.EconomyRise > 50||item2.PublicHealth>65 ||item2.ForeignRelations<40||item2.Policy>60||item2.Job>50) 
                    {
                    checkBox1.Text += "Focus on gaining more Popularity";
                    checkBox2.Text += "Focus on Economy";
                    checkBox3.Text += "Focus on gaining better relations with Foreign Countries";
                    checkBox4.Text += "Focus on Creating better policies";

                    //if and else 
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        item2.Popularity += 10;
                        item2.EconomyRise += 25;
                        
                    }
                    else if (checkBox1.Checked && checkBox3.Checked)
                    {
                        item2.Popularity += 10;
                        item2.ForeignRelations += 30;

                    }
                    else if (checkBox1.Checked && checkBox4.Checked)
                    {
                        item2.Popularity += 10;
                        item2.Policy += 30;
                    }
                    else if (checkBox2.Checked && checkBox3.Checked)
                    {
                        item2.EconomyRise += 25;
                        item2.ForeignRelations += 30;
                    }
                    else if (checkBox2.Checked && checkBox4.Checked)
                    {
                        item2.EconomyRise += 25;
                        item2.Policy += 20;
                    }
                    else
                    {
                        item2.ForeignRelations += 30;
                        item2.Policy += 20;
                    }
                
                 }
                else
                {
                    checkBox1.Text += "Focus on creating more Jobs";
                    checkBox2.Text += "Focus on Public Health";
                    checkBox3.Text += "Focus on gaining better relations with Foreign Countries";
                    checkBox4.Text += "Focus on Speeches and Interactions";
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        item2.Job += 35;
                        item2.EconomyRise += 25;
                        item2.PublicHealth += 25;
                    }
                    else if(checkBox1.Checked && checkBox3.Checked)
                    {
                        item2.Job += 35;
                        item2.EconomyRise += 25;
                        item2.ForeignRelations += 30;

                    }
                    else if (checkBox1.Checked && checkBox4.Checked)
                    {
                        item2.Job += 35;
                        item2.EconomyRise += 25;
                        item2.Presentation += 20;
                    }else if( checkBox2.Checked && checkBox3.Checked)
                    {
                        item2.PublicHealth += 25;
                        item2.ForeignRelations += 30;
                    }else if(checkBox2.Checked&& checkBox4.Checked)
                    {
                        item2.PublicHealth += 25;
                        item2.Presentation += 20;
                    }
                    else
                    {
                        item2.ForeignRelations += 30;
                        item2.Presentation += 20;
                    }
                }

            }

           
           
        }

        private void completeAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actions Saved!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int popularity = 0;
            int speech = 0;
            int economic = 0;
            int health = 0;
            int relations = 0;
            int policy = 0;
            int jobs = 0;

            if (checkBox1.Checked)
            {
                popularity += 30;
                jobs += 25;
                speech += 30;
            }
            if (checkBox2.Checked)
            {
                economic += 30;
                health += 40;
                jobs += 15;
                popularity += 15;
            }
            if (checkBox3.Checked)
            {
                popularity += 15;
                relations += 40;
                policy += 40;
            }
            if(checkBox4.Checked)
            {
                speech += 40;
                popularity += 15;
            }
            Attributes newAt = new Attributes(Convert.ToInt32(popularity),
                                         Convert.ToInt32(speech),
                                         Convert.ToInt32(economic),
                                         Convert.ToInt32(health),
                                         Convert.ToInt32(relations),
                                         Convert.ToInt32(policy),
                                         Convert.ToInt32(jobs));
            atNewList.Add(newAt);
           
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            SecondResults sR = new SecondResults(); 
            sR.ShowDialog();

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
