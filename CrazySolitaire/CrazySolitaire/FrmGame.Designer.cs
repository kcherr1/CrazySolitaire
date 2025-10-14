namespace CrazySolitaire
{
    partial class FrmGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            pbStock = new PictureBox();
            panTalon = new Panel();
            panFoundationStack_Clubs = new Panel();
            panFoundationStack_Hearts = new Panel();
            panFoundationStack_Spades = new Panel();
            panFoundationStack_Diamonds = new Panel();
            panTableauStack_0 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbStock).BeginInit();
            SuspendLayout();
            // 
            // pbStock
            // 
            pbStock.BackgroundImage = Properties.Resources.back_orange;
            pbStock.BackgroundImageLayout = ImageLayout.Stretch;
            pbStock.Location = new Point(40, 27);
            pbStock.Name = "pbStock";
            pbStock.Size = new Size(90, 126);
            pbStock.TabIndex = 0;
            pbStock.TabStop = false;
            // 
            // panTalon
            // 
            panTalon.Location = new Point(160, 27);
            panTalon.Name = "panTalon";
            panTalon.Size = new Size(141, 126);
            panTalon.TabIndex = 1;
            // 
            // panFoundationStack_Clubs
            // 
            panFoundationStack_Clubs.BackgroundImage = Properties.Resources.FoundationStackBg_Clubs;
            panFoundationStack_Clubs.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Clubs.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Clubs.Location = new Point(427, 26);
            panFoundationStack_Clubs.Name = "panFoundationStack_Clubs";
            panFoundationStack_Clubs.Size = new Size(90, 126);
            panFoundationStack_Clubs.TabIndex = 2;
            // 
            // panFoundationStack_Hearts
            // 
            panFoundationStack_Hearts.BackgroundImage = Properties.Resources.FoundationStackBg_Hearts;
            panFoundationStack_Hearts.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Hearts.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Hearts.Location = new Point(556, 27);
            panFoundationStack_Hearts.Name = "panFoundationStack_Hearts";
            panFoundationStack_Hearts.Size = new Size(90, 126);
            panFoundationStack_Hearts.TabIndex = 3;
            // 
            // panFoundationStack_Spades
            // 
            panFoundationStack_Spades.BackgroundImage = Properties.Resources.FoundationStackBg_Spades;
            panFoundationStack_Spades.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Spades.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Spades.Location = new Point(685, 27);
            panFoundationStack_Spades.Name = "panFoundationStack_Spades";
            panFoundationStack_Spades.Size = new Size(90, 126);
            panFoundationStack_Spades.TabIndex = 3;
            // 
            // panFoundationStack_Diamonds
            // 
            panFoundationStack_Diamonds.BackgroundImage = Properties.Resources.FoundationStackBg_Diamonds;
            panFoundationStack_Diamonds.BackgroundImageLayout = ImageLayout.Stretch;
            panFoundationStack_Diamonds.BorderStyle = BorderStyle.FixedSingle;
            panFoundationStack_Diamonds.Location = new Point(814, 27);
            panFoundationStack_Diamonds.Name = "panFoundationStack_Diamonds";
            panFoundationStack_Diamonds.Size = new Size(90, 126);
            panFoundationStack_Diamonds.TabIndex = 3;
            // 
            // panTableauStack_0
            // 
            panTableauStack_0.Location = new Point(40, 254);
            panTableauStack_0.Name = "panTableauStack_0";
            panTableauStack_0.Size = new Size(90, 306);
            panTableauStack_0.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(169, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 306);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Location = new Point(298, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(90, 306);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(427, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(90, 306);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Location = new Point(556, 254);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 306);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Location = new Point(685, 254);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 306);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Location = new Point(814, 254);
            panel6.Name = "panel6";
            panel6.Size = new Size(90, 306);
            panel6.TabIndex = 5;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(966, 674);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panTableauStack_0);
            Controls.Add(panFoundationStack_Diamonds);
            Controls.Add(panFoundationStack_Spades);
            Controls.Add(panFoundationStack_Hearts);
            Controls.Add(panFoundationStack_Clubs);
            Controls.Add(panTalon);
            Controls.Add(pbStock);
            Name = "FrmGame";
            Text = "Crazy Solitaire";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbStock;
        private Panel panTalon;
        private Panel panFoundationStack_Clubs;
        private Panel panFoundationStack_Hearts;
        private Panel panFoundationStack_Spades;
        private Panel panFoundationStack_Diamonds;
        private Panel panTableauStack_0;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
