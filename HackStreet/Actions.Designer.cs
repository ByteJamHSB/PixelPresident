namespace HackStreet
{
    partial class Actions
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
            this.label1 = new System.Windows.Forms.Label();
            this.actionCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.presentationCheck = new System.Windows.Forms.CheckBox();
            this.policyCheck = new System.Windows.Forms.CheckBox();
            this.relationsCheck = new System.Windows.Forms.CheckBox();
            this.fundsCheck = new System.Windows.Forms.CheckBox();
            this.pandemicCheck = new System.Windows.Forms.CheckBox();
            this.economyCheck = new System.Windows.Forms.CheckBox();
            this.jobsCheck = new System.Windows.Forms.CheckBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actions Allowed: ";
            // 
            // actionCheckBox
            // 
            this.actionCheckBox.FormattingEnabled = true;
            this.actionCheckBox.Items.AddRange(new object[] {
            "Good Speech Presentations",
            "Create New Policy",
            "Foreign Relations",
            "Manage Federal Funds",
            "Fight Pandemics",
            "State of Ecomony ",
            "Increase Jobs in America"});
            this.actionCheckBox.Location = new System.Drawing.Point(12, 40);
            this.actionCheckBox.Name = "actionCheckBox";
            this.actionCheckBox.Size = new System.Drawing.Size(168, 109);
            this.actionCheckBox.TabIndex = 1;
            this.actionCheckBox.SelectedIndexChanged += new System.EventHandler(this.actionCheckBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Limit of 4";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(655, 113);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(95, 36);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // presentationCheck
            // 
            this.presentationCheck.AutoSize = true;
            this.presentationCheck.Location = new System.Drawing.Point(252, 78);
            this.presentationCheck.Name = "presentationCheck";
            this.presentationCheck.Size = new System.Drawing.Size(154, 17);
            this.presentationCheck.TabIndex = 4;
            this.presentationCheck.Text = "Good Speech Presentation";
            this.presentationCheck.UseVisualStyleBackColor = true;
            // 
            // policyCheck
            // 
            this.policyCheck.AutoSize = true;
            this.policyCheck.Location = new System.Drawing.Point(252, 101);
            this.policyCheck.Name = "policyCheck";
            this.policyCheck.Size = new System.Drawing.Size(113, 17);
            this.policyCheck.TabIndex = 5;
            this.policyCheck.Text = "Create New Policy";
            this.policyCheck.UseVisualStyleBackColor = true;
            // 
            // relationsCheck
            // 
            this.relationsCheck.AutoSize = true;
            this.relationsCheck.Location = new System.Drawing.Point(252, 124);
            this.relationsCheck.Name = "relationsCheck";
            this.relationsCheck.Size = new System.Drawing.Size(108, 17);
            this.relationsCheck.TabIndex = 6;
            this.relationsCheck.Text = "Foreign Relations";
            this.relationsCheck.UseVisualStyleBackColor = true;
            // 
            // fundsCheck
            // 
            this.fundsCheck.AutoSize = true;
            this.fundsCheck.Location = new System.Drawing.Point(252, 147);
            this.fundsCheck.Name = "fundsCheck";
            this.fundsCheck.Size = new System.Drawing.Size(135, 17);
            this.fundsCheck.TabIndex = 7;
            this.fundsCheck.Text = "Manage Federal Funds";
            this.fundsCheck.UseVisualStyleBackColor = true;
            // 
            // pandemicCheck
            // 
            this.pandemicCheck.AutoSize = true;
            this.pandemicCheck.Location = new System.Drawing.Point(251, 170);
            this.pandemicCheck.Name = "pandemicCheck";
            this.pandemicCheck.Size = new System.Drawing.Size(114, 17);
            this.pandemicCheck.TabIndex = 8;
            this.pandemicCheck.Text = "Fight off Pandemic";
            this.pandemicCheck.UseVisualStyleBackColor = true;
            // 
            // economyCheck
            // 
            this.economyCheck.AutoSize = true;
            this.economyCheck.Location = new System.Drawing.Point(251, 193);
            this.economyCheck.Name = "economyCheck";
            this.economyCheck.Size = new System.Drawing.Size(112, 17);
            this.economyCheck.TabIndex = 9;
            this.economyCheck.Text = "State Of Economy";
            this.economyCheck.UseVisualStyleBackColor = true;
            // 
            // jobsCheck
            // 
            this.jobsCheck.AutoSize = true;
            this.jobsCheck.Location = new System.Drawing.Point(251, 216);
            this.jobsCheck.Name = "jobsCheck";
            this.jobsCheck.Size = new System.Drawing.Size(121, 17);
            this.jobsCheck.TabIndex = 10;
            this.jobsCheck.Text = "Increase Jobs in US";
            this.jobsCheck.UseVisualStyleBackColor = true;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(655, 67);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(95, 36);
            this.confirmBtn.TabIndex = 11;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.jobsCheck);
            this.Controls.Add(this.economyCheck);
            this.Controls.Add(this.pandemicCheck);
            this.Controls.Add(this.fundsCheck);
            this.Controls.Add(this.relationsCheck);
            this.Controls.Add(this.policyCheck);
            this.Controls.Add(this.presentationCheck);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "Actions";
            this.Text = "Actions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox actionCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox presentationCheck;
        private System.Windows.Forms.CheckBox policyCheck;
        private System.Windows.Forms.CheckBox relationsCheck;
        private System.Windows.Forms.CheckBox fundsCheck;
        private System.Windows.Forms.CheckBox pandemicCheck;
        private System.Windows.Forms.CheckBox economyCheck;
        private System.Windows.Forms.CheckBox jobsCheck;
        private System.Windows.Forms.Button confirmBtn;
    }
}