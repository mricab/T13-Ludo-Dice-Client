using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameClient;

namespace LudoClient
{
    public partial class Form3 : Form, IGClient3
    {
        private Random random = new Random();
        // Properties
        private GClient GameClient;
        private static Graphics drawer;
        private static int blockSize = 35;

        public Form3(GClient GameClient, String Game)
        {
            InitializeComponent();
            this.GameClient = GameClient;
            GameClient.RegisterObserver3(this);
            GameClient.StartGame(Game);
        }

        public Form3(GClient GameClient, int GameId)
        {
            InitializeComponent();
            this.GameClient = GameClient;
            GameClient.RegisterObserver3(this);
            GameClient.JoinGame(GameId);
        }

        // Control Events
        private void CloseGameButton_Click(object sender, EventArgs e)
        {
            Invoke(LaunchMenuFormHandler, this);
            Invoke(CloseFormHandler, this);
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            EndTurnButton.Visible = false;
            this.GameClient.EndTurn();
        }

        private void DiceButton_Click(object sender, EventArgs e)
        {
            DiceButton.Image = DiceImageList.Images[0];
            this.GameClient.ThrowDice();
        }

        // IGCLient3
        void IGClient3.OnGBoard(GBoardEvent e)
        {
            Invoke(DrawBoardHandler, this);
        }

        void IGClient3.OnGUpdate(GUpdateEvent e)
        {
            Invoke(UpdateHandler, this);
        }

        // Form Control
        private delegate void CloseFormDelegate(Form3 form);
        CloseFormDelegate CloseFormHandler = CloseForm;
        private static void CloseForm(Form3 form)
        {
            form.BoardPictureBox.Refresh();
            form.Dispose();
        }

        private delegate void LaunchMenuFormDelegate(Form3 form);
        LaunchMenuFormDelegate LaunchMenuFormHandler = LaunchMenuForm;
        private static void LaunchMenuForm(Form3 form)
        {
            Form2 menu = new Form2(form.GameClient);
            menu.Show();
        }

        private delegate void DrawBoardDelegate(Form3 form);
        DrawBoardDelegate DrawBoardHandler = DrawBoard;
        public static void DrawBoard(Form3 form)
        {
            int size = GClient.Match.board.size;
            string[] cells = GClient.Match.board.cells;
            //GameBoardFields[,] GameBoard = new GameBoardFields[size, size];
            form.BoardPictureBox.Image = new Bitmap(size * blockSize, size * blockSize);
            drawer = Graphics.FromImage(form.BoardPictureBox.Image);
            drawer.Clear(Color.Black);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int pos = (size * i) + j;
                    drawer.DrawImage(form.BlocksImageList.Images[int.Parse(cells[pos])], j * blockSize, i * blockSize);
                }
            }
        }

        private delegate void UpdateDelegate(Form3 form);
        UpdateDelegate UpdateHandler = UpdateBoard;
        public static void UpdateBoard(Form3 form)
        {
            if (GClient.Match.playing)
            {
                form.TurnLabel.Visible = false;
                form.EndTurnButton.Visible = true;
                form.DiceButton.Image = form.DiceImageList.Images[GClient.Match.dice];
                if (GClient.Match.canThrow) { form.DiceButton.Enabled = true; } 
                else { form.DiceButton.Enabled = false; }
            }
            else
            {
                form.TurnLabel.Text = "Esperando";
                form.TurnLabel.Visible = true;
                form.EndTurnButton.Visible = false;
                form.DiceButton.Image = form.DiceImageList.Images[GClient.Match.dice];
                form.DiceButton.Enabled = false;
            }
        }
    }
}
