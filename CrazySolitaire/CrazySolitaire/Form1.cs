using CrazySolitaire.Properties;

namespace CrazySolitaire {
    public partial class Form1 : Form {
        private Game game;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            game = new();
            for (int i = 0; i < 52; i++) {
                var card = game.Deck.Acquire();
                flpTest.AddCard(card);
            }
        }

    }
}
