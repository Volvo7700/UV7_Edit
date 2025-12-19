using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UV7_Edit.Preferences
{
    public enum ApplyTimeState
    {
        Immediate,
        OnNextCall,
        AfterRestart,
    }
    
    public class ApplyTimeAttribute : Attribute
    {
        public ApplyTimeState ApplyTime;

        public ApplyTimeAttribute(ApplyTimeState applyTime) : base()
        {
            ApplyTime = applyTime;
        }
    }
}
