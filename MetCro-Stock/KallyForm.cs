using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public KallyForm()
        {
            InitializeComponent();

            this.dataGridView_MetaCro.DataSource = m_kallyValues;
        }

        private void Button_SingleMecaro_Click(object sender, EventArgs e)
        {
            m_kallyValues.Clear();
            this.chart_KallyQuality.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_KallyQuality.Series.Add(series1);

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
            m_kallyValues.Clear();
            this.chart_KallyQuality.Series.Clear();

            for(int p = 0;p<10;p++)
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

                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series1.Name = "Series:" + p.ToString();
                this.chart_KallyQuality.Series.Add(series1);

                for (int j = 0; j < m_kallyValues.Count; j++)
                {
                    series1.Points.AddXY(j, m_kallyValues[j].Quality);
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

    }
}
