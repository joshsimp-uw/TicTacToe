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
      playerNameLbl = new Label();
      nameLbl = new Label();
      enterNameLbl = new Label();
      playerNameTb = new TextBox();
      updateNameBtn = new Button();
      newGameBtn = new Button();
      resetGameBtn = new Button();
      resetStatsBtn = new Button();
      winsLbl = new Label();
      losesLbl = new Label();
      tiesLbl = new Label();
      tableLayoutPanel2 = new TableLayoutPanel();
      tiesCountLbl = new Label();
      losesCountLbl = new Label();
      winsCountLbl = new Label();
      turnLbl = new Label();
      turnStatusLbl = new Label();
      changeNameBtn = new Button();
      exitBtn = new Button();
      tableLayoutPanel1.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
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
      tableLayoutPanel1.Size = new Size(447, 441);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // a1Btn
      // 
      a1Btn.Dock = DockStyle.Fill;
      a1Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      a1Btn.Location = new Point(3, 3);
      a1Btn.Name = "a1Btn";
      a1Btn.Size = new Size(142, 140);
      a1Btn.TabIndex = 0;
      a1Btn.UseVisualStyleBackColor = true;
      a1Btn.Click += Square_Click;
      // 
      // a2Btn
      // 
      a2Btn.Dock = DockStyle.Fill;
      a2Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      a2Btn.Location = new Point(151, 3);
      a2Btn.Name = "a2Btn";
      a2Btn.Size = new Size(142, 140);
      a2Btn.TabIndex = 1;
      a2Btn.UseVisualStyleBackColor = true;
      a2Btn.Click += Square_Click;
      // 
      // a3Btn
      // 
      a3Btn.Dock = DockStyle.Fill;
      a3Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      a3Btn.Location = new Point(299, 3);
      a3Btn.Name = "a3Btn";
      a3Btn.Size = new Size(145, 140);
      a3Btn.TabIndex = 2;
      a3Btn.UseVisualStyleBackColor = true;
      a3Btn.Click += Square_Click;
      // 
      // b1Btn
      // 
      b1Btn.Dock = DockStyle.Fill;
      b1Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      b1Btn.Location = new Point(3, 149);
      b1Btn.Name = "b1Btn";
      b1Btn.Size = new Size(142, 141);
      b1Btn.TabIndex = 3;
      b1Btn.UseVisualStyleBackColor = true;
      b1Btn.Click += Square_Click;
      // 
      // b2Btn
      // 
      b2Btn.Dock = DockStyle.Fill;
      b2Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      b2Btn.Location = new Point(151, 149);
      b2Btn.Name = "b2Btn";
      b2Btn.Size = new Size(142, 141);
      b2Btn.TabIndex = 4;
      b2Btn.UseVisualStyleBackColor = true;
      b2Btn.Click += Square_Click;
      // 
      // b3Btn
      // 
      b3Btn.Dock = DockStyle.Fill;
      b3Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      b3Btn.Location = new Point(299, 149);
      b3Btn.Name = "b3Btn";
      b3Btn.Size = new Size(145, 141);
      b3Btn.TabIndex = 5;
      b3Btn.UseVisualStyleBackColor = true;
      b3Btn.Click += Square_Click;
      // 
      // c1Btn
      // 
      c1Btn.Dock = DockStyle.Fill;
      c1Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      c1Btn.Location = new Point(3, 296);
      c1Btn.Name = "c1Btn";
      c1Btn.Size = new Size(142, 142);
      c1Btn.TabIndex = 6;
      c1Btn.UseVisualStyleBackColor = true;
      c1Btn.Click += Square_Click;
      // 
      // c2Btn
      // 
      c2Btn.Dock = DockStyle.Fill;
      c2Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      c2Btn.Location = new Point(151, 296);
      c2Btn.Name = "c2Btn";
      c2Btn.Size = new Size(142, 142);
      c2Btn.TabIndex = 7;
      c2Btn.UseVisualStyleBackColor = true;
      c2Btn.Click += Square_Click;
      // 
      // c3Btn
      // 
      c3Btn.Dock = DockStyle.Fill;
      c3Btn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
      c3Btn.Location = new Point(299, 296);
      c3Btn.Name = "c3Btn";
      c3Btn.Size = new Size(145, 142);
      c3Btn.TabIndex = 8;
      c3Btn.UseVisualStyleBackColor = true;
      c3Btn.Click += Square_Click;
      // 
      // welcomeLbl
      // 
      welcomeLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
      welcomeLbl.Location = new Point(453, 9);
      welcomeLbl.Name = "welcomeLbl";
      welcomeLbl.Size = new Size(166, 70);
      welcomeLbl.TabIndex = 1;
      welcomeLbl.Text = "Welcome to Tic-Tac-Toe!";
      welcomeLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // playerNameLbl
      // 
      playerNameLbl.AutoSize = true;
      playerNameLbl.Location = new Point(455, 131);
      playerNameLbl.Name = "playerNameLbl";
      playerNameLbl.Size = new Size(77, 15);
      playerNameLbl.TabIndex = 2;
      playerNameLbl.Text = "Player Name:";
      // 
      // nameLbl
      // 
      nameLbl.AutoSize = true;
      nameLbl.Location = new Point(538, 131);
      nameLbl.Name = "nameLbl";
      nameLbl.Size = new Size(39, 15);
      nameLbl.TabIndex = 3;
      nameLbl.Text = "Name";
      // 
      // enterNameLbl
      // 
      enterNameLbl.AutoSize = true;
      enterNameLbl.Location = new Point(453, 79);
      enterNameLbl.Name = "enterNameLbl";
      enterNameLbl.Size = new Size(133, 15);
      enterNameLbl.TabIndex = 4;
      enterNameLbl.Text = "Please enter your name:";
      // 
      // playerNameTb
      // 
      playerNameTb.Location = new Point(455, 99);
      playerNameTb.Name = "playerNameTb";
      playerNameTb.Size = new Size(103, 23);
      playerNameTb.TabIndex = 5;
      playerNameTb.Text = "Enter name";
      // 
      // updateNameBtn
      // 
      updateNameBtn.Location = new Point(564, 99);
      updateNameBtn.Name = "updateNameBtn";
      updateNameBtn.Size = new Size(55, 23);
      updateNameBtn.TabIndex = 6;
      updateNameBtn.Text = "Update";
      updateNameBtn.UseVisualStyleBackColor = true;
      updateNameBtn.Click += updateNameBtn_Click;
      // 
      // newGameBtn
      // 
      newGameBtn.Location = new Point(455, 149);
      newGameBtn.Name = "newGameBtn";
      newGameBtn.Size = new Size(164, 23);
      newGameBtn.TabIndex = 7;
      newGameBtn.Text = "New Game";
      newGameBtn.UseVisualStyleBackColor = true;
      newGameBtn.Click += newGameBtn_Click;
      // 
      // resetGameBtn
      // 
      resetGameBtn.Location = new Point(455, 178);
      resetGameBtn.Name = "resetGameBtn";
      resetGameBtn.Size = new Size(164, 23);
      resetGameBtn.TabIndex = 8;
      resetGameBtn.Text = "Reset Game";
      resetGameBtn.UseVisualStyleBackColor = true;
      resetGameBtn.Click += resetGameBtn_Click;
      // 
      // resetStatsBtn
      // 
      resetStatsBtn.Location = new Point(455, 207);
      resetStatsBtn.Name = "resetStatsBtn";
      resetStatsBtn.Size = new Size(164, 23);
      resetStatsBtn.TabIndex = 9;
      resetStatsBtn.Text = "Reset Stats";
      resetStatsBtn.UseVisualStyleBackColor = true;
      resetStatsBtn.Click += resetStatsBtn_Click;
      // 
      // winsLbl
      // 
      winsLbl.AutoSize = true;
      winsLbl.Dock = DockStyle.Fill;
      winsLbl.Location = new Point(3, 41);
      winsLbl.Name = "winsLbl";
      winsLbl.Size = new Size(55, 41);
      winsLbl.TabIndex = 10;
      winsLbl.Text = "Wins: ";
      winsLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // losesLbl
      // 
      losesLbl.AutoSize = true;
      losesLbl.Dock = DockStyle.Fill;
      losesLbl.Location = new Point(3, 82);
      losesLbl.Name = "losesLbl";
      losesLbl.Size = new Size(55, 41);
      losesLbl.TabIndex = 11;
      losesLbl.Text = "Loses: ";
      losesLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // tiesLbl
      // 
      tiesLbl.AutoSize = true;
      tiesLbl.Dock = DockStyle.Fill;
      tiesLbl.Location = new Point(3, 123);
      tiesLbl.Name = "tiesLbl";
      tiesLbl.Size = new Size(55, 44);
      tiesLbl.TabIndex = 12;
      tiesLbl.Text = "Ties: ";
      tiesLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 2;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.46328F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.53672F));
      tableLayoutPanel2.Controls.Add(tiesLbl, 0, 3);
      tableLayoutPanel2.Controls.Add(losesLbl, 0, 2);
      tableLayoutPanel2.Controls.Add(winsLbl, 0, 1);
      tableLayoutPanel2.Controls.Add(tiesCountLbl, 1, 3);
      tableLayoutPanel2.Controls.Add(losesCountLbl, 1, 2);
      tableLayoutPanel2.Controls.Add(winsCountLbl, 1, 1);
      tableLayoutPanel2.Controls.Add(turnLbl, 0, 0);
      tableLayoutPanel2.Controls.Add(turnStatusLbl, 1, 0);
      tableLayoutPanel2.Dock = DockStyle.Bottom;
      tableLayoutPanel2.Location = new Point(447, 274);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 4;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel2.Size = new Size(177, 167);
      tableLayoutPanel2.TabIndex = 13;
      // 
      // tiesCountLbl
      // 
      tiesCountLbl.AutoSize = true;
      tiesCountLbl.Dock = DockStyle.Fill;
      tiesCountLbl.Location = new Point(64, 123);
      tiesCountLbl.Name = "tiesCountLbl";
      tiesCountLbl.Size = new Size(110, 44);
      tiesCountLbl.TabIndex = 15;
      tiesCountLbl.Text = "0";
      tiesCountLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // losesCountLbl
      // 
      losesCountLbl.AutoSize = true;
      losesCountLbl.Dock = DockStyle.Fill;
      losesCountLbl.Location = new Point(64, 82);
      losesCountLbl.Name = "losesCountLbl";
      losesCountLbl.Size = new Size(110, 41);
      losesCountLbl.TabIndex = 14;
      losesCountLbl.Text = "0";
      losesCountLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // winsCountLbl
      // 
      winsCountLbl.AutoSize = true;
      winsCountLbl.Dock = DockStyle.Fill;
      winsCountLbl.Location = new Point(64, 41);
      winsCountLbl.Name = "winsCountLbl";
      winsCountLbl.Size = new Size(110, 41);
      winsCountLbl.TabIndex = 13;
      winsCountLbl.Text = "0";
      winsCountLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // turnLbl
      // 
      turnLbl.AutoSize = true;
      turnLbl.Dock = DockStyle.Fill;
      turnLbl.Location = new Point(3, 0);
      turnLbl.Name = "turnLbl";
      turnLbl.Size = new Size(55, 41);
      turnLbl.TabIndex = 16;
      turnLbl.Text = "Turn:";
      turnLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // turnStatusLbl
      // 
      turnStatusLbl.AutoSize = true;
      turnStatusLbl.Dock = DockStyle.Fill;
      turnStatusLbl.ForeColor = SystemColors.ActiveCaptionText;
      turnStatusLbl.Location = new Point(64, 0);
      turnStatusLbl.Name = "turnStatusLbl";
      turnStatusLbl.Size = new Size(110, 41);
      turnStatusLbl.TabIndex = 17;
      turnStatusLbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // changeNameBtn
      // 
      changeNameBtn.Location = new Point(455, 99);
      changeNameBtn.Name = "changeNameBtn";
      changeNameBtn.Size = new Size(103, 23);
      changeNameBtn.TabIndex = 14;
      changeNameBtn.Text = "Change Name";
      changeNameBtn.UseVisualStyleBackColor = true;
      changeNameBtn.Visible = false;
      changeNameBtn.Click += changeNameBtn_Click;
      // 
      // exitBtn
      // 
      exitBtn.Location = new Point(455, 236);
      exitBtn.Name = "exitBtn";
      exitBtn.Size = new Size(164, 23);
      exitBtn.TabIndex = 15;
      exitBtn.Text = "Exit Game";
      exitBtn.UseVisualStyleBackColor = true;
      exitBtn.Click += exitBtn_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.GradientInactiveCaption;
      ClientSize = new Size(624, 441);
      Controls.Add(exitBtn);
      Controls.Add(changeNameBtn);
      Controls.Add(tableLayoutPanel2);
      Controls.Add(resetStatsBtn);
      Controls.Add(resetGameBtn);
      Controls.Add(newGameBtn);
      Controls.Add(updateNameBtn);
      Controls.Add(playerNameTb);
      Controls.Add(enterNameLbl);
      Controls.Add(nameLbl);
      Controls.Add(playerNameLbl);
      Controls.Add(welcomeLbl);
      Controls.Add(tableLayoutPanel1);
      MaximizeBox = false;
      MinimizeBox = false;
      MinimumSize = new Size(640, 480);
      Name = "Form1";
      ShowIcon = false;
      Text = "Tic-Tac-Toe";
      Load += Form1_Load;
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
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
    private Label playerNameLbl;
    private Label nameLbl;
    private Label enterNameLbl;
    private TextBox playerNameTb;
    private Button updateNameBtn;
    private Button newGameBtn;
    private Button resetGameBtn;
    private Button resetStatsBtn;
    private Label winsLbl;
    private Label losesLbl;
    private Label tiesLbl;
    private TableLayoutPanel tableLayoutPanel2;
    private Label winsCountLbl;
    private Label losesCountLbl;
    private Label tiesCountLbl;
    private Button changeNameBtn;
    private Label turnLbl;
    private Label turnStatusLbl;
    private Button exitBtn;
  }
}
