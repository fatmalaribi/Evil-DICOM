﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Core.IO.Data;

namespace EvilDICOM.Core.Element
{
    /// <summary>
    /// Encapsulates the Date VR type
    /// </summary>
    public class Date : AbstractElement<System.DateTime?>
    {
        public Date() { }

        public Date(Tag tag, string data)
        {
            Tag = tag;
            Data = StringDataParser.ParseDate(data);
            VR = Enums.VR.Date;
        }
    }
}