using Notes.ViewModels.Base;

namespace Notes.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Notes";
        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }
    }
}
