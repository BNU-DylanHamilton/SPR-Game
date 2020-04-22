namespace Assessment_2
{
    partial class SPR_Game
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
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.computerGroupBox = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.userGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.computerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.userPictureBox);
            this.userGroupBox.Controls.Add(this.rockRadioButton);
            this.userGroupBox.Controls.Add(this.paperRadioButton);
            this.userGroupBox.Controls.Add(this.scissorsRadioButton);
            this.userGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGroupBox.Location = new System.Drawing.Point(96, 50);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(255, 351);
            this.userGroupBox.TabIndex = 0;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "User Choice";
            this.userGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(26, 36);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(201, 122);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 3;
            this.userPictureBox.TabStop = false;
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.Location = new System.Drawing.Point(51, 278);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(77, 29);
            this.rockRadioButton.TabIndex = 2;
            this.rockRadioButton.TabStop = true;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = true;
            this.rockRadioButton.CheckedChanged += new System.EventHandler(this.rockChoice);
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(51, 237);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(85, 29);
            this.paperRadioButton.TabIndex = 1;
            this.paperRadioButton.TabStop = true;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            this.paperRadioButton.CheckedChanged += new System.EventHandler(this.paperChoice);
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Location = new System.Drawing.Point(51, 194);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(108, 29);
            this.scissorsRadioButton.TabIndex = 0;
            this.scissorsRadioButton.TabStop = true;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            this.scissorsRadioButton.CheckedChanged += new System.EventHandler(this.scissorsChoice);
            // 
            // computerGroupBox
            // 
            this.computerGroupBox.Controls.Add(this.playButton);
            this.computerGroupBox.Controls.Add(this.computerPictureBox);
            this.computerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerGroupBox.Location = new System.Drawing.Point(451, 50);
            this.computerGroupBox.Name = "computerGroupBox";
            this.computerGroupBox.Size = new System.Drawing.Size(255, 351);
            this.computerGroupBox.TabIndex = 1;
            this.computerGroupBox.TabStop = false;
            this.computerGroupBox.Text = "Computer Choice";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(61, 246);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(126, 52);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.getComputerChoice);
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(30, 36);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(201, 122);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 4;
            this.computerPictureBox.TabStop = false;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.label2);
            this.resultGroupBox.Controls.Add(this.label1);
            this.resultGroupBox.Controls.Add(this.computerScoreLabel);
            this.resultGroupBox.Controls.Add(this.userScoreLabel);
            this.resultGroupBox.Controls.Add(this.resultsLabel);
            this.resultGroupBox.Controls.Add(this.resultLabel);
            this.resultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGroupBox.Location = new System.Drawing.Point(809, 50);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(255, 293);
            this.resultGroupBox.TabIndex = 1;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computer Score:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Score:";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.Location = new System.Drawing.Point(55, 230);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(136, 36);
            this.computerScoreLabel.TabIndex = 3;
            this.computerScoreLabel.Text = "0";
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.Location = new System.Drawing.Point(55, 146);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(153, 36);
            this.userScoreLabel.TabIndex = 2;
            this.userScoreLabel.Text = "0";
            // 
            // resultsLabel
            // 
            this.resultsLabel.Location = new System.Drawing.Point(18, 53);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(220, 50);
            this.resultsLabel.TabIndex = 1;
            this.resultsLabel.Text = "Results Message";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(32, 53);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(869, 349);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(126, 52);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeForm);
            // 
            // SPR_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 474);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.computerGroupBox);
            this.Controls.Add(this.userGroupBox);
            this.Name = "SPR_Game";
            this.Text = "Scissors Paper Rock Game";
            this.Load += new System.EventHandler(this.startUp);
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.computerGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.GroupBox computerGroupBox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label userScoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

