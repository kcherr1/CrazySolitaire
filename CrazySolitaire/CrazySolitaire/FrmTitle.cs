namespace CrazySolitaire {
    public partial class FrmTitle : Form {
        public FrmTitle() {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e) {
            FrmGame frmGame = new();
            frmGame.Show();
            this.Hide();
            Game.OpenForms.Add(this);
        }
    }
}
