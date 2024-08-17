using System.Diagnostics;
using WinFormsApp.异步和多线程.Biz;

namespace WinFormsApp.异步和多线程
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void AppendLine(string info)
        {
            this.textBox1.Text += info + Environment.NewLine;
            this.textBox1.ScrollToCaret();
            this.textBox1.Refresh();
        }

        public void InvokeAppendLine(string info)
        {
            this.Invoke(AppendLine, info);
        }

        public void InvokeAppendLine(object info)
        {
            this.Invoke(AppendLine, info.ToString());
        }


        private void BtnNormal_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AppendLine("同步检索开始...");

            Library.Books.ForEach(book =>
            {
                AppendLine(book.Search());
            });
            stopwatch.Stop();
            AppendLine($"同步检索结束，耗时{Convert.ToSingle(stopwatch.ElapsedMilliseconds) / 1000}秒。");
        }



        private void BtnThread_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AppendLine("自定义线程方式检索开始...");

            Thread thread = new Thread(() =>
            {
                Library.Books.ForEach(book =>
                {
                    //为了防止在非创建UI的线程上访问控件，需要使用invoke调用
                    this.InvokeAppendLine(book.Search());
                });
            });

            thread.Start();
            //thread.Join();

            stopwatch.Stop();
            AppendLine($"自定义线程方式检索结束，耗时{Convert.ToSingle(stopwatch.ElapsedMilliseconds) / 1000}秒。");
        }

        private void BtnBGWorker_Click(object sender, EventArgs e)
        {
            this.backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object? sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            this.InvokeAppendLine("后台线程方式检索开始...");

            Library.Books.ForEach(book =>
            {
                this.InvokeAppendLine(book.Search());
            });

            stopwatch.Stop();
            this.InvokeAppendLine($"后台线程方式检索结束，耗时{Convert.ToSingle(stopwatch.ElapsedMilliseconds) / 1000}秒。");
        }

        private void BtnThreadPool_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AppendLine("线程池方式检索开始...");

            ThreadPool.SetMinThreads(3, 3);
            ThreadPool.SetMaxThreads(5, 5);

            Library.Books.ForEach(book =>
            {
                //为了防止在非创建UI的线程上访问控件，需要使用invoke调用
                //this.InvokeAppendLine(book.Search());
                ThreadPool.QueueUserWorkItem(InvokeAppendLine, (object)book.Search());
            });


            //Thread thread = new Thread(() =>
            //{
            //    Library.Books.ForEach(book =>
            //    {
            //        //为了防止在非创建UI的线程上访问控件，需要使用invoke调用
            //        this.InvokeAppendLine(book.Search());
            //    });
            //});

            //thread.Start();
            ////thread.Join();

            stopwatch.Stop();
            AppendLine($"线程池方式检索结束，耗时{Convert.ToSingle(stopwatch.ElapsedMilliseconds) / 1000}秒。");
        }
    }
}
