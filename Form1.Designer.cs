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
            performanceLogLabel = new Label();
            coreThreadInformationLabel = new Label();
            SuspendLayout();
            // 
            // generatePassword
            // 
            generatePassword.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generatePassword.Location = new Point(574, 571);
            generatePassword.Margin = new Padding(4);
            generatePassword.Name = "generatePassword";
            generatePassword.Size = new Size(298, 65);
            generatePassword.TabIndex = 0;
            generatePassword.Text = "Create Password";
            generatePassword.UseVisualStyleBackColor = true;
            generatePassword.Click += generatePassword_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(245, 461);
            progressBar1.Margin = new Padding(4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(940, 60);
            progressBar1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(453, 192);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 68);
            panel1.TabIndex = 2;
            // 
            // hashedPassword
            // 
            hashedPassword.AutoSize = true;
            hashedPassword.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hashedPassword.Location = new Point(692, 209);
            hashedPassword.Margin = new Padding(4, 0, 4, 0);
            hashedPassword.Name = "hashedPassword";
            hashedPassword.Size = new Size(105, 14);
            hashedPassword.TabIndex = 3;
            hashedPassword.Text = "hashedPassword";
            // 
            // startBruteforceInitial
            // 
            startBruteforceInitial.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startBruteforceInitial.Location = new Point(923, 571);
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
            stopAttemptButton.Location = new Point(923, 661);
            stopAttemptButton.Margin = new Padding(4);
            stopAttemptButton.Name = "stopAttemptButton";
            stopAttemptButton.Size = new Size(292, 80);
            stopAttemptButton.TabIndex = 6;
            stopAttemptButton.Text = "Stop ";
            stopAttemptButton.UseVisualStyleBackColor = true;
            stopAttemptButton.Click += stopAttemptButton_Click;
            // 
            // passwordCracked
            // 
            passwordCracked.AutoSize = true;
            passwordCracked.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordCracked.Location = new Point(672, 372);
            passwordCracked.Margin = new Padding(4, 0, 4, 0);
            passwordCracked.Name = "passwordCracked";
            passwordCracked.Size = new Size(150, 22);
            passwordCracked.TabIndex = 3;
            passwordCracked.Text = "Final Password";
            // 
            // panel2
            // 
            panel2.Location = new Point(453, 356);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 68);
            panel2.TabIndex = 4;
            // 
            // timeElapsed
            // 
            timeElapsed.AutoSize = true;
            timeElapsed.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeElapsed.Location = new Point(669, 428);
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
            attemptText.Location = new Point(574, 525);
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
            label1.Location = new Point(542, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 37);
            label1.TabIndex = 4;
            label1.Text = "Brute Force Simulator";
            // 
            // passwordLowercaseSelect
            // 
            passwordLowercaseSelect.AutoSize = true;
            passwordLowercaseSelect.Location = new Point(245, 571);
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
            passwordLowerUpperSelect.Location = new Point(245, 600);
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
            passwordLowerUpperNumSelect.Location = new Point(245, 629);
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
            passwordLowerUpperNumSymbolsSelect.Location = new Point(245, 658);
            passwordLowerUpperNumSymbolsSelect.Name = "passwordLowerUpperNumSymbolsSelect";
            passwordLowerUpperNumSymbolsSelect.Size = new Size(369, 23);
            passwordLowerUpperNumSymbolsSelect.TabIndex = 10;
            passwordLowerUpperNumSymbolsSelect.TabStop = true;
            passwordLowerUpperNumSymbolsSelect.Text = "Lowercase, Uppercase, Numbers, Symbols";
            passwordLowerUpperNumSymbolsSelect.UseVisualStyleBackColor = true;
            // 
            // performanceTestButton
            // 
            performanceTestButton.Location = new Point(1267, 571);
            performanceTestButton.Name = "performanceTestButton";
            performanceTestButton.Size = new Size(145, 33);
            performanceTestButton.TabIndex = 11;
            performanceTestButton.Text = "Performance";
            performanceTestButton.UseVisualStyleBackColor = true;
            performanceTestButton.Click += performanceTestButton_Click;
            // 
            // performanceLogLabel
            // 
            performanceLogLabel.Location = new Point(12, 63);
            performanceLogLabel.Name = "performanceLogLabel";
            performanceLogLabel.Size = new Size(385, 384);
            performanceLogLabel.TabIndex = 0;
            performanceLogLabel.Text = "Performance";
            // 
            // coreThreadInformationLabel
            // 
            coreThreadInformationLabel.AutoSize = true;
            coreThreadInformationLabel.Location = new Point(1196, 38);
            coreThreadInformationLabel.Name = "coreThreadInformationLabel";
            coreThreadInformationLabel.Size = new Size(216, 50);
            coreThreadInformationLabel.TabIndex = 12;
            coreThreadInformationLabel.Text = "Core Thread Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1447, 857);
            Controls.Add(coreThreadInformationLabel);
            Controls.Add(hashedPassword);
            Controls.Add(timeElapsed);
            Controls.Add(performanceLogLabel);
            Controls.Add(passwordCracked);
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
        private Label performanceLogLabel;
        private Label coreThreadInformationLabel;
    }
}
