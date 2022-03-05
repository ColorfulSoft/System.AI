//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace System
{

    public static partial class warnings
    {

        /// <summary>
        /// Contains hashes of displayed warnings.
        /// </summary>
        private static List<int> __shown_hashes__;

        /// <summary>
        /// Warning filters.
        /// </summary>
        private static Dictionary<WarningCategory, string> __filter__;

        /// <summary>
        /// Initializes the warnings module.
        /// </summary>
        static warnings()
        {
            __shown_hashes__ = new List<int>();
            __filter__ = new Dictionary<WarningCategory, string>();
            __filter__.Add(WarningCategory.Warning, "default");
            __filter__.Add(WarningCategory.UserWarning, "default");
            __filter__.Add(WarningCategory.DeprecationWarning, "default");
            __filter__.Add(WarningCategory.SyntaxWarning, "default");
            __filter__.Add(WarningCategory.RuntimeWarning, "default");
            __filter__.Add(WarningCategory.FutureWarning, "default");
            __filter__.Add(WarningCategory.PendingDeprecationWarning, "ignore");
            __filter__.Add(WarningCategory.ImportWarning, "ignore");
            __filter__.Add(WarningCategory.UnicodeWarning, "default");
            __filter__.Add(WarningCategory.BytesWarning, "default");
            __filter__.Add(WarningCategory.ResourceWarning, "ignore");
        }

        /// <summary>
        /// Displays the warning text or throws it as an exception.
        /// </summary>
        /// <param name="warning">Warning object.</param>
        /// <param name="stacklevel">Stack level.</param>
        /// <param name="raise">Whether to throw an exception.</param>
        private static void __display__(Warning warning, int stacklevel, bool raise)
        {
            if(raise)
            {
                throw warning;
            }
            else
            {
                var foreground_color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warning (from warnings module):");
                var trace = new StackTrace(true);
                stacklevel = Math.Max(Math.Min(trace.FrameCount - 2, stacklevel), 1);
                var frame = trace.GetFrame(stacklevel + 1);
                Console.WriteLine(string.Format("    File \"{0}\", line {1}, in {2}", frame.GetFileName(), frame.GetFileLineNumber(), frame.GetMethod().Name));
                Console.WriteLine(warning.__warn_message__());
                Console.ForegroundColor = foreground_color;
            }
        }

        /// <summary>
        /// Sets a simple filter for an action with warnings of a given category.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="category">Warning category.</param>
        public static void simplefilter(string action, WarningCategory category)
        {
            action = action.ToLower();
            if((action != "default") &&
               (action != "error") &&
               (action != "ignore") &&
               (action != "always") &&
               (action != "module") &&
               (action != "once"))
            {
                throw new ArgumentException("Invalid string for action.");
            }
            else
            {
                __filter__[category] = action;
            }
        }

        /// <summary>
        /// Issue a warning, or maybe ignore it or raise an exception.
        /// The category argument, if given, must be a warning category class;
        /// it defaults to UserWarning.
        /// Alternatively, message can be a Warning instance, in which case category will be
        /// ignored and message.GetType() will be used. In this case, the message text
        /// will be message.ToString(). This function raises an exception if the particular
        /// warning issued is changed into an error by the warnings filter.
        /// The stacklevel argument can be used by wrapper functions written in .NET language, like this:
        /// </summary>
        /// <code>
        /// public static void deprecation(string message)
        /// {
        ///     warnings.warn(message, WarningCategory.DeprecationWarning, stacklevel: 2);
        /// }
        /// </code>
        /// <param name="message"></param>
        /// <param name="stacklevel"></param>
        public static void warn(object message, WarningCategory category = WarningCategory.UserWarning, int stacklevel = 1)
        {
            Warning warn = null;
            if(!(message is Warning))
            {
                switch(category)
                {
                    case WarningCategory.Warning:
                    {
                        warn = new Warning(message);
                        break;
                    }
                    case WarningCategory.UserWarning:
                    {
                        warn = new UserWarning(message);
                        break;
                    }
                    case WarningCategory.DeprecationWarning:
                    {
                        warn = new DeprecationWarning(message);
                        break;
                    }
                    case WarningCategory.SyntaxWarning:
                    {
                        warn = new SyntaxWarning(message);
                        break;
                    }
                    case WarningCategory.RuntimeWarning:
                    {
                        warn = new RuntimeWarning(message);
                        break;
                    }
                    case WarningCategory.FutureWarning:
                    {
                        warn = new FutureWarning(message);
                        break;
                    }
                    case WarningCategory.PendingDeprecationWarning:
                    {
                        warn = new PendingDeprecationWarning(message);
                        break;
                    }
                    case WarningCategory.ImportWarning:
                    {
                        warn = new ImportWarning(message);
                        break;
                    }
                    case WarningCategory.UnicodeWarning:
                    {
                        warn = new UnicodeWarning(message);
                        break;
                    }
                    case WarningCategory.BytesWarning:
                    {
                        warn = new BytesWarning(message);
                        break;
                    }
                    case WarningCategory.ResourceWarning:
                    {
                        warn = new ResourceWarning(message);
                        break;
                    }
                }
            }
            else
            {
                warn = message as Warning;
            }
            switch(__filter__[warn.category()])
            {
                case "default":
                {
                    goto case "once"; //TODO
                }
                case "ignore":
                {
                    break;
                }
                case "always":
                {
                    __display__(warn, stacklevel, __filter__[warn.category()] == "error");
                    break;
                }
                case "module":
                {
                    goto case "once";
                }
                case "once":
                {
                    if(!__shown_hashes__.Contains(warn.GetHashCode()))
                    {
                        __display__(warn, stacklevel, __filter__[warn.category()] == "error");
                        __shown_hashes__.Add(warn.GetHashCode());
                    }
                    break;
                }
            }
        }

    }

}