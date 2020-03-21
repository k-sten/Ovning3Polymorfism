using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3Polymorfism
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text field only. This fired an error!";
        }
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    class CharInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a string input in a character only field. This fired an error!";
        }
    }

    class SymbolInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a symbol input in an alpha numeric only field. This fired an error!";
        }
    }

    class InputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an input in an output only field. This fired an error!";
        }
    }
}
