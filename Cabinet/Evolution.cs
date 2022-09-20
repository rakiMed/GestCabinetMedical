using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Evolution
    {

        private DateTime dateFirstControl;

        public DateTime DateFirstControl
        {
            get { return dateFirstControl; }
            set { dateFirstControl = value; }
        }

        public Evolution(DateTime dateOfFirstControl)
        {
            this.DateFirstControl = dateOfFirstControl;
        }
    }
}
