using System;
using System.Windows.Forms;

namespace LoginFormApp
{
 partial class WelcomeForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreateSession;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public WelcomeForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCreateSession = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(100, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Voting System!";
            this.lblWelcome.ForeColor = System.Drawing.Color.White;

            // btnCreateSession
            this.btnCreateSession.Location = new System.Drawing.Point(200, 150);
            this.btnCreateSession.Name = "btnCreateSession";
            this.btnCreateSession.Size = new System.Drawing.Size(200, 50);
            this.btnCreateSession.TabIndex = 1;
            this.btnCreateSession.Text = "Create Voting Session";
            this.btnCreateSession.UseVisualStyleBackColor = true;
            this.btnCreateSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCreateSession.ForeColor = System.Drawing.Color.White;
            this.btnCreateSession.Click += new System.EventHandler(this.btnCreateSession_Click);

            // WelcomeForm
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnCreateSession);
            this.Controls.Add(this.lblWelcome);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ResumeLayout(false);
        }

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
            // Open the form to create a voting session
            using (CreateVotingSessionForm createSessionForm = new CreateVotingSessionForm())
            {
                createSessionForm.ShowDialog();
            }
        }
    }
}
