using Xamarin.Forms;

namespace DataBinding
{
    public partial class DataBindingPage : ContentPage
    {
        private Pokemon pokemon;
        public DataBindingPage()
        {
            InitializeComponent();
            pokemon = new Pokemon()
            {
                Name = "Pikachu",
                Type = "Type 1"
            };
            mStack.BindingContext = pokemon;
        }
    }
}
