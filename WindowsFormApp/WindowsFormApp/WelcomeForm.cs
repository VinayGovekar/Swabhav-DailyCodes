using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.Text = "Welcome Form";
            this.Shown += CreateLabel;
            this.Shown += CreateButton;
        }

        private void GodListner(object sender, EventArgs e)
        {
            Console.WriteLine("\nGod is listening!!");
        }
        private void DevilListner(object sender, EventArgs e) {
            Console.WriteLine("Devil is listening!!");
        }
        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
        private void CreateLabel(object sender, EventArgs e)
        {
            Label descriptionLabel = new Label();
            descriptionLabel.Text = "Welcome to forms App";
            descriptionLabel.Width = 200;
            descriptionLabel.Height = 30;
            descriptionLabel.Font = new Font("Times New Roman", 14);
            this.Controls.Add(descriptionLabel);
        }
        private void CreateButton(object sender, EventArgs e)
        {
            Button clickMeButton = new Button();
            clickMeButton.Text = "Click Me!";
            clickMeButton.Font = new Font("Arial", 14);
            clickMeButton.Click += new EventHandler(this.GodListner);
            clickMeButton.Click += new EventHandler(this.DevilListner);
            clickMeButton.Size = new Size(150,30);
            clickMeButton.Location= new Point(30,30);
            clickMeButton.BackColor = Color.LightBlue;
            this.Controls.Add(clickMeButton);
        }
    }
}
