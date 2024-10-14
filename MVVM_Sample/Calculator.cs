namespace MVVM_Sample
{
    public class Calculator : BindableBase
    {
        public uint LeftParam { get; set; }
        public uint RightParam { get; set; }

        private uint m_Result;
        public uint Result
        {
            get
            {
                return m_Result;
            }
            set
            {
                SetProperty( ref m_Result, value );
            }
        }

        public void Sum( )
        {
            Result = LeftParam + RightParam;
        }
    }
}
