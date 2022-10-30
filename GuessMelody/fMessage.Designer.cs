
namespace GuessMelody
{
    partial class fMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMessage));
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMessage.Location = new System.Drawing.Point(261, 121);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(145, 79);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackgroundImage = global::GuessMelody.Properties.Resources.preview;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(47, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackgroundImage = global::GuessMelody.Properties.Resources.preview;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(461, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(310, 356);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 55);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "0";
            // 
            // lblShowAnswer
            // 
            this.lblShowAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblShowAnswer.AutoSize = true;
            this.lblShowAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblShowAnswer.Location = new System.Drawing.Point(43, 272);
            this.lblShowAnswer.Name = "lblShowAnswer";
            this.lblShowAnswer.Size = new System.Drawing.Size(124, 24);
            this.lblShowAnswer.TabIndex = 4;
            this.lblShowAnswer.Text = "Show answer";
            this.lblShowAnswer.Click += new System.EventHandler(this.lblShowAnswer_Click);
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music_background_4125573_1280;
            this.ClientSize = new System.Drawing.Size(672, 465);
            this.Controls.Add(this.lblShowAnswer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.Load += new System.EventHandler(this.fMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblShowAnswer;
    }
}