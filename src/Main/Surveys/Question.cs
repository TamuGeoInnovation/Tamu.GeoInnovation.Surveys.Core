using System.Collections;

namespace TAMU.GeoInnovation.Surveys.Core
{
    public class Question
    {
        #region
        private int _Id;
        private ArrayList _Answers;
        private QuestionTypes _QuestionType;
        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public QuestionTypes QuestionType
        {
            get { return _QuestionType; }
            set { _QuestionType = value; }
        }

        public ArrayList Answers
        {
            get { return _Answers; }
            set { _Answers = value; }
        }

        private string _Value;

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

        public Question()
        {
            Answers = new ArrayList();
        }
    }
}
