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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, List<int>> m_wholeLines = new Dictionary<int, List<int>>();


        private void ToolStripButton_Layout_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ToolStripButton_Start_Click(object sender, EventArgs e)
        {
            int iNum = 0;
            int.TryParse(this.toolStripTextBox_KNum.Text, out iNum);
            if(iNum == 0)
            {
                MessageBox.Show("请输入正确的模拟数量...");
                return;
            }

            //在这里生成所有情况的Kxian集合，然后传进K图-如果是1就有2个list,如果是2，就有4个list的情况依次...
            //如果是1：两种可能的行进1.80-90 2.80-70
            //如果是2: 四种可能的行进1.80-90-100 2.80-90-80 3.80-70-60 4.80-70-80
            //如果是3: 八种可能的行进1:80-90-100-110 ...
            //如果是往前去沙盘推演10步走势：共有简化的1024种走法
            TreeOperator op = new TreeOperator();
            op.addList(null, 80, 0,6);

            int iMun = 0;

            foreach (KeyValuePair<string, BaseInfo> kv in op.DicInfos)
            {
                //在这里找到的是第10层，最底层的数据，然后一直往上寻找父节点，直到为空
                if (kv.Value.levle == 5)
                {
                    List<int> wholeParentLineList = new List<int>();
                    wholeParentLineList.Add(kv.Value.self);


                    BaseInfo now = kv.Value;

                    while (now.parent != null)
                    {
                        wholeParentLineList.Add(now.parent.self);

                        now = now.parent;
                    }

                    wholeParentLineList.Reverse();

                    m_wholeLines.Add(iMun, wholeParentLineList);

                    iMun++;
                }
            }

            int iUnm = 0;

            foreach(KeyValuePair<int,List<int>> kv in m_wholeLines)
            {
                if(kv.Value[1] < kv.Value[0])
                {
                    FormKLine form = new FormKLine(kv.Value,Color.Gray);
                    form.TopLevel = false;//设置为非顶级控件
                    form.MdiParent = this;
                    form.Show();

                    iUnm++;

                    this.Label1.Text = iUnm.ToString();

                }
                else
                {
                    FormKLine form = new FormKLine(kv.Value,Color.White);
                    form.TopLevel = false;//设置为非顶级控件
                    form.MdiParent = this;
                    form.Show();

                    iUnm++;

                    this.Label1.Text = iUnm.ToString();
                }


                //this.LayoutMdi(MdiLayout.TileHorizontal);
            }

            this.toolStripProgressBar_Sim.Value = 100;
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        private void ToolStripButton_test_Click(object sender, EventArgs e)
        {
            TreeViewForm f = new TreeViewForm();
            f.Show();
        }

        private void ToolStripButton_Kally_Click(object sender, EventArgs e)
        {
            KallyForm kally = new KallyForm();
            kally.Show();
        }
    }
}
