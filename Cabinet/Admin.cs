using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Admin:User
    {

        public Admin()
        { 
        }

        
        public override void AfficherInterface()
        {
            new FormAdministrareur(this).Show();
        }

    }
}
