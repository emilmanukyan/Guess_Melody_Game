namespace GuessMelody
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPlay.Location = new System.Drawing.Point(425, 152);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(426, 115);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParams
            // 
            this.btnParams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnParams.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParams.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnParams.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnParams.Location = new System.Drawing.Point(425, 281);
            this.btnParams.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(426, 106);
            this.btnParams.TabIndex = 1;
            this.btnParams.Text = "Settings";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Location = new System.Drawing.Point(425, 401);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(426, 115);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(341, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "♪GUESS MELODY♪";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music_background_4125573_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "fMain";
            this.Text = "Guess Melody";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

