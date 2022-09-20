using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cabinet
{
    public class Secretaire:User
    {

        public Secretaire()
        { }

        public override void AfficherInterface()
        {
            FormSecretaire f = new FormSecretaire(this);
            f.Show();
        }
    }
}
