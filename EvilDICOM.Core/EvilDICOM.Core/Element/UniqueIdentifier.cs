﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Core.IO.Data;

namespace EvilDICOM.Core.Element
{
    /// <summary>
    /// Encapsulates the UniqueIdentifier VR type
    /// </summary>
    public class UniqueIdentifier : AbstractElement<string>
    {
        public new string Data
        {
            get { return base.Data; }
            set { base.Data = DataRestriction.EnforceLengthRestriction(64, value); }
        }

        public UniqueIdentifier()
        {
        }

        public UniqueIdentifier(Tag tag, string data)
        {
            Tag = tag;
            Data = data;
            VR = Enums.VR.UniqueIdentifier;
        }
    }
}
