using System.Collections;

namespace TAMU.GeoInnovation.Surveys.Core
{
    public class Survey
    {
        #region
        private int _Id;
        private string _Name;
        private string _Description;
        private string _Location;
        private ArrayList _Categories;
        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public ArrayList Categories
        {
            get { return _Categories; }
            set { _Categories = value; }
        }

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
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

        public Survey()
        {
            Categories = new ArrayList();
        }
    }
}
