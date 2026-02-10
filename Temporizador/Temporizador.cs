namespace Temporizador
{
    public partial class Temporizador : Form
    {
        int seg = 0;
        int minutos = 0;
        String cero = "0";
        public Temporizador()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrTemporizador.Enabled = true;
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {

            seg++;
            

            

            if (seg == 60)
            {
                seg=0;
                minutos++;
                
            }
            if (minutos < 10)
            {
                if (seg < 10)
                {
                    lblTemp.Text = "0" + minutos + ":" + "0" + seg;
                }
                else
                { 
                    lblTemp.Text = "0" + minutos + ":" + seg;
                }
            }
            else
            {
                if (seg < 10)
                {
                    lblTemp.Text = minutos + ":" + "0" + seg;
                }
                else
                {  
                    lblTemp.Text = minutos + ":" + seg;
                }
            }


        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrTemporizador.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblTemp.Text = "00:00";
            seg =0; 
            minutos = 0;  
        }
    }
}
