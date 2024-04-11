namespace GridLayoutIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped1(object sender, TappedEventArgs e)
        {
            BottomBox1.IsVisible = !BottomBox1.IsVisible;
        }

        private void TapGestureRecognizer_OnTapped2(object sender, TappedEventArgs e)
        {
            BottomBox2.IsVisible = !BottomBox2.IsVisible;
        }
    }

}
