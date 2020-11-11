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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            List<President> sortList = new List<President>(PartyPick.presList);
            sortList.Sort();

            foreach(var item in sortList)
            {
                infoLabel.Text +=
                    "Party: " + item.Party.PadRight(20) +
                    "\nGender: " + item.Gender.PadRight(20) +
                    "\nAge:" + item.Age.ToString().PadRight(20) +
                    "\nRace: " + item.Race.PadRight(20);
                    //Environment.NewLine();
                   // item.ToString();
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actions aP = new Actions();
            aP.ShowDialog();
        }
    }
}
