using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.System.Threading;
using System.Threading.Tasks;
using Windows.UI.Core;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PreriodicApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            rand = new Random();
        }

        private ThreadPoolTimer PeriodicTimer;
        private Random rand;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("StartButton thread id: " + Environment.CurrentManagedThreadId);
            TimeSpan period = TimeSpan.FromMilliseconds(10);
            PeriodicTimer = ThreadPoolTimer.CreatePeriodicTimer(ElapsedHander, period, DestroydHandler);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            PeriodicTimer.Cancel();
        }

        private async void ElapsedHander(ThreadPoolTimer timer)
        {
            Debug.WriteLine("ElapsedHandler thread id: " + Environment.CurrentManagedThreadId);
            // get random number
            double number = rand.NextDouble();
            // update UI
            await Dispatcher.RunAsync(CoreDispatcherPriority.High,
                () =>
                {
                    // UI components can be accessed within this scope
                    Debug.WriteLine("ElapsedHandler after => thread id: " + Environment.CurrentManagedThreadId);
                    RandomNumberTextBlock.Text = "Random number : " + number.ToString("0.0000");
                });
        }
        private async void DestroydHandler(ThreadPoolTimer timer)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High,
            () =>
            {
        // UI components can be accessed within this scope.
        RandomNumberTextBlock.Text = "PeriodicApp Timer Stopped!";
            });
        }
    }
}
