using CrazySolitaire.Properties;

namespace CrazySolitaire {
    public partial class FrmGame : Form {
        private Game game;

        public FrmGame() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            game = new();
            for (int i = 0; i < 52; i++) {
                var card = game.Deck.Acquire();
            }
        }

    }
}
