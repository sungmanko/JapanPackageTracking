using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace JapanPackageTracking
{
    public partial class frmJapanPackageTracking : Form
    {
        public frmJapanPackageTracking()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTrackingNumber.Text))
            {
                MessageBox.Show("追跡番号が入ってないです。");
            }
            else
            {
                string url = string.Empty;

                if (rbYubin.Checked)
                {
                    url = "https://trackings.post.japanpost.jp/services/srv/search/?requestNo1=";
                    url += txtTrackingNumber.Text + "&search=追跡スタート";
                }
                else if (rbYamato.Checked)
                {
                    url = "https://jizen.kuronekoyamato.co.jp/jizen/servlet/crjz.b.NQ0010?id=";
                    url += txtTrackingNumber.Text;
                }
                else if (rbSagawa.Checked)
                {
                    url = "http://k2k.sagawa-exp.co.jp/p/web/okurijosearch.do?okurijoNo=";
                    url += txtTrackingNumber.Text;
                }
                Process.Start(url);
            }
        }
    }
}
