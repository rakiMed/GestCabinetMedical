using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Medcin:User
    {
        public Medcin()
        { }




        public override void AfficherInterface()
        {
            FormMedcin f = new FormMedcin(this);
            f.Show();
        }

    }
}
