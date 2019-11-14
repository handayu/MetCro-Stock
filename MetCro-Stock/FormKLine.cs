using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetCro_Stock
{
    public partial class FormKLine : Form
    {
        public FormKLine(List<int> firstPriceProbilityList,Color col)
        {
            InitializeComponent();

            for(int i = 0;i< firstPriceProbilityList.Count - 1;i++)
            {
                this.chart1.Series[0].Points.AddXY(0, firstPriceProbilityList[i], firstPriceProbilityList[i] - 10, firstPriceProbilityList[i] - 10, firstPriceProbilityList[i]);

            }

            //按照 高-低-开-收 加入进去的

            //this.chart1.Series[0].Points.AddXY(0, 80, 70, 70 ,80);
            //this.chart1.Series[0].Points.AddXY(1, 70, 60, 60, 70);
            //this.chart1.Series[0].Points.AddXY(2, 60, 50, 50, 60);
            //this.chart1.Series[0].Points.AddXY(3, 50, 40, 40, 50);
            //this.chart1.Series[0].Points.AddXY(4, 40, 30, 30, 40);
            //this.chart1.Series[0].Points.AddXY(5, 30, 20, 20, 30);
            //this.chart1.Series[0].Points.AddXY(6, 20, 10, 10, 20);
            //this.chart1.Series[0].Points.AddXY(7, 30, 20, 20, 30);

            this.chart1.BackColor = col;

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
