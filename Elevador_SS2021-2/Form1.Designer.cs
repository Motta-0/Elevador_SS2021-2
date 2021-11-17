namespace Elevador_SS2021_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.INTERNO = new System.Windows.Forms.DataGridView();
            this.Coluna_Interna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ELEVADOR = new System.Windows.Forms.DataGridView();
            this.Coluna_Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DESCE_EX = new System.Windows.Forms.DataGridView();
            this.DESCE_eXTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOBE_EX = new System.Windows.Forms.DataGridView();
            this.SOBE_EXTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.INTERNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ELEVADOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESCE_EX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SOBE_EX)).BeginInit();
            this.SuspendLayout();
            // 
            // INTERNO
            // 
            this.INTERNO.AllowUserToAddRows = false;
            this.INTERNO.AllowUserToDeleteRows = false;
            this.INTERNO.ColumnHeadersHeight = 4;
            this.INTERNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.INTERNO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_Interna});
            this.INTERNO.Location = new System.Drawing.Point(1048, 192);
            this.INTERNO.Name = "INTERNO";
            this.INTERNO.ReadOnly = true;
            this.INTERNO.RowHeadersVisible = false;
            this.INTERNO.RowHeadersWidth = 1000;
            this.INTERNO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.INTERNO.RowTemplate.Height = 24;
            this.INTERNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.INTERNO.Size = new System.Drawing.Size(203, 450);
            this.INTERNO.TabIndex = 0;
            this.INTERNO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.INTERNO_CellClick);
            this.INTERNO.SelectionChanged += new System.EventHandler(this.INTERNO_SelectionChanged);
            // 
            // Coluna_Interna
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coluna_Interna.DefaultCellStyle = dataGridViewCellStyle1;
            this.Coluna_Interna.HeaderText = "";
            this.Coluna_Interna.MaxInputLength = 1;
            this.Coluna_Interna.Name = "Coluna_Interna";
            this.Coluna_Interna.ReadOnly = true;
            this.Coluna_Interna.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1046, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAINEL INTERNO";
            // 
            // ELEVADOR
            // 
            this.ELEVADOR.AllowUserToAddRows = false;
            this.ELEVADOR.AllowUserToDeleteRows = false;
            this.ELEVADOR.ColumnHeadersHeight = 4;
            this.ELEVADOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ELEVADOR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_Imagem});
            this.ELEVADOR.Location = new System.Drawing.Point(472, 83);
            this.ELEVADOR.Name = "ELEVADOR";
            this.ELEVADOR.ReadOnly = true;
            this.ELEVADOR.RowHeadersVisible = false;
            this.ELEVADOR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ELEVADOR.RowTemplate.Height = 24;
            this.ELEVADOR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ELEVADOR.Size = new System.Drawing.Size(405, 559);
            this.ELEVADOR.TabIndex = 2;
            this.ELEVADOR.SelectionChanged += new System.EventHandler(this.ELEVADOR_SelectionChanged);
            // 
            // Coluna_Imagem
            // 
            this.Coluna_Imagem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coluna_Imagem.HeaderText = "";
            this.Coluna_Imagem.Name = "Coluna_Imagem";
            this.Coluna_Imagem.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(593, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ELEVADOR";
            // 
            // DESCE_EX
            // 
            this.DESCE_EX.AllowUserToAddRows = false;
            this.DESCE_EX.AllowUserToDeleteRows = false;
            this.DESCE_EX.ColumnHeadersHeight = 4;
            this.DESCE_EX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DESCE_EX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCE_eXTERNO});
            this.DESCE_EX.Location = new System.Drawing.Point(187, 192);
            this.DESCE_EX.Name = "DESCE_EX";
            this.DESCE_EX.ReadOnly = true;
            this.DESCE_EX.RowHeadersVisible = false;
            this.DESCE_EX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DESCE_EX.RowTemplate.Height = 24;
            this.DESCE_EX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DESCE_EX.Size = new System.Drawing.Size(130, 449);
            this.DESCE_EX.TabIndex = 4;
            this.DESCE_EX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DESCE_EX_CellClick);
            this.DESCE_EX.SelectionChanged += new System.EventHandler(this.DESCE_EX_SelectionChanged);
            // 
            // DESCE_eXTERNO
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DESCE_eXTERNO.DefaultCellStyle = dataGridViewCellStyle2;
            this.DESCE_eXTERNO.HeaderText = "";
            this.DESCE_eXTERNO.MaxInputLength = 1;
            this.DESCE_eXTERNO.Name = "DESCE_eXTERNO";
            this.DESCE_eXTERNO.ReadOnly = true;
            // 
            // SOBE_EX
            // 
            this.SOBE_EX.AllowUserToAddRows = false;
            this.SOBE_EX.AllowUserToDeleteRows = false;
            this.SOBE_EX.ColumnHeadersHeight = 4;
            this.SOBE_EX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SOBE_EX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOBE_EXTERNO});
            this.SOBE_EX.Location = new System.Drawing.Point(22, 192);
            this.SOBE_EX.Name = "SOBE_EX";
            this.SOBE_EX.ReadOnly = true;
            this.SOBE_EX.RowHeadersVisible = false;
            this.SOBE_EX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SOBE_EX.RowTemplate.Height = 24;
            this.SOBE_EX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SOBE_EX.Size = new System.Drawing.Size(130, 449);
            this.SOBE_EX.TabIndex = 5;
            this.SOBE_EX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SOBE_EX_CellClick);
            this.SOBE_EX.SelectionChanged += new System.EventHandler(this.SOBE_EX_SelectionChanged);
            // 
            // SOBE_EXTERNO
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SOBE_EXTERNO.DefaultCellStyle = dataGridViewCellStyle3;
            this.SOBE_EXTERNO.HeaderText = "";
            this.SOBE_EXTERNO.MaxInputLength = 1;
            this.SOBE_EXTERNO.Name = "SOBE_EXTERNO";
            this.SOBE_EXTERNO.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(210, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(45, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "SOBE";
            // 
            // Tempo
            // 
            this.Tempo.Interval = 1000;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 650);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SOBE_EX);
            this.Controls.Add(this.DESCE_EX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ELEVADOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INTERNO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.INTERNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ELEVADOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESCE_EX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SOBE_EX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView INTERNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ELEVADOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DESCE_EX;
        private System.Windows.Forms.DataGridView SOBE_EX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn Coluna_Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Interna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCE_eXTERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBE_EXTERNO;
        private System.Windows.Forms.Timer Tempo;
    }
}

