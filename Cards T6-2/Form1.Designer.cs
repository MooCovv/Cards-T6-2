namespace Cards_T6_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.showCardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.acePictureBox = new System.Windows.Forms.PictureBox();
            this.tenPictureBox = new System.Windows.Forms.PictureBox();
            this.kingPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.acePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardListBox
            // 
            this.cardListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.ItemHeight = 20;
            this.cardListBox.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.cardListBox.Location = new System.Drawing.Point(232, 282);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(120, 84);
            this.cardListBox.TabIndex = 1;
            // 
            // showCardButton
            // 
            this.showCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCardButton.Location = new System.Drawing.Point(167, 372);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(109, 35);
            this.showCardButton.TabIndex = 2;
            this.showCardButton.Text = "Show Card";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(302, 372);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 35);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // acePictureBox
            // 
            this.acePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("acePictureBox.Image")));
            this.acePictureBox.Location = new System.Drawing.Point(12, 12);
            this.acePictureBox.Name = "acePictureBox";
            this.acePictureBox.Size = new System.Drawing.Size(184, 264);
            this.acePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acePictureBox.TabIndex = 4;
            this.acePictureBox.TabStop = false;
            // 
            // tenPictureBox
            // 
            this.tenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tenPictureBox.Image")));
            this.tenPictureBox.Location = new System.Drawing.Point(202, 12);
            this.tenPictureBox.Name = "tenPictureBox";
            this.tenPictureBox.Size = new System.Drawing.Size(184, 264);
            this.tenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tenPictureBox.TabIndex = 5;
            this.tenPictureBox.TabStop = false;
            // 
            // kingPictureBox
            // 
            this.kingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kingPictureBox.Image")));
            this.kingPictureBox.Location = new System.Drawing.Point(393, 12);
            this.kingPictureBox.Name = "kingPictureBox";
            this.kingPictureBox.Size = new System.Drawing.Size(184, 264);
            this.kingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kingPictureBox.TabIndex = 6;
            this.kingPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 420);
            this.Controls.Add(this.kingPictureBox);
            this.Controls.Add(this.tenPictureBox);
            this.Controls.Add(this.acePictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.cardListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.acePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Button showCardButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox acePictureBox;
        private System.Windows.Forms.PictureBox tenPictureBox;
        private System.Windows.Forms.PictureBox kingPictureBox;
    }
}

