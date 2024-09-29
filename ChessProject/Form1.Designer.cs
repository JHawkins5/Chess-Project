
namespace ChessProject
{
    partial class Form1
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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.WhiteTakenListBox = new System.Windows.Forms.ListBox();
            this.BlackTakenListBox = new System.Windows.Forms.ListBox();
            this.BlackTimer = new System.Windows.Forms.Label();
            this.WhiteTimer = new System.Windows.Forms.Label();
            this.SetTimerButton = new System.Windows.Forms.Button();
            this.OneMinRadioButton = new System.Windows.Forms.RadioButton();
            this.FiveMinRadioButton = new System.Windows.Forms.RadioButton();
            this.TenMinRadioButton = new System.Windows.Forms.RadioButton();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.PauseGameButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.OnePlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.TwoPlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.ModeGroupBox = new System.Windows.Forms.GroupBox();
            this.SetModeButton = new System.Windows.Forms.Button();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CurrentXTextBox = new System.Windows.Forms.TextBox();
            this.CurrentYTextBox = new System.Windows.Forms.TextBox();
            this.NewXTextBox = new System.Windows.Forms.TextBox();
            this.NewYTextBox = new System.Windows.Forms.TextBox();
            this.CurrentXLabel = new System.Windows.Forms.Label();
            this.CurrentYLabel = new System.Windows.Forms.Label();
            this.NewXLabel = new System.Windows.Forms.Label();
            this.NewYLabel = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.StateOfGameLabel = new System.Windows.Forms.Label();
            this.TimeGroupBox.SuspendLayout();
            this.ModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(1533, 345);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(162, 62);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Enabled = false;
            this.SaveGameButton.Location = new System.Drawing.Point(1533, 423);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(162, 62);
            this.SaveGameButton.TabIndex = 1;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Location = new System.Drawing.Point(1533, 501);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(162, 62);
            this.LoadGameButton.TabIndex = 2;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
            // 
            // WhiteTakenListBox
            // 
            this.WhiteTakenListBox.FormattingEnabled = true;
            this.WhiteTakenListBox.ItemHeight = 32;
            this.WhiteTakenListBox.Location = new System.Drawing.Point(1494, 110);
            this.WhiteTakenListBox.Name = "WhiteTakenListBox";
            this.WhiteTakenListBox.Size = new System.Drawing.Size(240, 228);
            this.WhiteTakenListBox.TabIndex = 3;
            // 
            // BlackTakenListBox
            // 
            this.BlackTakenListBox.FormattingEnabled = true;
            this.BlackTakenListBox.ItemHeight = 32;
            this.BlackTakenListBox.Location = new System.Drawing.Point(1494, 836);
            this.BlackTakenListBox.Name = "BlackTakenListBox";
            this.BlackTakenListBox.Size = new System.Drawing.Size(240, 228);
            this.BlackTakenListBox.TabIndex = 4;
            // 
            // BlackTimer
            // 
            this.BlackTimer.AutoSize = true;
            this.BlackTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BlackTimer.Location = new System.Drawing.Point(1352, 118);
            this.BlackTimer.Name = "BlackTimer";
            this.BlackTimer.Size = new System.Drawing.Size(63, 32);
            this.BlackTimer.TabIndex = 5;
            this.BlackTimer.Text = "0:00";
            this.BlackTimer.Visible = false;
            // 
            // WhiteTimer
            // 
            this.WhiteTimer.AutoSize = true;
            this.WhiteTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WhiteTimer.Location = new System.Drawing.Point(1352, 836);
            this.WhiteTimer.Name = "WhiteTimer";
            this.WhiteTimer.Size = new System.Drawing.Size(63, 32);
            this.WhiteTimer.TabIndex = 6;
            this.WhiteTimer.Text = "0:00";
            this.WhiteTimer.Visible = false;
            // 
            // SetTimerButton
            // 
            this.SetTimerButton.Enabled = false;
            this.SetTimerButton.Location = new System.Drawing.Point(1533, 577);
            this.SetTimerButton.Name = "SetTimerButton";
            this.SetTimerButton.Size = new System.Drawing.Size(162, 62);
            this.SetTimerButton.TabIndex = 7;
            this.SetTimerButton.Text = "Set Timer";
            this.SetTimerButton.UseVisualStyleBackColor = true;
            this.SetTimerButton.Click += new System.EventHandler(this.SetTimerButton_Click);
            // 
            // OneMinRadioButton
            // 
            this.OneMinRadioButton.AutoSize = true;
            this.OneMinRadioButton.Enabled = false;
            this.OneMinRadioButton.Location = new System.Drawing.Point(21, 56);
            this.OneMinRadioButton.Name = "OneMinRadioButton";
            this.OneMinRadioButton.Size = new System.Drawing.Size(89, 36);
            this.OneMinRadioButton.TabIndex = 8;
            this.OneMinRadioButton.TabStop = true;
            this.OneMinRadioButton.Text = "1:00";
            this.OneMinRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiveMinRadioButton
            // 
            this.FiveMinRadioButton.AutoSize = true;
            this.FiveMinRadioButton.Enabled = false;
            this.FiveMinRadioButton.Location = new System.Drawing.Point(21, 98);
            this.FiveMinRadioButton.Name = "FiveMinRadioButton";
            this.FiveMinRadioButton.Size = new System.Drawing.Size(89, 36);
            this.FiveMinRadioButton.TabIndex = 9;
            this.FiveMinRadioButton.TabStop = true;
            this.FiveMinRadioButton.Text = "5:00";
            this.FiveMinRadioButton.UseVisualStyleBackColor = true;
            // 
            // TenMinRadioButton
            // 
            this.TenMinRadioButton.AutoSize = true;
            this.TenMinRadioButton.Enabled = false;
            this.TenMinRadioButton.Location = new System.Drawing.Point(21, 140);
            this.TenMinRadioButton.Name = "TenMinRadioButton";
            this.TenMinRadioButton.Size = new System.Drawing.Size(102, 36);
            this.TenMinRadioButton.TabIndex = 10;
            this.TenMinRadioButton.TabStop = true;
            this.TenMinRadioButton.Text = "10:00";
            this.TenMinRadioButton.UseVisualStyleBackColor = true;
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.TenMinRadioButton);
            this.TimeGroupBox.Controls.Add(this.FiveMinRadioButton);
            this.TimeGroupBox.Controls.Add(this.OneMinRadioButton);
            this.TimeGroupBox.Enabled = false;
            this.TimeGroupBox.Location = new System.Drawing.Point(1533, 645);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(156, 180);
            this.TimeGroupBox.TabIndex = 11;
            this.TimeGroupBox.TabStop = false;
            this.TimeGroupBox.Text = "Select Time";
            // 
            // PauseGameButton
            // 
            this.PauseGameButton.Enabled = false;
            this.PauseGameButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PauseGameButton.Location = new System.Drawing.Point(1554, 47);
            this.PauseGameButton.Name = "PauseGameButton";
            this.PauseGameButton.Size = new System.Drawing.Size(50, 42);
            this.PauseGameButton.TabIndex = 12;
            this.PauseGameButton.Text = "||";
            this.PauseGameButton.UseVisualStyleBackColor = true;
            this.PauseGameButton.Click += new System.EventHandler(this.PauseGameButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Enabled = false;
            this.StartGameButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGameButton.Location = new System.Drawing.Point(1494, 47);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(50, 42);
            this.StartGameButton.TabIndex = 13;
            this.StartGameButton.Text = ">";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // OnePlayerRadioButton
            // 
            this.OnePlayerRadioButton.AutoSize = true;
            this.OnePlayerRadioButton.Location = new System.Drawing.Point(6, 50);
            this.OnePlayerRadioButton.Name = "OnePlayerRadioButton";
            this.OnePlayerRadioButton.Size = new System.Drawing.Size(161, 36);
            this.OnePlayerRadioButton.TabIndex = 14;
            this.OnePlayerRadioButton.TabStop = true;
            this.OnePlayerRadioButton.Text = "One Player";
            this.OnePlayerRadioButton.UseVisualStyleBackColor = true;
            // 
            // TwoPlayerRadioButton
            // 
            this.TwoPlayerRadioButton.AutoSize = true;
            this.TwoPlayerRadioButton.Location = new System.Drawing.Point(6, 101);
            this.TwoPlayerRadioButton.Name = "TwoPlayerRadioButton";
            this.TwoPlayerRadioButton.Size = new System.Drawing.Size(159, 36);
            this.TwoPlayerRadioButton.TabIndex = 15;
            this.TwoPlayerRadioButton.TabStop = true;
            this.TwoPlayerRadioButton.Text = "Two Player";
            this.TwoPlayerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ModeGroupBox
            // 
            this.ModeGroupBox.Controls.Add(this.TwoPlayerRadioButton);
            this.ModeGroupBox.Controls.Add(this.OnePlayerRadioButton);
            this.ModeGroupBox.Enabled = false;
            this.ModeGroupBox.Location = new System.Drawing.Point(1337, 423);
            this.ModeGroupBox.Name = "ModeGroupBox";
            this.ModeGroupBox.Size = new System.Drawing.Size(190, 145);
            this.ModeGroupBox.TabIndex = 16;
            this.ModeGroupBox.TabStop = false;
            this.ModeGroupBox.Text = "Mode";
            // 
            // SetModeButton
            // 
            this.SetModeButton.Enabled = false;
            this.SetModeButton.Location = new System.Drawing.Point(1352, 577);
            this.SetModeButton.Name = "SetModeButton";
            this.SetModeButton.Size = new System.Drawing.Size(162, 62);
            this.SetModeButton.TabIndex = 17;
            this.SetModeButton.Text = "Set Mode";
            this.SetModeButton.UseVisualStyleBackColor = true;
            this.SetModeButton.Click += new System.EventHandler(this.SetModeButton_Click);
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.Location = new System.Drawing.Point(1320, 1067);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(180, 32);
            this.MoveLabel.TabIndex = 18;
            this.MoveLabel.Text = "No move made";
            this.MoveLabel.Visible = false;
            // 
            // MoveButton
            // 
            this.MoveButton.Enabled = false;
            this.MoveButton.Location = new System.Drawing.Point(1493, 1102);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(150, 46);
            this.MoveButton.TabIndex = 19;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // CurrentXTextBox
            // 
            this.CurrentXTextBox.Enabled = false;
            this.CurrentXTextBox.Location = new System.Drawing.Point(1321, 1189);
            this.CurrentXTextBox.Name = "CurrentXTextBox";
            this.CurrentXTextBox.Size = new System.Drawing.Size(200, 39);
            this.CurrentXTextBox.TabIndex = 20;
            // 
            // CurrentYTextBox
            // 
            this.CurrentYTextBox.Enabled = false;
            this.CurrentYTextBox.Location = new System.Drawing.Point(1560, 1189);
            this.CurrentYTextBox.Name = "CurrentYTextBox";
            this.CurrentYTextBox.Size = new System.Drawing.Size(200, 39);
            this.CurrentYTextBox.TabIndex = 21;
            // 
            // NewXTextBox
            // 
            this.NewXTextBox.Enabled = false;
            this.NewXTextBox.Location = new System.Drawing.Point(1321, 1269);
            this.NewXTextBox.Name = "NewXTextBox";
            this.NewXTextBox.Size = new System.Drawing.Size(200, 39);
            this.NewXTextBox.TabIndex = 22;
            // 
            // NewYTextBox
            // 
            this.NewYTextBox.Enabled = false;
            this.NewYTextBox.Location = new System.Drawing.Point(1560, 1269);
            this.NewYTextBox.Name = "NewYTextBox";
            this.NewYTextBox.Size = new System.Drawing.Size(200, 39);
            this.NewYTextBox.TabIndex = 23;
            // 
            // CurrentXLabel
            // 
            this.CurrentXLabel.AutoSize = true;
            this.CurrentXLabel.Location = new System.Drawing.Point(1321, 1151);
            this.CurrentXLabel.Name = "CurrentXLabel";
            this.CurrentXLabel.Size = new System.Drawing.Size(211, 32);
            this.CurrentXLabel.TabIndex = 24;
            this.CurrentXLabel.Text = "Current x-ordinate";
            // 
            // CurrentYLabel
            // 
            this.CurrentYLabel.AutoSize = true;
            this.CurrentYLabel.Location = new System.Drawing.Point(1565, 1151);
            this.CurrentYLabel.Name = "CurrentYLabel";
            this.CurrentYLabel.Size = new System.Drawing.Size(212, 32);
            this.CurrentYLabel.TabIndex = 25;
            this.CurrentYLabel.Text = "Current y-ordinate";
            // 
            // NewXLabel
            // 
            this.NewXLabel.AutoSize = true;
            this.NewXLabel.Location = new System.Drawing.Point(1321, 1234);
            this.NewXLabel.Name = "NewXLabel";
            this.NewXLabel.Size = new System.Drawing.Size(179, 32);
            this.NewXLabel.TabIndex = 26;
            this.NewXLabel.Text = "New x-ordinate";
            // 
            // NewYLabel
            // 
            this.NewYLabel.AutoSize = true;
            this.NewYLabel.Location = new System.Drawing.Point(1565, 1234);
            this.NewYLabel.Name = "NewYLabel";
            this.NewYLabel.Size = new System.Drawing.Size(180, 32);
            this.NewYLabel.TabIndex = 27;
            this.NewYLabel.Text = "New y-ordinate";
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnLabel.Location = new System.Drawing.Point(255, 13);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(339, 71);
            this.TurnLabel.TabIndex = 28;
            this.TurnLabel.Text = "White\'s Turn";
            this.TurnLabel.Visible = false;
            // 
            // StateOfGameLabel
            // 
            this.StateOfGameLabel.AutoSize = true;
            this.StateOfGameLabel.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StateOfGameLabel.Location = new System.Drawing.Point(628, 13);
            this.StateOfGameLabel.Name = "StateOfGameLabel";
            this.StateOfGameLabel.Size = new System.Drawing.Size(136, 71);
            this.StateOfGameLabel.TabIndex = 29;
            this.StateOfGameLabel.Text = "Play";
            this.StateOfGameLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1336);
            this.Controls.Add(this.StateOfGameLabel);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.NewYLabel);
            this.Controls.Add(this.NewXLabel);
            this.Controls.Add(this.CurrentYLabel);
            this.Controls.Add(this.CurrentXLabel);
            this.Controls.Add(this.NewYTextBox);
            this.Controls.Add(this.NewXTextBox);
            this.Controls.Add(this.CurrentYTextBox);
            this.Controls.Add(this.CurrentXTextBox);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.MoveLabel);
            this.Controls.Add(this.SetModeButton);
            this.Controls.Add(this.ModeGroupBox);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.PauseGameButton);
            this.Controls.Add(this.TimeGroupBox);
            this.Controls.Add(this.SetTimerButton);
            this.Controls.Add(this.WhiteTimer);
            this.Controls.Add(this.BlackTimer);
            this.Controls.Add(this.BlackTakenListBox);
            this.Controls.Add(this.WhiteTakenListBox);
            this.Controls.Add(this.LoadGameButton);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.NewGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ModeGroupBox.ResumeLayout(false);
            this.ModeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.ListBox WhiteTakenListBox;
        private System.Windows.Forms.ListBox BlackTakenListBox;
        private System.Windows.Forms.Label BlackTimer;
        private System.Windows.Forms.Label WhiteTimer;
        private System.Windows.Forms.Button SetTimerButton;
        private System.Windows.Forms.RadioButton OneMinRadioButton;
        private System.Windows.Forms.RadioButton FiveMinRadioButton;
        private System.Windows.Forms.RadioButton TenMinRadioButton;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.Button PauseGameButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.RadioButton OnePlayerRadioButton;
        private System.Windows.Forms.RadioButton TwoPlayerRadioButton;
        private System.Windows.Forms.GroupBox ModeGroupBox;
        private System.Windows.Forms.Button SetModeButton;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.TextBox CurrentXTextBox;
        private System.Windows.Forms.TextBox CurrentYTextBox;
        private System.Windows.Forms.TextBox NewXTextBox;
        private System.Windows.Forms.TextBox NewYTextBox;
        private System.Windows.Forms.Label CurrentXLabel;
        private System.Windows.Forms.Label CurrentYLabel;
        private System.Windows.Forms.Label NewXLabel;
        private System.Windows.Forms.Label NewYLabel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Label StateOfGameLabel;
    }
}

