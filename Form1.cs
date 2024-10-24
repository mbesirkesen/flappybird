using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//muhammed beşir kesen



namespace flappybird 

 {public partial class flippybird : Form
    {   //değişken tanımlama
        int cubukhizi = 8;
        int greavity = 10;
        int score = 0;
        
        public flippybird()
        {
            InitializeComponent();
        }
        private void timer(object sender, EventArgs e)
    {   //değişkenleri ekledgiğmiz karakterlere atama ve skor takibi
        dabuk.Top += greavity;
        ustteki_cubuk.Left -= cubukhizi;
        alttaki_cubuk.Left -= cubukhizi;
        label1.Text = "Score: " + score;
        //kusun cubuklardan gecişini kontrol etme ve yeni cubuk atayıp skoru arttırma
        if (alttaki_cubuk.Left <= -150)
        {
            alttaki_cubuk.Left = 500;
            score++;
        }
        if (ustteki_cubuk.Left <= -150)
        {
            ustteki_cubuk.Left = 600;
            score++;
        }
        //oyunda skor arttıkça oyunun zorluk seviyesini yükseltme
        if (score >= 15)
        {
            cubukhizi = 11;
        }
        if (score >= 30)
        {
            cubukhizi = 15;
        }
        if (score >= 45)
        {
            cubukhizi = 20;
        }
        //oyunun bitip bitmedigini kontrol etme
        if (dabuk.Bounds.IntersectsWith(ustteki_cubuk.Bounds) ||
            dabuk.Bounds.IntersectsWith(alttaki_cubuk.Bounds) ||
            dabuk.Bounds.IntersectsWith(yer.Bounds) || dabuk.Top < -15)
        {
            OyunBiter();
        }
    }
        //oyun bittiyse bittiğini belirtip oyunu bitirme
        public void OyunBiter()
        {
            timer1.Stop();
            label1.Text = "GAME OVER!!";
        }
        //kusumuzun kontrol yukarı assagı kontrolunu saglama
        private void flippybird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                greavity = -10;
            }
          
        }

        private void flippybird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                greavity = 10;
            }
        }

        private void flippybird_Load(object sender, EventArgs e)
        {

        }
    }
}
