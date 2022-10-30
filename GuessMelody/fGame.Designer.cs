
namespace GuessMelody
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.lblCounter2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblMelodyCounter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 423);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(213, 45);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::GuessMelody.Properties.Resources.preview;
            this.button1.Location = new System.Drawing.Point(344, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(121, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(634, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2";
            // 
            // lblCounter1
            // 
            this.lblCounter1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter1.ForeColor = System.Drawing.Color.Red;
            this.lblCounter1.Location = new System.Drawing.Point(201, 190);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(34, 35);
            this.lblCounter1.TabIndex = 4;
            this.lblCounter1.Text = "0";
            this.lblCounter1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCounter1_MouseClick);
            // 
            // lblCounter2
            // 
            this.lblCounter2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter2.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter2.ForeColor = System.Drawing.Color.Indigo;
            this.lblCounter2.Location = new System.Drawing.Point(716, 190);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(34, 35);
            this.lblCounter2.TabIndex = 4;
            this.lblCounter2.Text = "0";
            this.lblCounter2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCounter1_MouseClick);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPause.Location = new System.Drawing.Point(128, 357);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(210, 60);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinue.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnContinue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContinue.Location = new System.Drawing.Point(583, 355);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(206, 60);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblMelodyCounter
            // 
            this.lblMelodyCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMelodyCounter.AutoSize = true;
            this.lblMelodyCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblMelodyCounter.Font = new System.Drawing.Font("Algerian", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMelodyCounter.ForeColor = System.Drawing.Color.Black;
            this.lblMelodyCounter.Location = new System.Drawing.Point(527, 136);
            this.lblMelodyCounter.Name = "lblMelodyCounter";
            this.lblMelodyCounter.Size = new System.Drawing.Size(39, 39);
            this.lblMelodyCounter.TabIndex = 6;
            this.lblMelodyCounter.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(128, 286);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(661, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicDuration.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicDuration.ForeColor = System.Drawing.Color.Black;
            this.lblMusicDuration.Location = new System.Drawing.Point(443, 219);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(30, 30);
            this.lblMusicDuration.TabIndex = 8;
            this.lblMusicDuration.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Count of music\'s - ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music_background_4125573_1280;
            this.ClientSize = new System.Drawing.Size(967, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMusicDuration);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblMelodyCounter);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblCounter2);
            this.Controls.Add(this.lblCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.Label lblCounter2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblMelodyCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMusicDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}