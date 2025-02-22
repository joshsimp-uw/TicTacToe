namespace TicTacToe
{
  public partial class Form1 : Form
  {
    // Private Variables
    // Button[], squares        : The array of button objects for the game, 0-8
    // bool    , isPlayerTurn   : Tracks to see if it is the player's turn or computer's
    // char    , playerMarker   : Assigned marker ('X' or 'O') to the player
    // char    , computerMarker : Assigned marker ('X' or 'O') to the computer
    // Random  , random         : Random number generator object.
    // int     , playerWins     : Tracks the number of player wins
    // int     , computerWins   : Tracks the number of player losses
    // int     , ties           : Tracks the number of ties
    // string  , statsFilePath  : Stores the location of the statistics file.
    private Button[] squares;
    private bool isPlayerTurn;
    private char playerMarker;
    private char computerMarker;
    private Random random;
    private int playerWins = 0;
    private int computerWins = 0;
    private int ties = 0;
    private string playerName = string.Empty;
    private readonly string statsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stats.txt");

    /// <summary>
    /// After the form initializes: initialize components, 
    /// wire the buttons and initialize the random variable
    /// </summary>
    public Form1()
    {
      InitializeComponent();

      // Assign the squares array
      squares = [a1Btn, a2Btn, a3Btn, b1Btn, b2Btn, b3Btn, c1Btn, c2Btn, c3Btn];

      //assign the random object
      random = new Random();

    }

    /// <summary>
    /// When the form loads, import statistic and initialize a game.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e)
    {
      LoadStatistics();
    }

    /// <summary>
    /// Saves statistic on form close
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_FormClosed(object sender, EventArgs e)
    {
      SaveStatistics();
    }

    /// <summary>
    /// Initializes (or reinitializes) the game.
    /// Sets all markers to ""
    /// Enables all buttons.
    /// Assigns markers to players
    /// </summary>
    private void InitializeGame()
    {
      // Reset all squares
      foreach (var square in squares)
      {
        square.Text = "";
        square.Enabled = true;
      }

      // Randomly decide who goes first
      isPlayerTurn = random.Next(2) == 0;
      playerMarker = isPlayerTurn ? 'X' : 'O';
      computerMarker = isPlayerTurn ? 'O' : 'X';

      // Update the status label to indicate the human player's marker
      turnStatusLbl.Text = isPlayerTurn ? "Your turn" : "Computer's turn";


      // Once the Player's turn is done, then the Computer will make their move
      if (!isPlayerTurn)
        ComputerMove();
    }

    /// <summary>
    /// Primary Game Logic
    /// Wired method for all game button clicks.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Square_Click(object sender, EventArgs e)
    {
      // reassign the object as a button (since it is)
      var button = (Button)sender;

      //Player will select a button and the text of the button will update to their given marker (X or O)
      button.Text += playerMarker;
      button.Enabled = false;

      // Check for a winner when the button is clicked. 
      if (CheckForWinner(playerMarker))
      {
        //If the board shows a tic tac toe winner for the Player the status text will declare the Player the winner
        winsCountLbl.Text = (int.Parse(winsCountLbl.Text) + 1).ToString(); // Update wins count
        turnStatusLbl.Text = $"You win, {playerName}!";
        turnStatusLbl.ForeColor = Color.Green;
        DisableAllSquares();
        SaveStatistics(); // Save statistics after a win
        return;
      }

      // Check to see if the board is full
      if (IsBoardFull())
      {
        //If the board is full with no clear winner then the status text will declare a tie
        ties++;
        tiesCountLbl.Text = ties.ToString(); // Update ties count
        turnStatusLbl.Text = "It's a tie!";
        SaveStatistics(); // Save statistics after a tie
        return;
      }



    }

    /// <summary>
    /// Makes a random move on behalf of the "computer" opponent.
    /// </summary>
    private void ComputerMove()
    {
      //Computer will select a square to place their if a space is available
      // this logic is the same as if the board is full. Use isBoardFull()
      // This could be a large nested if statement if (!BoardFull())
      var availableSquares = squares.Where(s => s.Text == "").ToList();
      if (availableSquares.Count == 0) return;

      var randomSquare = availableSquares[random.Next(availableSquares.Count)];
      randomSquare.Text = computerMarker.ToString();
      randomSquare.Enabled = false;

      if (CheckForWinner(computerMarker))
      {
        //If the board shows a tic tac toe winner for the Computer the status text will declare the Computer the winner
        computerWins++;
        losesCountLbl.Text = computerWins.ToString(); // Update losses count
        turnStatusLbl.Text = $"Computer wins!";
        DisableAllSquares();
        SaveStatistics(); // Save statistics after a loss
      }
      else if (!CheckForWinner(computerMarker) && !IsBoardFull())
      {
        // Update the status label to indicate the human player's turn
        turnStatusLbl.Text = $"Your turn, {playerMarker}!";
      }
      else if (IsBoardFull())
      {
        //If the board is full with no clear winner then the status text will declare a tie
        ties++;
        tiesCountLbl.Text = ties.ToString(); // Update ties count
        turnStatusLbl.Text = "It's a tie!";
        SaveStatistics(); // Save statistics after a tie
      }
    }

    /// <summary>
    /// Checks the player marker against all the possible winning combinations.
    /// </summary>
    /// <param name="marker"></param>
    /// <returns>Boolean: True if all markers in a row, column, or diagonal match the input marker. </returns>
    private bool CheckForWinner(char marker)
    {
      // Check rows, columns, and diagonals for a winner
      return (squares[0].Text == marker.ToString() && squares[1].Text == marker.ToString() && squares[2].Text == marker.ToString()) || // Row 1
             (squares[3].Text == marker.ToString() && squares[4].Text == marker.ToString() && squares[5].Text == marker.ToString()) || // Row 2
             (squares[6].Text == marker.ToString() && squares[7].Text == marker.ToString() && squares[8].Text == marker.ToString()) || // Row 3
             (squares[0].Text == marker.ToString() && squares[3].Text == marker.ToString() && squares[6].Text == marker.ToString()) || // Column 1
             (squares[1].Text == marker.ToString() && squares[4].Text == marker.ToString() && squares[7].Text == marker.ToString()) || // Column 2
             (squares[2].Text == marker.ToString() && squares[5].Text == marker.ToString() && squares[8].Text == marker.ToString()) || // Column 3
             (squares[0].Text == marker.ToString() && squares[4].Text == marker.ToString() && squares[8].Text == marker.ToString()) || // Diagonal 1
             (squares[2].Text == marker.ToString() && squares[4].Text == marker.ToString() && squares[6].Text == marker.ToString());   // Diagonal 2
    }

    /// <summary>
    /// Check to see if the board is full
    /// </summary>
    /// <returns>
    /// True if board is all buttons are marked,
    /// else false.
    /// </returns>
    private bool IsBoardFull()
    {
      return squares.All(s => s.Text != "");
    }

    /// <summary>
    /// Disables all squares from being clicked
    /// </summary>
    private void DisableAllSquares()
    {
      foreach (var square in squares)
        square.Enabled = false;
    }

    /// <summary>
    /// Enables all squares to be clicked.
    ///</summary>
    private void EnableGame()
    {
      foreach (var square in squares)
        square.Enabled = false;
      changeNameBtn.Enabled = true;
      newGameBtn.Enabled = true;
      resetGameBtn.Enabled = true;
      resetStatsBtn.Enabled = true;
      exitBtn.Enabled = true;
      a1Btn.Enabled = true;
    }

    /// <summary>
    /// Loads statistics into memory from previous game sessions
    /// if the text document is found.
    /// </summary>
    private void LoadStatistics()
    {
      // Check if the stats file exists
      if (File.Exists(statsFilePath))
      {
        // Read the file and load the statistics
        string[] stats = File.ReadAllLines(statsFilePath);
        if (stats.Length == 3)
        {
          playerWins = int.Parse(stats[0]);
          computerWins = int.Parse(stats[1]);
          ties = int.Parse(stats[2]);

          // Update the labels using the stats text file
          winsCountLbl.Text = playerWins.ToString();
          losesCountLbl.Text = computerWins.ToString();
          tiesCountLbl.Text = ties.ToString();
        }
      }
    }

    /// <summary>
    /// Saves current statistics to file for retrival later.
    /// </summary>
    private void SaveStatistics()
    {
      // Save the statistics to the file
      string[] stats = { playerWins.ToString(), computerWins.ToString(), ties.ToString() };
      File.WriteAllLines(statsFilePath, stats);
    }

    /// <summary>
    /// Initializes a new game when the "New Game" button
    /// is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void newGameBtn_Click(object sender, EventArgs e)
    {
      InitializeGame();
    }

    /// <summary>
    /// Saves the statistics when the Exit button is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void exitBtn_Click(object sender, EventArgs e)
    {
      //Exit button will close the application
      SaveStatistics(); // Save statistics before exiting

      Application.Exit();
    }

    /// <summary>
    /// Updates the player name. Hides input buttons.
    /// Shows the "change name" button.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void updateNameBtn_Click(object sender, EventArgs e)
    {
      if (playerNameTb.Text != "")
      {
        playerName = playerNameTb.Text;
        welcomeLbl.Text = $"Welcome, {playerName}!";
        playerNameTb.Visible = false;
        enterNameLbl.Visible = false;
        updateNameBtn.Visible = false;
        welcomeLbl.Visible = true;
        changeNameBtn.Visible = true;
        EnableGame();
        InitializeGame();
      }

    }

    /// <summary>
    /// Allows a user to change their name when the button is pressed.
    /// Hides the "Change Name" button and shows input button.
    /// Sets the name to nothing.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void changeNameBtn_Click(object sender, EventArgs e)
    {
      playerNameTb.Text = "";
      playerName = "";
      welcomeLbl.Visible = false;
      changeNameBtn.Visible = false;
      playerNameTb.Visible = true;
      enterNameLbl.Visible = true;
      updateNameBtn.Visible = true;

    }

    /// <summary>
    /// Reset Game Button: Resets the game by initializing all the values.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void resetGameBtn_Click(object sender, EventArgs e)
    {
      InitializeGame();
    }

    /// <summary>
    /// Reset Stats Button: resets all the statistics to 0.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void resetStatsBtn_Click(object sender, EventArgs e)
    {
      winsCountLbl.Text = "0";
      losesCountLbl.Text = "0";
      tiesCountLbl.Text = "0";
    }
  }
}
