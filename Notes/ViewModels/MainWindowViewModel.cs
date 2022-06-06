namespace Notes.ViewModels
{
    internal class MainWindowViewModel : Base.BaseViewModel
    {
        private string _title = "Notes";
        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }
    }
}
