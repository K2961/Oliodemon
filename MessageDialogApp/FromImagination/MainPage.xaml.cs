using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FromImagination
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private IAsyncAction asyncAction;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;

            IAsyncAction a = Windows.System.Threading.ThreadPool.RunAsync(
                (work) =>
                {
                    while (true)
                    {
                        Debug.WriteLine("Running thread: " + Environment.CurrentManagedThreadId);
                        Debug.WriteLine("work count: " + count++);
                        if (work.Status == AsyncStatus.Canceled || count > 1000)
                        {
                            break;
                        }
                    }
                });
            asyncAction = a;

            asyncAction.Completed = new AsyncActionCompletedHandler(
                async (IAsyncAction act, AsyncStatus status) =>
                {
                    Debug.WriteLine("work complete, thread: " + Environment.CurrentManagedThreadId);
                    //Debug.WriteLine("work count when finished: " + count);

                    await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                        CoreDispatcherPriority.High, new DispatchedHandler(() =>
                        {
                            if (status == AsyncStatus.Canceled)
                            {
                                textBlock.Text = "Work thread canceled: " + count;
                            }
                            else
                            {
                                textBlock.Text = "Work thread complete: " + count;
                            }
                        }));
                });
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (asyncAction != null)
            {
                asyncAction.Cancel();
            }
        }
    }
}
