using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elevador_SS2021_2
{
    public partial class Form1 : Form
    {
        Image AbrirImagem = null;
        Image FecharImagem = null;

        //Criando vetor que vai receber o botão apertado em cada array
        int[] ChamarInterno = new int[6];
        int[] ChamarSubir = new int[6];
        int[] ChamarDescer = new int[6];
        String[] NumerarAndares = new string[6] { "T", "1°", "2°", "3°", "4°", "5°" };
        //NumerarAndares 
        enum Andares {T, A1, A2, A3, A4, A5};
        Andares Andar = Andares.T;//Andar inicial;


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
            //Definindo o tempo
            Tempo.Interval = 200;
            Tempo.Start();

            //Definindo as imagens
            AbrirImagem = new Bitmap("ElevAberto.gif");
            FecharImagem = new Bitmap("ElevFechado.gif");
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)ELEVADOR.Columns["Coluna_Imagem"];
            imageColumn.DefaultCellStyle.NullValue = null;
            ELEVADOR[0, 5].Value = FecharImagem;

            //Zerando a informação dos botões das Arrays
            for(int i=0; i<6; i++)
            {
                ChamarInterno[i] = 0;
                ChamarDescer[i] = 0;
                ChamarSubir[i] = 0;
            }

        }

        //Desligando o display de cada celula
        private void INTERNO_SelectionChanged(object sender, EventArgs e)
        {
            INTERNO.Rows[INTERNO.CurrentCell.RowIndex].Selected = false;
        }
        //Desligando o display de cada celula
        private void ELEVADOR_SelectionChanged(object sender, EventArgs e)
        {
            ELEVADOR.Rows[ELEVADOR.CurrentCell.RowIndex].Selected = false;
        }
        //Desligando o display de cada celula
        private void DESCE_EX_SelectionChanged(object sender, EventArgs e)
        {
            DESCE_EX.Rows[DESCE_EX.CurrentCell.RowIndex].Selected = false;
        }
        //Desligando o display de cada celula
        private void SOBE_EX_SelectionChanged(object sender, EventArgs e)
        {
            SOBE_EX.Rows[SOBE_EX.CurrentCell.RowIndex].Selected = false;
        }

        //Fazendo de cada celula da array um botão
        private void INTERNO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = INTERNO.CurrentRow.Index;
            ChamarInterno[5 - Linha] = 5 - Linha + 1;
           //testando Console.WriteLine(Linha);
            INTERNO.Rows[Linha].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        //Fazendo de cada celula da array um botão
        private void DESCE_EX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = DESCE_EX.CurrentRow.Index;
            ChamarDescer[5 - Linha] = 5 - Linha + 1;
            DESCE_EX.Rows[Linha].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        //Fazendo de cada celula da array um botão
        private void SOBE_EX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = SOBE_EX.CurrentRow.Index;
            ChamarSubir[5 - Linha] = 5 - Linha + 1;
            SOBE_EX.Rows[Linha].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            //Movendo o elevador
            for (int i = 0; i < 6; i++)
            {
                int chamar = ChamarInterno[i];
                int pos = (int)Andar;
                if (chamar != 0) //se foi chamado
                {
                    if (i != pos) //se a posição que foi apertada for diferente de i
                    {
                        ELEVADOR[0, 5 - pos].Value = null; // O elevador vai para o espaço vazio 

                        if (i > pos)//O elevador sobe
                        {
                            pos++;
                            ELEVADOR[0, 5 - pos].Value = FecharImagem;
                            Andar++;
                        }
                        else if (i < pos) // O elevador desce
                        {
                            pos--;
                            ELEVADOR[0, 5 - pos].Value = FecharImagem;
                            Andar--;
                        }
                    }
                    else //se for iguall
                    {
                        ELEVADOR[0, 5 - pos].Value = FecharImagem;
                        ChamarInterno[i] = 0;
                        INTERNO.Rows[5 - pos].DefaultCellStyle.BackColor = Color.White;
                    }
                    break;
                }
            }
        }
    }
}
