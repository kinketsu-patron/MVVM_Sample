namespace MVVM_Sample
{
    public class Calculator : NotifyChanged
    {
        private uint m_LeftParam;
        public uint LeftParam
        {
            get
            {
                return m_LeftParam;
            }
            set
            {
                if ( m_LeftParam != value )
                {
                    m_LeftParam = value;
                }
            }
        }

        private uint m_RightParam;
        public uint RightParam
        {
            get
            {
                return m_RightParam;
            }
            set
            {
                if ( m_RightParam != value )
                {
                    m_RightParam = value;
                }
            }
        }

        private uint m_Result;
        public uint Result
        {
            get
            {
                return m_Result;
            }
            set
            {
                if ( m_Result != value )
                {
                    m_Result = value;
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
