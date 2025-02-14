﻿namespace PnP.Core.Model
{
    /// <summary>
    /// Attribute to define how a model property maps to a Microsoft Graph field for usage in Microsoft Graph API calls
    /// </summary>
    internal sealed class GraphPropertyAttribute : PropertyAttribute
    {
        internal GraphPropertyAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        /// <summary>
        /// Is this property an expandable property?
        /// </summary>
        public bool Expandable { get; set; }

        /// <summary>
        /// Model property to define that a property can only be handled using the Microsoft Graph beta endpoint
        /// </summary>
        public bool Beta { get; set; }

        /// <summary>
        /// Url to get this field, needed in case the field cannot be loaded via an expand
        /// </summary>
        public string Get { get; set; }
    }
}
