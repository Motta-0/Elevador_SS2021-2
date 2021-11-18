using log4net;
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
        String[] NumerarAndares = new string[6] { "T", "2°", "3°", "4°", "5°", "6°"};

        //NumerarAndares 
        enum Andares { T, A2, A3, A4, A5, A6 };
        Andares Andar = Andares.T;//Andar inicial

        //Prioridade para os botões apertados
        const int FILA = 6;
        int[] FilaInt = new int[FILA];
        int chamarAndar = 0; //Não foi chamado

        enum DIRECAO { SOBE, DESCE, PARA };
        DIRECAO direcao = DIRECAO.PARA;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();

            //Criando a array do funcionamento interno
            INTERNO.RowTemplate.Height = 60;
            INTERNO.Rows.Add(6);
            for (int i = 0; i < 6; i++)
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
            Tempo.Interval = 1000;
            Tempo.Start();

            //Definindo as imagens
            AbrirImagem = new Bitmap("ElevAberto.gif");
            FecharImagem = new Bitmap("ElevFechado.gif");
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)ELEVADOR.Columns["Coluna_Imagem"];
            imageColumn.DefaultCellStyle.NullValue = null;
            ELEVADOR[0, 5].Value = FecharImagem;

            //Zerando a informação dos botões das Arrays
            for (int i = 0; i < 6; i++)
            {
                ChamarInterno[i] = 0;
                ChamarDescer[i] = 0;
                ChamarSubir[i] = 0;
            }

            //Zerando a prioridade
            for (int i = 0; i < FILA; i++)
            {
                FilaInt[i] = 0;
            }

            direcao = DIRECAO.PARA;
            chamarAndar = 0;
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

        //Definindo os botões de automatico e manual
        private void Automatic_CheckedChanged(object sender, EventArgs e)
        {
            if (Automatic.Checked == true)
            {
                Manual.Checked = false;

            }
            else
            {
                Manual.Checked = true;
            }

        }


        //Definindo os botões de automatico e manual
        private void Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (Manual.Checked == true)
            {
                Automatic.Checked = false;
            }
            else
            {
                Automatic.Checked = true;
            }
        }

        //Fazendo de cada celula da array um botão
        private void INTERNO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = INTERNO.CurrentRow.Index;
            int chamar = 5 - Linha + 1;
            ChamarInterno[5 - Linha] = chamar;
            //testando Console.WriteLine(Linha);
            chamarFILA(chamar);
            INTERNO.Rows[Linha].DefaultCellStyle.BackColor = Color.CornflowerBlue;
            string txt1 = string.Format("Andar chamado dentro do elevador: {0}", chamar);
            log.Info(txt1);
        }

        //Fazendo de cada celula da array um botão
        private void DESCE_EX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = DESCE_EX.CurrentRow.Index;
            int chamar = 5 - Linha + 1;
            ChamarDescer[5 - Linha] = chamar;
            chamarFILA(chamar);
            DESCE_EX.Rows[Linha].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        //Fazendo de cada celula da array um botão
        private void SOBE_EX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Linha = SOBE_EX.CurrentRow.Index;
            int chamar = 5 - Linha + 1;
            ChamarSubir[5 - Linha] = chamar;
            chamarFILA(chamar);
            SOBE_EX.Rows[Linha].DefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            switch (direcao)
            {
                case DIRECAO.PARA:
                    Inicio();
                    break;

            }

        }
        //oi

        //DIVIDINDO O MOVIMENTO DO ELEVADOR EM FUNÇÕES  
        private void Inicio()
        {
            int Atual = (int)Andar;
            if (chamarAndar == 0)
                chamarAndar = tiraFILA();


            if (chamarAndar > 0)
            {
                int chamar = chamarAndar - 1;

                if (chamar != Atual) //Ta no lugar errado
                {
                    ELEVADOR[0, 5 - Atual].Value = null; //Anda pra um espaço vazio

                    if (chamar > Atual)//O elevador sobe
                    {
                        Sobe();
                    }
                    else //O elevador Desce
                        Desce();
                }
                else
                {
                    Para();
                }
            }
        }

        private void Sobe()
        {
            int Atual = (int)Andar;
            int chamar = chamarAndar - 1;
            Atual++;
            ELEVADOR[0, 5 - Atual].Value = FecharImagem;
            Andar++;

            if (chamar == Atual)
                ELEVADOR[0, 5 - Atual].Value = AbrirImagem;
        }

        private void Desce()
        {
            int Atual = (int)Andar;
            int chamar = chamarAndar - 1;
            Atual--;
            ELEVADOR[0, 5 - Atual].Value = FecharImagem;
            Andar--;

            if (chamar == Atual)
                ELEVADOR[0, 5 - Atual].Value = AbrirImagem;
        }

        private void Para()
        {
            int Atual = (int)Andar;
            int chamar = chamarAndar - 1;
            ELEVADOR[0, 5 - Atual].Value = FecharImagem;
            ChamarInterno[chamar] = 0;
            ChamarSubir[chamar] = 0;
            ChamarDescer[chamar] = 0;
            INTERNO.Rows[5 - Atual].DefaultCellStyle.BackColor = Color.White;
            SOBE_EX.Rows[5 - Atual].DefaultCellStyle.BackColor = Color.White;
            DESCE_EX.Rows[5 - Atual].DefaultCellStyle.BackColor = Color.White;
            chamarAndar = 0;
        }

        //Função que joga os andares mais altos primeiro
        private void chamarFILA(int p)
        {
            for (int i = 0; i < FILA; i++)
            {
                if (FilaInt[i] == 0)
                {
                    FilaInt[i] = p;
                    break;
                }
            }
        }

        //Função que tira a ultima posição da fila para colocar outro no lugar
        private int tiraFILA()
        {
            int ret = FilaInt[0];
            int i;
            for (i = 1; i < FILA; i++)
            {
                FilaInt[i - 1] = FilaInt[i];
            }
            FilaInt[i - 1] = 0;

            return ret;
        }


    }
}

