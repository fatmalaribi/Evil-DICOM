﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Core.IO.Data;

namespace EvilDICOM.Core.Element
{
    /// <summary>
    /// Encapsulates the Unknown VR type
    /// </summary>
    public class Unknown : AbstractElement<byte[]>
    {
        public Unknown() { }

        public Unknown(Tag tag, byte[] data)
        {
            Tag = tag;
            Data = data;
            VR = Enums.VR.Unknown;
        }
    }
}
