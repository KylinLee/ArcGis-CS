using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapControlApplication111
{    
    public partial class AdmitBookmarkName : Form
    {
        // 主窗口变量
        public MainForm m_frmMain;
        public AdmitBookmarkName(MainForm frm)
        {
            InitializeComponent();
            if (frm != null)
            {
                // 初始化获取主窗口，以便后续调用其方法
                m_frmMain = frm;
            }
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (m_frmMain != null && tbBookmarkName.Text != "")
            {
                // 当输入值不为空时，调用主窗口方法，创建书签
                m_frmMain.CreatBookmark(tbBookmarkName.Text);
            }
            this.Close();
        }
    }
}
