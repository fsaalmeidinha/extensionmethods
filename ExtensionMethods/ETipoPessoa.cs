using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    public enum ETipoPessoa
    {
        [System.ComponentModel.Description("Pessoa Física")]
        Fisica = 1,
        [System.ComponentModel.Description("Pessoa Jurídica")]
        Juridica = 2
    }
}
