namespace Spider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlacar = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTimerIncrement = new System.Windows.Forms.Label();
            this.lbSpiderIncrement = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMoves = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSpiderLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWebLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSpiderTraceLenght = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbLastKeyPressed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSpiderDirection = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTimerStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.web = new System.Windows.Forms.PictureBox();
            this.spider = new System.Windows.Forms.PictureBox();
            this.arena = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // lbPlacar
            // 
            this.lbPlacar.AutoSize = true;
            this.lbPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlacar.Location = new System.Drawing.Point(650, 117);
            this.lbPlacar.Name = "lbPlacar";
            this.lbPlacar.Size = new System.Drawing.Size(0, 20);
            this.lbPlacar.TabIndex = 3;
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.LightGreen;
            this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.Location = new System.Drawing.Point(585, 63);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(195, 42);
            this.btIniciar.TabIndex = 4;
            this.btIniciar.Text = "&START";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spider:";
            // 
            // lbTimerIncrement
            // 
            this.lbTimerIncrement.AutoSize = true;
            this.lbTimerIncrement.Location = new System.Drawing.Point(640, 500);
            this.lbTimerIncrement.Name = "lbTimerIncrement";
            this.lbTimerIncrement.Size = new System.Drawing.Size(13, 13);
            this.lbTimerIncrement.TabIndex = 8;
            this.lbTimerIncrement.Text = "0";
            // 
            // lbSpiderIncrement
            // 
            this.lbSpiderIncrement.AutoSize = true;
            this.lbSpiderIncrement.Location = new System.Drawing.Point(640, 515);
            this.lbSpiderIncrement.Name = "lbSpiderIncrement";
            this.lbSpiderIncrement.Size = new System.Drawing.Size(13, 13);
            this.lbSpiderIncrement.TabIndex = 9;
            this.lbSpiderIncrement.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Moves:";
            // 
            // lbMoves
            // 
            this.lbMoves.AutoSize = true;
            this.lbMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoves.Location = new System.Drawing.Point(647, 321);
            this.lbMoves.Name = "lbMoves";
            this.lbMoves.Size = new System.Drawing.Size(0, 20);
            this.lbMoves.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Debug Info...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Increments:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Spider Location:";
            // 
            // lbSpiderLocation
            // 
            this.lbSpiderLocation.AutoSize = true;
            this.lbSpiderLocation.Location = new System.Drawing.Point(666, 532);
            this.lbSpiderLocation.Name = "lbSpiderLocation";
            this.lbSpiderLocation.Size = new System.Drawing.Size(13, 13);
            this.lbSpiderLocation.TabIndex = 15;
            this.lbSpiderLocation.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Web  Location:";
            // 
            // lbWebLocation
            // 
            this.lbWebLocation.AutoSize = true;
            this.lbWebLocation.Location = new System.Drawing.Point(663, 548);
            this.lbWebLocation.Name = "lbWebLocation";
            this.lbWebLocation.Size = new System.Drawing.Size(13, 13);
            this.lbWebLocation.TabIndex = 17;
            this.lbWebLocation.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 48);
            this.label5.TabIndex = 18;
            this.label5.Text = "SPIDER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Spider Trace Lenght:";
            // 
            // lbSpiderTraceLenght
            // 
            this.lbSpiderTraceLenght.AutoSize = true;
            this.lbSpiderTraceLenght.Location = new System.Drawing.Point(689, 469);
            this.lbSpiderTraceLenght.Name = "lbSpiderTraceLenght";
            this.lbSpiderTraceLenght.Size = new System.Drawing.Size(13, 13);
            this.lbSpiderTraceLenght.TabIndex = 20;
            this.lbSpiderTraceLenght.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Last Key Pressed:";
            // 
            // lbLastKeyPressed
            // 
            this.lbLastKeyPressed.AutoSize = true;
            this.lbLastKeyPressed.Location = new System.Drawing.Point(674, 450);
            this.lbLastKeyPressed.Name = "lbLastKeyPressed";
            this.lbLastKeyPressed.Size = new System.Drawing.Size(13, 13);
            this.lbLastKeyPressed.TabIndex = 22;
            this.lbLastKeyPressed.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Spider Direction:";
            // 
            // lbSpiderDirection
            // 
            this.lbSpiderDirection.AutoSize = true;
            this.lbSpiderDirection.Location = new System.Drawing.Point(668, 433);
            this.lbSpiderDirection.Name = "lbSpiderDirection";
            this.lbSpiderDirection.Size = new System.Drawing.Size(13, 13);
            this.lbSpiderDirection.TabIndex = 24;
            this.lbSpiderDirection.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(582, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Timer Status:";
            // 
            // lbTimerStatus
            // 
            this.lbTimerStatus.AutoSize = true;
            this.lbTimerStatus.Location = new System.Drawing.Point(652, 415);
            this.lbTimerStatus.Name = "lbTimerStatus";
            this.lbTimerStatus.Size = new System.Drawing.Size(32, 13);
            this.lbTimerStatus.TabIndex = 26;
            this.lbTimerStatus.Text = "False";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(584, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Controls:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Spider.Properties.Resources.keys0;
            this.pictureBox2.Location = new System.Drawing.Point(600, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 20);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Spider.Properties.Resources.keys1;
            this.pictureBox1.Location = new System.Drawing.Point(600, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 42);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // web
            // 
            this.web.Image = global::Spider.Properties.Resources.web;
            this.web.Location = new System.Drawing.Point(100, 100);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(24, 24);
            this.web.TabIndex = 5;
            this.web.TabStop = false;
            this.web.Visible = false;
            // 
            // spider
            // 
            this.spider.Enabled = false;
            this.spider.Image = global::Spider.Properties.Resources.spiderU;
            this.spider.Location = new System.Drawing.Point(276, 492);
            this.spider.Name = "spider";
            this.spider.Size = new System.Drawing.Size(24, 24);
            this.spider.TabIndex = 1;
            this.spider.TabStop = false;
            // 
            // arena
            // 
            this.arena.BackColor = System.Drawing.Color.White;
            this.arena.Location = new System.Drawing.Point(12, 12);
            this.arena.Name = "arena";
            this.arena.Size = new System.Drawing.Size(552, 552);
            this.arena.TabIndex = 0;
            this.arena.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(669, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Spider Moviment";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(681, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Pause Game";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(584, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Time:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(633, 141);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 20);
            this.lbTime.TabIndex = 30;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 576);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTimerStatus);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbSpiderDirection);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbLastKeyPressed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbSpiderTraceLenght);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbWebLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSpiderLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbMoves);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSpiderIncrement);
            this.Controls.Add(this.lbTimerIncrement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.web);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.lbPlacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spider);
            this.Controls.Add(this.arena);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 610);
            this.MinimumSize = new System.Drawing.Size(800, 610);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spider 1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arena;
        private System.Windows.Forms.PictureBox spider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPlacar;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.PictureBox web;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTimerIncrement;
        private System.Windows.Forms.Label lbSpiderIncrement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMoves;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSpiderLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbWebLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSpiderTraceLenght;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbLastKeyPressed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSpiderDirection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTimerStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerCountdown;

       
    }
}

