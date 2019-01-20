﻿#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
#endregion

namespace Delight
{
    /// <summary>
    /// Helper class for value converters.
    /// </summary>
    public class ValueConverters
    {
        #region Fields

        public static Dictionary<string, ValueConverter> Converters;
                   
        #endregion

        #region Methods

        /// <summary>
        /// Gets initializer from type name and string value.
        /// </summary>
        public static string GetInitializer(string typeName, string stringValue)
        {
            ValueConverter valueConverter;
            if (!Converters.TryGetValue(typeName, out valueConverter))
            {
                return null;
            }

            try
            {
                return valueConverter.GetInitializer(stringValue);
            }
            catch
            {
                return null;
            }
        }        

        #endregion

        #region Constructor

        static ValueConverters()
        {
            Converters = new Dictionary<string, ValueConverter>();
            Converters.Add("string", new StringValueConverter());
            Converters.Add("System.String", new StringValueConverter());
            Converters.Add("int", new IntValueConverter());
            Converters.Add("System.Int32", new IntValueConverter());            
            Converters.Add("bool", new BoolValueConverter());
            Converters.Add("System.Boolean", new BoolValueConverter());
            Converters.Add("float", new FloatValueConverter());
            Converters.Add("System.Single", new FloatValueConverter());
            Converters.Add("UnityEngine.Color", new ColorValueConverter());
            Converters.Add("Delight.ElementSize", new ElementSizeValueConverter());
            Converters.Add("Delight.ElementMargin", new ElementMarginValueConverter());
            Converters.Add("UnityEngine.Vector2", new Vector2ValueConverter());
            Converters.Add("UnityEngine.Vector3", new Vector3ValueConverter());
            Converters.Add("UnityEngine.Vector4", new Vector4ValueConverter());
            Converters.Add("Delight.ElementAlignment", new EnumValueConverter<ElementAlignment>());
            Converters.Add("Delight.ElementOrientation", new EnumValueConverter<ElementOrientation>());
            Converters.Add("UnityEngine.RenderMode", new EnumValueConverter<UnityEngine.RenderMode>());
            Converters.Add("TMPro.TextAlignmentOptions", new EnumValueConverter<TMPro.TextAlignmentOptions>());
        }

        #endregion
    }
}