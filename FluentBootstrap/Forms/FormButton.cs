﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap.Forms
{
    // This is like Button except it's derived from FormControl so it includes the form wrapping elements
    public class FormButton : FormControl, Buttons.IButton, IHasValueAttribute, IHasDisabledAttribute, IHasTextAttribute
    {
        internal FormButton(BootstrapHelper helper, ButtonType buttonType, ButtonStyle buttonStyle)
            : base(helper, "button", "btn", buttonStyle.GetDescription())
        {
            MergeAttribute("type", buttonType.GetDescription());
        }
    }
}
