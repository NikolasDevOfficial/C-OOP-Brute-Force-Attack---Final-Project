namespace CsharpBruteForceFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


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
    }


}
