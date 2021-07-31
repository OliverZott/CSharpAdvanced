using System.IO;
using System.Net;
using System.Windows;

namespace AsynchronousProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtml("https://www.google.com/");
        }

        private void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            // write url response to disk
            using var streamWriter = new StreamWriter("result.html");
            streamWriter.Write(html);
        }
    }
}
