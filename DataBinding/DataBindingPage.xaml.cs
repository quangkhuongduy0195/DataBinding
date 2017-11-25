using System.Threading.Tasks;
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

        private async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            pokemon.Name = "No Name";

            await Task.Delay(3000);

            pokemon.Name = "Quang Khuong Duy";
        }
    }
}
