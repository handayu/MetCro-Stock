using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetCro_Stock
{
    public class RealMarketData
    {
        public double Open
        {
            get;
            set;
        }

        public double High
        {
            get;
            set;
        }

        public double Low
        {
            get;
            set;
        }

        public double Close
        {
            get;
            set;
        }

        public double Highest
        {
            get;
            set;
        }

        public double Lowest
        {
            get;
            set;
        }
    }


    public class TxtHolder
    {
        private static string m_debugPath = System.IO.Directory.GetCurrentDirectory() + @"\data";


        //读取所有交易信息
        public static List<string> ReadTxt(string name)
        {
            List<string> tSingleInfo = new List<string>();

            string path = m_debugPath + "\\" + name;

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

        /// <summary>
        /// 把读取的所有信息先转化成标准平台类格式
        /// </summary>
        /// <param name="tradingList"></param>
        /// <returns></returns>
        public static List<RealMarketData> TransToStandardInfoList(List<string> allTradingList)
        {
            List<string> tradeList = new List<string>();

            List<string> allTradingCloneList = new List<string>();
            foreach (string s in allTradingList)
            {
                allTradingCloneList.Add(s);
            }

            List<RealMarketData> standardTradingList = new List<RealMarketData>();

            for (int i = 0; i < allTradingCloneList.Count; i++)
            {
                List<string> strArray = allTradingCloneList[i].Split(',').ToList();
                List<string> newStrArray = new List<string>();
                foreach (string s in strArray)
                {
                    if (s.CompareTo("") != 0)
                    {
                        newStrArray.Add(s);
                    }
                }

                RealMarketData standardTradeInfo = new RealMarketData();

                double high = double.MinValue;
                double.TryParse(newStrArray[0].Trim(' '), out high);
                standardTradeInfo.High = high;

                double low = double.MinValue;
                double.TryParse(newStrArray[1].Trim(' '), out low);
                standardTradeInfo.Low = low;

                double open = double.MinValue;
                double.TryParse(newStrArray[2].Trim(' '), out open);
                standardTradeInfo.Open = open;

                double close = double.MinValue;
                double.TryParse(newStrArray[3].Trim(' '), out close);
                standardTradeInfo.Close = close;

                double highest = double.MinValue;
                double.TryParse(newStrArray[4].Trim(' '), out highest);
                standardTradeInfo.Highest= highest;

                double lowest = double.MinValue;
                double.TryParse(newStrArray[5].Trim(' '), out lowest);
                standardTradeInfo.Lowest = lowest;

                standardTradingList.Add(standardTradeInfo);
            }
            return standardTradingList;
        }

        public static List<string> HoldInstruments()
        {
            //上面现在给的是一个文件夹的路径@"X:\xxx\xxx"，搜索文件夹下路径的所有.txt文件导入-策略文件
            string[] files = Directory.GetFiles(m_debugPath, "*.txt");
            return files.ToList();
        }
    }
}
