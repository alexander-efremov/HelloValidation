using MugenMvvmToolkit.Models;

namespace Core.Models
{
    public class User : NotifyPropertyChangedBase
    {
        private string _lastname;
        private string _firstname;

        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if(Equals(Lastname, value)) return;
                _lastname = value;
                OnPropertyChanged();
            }
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if (Equals(Firstname, value)) return;
                _firstname = value;
                OnPropertyChanged();
            }
        }
    }
}