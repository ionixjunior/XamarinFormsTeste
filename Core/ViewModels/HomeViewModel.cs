namespace Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
    }
}
