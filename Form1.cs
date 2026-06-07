namespace CsharpBruteForceFinal
{
    public partial class Form1 : Form
    {
        private BruteForceProgram _bruteForceProgram;
        private DateTime _startTime;
        //private long _latestAttempts;
        //private int _latestProgress;
        //private System.Windows.Forms.Timer _uiTimer;
        public Form1()
        {
            InitializeComponent();
        
        }


        private void generatePassword_Click(object sender, EventArgs e)
        {
            var generator = new passwordGenerator();
            string password = "";

            generatePassword.Enabled = passwordLowercaseSelect.Checked ||
                      passwordLowerUpperSelect.Checked ||
                      passwordLowerUpperNumSelect.Checked ||
                     passwordLowerUpperNumSymbolsSelect.Checked;

            if (passwordLowercaseSelect.Checked)
            {
                password = generator.RandomPasswordGeneratorLowercaseOnly();
            }
            else if (passwordLowerUpperSelect.Checked)
            {
                password = generator.RandomPasswordGeneratorLowerUppercase();

            }
            else if (passwordLowerUpperNumSelect.Checked)
            {
                password = generator.RandomPasswordGeneratorLowerUpperNumbers();

            }
            else if (passwordLowerUpperNumSymbolsSelect.Checked)
            {
                password = generator.RandomPasswordGeneratorLowerUpperNumSymbols();

            }
            var targetPassword = password;
            var unhashedPassword = password;

            byte[] hash = PasswordHashSalt.ComputeSHA256Hash(targetPassword);

            string hashedPasswordFinal= BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
  
            hashedPassword.Text = $"Unhashed: {unhashedPassword}\n Hashed version: {hashedPasswordFinal}";
        }
        private void startBruteforceInitial_Click(object sender, EventArgs e)
        {
            // Determine which character set to use based on the selected radio button
            string chars = "";

            if (passwordLowercaseSelect.Checked)
            {
                chars = "abcdefghijklmnopqrstuvwxyz";
            }
            else if (passwordLowerUpperSelect.Checked)
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            else if (passwordLowerUpperNumSelect.Checked)
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            }
            else if (passwordLowerUpperNumSymbolsSelect.Checked)
            {
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~!@#$%^&*()_+=-`";
            }
            else
            {
                MessageBox.Show("Please select a password type to begin.");
                return;
            }

      
            string targetHash = hashedPassword.Text.Split('\n')[1].Split(':')[1].Trim();

           
            _bruteForceProgram = new BruteForceProgram(chars, targetHash);


            _bruteForceProgram.ProgressTracker.ProgressChanged += OnProgressChanged;
            _bruteForceProgram.PasswordFound += (foundPassword) =>
            {
         
                this.Invoke((MethodInvoker)delegate {
                    passwordCracked.Text = foundPassword;
                });
            };

         
            _startTime = DateTime.Now;

            Task.Run(() =>
            {
                _bruteForceProgram.StartBruteForce();
            });
        }
        private void OnProgressChanged(long attempts, int progress)
        {
            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = Math.Min(progress, 100);
                attemptText.Text = $"Attempts: {attempts:N0}";
            });
        }

        private void stopAttemptButton_Click(object sender, EventArgs e)
        {
            _bruteForceProgram?.StopBruteForce();
        }
    }
}

    



