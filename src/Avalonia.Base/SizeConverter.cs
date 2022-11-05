﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace Avalonia;

/// <summary>
/// Creates a <see cref="Size"/> from a string representation.
/// </summary>
public class SizeConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType == typeof(string);
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
    {
        return value is string s ? Size.Parse(s) : null;
    }
}
