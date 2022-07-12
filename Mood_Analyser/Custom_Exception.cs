using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class Custom_Exception : Exception
    {

        public enum Mood
        {
            Empty,
            Null
        }

        public readonly Mood Minfo;

        public Custom_Exception(Mood minfo, string info) : base(info)
        {
            this.Minfo = minfo;
        }
    }
}
