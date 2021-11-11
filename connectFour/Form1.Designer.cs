
namespace connectFour
{
    partial class connectFourForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameBoardPanel = new System.Windows.Forms.Panel();
            this.col0Button = new System.Windows.Forms.Button();
            this.col1Button = new System.Windows.Forms.Button();
            this.col2Button = new System.Windows.Forms.Button();
            this.col3Button = new System.Windows.Forms.Button();
            this.col4Button = new System.Windows.Forms.Button();
            this.col5Button = new System.Windows.Forms.Button();
            this.col6Button = new System.Windows.Forms.Button();
            this.gameStatusLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.firstStepSettingsBox = new System.Windows.Forms.GroupBox();
            this.botStepRadiobutton = new System.Windows.Forms.RadioButton();
            this.playerStepRadiobutton = new System.Windows.Forms.RadioButton();
            this.firstStepSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.Location = new System.Drawing.Point(265, 166);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(700, 600);
            this.gameBoardPanel.TabIndex = 0;
            this.gameBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameBoardPanel_Paint);
            // 
            // col0Button
            // 
            this.col0Button.Enabled = false;
            this.col0Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col0Button.Location = new System.Drawing.Point(265, 92);
            this.col0Button.Margin = new System.Windows.Forms.Padding(0);
            this.col0Button.Name = "col0Button";
            this.col0Button.Size = new System.Drawing.Size(100, 68);
            this.col0Button.TabIndex = 1;
            this.col0Button.Text = "↓";
            this.col0Button.UseVisualStyleBackColor = true;
            this.col0Button.Click += new System.EventHandler(this.col0Button_Click);
            // 
            // col1Button
            // 
            this.col1Button.Enabled = false;
            this.col1Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col1Button.Location = new System.Drawing.Point(365, 92);
            this.col1Button.Margin = new System.Windows.Forms.Padding(0);
            this.col1Button.Name = "col1Button";
            this.col1Button.Size = new System.Drawing.Size(100, 68);
            this.col1Button.TabIndex = 2;
            this.col1Button.Text = "↓";
            this.col1Button.UseVisualStyleBackColor = true;
            this.col1Button.Click += new System.EventHandler(this.col1Button_Click);
            // 
            // col2Button
            // 
            this.col2Button.Enabled = false;
            this.col2Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col2Button.Location = new System.Drawing.Point(465, 92);
            this.col2Button.Margin = new System.Windows.Forms.Padding(0);
            this.col2Button.Name = "col2Button";
            this.col2Button.Size = new System.Drawing.Size(100, 68);
            this.col2Button.TabIndex = 3;
            this.col2Button.Text = "↓";
            this.col2Button.UseVisualStyleBackColor = true;
            this.col2Button.Click += new System.EventHandler(this.col2Button_Click);
            // 
            // col3Button
            // 
            this.col3Button.Enabled = false;
            this.col3Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col3Button.Location = new System.Drawing.Point(565, 92);
            this.col3Button.Margin = new System.Windows.Forms.Padding(0);
            this.col3Button.Name = "col3Button";
            this.col3Button.Size = new System.Drawing.Size(100, 68);
            this.col3Button.TabIndex = 4;
            this.col3Button.Text = "↓";
            this.col3Button.UseVisualStyleBackColor = true;
            this.col3Button.Click += new System.EventHandler(this.col3Button_Click);
            // 
            // col4Button
            // 
            this.col4Button.Enabled = false;
            this.col4Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col4Button.Location = new System.Drawing.Point(665, 92);
            this.col4Button.Margin = new System.Windows.Forms.Padding(0);
            this.col4Button.Name = "col4Button";
            this.col4Button.Size = new System.Drawing.Size(100, 68);
            this.col4Button.TabIndex = 5;
            this.col4Button.Text = "↓";
            this.col4Button.UseVisualStyleBackColor = true;
            this.col4Button.Click += new System.EventHandler(this.col4Button_Click);
            // 
            // col5Button
            // 
            this.col5Button.Enabled = false;
            this.col5Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col5Button.Location = new System.Drawing.Point(765, 92);
            this.col5Button.Margin = new System.Windows.Forms.Padding(0);
            this.col5Button.Name = "col5Button";
            this.col5Button.Size = new System.Drawing.Size(100, 68);
            this.col5Button.TabIndex = 6;
            this.col5Button.Text = "↓";
            this.col5Button.UseVisualStyleBackColor = true;
            this.col5Button.Click += new System.EventHandler(this.col5Button_Click);
            // 
            // col6Button
            // 
            this.col6Button.Enabled = false;
            this.col6Button.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.col6Button.Location = new System.Drawing.Point(865, 92);
            this.col6Button.Margin = new System.Windows.Forms.Padding(0);
            this.col6Button.Name = "col6Button";
            this.col6Button.Size = new System.Drawing.Size(100, 68);
            this.col6Button.TabIndex = 7;
            this.col6Button.Text = "↓";
            this.col6Button.UseVisualStyleBackColor = true;
            this.col6Button.Click += new System.EventHandler(this.col6Button_Click);
            // 
            // gameStatusLabel
            // 
            this.gameStatusLabel.AutoSize = true;
            this.gameStatusLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameStatusLabel.Location = new System.Drawing.Point(539, 28);
            this.gameStatusLabel.Name = "gameStatusLabel";
            this.gameStatusLabel.Size = new System.Drawing.Size(150, 32);
            this.gameStatusLabel.TabIndex = 8;
            this.gameStatusLabel.Text = "Press Start!";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(43, 178);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(150, 46);
            this.restartButton.TabIndex = 9;
            this.restartButton.Text = "Start";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // firstStepSettingsBox
            // 
            this.firstStepSettingsBox.Controls.Add(this.botStepRadiobutton);
            this.firstStepSettingsBox.Controls.Add(this.playerStepRadiobutton);
            this.firstStepSettingsBox.Location = new System.Drawing.Point(12, 12);
            this.firstStepSettingsBox.Name = "firstStepSettingsBox";
            this.firstStepSettingsBox.Size = new System.Drawing.Size(216, 148);
            this.firstStepSettingsBox.TabIndex = 10;
            this.firstStepSettingsBox.TabStop = false;
            this.firstStepSettingsBox.Text = "First Step";
            // 
            // botStepRadiobutton
            // 
            this.botStepRadiobutton.AutoSize = true;
            this.botStepRadiobutton.Location = new System.Drawing.Point(16, 80);
            this.botStepRadiobutton.Name = "botStepRadiobutton";
            this.botStepRadiobutton.Size = new System.Drawing.Size(81, 36);
            this.botStepRadiobutton.TabIndex = 1;
            this.botStepRadiobutton.Text = "Bot";
            this.botStepRadiobutton.UseVisualStyleBackColor = true;
            this.botStepRadiobutton.CheckedChanged += new System.EventHandler(this.botStepRadiobutton_CheckedChanged);
            // 
            // playerStepRadiobutton
            // 
            this.playerStepRadiobutton.AutoSize = true;
            this.playerStepRadiobutton.Checked = true;
            this.playerStepRadiobutton.Location = new System.Drawing.Point(16, 38);
            this.playerStepRadiobutton.Name = "playerStepRadiobutton";
            this.playerStepRadiobutton.Size = new System.Drawing.Size(109, 36);
            this.playerStepRadiobutton.TabIndex = 0;
            this.playerStepRadiobutton.TabStop = true;
            this.playerStepRadiobutton.Text = "Player";
            this.playerStepRadiobutton.UseVisualStyleBackColor = true;
            this.playerStepRadiobutton.CheckedChanged += new System.EventHandler(this.playerStepRadiobutton_CheckedChanged);
            // 
            // connectFourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 787);
            this.Controls.Add(this.firstStepSettingsBox);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.gameStatusLabel);
            this.Controls.Add(this.col6Button);
            this.Controls.Add(this.col5Button);
            this.Controls.Add(this.col4Button);
            this.Controls.Add(this.col3Button);
            this.Controls.Add(this.col2Button);
            this.Controls.Add(this.col1Button);
            this.Controls.Add(this.col0Button);
            this.Controls.Add(this.gameBoardPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "connectFourForm";
            this.Text = "Connect Four";
            this.Shown += new System.EventHandler(this.connectFourForm_Shown);
            this.firstStepSettingsBox.ResumeLayout(false);
            this.firstStepSettingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameBoardPanel;
        private System.Windows.Forms.Button col0Button;
        private System.Windows.Forms.Button col1Button;
        private System.Windows.Forms.Button col2Button;
        private System.Windows.Forms.Button col3Button;
        private System.Windows.Forms.Button col4Button;
        private System.Windows.Forms.Button col5Button;
        private System.Windows.Forms.Button col6Button;
        private System.Windows.Forms.Label gameStatusLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.GroupBox firstStepSettingsBox;
        private System.Windows.Forms.RadioButton botStepRadiobutton;
        private System.Windows.Forms.RadioButton playerStepRadiobutton;
    }
}

