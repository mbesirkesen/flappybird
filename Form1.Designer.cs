namespace flappybird
{
    partial class flippybird
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ustteki_cubuk = new System.Windows.Forms.PictureBox();
            this.alttaki_cubuk = new System.Windows.Forms.PictureBox();
            this.yer = new System.Windows.Forms.PictureBox();
            this.dabuk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ustteki_cubuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alttaki_cubuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabuk)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 457);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            // 
            // ustteki_cubuk
            // 
            this.ustteki_cubuk.Image = global::flappybird.Properties.Resources.pipedown;
            this.ustteki_cubuk.Location = new System.Drawing.Point(346, 1);
            this.ustteki_cubuk.Name = "ustteki_cubuk";
            this.ustteki_cubuk.Size = new System.Drawing.Size(100, 161);
            this.ustteki_cubuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ustteki_cubuk.TabIndex = 3;
            this.ustteki_cubuk.TabStop = false;
            // 
            // alttaki_cubuk
            // 
            this.alttaki_cubuk.Image = global::flappybird.Properties.Resources.pipe;
            this.alttaki_cubuk.Location = new System.Drawing.Point(346, 309);
            this.alttaki_cubuk.Name = "alttaki_cubuk";
            this.alttaki_cubuk.Size = new System.Drawing.Size(100, 127);
            this.alttaki_cubuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alttaki_cubuk.TabIndex = 2;
            this.alttaki_cubuk.TabStop = false;
            // 
            // yer
            // 
            this.yer.Image = global::flappybird.Properties.Resources.ground;
            this.yer.Location = new System.Drawing.Point(-10, 433);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(1357, 115);
            this.yer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yer.TabIndex = 1;
            this.yer.TabStop = false;
            // 
            // dabuk
            // 
            this.dabuk.Image = global::flappybird.Properties.Resources.bird;
            this.dabuk.Location = new System.Drawing.Point(22, 48);
            this.dabuk.Name = "dabuk";
            this.dabuk.Size = new System.Drawing.Size(53, 41);
            this.dabuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dabuk.TabIndex = 0;
            this.dabuk.TabStop = false;
            // 
            // flippybird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(671, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ustteki_cubuk);
            this.Controls.Add(this.alttaki_cubuk);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.dabuk);
            this.Name = "flippybird";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.flippybird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flippybird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flippybird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ustteki_cubuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alttaki_cubuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dabuk;
        private System.Windows.Forms.PictureBox yer;
        private System.Windows.Forms.PictureBox alttaki_cubuk;
        private System.Windows.Forms.PictureBox ustteki_cubuk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

