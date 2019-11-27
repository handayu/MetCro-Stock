using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetCro_Stock
{
    public partial class KallyForm : Form
    {
        private BindingList<KallyValue> m_kallyValues = new BindingList<KallyValue>();
        private BindingList<RealTrading> m_realTradeList = new BindingList<RealTrading>();

        public KallyForm()
        {
            InitializeComponent();

            this.dataGridView_MetaCro.DataSource = m_kallyValues;
            this.dataGridView_RealTrade.DataSource = m_realTradeList;

        }

        private void Button_SingleMecaro_Click(object sender, EventArgs e)
        {
            m_kallyValues.Clear();
            this.chart_KallyQuality.Series.Clear();
            this.chart_ShortTradingNumKally.Series.Clear();

            //
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_KallyQuality.Series.Add(series1);

            //

            KallyValue initValue = new KallyValue()
            {
                Shares = GetInitShares(),
                WinPercent = 0,
                PLValue = 0,
                Quality = GetInitQuality()
            };

            m_kallyValues.Add(initValue);

            //生成单次的100条数据
            for(int i = 0;i<1000;i++)
            {
                KallyValue nowKally = new KallyValue();

                int winLoss = 0;

                //生成一个基于胜率下的盈利还是亏损，然后和m_kally前一笔比较，生成新的一笔，加进去
                double winPer = GetInitWinPercent() * 100;//胜率节点比如胜率是30%
                //随机生成一个1-100的数，如果在1-30之间则是盈利，在30-100之间则是亏损

                double num = GetRandomNum();
                if (num >=1 && num <= winPer)
                {
                    winLoss = 1;
                }
                else
                {
                    winLoss = -1;
                }

                nowKally.WinPercent = winLoss;

                if (winLoss == 1 )
                {
                    nowKally.PLValue = m_kallyValues[m_kallyValues.Count - 1].Shares * GetSingleShareP();
                    nowKally.Quality = m_kallyValues[m_kallyValues.Count - 1].Quality + nowKally.PLValue;
                    double shares = Math.Ceiling(m_kallyValues[m_kallyValues.Count - 1].Quality/10000 * GetOpenSharesPercent());
                    nowKally.Shares = shares;             
                }
                else
                {
                    nowKally.PLValue = m_kallyValues[m_kallyValues.Count - 1].Shares * GetSingleShareL();
                    nowKally.Quality = m_kallyValues[m_kallyValues.Count - 1].Quality + nowKally.PLValue;
                    double shares = Math.Ceiling(m_kallyValues[m_kallyValues.Count - 1].Quality / 10000 * GetOpenSharesPercent());
                    nowKally.Shares = shares;
                }
                m_kallyValues.Add(nowKally);
            }

            for (int j = 0; j < m_kallyValues.Count; j++)
            {
                this.chart_KallyQuality.Series[0].Points.AddXY(j,m_kallyValues[j].Quality);
            }

            ///短期的加进去
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            this.chart_ShortTradingNumKally.Series.Add(series2);
            for (int j = 0; j < 50; j++)
            {
                this.chart_ShortTradingNumKally.Series[0].Points.AddXY(j, m_kallyValues[j].Quality);
            }

        }

        public int GetRandomNum()
        {
            int rNum = 0;

            for (int i = 0; i < 5; i++)
            {
                byte[] buffer = Guid.NewGuid().ToByteArray();
                int iSeed = BitConverter.ToInt32(buffer, 0);
                Random random = new Random(iSeed);
                rNum = random.Next(1,101);
                break;
            }

            return rNum;
        }

        private void Button_SeriesKallyCaro_Click(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.BeginInvoke(new Action<object, EventArgs>(Button_SeriesKallyCaro_Click), sender, e);
                return;
            }


            m_kallyValues.Clear();

            this.chart_KallyQuality.Series.Clear();
            this.chart_ShortTradingNumKally.Series.Clear();


            for (int p = 0;p<10;p++)
            {
                m_kallyValues.Clear();

                KallyValue initValue = new KallyValue()
                {
                    Shares = GetInitShares(),
                    WinPercent = 0,
                    PLValue = 0,
                    Quality = GetInitQuality()
                };

                m_kallyValues.Add(initValue);

                //生成单次的100条数据
                for (int i = 0; i < 1000; i++)
                {
                    KallyValue nowKally = new KallyValue();

                    int winLoss = 0;

                    //生成一个基于胜率下的盈利还是亏损，然后和m_kally前一笔比较，生成新的一笔，加进去
                    double winPer = GetInitWinPercent() * 100;//胜率节点比如胜率是30%
                                                              //随机生成一个1-100的数，如果在1-30之间则是盈利，在30-100之间则是亏损

                    double num = GetRandomNum();
                    if (num >= 1 && num <= winPer)
                    {
                        winLoss = 1;
                    }
                    else
                    {
                        winLoss = -1;
                    }

                    nowKally.WinPercent = winLoss;

                    if (winLoss == 1)
                    {
                        nowKally.PLValue = m_kallyValues[m_kallyValues.Count - 1].Shares * GetSingleShareP();
                        nowKally.Quality = m_kallyValues[m_kallyValues.Count - 1].Quality + nowKally.PLValue;
                        double shares = Math.Ceiling(m_kallyValues[m_kallyValues.Count - 1].Quality / 10000 * GetOpenSharesPercent());
                        nowKally.Shares = shares;
                    }
                    else
                    {
                        nowKally.PLValue = m_kallyValues[m_kallyValues.Count - 1].Shares * GetSingleShareL();
                        nowKally.Quality = m_kallyValues[m_kallyValues.Count - 1].Quality + nowKally.PLValue;
                        double shares = Math.Ceiling(m_kallyValues[m_kallyValues.Count - 1].Quality / 10000 * GetOpenSharesPercent());
                        nowKally.Shares = shares;
                    }
                    m_kallyValues.Add(nowKally);
                }

                //长期的加进去
                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series1.Name = "Series:" + p.ToString();
                this.chart_KallyQuality.Series.Add(series1);

                for (int j = 0; j < m_kallyValues.Count; j++)
                {
                    series1.Points.AddXY(j, m_kallyValues[j].Quality);
                }

                ///短期的加进去
                System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series2.ChartArea = "ChartArea1";
                series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series2.Name = "Series:" + p.ToString();
                this.chart_ShortTradingNumKally.Series.Add(series2);

                for (int j = 0; j < 50; j++)
                {
                    series2.Points.AddXY(j, m_kallyValues[j].Quality);
                }
            }
        }

        private double GetInitShares()
        {
            double i = 0;
            double.TryParse(this.textBox_InitShares.Text, out i);
            return i;
        }

        private double GetOpenSharesPercent()
        {
            double i = 0;
            double.TryParse(this.textBox_OpenSharesPer.Text, out i);
            return i;
        }

        private double GetInitQuality()
        {
            double i = 0;
            double.TryParse(this.textBox_InitQuality.Text, out i);
            return i;
        }

        private double GetInitWinPercent()
        {
            double i = 0;
            double.TryParse(this.textBox_WinPer.Text, out i);
            return i;
        }

        private double GetSingleShareP()
        {
            double i = 0;
            double.TryParse(this.textBox_singleProfir.Text, out i);
            return i;
        }

        private double GetSingleShareL()
        {
            double i = 0;
            double.TryParse(this.textBox_SingleLoss.Text, out i);
            return i;
        }

        private double GetAddShares()
        {
            double i = 0;
            double.TryParse(this.textBox1_HighAddShares.Text, out i);
            return i;
        }

        private double GetDicelieShares()
        {
            double i = 0;
            double.TryParse(this.textBox1_LowDownShares.Text, out i);
            return i;
        }

        private void Button_Auto_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void Ticker(object sender, EventArgs e)
        {
            Button_SeriesKallyCaro_Click(null, null);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //找txt生成笔数对象
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\" + "realtrade.txt";

            List<string> tradeListStrList = ReadTxt(path);

            foreach(string str in tradeListStrList)
            {
                string[] arrayList = str.Split(' ');
                RealTrading realtrade = new RealTrading();

                List<string> newList = new List<string>();
                for (int p = 0;p<arrayList.Length;p++)
                {
                    if (arrayList[p] == "") continue;
                    newList.Add(arrayList[p]);
                }


                    realtrade.StartTrade = newList[0].Trim();
                    realtrade.EndTrade = newList[1].Trim();

                    double openshare = 0.00;
                    double.TryParse(newList[2].Trim(), out openshare);
                    realtrade.OpenShares = openshare;

                    double plMoney = 0.00;
                    double.TryParse(newList[3].Trim(), out plMoney);
                    realtrade.PLMoney = plMoney;
                    m_realTradeList.Add(realtrade);
                

            }

            double netQUality = 0.00;
            //加入图表
            for (int j = 0; j < m_realTradeList.Count; j++)
            {
               netQUality = netQUality + m_realTradeList[j].PLMoney;               
               this.chart_RealTrade.Series[0].Points.AddXY(j, netQUality);
            }

            //计算
            this.label_TradeNum.Text = m_realTradeList.Count.ToString();

            double win = 0;
            double los = 0;

            double allWin = 0.00;
            double allLos = 0.00;

            for(int i = 0;i<m_realTradeList.Count;i++)
            {
                if(m_realTradeList[i].PLMoney > 0)
                {
                    win = win + 1;
                    allWin = allWin + m_realTradeList[i].PLMoney;
                }
                else
                {
                    los = los + 1;
                    allLos = allLos + System.Math.Abs(m_realTradeList[i].PLMoney);

                }
            }

            if(win + los != 0)
            this.label_WinPercent.Text = (win / (win + los)).ToString("0.00");

            if (allWin + allLos != 0)
                this.label_PL.Text = (allWin / allLos).ToString("0.00");

            this.label_Ev.Text = ((win / (win + los)) * (allWin / allLos) - (los / (win + los)) * 1).ToString("0.0000");

        }


        //读取所有交易信息
        public static List<string> ReadTxt(string path)
        {
            List<string> tSingleInfo = new List<string>();

            //设置文件共享方式为读写，FileShare.ReadWrite，这样的话，就可以打开了
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                tSingleInfo.Add(line.ToString());
            }

            return tSingleInfo;
        }


    }
}
