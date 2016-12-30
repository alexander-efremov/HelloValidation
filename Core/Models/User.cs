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
            set { _lastname = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
    }
}