
namespace GuessMelody
{
    partial class fWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWin));
            this.lblWinnersName = new System.Windows.Forms.Label();
            this.lblWinnersCounter = new System.Windows.Forms.Label();
            this.btnNice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinnersName
            // 
            this.lblWinnersName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWinnersName.AutoSize = true;
            this.lblWinnersName.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnersName.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnersName.ForeColor = System.Drawing.Color.Black;
            this.lblWinnersName.Location = new System.Drawing.Point(300, 180);
            this.lblWinnersName.Name = "lblWinnersName";
            this.lblWinnersName.Size = new System.Drawing.Size(207, 54);
            this.lblWinnersName.TabIndex = 0;
            this.lblWinnersName.Text = "label1";
            // 
            // lblWinnersCounter
            // 
            this.lblWinnersCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWinnersCounter.AutoSize = true;
            this.lblWinnersCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnersCounter.Font = new System.Drawing.Font("Algerian", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnersCounter.ForeColor = System.Drawing.Color.Black;
            this.lblWinnersCounter.Location = new System.Drawing.Point(300, 234);
            this.lblWinnersCounter.Name = "lblWinnersCounter";
            this.lblWinnersCounter.Size = new System.Drawing.Size(52, 54);
            this.lblWinnersCounter.TabIndex = 0;
            this.lblWinnersCounter.Text = "0";
            // 
            // btnNice
            // 
            this.btnNice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNice.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNice.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnNice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNice.Location = new System.Drawing.Point(309, 347);
            this.btnNice.Name = "btnNice";
            this.btnNice.Size = new System.Drawing.Size(198, 59);
            this.btnNice.TabIndex = 1;
            this.btnNice.Text = "Nice!";
            this.btnNice.UseVisualStyleBackColor = true;
            this.btnNice.Click += new System.EventHandler(this.btnNice_Click);
            // 
            // fWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music_background_4125573_1280;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNice);
            this.Controls.Add(this.lblWinnersCounter);
            this.Controls.Add(this.lblWinnersName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fWin";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNice;
        public System.Windows.Forms.Label lblWinnersName;
        public System.Windows.Forms.Label lblWinnersCounter;
    }
}