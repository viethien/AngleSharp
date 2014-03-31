﻿namespace AngleSharp.DOM.Css
{
    using System;

    sealed class CSSCounter : CSSPrimitiveValue
    {
        #region Fields

        String identifier;
        String listStyle;
        String separator;

        #endregion

        #region ctor

        public CSSCounter(String identifier, String listStyle, String separator)
        {
            this.identifier = identifier;
            this.listStyle = listStyle;
            this.separator = separator;
        }

        #endregion

        #region Properties

        public String Identifier
        {
            get { return identifier; }
        }

        public String ListStyle
        {
            get { return listStyle; }
        }

        public String Separator
        {
            get { return separator; }
        }

        #endregion
    }
}
