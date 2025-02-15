namespace TicTacToe
{
  public partial class Form1 : Form
  {
    // Private Variable
    private Button[,] squares = new Button[3,3];
    private bool isPlayerTurn;
    private char playerMarker;
    private char computerMarker;
    private Random random;

    // Player's name
    private string playerName = "Player";

    // Variables to track wins, ties, and losses
    private int playerWins = 0;
    private int computerWins = 0;
    private int ties = 0;

    // File path to save and load statistics which said text file will be saved in the same folder or location as the executable
    private readonly string statsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stats.txt");


    public Form1()
    {
      InitializeComponent();
    }

    private void a1Btn_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      LoadStatistics();
    }

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
      if (turnStatusLbl.Text = isPlayerTurn)
      { 
        turnStatusLbl.Text = "Your turn";
        turnStatusLbl.ForeColor = Color.Green;
      }
      else
      {
        turnStatusLbl.Text = "Computer's turn";
        turnStatusLbl.ForeColor = Color.Red;
      } 

      // Once the Player's turn is done, then the Computer will make their move
      if (!isPlayerTurn)
        ComputerMove();
    }

    private void Square_Click(object sender, EventArgs e)
    {
      var button = (Button)sender;
      if (button.Text != "") return;

      //Player will select a button and the text of the button will update to their chosen marker (X or O)
      button.Text = playerMarker.ToString();
      button.Enabled = false;

      if (CheckForWinner(playerMarker))
      {
        //If the board shows a tic tac toe winner for the Player the status text will declare the Player the winner
        playerWins++;
        winsCountLbl.Text = playerWins.ToString(); // Update wins count
        turnStatusLbl.Text = $"You win, {playerName}!";
        DisableAllSquares();
        SaveStatistics(); // Save statistics after a win
        return;
      }

      if (IsBoardFull())
      {
        //If the board is full with no clear winner then the status text will declare a tie
        ties++;
        lblTiesCount.Text = ties.ToString(); // Update ties count
        lblStatus.Text = "It's a tie!";
        SaveStatistics(); // Save statistics after a tie
        return;
      }

      ComputerMove();
    }

    private void ComputerMove()
    {
      //Computer will select a square to place their marker if available
      var availableSquares = squares.Where(s => s.Text == "").ToList();
      if (availableSquares.Count == 0) return;

      var randomSquare = availableSquares[random.Next(availableSquares.Count)];
      randomSquare.Text = computerMarker.ToString();
      randomSquare.Enabled = false;

      if (CheckForWinner(computerMarker))
      {
        //If the board shows a tic tac toe winner for the Computer the status text will declare the Computer the winner
        computerWins++;
        lblLossesCount.Text = computerWins.ToString(); // Update losses count
        lblStatus.Text = $"Computer wins! Better luck next time {playerName}.";
        DisableAllSquares();
        SaveStatistics(); // Save statistics after a loss
        return;
      }

      if (IsBoardFull())
      {
        //If the board is full with no clear winner then the status text will declare a tie
        ties++;
        lblTiesCount.Text = ties.ToString(); // Update ties count
        lblStatus.Text = "It's a tie!";
        SaveStatistics(); // Save statistics after a tie
        return;
      }

      // Update the status label to indicate the human player's turn
      lblStatus.Text = $"Your turn (You are {playerMarker})";
    }

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
    private bool IsBoardFull()
    {
      return squares.All(s => s.Text != "");
    }

    private void DisableAllSquares()
    {
      foreach (var square in squares)
        square.Enabled = false;
    }



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
          lossesCountLbl.Text = computerWins.ToString();
          tiesCountLbl.Text = ties.ToString();
        }
      }
    }

    private void SaveStatistics()
    {
      // Save the statistics to the file
      string[] stats = { playerWins.ToString(), computerWins.ToString(), ties.ToString() };
      File.WriteAllLines(statsFilePath, stats);
    }
  }
}
