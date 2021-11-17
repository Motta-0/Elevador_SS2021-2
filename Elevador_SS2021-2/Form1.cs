using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevador_SS2021_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Criando a array do funcionamento interno
            INTERNO.RowTemplate.Height = 60;
            INTERNO.Rows.Add(6);

            for(int i=0; i<6; i++)
            {
                if (i == 5)
                {
                    INTERNO[0, 5].Value = string.Format("T");
                }
                else
                    INTERNO[0, i].Value = string.Format("{0}", 6 - i);
            }

            //Array do proprio elevador
            ELEVADOR.RowTemplate.Height = 75;
            ELEVADOR.Rows.Add(6);

            //Criando a array do funcionamento subida externa
            SOBE_EX.RowTemplate.Height = 60;
            SOBE_EX.Rows.Add(6);

            for (int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    SOBE_EX[0, 5].Value = string.Format("T");
                }
                else
                    SOBE_EX[0, i].Value = string.Format("{0}", 6 - i);
            }

            //Criando a array do funcionamento descida externa
            DESCE_EX.RowTemplate.Height = 60;
            DESCE_EX.Rows.Add(6);

            for (int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    DESCE_EX[0, 5].Value = string.Format("T");
                }
                else
                    DESCE_EX[0, i].Value = string.Format("{0}", 6 - i);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
