using System;
using System.Windows.Forms;

namespace lootbox
{
    public partial class Form1 : Form
    {
        private Random random;
        private int finalOcena;          
        private int losowaniaCounter;    

        public Form1()
        {
            InitializeComponent();
            random = new Random();              
            timerLosowanie.Tick += timerLosowanie_Tick; 
        }

        // Obs³uga zdarzenia klikniêcia przycisku
        private void btnLosuj_Click(object sender, EventArgs e)
        {
            losowaniaCounter = 0;                     
            finalOcena = random.Next(1, 7);          
            timerLosowanie.Start();                 
        }

      
        private void timerLosowanie_Tick(object sender, EventArgs e)
        {
            int ocena = random.Next(1, 7);            
            lblWynik.Text = ocena.ToString();         
            losowaniaCounter++;                       

           
            if (losowaniaCounter > 20)               
            {
                timerLosowanie.Stop();                
                lblWynik.Text = finalOcena.ToString(); 
            }
        }
    }
}
