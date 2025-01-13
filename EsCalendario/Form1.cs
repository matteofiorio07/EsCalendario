using System.Globalization;
using System.Windows.Forms;

namespace EsCalendario
{
    public partial class Form1 : Form
    {
        int mese, anno;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayGiorni();
        }

        //Metodo che permette di far si che il calendario sia funzionale nel presente stesso
        private void DisplayGiorni()
        {
            DateTime now = DateTime.Now;
            mese = now.Month;
            anno = now.Year;

            String NomeMese = DateTimeFormatInfo.CurrentInfo.GetMonthName(mese);
            LB_Date.Text = NomeMese + " " + anno;

            //Primo giorno del mese
            DateTime inizioDelMese = new DateTime(anno, mese, 1);

            //Contatore dei giorni del mese
            int giorni = DateTime.DaysInMonth(anno, mese);

            //Convertire l'inizio del mese in numero intero
            int giorniDellaSettimana = Convert.ToInt32(inizioDelMese.DayOfWeek.ToString("d"));

            //Creo un usercontrol vuoto
            /* (Un UserControl è un modo per creare un controllo personalizzato riutilizzabile per le interfacce utente. 
            Immagina di avere un insieme di controlli (come bottoni, etichette, caselle di testo) che usi spesso insieme in 
            diverse parti della tua applicazione. Invece di doverli ricreare e configurare ogni volta, puoi raggrupparli in 
            un UserControl e usarlo come un unico componente).
            */
            for (int i = 1; i < giorniDellaSettimana; i++)
            {
                UserControlVuoto ucvuoto = new UserControlVuoto();
                daycontainer.Controls.Add(ucvuoto);
            }

            //Creo un usercontrol per i giorni
            for (int i = 1; i <= giorni; i++)
            {
                UserControlGiorni ucgiorni = new UserControlGiorni();
                ucgiorni.Giorni(i);
                daycontainer.Controls.Add(ucgiorni);
            }
        }

        private void btn_prossimo_Click(object sender, EventArgs e)
        {
            //Pulisco il "container"
            daycontainer.Controls.Clear();

            //Incremento il mese per andare al prossimo mese
            mese++;

            String NomeMese = DateTimeFormatInfo.CurrentInfo.GetMonthName(mese);
            LB_Date.Text = NomeMese + " " + anno;

            /*Copio e incollo la parte di codice già presente nel metodo DisplayGiorni() per continuare il calendario
            con i mesi successivi*/
            DateTime inizioDelMese = new DateTime(anno, mese, 1);

            int giorni = DateTime.DaysInMonth(anno, mese);

            int giorniDellaSettimana = Convert.ToInt32(inizioDelMese.DayOfWeek.ToString("d"));

            for (int i = 1; i < giorniDellaSettimana; i++)
            {
                UserControlVuoto ucvuoto = new UserControlVuoto();
                daycontainer.Controls.Add(ucvuoto);
            }

            for (int i = 1; i <= giorni; i++)
            {
                UserControlGiorni ucgiorni = new UserControlGiorni();
                ucgiorni.Giorni(i);
                daycontainer.Controls.Add(ucgiorni);
            }
        }

        private void btn_precedente_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            //Decremento il mese per andare al mese precedente
            mese--;

            String NomeMese = DateTimeFormatInfo.CurrentInfo.GetMonthName(mese);
            LB_Date.Text = NomeMese + " " + anno;

            /*Copio e incollo la parte di codice già presente nel metodo DisplayGiorni() e in btn_prossimo per 
            tornare indietro nel calendario*/
            DateTime inizioDelMese = new DateTime(anno, mese, 1);

            int giorni = DateTime.DaysInMonth(anno, mese);

            int giorniDellaSettimana = Convert.ToInt32(inizioDelMese.DayOfWeek.ToString("d"));

            for (int i = 1; i < giorniDellaSettimana; i++)
            {
                UserControlVuoto ucvuoto = new UserControlVuoto();
                daycontainer.Controls.Add(ucvuoto);
            }

            for (int i = 1; i <= giorni; i++)
            {
                UserControlGiorni ucgiorni = new UserControlGiorni();
                ucgiorni.Giorni(i);
                daycontainer.Controls.Add(ucgiorni);
            }
        }
    }
}
