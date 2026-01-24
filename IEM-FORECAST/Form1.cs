using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IEM_FORECAST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "schtasks",
                    Arguments = @"/run /s TSEDB /u tse\administrator /p scsadmin /tn ""IEM-Forecast.""",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(psi);

                MessageBox.Show("สั่งรัน IEM-Forecast. สำเร็จ",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
