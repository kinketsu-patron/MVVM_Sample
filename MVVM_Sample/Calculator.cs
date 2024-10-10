namespace MVVM_Sample
{
    public class Calculator : NotifyChanged
    {
        private uint _LeftParam;
        public uint LeftParam
        {
            get
            {
                return _LeftParam;
            }
            set
            {
                if ( _LeftParam != value )
                {
                    _LeftParam = value;
                }
            }
        }

        private uint _RightParam;
        public uint RightParam
        {
            get
            {
                return _RightParam;
            }
            set
            {
                if ( _RightParam != value )
                {
                    _RightParam = value;
                }
            }
        }

        private uint _Result;
        public uint Result
        {
            get
            {
                return _Result;
            }
            set
            {
                if ( _Result != value )
                {
                    _Result = value;
                    RaisePropertyChanged( );
                }
            }
        }

        public void Sum( )
        {
            Result = LeftParam + RightParam;
        }
    }
}
