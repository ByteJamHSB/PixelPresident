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
    public partial class Actions : Form
    {
        // int maxCount = 4;
        public Actions()
        {
            InitializeComponent();
        }

        private void actionCheckBox_SelectedIndexChanged(int maxCount, ItemCheckEventArgs e)
        {
            //maxCount = 4;
            if (actionCheckBox.CheckedItems.Count == maxCount)
            {
                if (!actionCheckBox.GetItemChecked(actionCheckBox.SelectedIndex))
                    e.NewValue = e.CurrentValue;
            }

        }

        private void actionCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (presentationCheck.Checked)
            {
                //popularity increase with everyone
            }

            if (policyCheck.Checked)
            {
                //popularity slighly increases
            }
            if (relationsCheck.Checked)
            {
                //populariy slightly increase 
                //policy decreases

            }
            if (fundsCheck.Checked)
            {
                //policy increases
                //popularity increases
                // speech decrease
            }
            if (pandemicCheck.Checked)
            {
                //foreign relation increase
                //speech decrease 

                //popularity increase
            }
            if (economyCheck.Checked)
            {
                //funds increase
                //policy increase

            }
            if (jobsCheck.Checked)
            {
                //economy increase
                //pandemic checks
                //funds check
                //presentation decrease
            }
        }
    }
}
