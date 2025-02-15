namespace TicTacToe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            a1Btn = new Button();
            a2Btn = new Button();
            a3Btn = new Button();
            b1Btn = new Button();
            b2Btn = new Button();
            b3Btn = new Button();
            c1Btn = new Button();
            c2Btn = new Button();
            c3Btn = new Button();
            welcomeLbl = new Label();
            lblStatus = new Label();
            btnNewGame = new Button();
            btnExit = new Button();
            lblWins = new Label();
            lblTies = new Label();
            lblLosses = new Label();
            lblTiesCount = new Label();
            lblWinsCount = new Label();
            lblLossesCount = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(a1Btn, 0, 0);
            tableLayoutPanel1.Controls.Add(a2Btn, 1, 0);
            tableLayoutPanel1.Controls.Add(a3Btn, 2, 0);
            tableLayoutPanel1.Controls.Add(b1Btn, 0, 1);
            tableLayoutPanel1.Controls.Add(b2Btn, 1, 1);
            tableLayoutPanel1.Controls.Add(b3Btn, 2, 1);
            tableLayoutPanel1.Controls.Add(c1Btn, 0, 2);
            tableLayoutPanel1.Controls.Add(c2Btn, 1, 2);
            tableLayoutPanel1.Controls.Add(c3Btn, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(447, 464);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // a1Btn
            // 
            a1Btn.Dock = DockStyle.Fill;
            a1Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a1Btn.Location = new Point(3, 3);
            a1Btn.Name = "a1Btn";
            a1Btn.Size = new Size(142, 148);
            a1Btn.TabIndex = 0;
            a1Btn.Text = "X";
            a1Btn.UseVisualStyleBackColor = true;
            // 
            // a2Btn
            // 
            a2Btn.Dock = DockStyle.Fill;
            a2Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a2Btn.Location = new Point(151, 3);
            a2Btn.Name = "a2Btn";
            a2Btn.Size = new Size(142, 148);
            a2Btn.TabIndex = 1;
            a2Btn.Text = "X";
            a2Btn.UseVisualStyleBackColor = true;
            // 
            // a3Btn
            // 
            a3Btn.Dock = DockStyle.Fill;
            a3Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a3Btn.Location = new Point(299, 3);
            a3Btn.Name = "a3Btn";
            a3Btn.Size = new Size(145, 148);
            a3Btn.TabIndex = 2;
            a3Btn.Text = "X";
            a3Btn.UseVisualStyleBackColor = true;
            // 
            // b1Btn
            // 
            b1Btn.Dock = DockStyle.Fill;
            b1Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1Btn.Location = new Point(3, 157);
            b1Btn.Name = "b1Btn";
            b1Btn.Size = new Size(142, 148);
            b1Btn.TabIndex = 3;
            b1Btn.Text = "X";
            b1Btn.UseVisualStyleBackColor = true;
            // 
            // b2Btn
            // 
            b2Btn.Dock = DockStyle.Fill;
            b2Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b2Btn.Location = new Point(151, 157);
            b2Btn.Name = "b2Btn";
            b2Btn.Size = new Size(142, 148);
            b2Btn.TabIndex = 4;
            b2Btn.Text = "X";
            b2Btn.UseVisualStyleBackColor = true;
            // 
            // b3Btn
            // 
            b3Btn.Dock = DockStyle.Fill;
            b3Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b3Btn.Location = new Point(299, 157);
            b3Btn.Name = "b3Btn";
            b3Btn.Size = new Size(145, 148);
            b3Btn.TabIndex = 5;
            b3Btn.Text = "X";
            b3Btn.UseVisualStyleBackColor = true;
            // 
            // c1Btn
            // 
            c1Btn.Dock = DockStyle.Fill;
            c1Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c1Btn.Location = new Point(3, 311);
            c1Btn.Name = "c1Btn";
            c1Btn.Size = new Size(142, 150);
            c1Btn.TabIndex = 6;
            c1Btn.Text = "X";
            c1Btn.UseVisualStyleBackColor = true;
            // 
            // c2Btn
            // 
            c2Btn.Dock = DockStyle.Fill;
            c2Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c2Btn.Location = new Point(151, 311);
            c2Btn.Name = "c2Btn";
            c2Btn.Size = new Size(142, 150);
            c2Btn.TabIndex = 7;
            c2Btn.Text = "X";
            c2Btn.UseVisualStyleBackColor = true;
            // 
            // c3Btn
            // 
            c3Btn.Dock = DockStyle.Fill;
            c3Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c3Btn.Location = new Point(299, 311);
            c3Btn.Name = "c3Btn";
            c3Btn.Size = new Size(145, 150);
            c3Btn.TabIndex = 8;
            c3Btn.Text = "X";
            c3Btn.UseVisualStyleBackColor = true;
            // 
            // welcomeLbl
            // 
            welcomeLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(453, 9);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(198, 107);
            welcomeLbl.TabIndex = 1;
            welcomeLbl.Text = "Welcome to Tic-Tac-Toe!";
            welcomeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 15F);
            lblStatus.Location = new Point(450, 146);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 28);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNewGame
            // 
            btnNewGame.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewGame.Location = new Point(467, 438);
            btnNewGame.MinimumSize = new Size(75, 25);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(75, 25);
            btnNewGame.TabIndex = 3;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(593, 439);
            btnExit.MinimumSize = new Size(75, 25);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 25);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblWins
            // 
            lblWins.AutoSize = true;
            lblWins.Location = new Point(449, 222);
            lblWins.Name = "lblWins";
            lblWins.Size = new Size(33, 15);
            lblWins.TabIndex = 5;
            lblWins.Text = "Wins";
            // 
            // lblTies
            // 
            lblTies.AutoSize = true;
            lblTies.Location = new Point(531, 222);
            lblTies.Name = "lblTies";
            lblTies.Size = new Size(27, 15);
            lblTies.TabIndex = 6;
            lblTies.Text = "Ties";
            // 
            // lblLosses
            // 
            lblLosses.AutoSize = true;
            lblLosses.Location = new Point(613, 222);
            lblLosses.Name = "lblLosses";
            lblLosses.Size = new Size(41, 15);
            lblLosses.TabIndex = 7;
            lblLosses.Text = "Losses";
            // 
            // lblTiesCount
            // 
            lblTiesCount.AutoSize = true;
            lblTiesCount.Location = new Point(531, 237);
            lblTiesCount.Name = "lblTiesCount";
            lblTiesCount.Size = new Size(13, 15);
            lblTiesCount.TabIndex = 8;
            lblTiesCount.Text = "0";
            // 
            // lblWinsCount
            // 
            lblWinsCount.AutoSize = true;
            lblWinsCount.Location = new Point(449, 237);
            lblWinsCount.Name = "lblWinsCount";
            lblWinsCount.Size = new Size(13, 15);
            lblWinsCount.TabIndex = 9;
            lblWinsCount.Text = "0";
            // 
            // lblLossesCount
            // 
            lblLossesCount.AutoSize = true;
            lblLossesCount.Location = new Point(613, 237);
            lblLossesCount.Name = "lblLossesCount";
            lblLossesCount.Size = new Size(13, 15);
            lblLossesCount.TabIndex = 10;
            lblLossesCount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(669, 464);
            Controls.Add(lblLossesCount);
            Controls.Add(lblWinsCount);
            Controls.Add(lblTiesCount);
            Controls.Add(lblLosses);
            Controls.Add(lblTies);
            Controls.Add(lblWins);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Controls.Add(lblStatus);
            Controls.Add(welcomeLbl);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(640, 480);
            Name = "Form1";
            ShowIcon = false;
            Text = "Tic-Tac-Toe";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    private Button a2Btn;
    private Button a1Btn;
    private Button a3Btn;
    private Button b1Btn;
    private Button b2Btn;
    private Button b3Btn;
    private Button c1Btn;
    private Button c2Btn;
    private Button c3Btn;
    private Label welcomeLbl;
        private Label lblStatus;
        private Button btnNewGame;
        private Button btnExit;
        private Label lblWins;
        private Label lblTies;
        private Label lblLosses;
        private Label lblTiesCount;
        private Label lblWinsCount;
        private Label lblLossesCount;
    }
}
