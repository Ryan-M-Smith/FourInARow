namespace FourInARowGUI {
    partial class GameForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			Space titleText;
			Space smallTitle;
			gamePanel = new Panel();
			menuPanel = new Panel();
			quitButton = new Button();
			playButton = new Button();
			infoBox = new Space();
			menuButton = new Button();
			boardPanel = new Panel();
			space35 = new Space();
			space29 = new Space();
			space23 = new Space();
			space17 = new Space();
			space11 = new Space();
			space5 = new Space();
			space34 = new Space();
			space28 = new Space();
			space22 = new Space();
			space16 = new Space();
			space10 = new Space();
			space4 = new Space();
			space33 = new Space();
			space27 = new Space();
			space21 = new Space();
			space15 = new Space();
			space9 = new Space();
			space3 = new Space();
			space32 = new Space();
			space26 = new Space();
			space20 = new Space();
			space14 = new Space();
			space8 = new Space();
			space2 = new Space();
			space31 = new Space();
			space25 = new Space();
			space19 = new Space();
			space13 = new Space();
			space7 = new Space();
			space1 = new Space();
			space30 = new Space();
			space24 = new Space();
			space18 = new Space();
			space12 = new Space();
			space6 = new Space();
			space0 = new Space();
			playAgainButton = new Button();
			titleText = new Space();
			smallTitle = new Space();
			gamePanel.SuspendLayout();
			menuPanel.SuspendLayout();
			boardPanel.SuspendLayout();
			SuspendLayout();
			// 
			// titleText
			// 
			titleText.BorderStyle = BorderStyle.None;
			titleText.Font = new Font("Unispace", 72F, FontStyle.Bold);
			titleText.Location = new Point(115, 146);
			titleText.Name = "titleText";
			titleText.ScrollBars = RichTextBoxScrollBars.None;
			titleText.Size = new Size(787, 113);
			titleText.TabIndex = 6;
			titleText.Text = "Four In A Row";
			// 
			// smallTitle
			// 
			smallTitle.BackColor = Color.White;
			smallTitle.BorderStyle = BorderStyle.None;
			smallTitle.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			smallTitle.Location = new Point(31, 36);
			smallTitle.Name = "smallTitle";
			smallTitle.ReadOnly = true;
			smallTitle.ScrollBars = RichTextBoxScrollBars.None;
			smallTitle.Size = new Size(384, 54);
			smallTitle.TabIndex = 4;
			smallTitle.Text = "Four In A Row";
			// 
			// gamePanel
			// 
			gamePanel.Controls.Add(menuPanel);
			gamePanel.Controls.Add(infoBox);
			gamePanel.Controls.Add(menuButton);
			gamePanel.Controls.Add(boardPanel);
			gamePanel.Controls.Add(playAgainButton);
			gamePanel.Controls.Add(smallTitle);
			gamePanel.Location = new Point(0, 0);
			gamePanel.Name = "gamePanel";
			gamePanel.Size = new Size(1017, 568);
			gamePanel.TabIndex = 0;
			// 
			// menuPanel
			// 
			menuPanel.Controls.Add(titleText);
			menuPanel.Controls.Add(quitButton);
			menuPanel.Controls.Add(playButton);
			menuPanel.Location = new Point(0, 0);
			menuPanel.Name = "menuPanel";
			menuPanel.Size = new Size(1017, 568);
			menuPanel.TabIndex = 6;
			// 
			// quitButton
			// 
			quitButton.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			quitButton.Location = new Point(525, 345);
			quitButton.Name = "quitButton";
			quitButton.Size = new Size(245, 78);
			quitButton.TabIndex = 8;
			quitButton.Text = "QUIT";
			quitButton.UseVisualStyleBackColor = true;
			quitButton.Click += QuitButton_Click;
			// 
			// playButton
			// 
			playButton.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			playButton.Location = new Point(248, 345);
			playButton.Name = "playButton";
			playButton.Size = new Size(245, 78);
			playButton.TabIndex = 7;
			playButton.Text = "PLAY";
			playButton.UseVisualStyleBackColor = true;
			playButton.Click += PlayButton_Click;
			// 
			// infoBox
			// 
			infoBox.BackColor = Color.White;
			infoBox.BorderStyle = BorderStyle.None;
			infoBox.Font = new Font("Unispace", 24F, FontStyle.Bold);
			infoBox.Location = new Point(41, 151);
			infoBox.Name = "infoBox";
			infoBox.ReadOnly = true;
			infoBox.ScrollBars = RichTextBoxScrollBars.None;
			infoBox.Size = new Size(361, 198);
			infoBox.TabIndex = 5;
			infoBox.Text = "It's your turn!\n\nClick a column to play your piece.";
			// 
			// menuButton
			// 
			menuButton.Font = new Font("Unispace", 24F, FontStyle.Bold);
			menuButton.Location = new Point(277, 355);
			menuButton.Name = "menuButton";
			menuButton.Size = new Size(125, 45);
			menuButton.TabIndex = 10;
			menuButton.Text = "MENU";
			menuButton.UseVisualStyleBackColor = true;
			menuButton.Visible = false;
			menuButton.Click += MenuButton_Click;
			// 
			// boardPanel
			// 
			boardPanel.BorderStyle = BorderStyle.Fixed3D;
			boardPanel.Controls.Add(space35);
			boardPanel.Controls.Add(space29);
			boardPanel.Controls.Add(space23);
			boardPanel.Controls.Add(space17);
			boardPanel.Controls.Add(space11);
			boardPanel.Controls.Add(space5);
			boardPanel.Controls.Add(space34);
			boardPanel.Controls.Add(space28);
			boardPanel.Controls.Add(space22);
			boardPanel.Controls.Add(space16);
			boardPanel.Controls.Add(space10);
			boardPanel.Controls.Add(space4);
			boardPanel.Controls.Add(space33);
			boardPanel.Controls.Add(space27);
			boardPanel.Controls.Add(space21);
			boardPanel.Controls.Add(space15);
			boardPanel.Controls.Add(space9);
			boardPanel.Controls.Add(space3);
			boardPanel.Controls.Add(space32);
			boardPanel.Controls.Add(space26);
			boardPanel.Controls.Add(space20);
			boardPanel.Controls.Add(space14);
			boardPanel.Controls.Add(space8);
			boardPanel.Controls.Add(space2);
			boardPanel.Controls.Add(space31);
			boardPanel.Controls.Add(space25);
			boardPanel.Controls.Add(space19);
			boardPanel.Controls.Add(space13);
			boardPanel.Controls.Add(space7);
			boardPanel.Controls.Add(space1);
			boardPanel.Controls.Add(space30);
			boardPanel.Controls.Add(space24);
			boardPanel.Controls.Add(space18);
			boardPanel.Controls.Add(space12);
			boardPanel.Controls.Add(space6);
			boardPanel.Controls.Add(space0);
			boardPanel.Location = new Point(443, 23);
			boardPanel.Name = "boardPanel";
			boardPanel.Size = new Size(547, 522);
			boardPanel.TabIndex = 3;
			// 
			// space35
			// 
			space35.BackColor = Color.White;
			space35.Cursor = Cursors.Hand;
			space35.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space35.Location = new Point(449, 428);
			space35.MaxLength = 1;
			space35.Multiline = false;
			space35.Name = "space35";
			space35.ReadOnly = true;
			space35.ScrollBars = RichTextBoxScrollBars.None;
			space35.Size = new Size(93, 89);
			space35.TabIndex = 36;
			space35.Text = "";
			space35.Click += PlayColumn;
			space35.Enter += Unfocus;
			space35.MouseEnter += ColumnHighlight;
			space35.MouseLeave += UndoColumnHighlight;
			// 
			// space29
			// 
			space29.BackColor = Color.White;
			space29.Cursor = Cursors.Hand;
			space29.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space29.Location = new Point(449, 343);
			space29.MaxLength = 1;
			space29.Multiline = false;
			space29.Name = "space29";
			space29.ReadOnly = true;
			space29.ScrollBars = RichTextBoxScrollBars.None;
			space29.Size = new Size(93, 89);
			space29.TabIndex = 35;
			space29.Text = "";
			space29.Click += PlayColumn;
			space29.Enter += Unfocus;
			space29.MouseEnter += ColumnHighlight;
			space29.MouseLeave += UndoColumnHighlight;
			// 
			// space23
			// 
			space23.BackColor = Color.White;
			space23.Cursor = Cursors.Hand;
			space23.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space23.Location = new Point(449, 257);
			space23.MaxLength = 1;
			space23.Multiline = false;
			space23.Name = "space23";
			space23.ReadOnly = true;
			space23.ScrollBars = RichTextBoxScrollBars.None;
			space23.Size = new Size(93, 89);
			space23.TabIndex = 34;
			space23.Text = "";
			space23.Click += PlayColumn;
			space23.Enter += Unfocus;
			space23.MouseEnter += ColumnHighlight;
			space23.MouseLeave += UndoColumnHighlight;
			// 
			// space17
			// 
			space17.BackColor = Color.White;
			space17.Cursor = Cursors.Hand;
			space17.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space17.Location = new Point(449, 171);
			space17.MaxLength = 1;
			space17.Multiline = false;
			space17.Name = "space17";
			space17.ReadOnly = true;
			space17.ScrollBars = RichTextBoxScrollBars.None;
			space17.Size = new Size(93, 89);
			space17.TabIndex = 33;
			space17.Text = "";
			space17.Click += PlayColumn;
			space17.Enter += Unfocus;
			space17.MouseEnter += ColumnHighlight;
			space17.MouseLeave += UndoColumnHighlight;
			// 
			// space11
			// 
			space11.BackColor = Color.White;
			space11.Cursor = Cursors.Hand;
			space11.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space11.Location = new Point(449, 86);
			space11.MaxLength = 1;
			space11.Multiline = false;
			space11.Name = "space11";
			space11.ReadOnly = true;
			space11.ScrollBars = RichTextBoxScrollBars.None;
			space11.Size = new Size(93, 89);
			space11.TabIndex = 32;
			space11.Text = "";
			space11.Click += PlayColumn;
			space11.Enter += Unfocus;
			space11.MouseEnter += ColumnHighlight;
			space11.MouseLeave += UndoColumnHighlight;
			// 
			// space5
			// 
			space5.BackColor = Color.White;
			space5.Cursor = Cursors.Hand;
			space5.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space5.Location = new Point(449, 0);
			space5.MaxLength = 1;
			space5.Multiline = false;
			space5.Name = "space5";
			space5.ReadOnly = true;
			space5.ScrollBars = RichTextBoxScrollBars.None;
			space5.Size = new Size(93, 89);
			space5.TabIndex = 31;
			space5.Text = "";
			space5.Click += PlayColumn;
			space5.Enter += Unfocus;
			space5.MouseEnter += ColumnHighlight;
			space5.MouseLeave += UndoColumnHighlight;
			// 
			// space34
			// 
			space34.BackColor = Color.White;
			space34.Cursor = Cursors.Hand;
			space34.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space34.Location = new Point(359, 428);
			space34.MaxLength = 1;
			space34.Multiline = false;
			space34.Name = "space34";
			space34.ReadOnly = true;
			space34.ScrollBars = RichTextBoxScrollBars.None;
			space34.Size = new Size(93, 89);
			space34.TabIndex = 30;
			space34.Text = "";
			space34.Click += PlayColumn;
			space34.Enter += Unfocus;
			space34.MouseEnter += ColumnHighlight;
			space34.MouseLeave += UndoColumnHighlight;
			// 
			// space28
			// 
			space28.BackColor = Color.White;
			space28.Cursor = Cursors.Hand;
			space28.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space28.Location = new Point(359, 343);
			space28.MaxLength = 1;
			space28.Multiline = false;
			space28.Name = "space28";
			space28.ReadOnly = true;
			space28.ScrollBars = RichTextBoxScrollBars.None;
			space28.Size = new Size(93, 89);
			space28.TabIndex = 29;
			space28.Text = "";
			space28.Click += PlayColumn;
			space28.Enter += Unfocus;
			space28.MouseEnter += ColumnHighlight;
			space28.MouseLeave += UndoColumnHighlight;
			// 
			// space22
			// 
			space22.BackColor = Color.White;
			space22.Cursor = Cursors.Hand;
			space22.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space22.Location = new Point(359, 257);
			space22.MaxLength = 1;
			space22.Multiline = false;
			space22.Name = "space22";
			space22.ReadOnly = true;
			space22.ScrollBars = RichTextBoxScrollBars.None;
			space22.Size = new Size(93, 89);
			space22.TabIndex = 28;
			space22.Text = "";
			space22.Click += PlayColumn;
			space22.Enter += Unfocus;
			space22.MouseEnter += ColumnHighlight;
			space22.MouseLeave += UndoColumnHighlight;
			// 
			// space16
			// 
			space16.BackColor = Color.White;
			space16.Cursor = Cursors.Hand;
			space16.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space16.Location = new Point(359, 171);
			space16.MaxLength = 1;
			space16.Multiline = false;
			space16.Name = "space16";
			space16.ReadOnly = true;
			space16.ScrollBars = RichTextBoxScrollBars.None;
			space16.Size = new Size(93, 89);
			space16.TabIndex = 27;
			space16.Text = "";
			space16.Click += PlayColumn;
			space16.Enter += Unfocus;
			space16.MouseEnter += ColumnHighlight;
			space16.MouseLeave += UndoColumnHighlight;
			// 
			// space10
			// 
			space10.BackColor = Color.White;
			space10.Cursor = Cursors.Hand;
			space10.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space10.Location = new Point(359, 86);
			space10.MaxLength = 1;
			space10.Multiline = false;
			space10.Name = "space10";
			space10.ReadOnly = true;
			space10.ScrollBars = RichTextBoxScrollBars.None;
			space10.Size = new Size(93, 89);
			space10.TabIndex = 26;
			space10.Text = "";
			space10.Click += PlayColumn;
			space10.Enter += Unfocus;
			space10.MouseEnter += ColumnHighlight;
			space10.MouseLeave += UndoColumnHighlight;
			// 
			// space4
			// 
			space4.BackColor = Color.White;
			space4.Cursor = Cursors.Hand;
			space4.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space4.Location = new Point(359, 0);
			space4.MaxLength = 1;
			space4.Multiline = false;
			space4.Name = "space4";
			space4.ReadOnly = true;
			space4.ScrollBars = RichTextBoxScrollBars.None;
			space4.Size = new Size(93, 89);
			space4.TabIndex = 25;
			space4.Text = "";
			space4.Click += PlayColumn;
			space4.Enter += Unfocus;
			space4.MouseEnter += ColumnHighlight;
			space4.MouseLeave += UndoColumnHighlight;
			// 
			// space33
			// 
			space33.BackColor = Color.White;
			space33.Cursor = Cursors.Hand;
			space33.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space33.Location = new Point(269, 428);
			space33.MaxLength = 1;
			space33.Multiline = false;
			space33.Name = "space33";
			space33.ReadOnly = true;
			space33.ScrollBars = RichTextBoxScrollBars.None;
			space33.Size = new Size(93, 89);
			space33.TabIndex = 24;
			space33.Text = "";
			space33.Click += PlayColumn;
			space33.Enter += Unfocus;
			space33.MouseEnter += ColumnHighlight;
			space33.MouseLeave += UndoColumnHighlight;
			// 
			// space27
			// 
			space27.BackColor = Color.White;
			space27.Cursor = Cursors.Hand;
			space27.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space27.Location = new Point(269, 343);
			space27.MaxLength = 1;
			space27.Multiline = false;
			space27.Name = "space27";
			space27.ReadOnly = true;
			space27.ScrollBars = RichTextBoxScrollBars.None;
			space27.Size = new Size(93, 89);
			space27.TabIndex = 23;
			space27.Text = "";
			space27.Click += PlayColumn;
			space27.Enter += Unfocus;
			space27.MouseEnter += ColumnHighlight;
			space27.MouseLeave += UndoColumnHighlight;
			// 
			// space21
			// 
			space21.BackColor = Color.White;
			space21.Cursor = Cursors.Hand;
			space21.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space21.Location = new Point(269, 257);
			space21.MaxLength = 1;
			space21.Multiline = false;
			space21.Name = "space21";
			space21.ReadOnly = true;
			space21.ScrollBars = RichTextBoxScrollBars.None;
			space21.Size = new Size(93, 89);
			space21.TabIndex = 22;
			space21.Text = "";
			space21.Click += PlayColumn;
			space21.Enter += Unfocus;
			space21.MouseEnter += ColumnHighlight;
			space21.MouseLeave += UndoColumnHighlight;
			// 
			// space15
			// 
			space15.BackColor = Color.White;
			space15.Cursor = Cursors.Hand;
			space15.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space15.Location = new Point(269, 171);
			space15.MaxLength = 1;
			space15.Multiline = false;
			space15.Name = "space15";
			space15.ReadOnly = true;
			space15.ScrollBars = RichTextBoxScrollBars.None;
			space15.Size = new Size(93, 89);
			space15.TabIndex = 21;
			space15.Text = "";
			space15.Click += PlayColumn;
			space15.Enter += Unfocus;
			space15.MouseEnter += ColumnHighlight;
			space15.MouseLeave += UndoColumnHighlight;
			// 
			// space9
			// 
			space9.BackColor = Color.White;
			space9.Cursor = Cursors.Hand;
			space9.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space9.Location = new Point(269, 86);
			space9.MaxLength = 1;
			space9.Multiline = false;
			space9.Name = "space9";
			space9.ReadOnly = true;
			space9.ScrollBars = RichTextBoxScrollBars.None;
			space9.Size = new Size(93, 89);
			space9.TabIndex = 20;
			space9.Text = "";
			space9.Click += PlayColumn;
			space9.Enter += Unfocus;
			space9.MouseEnter += ColumnHighlight;
			space9.MouseLeave += UndoColumnHighlight;
			// 
			// space3
			// 
			space3.BackColor = Color.White;
			space3.Cursor = Cursors.Hand;
			space3.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space3.Location = new Point(269, 0);
			space3.MaxLength = 1;
			space3.Multiline = false;
			space3.Name = "space3";
			space3.ReadOnly = true;
			space3.ScrollBars = RichTextBoxScrollBars.None;
			space3.Size = new Size(93, 89);
			space3.TabIndex = 19;
			space3.Text = "";
			space3.Click += PlayColumn;
			space3.Enter += Unfocus;
			space3.MouseEnter += ColumnHighlight;
			space3.MouseLeave += UndoColumnHighlight;
			// 
			// space32
			// 
			space32.BackColor = Color.White;
			space32.Cursor = Cursors.Hand;
			space32.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space32.Location = new Point(179, 428);
			space32.MaxLength = 1;
			space32.Multiline = false;
			space32.Name = "space32";
			space32.ReadOnly = true;
			space32.ScrollBars = RichTextBoxScrollBars.None;
			space32.Size = new Size(93, 89);
			space32.TabIndex = 18;
			space32.Text = "";
			space32.Click += PlayColumn;
			space32.Enter += Unfocus;
			space32.MouseEnter += ColumnHighlight;
			space32.MouseLeave += UndoColumnHighlight;
			// 
			// space26
			// 
			space26.BackColor = Color.White;
			space26.Cursor = Cursors.Hand;
			space26.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space26.Location = new Point(179, 343);
			space26.MaxLength = 1;
			space26.Multiline = false;
			space26.Name = "space26";
			space26.ReadOnly = true;
			space26.ScrollBars = RichTextBoxScrollBars.None;
			space26.Size = new Size(93, 89);
			space26.TabIndex = 17;
			space26.Text = "";
			space26.Click += PlayColumn;
			space26.Enter += Unfocus;
			space26.MouseEnter += ColumnHighlight;
			space26.MouseLeave += UndoColumnHighlight;
			// 
			// space20
			// 
			space20.BackColor = Color.White;
			space20.Cursor = Cursors.Hand;
			space20.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space20.Location = new Point(179, 257);
			space20.MaxLength = 1;
			space20.Multiline = false;
			space20.Name = "space20";
			space20.ReadOnly = true;
			space20.ScrollBars = RichTextBoxScrollBars.None;
			space20.Size = new Size(93, 89);
			space20.TabIndex = 16;
			space20.Text = "";
			space20.Click += PlayColumn;
			space20.Enter += Unfocus;
			space20.MouseEnter += ColumnHighlight;
			space20.MouseLeave += UndoColumnHighlight;
			// 
			// space14
			// 
			space14.BackColor = Color.White;
			space14.Cursor = Cursors.Hand;
			space14.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space14.Location = new Point(179, 171);
			space14.MaxLength = 1;
			space14.Multiline = false;
			space14.Name = "space14";
			space14.ReadOnly = true;
			space14.ScrollBars = RichTextBoxScrollBars.None;
			space14.Size = new Size(93, 89);
			space14.TabIndex = 15;
			space14.Text = "";
			space14.Click += PlayColumn;
			space14.Enter += Unfocus;
			space14.MouseEnter += ColumnHighlight;
			space14.MouseLeave += UndoColumnHighlight;
			// 
			// space8
			// 
			space8.BackColor = Color.White;
			space8.Cursor = Cursors.Hand;
			space8.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space8.Location = new Point(179, 86);
			space8.MaxLength = 1;
			space8.Multiline = false;
			space8.Name = "space8";
			space8.ReadOnly = true;
			space8.ScrollBars = RichTextBoxScrollBars.None;
			space8.Size = new Size(93, 89);
			space8.TabIndex = 14;
			space8.Text = "";
			space8.Click += PlayColumn;
			space8.Enter += Unfocus;
			space8.MouseEnter += ColumnHighlight;
			space8.MouseLeave += UndoColumnHighlight;
			// 
			// space2
			// 
			space2.BackColor = Color.White;
			space2.Cursor = Cursors.Hand;
			space2.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space2.Location = new Point(179, 0);
			space2.MaxLength = 1;
			space2.Multiline = false;
			space2.Name = "space2";
			space2.ReadOnly = true;
			space2.ScrollBars = RichTextBoxScrollBars.None;
			space2.Size = new Size(93, 89);
			space2.TabIndex = 13;
			space2.Text = "";
			space2.Click += PlayColumn;
			space2.Enter += Unfocus;
			space2.MouseEnter += ColumnHighlight;
			space2.MouseLeave += UndoColumnHighlight;
			// 
			// space31
			// 
			space31.BackColor = Color.White;
			space31.Cursor = Cursors.Hand;
			space31.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space31.Location = new Point(90, 428);
			space31.MaxLength = 1;
			space31.Multiline = false;
			space31.Name = "space31";
			space31.ReadOnly = true;
			space31.ScrollBars = RichTextBoxScrollBars.None;
			space31.Size = new Size(93, 89);
			space31.TabIndex = 12;
			space31.Text = "";
			space31.Click += PlayColumn;
			space31.Enter += Unfocus;
			space31.MouseEnter += ColumnHighlight;
			space31.MouseLeave += UndoColumnHighlight;
			// 
			// space25
			// 
			space25.BackColor = Color.White;
			space25.Cursor = Cursors.Hand;
			space25.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space25.Location = new Point(90, 343);
			space25.MaxLength = 1;
			space25.Multiline = false;
			space25.Name = "space25";
			space25.ReadOnly = true;
			space25.ScrollBars = RichTextBoxScrollBars.None;
			space25.Size = new Size(93, 89);
			space25.TabIndex = 11;
			space25.Text = "";
			space25.Click += PlayColumn;
			space25.Enter += Unfocus;
			space25.MouseEnter += ColumnHighlight;
			space25.MouseLeave += UndoColumnHighlight;
			// 
			// space19
			// 
			space19.BackColor = Color.White;
			space19.Cursor = Cursors.Hand;
			space19.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space19.Location = new Point(90, 257);
			space19.MaxLength = 1;
			space19.Multiline = false;
			space19.Name = "space19";
			space19.ReadOnly = true;
			space19.ScrollBars = RichTextBoxScrollBars.None;
			space19.Size = new Size(93, 89);
			space19.TabIndex = 10;
			space19.Text = "";
			space19.Click += PlayColumn;
			space19.Enter += Unfocus;
			space19.MouseEnter += ColumnHighlight;
			space19.MouseLeave += UndoColumnHighlight;
			// 
			// space13
			// 
			space13.BackColor = Color.White;
			space13.Cursor = Cursors.Hand;
			space13.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space13.Location = new Point(90, 171);
			space13.MaxLength = 1;
			space13.Multiline = false;
			space13.Name = "space13";
			space13.ReadOnly = true;
			space13.ScrollBars = RichTextBoxScrollBars.None;
			space13.Size = new Size(93, 89);
			space13.TabIndex = 9;
			space13.Text = "";
			space13.Click += PlayColumn;
			space13.Enter += Unfocus;
			space13.MouseEnter += ColumnHighlight;
			space13.MouseLeave += UndoColumnHighlight;
			// 
			// space7
			// 
			space7.BackColor = Color.White;
			space7.Cursor = Cursors.Hand;
			space7.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space7.Location = new Point(90, 86);
			space7.MaxLength = 1;
			space7.Multiline = false;
			space7.Name = "space7";
			space7.ReadOnly = true;
			space7.ScrollBars = RichTextBoxScrollBars.None;
			space7.Size = new Size(93, 89);
			space7.TabIndex = 8;
			space7.Text = "";
			space7.Click += PlayColumn;
			space7.Enter += Unfocus;
			space7.MouseEnter += ColumnHighlight;
			space7.MouseLeave += UndoColumnHighlight;
			// 
			// space1
			// 
			space1.BackColor = Color.White;
			space1.Cursor = Cursors.Hand;
			space1.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space1.Location = new Point(90, 0);
			space1.MaxLength = 1;
			space1.Multiline = false;
			space1.Name = "space1";
			space1.ReadOnly = true;
			space1.ScrollBars = RichTextBoxScrollBars.None;
			space1.Size = new Size(93, 89);
			space1.TabIndex = 7;
			space1.Text = "";
			space1.Click += PlayColumn;
			space1.Enter += Unfocus;
			space1.MouseEnter += ColumnHighlight;
			space1.MouseLeave += UndoColumnHighlight;
			// 
			// space30
			// 
			space30.BackColor = Color.White;
			space30.Cursor = Cursors.Hand;
			space30.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space30.Location = new Point(0, 428);
			space30.MaxLength = 1;
			space30.Multiline = false;
			space30.Name = "space30";
			space30.ReadOnly = true;
			space30.ScrollBars = RichTextBoxScrollBars.None;
			space30.Size = new Size(93, 89);
			space30.TabIndex = 6;
			space30.Text = "";
			space30.Click += PlayColumn;
			space30.Enter += Unfocus;
			space30.MouseEnter += ColumnHighlight;
			space30.MouseLeave += UndoColumnHighlight;
			// 
			// space24
			// 
			space24.BackColor = Color.White;
			space24.Cursor = Cursors.Hand;
			space24.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space24.Location = new Point(0, 343);
			space24.MaxLength = 1;
			space24.Multiline = false;
			space24.Name = "space24";
			space24.ReadOnly = true;
			space24.ScrollBars = RichTextBoxScrollBars.None;
			space24.Size = new Size(93, 89);
			space24.TabIndex = 5;
			space24.Text = "";
			space24.Click += PlayColumn;
			space24.Enter += Unfocus;
			space24.MouseEnter += ColumnHighlight;
			space24.MouseLeave += UndoColumnHighlight;
			// 
			// space18
			// 
			space18.BackColor = Color.White;
			space18.Cursor = Cursors.Hand;
			space18.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space18.Location = new Point(0, 257);
			space18.MaxLength = 1;
			space18.Multiline = false;
			space18.Name = "space18";
			space18.ReadOnly = true;
			space18.ScrollBars = RichTextBoxScrollBars.None;
			space18.Size = new Size(93, 89);
			space18.TabIndex = 4;
			space18.Text = "";
			space18.Click += PlayColumn;
			space18.Enter += Unfocus;
			space18.MouseEnter += ColumnHighlight;
			space18.MouseLeave += UndoColumnHighlight;
			// 
			// space12
			// 
			space12.BackColor = Color.White;
			space12.Cursor = Cursors.Hand;
			space12.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space12.Location = new Point(0, 171);
			space12.MaxLength = 1;
			space12.Multiline = false;
			space12.Name = "space12";
			space12.ReadOnly = true;
			space12.ScrollBars = RichTextBoxScrollBars.None;
			space12.Size = new Size(93, 89);
			space12.TabIndex = 3;
			space12.Text = "";
			space12.Click += PlayColumn;
			space12.Enter += Unfocus;
			space12.MouseEnter += ColumnHighlight;
			space12.MouseLeave += UndoColumnHighlight;
			// 
			// space6
			// 
			space6.BackColor = Color.White;
			space6.Cursor = Cursors.Hand;
			space6.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space6.Location = new Point(0, 86);
			space6.MaxLength = 1;
			space6.Multiline = false;
			space6.Name = "space6";
			space6.ReadOnly = true;
			space6.ScrollBars = RichTextBoxScrollBars.None;
			space6.Size = new Size(93, 89);
			space6.TabIndex = 2;
			space6.Text = "";
			space6.Click += PlayColumn;
			space6.Enter += Unfocus;
			space6.MouseEnter += ColumnHighlight;
			space6.MouseLeave += UndoColumnHighlight;
			// 
			// space0
			// 
			space0.BackColor = Color.White;
			space0.Cursor = Cursors.Hand;
			space0.Font = new Font("Webdings", 62F, FontStyle.Bold);
			space0.Location = new Point(0, 0);
			space0.MaxLength = 1;
			space0.Multiline = false;
			space0.Name = "space0";
			space0.ReadOnly = true;
			space0.ScrollBars = RichTextBoxScrollBars.None;
			space0.Size = new Size(93, 89);
			space0.TabIndex = 1;
			space0.Text = "";
			space0.Click += PlayColumn;
			space0.Enter += Unfocus;
			space0.MouseEnter += ColumnHighlight;
			space0.MouseLeave += UndoColumnHighlight;
			// 
			// playAgainButton
			// 
			playAgainButton.Font = new Font("Unispace", 24F, FontStyle.Bold);
			playAgainButton.Location = new Point(31, 355);
			playAgainButton.Name = "playAgainButton";
			playAgainButton.Size = new Size(227, 45);
			playAgainButton.TabIndex = 9;
			playAgainButton.Text = "PLAY AGAIN";
			playAgainButton.UseVisualStyleBackColor = true;
			playAgainButton.Visible = false;
			playAgainButton.Click += PlayAgainButton_Click;
			// 
			// GameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(1018, 566);
			Controls.Add(gamePanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "GameForm";
			Text = "Four In A Row";
			gamePanel.ResumeLayout(false);
			menuPanel.ResumeLayout(false);
			boardPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel gamePanel;
        private RichTextBox infoBox;
        private Panel boardPanel;
        private RichTextBox space35;
        private RichTextBox space29;
        private RichTextBox space23;
        private RichTextBox space17;
        private RichTextBox space11;
        private RichTextBox space5;
        private RichTextBox space34;
        private RichTextBox space28;
        private RichTextBox space22;
        private RichTextBox space16;
        private RichTextBox space10;
        private RichTextBox space4;
        private RichTextBox space33;
        private RichTextBox space27;
        private RichTextBox space21;
        private RichTextBox space15;
        private RichTextBox space9;
        private RichTextBox space3;
        private RichTextBox space32;
        private RichTextBox space26;
        private RichTextBox space20;
        private RichTextBox space14;
        private RichTextBox space8;
        private RichTextBox space2;
        private RichTextBox space31;
        private RichTextBox space25;
        private RichTextBox space19;
        private RichTextBox space13;
        private RichTextBox space7;
        private RichTextBox space1;
        private RichTextBox space30;
        private RichTextBox space24;
        private RichTextBox space18;
        private RichTextBox space12;
        private RichTextBox space6;
        private RichTextBox space0;
        private RichTextBox smallTitle;
        private Panel menuPanel;
        private Button quitButton;
        private Button playButton;
        private RichTextBox titleText;
		private Button menuButton;
		private Button playAgainButton;
	}
}
