namespace TicketsDeCinema
{
    partial class AppContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbActiveUser = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnMyTickets = new System.Windows.Forms.Button();
            this.btnMovieSession = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myTicketsScreen = new TicketsDeCinema.myTickets();
            this.myProfileScreen = new TicketsDeCinema.MyProfile();
            this.movieSessionsScreen = new TicketsDeCinema.MovieSessions();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbActiveUser);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnMyProfile);
            this.panel1.Controls.Add(this.btnMyTickets);
            this.panel1.Controls.Add(this.btnMovieSession);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 461);
            this.panel1.TabIndex = 0;
            // 
            // lbActiveUser
            // 
            this.lbActiveUser.AutoSize = true;
            this.lbActiveUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbActiveUser.Location = new System.Drawing.Point(12, 386);
            this.lbActiveUser.Name = "lbActiveUser";
            this.lbActiveUser.Size = new System.Drawing.Size(0, 14);
            this.lbActiveUser.TabIndex = 5;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSignOut.Image = global::TicketsDeCinema.Properties.Resources.logoutBlack;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.Location = new System.Drawing.Point(0, 408);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSignOut.Size = new System.Drawing.Size(200, 30);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sair";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.MouseEnter += new System.EventHandler(this.btnSignOut_MouseEnter);
            this.btnSignOut.MouseLeave += new System.EventHandler(this.btnSignOut_MouseLeave);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMyProfile.Location = new System.Drawing.Point(0, 197);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMyProfile.Size = new System.Drawing.Size(200, 30);
            this.btnMyProfile.TabIndex = 3;
            this.btnMyProfile.Text = "Meu perfil";
            this.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            this.btnMyProfile.MouseEnter += new System.EventHandler(this.btnMyProfile_MouseEnter);
            this.btnMyProfile.MouseLeave += new System.EventHandler(this.btnMyProfile_MouseLeave);
            // 
            // btnMyTickets
            // 
            this.btnMyTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyTickets.FlatAppearance.BorderSize = 0;
            this.btnMyTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTickets.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnMyTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMyTickets.Location = new System.Drawing.Point(0, 167);
            this.btnMyTickets.Name = "btnMyTickets";
            this.btnMyTickets.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMyTickets.Size = new System.Drawing.Size(200, 30);
            this.btnMyTickets.TabIndex = 2;
            this.btnMyTickets.Text = "Meus ingressos";
            this.btnMyTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyTickets.UseVisualStyleBackColor = true;
            this.btnMyTickets.Click += new System.EventHandler(this.btnMyTickets_Click);
            this.btnMyTickets.MouseEnter += new System.EventHandler(this.btnMyTickets_MouseEnter);
            this.btnMyTickets.MouseLeave += new System.EventHandler(this.btnMyTickets_MouseLeave);
            // 
            // btnMovieSession
            // 
            this.btnMovieSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovieSession.FlatAppearance.BorderSize = 0;
            this.btnMovieSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieSession.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnMovieSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMovieSession.Location = new System.Drawing.Point(0, 137);
            this.btnMovieSession.Name = "btnMovieSession";
            this.btnMovieSession.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMovieSession.Size = new System.Drawing.Size(200, 30);
            this.btnMovieSession.TabIndex = 1;
            this.btnMovieSession.Text = "Sessões";
            this.btnMovieSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieSession.UseVisualStyleBackColor = true;
            this.btnMovieSession.Click += new System.EventHandler(this.btnMovieSession_Click);
            this.btnMovieSession.MouseEnter += new System.EventHandler(this.btnMovieSession_MouseEnter);
            this.btnMovieSession.MouseLeave += new System.EventHandler(this.btnMovieSession_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketsDeCinema.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // myTicketsScreen
            // 
            this.myTicketsScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.myTicketsScreen.Location = new System.Drawing.Point(197, 0);
            this.myTicketsScreen.Name = "myTicketsScreen";
            this.myTicketsScreen.Size = new System.Drawing.Size(588, 461);
            this.myTicketsScreen.TabIndex = 3;
            // 
            // myProfileScreen
            // 
            this.myProfileScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.myProfileScreen.Location = new System.Drawing.Point(197, 0);
            this.myProfileScreen.Name = "myProfileScreen";
            this.myProfileScreen.Size = new System.Drawing.Size(588, 461);
            this.myProfileScreen.TabIndex = 2;
            // 
            // movieSessionsScreen
            // 
            this.movieSessionsScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.movieSessionsScreen.Location = new System.Drawing.Point(197, 0);
            this.movieSessionsScreen.Name = "movieSessionsScreen";
            this.movieSessionsScreen.Size = new System.Drawing.Size(588, 461);
            this.movieSessionsScreen.TabIndex = 1;
            // 
            // AppContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.myTicketsScreen);
            this.Controls.Add(this.myProfileScreen);
            this.Controls.Add(this.movieSessionsScreen);
            this.Controls.Add(this.panel1);
            this.Name = "AppContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cine.exe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnMyTickets;
        private System.Windows.Forms.Button btnMovieSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbActiveUser;
        private MovieSessions movieSessionsScreen;
        private MyProfile myProfileScreen;
        private myTickets myTicketsScreen;
    }
}