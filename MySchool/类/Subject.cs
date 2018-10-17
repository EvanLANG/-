using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool
{
    public class Subject
    {
        private int _subjectId;

        public int SubjectId
        {
            get { return _subjectId; }
            set { _subjectId = value; }
        }
        private string _subjectName;

        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }

        public override string ToString()
        {
            return this.SubjectName;
        }
    }
}
