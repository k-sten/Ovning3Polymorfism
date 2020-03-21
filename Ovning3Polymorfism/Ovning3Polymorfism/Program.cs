using System;
using System.Collections.Generic;

namespace Ovning3Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();
            CharInputError charInputError = new CharInputError();
            SymbolInputError symbolInputError = new SymbolInputError();
            InputError inputerror = new InputError();
            List<UserError> userErrors = new List<UserError> { numericInputError, textInputError, charInputError, symbolInputError, inputerror };

            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            // 3.4.11 Det låter oss definiera en basklass som subklasser kan ärva från som kan implementeras eller använda override

            // 3.4.12 Istället för att behöva skriva samma kod flera gånger kan vi skriva basklassen och sedan använda oss av subklasser

            // 3.4.13 En abstrakt klass definierar vad nånting är. Ett interface definierar vad nånting kan göra.
            // Det går inte att ärva från olika typer av abstrakta klasser men en klass kan innehålla flera interface.
        }
    }
}
