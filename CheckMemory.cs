using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace file_manager
{
    internal class CheckMemory
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        private ProgressBar pbFreeSpaceC;
        private ProgressBar pbFreeSpaceD;
        private Label txtFreeSpaceC;
        private Label txtFreeSpaceD;
        private Label txtPercentC;
        private Label txtPercentD;

        
        public CheckMemory(ProgressBar pbFreeSpaceC, ProgressBar pbFreeSpaceD, Label txtFreeSpaceC, Label txtFreeSpaceD, Label txtPercentC, Label txtPercentD)
        {
            this.pbFreeSpaceC = pbFreeSpaceC;
            this.pbFreeSpaceD = pbFreeSpaceD;
            this.txtFreeSpaceC = txtFreeSpaceC;
            this.txtFreeSpaceD = txtFreeSpaceD;
            this.txtPercentC = txtPercentC;
            this.txtPercentD = txtPercentD;
        }

        public void UpdateMemory()
        {
            while (true)
            {
                try
                {
                    txtFreeSpaceC.Text = drives[0].Name + " " + Math.Round((drives[0].TotalSize - (double)drives[0].TotalFreeSpace) / 1073741824, 1).ToString() + " Гб " + "/"
                         + Math.Round((double)drives[0].TotalSize / 1073741824, 1).ToString() + " Гб ";
                    pbFreeSpaceC.Value = Convert.ToInt16(Math.Round((drives[0].TotalSize - drives[0].AvailableFreeSpace) / (double)drives[0].TotalSize * 100));
                    txtPercentC.Text = Math.Round((drives[0].TotalSize - drives[0].AvailableFreeSpace) / (double)drives[0].TotalSize * 100, 1).ToString() + "%";

                    txtFreeSpaceD.Text = drives[1].Name + " " + Math.Round((drives[1].TotalSize - (double)drives[1].TotalFreeSpace) / 1073741824, 1).ToString() + " Гб " + "/"
                         + Math.Round((double)drives[1].TotalSize / 1073741824, 1).ToString() + " Гб ";
                    pbFreeSpaceD.Value = Convert.ToInt16(Math.Round((drives[1].TotalSize - drives[1].AvailableFreeSpace) / (double)drives[1].TotalSize * 100));
                    txtPercentD.Text = Math.Round((drives[1].TotalSize - drives[1].AvailableFreeSpace) / (double)drives[1].TotalSize * 100, 1).ToString() + "%";
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    continue;
                }
                Thread.Sleep(2 * 1000);

            }
        }
    }
}
