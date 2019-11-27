using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetCro_Stock
{
    public class KallyValue
    {
        public double Shares
        {
            get;
            set;
        }

        public double WinPercent
        {
            get;
            set;
        }

        public double PLValue
        {
            get;
            set;
        }

        public double Quality
        {
            get;
            set;
        }
    }

    public class RealTrading
    {
        public string StartTrade
        {
            get;
            set;
        }

        public string EndTrade
        {
            get;
            set;
        }

        public double OpenShares
        {
            get;
            set;
        }

        public double PLMoney
        {
            get;
            set;
        }
    }

}
