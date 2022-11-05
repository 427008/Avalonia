﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace Avalonia.Media;

/// <summary>
/// Creates a <see cref="Color"/> from a string representation.
/// </summary>
public class ColorConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType == typeof(string);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
    {
        return value is string s ? Color.Parse(s) : null;
    }
}
