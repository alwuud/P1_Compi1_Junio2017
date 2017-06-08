using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;
using Irony.Ast;

    


namespace Practica1_Junio17_COMPI1.Compiler
{

    class MainGrammar:  Irony.Parsing.Grammar

    {
        public MainGrammar(): base(false)
        {
            #region Terminals 

            var lK = ToTerm("[");
            var rK = ToTerm("]");
            var lP = ToTerm("(");
            var rP = ToTerm(")");
            
            var equal = ToTerm("=");
            var dollar = ToTerm("$");
            var comma = ToTerm(",");

            var div = ToTerm("/");
            var plus = ToTerm("+");
            var less = ToTerm("-");
            var times = ToTerm("*");

            #endregion Terminals

            #region SpecialTerminals
            var ids = new IdentifierTerminal("id", "_");
            var strs = new StringLiteral("string", "\"");
            var nums = new NumberLiteral("int", NumberOptions.NoDotAfterInt, typeof(Int32));



            #endregion




        }

    }
}
