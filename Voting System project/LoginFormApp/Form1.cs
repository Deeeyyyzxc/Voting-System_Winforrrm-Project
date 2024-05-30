using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LoginFormApp;

public partial class Form1 : Form
{
    private List<User> users;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;

    public Form1()
    {
        InitializeComponent();
        LoadUsers();
    }
            private void LoadUsers()
        {
            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            else
            {
                users = new List<User>();
            }
        }
private void btnLogin_Click(object sender, EventArgs e)
{
    string username = txtUsername.Text;
    string password = txtPassword.Text;

    var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

    if (user != null)
    {
        MessageBox.Show("Login Successful!");
        this.Hide(); // Hide the login form
        using (WelcomeForm welcomeForm = new WelcomeForm())
        {
            welcomeForm.ShowDialog(); // Open the WelcomeForm
        }
        this.Close(); // Close the login form after WelcomeForm is closed
    }
    else
    {
        MessageBox.Show("Invalid Username or Password");
    }
}

        private void btnSignUp_Click(object sender, EventArgs e)
        {
        using (SignUpForm signUpForm = new SignUpForm())
            {
                if (signUpForm.ShowDialog() == DialogResult.OK)
                {
                    User newUser = signUpForm.NewUser;
                    if (newUser != null)
                    {
                        txtUsername.Text = newUser.Username;
                        txtPassword.Text = newUser.Password;
                        btnLogin_Click(sender, e); // Simulate login click
                    }
                }
            }
        }

}
