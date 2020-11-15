namespace TakiClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateGameButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CardsTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.CreateGamePanel = new System.Windows.Forms.Panel();
            this.JoinGamePanel = new System.Windows.Forms.Panel();
            this.JoinGameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LobbyName = new System.Windows.Forms.TextBox();
            this.submitCreateGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.transparentControl3 = new TakiClient.TransparentControl();
            this.transparentControl2 = new TakiClient.TransparentControl();
            this.transparentControl1 = new TakiClient.TransparentControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GamePanel.SuspendLayout();
            this.CreateGamePanel.SuspendLayout();
            this.JoinGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.StartGame);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CreateGameButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 623);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::TakiClient.Properties.Resources.chain_end_30px;
            this.button4.Location = new System.Drawing.Point(0, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 79);
            this.button4.TabIndex = 1;
            this.button4.Text = "End Game";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.StartGame.FlatAppearance.BorderSize = 0;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.White;
            this.StartGame.Image = global::TakiClient.Properties.Resources.start_24px;
            this.StartGame.Location = new System.Drawing.Point(2, 281);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(163, 79);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start Game";
            this.StartGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StartGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(2, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Join a Game";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateGameButton
            // 
            this.CreateGameButton.FlatAppearance.BorderSize = 0;
            this.CreateGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateGameButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGameButton.ForeColor = System.Drawing.Color.White;
            this.CreateGameButton.Image = global::TakiClient.Properties.Resources.create_30px;
            this.CreateGameButton.Location = new System.Drawing.Point(0, 119);
            this.CreateGameButton.Name = "CreateGameButton";
            this.CreateGameButton.Size = new System.Drawing.Size(163, 79);
            this.CreateGameButton.TabIndex = 1;
            this.CreateGameButton.Text = "Create a Game";
            this.CreateGameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateGameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CreateGameButton.UseVisualStyleBackColor = true;
            this.CreateGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(130)))), ((int)(((byte)(187)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 76);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(130)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 76);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(130)))), ((int)(((byte)(187)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 76);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(130)))), ((int)(((byte)(187)))));
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 76);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TakiClient.Properties.Resources.TAKI_logo;
            this.pictureBox5.Location = new System.Drawing.Point(12, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TakiClient.Properties.Resources.TAKI_logo;
            this.pictureBox4.Location = new System.Drawing.Point(12, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TakiClient.Properties.Resources.TAKI_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TakiClient.Properties.Resources.TAKI_logo;
            this.pictureBox3.Location = new System.Drawing.Point(12, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // CardsTimer
            // 
            this.CardsTimer.Interval = 50;
            this.CardsTimer.Tick += new System.EventHandler(this.CardsTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.CreateGamePanel);
            this.GamePanel.Controls.Add(this.pictureBox2);
            this.GamePanel.Controls.Add(this.transparentControl3);
            this.GamePanel.Location = new System.Drawing.Point(169, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(787, 623);
            this.GamePanel.TabIndex = 3;
            this.GamePanel.Visible = false;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CreateGamePanel
            // 
            this.CreateGamePanel.Controls.Add(this.JoinGamePanel);
            this.CreateGamePanel.Controls.Add(this.LobbyName);
            this.CreateGamePanel.Controls.Add(this.submitCreateGame);
            this.CreateGamePanel.Controls.Add(this.label1);
            this.CreateGamePanel.Location = new System.Drawing.Point(172, 210);
            this.CreateGamePanel.Name = "CreateGamePanel";
            this.CreateGamePanel.Size = new System.Drawing.Size(361, 140);
            this.CreateGamePanel.TabIndex = 8;
            // 
            // JoinGamePanel
            // 
            this.JoinGamePanel.Controls.Add(this.JoinGameText);
            this.JoinGamePanel.Controls.Add(this.button1);
            this.JoinGamePanel.Controls.Add(this.label2);
            this.JoinGamePanel.Location = new System.Drawing.Point(3, 0);
            this.JoinGamePanel.Name = "JoinGamePanel";
            this.JoinGamePanel.Size = new System.Drawing.Size(361, 140);
            this.JoinGamePanel.TabIndex = 9;
            // 
            // JoinGameText
            // 
            this.JoinGameText.BackColor = System.Drawing.SystemColors.Window;
            this.JoinGameText.Location = new System.Drawing.Point(141, 30);
            this.JoinGameText.Name = "JoinGameText";
            this.JoinGameText.Size = new System.Drawing.Size(203, 27);
            this.JoinGameText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "GameId";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LobbyName
            // 
            this.LobbyName.BackColor = System.Drawing.SystemColors.Window;
            this.LobbyName.Location = new System.Drawing.Point(141, 30);
            this.LobbyName.Name = "LobbyName";
            this.LobbyName.Size = new System.Drawing.Size(203, 27);
            this.LobbyName.TabIndex = 6;
            // 
            // submitCreateGame
            // 
            this.submitCreateGame.Location = new System.Drawing.Point(21, 75);
            this.submitCreateGame.Name = "submitCreateGame";
            this.submitCreateGame.Size = new System.Drawing.Size(88, 30);
            this.submitCreateGame.TabIndex = 7;
            this.submitCreateGame.Text = "Submit";
            this.submitCreateGame.UseVisualStyleBackColor = true;
            this.submitCreateGame.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lobby Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(130)))), ((int)(((byte)(187)))));
            this.pictureBox2.Image = global::TakiClient.Properties.Resources.TAKI_logo;
            this.pictureBox2.Location = new System.Drawing.Point(221, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(273, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // transparentControl3
            // 
            this.transparentControl3.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl3.Image = null;
            this.transparentControl3.Location = new System.Drawing.Point(91, 193);
            this.transparentControl3.Name = "transparentControl3";
            this.transparentControl3.Size = new System.Drawing.Size(75, 23);
            this.transparentControl3.TabIndex = 0;
            this.transparentControl3.Text = "transparentControl3";
            // 
            // transparentControl2
            // 
            this.transparentControl2.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl2.Image = global::TakiClient.Properties.Resources.back_card_final;
            this.transparentControl2.Location = new System.Drawing.Point(286, 119);
            this.transparentControl2.Name = "transparentControl2";
            this.transparentControl2.Size = new System.Drawing.Size(300, 300);
            this.transparentControl2.TabIndex = 2;
            this.transparentControl2.Text = "transparentControl2";
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.Transparent;
            this.transparentControl1.Image = global::TakiClient.Properties.Resources.yellow_3;
            this.transparentControl1.Location = new System.Drawing.Point(470, 120);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Size = new System.Drawing.Size(300, 300);
            this.transparentControl1.TabIndex = 1;
            this.transparentControl1.Text = "transparentControl1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(959, 623);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transparentControl2);
            this.Controls.Add(this.transparentControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.CreateGamePanel.ResumeLayout(false);
            this.CreateGamePanel.PerformLayout();
            this.JoinGamePanel.ResumeLayout(false);
            this.JoinGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateGameButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer CardsTimer;
        private TransparentControl transparentControl1;
        private TransparentControl transparentControl2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel GamePanel;
        private TransparentControl transparentControl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LobbyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitCreateGame;
        private System.Windows.Forms.Panel JoinGamePanel;
        private System.Windows.Forms.TextBox JoinGameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CreateGamePanel;
    }
}

