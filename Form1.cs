using CsharpBruteForceFinal.progressTracking;
using System.Diagnostics;
using System.Linq;

namespace CsharpBruteForceFinal
{
    public partial class Form1 : Form
    {
        private BruteForceProgram _bruteForceProgram;
        private DateTime _startTime;
        private long _latestAttempts;
        private int _latestProgress;
        private System.Windows.Forms.Timer _uiTimer;
        private PerformanceLogger _performanceLogger = new PerformanceLogger();

    
        public Form1()
        {
            InitializeComponent();

            _uiTimer = new System.Windows.Forms.Timer();
            _uiTimer.Interval = 1000;
            _uiTimer.Tick += (s, e) =>
            {
                progressBar1.Value = Math.Min(_latestProgress, 100);
                attemptText.Text = $"Attempts: {_latestAttempts:N0}";
            };
            _uiTimer.Start();

          
        }

        private string GetSelectedChars()
        {
            if (passwordLowercaseSelect.Checked)
                return "abcdefghijklmnopqrstuvwxyz";
            else if (passwordLowerUpperSelect.Checked)
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            else if (passwordLowerUpperNumSelect.Checked)
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            else if (passwordLowerUpperNumSymbolsSelect.Checked)
                return "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~!@#$%^&*()_+=-`";

            return "";
        }
        private void performanceTestButton_Click(object sender, EventArgs e)
        {
            RunPerformanceTest();
        }
        private void generatePassword_Click(object sender, EventArgs e)
        {
            var generator = new passwordGenerator();
            string password = "";

            generatePassword.Enabled =
                passwordLowercaseSelect.Checked ||
                passwordLowerUpperSelect.Checked ||
                passwordLowerUpperNumSelect.Checked ||
                passwordLowerUpperNumSymbolsSelect.Checked;

            if (passwordLowercaseSelect.Checked)
                password = generator.RandomPasswordGeneratorLowercaseOnly();
            else if (passwordLowerUpperSelect.Checked)
                password = generator.RandomPasswordGeneratorLowerUppercase();
            else if (passwordLowerUpperNumSelect.Checked)
                password = generator.RandomPasswordGeneratorLowerUpperNumbers();
            else if (passwordLowerUpperNumSymbolsSelect.Checked)
                password = generator.RandomPasswordGeneratorLowerUpperNumSymbols();

            byte[] hash = PasswordHashSalt.ComputeSHA256Hash(password);
            string hashedPasswordFinal = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            
            hashedPassword.Text = $"Unhashed: {password}\nHashed: {hashedPasswordFinal}";
        }

        private void startBruteforceInitial_Click(object sender, EventArgs e)
        {
            string chars = GetSelectedChars();

            if (string.IsNullOrEmpty(chars))
            {
                MessageBox.Show("Select a brute force mode first.");
                return;
            }

            string targetPassword = hashedPassword.Text.Split('\n')[1].Split(':')[1].Trim();

            _bruteForceProgram = new BruteForceProgram(chars, targetPassword);

            _bruteForceProgram.ProgressTracker.ProgressChanged += (attempts, progress) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    _latestAttempts = attempts;
                    _latestProgress = progress;

                    progressBar1.Value = Math.Min(progress, 100);
                    attemptText.Text = $"Attempts: {attempts:N0}";
                });
            };

            _bruteForceProgram.PasswordFound += (foundPassword) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    passwordCracked.Text = foundPassword;
                    timeElapsed.Text =
                        $"Time passed: {(DateTime.Now - _startTime).TotalSeconds} seconds";
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

        private async void RunPerformanceTest()
        {
            string chars = GetSelectedChars();

            string[] parts = hashedPassword.Text.Split('\n');
            if (parts.Length < 2)
            {
                MessageBox.Show("Generate a password first!");
                return;
            }

            string targetPassword = parts[1].Split(':')[1].Trim();

        
            _performanceLogger = new PerformanceLogger();

     
            var originalText = startBruteforceInitial.Text;
            startBruteforceInitial.Enabled = false;
            startBruteforceInitial.Text = "Running tests...";
            performanceTestButton.Enabled = false;

            try
            {
                await Task.Run(() =>
                {
                
                    var single = new BruteForceProgram(chars, targetPassword);
                    string singleResult = null;

                    _performanceLogger.LogPerformance(
                        "Single-thread",
                        () => singleResult = single.StartBruteForceSingleThread(),
                        () => single.GetAttempts(),
                        () => singleResult ?? "Not found"
                    );

                    var multi = new BruteForceProgram(chars, targetPassword);
                  
                    string multiResult = null;

                    _performanceLogger.LogPerformance(
                        "Multi-thread",
                        () => multiResult = multi.StartBruteForce(),
                        () => multi.GetAttempts(),
                        () => multiResult ?? "Not found"
                    );
                });
            }
            finally
            {
         
                this.Invoke(() =>
                {
                    startBruteforceInitial.Enabled = true;
                    startBruteforceInitial.Text = originalText;
                    performanceTestButton.Enabled = true;
                    _performanceLogger.DisplayResults(performanceLogLabel);
                });
            }
        }

        private void stopAttemptButton_Click(object sender, EventArgs e) 
        {
            //use just in case
            Debug.WriteLine("DEBUG Stop clicked clicked");
            if (_bruteForceProgram != null)
            {
                _bruteForceProgram.StopBruteForce();
                Debug.WriteLine("Stop command sent");
            }
            else
            {
                Debug.WriteLine("Brute force program is null");
            }
        }



    }
}