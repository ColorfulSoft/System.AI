//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;

namespace System
{

    /// <summary>
    /// This is the base class of all warning category classes. It is a subclass of Exception.
    /// </summary>
    public class Warning : Exception
    {

        /// <summary>
        /// Parameters passed when creating the warning instance.
        /// </summary>
        public object[] args
        {

            get;

            internal set;

        }

        /// <summary>
        /// Hash code of the current warning object.
        /// </summary>
        private readonly int __hash__;

        /// <summary>
        /// Returns the hash code of the current warning object.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return this.__hash__;
        }

        /// <summary>
        /// Writes string representations of args array elements into a single string, separating them with a comma.
        /// </summary>
        /// <param name="args">Arguments.</param>
        /// <returns>String representations.</returns>
        private static string __format_args__(object[] args)
        {
            var str = "";
            for(int i = 0; i < args.Length; ++i)
            {
                if(args[i] is string)
                {
                    str += '"' + args[i].ToString() + '"';
                    if((i + 1) == args.Length)
                    {
                        break;
                    }
                    str += ", ";
                    continue;
                }
                if(args[i] is char)
                {
                    str += '\'' + args[i].ToString() + '\'';
                    if((i + 1) == args.Length)
                    {
                        break;
                    }
                    str += ", ";
                    continue;
                }
                str += args[i].ToString();
                if((i + 1) == args.Length)
                {
                    break;
                }
                str += ", ";
            }
            return str;
        }

        /// <summary>
        /// Generates message for warnings.warn.
        /// </summary>
        /// <returns>String representation of the current Warning object.</returns>
        internal string __warn_message__()
        {
            return this.GetType().Name + ((this.args.Length > 1) ? ": (" : ": ") + __format_args__(this.args) + ((this.args.Length > 1) ? ")" : "");
        }

        /// <summary>
        /// Initializes the warning object with the specified arguments (data about the problem).
        /// </summary>
        /// <param name="args">Arguments</param>
        public Warning(params object[] args) : base(__format_args__(args))
        {
            this.args = args;
            this.__hash__ = this.GetType().Name.GetHashCode();
            foreach(var arg in this.args)
            {
                unchecked
                {
                    this.__hash__ += arg.GetHashCode();
                }
            }
        }

        /// <summary>
        /// Returns a string representation of the current warning object.
        /// </summary>
        /// <returns>String representation of the current warning object.</returns>
        public override string ToString()
        {
            return this.GetType().Name + '(' + __format_args__(this.args) + ')';
        }

        /// <summary>
        /// Returns the warning category.
        /// </summary>
        /// <returns>Warning category.</returns>
        public virtual WarningCategory category()
        {
            if(this.GetType() == typeof(object))
            {
                return WarningCategory.Warning;
            }
            if(this is UserWarning)
            {
                return WarningCategory.UserWarning;
            }
            if(this is DeprecationWarning)
            {
                return WarningCategory.DeprecationWarning;
            }
            if(this is SyntaxWarning)
            {
                return WarningCategory.SyntaxWarning;
            }
            if(this is RuntimeWarning)
            {
                return WarningCategory.RuntimeWarning;
            }
            if(this is FutureWarning)
            {
                return WarningCategory.FutureWarning;
            }
            if(this is PendingDeprecationWarning)
            {
                return WarningCategory.PendingDeprecationWarning;
            }
            if(this is ImportWarning)
            {
                return WarningCategory.ImportWarning;
            }
            if(this is UnicodeWarning)
            {
                return WarningCategory.UnicodeWarning;
            }
            if(this is BytesWarning)
            {
                return WarningCategory.BytesWarning;
            }
            if(this is ResourceWarning)
            {
                return WarningCategory.ResourceWarning;
            }
            return WarningCategory.Warning;
        }

    }

}