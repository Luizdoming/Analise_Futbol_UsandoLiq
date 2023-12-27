namespace UsandoLinq
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            dgvDados_Brasil = new DataGridView();
            label1 = new Label();
            cbo_Equipes_Brasil = new ComboBox();
            previewDialog = new PrintPreviewDialog();
            print = new System.Drawing.Printing.PrintDocument();
            PanelBra = new Panel();
            Lbl_empate = new Label();
            Lbl_media_cartao = new Label();
            Lbl_total_cartao = new Label();
            Lbl_total_Derrota = new Label();
            Lbl_total_Vitoria = new Label();
            Lbl_Vitoria_Fora = new Label();
            Lbl_Vitoria_Casa = new Label();
            Lbl_Media_Cantos_Ht_Fora = new Label();
            Lbl_Media_Cantos_Ht_Casa = new Label();
            Lbl_Media_Cantos_Fora = new Label();
            Lbl_Media_Cantos_Casa = new Label();
            Lbl_Media_Ht_Fora = new Label();
            Lbl_Gol_Ht_Fora = new Label();
            Lbl_Media_Ht_Casa = new Label();
            Lbl_Gol_Ht_Casa = new Label();
            Lbl_Media_Gol_Fora = new Label();
            Lbl_Total_Gol_Fora = new Label();
            Lbl_MediaGol_Casa = new Label();
            Lbl_Total_Gol_Casa = new Label();
            Rb_JogosCasa_BR = new RadioButton();
            Rb_JogosFora_Brasil = new RadioButton();
            Rb_jogos_CantosHT = new RadioButton();
            Rb_golsHt = new RadioButton();
            Rb_JogosSemMarcar = new RadioButton();
            Rb_Estatisticas_Capeonato = new RadioButton();
            label2 = new Label();
            lbl_totalJogosEquipe = new Label();
            label3 = new Label();
            Cbo_europa = new ComboBox();
            Chk_brasil = new CheckBox();
            Chk_Europa = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvDados_Brasil).BeginInit();
            PanelBra.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDados_Brasil
            // 
            dgvDados_Brasil.AllowUserToAddRows = false;
            dgvDados_Brasil.AllowUserToDeleteRows = false;
            dgvDados_Brasil.AllowUserToResizeColumns = false;
            dgvDados_Brasil.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDados_Brasil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDados_Brasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDados_Brasil.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDados_Brasil.BackgroundColor = Color.WhiteSmoke;
            dgvDados_Brasil.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDados_Brasil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDados_Brasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados_Brasil.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDados_Brasil.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDados_Brasil.GridColor = SystemColors.ScrollBar;
            dgvDados_Brasil.Location = new Point(12, 103);
            dgvDados_Brasil.MultiSelect = false;
            dgvDados_Brasil.Name = "dgvDados_Brasil";
            dgvDados_Brasil.ReadOnly = true;
            dgvDados_Brasil.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDados_Brasil.RowHeadersVisible = false;
            dgvDados_Brasil.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDados_Brasil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados_Brasil.ShowCellErrors = false;
            dgvDados_Brasil.ShowCellToolTips = false;
            dgvDados_Brasil.ShowEditingIcon = false;
            dgvDados_Brasil.ShowRowErrors = false;
            dgvDados_Brasil.Size = new Size(575, 591);
            dgvDados_Brasil.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(818, 1);
            label1.Name = "label1";
            label1.Size = new Size(136, 17);
            label1.TabIndex = 1;
            label1.Text = "Selecione uma Equipe";
            // 
            // cbo_Equipes_Brasil
            // 
            cbo_Equipes_Brasil.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbo_Equipes_Brasil.ForeColor = SystemColors.GrayText;
            cbo_Equipes_Brasil.FormattingEnabled = true;
            cbo_Equipes_Brasil.Location = new Point(819, 21);
            cbo_Equipes_Brasil.Name = "cbo_Equipes_Brasil";
            cbo_Equipes_Brasil.Size = new Size(157, 28);
            cbo_Equipes_Brasil.TabIndex = 2;
            cbo_Equipes_Brasil.SelectedValueChanged += Cbo_Equipes_Brasil_SelectedValueChanged;
            // 
            // previewDialog
            // 
            previewDialog.AutoScrollMargin = new Size(0, 0);
            previewDialog.AutoScrollMinSize = new Size(0, 0);
            previewDialog.ClientSize = new Size(400, 300);
            previewDialog.Enabled = true;
            previewDialog.Icon = (Icon)resources.GetObject("previewDialog.Icon");
            previewDialog.Name = "previewDialog";
            previewDialog.Visible = false;
            // 
            // print
            // 
            print.PrintPage += Print_PrintPage;
            // 
            // PanelBra
            // 
            PanelBra.BorderStyle = BorderStyle.FixedSingle;
            PanelBra.Controls.Add(Lbl_empate);
            PanelBra.Controls.Add(Lbl_media_cartao);
            PanelBra.Controls.Add(Lbl_total_cartao);
            PanelBra.Controls.Add(Lbl_total_Derrota);
            PanelBra.Controls.Add(Lbl_total_Vitoria);
            PanelBra.Controls.Add(Lbl_Vitoria_Fora);
            PanelBra.Controls.Add(Lbl_Vitoria_Casa);
            PanelBra.Controls.Add(Lbl_Media_Cantos_Ht_Fora);
            PanelBra.Controls.Add(Lbl_Media_Cantos_Ht_Casa);
            PanelBra.Controls.Add(Lbl_Media_Cantos_Fora);
            PanelBra.Controls.Add(Lbl_Media_Cantos_Casa);
            PanelBra.Controls.Add(Lbl_Media_Ht_Fora);
            PanelBra.Controls.Add(Lbl_Gol_Ht_Fora);
            PanelBra.Controls.Add(Lbl_Media_Ht_Casa);
            PanelBra.Controls.Add(Lbl_Gol_Ht_Casa);
            PanelBra.Controls.Add(Lbl_Media_Gol_Fora);
            PanelBra.Controls.Add(Lbl_Total_Gol_Fora);
            PanelBra.Controls.Add(Lbl_MediaGol_Casa);
            PanelBra.Controls.Add(Lbl_Total_Gol_Casa);
            PanelBra.Cursor = Cursors.Hand;
            PanelBra.Location = new Point(593, 103);
            PanelBra.Name = "PanelBra";
            PanelBra.Size = new Size(387, 591);
            PanelBra.TabIndex = 3;
            // 
            // Lbl_empate
            // 
            Lbl_empate.AutoSize = true;
            Lbl_empate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_empate.Location = new Point(14, 552);
            Lbl_empate.Name = "Lbl_empate";
            Lbl_empate.Size = new Size(17, 17);
            Lbl_empate.TabIndex = 12;
            Lbl_empate.Text = "...";
            // 
            // Lbl_media_cartao
            // 
            Lbl_media_cartao.AutoSize = true;
            Lbl_media_cartao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_media_cartao.Location = new Point(14, 522);
            Lbl_media_cartao.Name = "Lbl_media_cartao";
            Lbl_media_cartao.Size = new Size(17, 17);
            Lbl_media_cartao.TabIndex = 13;
            Lbl_media_cartao.Text = "...";
            // 
            // Lbl_total_cartao
            // 
            Lbl_total_cartao.AutoSize = true;
            Lbl_total_cartao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_total_cartao.Location = new Point(14, 492);
            Lbl_total_cartao.Name = "Lbl_total_cartao";
            Lbl_total_cartao.Size = new Size(17, 17);
            Lbl_total_cartao.TabIndex = 14;
            Lbl_total_cartao.Text = "...";
            // 
            // Lbl_total_Derrota
            // 
            Lbl_total_Derrota.AutoSize = true;
            Lbl_total_Derrota.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_total_Derrota.Location = new Point(14, 462);
            Lbl_total_Derrota.Name = "Lbl_total_Derrota";
            Lbl_total_Derrota.Size = new Size(17, 17);
            Lbl_total_Derrota.TabIndex = 15;
            Lbl_total_Derrota.Text = "...";
            // 
            // Lbl_total_Vitoria
            // 
            Lbl_total_Vitoria.AutoSize = true;
            Lbl_total_Vitoria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_total_Vitoria.Location = new Point(14, 432);
            Lbl_total_Vitoria.Name = "Lbl_total_Vitoria";
            Lbl_total_Vitoria.Size = new Size(17, 17);
            Lbl_total_Vitoria.TabIndex = 6;
            Lbl_total_Vitoria.Text = "...";
            // 
            // Lbl_Vitoria_Fora
            // 
            Lbl_Vitoria_Fora.AutoSize = true;
            Lbl_Vitoria_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Vitoria_Fora.Location = new Point(14, 402);
            Lbl_Vitoria_Fora.Name = "Lbl_Vitoria_Fora";
            Lbl_Vitoria_Fora.Size = new Size(17, 17);
            Lbl_Vitoria_Fora.TabIndex = 7;
            Lbl_Vitoria_Fora.Text = "...";
            // 
            // Lbl_Vitoria_Casa
            // 
            Lbl_Vitoria_Casa.AutoSize = true;
            Lbl_Vitoria_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Vitoria_Casa.Location = new Point(14, 372);
            Lbl_Vitoria_Casa.Name = "Lbl_Vitoria_Casa";
            Lbl_Vitoria_Casa.Size = new Size(17, 17);
            Lbl_Vitoria_Casa.TabIndex = 8;
            Lbl_Vitoria_Casa.Text = "...";
            // 
            // Lbl_Media_Cantos_Ht_Fora
            // 
            Lbl_Media_Cantos_Ht_Fora.AutoSize = true;
            Lbl_Media_Cantos_Ht_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Cantos_Ht_Fora.Location = new Point(14, 342);
            Lbl_Media_Cantos_Ht_Fora.Name = "Lbl_Media_Cantos_Ht_Fora";
            Lbl_Media_Cantos_Ht_Fora.Size = new Size(17, 17);
            Lbl_Media_Cantos_Ht_Fora.TabIndex = 9;
            Lbl_Media_Cantos_Ht_Fora.Text = "...";
            // 
            // Lbl_Media_Cantos_Ht_Casa
            // 
            Lbl_Media_Cantos_Ht_Casa.AutoSize = true;
            Lbl_Media_Cantos_Ht_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Cantos_Ht_Casa.Location = new Point(14, 312);
            Lbl_Media_Cantos_Ht_Casa.Name = "Lbl_Media_Cantos_Ht_Casa";
            Lbl_Media_Cantos_Ht_Casa.Size = new Size(17, 17);
            Lbl_Media_Cantos_Ht_Casa.TabIndex = 10;
            Lbl_Media_Cantos_Ht_Casa.Text = "...";
            // 
            // Lbl_Media_Cantos_Fora
            // 
            Lbl_Media_Cantos_Fora.AutoSize = true;
            Lbl_Media_Cantos_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Cantos_Fora.Location = new Point(14, 282);
            Lbl_Media_Cantos_Fora.Name = "Lbl_Media_Cantos_Fora";
            Lbl_Media_Cantos_Fora.Size = new Size(17, 17);
            Lbl_Media_Cantos_Fora.TabIndex = 1;
            Lbl_Media_Cantos_Fora.Text = "...";
            // 
            // Lbl_Media_Cantos_Casa
            // 
            Lbl_Media_Cantos_Casa.AutoSize = true;
            Lbl_Media_Cantos_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Cantos_Casa.Location = new Point(14, 252);
            Lbl_Media_Cantos_Casa.Name = "Lbl_Media_Cantos_Casa";
            Lbl_Media_Cantos_Casa.Size = new Size(17, 17);
            Lbl_Media_Cantos_Casa.TabIndex = 2;
            Lbl_Media_Cantos_Casa.Text = "...";
            // 
            // Lbl_Media_Ht_Fora
            // 
            Lbl_Media_Ht_Fora.AutoSize = true;
            Lbl_Media_Ht_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Ht_Fora.Location = new Point(14, 222);
            Lbl_Media_Ht_Fora.Name = "Lbl_Media_Ht_Fora";
            Lbl_Media_Ht_Fora.Size = new Size(17, 17);
            Lbl_Media_Ht_Fora.TabIndex = 3;
            Lbl_Media_Ht_Fora.Text = "...";
            // 
            // Lbl_Gol_Ht_Fora
            // 
            Lbl_Gol_Ht_Fora.AutoSize = true;
            Lbl_Gol_Ht_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Gol_Ht_Fora.Location = new Point(14, 192);
            Lbl_Gol_Ht_Fora.Name = "Lbl_Gol_Ht_Fora";
            Lbl_Gol_Ht_Fora.Size = new Size(17, 17);
            Lbl_Gol_Ht_Fora.TabIndex = 4;
            Lbl_Gol_Ht_Fora.Text = "...";
            // 
            // Lbl_Media_Ht_Casa
            // 
            Lbl_Media_Ht_Casa.AutoSize = true;
            Lbl_Media_Ht_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Ht_Casa.Location = new Point(14, 162);
            Lbl_Media_Ht_Casa.Name = "Lbl_Media_Ht_Casa";
            Lbl_Media_Ht_Casa.Size = new Size(17, 17);
            Lbl_Media_Ht_Casa.TabIndex = 5;
            Lbl_Media_Ht_Casa.Text = "...";
            // 
            // Lbl_Gol_Ht_Casa
            // 
            Lbl_Gol_Ht_Casa.AutoSize = true;
            Lbl_Gol_Ht_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Gol_Ht_Casa.Location = new Point(14, 132);
            Lbl_Gol_Ht_Casa.Name = "Lbl_Gol_Ht_Casa";
            Lbl_Gol_Ht_Casa.Size = new Size(17, 17);
            Lbl_Gol_Ht_Casa.TabIndex = 0;
            Lbl_Gol_Ht_Casa.Text = "...";
            // 
            // Lbl_Media_Gol_Fora
            // 
            Lbl_Media_Gol_Fora.AutoSize = true;
            Lbl_Media_Gol_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Media_Gol_Fora.Location = new Point(14, 102);
            Lbl_Media_Gol_Fora.Name = "Lbl_Media_Gol_Fora";
            Lbl_Media_Gol_Fora.Size = new Size(17, 17);
            Lbl_Media_Gol_Fora.TabIndex = 0;
            Lbl_Media_Gol_Fora.Text = "...";
            // 
            // Lbl_Total_Gol_Fora
            // 
            Lbl_Total_Gol_Fora.AutoSize = true;
            Lbl_Total_Gol_Fora.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Total_Gol_Fora.Location = new Point(14, 72);
            Lbl_Total_Gol_Fora.Name = "Lbl_Total_Gol_Fora";
            Lbl_Total_Gol_Fora.Size = new Size(17, 17);
            Lbl_Total_Gol_Fora.TabIndex = 0;
            Lbl_Total_Gol_Fora.Text = "...";
            // 
            // Lbl_MediaGol_Casa
            // 
            Lbl_MediaGol_Casa.AutoSize = true;
            Lbl_MediaGol_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_MediaGol_Casa.Location = new Point(14, 42);
            Lbl_MediaGol_Casa.Name = "Lbl_MediaGol_Casa";
            Lbl_MediaGol_Casa.Size = new Size(17, 17);
            Lbl_MediaGol_Casa.TabIndex = 0;
            Lbl_MediaGol_Casa.Text = "...";
            // 
            // Lbl_Total_Gol_Casa
            // 
            Lbl_Total_Gol_Casa.AutoSize = true;
            Lbl_Total_Gol_Casa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Lbl_Total_Gol_Casa.Location = new Point(14, 12);
            Lbl_Total_Gol_Casa.Name = "Lbl_Total_Gol_Casa";
            Lbl_Total_Gol_Casa.Size = new Size(17, 17);
            Lbl_Total_Gol_Casa.TabIndex = 0;
            Lbl_Total_Gol_Casa.Text = "...";
            // 
            // Rb_JogosCasa_BR
            // 
            Rb_JogosCasa_BR.AutoSize = true;
            Rb_JogosCasa_BR.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rb_JogosCasa_BR.Location = new Point(14, 3);
            Rb_JogosCasa_BR.Name = "Rb_JogosCasa_BR";
            Rb_JogosCasa_BR.Size = new Size(93, 21);
            Rb_JogosCasa_BR.TabIndex = 4;
            Rb_JogosCasa_BR.TabStop = true;
            Rb_JogosCasa_BR.Text = "Jogos Casa";
            Rb_JogosCasa_BR.UseVisualStyleBackColor = true;
            // 
            // Rb_JogosFora_Brasil
            // 
            Rb_JogosFora_Brasil.AutoSize = true;
            Rb_JogosFora_Brasil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rb_JogosFora_Brasil.Location = new Point(118, 3);
            Rb_JogosFora_Brasil.Name = "Rb_JogosFora_Brasil";
            Rb_JogosFora_Brasil.Size = new Size(92, 21);
            Rb_JogosFora_Brasil.TabIndex = 4;
            Rb_JogosFora_Brasil.TabStop = true;
            Rb_JogosFora_Brasil.Text = "Jogos Fora";
            Rb_JogosFora_Brasil.UseVisualStyleBackColor = true;
            // 
            // Rb_jogos_CantosHT
            // 
            Rb_jogos_CantosHT.AutoSize = true;
            Rb_jogos_CantosHT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rb_jogos_CantosHT.Location = new Point(221, 3);
            Rb_jogos_CantosHT.Name = "Rb_jogos_CantosHT";
            Rb_jogos_CantosHT.Size = new Size(89, 21);
            Rb_jogos_CantosHT.TabIndex = 4;
            Rb_jogos_CantosHT.TabStop = true;
            Rb_jogos_CantosHT.Text = "Cantos HT";
            Rb_jogos_CantosHT.UseVisualStyleBackColor = true;
            // 
            // Rb_golsHt
            // 
            Rb_golsHt.AutoSize = true;
            Rb_golsHt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rb_golsHt.Location = new Point(321, 3);
            Rb_golsHt.Name = "Rb_golsHt";
            Rb_golsHt.Size = new Size(73, 21);
            Rb_golsHt.TabIndex = 4;
            Rb_golsHt.TabStop = true;
            Rb_golsHt.Text = "Gols HT";
            Rb_golsHt.UseVisualStyleBackColor = true;
            // 
            // Rb_JogosSemMarcar
            // 
            Rb_JogosSemMarcar.AutoSize = true;
            Rb_JogosSemMarcar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rb_JogosSemMarcar.Location = new Point(405, 3);
            Rb_JogosSemMarcar.Name = "Rb_JogosSemMarcar";
            Rb_JogosSemMarcar.Size = new Size(167, 21);
            Rb_JogosSemMarcar.TabIndex = 4;
            Rb_JogosSemMarcar.TabStop = true;
            Rb_JogosSemMarcar.Text = "Jogos Sem Marcar Gols";
            Rb_JogosSemMarcar.UseVisualStyleBackColor = true;
            // 
            // Rb_Estatisticas_Capeonato
            // 
            Rb_Estatisticas_Capeonato.AutoSize = true;
            Rb_Estatisticas_Capeonato.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rb_Estatisticas_Capeonato.Location = new Point(583, 3);
            Rb_Estatisticas_Capeonato.Name = "Rb_Estatisticas_Capeonato";
            Rb_Estatisticas_Capeonato.Size = new Size(168, 21);
            Rb_Estatisticas_Capeonato.TabIndex = 4;
            Rb_Estatisticas_Capeonato.TabStop = true;
            Rb_Estatisticas_Capeonato.Text = "Estatisticas Competição";
            Rb_Estatisticas_Capeonato.UseVisualStyleBackColor = true;
            Rb_Estatisticas_Capeonato.CheckedChanged += Rb_Estatisticas_Capeonato_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(12, 706);
            label2.Name = "label2";
            label2.Size = new Size(314, 17);
            label2.TabIndex = 5;
            label2.Text = "Use a Tecla -  P  - Para Imprimir ou Gerar um PDF. ";
            // 
            // lbl_totalJogosEquipe
            // 
            lbl_totalJogosEquipe.AutoSize = true;
            lbl_totalJogosEquipe.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_totalJogosEquipe.ForeColor = SystemColors.GrayText;
            lbl_totalJogosEquipe.Location = new Point(15, 80);
            lbl_totalJogosEquipe.Name = "lbl_totalJogosEquipe";
            lbl_totalJogosEquipe.Size = new Size(15, 20);
            lbl_totalJogosEquipe.TabIndex = 6;
            lbl_totalJogosEquipe.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(818, 49);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 1;
            label3.Text = "Selecione uma Liga";
            // 
            // Cbo_europa
            // 
            Cbo_europa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cbo_europa.ForeColor = SystemColors.GrayText;
            Cbo_europa.FormattingEnabled = true;
            Cbo_europa.Location = new Point(819, 69);
            Cbo_europa.Name = "Cbo_europa";
            Cbo_europa.Size = new Size(157, 28);
            Cbo_europa.TabIndex = 2;
            Cbo_europa.SelectedValueChanged += Cbo_europa_SelectedValueChanged;
            // 
            // Chk_brasil
            // 
            Chk_brasil.AutoSize = true;
            Chk_brasil.Location = new Point(729, 53);
            Chk_brasil.Name = "Chk_brasil";
            Chk_brasil.Size = new Size(54, 19);
            Chk_brasil.TabIndex = 7;
            Chk_brasil.Text = "Brasil";
            Chk_brasil.UseVisualStyleBackColor = true;
            Chk_brasil.CheckedChanged += Chk_brasil_CheckedChanged;
            // 
            // Chk_Europa
            // 
            Chk_Europa.AutoSize = true;
            Chk_Europa.Location = new Point(729, 78);
            Chk_Europa.Name = "Chk_Europa";
            Chk_Europa.Size = new Size(63, 19);
            Chk_Europa.TabIndex = 7;
            Chk_Europa.Text = "Europa";
            Chk_Europa.UseVisualStyleBackColor = true;
            Chk_Europa.CheckedChanged += Chk_Europa_CheckedChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 729);
            Controls.Add(Chk_Europa);
            Controls.Add(Chk_brasil);
            Controls.Add(lbl_totalJogosEquipe);
            Controls.Add(label2);
            Controls.Add(Rb_Estatisticas_Capeonato);
            Controls.Add(Rb_JogosSemMarcar);
            Controls.Add(Rb_golsHt);
            Controls.Add(Rb_jogos_CantosHT);
            Controls.Add(Rb_JogosFora_Brasil);
            Controls.Add(Rb_JogosCasa_BR);
            Controls.Add(PanelBra);
            Controls.Add(Cbo_europa);
            Controls.Add(label3);
            Controls.Add(cbo_Equipes_Brasil);
            Controls.Add(label1);
            Controls.Add(dgvDados_Brasil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMain";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados_Brasil).EndInit();
            PanelBra.ResumeLayout(false);
            PanelBra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados_Brasil;
        private Label label1;
        private ComboBox cbo_Equipes_Brasil;
        private PrintPreviewDialog previewDialog;
        private System.Drawing.Printing.PrintDocument print;
        private Panel PanelBra;
        private RadioButton Rb_JogosCasa_BR;
        private RadioButton Rb_JogosFora_Brasil;
        private RadioButton Rb_jogos_CantosHT;
        private RadioButton Rb_golsHt;
        private RadioButton Rb_JogosSemMarcar;
        private RadioButton Rb_Estatisticas_Capeonato;
        private Label Lbl_empate;
        private Label Lbl_media_cartao;
        private Label Lbl_total_cartao;
        private Label Lbl_total_Derrota;
        private Label Lbl_total_Vitoria;
        private Label Lbl_Vitoria_Fora;
        private Label Lbl_Vitoria_Casa;
        private Label Lbl_Media_Cantos_Ht_Fora;
        private Label Lbl_Media_Cantos_Ht_Casa;
        private Label Lbl_Media_Cantos_Fora;
        private Label Lbl_Media_Cantos_Casa;
        private Label Lbl_Media_Ht_Fora;
        private Label Lbl_Gol_Ht_Fora;
        private Label Lbl_Media_Ht_Casa;
        private Label Lbl_Gol_Ht_Casa;
        private Label Lbl_Media_Gol_Fora;
        private Label Lbl_Total_Gol_Fora;
        private Label Lbl_MediaGol_Casa;
        private Label Lbl_Total_Gol_Casa;
        private Label label2;
        private Label lbl_totalJogosEquipe;
        private Label label3;
        private ComboBox Cbo_europa;
        private CheckBox Chk_brasil;
        private CheckBox Chk_Europa;
    }
}
