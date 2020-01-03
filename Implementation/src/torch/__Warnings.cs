//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

using System;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            ///<summary>Warning output module.</summary>
            internal static class __Warnings
            {

                ///<summary>Texts of warnings that have already been issued.</summary>
                private static List<string> __showed_messages;

                ///<summary>Initializes the warnings module.</summary>
                static __Warnings()
                {
                    __showed_messages = new List<string>();
                }

                ///<summary>Displays a warning.</summary>
                public static void warn(string message, bool uncontrollable = false)
                {
                    if(torch.warnings_are_enabled)
                    {
                        if(uncontrollable)
                        {
                            var last_color = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("UserWarning: " + message);
                            Console.ForegroundColor = last_color;
                        }
                        else
                        {
                            if(!(__showed_messages.Exists((string str) =>
                            {
                                return (str == message);
                            })))
                            {
                                var last_color = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("UserWarning: " + message);
                                Console.ForegroundColor = last_color;
                                __showed_messages.Add(message);
                            }
                        }
                    }
                }

            }

        }

    }

}