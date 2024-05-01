namespace UsandoLinq.Entities
{
    public class Brasileirao
    {
        /*
        Colunas Da Tabela
        Season     DATA	    Home	    Away	    GolHome	    golAway	Resultado
        totalgol	EHome	    Eaway	    TotalE	    EHTHome
        EHTAway	TotalEHT	CartaoHome	CartaoAway
        TotalC	    GolHTHome	GolHTAway	TotalGolHT
      */
        #region Campos Da Class
        public int Season { get; set; }
        public DateTime Data { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public int GolHome { get; set; }
        public int GolAway { get; set; }
        public string Result { get; set; }
        public int Gols { get; set; }
        public int CantosH { get; set; }
        public int CantosA { get; set; }
        public int Escanteios { get; set; }
        public int EHomeHt { get; set; }
        public int EAwayHT { get; set; }
        public int EscanteiosHT { get; set; }
        public int CartaoH { get; set; }
        public int CartaoA { get; set; }
        public int TotalCartao { get; set; }
        public int GolHomeHT { get; set; }
        public int GolAwayHT { get; set; }
        public int TotalGolHT { get; set; }
        #endregion

        public Brasileirao() { }

        #region Construtor com Argumentos
        public Brasileirao(int season, DateTime data, string home, string away, int golHome, int golAway, string result, int gols, int cantosH, int cantosA, int escanteios, int eHomeHt, int eAwayHT, int escanteiosHT, int cartaoH, int cartaoA, int totalCartao, int golHomeHT, int golAwayHT, int totalGolHT)
        {
            Season = season;
            Data = data;
            Home = home;
            Away = away;
            GolHome = golHome;
            GolAway = golAway;
            Result = result;
            Gols = gols;
            CantosH = cantosH;
            CantosA = cantosA;
            Escanteios = escanteios;
            EHomeHt = eHomeHt;
            EAwayHT = eAwayHT;
            EscanteiosHT = escanteiosHT;
            CartaoH = cartaoH;
            CartaoA = cartaoA;
            TotalCartao = totalCartao;
            GolHomeHT = golHomeHT;
            GolAwayHT = golAwayHT;
            TotalGolHT = totalGolHT;
        }
        #endregion

        public void LerDadosBrasil(List<Brasileirao> brasileirao)
        {
            string path_Dinamica = Application.StartupPath + @"Files\Brasil.csv";

            using StreamReader sr = File.OpenText(path_Dinamica);
            while (!sr.EndOfStream)
            {
                string[] file = sr.ReadLine().Split(',');
                int season = Convert.ToInt32(file[0]);
                DateTime data = Convert.ToDateTime(file[1].ToString()).Date;
                string home = file[2];
                string away = file[3];
                int golHome = Convert.ToInt32(file[4]);
                int golAway = Convert.ToInt32(file[5]);
                string result = file[6];
                int gols = Convert.ToInt32(file[7]);
                int cantosH = Convert.ToInt32(file[8]);
                int cantosA = Convert.ToInt32(file[9]);
                int escanteios = Convert.ToInt32(file[10]); ;
                int eHomeHt = Convert.ToInt32(file[11]); ;
                int eAwayHT = Convert.ToInt32(file[12]); ;
                int escanteiosHT = Convert.ToInt32(file[13]); ;
                int cartaoH = Convert.ToInt32(file[14]); ;
                int cartaoA = Convert.ToInt32(file[15]); ;
                int totalCartao = Convert.ToInt32(file[16]); ;
                int golHomeHT = Convert.ToInt32(file[17]); ;
                int golAwayHT = Convert.ToInt32(file[18]); ;
                int totalGolHT = Convert.ToInt32(file[19]); ;
                brasileirao.Add(new Brasileirao(season, data, home, away, golHome, golAway, result,
                       gols, cantosH, cantosA, escanteios, eHomeHt, eAwayHT, escanteiosHT, cartaoH, cartaoA, totalCartao, golHomeHT, golAwayHT, totalGolHT));
            }

        }

        public void AdcionarEquipesCombobox(ComboBox cbo)
        {
            List<Brasileirao> Jogos = new();
            LerDadosBrasil(Jogos);

            SortedSet<string> equipes = new();
            Jogos.ForEach(e => equipes.Add(e.Home));

            cbo.Items.Clear();
            foreach (var e in equipes)
            {
                cbo.Items.Add(e);
            }
        }

        public void JogosCasa(DataGridView dgv, string equipe)
        {
            List<Brasileirao> Jogos = new();
            LerDadosBrasil(Jogos);

            int ano = DateTime.Now.Year - 1;
            var jogoscasa = Jogos.Where(j => j.Home == equipe && j.Season == ano)
                .Select
                (j => new
                {
                    j.Data,
                    j.Home,
                    j.GolHome,
                    j.GolAway,
                    j.Away,
                    j.Gols
                })
                .OrderByDescending(j => j.Data)
                .ToArray();
            dgv.DataSource = jogoscasa;
        }

        public void JogosFora(DataGridView dgv, string equipe)
        {
            List<Brasileirao> Jogos = new();
            LerDadosBrasil(Jogos);

            int ano = DateTime.Now.Year - 1;
            var jogosfora = Jogos.Where(j => j.Away == equipe && j.Data.Year == ano)
                .Select
                (j => new
                {
                    j.Data,
                    j.Home,
                    j.GolHome,
                    j.GolAway,
                    j.Away,
                    j.Gols
                })
                .OrderByDescending(j => j.Data)
                .ToArray();
            dgv.DataSource = jogosfora;
        }

        public void EstatisticaEquipe(string equipe, params Label[] label)
        {
            List<Brasileirao> Jogos = new();
            LerDadosBrasil(Jogos);

            //Total de gols em casa
            var T_GolsCasa = (from j in Jogos where j.Home == equipe select j.GolHome).Sum();
            label[0].Text = $"{equipe} Marcou {T_GolsCasa} gols em casa";

            //Média gols em casa
            var M_golsCasa = (from j in Jogos where j.Home == equipe select j.GolHome).Average();
            label[1].Text = $"Média de {Math.Round(M_golsCasa, 2)} gols jogando em casa";

            //Total Gols Fora
            var T_GolsFora = (from j in Jogos where j.Away == equipe select j.GolAway).Sum();
            label[2].Text = $"Marcou {T_GolsFora} gols Como visitante";

            //Media de gols Fora
            var M_golsFora = (from j in Jogos where j.Away == equipe select j.GolAway).Average();
            label[3].Text = $"Média de {Math.Round(M_golsFora, 2)} gols fora";

            //Total gos Ht Casa
            var T_GolsHtCasa = (from j in Jogos where j.Home == equipe select j.GolHomeHT).Sum();
            label[4].Text = $"Marcou {T_GolsHtCasa} gols HT jogando em casa";

            //Media Gols HT Casa
            var M_golsHtCasa = (from j in Jogos where j.Home == equipe select j.GolHomeHT).Average();
            label[5].Text = $"Média de {Math.Round(M_golsHtCasa, 2)} gols no HT em casa";

            //Total Gols HT Como Visitante
            var T_GolsHtVisitante = (from j in Jogos where j.Away == equipe select j.GolAwayHT).Sum();
            label[6].Text = $"Marcou {T_GolsHtVisitante} Gols HT como visitante";

            //Media de gols no Ht Como Visitante
            var M_GolsHtFora = (from j in Jogos where j.Away == equipe select j.GolAwayHT).Average();
            label[7].Text = $"Média de {Math.Round(M_GolsHtFora, 2)} gols no HT como visitante";

            //Media de Escanteios Jogando em Casa
            var M_EscanteiosCasa = (from j in Jogos where j.Home == equipe select j.CantosH).Average();
            label[8].Text = $"Média de {Math.Round(M_EscanteiosCasa, 2)} escanteios em casa";

            //Media de Escanteios Como Visitante
            var M_EscanteiosFora = (from j in Jogos where j.Away == equipe select j.CantosA).Average();
            label[9].Text = $"Média de {Math.Round(M_EscanteiosFora, 2)} escanteios como visitante";

            //Media de escanteios no HT em casa
            var M_EscanteiosHtCasa = (from j in Jogos where j.Home == equipe select j.EHomeHt).Average();
            label[10].Text = $"Média de {Math.Round(M_EscanteiosHtCasa, 2)} escanteios no HT em casa";

            //Media de escanteios no HT como Visitante
            var M_EscanteiosHtFora = (from j in Jogos where j.Away == equipe select j.EAwayHT).Average();
            label[11].Text = $"Média de {Math.Round(M_EscanteiosHtFora, 2)} escanteios HT como visitante";

            //Total de vitoria em casa
            var T_VitoriaCasa = (from j in Jogos where j.Home == equipe && j.Result == "H" select j.Result).Count();
            label[12].Text = $"{T_VitoriaCasa} vitória como mandante";

            //Total de vitoria como visitante
            var T_VitoriaFora = (from j in Jogos where j.Away == equipe && j.Result == "A" select j.Result).Count();
            label[13].Text = $"{T_VitoriaFora} vitória como visitante";

            //Calcula total geral de vitória na competição
            int T_totalVitoriGeral = T_VitoriaFora + T_VitoriaCasa;
            label[14].Text = $"{equipe} tem um total de {T_totalVitoriGeral} vitória";


            //Total cartao e sua média
            var T_cartaoCasa = (from j in Jogos where j.Home == equipe select j.CartaoH).Sum();
            var T_cartaoFora = (from j in Jogos where j.Away == equipe select j.CartaoA).Sum();
            var M_cartaoCasa = (from j in Jogos where j.Home == equipe select j.CartaoH).Average();
            var M_cartaoFora = (from j in Jogos where j.Away == equipe select j.CartaoA).Average();

            double Media_Cartao = Math.Round((M_cartaoCasa + M_cartaoFora), 2);
            int Total_Cartao = T_cartaoCasa + T_cartaoFora;
            label[15].Text = $"{Total_Cartao} Cartão recebido na competição";
            label[16].Text = $"Uma média de {Media_Cartao} cartão por partida";

            //Calculando o total de derrota na competição
            var T_derrotaCasa = (from j in Jogos where j.Home == equipe && j.Result == "A" select j.Result).Count();
            var T_derroFora = (from j in Jogos where j.Away == equipe && j.Result == "H" select j.Result).Count();
            label[17].Text = $"Obtendo {(int)T_derroFora + T_derrotaCasa} derrota";

            //Calculando total de Empate
            var T_empate_Casa = (from j in Jogos where j.Home == equipe && j.Result == "D" select j.Result).Count();
            var T_empate_Fora = (from j in Jogos where j.Away == equipe && j.Result == "D" select j.Result).Count();
            label[18].Text = $"Obteve um total de {T_empate_Casa + T_empate_Fora} empate";

        }

        public void EstatisticaCompeticao(params Label[] label)
        {
            List<Brasileirao> jogos = new();
            LerDadosBrasil(jogos);
            int ano = DateTime.Now.Year - 1;

            //calculando o total de gols da temporada atual
            var totalGolsNacompeticao = (from j in jogos where j.Data.Year == ano select j.Gols).Sum();
            //int result1 = totalGolsNacompeticao;
            label[0].Text = $"Já foram marcados {totalGolsNacompeticao} gols na temporada atual";

            //Média de gols da competicao
            var mediaGolsNacompeticao = (from j in jogos where j.Data.Year == ano select j.Gols).Average();
            label[1].Text = $"Temos uma média de {Math.Round(mediaGolsNacompeticao, 2)} gols por partida";

            //Média de gols no HT e total de gols
            var mediaGolsHT = (from j in jogos where j.Data.Year == ano select j.TotalGolHT).Average();
            var totalGolsHT = (from j in jogos where j.Data.Year == ano select j.TotalGolHT).Sum();
            label[2].Text = $"Tivemos {totalGolsHT} gols no HT";
            label[3].Text = $"Uma média de {Math.Round(mediaGolsHT, 2)}";

            //Média de escanteios geral e no HT
            var mediaEscanteioGeral = (from j in jogos
                                       where j.Data.Year == ano
                                       select j.Escanteios).AsQueryable().Average();
            var mediaEscanteiosHT = (from j in jogos where j.Data.Year == ano select j.EscanteiosHT).Average();
            label[4].Text = $"Temos uma média de {Math.Round(mediaEscanteioGeral, 2)} escanteios por partidas";
            label[5].Text = $"No ht temos um média de {Math.Round(mediaEscanteiosHT, 2)} escanteios por partidas";

            //Total de cartaos e média
            var mediaGeralcartao = (from j in jogos where j.Data.Year == ano select j.TotalCartao).Average();
            var T_cartaogeral = (from j in jogos where j.Data.Year == ano select j.TotalCartao).Sum();
            label[6].Text = $"Temos um total de {T_cartaogeral} cartões na competição";
            label[7].Text = $"Com uma média de {Math.Round(mediaGeralcartao, 2)} cartão por partidas";

            //Totais de vitorias da casa e visitante
            var T_vitoriaGeralCasa = (from j in jogos where j.Data.Year == ano && j.Result == "H" select j.Result).Count();
            var T_vitoriaGeralFora = (from j in jogos where j.Data.Year == ano && j.Result == "A" select j.Result).Count();
            var T_empatesGeral = (from j in jogos where j.Data.Year == ano && j.Result == "D" select j.Result).Count();
            var TotalJogos = (from j in jogos where j.Data.Year == ano select j.Data).Count();

            label[8].Text = $"Das equipes mandantes tivemos {T_vitoriaGeralCasa} vitória";
            label[9].Text = $"Foram {T_vitoriaGeralFora} vitória das equipes com visitantes";
            label[10].Text = $"Tivemos {T_empatesGeral} partidas com empates";

            //Calculando as porcentagens de vitória e empates
            label[11].Text = $"{Math.Round((double)100 / TotalJogos * T_vitoriaGeralCasa, 2)}% dos jogos foram vencidos pelos mandantes";
            label[12].Text = $"{Math.Round((double)100 / TotalJogos * T_empatesGeral, 2)}% dos jogos foram vencidos pelos visitantes";
            label[13].Text = $"Apenas {Math.Round((double)100 / TotalJogos * T_vitoriaGeralFora, 2)}% das partidas terminaram empatadas";


        }

        public void JogosMaisDeTresEscanteiosHt(string equipe, DataGridView dgvG)
        {
            try
            {
                List<Brasileirao> jogos = new();
                LerDadosBrasil(jogos);
                int ano = DateTime.Now.Year - 1;

                var jogosComMaisdeTresEscanteioHt = jogos.Where(j => j.Home == equipe
                        && j.EscanteiosHT > 3 && j.Data.Year == ano
                        || j.Away == equipe && j.EscanteiosHT > 3 && j.Data.Year == ano)
                        .Select(j => new
                        {
                            j.Data,
                            j.Home,
                            j.EHomeHt,
                            j.EAwayHT,
                            j.Away,
                        }).OrderByDescending(j => j.Data).ToList();
                dgvG.DataSource = jogosComMaisdeTresEscanteioHt;
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Buscar informação", "Aviso!" + e.Message);
            }
        }

        public void JogosGolsHt(string equipe, DataGridView dgv)
        {
            List<Brasileirao> Jogos = new();
            LerDadosBrasil(Jogos);
            int ano = DateTime.Now.Year - 1;
            var result = Jogos.Where(j => j.Home == equipe && j.TotalGolHT > 0 &&
                                     j.Data.Year == ano || j.Away == equipe
                                     && j.TotalGolHT > 0 && j.Data.Year == ano)
                                    .Select(j => new
                                    {
                                        j.Data,
                                        j.Home,
                                        j.GolHomeHT,
                                        j.GolAwayHT,
                                        j.Away
                                    }).OrderByDescending(j => j.Data).ToArray();
            dgv.DataSource = result;
        }

        public void TodosJogosDaEquipe(string equipe, DataGridView dgv)
        {
            List<Brasileirao> todosJogos = new();
            LerDadosBrasil(todosJogos);
            int ano = DateTime.Now.Year - 1;

            var result = todosJogos.Where(j => j.Home == equipe && j.Data.Year == ano
                                   || j.Away == equipe && j.Data.Year == ano)
                                   .Select(j => new
                                   {
                                       j.Data,
                                       j.Home,
                                       j.GolHome,
                                       j.GolAway,
                                       j.Away,
                                   }
                                   ).OrderByDescending(j => j.Data).ToList();
            dgv.DataSource = result;
        }

        public void JogosSemMarcarGols(string equipe, DataGridView dgv)
        {
            List<Brasileirao> Jogos = new();
            LerDadosBrasil(Jogos);
            int ano = DateTime.Now.Year - 1;

            var result = Jogos.Where(j => j.Home == equipe && j.GolHome < 1
                                    || j.Away == equipe && j.GolAway < 1)
                                    .Select(j => new
                                    {
                                        j.Data,
                                        j.Home,
                                        j.GolHome,
                                        j.GolAway,
                                        j.Away
                                    }
                                    ).OrderByDescending(j => j.Data).ToList();
            dgv.DataSource = result;
        }


    }//Fim class
}//Fim NameSpace
