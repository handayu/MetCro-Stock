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
    public partial class TreeViewForm : Form
    {
        public TreeViewForm()
        {
            InitializeComponent();

        }

        private Dictionary<int, List<int>> m_wholeLines = new Dictionary<int, List<int>>();

        private void Button1_Click(object sender, EventArgs e)
        {
            //TreeOperator op = new TreeOperator();
            //op.addList(null, 80, 0);

            //int iMun = 0;

            //foreach(KeyValuePair<string,BaseInfo> kv  in op.DicInfos)
            //{
            //    //在这里找到的是第10层，最底层的数据，然后一直往上寻找父节点，直到为空
            //    if(kv.Value.levle == 10)
            //    {
            //        List<int> wholeParentLineList = new List<int>();
            //        wholeParentLineList.Add(kv.Value.self);


            //        BaseInfo now = kv.Value;

            //        while (now.parent != null)
            //        {
            //            wholeParentLineList.Add(now.parent.self);

            //            now = now.parent;
            //        }

            //        wholeParentLineList.Reverse();

            //        m_wholeLines.Add(iMun, wholeParentLineList);

            //        this.richTextBox1.AppendText(kv.Value.self.ToString() + "\n");

            //        iMun++;
            //    }
            //}

            //this.richTextBox1.AppendText("\n" + iMun.ToString());


        }
    }
}
