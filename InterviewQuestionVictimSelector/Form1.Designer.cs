namespace InterviewQuestionVictimSelector
{
    partial class Form1
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblCurrentVictim = new System.Windows.Forms.Label();
            this.interviewQuestionVictimSelector = new System.Windows.Forms.Label();
            this.lblPoolOfNames = new System.Windows.Forms.Label();
            this.lvNamePool = new System.Windows.Forms.ListView();
            this.lblCurrentVictimLabel = new System.Windows.Forms.Label();
            this.lblQuestionLabel = new System.Windows.Forms.Label();
            this.lblQuestionBox = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.editTab = new System.Windows.Forms.TabPage();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnDeleteName = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbSelectName = new System.Windows.Forms.ComboBox();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.txtSelectedQuestion = new System.Windows.Forms.TextBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.lblSelectQuestion = new System.Windows.Forms.Label();
            this.cmbSelectQuestion = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.editTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(657, 379);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(119, 34);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.select_Click);
            // 
            // lblCurrentVictim
            // 
            this.lblCurrentVictim.AutoSize = true;
            this.lblCurrentVictim.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblCurrentVictim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentVictim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVictim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurrentVictim.Location = new System.Drawing.Point(301, 436);
            this.lblCurrentVictim.Name = "lblCurrentVictim";
            this.lblCurrentVictim.Size = new System.Drawing.Size(129, 28);
            this.lblCurrentVictim.TabIndex = 1;
            this.lblCurrentVictim.Text = "Click Select";
            // 
            // interviewQuestionVictimSelector
            // 
            this.interviewQuestionVictimSelector.AutoSize = true;
            this.interviewQuestionVictimSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interviewQuestionVictimSelector.Location = new System.Drawing.Point(304, 8);
            this.interviewQuestionVictimSelector.Name = "interviewQuestionVictimSelector";
            this.interviewQuestionVictimSelector.Size = new System.Drawing.Size(428, 31);
            this.interviewQuestionVictimSelector.TabIndex = 2;
            this.interviewQuestionVictimSelector.Text = "Interview Question Victim Selector";
            // 
            // lblPoolOfNames
            // 
            this.lblPoolOfNames.AutoSize = true;
            this.lblPoolOfNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoolOfNames.Location = new System.Drawing.Point(80, 121);
            this.lblPoolOfNames.Name = "lblPoolOfNames";
            this.lblPoolOfNames.Size = new System.Drawing.Size(162, 26);
            this.lblPoolOfNames.TabIndex = 3;
            this.lblPoolOfNames.Text = "Pool of Names:";
            // 
            // lvNamePool
            // 
            this.lvNamePool.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvNamePool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNamePool.Location = new System.Drawing.Point(301, 121);
            this.lvNamePool.Name = "lvNamePool";
            this.lvNamePool.Size = new System.Drawing.Size(475, 232);
            this.lvNamePool.TabIndex = 4;
            this.lvNamePool.UseCompatibleStateImageBehavior = false;
            this.lvNamePool.View = System.Windows.Forms.View.List;
            // 
            // lblCurrentVictimLabel
            // 
            this.lblCurrentVictimLabel.AutoSize = true;
            this.lblCurrentVictimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVictimLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCurrentVictimLabel.Location = new System.Drawing.Point(85, 438);
            this.lblCurrentVictimLabel.Name = "lblCurrentVictimLabel";
            this.lblCurrentVictimLabel.Size = new System.Drawing.Size(157, 26);
            this.lblCurrentVictimLabel.TabIndex = 5;
            this.lblCurrentVictimLabel.Text = "Current Victim:";
            // 
            // lblQuestionLabel
            // 
            this.lblQuestionLabel.AutoSize = true;
            this.lblQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionLabel.Location = new System.Drawing.Point(137, 58);
            this.lblQuestionLabel.Name = "lblQuestionLabel";
            this.lblQuestionLabel.Size = new System.Drawing.Size(105, 26);
            this.lblQuestionLabel.TabIndex = 7;
            this.lblQuestionLabel.Text = "Question:";
            // 
            // lblQuestionBox
            // 
            this.lblQuestionBox.AutoSize = true;
            this.lblQuestionBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblQuestionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionBox.Location = new System.Drawing.Point(301, 56);
            this.lblQuestionBox.Name = "lblQuestionBox";
            this.lblQuestionBox.Size = new System.Drawing.Size(129, 28);
            this.lblQuestionBox.TabIndex = 8;
            this.lblQuestionBox.Text = "Click Select";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.editTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 551);
            this.tabControl1.TabIndex = 9;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.lblQuestionBox);
            this.mainTab.Controls.Add(this.lblCurrentVictimLabel);
            this.mainTab.Controls.Add(this.lblQuestionLabel);
            this.mainTab.Controls.Add(this.lblPoolOfNames);
            this.mainTab.Controls.Add(this.lblCurrentVictim);
            this.mainTab.Controls.Add(this.lvNamePool);
            this.mainTab.Controls.Add(this.btnSelect);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(1045, 525);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.lblLastName);
            this.editTab.Controls.Add(this.lblFirstname);
            this.editTab.Controls.Add(this.txtLastName);
            this.editTab.Controls.Add(this.btnAddName);
            this.editTab.Controls.Add(this.btnDeleteName);
            this.editTab.Controls.Add(this.btnUpdateName);
            this.editTab.Controls.Add(this.txtFirstName);
            this.editTab.Controls.Add(this.cmbSelectName);
            this.editTab.Controls.Add(this.lblSelectName);
            this.editTab.Controls.Add(this.txtSelectedQuestion);
            this.editTab.Controls.Add(this.btnAddQuestion);
            this.editTab.Controls.Add(this.btnDeleteQuestion);
            this.editTab.Controls.Add(this.btnUpdateQuestion);
            this.editTab.Controls.Add(this.lblSelectQuestion);
            this.editTab.Controls.Add(this.cmbSelectQuestion);
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(1045, 525);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(91, 345);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 26);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Tag = "";
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(91, 309);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(125, 26);
            this.lblFirstname.TabIndex = 13;
            this.lblFirstname.Tag = "";
            this.lblFirstname.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(239, 348);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 26);
            this.txtLastName.TabIndex = 12;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(239, 396);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 11;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnDeleteName
            // 
            this.btnDeleteName.Location = new System.Drawing.Point(401, 396);
            this.btnDeleteName.Name = "btnDeleteName";
            this.btnDeleteName.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteName.TabIndex = 10;
            this.btnDeleteName.Text = "Delete";
            this.btnDeleteName.UseVisualStyleBackColor = true;
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(320, 396);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateName.TabIndex = 9;
            this.btnUpdateName.Text = "Update";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(239, 309);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 26);
            this.txtFirstName.TabIndex = 8;
            // 
            // cmbSelectName
            // 
            this.cmbSelectName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbSelectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectName.FormattingEnabled = true;
            this.cmbSelectName.Location = new System.Drawing.Point(239, 270);
            this.cmbSelectName.Name = "cmbSelectName";
            this.cmbSelectName.Size = new System.Drawing.Size(237, 24);
            this.cmbSelectName.TabIndex = 7;
            this.cmbSelectName.SelectedIndexChanged += new System.EventHandler(this.cmbSelectName_SelectedIndexChanged);
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectName.Location = new System.Drawing.Point(72, 265);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(144, 26);
            this.lblSelectName.TabIndex = 6;
            this.lblSelectName.Tag = "";
            this.lblSelectName.Text = "Select Name:";
            // 
            // txtSelectedQuestion
            // 
            this.txtSelectedQuestion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSelectedQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedQuestion.Location = new System.Drawing.Point(239, 101);
            this.txtSelectedQuestion.Multiline = true;
            this.txtSelectedQuestion.Name = "txtSelectedQuestion";
            this.txtSelectedQuestion.Size = new System.Drawing.Size(728, 88);
            this.txtSelectedQuestion.TabIndex = 5;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(732, 204);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestion.TabIndex = 4;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(894, 204);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteQuestion.TabIndex = 3;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Location = new System.Drawing.Point(813, 204);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateQuestion.TabIndex = 2;
            this.btnUpdateQuestion.Text = "Update";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            // 
            // lblSelectQuestion
            // 
            this.lblSelectQuestion.AutoSize = true;
            this.lblSelectQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectQuestion.Location = new System.Drawing.Point(44, 56);
            this.lblSelectQuestion.Name = "lblSelectQuestion";
            this.lblSelectQuestion.Size = new System.Drawing.Size(172, 26);
            this.lblSelectQuestion.TabIndex = 1;
            this.lblSelectQuestion.Tag = "";
            this.lblSelectQuestion.Text = "Select Question:";
            // 
            // cmbSelectQuestion
            // 
            this.cmbSelectQuestion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbSelectQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectQuestion.FormattingEnabled = true;
            this.cmbSelectQuestion.Location = new System.Drawing.Point(239, 61);
            this.cmbSelectQuestion.Name = "cmbSelectQuestion";
            this.cmbSelectQuestion.Size = new System.Drawing.Size(728, 24);
            this.cmbSelectQuestion.TabIndex = 0;
            this.cmbSelectQuestion.SelectedIndexChanged += new System.EventHandler(this.cmbSelectQuestion_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 605);
            this.Controls.Add(this.interviewQuestionVictimSelector);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Victim Selector";
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblCurrentVictim;
        private System.Windows.Forms.Label interviewQuestionVictimSelector;
        private System.Windows.Forms.Label lblPoolOfNames;
        private System.Windows.Forms.ListView lvNamePool;
        private System.Windows.Forms.Label lblCurrentVictimLabel;
        private System.Windows.Forms.Label lblQuestionLabel;
        private System.Windows.Forms.Label lblQuestionBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnDeleteName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbSelectName;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.TextBox txtSelectedQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Label lblSelectQuestion;
        private System.Windows.Forms.ComboBox cmbSelectQuestion;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
    }
}

