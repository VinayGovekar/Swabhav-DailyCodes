using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using TaskAndThreadApp.Model;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TaskAndThreadApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            
            this.Height = 200;
            this.Width = 300;
            this.Shown += AllButtonsCreater;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        public void AllButtonsCreater(object sender,EventArgs e)
        {
            var HelloButton = CreateButton("Hello", 10, 10);
            HelloButton.Click += new EventHandler((object s, EventArgs eargs) => MessageBox.Show("Hello"));
            this.Controls.Add(HelloButton);

            var syncButton = CreateButton("Sync", 90, 10);
            syncButton.Click += new EventHandler(SyncButtonClick);
            this.Controls.Add(syncButton);

            var threadButton = CreateButton("Thread", 170, 10);
            threadButton.Click += new EventHandler(ThreadButtonClick);
            this.Controls.Add(threadButton);

            var taskButton = CreateButton("Task", 10, 60);
            taskButton.Click += new EventHandler(TaskButtonClick);
            this.Controls.Add(taskButton);

            var asyncButton = CreateButton("Async", 90, 60);
            asyncButton.Click += new EventHandler(AsyncButtonClick);
            this.Controls.Add(asyncButton);

            var asyncResultButton = CreateButton("AsyncResult", 170, 60);
            asyncResultButton.Click += new EventHandler(AsyncResultButtonClick);
            this.Controls.Add(asyncResultButton);
            
        }
        public void SyncButtonClick(object s, EventArgs e)
        {
            new TimePrinter().PrintDelay();
        }

        public void ThreadButtonClick(object s,EventArgs e)
        {
            new Thread(new TimePrinter().PrintDelay).Start();
        }

        public void TaskButtonClick(object s, EventArgs e)
        {
            Task.Run(new TimePrinter().PrintDelay);
        }
        public void AsyncButtonClick(object s, EventArgs e)
        {
            var result = new TimePrinter().PrintAsync();
            MessageBox.Show(result.ToString());
        }
        public async void AsyncResultButtonClick(object s,EventArgs e)
        {
            var result = await new TimePrinter().PrintAsync();
            MessageBox.Show(result.ToString());
        }
        public Button CreateButton(string name,int x,int y)
        {
            Button button = new Button();
            button.Text = name;
            button.Size = new Size(50, 30);
            button.Location = new Point(x, y);
            return button;
        }
    }
}
