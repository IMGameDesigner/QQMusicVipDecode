using System;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace DefaultNamespace
{
    public class cmd
    {
        Process p;
        private Action endCallback;
        public cmd(Action endCallback)
        {
            this.endCallback = endCallback;
            openCmd();
        }

        public void RunCmdAsync(string cmdInput)
        {
            p.StandardInput.WriteLine(cmdInput);
        }

        public void ExitAsync()
        {
            p.StandardInput.WriteLine("exit");
        }

        private void openCmd()
        {
            p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            p.OutputDataReceived += new DataReceivedEventHandler(LogListener);
            p.ErrorDataReceived += new DataReceivedEventHandler(ErrorListener);
            //启用Exited事件
            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(ExitListener);

            //启动程序
            p.Start();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            p.StandardInput.AutoFlush = true;
        }


        private void LogListener(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Debug.Log("LogListener:<color=#00f>" + e.Data + "</color>");
            }
        }

        private void ErrorListener(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Debug.LogError(e.Data);
            }
        }

        private void ExitListener(object sender, EventArgs e)
        {
            Debug.Log("命令执行完毕");
            endCallback?.Invoke();
        }


    }
}