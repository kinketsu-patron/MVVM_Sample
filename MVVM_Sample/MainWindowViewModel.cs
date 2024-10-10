#nullable enable

namespace MVVM_Sample
{
    public class MainWindowViewModel : NotifyChanged
    {
        private Calculator _CalcModel;
        public DelegateCommand EqualCommand { get; }

        public uint LeftParam
        {
            get { return _CalcModel.LeftParam; }
            set { _CalcModel.LeftParam = value; }
        }

        public uint RightParam
        {
            get { return _CalcModel.RightParam; }
            set { _CalcModel.RightParam = value; }
        }

        public uint Result
        {
            get { return _CalcModel.Result; }
            set { _CalcModel.Result = value; }
        }

        public MainWindowViewModel( )
        {
            _CalcModel = new Calculator( );
            _CalcModel.PropertyChanged += ( sender, e ) => RaisePropertyChanged( e.PropertyName );
            EqualCommand = new DelegateCommand( Equal_Click );
        }

        private void Equal_Click( )
        {
            _CalcModel.Sum( );
        }
    }
}
