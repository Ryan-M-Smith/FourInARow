//
// Author: Ryan Smith
// Created: 10/15/24
// Filename: Validator.cs
// Description: Determine if someone won the game
//

namespace FourInARowGUI {
	/// <summary>
	/// Extensions for the <c>RichTextBox</c>
	/// </summary>
	public static class RichTextBoxExtentions {
		/// <summary>
		/// Determine if two spaces were played by the same player
		/// </summary>
		/// 
		/// <param name="lhs">The left-hand (caller) object</param>
		/// <param name="rhs">The right hand (argument) object</param>
		/// 
		/// <returns>
		///	<c>true</c> If <c>lhs</c> and <c>rhs</c> have both been filled and their
		///	foreground colors are the same, <c>false</c> otherwise
		///	</returns>
		public static bool Matches(this Space lhs, Space rhs) {
			return !lhs.IsEmpty() && !rhs.IsEmpty() && lhs.ForeColor == rhs.ForeColor;
		}

		/// <summary>
		/// Determine if a space is empty
		/// </summary>
		/// 
		/// <param name="space">The space to check</param>
		/// 
		/// <returns><c>true</c> if the space is empty, <c>false</c> otherwise</returns>
		public static bool IsEmpty(this Space space) {
			return space.Text == string.Empty;
		}
	}

	/// <summary>
	/// Validate wins and ties on the game board
	/// </summary>
	public static class Validator {
		/// <summary>
		/// The directions to search for pieces in
		/// </summary>
		public enum Directions {Left, Right, Up, Down, UpLeft, DownRight, DownLeft, UpRight};

		private static int pointer = 0;

		/// <summary>
		/// The four spaces that make up the winning row
		/// </summary>
		public static readonly Space[] Solution = new Space[4];

		/// <summary>
		/// Determine if the player who just played a given piece won the game
		/// </summary>
		/// 
		/// <param name="point">The coordinates of the recently played piece</param>
		/// <param name="board">The board to check</param>
		/// 
		/// <returns><c>true</c> if the play resulted in a win, <c>false</c> othwerwise</returns>
		public static bool DidWin(Point point, Board board) {
			Space piece = board.At(point);

			for (int i = 0; i < 4; i++) {
				pointer = 0;
				Solution[pointer] = piece; // Store this current piece first
				int count = CountPiece(point, piece, (Directions)(i * 2), board) + CountPiece(point, piece, (Directions)(i * 2 + 1), board) + 1;

				if (count == 4) {
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Check if the game is a tie.
		/// 
		/// Assuming the game board has just been checked for a winner and none was found, if the topmost
		/// row is full before another player makes a move, the board is full and the game can be considered a tie.
		/// </summary>
		/// 
		/// <param name="board"></param>
		/// <returns><c>true</c> if the game is a tie, <c>false</c> otherwise</returns>
		public static bool IsTie(Board board) => board.Data[0].All(elem => !elem.IsEmpty());

		/// <summary>
		/// Recursively calculate the number of consecutive pieces after the starting piece in a given direction
		/// </summary>
		/// 
		/// <param name="point">The starting point</param>
		/// <param name="space">The space to search next</param>
		/// <param name="direction">The direction to search in</param>
		/// <param name="board">The board to search on</param>
		/// 
		/// <returns>The number of consecutive pieces after the starting piece in the given direction</returns>
		/// <exception cref="NotImplementedException">Filler for the default switch case, which should never get used</exception>
		private static int CountPiece(Point point, Space space, Directions direction, Board board) {
			Point nextPoint = direction switch {
                Directions.Up 			=> new Point(point.X - 1, point.Y),
                Directions.Down 		=> new Point(point.X + 1, point.Y),
                Directions.Left 		=> new Point(point.X, 	  point.Y - 1),
                Directions.Right 		=> new Point(point.X, 	  point.Y + 1),
                Directions.UpLeft 		=> new Point(point.X - 1, point.Y - 1),
                Directions.DownLeft 	=> new Point(point.X + 1, point.Y - 1),
                Directions.UpRight 		=> new Point(point.X - 1, point.Y - 1),
                Directions.DownRight 	=> new Point(point.X + 1, point.Y + 1),
				_ 						=> throw new InvalidOperationException() // This case should never occur
            };

			if (Board.InBounds(nextPoint) && board.At(nextPoint).Matches(space)) {
				// Store the current point as an endpoint
				Solution[++pointer] = board.At(nextPoint);

				// Recursively calculate the number of occupied spaces in this direction 
				return CountPiece(nextPoint, space, direction, board) + 1;
			}

			return 0; // We don't want this piece, don't count it and stop recursion
		}
	}
}