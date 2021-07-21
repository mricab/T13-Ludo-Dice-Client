
namespace LudoClient
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.CloseGameButton = new System.Windows.Forms.Button();
            this.BoardPictureBox = new System.Windows.Forms.PictureBox();
            this.BlocksImageList = new System.Windows.Forms.ImageList(this.components);
            this.TurnLabel = new System.Windows.Forms.Label();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.DiceButton = new System.Windows.Forms.Button();
            this.DiceImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseGameButton
            // 
            this.CloseGameButton.Location = new System.Drawing.Point(543, 12);
            this.CloseGameButton.Name = "CloseGameButton";
            this.CloseGameButton.Size = new System.Drawing.Size(75, 23);
            this.CloseGameButton.TabIndex = 0;
            this.CloseGameButton.Text = "Cerrar";
            this.CloseGameButton.UseVisualStyleBackColor = true;
            this.CloseGameButton.Click += new System.EventHandler(this.CloseGameButton_Click);
            // 
            // BoardPictureBox
            // 
            this.BoardPictureBox.Location = new System.Drawing.Point(12, 12);
            this.BoardPictureBox.Name = "BoardPictureBox";
            this.BoardPictureBox.Size = new System.Drawing.Size(525, 525);
            this.BoardPictureBox.TabIndex = 1;
            this.BoardPictureBox.TabStop = false;
            // 
            // BlocksImageList
            // 
            this.BlocksImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BlocksImageList.ImageStream")));
            this.BlocksImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.BlocksImageList.Images.SetKeyName(0, "Bloque_0.png");
            this.BlocksImageList.Images.SetKeyName(1, "Bloque_1.png");
            this.BlocksImageList.Images.SetKeyName(2, "Bloque_2.png");
            this.BlocksImageList.Images.SetKeyName(3, "Bloque_3.png");
            this.BlocksImageList.Images.SetKeyName(4, "Bloque_4.png");
            this.BlocksImageList.Images.SetKeyName(5, "Bloque_5.png");
            this.BlocksImageList.Images.SetKeyName(6, "Bloque_6.png");
            this.BlocksImageList.Images.SetKeyName(7, "Bloque_7.png");
            this.BlocksImageList.Images.SetKeyName(8, "Bloque_8.png");
            this.BlocksImageList.Images.SetKeyName(9, "Bloque_29.png");
            this.BlocksImageList.Images.SetKeyName(10, "Bloque_10.png");
            this.BlocksImageList.Images.SetKeyName(11, "Bloque_11.png");
            this.BlocksImageList.Images.SetKeyName(12, "Bloque_12.png");
            this.BlocksImageList.Images.SetKeyName(13, "Bloque_13.png");
            this.BlocksImageList.Images.SetKeyName(14, "Bloque_14.png");
            this.BlocksImageList.Images.SetKeyName(15, "Bloque_29.png");
            this.BlocksImageList.Images.SetKeyName(16, "Bloque_29.png");
            this.BlocksImageList.Images.SetKeyName(17, "Bloque_29.png");
            this.BlocksImageList.Images.SetKeyName(18, "Bloque_29.png");
            this.BlocksImageList.Images.SetKeyName(19, "Bloque_29.png");
            this.BlocksImageList.Images.SetKeyName(20, "Bloque_20.png");
            this.BlocksImageList.Images.SetKeyName(21, "Bloque_21.png");
            this.BlocksImageList.Images.SetKeyName(22, "Bloque_22.png");
            this.BlocksImageList.Images.SetKeyName(23, "Bloque_23.png");
            this.BlocksImageList.Images.SetKeyName(24, "Bloque_24.png");
            this.BlocksImageList.Images.SetKeyName(25, "Bloque_25.png");
            this.BlocksImageList.Images.SetKeyName(26, "Bloque_26.png");
            this.BlocksImageList.Images.SetKeyName(27, "Bloque_27.png");
            this.BlocksImageList.Images.SetKeyName(28, "Bloque_28.png");
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Location = new System.Drawing.Point(552, 244);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(58, 13);
            this.TurnLabel.TabIndex = 2;
            this.TurnLabel.Text = "Esperando";
            this.TurnLabel.Visible = false;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Location = new System.Drawing.Point(543, 260);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(75, 23);
            this.EndTurnButton.TabIndex = 3;
            this.EndTurnButton.Text = "Terminar";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Visible = false;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // DiceButton
            // 
            this.DiceButton.Enabled = false;
            this.DiceButton.Location = new System.Drawing.Point(551, 477);
            this.DiceButton.Name = "DiceButton";
            this.DiceButton.Size = new System.Drawing.Size(60, 60);
            this.DiceButton.TabIndex = 4;
            this.DiceButton.UseVisualStyleBackColor = true;
            this.DiceButton.Click += new System.EventHandler(this.DiceButton_Click);
            // 
            // DiceImageList
            // 
            this.DiceImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DiceImageList.ImageStream")));
            this.DiceImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DiceImageList.Images.SetKeyName(0, "dice0.jpg");
            this.DiceImageList.Images.SetKeyName(1, "dice1.jpg");
            this.DiceImageList.Images.SetKeyName(2, "dice2.jpg");
            this.DiceImageList.Images.SetKeyName(3, "dice3.jpg");
            this.DiceImageList.Images.SetKeyName(4, "dice4.jpg");
            this.DiceImageList.Images.SetKeyName(5, "dice5.jpg");
            this.DiceImageList.Images.SetKeyName(6, "dice6.jpg");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 543);
            this.Controls.Add(this.DiceButton);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.BoardPictureBox);
            this.Controls.Add(this.CloseGameButton);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseGameButton;
        private System.Windows.Forms.PictureBox BoardPictureBox;
        private System.Windows.Forms.ImageList BlocksImageList;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button EndTurnButton;
        private System.Windows.Forms.Button DiceButton;
        private System.Windows.Forms.ImageList DiceImageList;
    }
}