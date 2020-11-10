namespace HackStreet
{
    partial class PartyPick
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.partyLabel = new System.Windows.Forms.Label();
            this.demoPartyRadio = new System.Windows.Forms.RadioButton();
            this.republicanPartyRadio = new System.Windows.Forms.RadioButton();
            this.libPartyRadio = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.greenParty = new System.Windows.Forms.RadioButton();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.raceTxt = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // partyLabel
            // 
            this.partyLabel.AutoSize = true;
            this.partyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.partyLabel.Location = new System.Drawing.Point(12, 33);
            this.partyLabel.Name = "partyLabel";
            this.partyLabel.Size = new System.Drawing.Size(117, 13);
            this.partyLabel.TabIndex = 0;
            this.partyLabel.Text = "Pick a Party to Run for:";
            // 
            // demoPartyRadio
            // 
            this.demoPartyRadio.AutoSize = true;
            this.demoPartyRadio.BackColor = System.Drawing.SystemColors.Control;
            this.demoPartyRadio.Location = new System.Drawing.Point(144, 33);
            this.demoPartyRadio.Name = "demoPartyRadio";
            this.demoPartyRadio.Size = new System.Drawing.Size(106, 17);
            this.demoPartyRadio.TabIndex = 1;
            this.demoPartyRadio.TabStop = true;
            this.demoPartyRadio.Text = "Democratic Party";
            this.demoPartyRadio.UseVisualStyleBackColor = false;
            // 
            // republicanPartyRadio
            // 
            this.republicanPartyRadio.AutoSize = true;
            this.republicanPartyRadio.BackColor = System.Drawing.SystemColors.Control;
            this.republicanPartyRadio.Location = new System.Drawing.Point(283, 33);
            this.republicanPartyRadio.Name = "republicanPartyRadio";
            this.republicanPartyRadio.Size = new System.Drawing.Size(106, 17);
            this.republicanPartyRadio.TabIndex = 2;
            this.republicanPartyRadio.TabStop = true;
            this.republicanPartyRadio.Text = "Republican Party";
            this.republicanPartyRadio.UseVisualStyleBackColor = false;
            // 
            // libPartyRadio
            // 
            this.libPartyRadio.AutoSize = true;
            this.libPartyRadio.BackColor = System.Drawing.SystemColors.Control;
            this.libPartyRadio.Location = new System.Drawing.Point(408, 33);
            this.libPartyRadio.Name = "libPartyRadio";
            this.libPartyRadio.Size = new System.Drawing.Size(101, 17);
            this.libPartyRadio.TabIndex = 3;
            this.libPartyRadio.TabStop = true;
            this.libPartyRadio.Text = "Libertarian Party";
            this.libPartyRadio.UseVisualStyleBackColor = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(623, 154);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(98, 33);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next (Information)";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(623, 193);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(98, 33);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // greenParty
            // 
            this.greenParty.AutoSize = true;
            this.greenParty.BackColor = System.Drawing.SystemColors.Control;
            this.greenParty.Location = new System.Drawing.Point(526, 33);
            this.greenParty.Name = "greenParty";
            this.greenParty.Size = new System.Drawing.Size(81, 17);
            this.greenParty.TabIndex = 6;
            this.greenParty.TabStop = true;
            this.greenParty.Text = "Green Party";
            this.greenParty.UseVisualStyleBackColor = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(623, 115);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(98, 33);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gender:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ageLabel.Location = new System.Drawing.Point(12, 144);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Age:";
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(68, 137);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(32, 20);
            this.ageTxt.TabIndex = 12;
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.raceLabel.Location = new System.Drawing.Point(12, 183);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 13);
            this.raceLabel.TabIndex = 13;
            this.raceLabel.Text = "Race:";
            // 
            // raceTxt
            // 
            this.raceTxt.Location = new System.Drawing.Point(54, 176);
            this.raceTxt.Name = "raceTxt";
            this.raceTxt.Size = new System.Drawing.Size(100, 20);
            this.raceTxt.TabIndex = 14;
            // 
            // genderText
            // 
            this.genderText.Location = new System.Drawing.Point(68, 91);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(100, 20);
            this.genderText.TabIndex = 15;
            // 
            // PartyPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.raceTxt);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.greenParty);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.libPartyRadio);
            this.Controls.Add(this.republicanPartyRadio);
            this.Controls.Add(this.demoPartyRadio);
            this.Controls.Add(this.partyLabel);
            this.Name = "PartyPick";
            this.Text = "PartyPick";
            this.Load += new System.EventHandler(this.PartyPick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label partyLabel;
        private System.Windows.Forms.RadioButton demoPartyRadio;
        private System.Windows.Forms.RadioButton republicanPartyRadio;
        private System.Windows.Forms.RadioButton libPartyRadio;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.RadioButton greenParty;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox raceTxt;
        private System.Windows.Forms.TextBox genderText;
    }
}