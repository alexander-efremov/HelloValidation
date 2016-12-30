using Core.Models;
using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class MainViewModel : EditableViewModel<User>
    {
        public string Lastname
        {
            get { return Entity.Lastname; }
            set
            {
                if (Equals(Entity.Lastname, value)) return;
                Entity.Lastname = value;
                OnPropertyChanged();
            }
        }

        public string Firstname
        {
            get { return Entity.Firstname; }
            set
            {
                if (Equals(Entity.Firstname, value)) return;
                Entity.Firstname = value;
                OnPropertyChanged();
            }
        }
    }
}