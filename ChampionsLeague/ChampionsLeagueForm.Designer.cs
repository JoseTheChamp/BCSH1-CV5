namespace ChampionsLeague
{
    partial class ChampionsLeagueForm
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
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonEditPlayer = new System.Windows.Forms.Button();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.buttonBestClubs = new System.Windows.Forms.Button();
            this.listBoxConsole = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 20;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 12);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(577, 204);
            this.listBoxPlayers.TabIndex = 0;
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(595, 12);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(203, 29);
            this.buttonAddPlayer.TabIndex = 1;
            this.buttonAddPlayer.Text = "Přidat hráče";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.Location = new System.Drawing.Point(595, 47);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(203, 29);
            this.buttonEditPlayer.TabIndex = 2;
            this.buttonEditPlayer.Text = "Upravit hráče";
            this.buttonEditPlayer.UseVisualStyleBackColor = true;
            this.buttonEditPlayer.Click += new System.EventHandler(this.buttonEditPlayer_Click);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.Location = new System.Drawing.Point(595, 82);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(203, 29);
            this.buttonDeletePlayer.TabIndex = 3;
            this.buttonDeletePlayer.Text = "Smazat hráče";
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // buttonBestClubs
            // 
            this.buttonBestClubs.Location = new System.Drawing.Point(595, 117);
            this.buttonBestClubs.Name = "buttonBestClubs";
            this.buttonBestClubs.Size = new System.Drawing.Size(203, 29);
            this.buttonBestClubs.TabIndex = 4;
            this.buttonBestClubs.Text = "Nejlepší kluby";
            this.buttonBestClubs.UseVisualStyleBackColor = true;
            this.buttonBestClubs.Click += new System.EventHandler(this.buttonBestClubs_Click);
            // 
            // listBoxConsole
            // 
            this.listBoxConsole.FormattingEnabled = true;
            this.listBoxConsole.ItemHeight = 20;
            this.listBoxConsole.Location = new System.Drawing.Point(12, 222);
            this.listBoxConsole.Name = "listBoxConsole";
            this.listBoxConsole.Size = new System.Drawing.Size(786, 124);
            this.listBoxConsole.TabIndex = 5;
            // 
            // ChampionsLeagueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.Controls.Add(this.listBoxConsole);
            this.Controls.Add(this.buttonBestClubs);
            this.Controls.Add(this.buttonDeletePlayer);
            this.Controls.Add(this.buttonEditPlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.listBoxPlayers);
            this.Name = "ChampionsLeagueForm";
            this.Text = "ChampionsLeagueForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxPlayers;
        private Button buttonAddPlayer;
        private Button buttonEditPlayer;
        private Button buttonDeletePlayer;
        private Button buttonBestClubs;
        private ListBox listBoxConsole;
    }
}