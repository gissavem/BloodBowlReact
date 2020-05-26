using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BBTeamManagerReact
{
    public class BBException : Exception
    {
        public BBException() : base()
        {

        }
        public BBException(string message) : base(message)
        {

        }
        public BBException(string message, params object[] args) : base (string.Format(CultureInfo.CurrentCulture, message, args))
        {

        }
    }
}
