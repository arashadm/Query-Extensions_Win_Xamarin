﻿using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace QueryExtensions
{

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class QueryParameterAttribute : Attribute
    {

        public QueryParameterAttribute ( String name)
        {
            Name = name;
        }

        public String ToParameter ( Object value )
        {
            return "";
        }


        /// <summary>
        /// Gets or sets the name of the property. If this is null, Property Name will be used.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Format used will calling ToString() on related value.
        /// </summary>
        public String Format { get; set; }

        /// <summary>
        /// Used with formating,
        /// Default is InvariantCulture
        /// </summary>
        public CultureInfo Culture { get; set; }

        /// <summary>
        /// A value of true will include the key= even if the value is null or empty
        /// </summary>
        public bool AllowEmpty { get; set; }

    }
}
