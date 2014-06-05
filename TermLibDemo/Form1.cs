using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Term.Forms;
using Term.HW.Cards;

namespace TermLibDemo
{
    public partial class Form1 : TouchForm
    {
        ICardReader cardReader;

        public Form1()
        {
            InitializeComponent();

            //Nastaveni do Fullscreen modu
            FillWholeScreen();

            //Aktivace ctecky
            cardReader = new CardReaderFactory().CreateReader("COM3", CardFormat.Desfire);
            cardReader.OnCardRead += new AbstractCardReader.ICardRead(cardReader_OnCardRead);
            cardReader.Start();
        }

        void cardReader_OnCardRead(CardRead card)
        {
            lCard.Text = string.Concat("CARD: ", card.Serial);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                int i = int.Parse(b.Text);
                i++;
                b.Text = i.ToString();
            }
            catch { }
        }
    }
}