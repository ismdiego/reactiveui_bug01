namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Control? DefaultControl { get; }
        
        public Form1()
        {
            InitializeComponent();
            this.DefaultControl = new Label() { Text = "Nothing here" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.viewModelControlHost1.ViewModel = new TestVM();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.viewModelControlHost1.ViewModel = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.viewModelControlHost1.ViewModel = new TestVM();
            this.viewModelControlHost1.DefaultContent = this.DefaultControl;
        }
    }
}