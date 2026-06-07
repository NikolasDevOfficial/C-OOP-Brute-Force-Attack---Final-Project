namespace CsharpBruteForceFinal
{
    public partial class Form1 : Form
    {
        private BruteForceProgram _bruteForceProgram;
        private DateTime _startTime;
        private long _latestAttempts;
        private int _latestProgress;
        private System.Windows.Forms.Timer _uiTimer;
        public Form1()
        {
            InitializeComponent();

            _uiTimer = new System.Windows.Forms.Timer();
            _uiTimer.Interval = 1000; // modify interval if needed, temp fix
            _uiTimer.Tick += (s, e) =>
            {
                progressBar1.Value = Math.Min(_latestProgress, 100);
                attemptText.Text = $"Attempts: {_latestAttempts:N0}";
            };
            _uiTimer.Start();

        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void attemptText_Click(object sender, EventArgs e)
        {

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

            string hashString = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            var hashedPasswordFinal = hashString;
            hashedPassword.Text = $"Unhashed: {unhashedPassword}\nHashed: {hashedPasswordFinal}";
        }




        private void startBruteforceInitial_Click(object sender, EventArgs e)
        {
            string chars = "";

            if (passwordLowercaseSelect.Checked)
                chars = "abcdefghijklmnopqrstuvwxyz";
            else if (passwordLowerUpperSelect.Checked)
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            else if (passwordLowerUpperNumSelect.Checked)
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            else if (passwordLowerUpperNumSymbolsSelect.Checked)
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~!@#$%^&*()_+=-`";
            else
            {
                MessageBox.Show("Select a brute force mode first.");
                return;
            }







            string targetHash = hashedPassword.Text.Split('\n')[1].Split(':')[1].Trim();
            _bruteForceProgram = new BruteForceProgram(chars, targetHash);
            _bruteForceProgram.ProgressTracker.ProgressChanged += (attempts, progress) =>
        
            {
        
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = Math.Min(progress, 100);
                    attemptText.Text = $"Attempts: {attempts:N0}";
                });
            };

            _bruteForceProgram.PasswordFound += (foundPassword) =>
         
            {
                this.Invoke((MethodInvoker)delegate
                {
                    passwordCracked.Text = foundPassword;
                    timeElapsed.Text = $"Time passed since the start: {(DateTime.Now - _startTime).TotalSeconds} seconds";
                });
            };

            _startTime = DateTime.Now;
            progressBar1.Value = 0;
            attemptText.Text = "Attempts: 0";

            Task.Run(() =>
            {
                _bruteForceProgram.StartBruteForce();
            });
        }


        private void stopAttemptButton_Click(object sender, EventArgs e)
        {
            _bruteForceProgram?.StopBruteForce();
        } }






    }

