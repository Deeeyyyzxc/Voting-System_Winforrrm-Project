using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class CreateVotingSessionForm : Form
    {
        private Label titleLabel;
        private RadioButton option1RadioButton;
        private RadioButton option2RadioButton;
        private RadioButton option3RadioButton;
        private RadioButton option4RadioButton;
        private Button voteButton;
        private Button showResultsButton;
        private Button resetVotesButton;
        private Button customizeOptionsButton;
        private Button saveVotesButton;
        private Button loadVotesButton;
        private Label resultsLabel;

        private TextBox option1TextBox;
        private TextBox option2TextBox;
        private TextBox option3TextBox;
        private TextBox option4TextBox;

        private int option1Votes = 0;
        private int option2Votes = 0;
        private int option3Votes = 0;
        private int option4Votes = 0;

        public CreateVotingSessionForm()
        {
            InitializeComponent(); // Initialize components here
        }

        private void InitializeComponent()
        {
            // Form properties
            this.Text = "Voting System";
            this.BackColor = Color.FromArgb(52, 73, 94); // Set form background color
            this.ClientSize = new Size(400, 450); // Set form size
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Title Label
            this.titleLabel = new Label();
            this.titleLabel.Text = "Voting System";
            this.titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new Point(120, 20);
            this.titleLabel.ForeColor = Color.DarkBlue; // Set title color
            this.titleLabel.BackColor = Color.LightYellow; // Set title background color

            // Option 1 RadioButton
            this.option1RadioButton = new RadioButton();
            this.option1RadioButton.Text = "Option 1";
            this.option1RadioButton.Location = new Point(50, 100);
            this.option1RadioButton.ForeColor = Color.Black; // Set option text color
            this.option1RadioButton.BackColor = Color.LightGray; // Set option background color

            // Option 2 RadioButton
            this.option2RadioButton = new RadioButton();
            this.option2RadioButton.Text = "Option 2";
            this.option2RadioButton.Location = new Point(50, 130);
            this.option2RadioButton.ForeColor = Color.Black; // Set option text color
            this.option2RadioButton.BackColor = Color.LightGray; // Set option background color

            // Option 3 RadioButton
            this.option3RadioButton = new RadioButton();
            this.option3RadioButton.Text = "Option 3";
            this.option3RadioButton.Location = new Point(50, 160);
            this.option3RadioButton.ForeColor = Color.Black; // Set option text color
            this.option3RadioButton.BackColor = Color.LightGray; // Set option background color

            // Option 4 RadioButton
            this.option4RadioButton = new RadioButton();
            this.option4RadioButton.Text = "Option 4";
            this.option4RadioButton.Location = new Point(50, 190);
            this.option4RadioButton.ForeColor = Color.Black; // Set option text color
            this.option4RadioButton.BackColor = Color.LightGray; // Set option background color

            // Vote Button
            this.voteButton = new Button();
            this.voteButton.Text = "Vote";
            this.voteButton.Location = new Point(50, 230);
            this.voteButton.Click += new EventHandler(this.VoteButton_Click);

            // Show Results Button
            this.showResultsButton = new Button();
            this.showResultsButton.Text = "Show Results";
            this.showResultsButton.Location = new Point(150, 230);
            this.showResultsButton.Click += new EventHandler(this.ShowResultsButton_Click);

            // Reset Votes Button
            this.resetVotesButton = new Button();
            this.resetVotesButton.Text = "Reset Votes";
            this.resetVotesButton.Location = new Point(250, 230);
            this.resetVotesButton.Click += new EventHandler(this.ResetVotesButton_Click);

            // Customize Options Button
            this.customizeOptionsButton = new Button();
            this.customizeOptionsButton.Text = "Customize Options";
            this.customizeOptionsButton.Location = new Point(50, 270);
            this.customizeOptionsButton.Click += new EventHandler(this.CustomizeOptionsButton_Click);

            // Save Votes Button
            this.saveVotesButton = new Button();
            this.saveVotesButton.Text = "Save Votes";
            this.saveVotesButton.Location = new Point(200, 270);
            this.saveVotesButton.Click += new EventHandler(this.SaveVotesButton_Click);

            // Load Votes Button
            this.loadVotesButton = new Button();
            this.loadVotesButton.Text = "Load Votes";
            this.loadVotesButton.Location = new Point(300, 270);
            this.loadVotesButton.Click += new EventHandler(this.LoadVotesButton_Click);

            // Results Label
            this.resultsLabel = new Label();
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new Point(50, 310);
            this.resultsLabel.ForeColor = Color.White;

            // Option 1 TextBox
            this.option1TextBox = new TextBox();
            this.option1TextBox.Location = new Point(200, 100);
            this.option1TextBox.Size = new Size(150, 20);

            // Option 2 TextBox
            this.option2TextBox = new TextBox();
            this.option2TextBox.Location = new Point(200, 130);
            this.option2TextBox.Size = new Size(150, 20);

            // Option 3 TextBox
            this.option3TextBox = new TextBox();
            this.option3TextBox.Location = new Point(200, 160);
            this.option3TextBox.Size = new Size(150, 20);

            // Option 4 TextBox
            this.option4TextBox = new TextBox();
            this.option4TextBox.Location = new Point(200, 190);
            this.option4TextBox.Size = new Size(150, 20);

            // Add controls to the form
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.option1RadioButton);
            this.Controls.Add(this.option2RadioButton);
            this.Controls.Add(this.option3RadioButton);
            this.Controls.Add(this.option4RadioButton);
            this.Controls.Add(this.voteButton);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.resetVotesButton);
            this.Controls.Add(this.customizeOptionsButton);
            this.Controls.Add(this.saveVotesButton);
            this.Controls.Add(this.loadVotesButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.option1TextBox);
            this.Controls.Add(this.option2TextBox);
            this.Controls.Add(this.option3TextBox);
            this.Controls.Add(this.option4TextBox);
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            if (option1RadioButton.Checked)
            {
                option1Votes++;
            }
            else if (option2RadioButton.Checked)
            {
                option2Votes++;
            }
            else if (option3RadioButton.Checked)
            {
                option3Votes++;
            }
            else if (option4RadioButton.Checked)
            {
                option4Votes++;
            }
            else
            {
                MessageBox.Show("Please select an option to vote.", "No Option Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thank you for your vote!", "Vote Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowResultsButton_Click(object sender, EventArgs e)
        {
            resultsLabel.Visible = !resultsLabel.Visible;

            if (resultsLabel.Visible)
            {
                // If results are now visible, update the label with the current results
                string results = $"{option1RadioButton.Text}: {option1Votes} votes ({option1TextBox.Text})\n" +
                                 $"{option2RadioButton.Text}: {option2Votes} votes ({option2TextBox.Text})\n" +
                                 $"{option3RadioButton.Text}: {option3Votes} votes ({option3TextBox.Text})\n" +
                                 $"{option4RadioButton.Text}: {option4Votes} votes ({option4TextBox.Text})";

                resultsLabel.Text = results;
            }
            else
            {
                // If results are hidden, clear the label text
                resultsLabel.Text = string.Empty;
            }
        }

        private void ResetVotesButton_Click(object sender, EventArgs e)
        {
            option1Votes = 0;
            option2Votes = 0;
            option3Votes = 0;
            option4Votes = 0;
            MessageBox.Show("All votes have been reset.", "Votes Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (resultsLabel.Visible)
            {
                ShowResultsButton_Click(sender, e);
            }
        }

        private void CustomizeOptionsButton_Click(object sender, EventArgs e)
        {
            string newOption1 = Prompt.ShowDialog("Enter new text for Option 1:", "Customize Option");
            if (!string.IsNullOrEmpty(newOption1))
            {
                option1RadioButton.Text = newOption1;
            }

            string newOption2 = Prompt.ShowDialog("Enter new text for Option 2:", "Customize Option");
            if (!string.IsNullOrEmpty(newOption2))
            {
                option2RadioButton.Text = newOption2;
            }

            string newOption3 = Prompt.ShowDialog("Enter new text for Option 3:", "Customize Option");
            if (!string.IsNullOrEmpty(newOption3))
            {
                option3RadioButton.Text = newOption3;
            }

            string newOption4 = Prompt.ShowDialog("Enter new text for Option 4:", "Customize Option");
            if (!string.IsNullOrEmpty(newOption4))
            {
                option4RadioButton.Text = newOption4;
            }
        }

        private void SaveVotesButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("votes.txt"))
            {
                writer.WriteLine(option1Votes);
                writer.WriteLine(option2Votes);
                writer.WriteLine(option3Votes);
                writer.WriteLine(option4Votes);
            }
            MessageBox.Show("Votes have been saved.", "Votes Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadVotesButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("votes.txt"))
            {
                using (StreamReader reader = new StreamReader("votes.txt"))
                {
                    option1Votes = int.Parse(reader.ReadLine());
                    option2Votes = int.Parse(reader.ReadLine());
                    option3Votes = int.Parse(reader.ReadLine());
                    option4Votes = int.Parse(reader.ReadLine());
                }
                MessageBox.Show("Votes have been loaded.", "Votes Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultsLabel.Visible)
                {
                    ShowResultsButton_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("No saved votes found.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
                Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
    }
}
