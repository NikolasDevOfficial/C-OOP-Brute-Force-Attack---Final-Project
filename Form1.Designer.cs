namespace CsharpBruteForceFinal
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
            generatePassword = new Button();
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            hashedPassword = new Label();
            startBruteforceInitial = new Button();
            stopAttemptButton = new Button();
            passwordCracked = new Label();
            panel2 = new Panel();
            timeElapsed = new Label();
            attemptText = new Label();
            label1 = new Label();
            passwordLowercaseSelect = new RadioButton();
            passwordLowerUpperSelect = new RadioButton();
            passwordLowerUpperNumSelect = new RadioButton();
            passwordLowerUpperNumSymbolsSelect = new RadioButton();
            performanceTestButton = new Button();
            performanceLogTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // generatePassword
            // 
            generatePassword.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generatePassword.Location = new Point(454, 389);
            generatePassword.Margin = new Padding(4);
            generatePassword.Name = "generatePassword";
            generatePassword.Size = new Size(113, 100);
            generatePassword.TabIndex = 0;
            generatePassword.Text = "Create Password";
            generatePassword.UseVisualStyleBackColor = true;
            generatePassword.Click += generatePassword_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(46, 275);
            progressBar1.Margin = new Padding(4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(940, 60);
            progressBar1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(hashedPassword);
            panel1.Location = new Point(222, 60);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 68);
            panel1.TabIndex = 2;
            // 
            // hashedPassword
            // 
            hashedPassword.AutoSize = true;
            hashedPassword.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hashedPassword.Location = new Point(243, 24);
            hashedPassword.Margin = new Padding(4, 0, 4, 0);
            hashedPassword.Name = "hashedPassword";
            hashedPassword.Size = new Size(105, 14);
            hashedPassword.TabIndex = 3;
            hashedPassword.Text = "hashedPassword";
            // 
            // startBruteforceInitial
            // 
            startBruteforceInitial.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startBruteforceInitial.Location = new Point(586, 492);
            startBruteforceInitial.Margin = new Padding(4);
            startBruteforceInitial.Name = "startBruteforceInitial";
            startBruteforceInitial.Size = new Size(292, 65);
            startBruteforceInitial.TabIndex = 4;
            startBruteforceInitial.Text = "Start Brute Force";
            startBruteforceInitial.UseVisualStyleBackColor = true;
            startBruteforceInitial.Click += startBruteforceInitial_Click;
            // 
            // stopAttemptButton
            // 
            stopAttemptButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stopAttemptButton.Location = new Point(626, 389);
            stopAttemptButton.Margin = new Padding(4);
            stopAttemptButton.Name = "stopAttemptButton";
            stopAttemptButton.Size = new Size(252, 80);
            stopAttemptButton.TabIndex = 6;
            stopAttemptButton.Text = "Stop ";
            stopAttemptButton.UseVisualStyleBackColor = true;
            stopAttemptButton.Click += stopAttemptButton_Click;
            // 
            // passwordCracked
            // 
            passwordCracked.AutoSize = true;
            passwordCracked.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordCracked.Location = new Point(222, 17);
            passwordCracked.Margin = new Padding(4, 0, 4, 0);
            passwordCracked.Name = "passwordCracked";
            passwordCracked.Size = new Size(150, 22);
            passwordCracked.TabIndex = 3;
            passwordCracked.Text = "Final Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(timeElapsed);
            panel2.Controls.Add(passwordCracked);
            panel2.Location = new Point(222, 199);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 68);
            panel2.TabIndex = 4;
            // 
            // timeElapsed
            // 
            timeElapsed.AutoSize = true;
            timeElapsed.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeElapsed.Location = new Point(219, 39);
            timeElapsed.Margin = new Padding(4, 0, 4, 0);
            timeElapsed.Name = "timeElapsed";
            timeElapsed.Size = new Size(153, 19);
            timeElapsed.TabIndex = 7;
            timeElapsed.Text = "Time since start";
            // 
            // attemptText
            // 
            attemptText.AutoSize = true;
            attemptText.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attemptText.Location = new Point(480, 351);
            attemptText.Margin = new Padding(4, 0, 4, 0);
            attemptText.Name = "attemptText";
            attemptText.Size = new Size(90, 19);
            attemptText.TabIndex = 4;
            attemptText.Text = "Attempts:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(317, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 37);
            label1.TabIndex = 4;
            label1.Text = "Brute Force Simulator";
            // 
            // passwordLowercaseSelect
            // 
            passwordLowercaseSelect.AutoSize = true;
            passwordLowercaseSelect.Location = new Point(80, 379);
            passwordLowercaseSelect.Name = "passwordLowercaseSelect";
            passwordLowercaseSelect.Size = new Size(180, 23);
            passwordLowercaseSelect.TabIndex = 7;
            passwordLowercaseSelect.TabStop = true;
            passwordLowercaseSelect.Text = "Lowercase letters";
            passwordLowercaseSelect.UseVisualStyleBackColor = true;
            // 
            // passwordLowerUpperSelect
            // 
            passwordLowerUpperSelect.AutoSize = true;
            passwordLowerUpperSelect.Location = new Point(80, 408);
            passwordLowerUpperSelect.Name = "passwordLowerUpperSelect";
            passwordLowerUpperSelect.Size = new Size(279, 23);
            passwordLowerUpperSelect.TabIndex = 8;
            passwordLowerUpperSelect.TabStop = true;
            passwordLowerUpperSelect.Text = "Lowercase, Uppercase letters";
            passwordLowerUpperSelect.UseVisualStyleBackColor = true;
            // 
            // passwordLowerUpperNumSelect
            // 
            passwordLowerUpperNumSelect.AutoSize = true;
            passwordLowerUpperNumSelect.Location = new Point(80, 437);
            passwordLowerUpperNumSelect.Name = "passwordLowerUpperNumSelect";
            passwordLowerUpperNumSelect.Size = new Size(288, 23);
            passwordLowerUpperNumSelect.TabIndex = 9;
            passwordLowerUpperNumSelect.TabStop = true;
            passwordLowerUpperNumSelect.Text = "Lowercase, Uppercase, Numbers";
            passwordLowerUpperNumSelect.UseVisualStyleBackColor = true;
            // 
            // passwordLowerUpperNumSymbolsSelect
            // 
            passwordLowerUpperNumSymbolsSelect.AutoSize = true;
            passwordLowerUpperNumSymbolsSelect.Location = new Point(80, 466);
            passwordLowerUpperNumSymbolsSelect.Name = "passwordLowerUpperNumSymbolsSelect";
            passwordLowerUpperNumSymbolsSelect.Size = new Size(369, 23);
            passwordLowerUpperNumSymbolsSelect.TabIndex = 10;
            passwordLowerUpperNumSymbolsSelect.TabStop = true;
            passwordLowerUpperNumSymbolsSelect.Text = "Lowercase, Uppercase, Numbers, Symbols";
            passwordLowerUpperNumSymbolsSelect.UseVisualStyleBackColor = true;
            // 
            // performanceTestButton
            // 
            performanceTestButton.Location = new Point(841, 60);
            performanceTestButton.Name = "performanceTestButton";
            performanceTestButton.Size = new Size(145, 24);
            performanceTestButton.TabIndex = 11;
            performanceTestButton.Text = "Performance";
            performanceTestButton.UseVisualStyleBackColor = true;
            // 
            // performanceLogTextBox
            // 
            performanceLogTextBox.Location = new Point(846, 145);
            performanceLogTextBox.Name = "performanceLogTextBox";
            performanceLogTextBox.Size = new Size(140, 26);
            performanceLogTextBox.TabIndex = 12;
            performanceLogTextBox.Text = "Performance Log";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1029, 570);
            Controls.Add(performanceLogTextBox);
            Controls.Add(performanceTestButton);
            Controls.Add(passwordLowerUpperNumSymbolsSelect);
            Controls.Add(passwordLowerUpperNumSelect);
            Controls.Add(passwordLowerUpperSelect);
            Controls.Add(passwordLowercaseSelect);
            Controls.Add(label1);
            Controls.Add(attemptText);
            Controls.Add(panel2);
            Controls.Add(stopAttemptButton);
            Controls.Add(startBruteforceInitial);
            Controls.Add(panel1);
            Controls.Add(progressBar1);
            Controls.Add(generatePassword);
            Cursor = Cursors.PanNorth;
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Red;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Brute Force Simulator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generatePassword;
        private ProgressBar progressBar1;
        private Panel panel1;
        private Label hashedPassword;
        private Button startBruteforceInitial;
        private Button stopAttemptButton;
        private Label passwordCracked;
        private Panel panel2;
        private Label timeElapsed;
        private Label attemptText;
        private Label label1;
        private RadioButton passwordLowercaseSelect;
        private RadioButton passwordLowerUpperSelect;
        private RadioButton passwordLowerUpperNumSelect;
        private RadioButton passwordLowerUpperNumSymbolsSelect;
        private Button performanceTestButton;
        private TextBox performanceLogTextBox;
    }
}
