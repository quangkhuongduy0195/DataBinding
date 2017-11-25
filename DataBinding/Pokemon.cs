using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBinding
{
    public class Pokemon: INotifyPropertyChanged
    {

        //public string Name { get; set; }
        private String _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Type { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string property =null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));    
        }
    }
}