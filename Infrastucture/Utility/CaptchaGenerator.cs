﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Utility
{
    public class CaptchaGenerator
    {
        private int karakterSayisi;
        private string fontTipi;
        private float fontBuyuklugu;


        public string olusturanString;

        public CaptchaGenerator(int karakterSayisi, string fontTipi, float fontBuyuklugu)
        {
            this.karakterSayisi = karakterSayisi;
            this.fontTipi = fontTipi;
            this.fontBuyuklugu = fontBuyuklugu;
            
        }
        private char KarakterUret()
        {
            //65-90 büyük harf
            //97-122 kücük harf

            char karakter = ' ';
            Random rnd = new Random();
            bool kontrol = true;
            while (kontrol)
            {
                int sayi = rnd.Next(65, 123);
                if (!(sayi>90&&sayi<97))
                {
                    karakter = (char)sayi;
                    kontrol = false;
                }
            }
            return karakter;
        }

        private string KarakterDizisiUret()
        {
            string karakterdizisi = "";
            for (int i = 0; i < karakterSayisi; i++)
            {
                karakterdizisi += KarakterUret();
            }
            return karakterdizisi;
        }

        public Bitmap GuvenlikResmiUret()
        {
            this.olusturanString = KarakterDizisiUret();

            Bitmap b = new Bitmap(1,1);
            Graphics g = Graphics.FromImage(b);
            int width =(int)g.MeasureString(olusturanString,new Font(fontTipi,fontBuyuklugu)).Width;
            int height = (int)g.MeasureString(olusturanString,new Font(fontTipi,fontBuyuklugu)).Height;

            Bitmap resim = new Bitmap(width, height);
            Graphics graph = Graphics.FromImage(resim);
            graph.Clear(Color.Black);

            HatchBrush brush = new HatchBrush(HatchStyle.Weave, Color.White);
            graph.DrawLine(new Pen(Brushes.Gray,1), 0, 18, 300, 18);

            
            graph.DrawString(olusturanString, new Font(fontTipi, fontBuyuklugu), brush, new PointF(0, 0));
            return resim;
            
        }



    }
}
