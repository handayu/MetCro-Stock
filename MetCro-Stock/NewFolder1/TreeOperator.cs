using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCro_Stock
{
    public class BaseInfo
    {
        public int levle
        {
            get;
            set;
        }

        public BaseInfo parent
        {
            get;
            set;
        }

        public int self
        {
            get;
            set;
        }

        public int chird1
        {
            get;
            set;
        }

        public int chird2
        {
            get;
            set;
        }

        public string key
        {
            get;
            set;
        }
    }


    public  class TreeOperator
    {
        private Dictionary<string, BaseInfo> m_dicInfos = new Dictionary<string, BaseInfo>();


        public Dictionary<string, BaseInfo> DicInfos
        {
            get
            {
                return m_dicInfos;
            }
        }

        public  void addList(BaseInfo parent, int self, int levle,int limitLevel)
        {
            try
            {
                if (levle == limitLevel) return;

                if (levle == 0)
                {
                    BaseInfo info = new BaseInfo();
                    info.levle = 0;
                    info.parent = null;
                    info.self = self;
                    info.chird1 = self + 10;
                    info.chird2 = self - 10;
                    string ekey = System.Guid.NewGuid().ToString();
                    info.key = "0" + ":" + ekey;
                    m_dicInfos.Add(info.key, info);
                    addList(info, info.chird1, 1, limitLevel);
                    addList(info, info.chird2, 1, limitLevel);
                }
                else
                {
                    BaseInfo info = new BaseInfo();
                    info.levle = levle;
                    info.parent = parent;
                    info.self = self;
                    info.chird1 = self + 10;
                    info.chird2 = self - 10;
                    string ekey = System.Guid.NewGuid().ToString();
                    info.key = levle.ToString() + ":" + ekey;
                    m_dicInfos.Add(info.key, info);
                    addList(info, info.chird1, levle + 1, limitLevel);
                    addList(info, info.chird2, levle + 1, limitLevel);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
