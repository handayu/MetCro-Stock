using NPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetCro_Stock
{
    public partial class FormRealKLine : Form
    {
        private List<RealMarketData> m_RealDataList = new List<RealMarketData>();
        private int m_nowIndex = -1;

        public FormRealKLine(List<RealMarketData> realData)
        {
            InitializeComponent();

            m_RealDataList = realData;
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        public Timer Clock
        {
            get
            {
                return this.timer1;
            }
        }

        /// <summary>
        /// 清空图表数据
        /// </summary>
        public void ClearData()
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();


            m_nowIndex = -1;
        }

        /// <summary>
        /// 更新数据缓存
        /// </summary>
        /// <param name="realData"></param>
        public void Updata(List<RealMarketData> realData)
        {
            m_RealDataList = realData;

            m_nowIndex = -1;
        }

        /// <summary>
        /// 在这里加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ticker_Event(object sender, EventArgs e)
        {
            //按照List的顺序加载整个数据
            //按照 高-低-开-收 加入进去的
            //this.chart1.Series[0].Points.AddXY(0, 80, 70, 70 ,80);
            //this.chart1.Series[0].Points.AddXY(1, 70, 60, 60, 70);
            //this.chart1.Series[0].Points.AddXY(2, 60, 50, 50, 60);
            //this.chart1.Series[0].Points.AddXY(3, 50, 40, 40, 50);
            //this.chart1.Series[0].Points.AddXY(4, 40, 30, 30, 40);
            //this.chart1.Series[0].Points.AddXY(5, 30, 20, 20, 30);
            //this.chart1.Series[0].Points.AddXY(6, 20, 10, 10, 20);
            //this.chart1.Series[0].Points.AddXY(7, 30, 20, 20, 30);
            if (m_nowIndex == this.m_RealDataList.Count - 1) return;

            m_nowIndex = m_nowIndex + 1;

            this.chart1.Series[0].Points.AddXY(m_nowIndex,
                m_RealDataList[m_nowIndex].High, m_RealDataList[m_nowIndex].Low,
                m_RealDataList[m_nowIndex].Open, m_RealDataList[m_nowIndex].Close);

            //this.chart1.Series[1].Points.AddXY(m_nowIndex,
            //   m_RealDataList[m_nowIndex].Highest);

            //this.chart1.Series[2].Points.AddXY(m_nowIndex,
            //   m_RealDataList[m_nowIndex].Lowest);

            Debug.WriteLine(this.Clock.Interval.ToString());
        }

        /// <summary>
        /// 往前一根
        /// </summary>
        public void GoAheadOneLine()
        {
            if (m_nowIndex == this.m_RealDataList.Count - 1) return;

            m_nowIndex = m_nowIndex + 1;

            this.chart1.Series[0].Points.AddXY(m_nowIndex,
                m_RealDataList[m_nowIndex].High, m_RealDataList[m_nowIndex].Low,
                m_RealDataList[m_nowIndex].Open, m_RealDataList[m_nowIndex].Close);

            this.chart1.Series[1].Points.AddXY(m_nowIndex,
               m_RealDataList[m_nowIndex].Highest);

            this.chart1.Series[2].Points.AddXY(m_nowIndex,
               m_RealDataList[m_nowIndex].Lowest);

        }

        /// <summary>
        /// 往后一根
        /// </summary>
        public void GoBackOneLine()
        {
            //在现在的基础上把现在的一根删除，同时把m_index减掉一个 
            if(m_nowIndex >= 0)
            {
                this.chart1.Series[0].Points.RemoveAt(m_nowIndex);
                this.chart1.Series[1].Points.RemoveAt(m_nowIndex);
                this.chart1.Series[2].Points.RemoveAt(m_nowIndex);

                m_nowIndex = m_nowIndex - 1;
            }
            
        }

    }
}
