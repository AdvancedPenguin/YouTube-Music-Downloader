using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YouTubeDownloader
{
    public partial class Form1 : Form
    {
        private readonly YoutubeClient youtube;

        public Form1()
        {
            InitializeComponent();
            youtube = new YoutubeClient();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            var links = txtLinks.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var link in links)
            {
                try
                {
                    var video = await youtube.Videos.GetAsync(link);

                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
                    var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                    var fileName = $"{RemoveInvalidCharacters(video.Title)}.wav";
                    using (var fileStream = File.OpenWrite(fileName))
                    {
                        await stream.CopyToAsync(fileStream);
                    }

                    txtStatus.AppendText($"Success! The video '{video.Title}' has been downloaded and saved as {fileName}{Environment.NewLine}");
                }
                catch (Exception ex)
                {
                    txtStatus.AppendText($"An error occurred: {ex.Message}{Environment.NewLine}");
                }
            }
        }

        private static string RemoveInvalidCharacters(string input)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            var sanitizedTitle = string.Concat(input.Split(invalidChars, StringSplitOptions.RemoveEmptyEntries));
            return sanitizedTitle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}