namespace WinFormsApp.异步和多线程
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNormal = new Button();
            textBox1 = new TextBox();
            btnThread = new Button();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            btnBGWorker = new Button();
            btnThreadPool = new Button();
            SuspendLayout();
            // 
            // btnNormal
            // 
            btnNormal.Location = new Point(71, 12);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(229, 23);
            btnNormal.TabIndex = 0;
            btnNormal.Text = "同步方法(UI会被冻结)";
            btnNormal.UseVisualStyleBackColor = true;
            btnNormal.Click += BtnNormal_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 181);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 257);
            textBox1.TabIndex = 1;
            // 
            // btnThread
            // 
            btnThread.Location = new Point(71, 81);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(229, 23);
            btnThread.TabIndex = 2;
            btnThread.Text = "自定义线程方法（UI不会被冻结）";
            btnThread.UseVisualStyleBackColor = true;
            btnThread.Click += BtnThread_Click;
            // 
            // backgroundWorker
            // 
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            // 
            // btnBGWorker
            // 
            btnBGWorker.Location = new Point(71, 41);
            btnBGWorker.Name = "btnBGWorker";
            btnBGWorker.Size = new Size(229, 23);
            btnBGWorker.TabIndex = 3;
            btnBGWorker.Text = "后台线程方法（UI不会被冻结）";
            btnBGWorker.UseVisualStyleBackColor = true;
            btnBGWorker.Click += BtnBGWorker_Click;
            // 
            // btnThreadPool
            // 
            btnThreadPool.Location = new Point(71, 120);
            btnThreadPool.Name = "btnThreadPool";
            btnThreadPool.Size = new Size(229, 23);
            btnThreadPool.TabIndex = 4;
            btnThreadPool.Text = "自定义线程池方法（UI不会被冻结）";
            btnThreadPool.UseVisualStyleBackColor = true;
            btnThreadPool.Click += BtnThreadPool_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThreadPool);
            Controls.Add(btnBGWorker);
            Controls.Add(btnThread);
            Controls.Add(textBox1);
            Controls.Add(btnNormal);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNormal;
        private TextBox textBox1;
        private Button btnThread;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Button btnBGWorker;
        private Button btnThreadPool;
    }
}