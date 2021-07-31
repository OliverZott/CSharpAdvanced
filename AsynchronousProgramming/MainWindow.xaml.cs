using System.IO;
using System.Net;
using System.Threading.Tasks;
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // DownloadHtmlAsync("https://www.google.com/");   // first async example

            var getHtmlTask = GetHtmlAsync("https://www.google.com/");  // Task object representing state of async operation!
            MessageBox.Show("Waiting for async stuff :)");  // We dont have to wait until async stuff is finished.

            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }


        // generic /nongeneric versions <>
        // annotate blocking operation: affix async
        private async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();

            // blocking method -> async version 
            var html = await webClient.DownloadStringTaskAsync(url);  // 'await' is marker for compiler so compiler continues!
            // if runtime is compilted it continues here!

            await using var streamWriter = new StreamWriter("result.html");
            {
                // blocking method -> async version 
                await streamWriter.WriteAsync(html);
            }

        }


        private void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            // write url response to disk
            using var streamWriter = new StreamWriter("result.html");
            streamWriter.Write(html);
        }


        // Example 2 - NOT async
        private string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        // Example 2 - async
        private async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
