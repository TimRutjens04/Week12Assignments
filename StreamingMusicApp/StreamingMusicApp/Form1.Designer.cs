namespace StreamingMusicApp
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
            tabControl1 = new TabControl();
            tabUser = new TabPage();
            label11 = new Label();
            lbxUserAllUsers = new ListBox();
            btnUserRegister = new Button();
            label3 = new Label();
            label4 = new Label();
            tbxUserRegisterPassword = new TextBox();
            tbxUserRegisterEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbxUserLoginPassword = new TextBox();
            tbxUserLoginEmail = new TextBox();
            btnUserLogin = new Button();
            tabSongs = new TabPage();
            btnSongsAddPlaylist = new Button();
            numSongsDuration = new NumericUpDown();
            label10 = new Label();
            btnSongsQueueAddFavorites = new Button();
            btnSongsAddFavorites = new Button();
            btnSongsRemoveQueue = new Button();
            btnSongsAddQueue = new Button();
            cbxSongsGenre = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tbxSongsTitle = new TextBox();
            tbxSongsArtist = new TextBox();
            label6 = new Label();
            label5 = new Label();
            clbxSongsQueue = new CheckedListBox();
            tabFavorites = new TabPage();
            clbxFavoritesList = new CheckedListBox();
            btnRemoveFavorites = new Button();
            tabPlaylist = new TabPage();
            btnPlaylistsDelete = new Button();
            btnPlaylistsOpen = new Button();
            clbxPlaylistsPlaylist = new CheckedListBox();
            lblLoggedInUser = new Label();
            tabControl1.SuspendLayout();
            tabUser.SuspendLayout();
            tabSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSongsDuration).BeginInit();
            tabFavorites.SuspendLayout();
            tabPlaylist.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabUser);
            tabControl1.Controls.Add(tabSongs);
            tabControl1.Controls.Add(tabFavorites);
            tabControl1.Controls.Add(tabPlaylist);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(340, 658);
            tabControl1.TabIndex = 0;
            // 
            // tabUser
            // 
            tabUser.Controls.Add(label11);
            tabUser.Controls.Add(lbxUserAllUsers);
            tabUser.Controls.Add(btnUserRegister);
            tabUser.Controls.Add(label3);
            tabUser.Controls.Add(label4);
            tabUser.Controls.Add(tbxUserRegisterPassword);
            tabUser.Controls.Add(tbxUserRegisterEmail);
            tabUser.Controls.Add(label2);
            tabUser.Controls.Add(label1);
            tabUser.Controls.Add(tbxUserLoginPassword);
            tabUser.Controls.Add(tbxUserLoginEmail);
            tabUser.Controls.Add(btnUserLogin);
            tabUser.Location = new Point(4, 34);
            tabUser.Name = "tabUser";
            tabUser.Padding = new Padding(3);
            tabUser.Size = new Size(332, 620);
            tabUser.TabIndex = 2;
            tabUser.Text = "User";
            tabUser.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(93, 273);
            label11.Name = "label11";
            label11.Size = new Size(142, 25);
            label11.TabIndex = 11;
            label11.Text = "All current users:";
            // 
            // lbxUserAllUsers
            // 
            lbxUserAllUsers.FormattingEnabled = true;
            lbxUserAllUsers.ItemHeight = 25;
            lbxUserAllUsers.Location = new Point(18, 301);
            lbxUserAllUsers.Name = "lbxUserAllUsers";
            lbxUserAllUsers.Size = new Size(295, 279);
            lbxUserAllUsers.TabIndex = 10;
            // 
            // btnUserRegister
            // 
            btnUserRegister.Location = new Point(111, 211);
            btnUserRegister.Name = "btnUserRegister";
            btnUserRegister.Size = new Size(112, 34);
            btnUserRegister.TabIndex = 9;
            btnUserRegister.Text = "Register";
            btnUserRegister.UseVisualStyleBackColor = true;
            btnUserRegister.Click += btnUserRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 174);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 140);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // tbxUserRegisterPassword
            // 
            tbxUserRegisterPassword.Location = new Point(111, 174);
            tbxUserRegisterPassword.Name = "tbxUserRegisterPassword";
            tbxUserRegisterPassword.Size = new Size(150, 31);
            tbxUserRegisterPassword.TabIndex = 6;
            tbxUserRegisterPassword.UseSystemPasswordChar = true;
            // 
            // tbxUserRegisterEmail
            // 
            tbxUserRegisterEmail.Location = new Point(111, 137);
            tbxUserRegisterEmail.Name = "tbxUserRegisterEmail";
            tbxUserRegisterEmail.Size = new Size(150, 31);
            tbxUserRegisterEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // tbxUserLoginPassword
            // 
            tbxUserLoginPassword.Location = new Point(111, 43);
            tbxUserLoginPassword.Name = "tbxUserLoginPassword";
            tbxUserLoginPassword.Size = new Size(150, 31);
            tbxUserLoginPassword.TabIndex = 2;
            tbxUserLoginPassword.UseSystemPasswordChar = true;
            // 
            // tbxUserLoginEmail
            // 
            tbxUserLoginEmail.Location = new Point(111, 6);
            tbxUserLoginEmail.Name = "tbxUserLoginEmail";
            tbxUserLoginEmail.Size = new Size(150, 31);
            tbxUserLoginEmail.TabIndex = 1;
            // 
            // btnUserLogin
            // 
            btnUserLogin.Location = new Point(111, 80);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(112, 34);
            btnUserLogin.TabIndex = 0;
            btnUserLogin.Text = "Login";
            btnUserLogin.UseVisualStyleBackColor = true;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // tabSongs
            // 
            tabSongs.Controls.Add(btnSongsAddPlaylist);
            tabSongs.Controls.Add(numSongsDuration);
            tabSongs.Controls.Add(label10);
            tabSongs.Controls.Add(btnSongsQueueAddFavorites);
            tabSongs.Controls.Add(btnSongsAddFavorites);
            tabSongs.Controls.Add(btnSongsRemoveQueue);
            tabSongs.Controls.Add(btnSongsAddQueue);
            tabSongs.Controls.Add(cbxSongsGenre);
            tabSongs.Controls.Add(label9);
            tabSongs.Controls.Add(label8);
            tabSongs.Controls.Add(label7);
            tabSongs.Controls.Add(tbxSongsTitle);
            tabSongs.Controls.Add(tbxSongsArtist);
            tabSongs.Controls.Add(label6);
            tabSongs.Controls.Add(label5);
            tabSongs.Controls.Add(clbxSongsQueue);
            tabSongs.Location = new Point(4, 34);
            tabSongs.Name = "tabSongs";
            tabSongs.Padding = new Padding(3);
            tabSongs.Size = new Size(332, 620);
            tabSongs.TabIndex = 0;
            tabSongs.Text = "Songs";
            tabSongs.UseVisualStyleBackColor = true;
            // 
            // btnSongsAddPlaylist
            // 
            btnSongsAddPlaylist.Location = new Point(221, 184);
            btnSongsAddPlaylist.Name = "btnSongsAddPlaylist";
            btnSongsAddPlaylist.Size = new Size(92, 64);
            btnSongsAddPlaylist.TabIndex = 17;
            btnSongsAddPlaylist.Text = "Add to playlist";
            btnSongsAddPlaylist.UseVisualStyleBackColor = true;
            btnSongsAddPlaylist.Click += btnSongsAddPlaylist_Click;
            // 
            // numSongsDuration
            // 
            numSongsDuration.Location = new Point(128, 141);
            numSongsDuration.Name = "numSongsDuration";
            numSongsDuration.Size = new Size(150, 31);
            numSongsDuration.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 143);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 14;
            label10.Text = "Duration:";
            // 
            // btnSongsQueueAddFavorites
            // 
            btnSongsQueueAddFavorites.Location = new Point(6, 550);
            btnSongsQueueAddFavorites.Name = "btnSongsQueueAddFavorites";
            btnSongsQueueAddFavorites.Size = new Size(320, 34);
            btnSongsQueueAddFavorites.TabIndex = 13;
            btnSongsQueueAddFavorites.Text = "Add selected song to favorites";
            btnSongsQueueAddFavorites.UseVisualStyleBackColor = true;
            btnSongsQueueAddFavorites.Click += btnSongsQueueAddFavorites_Click;
            // 
            // btnSongsAddFavorites
            // 
            btnSongsAddFavorites.Location = new Point(128, 184);
            btnSongsAddFavorites.Name = "btnSongsAddFavorites";
            btnSongsAddFavorites.Size = new Size(87, 64);
            btnSongsAddFavorites.TabIndex = 12;
            btnSongsAddFavorites.Text = "Add to favorites";
            btnSongsAddFavorites.UseVisualStyleBackColor = true;
            btnSongsAddFavorites.Click += btnSongsAddFavorites_Click;
            // 
            // btnSongsRemoveQueue
            // 
            btnSongsRemoveQueue.Location = new Point(6, 513);
            btnSongsRemoveQueue.Name = "btnSongsRemoveQueue";
            btnSongsRemoveQueue.Size = new Size(320, 34);
            btnSongsRemoveQueue.TabIndex = 11;
            btnSongsRemoveQueue.Text = "Remove selected songs from queue";
            btnSongsRemoveQueue.UseVisualStyleBackColor = true;
            btnSongsRemoveQueue.Click += btnSongsRemoveQueue_Click;
            // 
            // btnSongsAddQueue
            // 
            btnSongsAddQueue.Location = new Point(34, 184);
            btnSongsAddQueue.Name = "btnSongsAddQueue";
            btnSongsAddQueue.Size = new Size(87, 64);
            btnSongsAddQueue.TabIndex = 10;
            btnSongsAddQueue.Text = "Add to queue";
            btnSongsAddQueue.UseVisualStyleBackColor = true;
            btnSongsAddQueue.Click += btnSongsAddQueue_Click;
            // 
            // cbxSongsGenre
            // 
            cbxSongsGenre.FormattingEnabled = true;
            cbxSongsGenre.Items.AddRange(new object[] { "Rap", "Pop", "Rock", "Country", "Classical" });
            cbxSongsGenre.Location = new Point(128, 105);
            cbxSongsGenre.Name = "cbxSongsGenre";
            cbxSongsGenre.Size = new Size(150, 33);
            cbxSongsGenre.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 105);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 8;
            label9.Text = "Genre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 71);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 7;
            label8.Text = "Title:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 34);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 6;
            label7.Text = "Artist:";
            // 
            // tbxSongsTitle
            // 
            tbxSongsTitle.Location = new Point(128, 68);
            tbxSongsTitle.Name = "tbxSongsTitle";
            tbxSongsTitle.Size = new Size(150, 31);
            tbxSongsTitle.TabIndex = 5;
            // 
            // tbxSongsArtist
            // 
            tbxSongsArtist.Location = new Point(128, 31);
            tbxSongsArtist.Name = "tbxSongsArtist";
            tbxSongsArtist.Size = new Size(150, 31);
            tbxSongsArtist.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 251);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 3;
            label6.Text = "Queue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 3);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 2;
            label5.Text = "Add songs";
            // 
            // clbxSongsQueue
            // 
            clbxSongsQueue.FormattingEnabled = true;
            clbxSongsQueue.Location = new Point(6, 279);
            clbxSongsQueue.Name = "clbxSongsQueue";
            clbxSongsQueue.Size = new Size(320, 228);
            clbxSongsQueue.TabIndex = 1;
            // 
            // tabFavorites
            // 
            tabFavorites.Controls.Add(clbxFavoritesList);
            tabFavorites.Controls.Add(btnRemoveFavorites);
            tabFavorites.Location = new Point(4, 34);
            tabFavorites.Name = "tabFavorites";
            tabFavorites.Padding = new Padding(3);
            tabFavorites.Size = new Size(332, 620);
            tabFavorites.TabIndex = 1;
            tabFavorites.Text = "Favorites";
            tabFavorites.UseVisualStyleBackColor = true;
            // 
            // clbxFavoritesList
            // 
            clbxFavoritesList.FormattingEnabled = true;
            clbxFavoritesList.Location = new Point(19, 6);
            clbxFavoritesList.Name = "clbxFavoritesList";
            clbxFavoritesList.Size = new Size(290, 396);
            clbxFavoritesList.TabIndex = 2;
            // 
            // btnRemoveFavorites
            // 
            btnRemoveFavorites.Location = new Point(19, 412);
            btnRemoveFavorites.Name = "btnRemoveFavorites";
            btnRemoveFavorites.Size = new Size(290, 34);
            btnRemoveFavorites.TabIndex = 1;
            btnRemoveFavorites.Text = "Remove selected songs";
            btnRemoveFavorites.UseVisualStyleBackColor = true;
            btnRemoveFavorites.Click += btnRemoveFavorites_Click;
            // 
            // tabPlaylist
            // 
            tabPlaylist.Controls.Add(btnPlaylistsDelete);
            tabPlaylist.Controls.Add(btnPlaylistsOpen);
            tabPlaylist.Controls.Add(clbxPlaylistsPlaylist);
            tabPlaylist.Location = new Point(4, 34);
            tabPlaylist.Name = "tabPlaylist";
            tabPlaylist.Padding = new Padding(3);
            tabPlaylist.Size = new Size(332, 620);
            tabPlaylist.TabIndex = 3;
            tabPlaylist.Text = "Playlists";
            tabPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnPlaylistsDelete
            // 
            btnPlaylistsDelete.Location = new Point(184, 492);
            btnPlaylistsDelete.Name = "btnPlaylistsDelete";
            btnPlaylistsDelete.Size = new Size(112, 64);
            btnPlaylistsDelete.TabIndex = 2;
            btnPlaylistsDelete.Text = "Delete playlist";
            btnPlaylistsDelete.UseVisualStyleBackColor = true;
            // 
            // btnPlaylistsOpen
            // 
            btnPlaylistsOpen.Location = new Point(26, 492);
            btnPlaylistsOpen.Name = "btnPlaylistsOpen";
            btnPlaylistsOpen.Size = new Size(112, 64);
            btnPlaylistsOpen.TabIndex = 1;
            btnPlaylistsOpen.Text = "Open playlist";
            btnPlaylistsOpen.UseVisualStyleBackColor = true;
            // 
            // clbxPlaylistsPlaylist
            // 
            clbxPlaylistsPlaylist.FormattingEnabled = true;
            clbxPlaylistsPlaylist.Location = new Point(6, 6);
            clbxPlaylistsPlaylist.Name = "clbxPlaylistsPlaylist";
            clbxPlaylistsPlaylist.Size = new Size(320, 480);
            clbxPlaylistsPlaylist.TabIndex = 0;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Location = new Point(16, 673);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(118, 25);
            lblLoggedInUser.TabIndex = 17;
            lblLoggedInUser.Text = "Logged in as:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 716);
            Controls.Add(lblLoggedInUser);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabUser.ResumeLayout(false);
            tabUser.PerformLayout();
            tabSongs.ResumeLayout(false);
            tabSongs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSongsDuration).EndInit();
            tabFavorites.ResumeLayout(false);
            tabPlaylist.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabFavorites;
        private TabPage tabUser;
        private Button btnRemoveFavorites;
        private Button btnUserRegister;
        private Label label3;
        private Label label4;
        private TextBox tbxUserRegisterPassword;
        private TextBox tbxUserRegisterEmail;
        private Label label2;
        private Label label1;
        private TextBox tbxUserLoginPassword;
        private TextBox tbxUserLoginEmail;
        private Button btnUserLogin;
        private CheckedListBox clbxFavoritesList;
        private TabPage tabSongs;
        private ComboBox cbxSongsGenre;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbxSongsTitle;
        private TextBox tbxSongsArtist;
        private Label label6;
        private Label label5;
        private CheckedListBox clbxSongsQueue;
        private Button btnSongsQueueAddFavorites;
        private Button btnSongsAddFavorites;
        private Button btnSongsRemoveQueue;
        private Button btnSongsAddQueue;
        private NumericUpDown numSongsDuration;
        private Label label10;
        private Label label11;
        private ListBox lbxUserAllUsers;
        private Label lblLoggedInUser;
        private TabPage tabPlaylist;
        private Button btnPlaylistsDelete;
        private Button btnPlaylistsOpen;
        private CheckedListBox clbxPlaylistsPlaylist;
        private Button btnSongsAddPlaylist;
    }
}