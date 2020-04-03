using System.Drawing;
using System.Windows.Forms;


namespace Wyswietlacz7seg
{
    public class Wyswietlacz : Panel
    {

        private Mechanizm mechanizm;
        private Color kolorWyswietlacza, kolorNapisu;

        public Wyswietlacz()
        {
            mechanizm = new Mechanizm();
            UstawieniaDomyslne();
        }

        private void UstawieniaDomyslne()
        {
            //w razie gdyby użytkownik nie zmienił ustawień komponentu ustawienia domyślne
            kolorWyswietlacza = Color.Black;
            kolorNapisu = Color.Red;
            BackColor = kolorWyswietlacza;
            Size = new Size(100, 200);   
        }

        public void WylaczWyswietlacz()
        {
            mechanizm.WyzerujStany();
            PaintComponent(CreateGraphics());
        }

        public void Ustaw(char stan)
        {
            mechanizm.UstawStan(stan);
            PaintComponent(CreateGraphics());
        }

        public void PaintComponent(Graphics g)
        {
           
            SolidBrush brush = new SolidBrush(kolorNapisu);
            g.FillRectangle(new SolidBrush(kolorWyswietlacza), 0, 0, 100, 200);

            // segment a
            if (mechanizm.GetStan()[0])
            {
                g.FillRectangle(brush, new Rectangle(0, 0, 100, 8));
            }
            // segment b
            if (mechanizm.GetStan()[1])
            {
                g.FillRectangle(brush, new Rectangle(92, 0, 8, 100));
            }
            // segment c
            if (mechanizm.GetStan()[2])
            {
                g.FillRectangle(brush, new Rectangle(92, 100, 8, 100));
            }
            // segment d
            if (mechanizm.GetStan()[3])
            {
                g.FillRectangle(brush, new Rectangle(0, 192, 100, 8));
            }
            // segment e
            if (mechanizm.GetStan()[4])
            {
                g.FillRectangle(brush, new Rectangle(0, 100, 8, 100));
            }
            // segment f
            if (mechanizm.GetStan()[5])
            {
                g.FillRectangle(brush, new Rectangle(0, 0, 8, 100));
            }
            // segment g
            if (mechanizm.GetStan()[6])
            {
                g.FillRectangle(brush, new Rectangle(0, 100, 100, 8));
            }
        }

        public Mechanizm GetMechanizmWYswietlacza()
        {
            return mechanizm;
        }

        public void SetMechanizmWYswietlacza(Mechanizm mechanizmWYswietlacza)
        {
            mechanizm = mechanizmWYswietlacza;
        }

        public Color GetKolorWyswietlacza()
        {
            return kolorWyswietlacza;
        }

        public void SetKolorWyswietlacza(Color kolorWyswietlacza)
        {
            this.kolorWyswietlacza = kolorWyswietlacza;
        }

        public Color GetKolorNapisu()
        {
            return kolorNapisu;
        }

        public void SetKolorNapisu(Color kolorNapisu)
        {
            this.kolorNapisu = kolorNapisu;
        }

    }
}
