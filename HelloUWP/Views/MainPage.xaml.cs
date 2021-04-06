using System;

using HelloUWP.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace HelloUWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var myDlg = new MessageDialog("안녕!!!");  // 컴파일시점에 MessageDialog와 바꿔치기 해줌
            myDlg.Commands.Add(new UICommand("OK"));
            myDlg.Commands.Add(new UICommand("no"));
            myDlg.Commands.Add(new UICommand("싫어"));
            await myDlg.ShowAsync();
            
        }
    }
}
// 비동기 : 연락이 안 올것을 가정하고 기다림. EX) 메신저, 카카오톡, NODEJS => 
// 비동기 VS 동기 : 동기화 멈춰있음(오류가 날 가능성 ↑)



