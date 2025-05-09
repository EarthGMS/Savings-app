using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenYouTubeButton();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void OpenYouTubeButton()
        {
            string youtubeUrl = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = youtubeUrl,
                    UseShellExecute = true // Needed for .NET Core or newer .NET
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open link: " + ex.Message);
            }
        }
    }
}
