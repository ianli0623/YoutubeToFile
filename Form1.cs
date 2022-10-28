using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YoutubeToFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_FolderPath.Enabled = false;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            //path.Description = "請選擇存放資料夾";
            path.ShowDialog();
            txt_FolderPath.Text = path.SelectedPath;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            try
            {
                var source = txt_FolderPath.Text;
                if (!string.IsNullOrEmpty(source))
                {
                    if (!string.IsNullOrEmpty(txt_url.Text))
                    {
                        var youtube = YouTube.Default;
                        var vid = youtube.GetVideo(txt_url.Text);
                        string file_name = Path.Combine(source, vid.FullName);
                        Cursor.Current = Cursors.WaitCursor;
                        File.WriteAllBytes(file_name, vid.GetBytes());
                        var inputFile = new MediaFile { Filename = file_name };
                        var outputFile = new MediaFile { Filename = file_name.Replace(".mp4", ".mp3") };
                        using (var engine = new Engine())
                        {
                            engine.GetMetadata(inputFile);
                            engine.Convert(inputFile, outputFile);
                        }
                        lin_mp3.Text = outputFile.Filename;
                        lin_mp4.Text = inputFile.Filename;
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("請輸入網址");
                    }
                }
                else
                {
                    MessageBox.Show("請選擇資料夾");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lin_mp3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = lin_mp3.Text;
            process.Start();
        }

        private void lin_mp4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = lin_mp4.Text;
            process.Start();
        }

        private void btn_opendow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_FolderPath.Text))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = txt_FolderPath.Text,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            else
            {
                MessageBox.Show("請選擇資料夾");
            }
        }
    }
}
