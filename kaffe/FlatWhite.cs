﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe,Imælk
    {

        public FlatWhite()
        {

        }

        public override string Styrke()
        {
            return "Mild";
        }

        public int MlMælk()
        {
            return 160;
        }

        public override int Pris()
        {
            return 45;
        }
    }
}
