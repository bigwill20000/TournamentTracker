namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.Windows.Forms.Label createTeamLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new System.Windows.Forms.TextBox();
            teamNameLabel = new System.Windows.Forms.Label();
            addMemberButton = new System.Windows.Forms.Button();
            selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            selectTeamMemberLabel = new System.Windows.Forms.Label();
            addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            createMemberButton = new System.Windows.Forms.Button();
            cellPhoneValue = new System.Windows.Forms.TextBox();
            cellPhoneLabel = new System.Windows.Forms.Label();
            emailValue = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            lastNameValue = new System.Windows.Forms.TextBox();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameValue = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            teamMembersListBox = new System.Windows.Forms.ListBox();
            removeSelectedMemberButton = new System.Windows.Forms.Button();
            createTeamButton = new System.Windows.Forms.Button();
            createTeamLabel = new System.Windows.Forms.Label();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            createTeamLabel.Location = new System.Drawing.Point(13, 13);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new System.Drawing.Size(272, 62);
            createTeamLabel.TabIndex = 25;
            createTeamLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new System.Drawing.Point(24, 137);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new System.Drawing.Size(452, 43);
            teamNameValue.TabIndex = 27;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            teamNameLabel.Location = new System.Drawing.Point(15, 84);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(215, 50);
            teamNameLabel.TabIndex = 26;
            teamNameLabel.Text = "Team Name";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            addMemberButton.Location = new System.Drawing.Point(133, 291);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new System.Drawing.Size(249, 48);
            addMemberButton.TabIndex = 31;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new System.Drawing.Point(25, 240);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new System.Drawing.Size(451, 45);
            selectTeamMemberDropDown.TabIndex = 30;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            selectTeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            selectTeamMemberLabel.Location = new System.Drawing.Point(20, 187);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new System.Drawing.Size(362, 50);
            selectTeamMemberLabel.TabIndex = 29;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellPhoneValue);
            addNewMemberGroupBox.Controls.Add(cellPhoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(51, 153, 251);
            addNewMemberGroupBox.Location = new System.Drawing.Point(24, 364);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new System.Drawing.Size(452, 369);
            addNewMemberGroupBox.TabIndex = 32;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add new Member";
            addNewMemberGroupBox.Enter += groupBox1_Enter;
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            createMemberButton.Location = new System.Drawing.Point(109, 293);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new System.Drawing.Size(249, 48);
            createMemberButton.TabIndex = 32;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click_1;
            // 
            // cellPhoneValue
            // 
            cellPhoneValue.Location = new System.Drawing.Point(218, 223);
            cellPhoneValue.Name = "cellPhoneValue";
            cellPhoneValue.Size = new System.Drawing.Size(209, 51);
            cellPhoneValue.TabIndex = 16;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cellPhoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            cellPhoneLabel.Location = new System.Drawing.Point(13, 216);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new System.Drawing.Size(187, 50);
            cellPhoneLabel.TabIndex = 15;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new System.Drawing.Point(218, 166);
            emailValue.Name = "emailValue";
            emailValue.Size = new System.Drawing.Size(209, 51);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            emailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            emailLabel.Location = new System.Drawing.Point(13, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(110, 50);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new System.Drawing.Point(218, 109);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new System.Drawing.Size(209, 51);
            lastNameValue.TabIndex = 12;
            lastNameValue.TextChanged += lastNameValue_TextChanged;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            lastNameLabel.Location = new System.Drawing.Point(13, 102);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(195, 50);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.Click += lastNameLabel_Click;
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new System.Drawing.Point(218, 52);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new System.Drawing.Size(209, 51);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            firstNameLabel.Location = new System.Drawing.Point(13, 51);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(199, 50);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 37;
            teamMembersListBox.Location = new System.Drawing.Point(519, 137);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new System.Drawing.Size(399, 596);
            teamMembersListBox.TabIndex = 33;
            teamMembersListBox.SelectedIndexChanged += teamMemberListBox_SelectedIndexChanged;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            removeSelectedMemberButton.ForeColor = System.Drawing.Color.DodgerBlue;
            removeSelectedMemberButton.Location = new System.Drawing.Point(939, 364);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new System.Drawing.Size(134, 101);
            removeSelectedMemberButton.TabIndex = 34;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = System.Drawing.Color.DodgerBlue;
            createTeamButton.Location = new System.Drawing.Point(405, 751);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new System.Drawing.Size(278, 80);
            createTeamButton.TabIndex = 35;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1085, 851);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "CreateTeamForm";
            Text = "Add New Member";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}