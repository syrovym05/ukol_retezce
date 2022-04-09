using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";            
            string slovo = textBox1.Text;
            int pocet_samohlasek = 0, pocet_souhlasek = 0, pocet_ostatni = 0;

            slovo = slovo.ToLower();

            foreach (char s in samohlasky)
            {
                if (slovo.Contains(s))              
                {
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        if (slovo[i] == s) pocet_samohlasek++;
                    }
                }                
            }
            foreach (char s in souhlasky)
            {
                if (slovo.Contains(s))
                {
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        if (slovo[i] == s) pocet_souhlasek++;
                    }
                }
            }
            pocet_ostatni = slovo.Length - pocet_samohlasek - pocet_souhlasek;


            label2.Text = "Počet samohlásek: ";
            label3.Text = "Počet souhlásek: ";
            label4.Text = "Počet ostatních: ";
            label5.Text = pocet_samohlasek.ToString();
            label6.Text = pocet_souhlasek.ToString();
            label7.Text = pocet_ostatni.ToString();            
        }
    }
}
