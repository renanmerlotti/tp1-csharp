using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    internal class DownloadManager
    {
        public event Action DownloadCompleted;

        public void StartDownload()
        {
            Thread.Sleep(3000);

            DownloadCompleted?.Invoke();
        }
    }
}
