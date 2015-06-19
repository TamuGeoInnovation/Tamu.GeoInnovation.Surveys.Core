namespace TAMU.GeoInnovation.Surveys.Core
{
    public class Answer
    {
        #region
        private int _Id;
        private string _Value;
        private bool _Enabled;
        private bool _IsNADefault;

        public bool IsNADefault
        {
            get { return _IsNADefault; }
            set { _IsNADefault = value; }
        }

        public bool Enabled
        {
            get { return _Enabled; }
            set { _Enabled = value; }
        }

        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        #endregion

    }
}
