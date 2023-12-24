using System.Drawing.Printing;
using UsandoLinq.Entities;
using static UsandoLinq.Entities.ImprimirResultados;

namespace UsandoLinq
{
    public partial class FrmMain : Form
    {
        readonly Brasileirao brasil = new();
        
        //Variavéis para manipulação das cordenadas do documento
        int x;
        int y;
        int largura;
        int altura;
        int paginas;
        int linhas;

        public string equipe;

        public FrmMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = $"Seja Bem Vindo | Hoje é  {DateTime.Now.ToLongDateString()}"; 
            brasil.AdcionarEquipesCombobox(cbo_Equipes_Brasil);
            LimparControles();
        }

        private void SelecionarJogosBrasileirao()
        {

            if (cbo_Equipes_Brasil.SelectedItem.ToString() != null && Rb_JogosCasa_BR.Checked)
            {
                equipe = cbo_Equipes_Brasil.SelectedItem.ToString();
                brasil.JogosCasa(dgvDados_Brasil, equipe);

                brasil.EstatisticaEquipe(equipe, Lbl_Total_Gol_Casa, Lbl_MediaGol_Casa, Lbl_Total_Gol_Fora,
                                         Lbl_Media_Gol_Fora, Lbl_Gol_Ht_Casa, Lbl_Media_Ht_Casa,
                                         Lbl_Gol_Ht_Fora, Lbl_Media_Ht_Fora, Lbl_Media_Cantos_Casa,
                                         Lbl_Media_Cantos_Fora, Lbl_Media_Cantos_Ht_Casa, Lbl_Media_Cantos_Ht_Fora,
                                         Lbl_Vitoria_Casa, Lbl_Vitoria_Fora, Lbl_total_Vitoria,
                                         Lbl_total_Derrota, Lbl_total_cartao, Lbl_media_cartao, Lbl_empate);
                
                return;
            }

            if (cbo_Equipes_Brasil.SelectedItem.ToString() != null && Rb_JogosFora_Brasil.Checked)
            {
                equipe = cbo_Equipes_Brasil.SelectedItem.ToString();
                brasil.JogosFora(dgvDados_Brasil, equipe);
                equipe = cbo_Equipes_Brasil.SelectedItem.ToString();

                brasil.EstatisticaEquipe(equipe, Lbl_Total_Gol_Casa, Lbl_MediaGol_Casa, Lbl_Total_Gol_Fora,
                                         Lbl_Media_Gol_Fora, Lbl_Gol_Ht_Casa, Lbl_Media_Ht_Casa,
                                         Lbl_Gol_Ht_Fora, Lbl_Media_Ht_Fora, Lbl_Media_Cantos_Casa,
                                         Lbl_Media_Cantos_Fora, Lbl_Media_Cantos_Ht_Casa, Lbl_Media_Cantos_Ht_Fora,
                                         Lbl_Vitoria_Casa, Lbl_Vitoria_Fora, Lbl_total_Vitoria,
                                         Lbl_total_Derrota, Lbl_total_cartao, Lbl_media_cartao, Lbl_empate);
               
                return;
            }

            if (Rb_jogos_CantosHT.Checked)
            {
                JogosComMaisDeTresCantosHt();
                return;
            }

            if (Rb_golsHt.Checked)
            {
                JogosGolsHt();
                return;
            }

            if (Rb_JogosSemMarcar.Checked)
            {
                try
                {
                    if (cbo_Equipes_Brasil.SelectedItem.ToString() != null)
                    {
                        equipe = cbo_Equipes_Brasil.SelectedItem.ToString();
                        brasil.JogosSemMarcarGols(equipe, dgvDados_Brasil);
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma equipe.");
                }
            }

            if (cbo_Equipes_Brasil.SelectedItem.ToString() != null)
            {
                equipe = cbo_Equipes_Brasil.SelectedItem.ToString();
                brasil.TodosJogosDaEquipe(equipe, dgvDados_Brasil);
            }

        }

        private void Cbo_Equipes_Brasil_SelectedValueChanged(object sender, System.EventArgs e)
        {
            SelecionarJogosBrasileirao();
        }

        private void Imprimir()
        {
            largura = print.DefaultPageSettings.Bounds.Width;
            altura = print.DefaultPageSettings.Bounds.Height;
            y = 40; x = 40;

            if (dgvDados_Brasil.RowCount < 1 && Rb_Estatisticas_Capeonato.Checked != true)
            {
                MessageBox.Show("Não existe dados para ser impresso!", "Aviso!");
                return;
            }
            else
            {
                print.Print();
            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            largura = print.DefaultPageSettings.Bounds.Width;
            altura = print.DefaultPageSettings.Bounds.Height;
            y = 40; x = 40;

            if (dgvDados_Brasil.RowCount < 1 && Rb_Estatisticas_Capeonato.Checked != true)
            {
                MessageBox.Show("Não existe dados para ser impresso!", "Aviso!");
                return;
            }
            else
            {
                print.Print();
            }
        }

        //Comando Para visualizar documento antes de imprimir
        private void VisualizarPrint()
        {
            if (dgvDados_Brasil.RowCount < 1)
            {
                MessageBox.Show("Não existe dados para ser impresso!", "Aviso!");
                return;
            }
            else
            {
                largura = print.DefaultPageSettings.Bounds.Width;
                altura = print.DefaultPageSettings.Bounds.Height;
                y = 50; x = 50;

                previewDialog.Document = print;
                previewDialog.ShowDialog();
            }
        }

        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region Dados lista;

            //Desenhando o ducumento para imprimir
            Font letra = new("Consolas", 11, FontStyle.Regular | FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);

            Font fontdoc = new("Consolas", 18, FontStyle.Bold, GraphicsUnit.Point);
            string tituloJogos = "JOGOS DA EQUIPE";
            Brush pincelTitulo = new SolidBrush(Color.Black);
            Rectangle areaTitulo = new(x, y, largura - 50, 27);
            StringFormat formatoTitulo = new()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            //Adcionando os registros da gridview em uma lista
            //----------------------------------------------------------------
            List<string> FilesR = new();   // Faz parte da class  record
            foreach (DataGridViewRow row in dgvDados_Brasil.Rows)
            {
                DadosParaImprimiR resultados = new()
                {
                    Data = row.Cells[0].Value.ToString().Substring(0, 10),
                    Home = row.Cells[1].Value.ToString().ToUpper(),
                    GolHome = Convert.ToInt32(row.Cells[2].Value.ToString()),
                    GolAway = Convert.ToInt32(row.Cells[3].Value.ToString()),
                    Away = row.Cells[4].Value.ToString().ToUpper()
                    //Gols = Convert.ToInt32(row.Cells[5].Value.ToString())
                };
                FilesR.Add(resultados.ToString());
            }

            //Adcionando o titulo
            e.Graphics.DrawString($"{DateTime.Now}", letra, pincel, new Point(x, y));
            if (FilesR.Count != 0)
            {
                e.Graphics.DrawString(tituloJogos, fontdoc, pincelTitulo, areaTitulo, formatoTitulo);
                y += 50;
            }

            //Adcionando os dados
            for (int i = 0; i < FilesR.Count; i++)
            {
                e.Graphics.DrawString(FilesR[i], letra, pincel, new Point(x, y));
                y += 25;
            }

            if (Rb_golsHt.Checked)
            {
                e.Graphics.DrawString($"Temos {dgvDados_Brasil.Rows.Count} jogos com gols no HT para equipe {equipe}", letra, pincel, new Point(x, y + 25));
            }

            if (Rb_jogos_CantosHT.Checked)
            {
                e.Graphics.DrawString($"Temos {dgvDados_Brasil.Rows.Count} jogos com gols mais de 3 cantos no HT para equipe {equipe}", letra, pincel, new Point(x, y + 25));
            }
            #endregion

            #region Dados Estatisticas
            if (Rb_Estatisticas_Capeonato.Checked || Rb_Estatisticas_Capeonato.Checked || Rb_JogosFora_Brasil.Checked || Rb_JogosCasa_BR.Checked)
            {
                Font fontdocE = new("Consolas", 18, FontStyle.Bold, GraphicsUnit.Point);
                string tituloAnalisesE = "ESTATISTICA";
                Brush pincelTituloE = new SolidBrush(Color.Black);
                Rectangle areaTituloE = new(x, y, largura - 50, 50);
                StringFormat formatoTituloE = new()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                //Adcionaodo o titulo das estatisticas
                e.Graphics.DrawString(tituloAnalisesE, fontdocE, pincelTituloE, areaTituloE, formatoTituloE);
                y += 50;

                //Adcionaod os dados das estatisticas para o documento
                foreach (Control controles in PanelBra.Controls)
                {
                    if (controles.Text != string.Empty)
                    {
                        e.Graphics.DrawString(controles.Text.ToUpper(), letra, pincel, new Point(x, y));
                        y += 25;
                    }

                    //if (y >= altura - 50)
                    //{
                    //    y = 50;
                    //    e.HasMorePages = true;
                    //    break;
                    //}
                }
            }

            #endregion

        }

        private void Rb_Estatisticas_Capeonato_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Rb_Estatisticas_Capeonato.Checked)
                {
                    foreach (Control c in PanelBra.Controls)
                    {
                        c.Text = string.Empty;
                    }

                    brasil.EstatisticaCompeticao(Lbl_Total_Gol_Casa, Lbl_MediaGol_Casa, Lbl_Total_Gol_Fora,
                                                Lbl_Media_Gol_Fora, Lbl_Gol_Ht_Casa, Lbl_Media_Ht_Casa,
                                                Lbl_Gol_Ht_Fora, Lbl_Media_Ht_Fora, Lbl_Media_Cantos_Casa,
                                                Lbl_Media_Cantos_Fora, Lbl_Media_Cantos_Ht_Casa,
                                                Lbl_Media_Cantos_Ht_Fora, Lbl_Vitoria_Casa, Lbl_Vitoria_Fora);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao buscar informações", "Aviso!" + err.Message);
            }
        }

        private void JogosComMaisDeTresCantosHt()
        {
            try
            {
                if (cbo_Equipes_Brasil.SelectedItem.ToString() != null && Rb_jogos_CantosHT.Checked)
                {
                    equipe = cbo_Equipes_Brasil.SelectedItem.ToString();
                    brasil.JogosMaisDeTresEscanteiosHt(equipe, dgvDados_Brasil);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma equipe para realizar a consulta dos dados...");
                return;
            }
        }

        private void JogosGolsHt()
        {
            try
            {
                if (cbo_Equipes_Brasil.SelectedItem.ToString() != null && Rb_golsHt.Checked)
                {
                    equipe = cbo_Equipes_Brasil.SelectedItem.ToString();
                    brasil.JogosGolsHt(equipe, dgvDados_Brasil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado, verifique se selecionou uma equipe." + ex.Message, "Aviso"); ;
            }
        }

        //Comando usado para associar tecla de atalhos
        protected override bool ProcessCmdKey(ref Message msgb, Keys tecla)
        {
            switch (tecla)
            {
                case Keys.Escape:
                    MessageBox.Show("Encerrando a Aplicação, até breve...");
                    Application.Exit();
                    break;
                case Keys.F11:
                    JogosComMaisDeTresCantosHt();
                    break;
                case Keys.F4:
                    JogosGolsHt();
                    break;
                case Keys.P:
                    Imprimir();
                    break;
            }
            return base.IsInputKey(tecla);
        }

        //private void Btn_Pdf_Click(object sender, EventArgs e)
        //{
        //    CreatePDF pdf = new();

        //    pdf.CreateDocumentPDF();
        //}

        public void LimparControles()
        {
            foreach (Control c in PanelBra.Controls) { c.Text = string.Empty; };
        }

    }//Fim Class
}//Fim NameSpace
