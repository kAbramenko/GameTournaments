namespace GameTournaments
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxTournaments = new System.Windows.Forms.ListBox();
            this.addTournamentButton = new System.Windows.Forms.Button();
            this.RemoveTournamentButton = new System.Windows.Forms.Button();
            this.tournamentGameDisciplineText = new System.Windows.Forms.TextBox();
            this.tournamentPrizepoolText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tournamentNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.playerDateText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.playerNicknameText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerSurnameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playerNameText = new System.Windows.Forms.TextBox();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.RemoveTeamButton = new System.Windows.Forms.Button();
            this.RemovePlayerButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTournaments
            // 
            this.listBoxTournaments.FormattingEnabled = true;
            this.listBoxTournaments.Location = new System.Drawing.Point(12, 12);
            this.listBoxTournaments.Name = "listBoxTournaments";
            this.listBoxTournaments.Size = new System.Drawing.Size(248, 472);
            this.listBoxTournaments.TabIndex = 0;
            this.listBoxTournaments.SelectedIndexChanged += new System.EventHandler(this.listBoxTournaments_SelectedIndexChanged);
            // 
            // addTournamentButton
            // 
            this.addTournamentButton.Location = new System.Drawing.Point(9, 154);
            this.addTournamentButton.Name = "addTournamentButton";
            this.addTournamentButton.Size = new System.Drawing.Size(100, 23);
            this.addTournamentButton.TabIndex = 1;
            this.addTournamentButton.Text = "Добавить";
            this.addTournamentButton.UseVisualStyleBackColor = true;
            this.addTournamentButton.Click += new System.EventHandler(this.addTournamentButton_Click);
            // 
            // RemoveTournamentButton
            // 
            this.RemoveTournamentButton.Location = new System.Drawing.Point(194, 490);
            this.RemoveTournamentButton.Name = "RemoveTournamentButton";
            this.RemoveTournamentButton.Size = new System.Drawing.Size(66, 23);
            this.RemoveTournamentButton.TabIndex = 2;
            this.RemoveTournamentButton.Text = "Удалить";
            this.RemoveTournamentButton.UseVisualStyleBackColor = true;
            this.RemoveTournamentButton.Click += new System.EventHandler(this.removeTournamentButton_Click);
            // 
            // tournamentGameDisciplineText
            // 
            this.tournamentGameDisciplineText.Location = new System.Drawing.Point(9, 89);
            this.tournamentGameDisciplineText.Name = "tournamentGameDisciplineText";
            this.tournamentGameDisciplineText.Size = new System.Drawing.Size(100, 20);
            this.tournamentGameDisciplineText.TabIndex = 8;
            this.tournamentGameDisciplineText.TextChanged += new System.EventHandler(this.tournamentGameDisciplineText_TextChanged);
            // 
            // tournamentPrizepoolText
            // 
            this.tournamentPrizepoolText.Location = new System.Drawing.Point(9, 128);
            this.tournamentPrizepoolText.Name = "tournamentPrizepoolText";
            this.tournamentPrizepoolText.Size = new System.Drawing.Size(100, 20);
            this.tournamentPrizepoolText.TabIndex = 9;
            this.tournamentPrizepoolText.TextChanged += new System.EventHandler(this.tournamentPrizepoolText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Игровая дисциплина (id):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Призовой фонд ($):";
            // 
            // tournamentNameText
            // 
            this.tournamentNameText.Location = new System.Drawing.Point(9, 49);
            this.tournamentNameText.Name = "tournamentNameText";
            this.tournamentNameText.Size = new System.Drawing.Size(100, 20);
            this.tournamentNameText.TabIndex = 5;
            this.tournamentNameText.TextChanged += new System.EventHandler(this.tournamentNameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название турнира:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tournamentGameDisciplineText);
            this.groupBox1.Controls.Add(this.addTournamentButton);
            this.groupBox1.Controls.Add(this.tournamentPrizepoolText);
            this.groupBox1.Controls.Add(this.tournamentNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание турнира";
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(371, 12);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(248, 472);
            this.listBoxTeams.TabIndex = 11;
            this.listBoxTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTournaments_SelectedIndexChanged);
            this.listBoxTeams.DoubleClick += new System.EventHandler(this.listBoxTeams_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addTeamButton);
            this.groupBox2.Controls.Add(this.teamNameText);
            this.groupBox2.Location = new System.Drawing.Point(380, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание команды";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название команды:";
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(9, 154);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(100, 23);
            this.addTeamButton.TabIndex = 1;
            this.addTeamButton.Text = "Добавить";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // teamNameText
            // 
            this.teamNameText.Location = new System.Drawing.Point(9, 49);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(100, 20);
            this.teamNameText.TabIndex = 5;
            this.teamNameText.TextChanged += new System.EventHandler(this.teamNameText_TextChanged);
            this.teamNameText.Validating += new System.ComponentModel.CancelEventHandler(this.teamNameText_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.playerDateText);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.playerNicknameText);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.playerSurnameText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.addPlayerButton);
            this.groupBox3.Controls.Add(this.playerNameText);
            this.groupBox3.Location = new System.Drawing.Point(743, 519);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 185);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создание игрока";
            // 
            // playerDateText
            // 
            this.playerDateText.Location = new System.Drawing.Point(122, 49);
            this.playerDateText.Name = "playerDateText";
            this.playerDateText.Size = new System.Drawing.Size(86, 20);
            this.playerDateText.TabIndex = 11;
            this.playerDateText.TextChanged += new System.EventHandler(this.playerDateText_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Дата рождения:";
            // 
            // playerNicknameText
            // 
            this.playerNicknameText.Location = new System.Drawing.Point(9, 128);
            this.playerNicknameText.Name = "playerNicknameText";
            this.playerNicknameText.Size = new System.Drawing.Size(93, 20);
            this.playerNicknameText.TabIndex = 9;
            this.playerNicknameText.TextChanged += new System.EventHandler(this.playerNicknameText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ник:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Фамилия";
            // 
            // playerSurnameText
            // 
            this.playerSurnameText.Location = new System.Drawing.Point(9, 89);
            this.playerSurnameText.Name = "playerSurnameText";
            this.playerSurnameText.Size = new System.Drawing.Size(93, 20);
            this.playerSurnameText.TabIndex = 6;
            this.playerSurnameText.TextChanged += new System.EventHandler(this.playerSurnameText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Имя";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(9, 154);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(100, 23);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "Добавить";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // playerNameText
            // 
            this.playerNameText.Location = new System.Drawing.Point(9, 49);
            this.playerNameText.Name = "playerNameText";
            this.playerNameText.Size = new System.Drawing.Size(93, 20);
            this.playerNameText.TabIndex = 5;
            this.playerNameText.TextChanged += new System.EventHandler(this.playerNameText_TextChanged);
            this.playerNameText.Validating += new System.ComponentModel.CancelEventHandler(this.playerNameText_Validating);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(734, 12);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(248, 472);
            this.listBoxPlayers.TabIndex = 13;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            this.listBoxPlayers.DoubleClick += new System.EventHandler(this.listBoxPlayers_DoubleClick);
            // 
            // RemoveTeamButton
            // 
            this.RemoveTeamButton.Location = new System.Drawing.Point(553, 490);
            this.RemoveTeamButton.Name = "RemoveTeamButton";
            this.RemoveTeamButton.Size = new System.Drawing.Size(66, 23);
            this.RemoveTeamButton.TabIndex = 15;
            this.RemoveTeamButton.Text = "Удалить";
            this.RemoveTeamButton.UseVisualStyleBackColor = true;
            this.RemoveTeamButton.Click += new System.EventHandler(this.removeTeamButton_Click);
            // 
            // RemovePlayerButton
            // 
            this.RemovePlayerButton.Location = new System.Drawing.Point(916, 490);
            this.RemovePlayerButton.Name = "RemovePlayerButton";
            this.RemovePlayerButton.Size = new System.Drawing.Size(66, 23);
            this.RemovePlayerButton.TabIndex = 16;
            this.RemovePlayerButton.Text = "Удалить";
            this.RemovePlayerButton.UseVisualStyleBackColor = true;
            this.RemovePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 725);
            this.Controls.Add(this.RemovePlayerButton);
            this.Controls.Add(this.RemoveTeamButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxTeams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemoveTournamentButton);
            this.Controls.Add(this.listBoxTournaments);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTournaments;
        private System.Windows.Forms.Button addTournamentButton;
        private System.Windows.Forms.Button RemoveTournamentButton;
        private System.Windows.Forms.TextBox tournamentGameDisciplineText;
        private System.Windows.Forms.TextBox tournamentPrizepoolText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tournamentNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox playerSurnameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.TextBox playerNameText;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox playerNicknameText;
        private System.Windows.Forms.TextBox playerDateText;
        private System.Windows.Forms.Button RemoveTeamButton;
        private System.Windows.Forms.Button RemovePlayerButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}