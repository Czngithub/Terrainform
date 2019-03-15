using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrainForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 form = new Form1();
            Boolean b = form.InitializeDirect3D();
            if (b==false)
            {
                MessageBox.Show("无法启动Direct3D","错误");
                return;
            }
            form.Show();//如果初始化成功，则显示窗体
            while (form.Created)
            {
                form.Render();
                Application.DoEvents();
            }
            //form.Dispose();
        }
    }
}
