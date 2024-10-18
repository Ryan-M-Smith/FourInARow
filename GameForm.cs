//
// Author: Ryan Smith
// Created: 10/9/24
// Filename: GameForm.cs
// Description: The main application form
//

using System.Data.Common;
using System.Diagnostics;
using System.Drawing;

namespace FourInARowGUI {
	public partial class GameForm : Form {
		private int SelectedColumn { get; set; }
		private int Turn { get; set; } = 0;
		private bool GameOver { get; set; } = false;
		private bool IsTie { get; set; } = false;

		/// <summary>
		/// The symbol used to represent player pieces on the game board.
		/// 
		/// With the Webdings font, the lowercase letter n shows up as a circle with minimal drop space,
		/// which provides better alignment within the RichTextBox than a circle Unicode character
		/// does.
		/// </summary>
		private const string _symbol = "n";

		private readonly Board _board;

		private static readonly TurnController _turnController = new();

		public GameForm() {
			InitializeComponent();

			_board = [
				new() {space0,  space1,  space2,  space3,  space4,  space5},
				new() {space6,  space7,  space8,  space9,  space10, space11},
				new() {space12, space13, space14, space15, space16, space17},
				new() {space18, space19, space20, space21, space22, space23},
				new() {space24, space25, space26, space27, space28, space29},
				new() {space30, space31, space32, space33, space34, space35},
			];

			_turnController.OnTurnUpdate += TakeTurn;
		}

		public int GetColumnIndex(object sender) {
			int column = -1;

			for (int i = 0; i < Board.Columns && column == -1; i++) {
				column = _board[i].FindIndex(0, _board[i].Count, sender.Equals);
			}

			return column;
		}

		private async void TakeTurn(object sender, TurnEventArgs e) {
			if (GameOver) {
				e.Turn--;

				if (IsTie) {
					infoBox.Text = "Tie Game!";
				}
				else if (e.Turn % 2 == 0) {
					infoBox.Text = "Congratulations!\n\nYou Won!";
				}
				else if (e.Turn % 2 == 1) {
					infoBox.Text = "The CPU Won!";
				}

				return;
			}

			// Player turns are handled by the click event
			if (e.Turn % 2 == 0) {
				infoBox.Text = "It's your turn!\n\nClick a column to play your piece.";
				return;
			}

			infoBox.Text = "It's the CPU's turn.\n\nThinking";

			for (int i = 0; i < 9; i++) {
				if (i > 0 && i % 3 == 0) {
					infoBox.Text = infoBox.Text.Remove(infoBox.Text.Length - 3, 3);
					await Task.Delay(100);
				}

				infoBox.Text += ".";
				await Task.Delay(100);
			}

			// Choose a column for the CPU to play in
			Random random = new();
			int column;

			do {
				column = random.Next(0, Board.Columns);
			} while (_board.IsFull(column));

			await PlayPiece(column);
			_turnController.SwitchTurns(++Turn);
		}

		/// <summary>
		/// Highlight the winning row on the game board
		/// </summary>
		private void HighlightWinner() {
			foreach (RowType row in _board) {
				foreach (Space space in row) {
					// Color all filled spaces gray except for the winning row
					if (!space.IsEmpty() && !Validator.Solution.Contains(space)) {
						space.ForeColor = Color.Gray;
					}
				}
			}
		}

		private void ColumnHighlight(object sender, EventArgs e) {
			SelectedColumn = GetColumnIndex(sender);
			var column = _board.GetColumn(SelectedColumn);
			column.ForEach(space => space.BackColor = Color.LightGray);
		}

		private void UndoColumnHighlight(object sender, EventArgs e) {
			SelectedColumn = GetColumnIndex(sender);
			var column = _board.GetColumn(SelectedColumn);
			column.ForEach(space => space.BackColor = Color.White);
		}

		private void Unfocus(object sender, EventArgs e) {
			ActiveControl = null;
		}

		private async void PlayColumn(object sender, EventArgs e) {
			if (Turn % 2 != 0 || GameOver) {
				return;
			}

			await PlayPiece(SelectedColumn);
			_turnController.SwitchTurns(++Turn);
		}

		/// <summary>
		/// Play a piece in the game board
		/// </summary>
		private async Task PlayPiece(int columnIdx) {
			ColumnType column = _board.GetColumn(columnIdx);
			Space? previous = null;
			int rowIdx = -1;

			// Simulate the piece falling into place
			foreach (var current in column) {
				// The piece stops at the lowest possible space it can fall into
				if (!current.IsEmpty()) {
					break;
				}

				current.ForeColor = (Turn % 2 == 0) ? Color.DodgerBlue : Color.Red;

				previous?.Clear();      // Clear the previous board space
				current.Text = _symbol; // Update the current board space 
				previous = current;     // Update the previous board space
				await Task.Delay(20);   // Add a slight delay so the animation is visible

				rowIdx++;
			}

			if (Validator.IsTie(_board)) {
				GameOver = true;
				IsTie = true;

				playAgainButton.Show();
				menuButton.Show();
			}
			else if (Validator.DidWin(new Point(rowIdx, columnIdx), _board)) {
				GameOver = true;

				HighlightWinner();

				playAgainButton.Show();
				menuButton.Show();
			}
		}

		/// <summary>
		/// Start the game if the play button is clicked
		/// </summary>
		/// <param name="sender">The object sending the event</param>
		/// <param name="e">The event to handle</param>
		private void PlayButton_Click(object sender, EventArgs e) {
			menuPanel.Hide();
		}

		/// <summary>
		/// Quit the game if the quit button is clicked
		/// </summary>
		/// <param name="sender">The object sending the event</param>
		/// <param name="e">The event to handle</param>
		private void QuitButton_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		/// <summary>
		/// Restart the game if the button is clicked
		/// </summary>
		/// <param name="sender">The object sending the event</param>
		/// <param name="e">The event to handle</param>
		private void PlayAgainButton_Click(object sender, EventArgs e) {
			GameOver = false;
			IsTie = false;

			_board.Clear();

			playAgainButton.Hide();
			menuButton.Hide();

			_turnController.SwitchTurns(Turn = 0);
		}

		private void MenuButton_Click(object sender, EventArgs e) {
			GameOver = false;
			IsTie = false;

			_board.Clear();

			playAgainButton.Hide();
			menuButton.Hide();

			menuPanel.Show();
		}
	}
}
