//
// Author: Ryan Smith
// Created: 10/10/24
// Filename: Board.cs
// Description: The game board
//

using System.Collections;

namespace FourInARowGUI {
	/// <summary>
	/// An enumerator for the <c>Board</c> class
	/// </summary>
	/// 
	/// <param name="board">A board to enumerate over</param>
	internal class BoardEnumerator(Board board) : IEnumerator<RowType> {
		private readonly Board _board = board;
		private int _position = -1;
		
		object IEnumerator.Current => _board.At(_position);

		RowType IEnumerator<RowType>.Current => _board.At(_position);

		void IDisposable.Dispose() {
			GC.SuppressFinalize(this);
		}

		bool IEnumerator.MoveNext() => ++_position < Board.Rows;

		void IEnumerator.Reset() => _position = -1;
	}

	/// <summary>
	/// The game board
	/// </summary>
	public class Board: IEnumerable {
		#region Implement IEunumerable

		/// <summary>
		/// Get an enumerator for this <c>Board</c>
		/// </summary>
		/// 
		/// <returns>A new <c>BoardEnumerator</c></returns>
		BoardEnumerator GetEnumerator() {
			return new BoardEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}

		/// <summary>
		/// Allow adding rows to the board.
		/// 
		/// This method facilitates use of the collection constructor.
		/// </summary>
		/// 
		/// <param name="item"></param>
		public void Add(RowType item) => _board.Add(item);

		#endregion

		/// <summary> The number of rows in the board </summary>
		public const int Rows = 6;

		/// <summary> The number of columns in the board </summary>
		public const int Columns = 6;

		private readonly BoardType _board;

		public BoardType Data => _board;

		/// <summary>
		/// Allow updating and accessing the board via coordinate
		/// </summary>
		/// 
		/// <param name="x"> The x-coordinate </param>
		/// <param name="y"> The y-coordinate </param>
		/// 
		/// <returns>The character at location <c>(x, y)</c></returns>
		public Space this[int x, int y] {
			get => _board[x][y];
			set => _board[x][y] = value;
		}

		/// <summary>
		/// Allow accessing individual rows of the board
		/// </summary>
		/// 
		/// <param name="row">The row index</param>
		/// 
		/// <returns>The row at index <c>row</c></returns>
		public RowType this[int row] => _board[row];

		/// <summary>
		/// Default constructor
		/// </summary>
		public Board() {
			_board = [];
		}

		/// <summary>
		/// Create a new board from board data
		/// </summary>
		/// <param name="board"></param>
		public Board(BoardType board) {
			_board = board;
		}

		/// <summary>
		/// Clear the board
		/// </summary>
		public void Clear() => _board.ForEach(row => row.ForEach(item => item.Clear()));

		/// <summary>
		/// Determine if a given point is a valid point on the game board
		/// </summary>
		/// 
		/// <param name="point">The point to check</param>
		/// 
		/// <returns><c>true</c> if <c>point</c> is within the boad's bounds, <c>false</c> otherwise</returns>
		public static bool InBounds(Point point) => point.X >= 0 && point.X < Rows && point.Y >= 0 && point.Y < Columns;

		/// <summary>
		/// Determine if a given column is full
		/// </summary>
		/// 
		/// <param name="column">The column to check</param>
		/// 
		/// <returns><c>true</c> if <c>column</c> is full, <c>false</c> otherwise</returns>
		public bool IsFull(int column) => !At(0, column).IsEmpty();

		/// <summary>
		/// Index the board with bounds checking
		/// </summary>
		/// 
		/// <param name="point">The point to access</param>
		/// 
		/// <returns>The piece at <c>point</c></returns>
		/// <exception cref="IndexOutOfRangeException">If the point is outside the bounds of the board</exception>
		public Space At(Point point) {
			if (!InBounds(point)) {
				throw new IndexOutOfRangeException($"The point ({point.X}, {point.Y}) exceeds the bounds of the board");
			}

			return this[point.X, point.Y];
		}

		/// <summary>
		/// Index the board with bounds checking
		/// </summary>
		/// 
		/// <param name="row">The row index</param>
		/// <param name="column">The column index</param>
		/// 
		/// <returns>The piece at <c>(x, y)</c></returns>
		/// <exception cref="IndexOutOfRangeException">If the point is outside the bounds of the board</exception>
		public Space At(int row, int column) {
			return At(new Point(row, column));
		}

		/// <summary>
		/// Row indexing with bounds checking
		/// </summary>
		/// 
		/// <param name="row">The row index</param>
		/// 
		/// <returns>The row at index <c>row</c></returns>
		/// <exception cref="IndexOutOfRangeException">If the row index is out of range</exception>
		public RowType At(int row) {
			if (row < 0 || row > Rows) {
				throw new IndexOutOfRangeException($"Invalid row index {row}");
			}

			return this[row];
		}

		/// <summary>
		/// Get the <c>RichTextBoxe</c>s that make up a specific column of the board
		/// </summary>
		/// 
		/// <param name="column">The column index</param>
		/// <returns>The column at index <c>index</c></returns>
		public ColumnType GetColumn(int column) => new(_board.Select(row => row.ElementAt(column)));
	}
}