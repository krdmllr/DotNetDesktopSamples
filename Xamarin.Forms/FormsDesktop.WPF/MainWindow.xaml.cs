namespace Xamarin.Forms.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new FormsDesktop.App());
        }
    }
}
