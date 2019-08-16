namespace DynamicToolTipSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public ViewModel ViewModel { get; set; }
        public MainWindow()
        {
            ViewModel = new ViewModel();
            DataContext = ViewModel;
            InitializeComponent();
            ViewModel.Initialize(btn);
        }
    }
}
