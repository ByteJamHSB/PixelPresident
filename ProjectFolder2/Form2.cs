﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void PublicSpeakinglbl_Click(object sender, EventArgs e)
        {

        }

        private void Eventbtn_Click(object sender, EventArgs e)
        {
            EventPopup popup = new EventPopup();

            DialogResult dialogresult = popup.ShowDialog();
            //if (dialogresult == DialogResult.OK)
            //{
            //    Console.WriteLine("You clicked OK");
            //}
            //else if (dialogresult == DialogResult.Cancel)
            //{
            //    Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            //}
            //popup.Dispose();
        }



        private void tabPage5_Load(object sender, EventArgs e)
        {
            List<President> sortList = new List<President>(PartyPick.presList);
            sortList.Sort();

            foreach (var item in sortList)
            {

                PartyEmpty.Text += item.Party;
                RaceEmpty.Text += item.Gender;
                AgeEmpty.Text += item.Age;
                RaceEmpty.Text += item.Race;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
