using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackStreet
{
    public partial class PartyPick : Form
    {
        public static List<President> presList = new List<President>();

        public PartyPick()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to return to Menu?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) == DialogResult.Yes){
                MessageBox.Show("Returning to menu!", "Menu Return");
            }
            else
            {
                MessageBox.Show("Did not return");
                PartyPick pp = new PartyPick();
                pp.ShowDialog();
            }
            this.Close();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Information infoPage=new Information();
            infoPage.ShowDialog();
        }

        private void PartyPick_Load(object sender, EventArgs e)
        {
            demoPartyRadio.Checked = true;

            //file to hold list
            try
            {
                if (File.Exists("president.ser"))
                {
                    using (Stream stream = File.Open("president.ser", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        presList = (List<President>)bin.Deserialize(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Opening File, program ending"+ex.Message);
            }
        }

        /*private void demoPartyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (demoPartyRadio.Checked == true)
            {
                //MessageBox.Show("You have chose Democrat!");
                return;
            }
            else if (republicanPartyRadio.Checked == true) {
                //MessageBox.Show("You have chosen Republican!!");
                return;
            }
            else if (libPartyRadio.Checked == true)
            {
                //MessageBox.Show("You have chosen to represent Libertarian party!");
                return;

            } else if (greenParty.Checked == true)
            {
                //MessageBox.Show("You have chosen to represent Green Party");
                return;
              
            }
        }*/

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int errctr = 0;
           
            //radio buttons array 
            RadioButton[] radBtns = { demoPartyRadio, republicanPartyRadio, libPartyRadio, greenParty };
           
            
            errctr += CType(radBtns);
          
            errctr += Age();
            errctr += Race();
            //used to represent radio button that is selected

            if (errctr == 0)
            {
                string ctype = " ";
                
                foreach (var pBtn in radBtns)
                {
                    if (pBtn.Checked)
                    {
                        ctype = Convert.ToString(pBtn.Text);
                        break;
                    }
                }
           
                
                President p = new President(ctype,
                    genderText.Text,
                    Convert.ToInt32(ageTxt.Text),
                    raceTxt.Text);
                presList.Add(p);
                MessageBox.Show("Party Saved", "Party", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int CType(RadioButton[] radBtns)
        {
            int errs = 0;
            bool selected = false;

            foreach(var pBtn in radBtns)
            {
                if (pBtn.Checked)
                {
                    selected = true;
                    break;
                }
            }
            if (!selected)
            {
                MessageBox.Show("No part was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }return errs;
        }
        
        int Age()
        {
            int errs = 0;
            if (String.IsNullOrEmpty(ageTxt.Text.Trim())) {
                MessageBox.Show("Must enter age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else if (Convert.ToInt32(ageTxt.Text) <= 0)
            {
                MessageBox.Show("Must enter age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            else
            {

            }
            return errs;
        }
        int Race()
        {
            int errs = 0;
            if (String.IsNullOrEmpty(raceTxt.Text.Trim()))
            {
                MessageBox.Show("Race is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }
            return errs++;
        }
        int Gender()
        {
            int errs = 0;
            if (String.IsNullOrEmpty(genderText.Text.Trim()))
            {
                MessageBox.Show("Race is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errs++;
            }return errs;
        }

        

        
    }
    }

