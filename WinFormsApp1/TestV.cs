using ReactiveUI;

namespace WinFormsApp1
{
    public partial class TestV : UserControl, IViewFor<TestVM>
    {
        public TestV()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(this.ViewModel, vm => vm.Text, v => v.label1.Text));
            });
        }

        public TestVM? ViewModel { get; set; }
        object? IViewFor.ViewModel { get => this.ViewModel; set => this.ViewModel = value as TestVM; }
    }
}
