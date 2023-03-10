using System;
using Trainer.DAL.Util.Constant;

namespace Trainer.DAL.Entities
{
    public class Examination
    {
        public Guid Id
        {
            get;
            set;
        }

        public Guid PatientId
        {
            get;
            set;
        }

        public TypePhysicalActive TypePhysicalActive
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public int Indicators
        {
            get;
            set;
        }

        public Status Status
        {
            get;
            set;
        }

        public Patient Patient
        {
            get;
            set;
        }

        public Results Result
        {
            get;
            set;
        }
    }
}
