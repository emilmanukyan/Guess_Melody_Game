namespace GuessMelody
{
    partial class fParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParam));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.cbAllDirectory = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 251);
            this.listBox1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 269);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(152, 44);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Browse";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnClearList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearList.Location = new System.Drawing.Point(182, 269);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(152, 44);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbAllDirectory
            // 
            this.cbAllDirectory.AutoSize = true;
            this.cbAllDirectory.BackColor = System.Drawing.Color.Transparent;
            this.cbAllDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAllDirectory.Location = new System.Drawing.Point(654, 273);
            this.cbAllDirectory.Name = "cbAllDirectory";
            this.cbAllDirectory.Size = new System.Drawing.Size(112, 20);
            this.cbAllDirectory.TabIndex = 3;
            this.cbAllDirectory.Text = "Inside Folders";
            this.cbAllDirectory.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOk.Location = new System.Drawing.Point(686, 380);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(178, 44);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::GuessMelody.Properties.Resources.preview;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(686, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Settings";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(325, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(35, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "L";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(35, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 1";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRandomStart.Location = new System.Drawing.Point(9, 102);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(180, 20);
            this.cbRandomStart.TabIndex = 3;
            this.cbRandomStart.Text = "Start from a random place";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "25",
            "30",
            "45"});
            this.cbMusicDuration.Location = new System.Drawing.Point(118, 56);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(38, 21);
            this.cbMusicDuration.TabIndex = 2;
            this.cbMusicDuration.Text = "20";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(118, 23);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(38, 21);
            this.cbGameDuration.TabIndex = 1;
            this.cbGameDuration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Timer to answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game duration";
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources.music_background_4125573_1280;
            this.ClientSize = new System.Drawing.Size(954, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbAllDirectory);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParam";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.CheckBox cbAllDirectory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}