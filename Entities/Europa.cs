using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoLinq.Entities
{
    public class Europa
    {
        #region Campos Da Class
        public string Liga { get; set; }
        public DateTime Data { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public int GolHome { get; set; }
        public int GolAway { get; set; }
        public int TotalGols { get; set; } 
        public string Result { get; set; }
        public int GolHomeHT { get; set; }
        public int GolAwayHT { get; set; }
        public string ResultHT { get; set; }
        public int CantosH { get; set; }
        public int CantosA { get; set; }
        public int TotalEscanteios { get; set; }
        public int CardAmareloHome { get; set; }
        public int CardAmareloAway { get; set; }
        public int CardRedHome { get; set; }
        public int CardRedAway { get; set; }
        public int TotalGolHT { get; set; }
        public int TotalCartao  { get; set; }

        #endregion

        //Contrutor Padrão
        public Europa() { }

        #region Construtor com argumentos
        public Europa(string liga, DateTime data, string home, string away, int golHome, int golAway, int gols, string result, int golHomeHT, int golAwayHT, string resultHT, int cantosH, int cantosA, int totalEscanteios, int cardAmareloHome, int cardAmareloAway, int cardRedHome, int cardRedAway,int totalCartao, int totalGolHT)
        {
            Liga = liga;
            Data = data;
            Home = home;
            Away = away;
            GolHome = golHome;
            GolAway = golAway;
            TotalGols = gols;
            Result = result;
            GolHomeHT = golHomeHT;
            GolAwayHT = golAwayHT;
            ResultHT = resultHT;
            CantosH = cantosH;
            CantosA = cantosA;
            TotalEscanteios = totalEscanteios;
            CardAmareloHome = cardAmareloHome;
            CardAmareloAway = cardAmareloAway;
            CardRedHome = cardRedHome;
            CardRedAway = cardRedAway;
            TotalCartao = totalCartao;
            TotalGolHT = totalGolHT;
        }
        #endregion

        public void LerdadosEuropa(List<Europa> europa)
        {
            string path_dinamica = Application.StartupPath + @"Files\Europa.csv";

            using StreamReader str = File.OpenText(path_dinamica);
                while (!str.EndOfStream)
                {
                    string[] file = str.ReadLine().Split(',');
                    string liga = file[1];
                    DateTime data = Convert.ToDateTime(file[2].ToString()).Date;
                    string home = file[3];
                    string away = file[4];
                    int golHome = Convert.ToInt32(file[5]);
                    int golAway = Convert.ToInt32(file[6]);
                    int gols = Convert.ToInt32(file[7]);
                    string result = file[8];
                    int golHomeHT = Convert.ToInt32(file[9]); 
                    int golAwayHT = Convert.ToInt32(file[10]);
                    string resulHt = file[11];
                    int cantosH = Convert.ToInt32(file[12]);
                    int cantosA = Convert.ToInt32(file[13]);
                    int escanteios = Convert.ToInt32(file[14]);
                    int cardAnareloH = Convert.ToInt32(file[15]); 
                    int cardAmareloA = Convert.ToInt32(file[16]); 
                    int cardRedHome = Convert.ToInt32(file[17]);
                    int cardRedAway = Convert.ToInt32(file[18]);
                    int totalGolHT = Convert.ToInt32(file[19]);
                    int totalCartao = Convert.ToInt32(file[20]);
                    europa.Add(new Europa(liga, data, home, away, golHome, golAway, gols,result,golHomeHT,golAwayHT,resulHt
                                          ,cantosH,cantosA,escanteios,CardAmareloHome
                                          ,cardAmareloA,cardRedHome,cardRedAway,totalGolHT,totalCartao));
                }

        }

        public void AdcionarEquipesEuropaNaCombobox(ComboBox cbo)
        {
            List<Europa> dados = new();
            LerdadosEuropa(dados);

            SortedSet<string> ligas = new();
            dados.ForEach(e => ligas.Add(e.Liga));

            cbo.Items.Clear();
            foreach (var item in ligas)
            {
                cbo.Items.Add(item);
            };

        }
    }
}
