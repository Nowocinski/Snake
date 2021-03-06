﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snake_v2
{
    public partial class Forma : Form
    {
        List<BodyPart> body = new List<BodyPart>();
        Head head = new Head();
        bool generujNoweJedzenie = true;
        int x, y;

        public Forma()
        {
            InitializeComponent();
        }

        private void Forma_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();

            if(generujNoweJedzenie == true)
            {
                generujNoweJedzenie = false;
                x = rnd.Next(0, ClientSize.Width - 20);
                x -= x % 20;
                y = rnd.Next(0, ClientSize.Height - 20);
                y -= y % 20;
            }

            Food jedzenie = new Food(x,y);
            jedzenie.Rysuj(e);

            head.Rysuj(e);
            head.GameOver(timer, body, ClientSize.Height, ClientSize.Width);

            body.Add(new BodyPart(head.X, head.Y));
            if (head.x != jedzenie.x || head.y != jedzenie.y)
                body.RemoveAt(0);
            else
                generujNoweJedzenie = true;
                
            foreach (BodyPart item in body)
                item.Rysuj(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A) head.Poruszanie(Kierunek.left);
            if (e.KeyChar == (char)Keys.D) head.Poruszanie(Kierunek.right);
            if (e.KeyChar == (char)Keys.W) head.Poruszanie(Kierunek.top);
            if (e.KeyChar == (char)Keys.S) head.Poruszanie(Kierunek.down);
        }
    }
}
