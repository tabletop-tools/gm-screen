using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TabletopTools.GMScreen.ViewMOdel.Command
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetValue<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (property != null && property.Equals(value))
                return;

            property = value;
            OnPropertyChanged(propertyName);
        }

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}