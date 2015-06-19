using System.Collections;

namespace TAMU.GeoInnovation.Surveys.Core
{
    public class Category
    {
        #region
        private int _Id;
        private string _Name;
        private ArrayList _Questions;

        public ArrayList Questions
        {
            get { return _Questions; }
            set { _Questions = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        #endregion

        public Category()
        {
            Questions = new ArrayList();
        }
    }
}
