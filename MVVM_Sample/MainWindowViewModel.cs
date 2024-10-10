#nullable enable

namespace MVVM_Sample
{
    public class MainWindowViewModel : NotifyChanged
    {
        private Calculator m_CalcModel;
        public DelegateCommand EqualCommand { get; }

        public uint LeftParam
        {
            get { return m_CalcModel.LeftParam; }
            set { m_CalcModel.LeftParam = value; }
        }

        public uint RightParam
        {
            get { return m_CalcModel.RightParam; }
            set { m_CalcModel.RightParam = value; }
        }

        public uint Result
        {
            get { return m_CalcModel.Result; }
            set { m_CalcModel.Result = value; }
        }

        public MainWindowViewModel( )
        {
            m_CalcModel = new Calculator( );
            m_CalcModel.PropertyChanged += ( sender, e ) => RaisePropertyChanged( e.PropertyName );
            EqualCommand = new DelegateCommand( Equal_Click );
        }

        private void Equal_Click( )
        {
            m_CalcModel.Sum( );
        }
    }
}
