using System.Diagnostics;

namespace FourInARowGUI {
	/// <summary>
	/// The event argument for a turn update event
	/// </summary>
	/// <param name="turn">The current turn count</param>
	public class TurnEventArgs(int turn) : EventArgs {
		/// <summary>
		/// The turn count
		/// </summary>
		public int Turn { get; set; } = turn;
	}

	/// <summary>
	/// Handle the process of switching turns
	/// </summary>
	public class TurnController {
		public delegate void TurnUpdateHandler(object sender, TurnEventArgs e);
		public event TurnUpdateHandler? OnTurnUpdate;

		/// <summary>
		/// Switch turns
		/// </summary>
		/// <param name="turn">The newly updated turn count</param>
		public void SwitchTurns(int turn) {
			if (OnTurnUpdate == null) {
				return;
			}

			OnTurnUpdate(this, new(turn)); // Raise the event
		}
	}
}
