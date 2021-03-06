﻿using System;
using System.IO;

namespace Sorschia.Data
{
    /// <summary>
    /// Exposes methods that convert a database value to another type
    /// </summary>
    public static class DbValueConverter
    {
        private static T Convert<T>(object value, Func<object, T, T> convert, T valueIfDefault = default(T))
        {
            return value == DBNull.Value ? default(T) : convert(value, valueIfDefault);
        }

        private static T Convert<T>(object value, Func<object, IFormatProvider, T, T> convert, IFormatProvider formatProvider, T valueIfDefault = default(T))
        {
            return value == DBNull.Value ? default(T) : convert(value, formatProvider, valueIfDefault);
        }

        public static bool ToBoolean(object value, bool valueIfDefault = default(bool))
        {
            return Convert(value, ValueConverter.ToBoolean, valueIfDefault);
        }

        public static bool ToBoolean(object value, IFormatProvider formatProvider, bool valueIfDefault = default(bool))
        {
            return Convert(value, ValueConverter.ToBoolean, formatProvider, valueIfDefault);
        }

        public static byte ToByte(object value, byte valueIfDefault = default(byte))
        {
            return Convert(value, ValueConverter.ToByte, valueIfDefault);
        }

        public static byte ToByte(object value, IFormatProvider formatProvider, byte valueIfDefault = default(byte))
        {
            return Convert(value, ValueConverter.ToByte, formatProvider, valueIfDefault);
        }

        public static byte[] ToByteArray(object value, byte[] valueIfDefault = default(byte[]))
        {
            return Convert(value, ValueConverter.ToByteArray, valueIfDefault);
        }

        public static char ToChar(object value, char valueIfDefault = default(char))
        {
            return Convert(value, ValueConverter.ToChar, valueIfDefault);
        }

        public static char ToChar(object value, IFormatProvider formatProvider, char valueIfDefault = default(char))
        {
            return Convert(value, ValueConverter.ToChar, formatProvider, valueIfDefault);
        }

        public static DateTime ToDateTime(object value, DateTime valueIfDefault = default(DateTime))
        {
            return Convert(value, ValueConverter.ToDateTime, valueIfDefault);
        }

        public static DateTime ToDateTime(object value, IFormatProvider formatProvider, DateTime valueIfDefault = default(DateTime))
        {
            return Convert(value, ValueConverter.ToDateTime, formatProvider, valueIfDefault);
        }

        public static decimal ToDecimal(object value, decimal valueIfDefault = default(decimal))
        {
            return Convert(value, ValueConverter.ToDecimal, valueIfDefault);
        }

        public static decimal ToDecimal(object value, IFormatProvider formatProvider, decimal valueIfDefault = default(decimal))
        {
            return Convert(value, ValueConverter.ToDecimal, formatProvider, valueIfDefault);
        }

        public static double ToDouble(object value, double valueIfDefault = default(double))
        {
            return Convert(value, ValueConverter.ToDouble, valueIfDefault);
        }

        public static double ToDouble(object value, IFormatProvider formatProvider, double valueIfDefault = default(double))
        {
            return Convert(value, ValueConverter.ToDouble, formatProvider, valueIfDefault);
        }

        public static Guid ToGuid(object value, Guid valueIfDefault = default(Guid))
        {
            return Convert(value, ValueConverter.ToGuid, valueIfDefault);
        }

        public static short ToInt16(object value, short valueIfDefault = default(short))
        {
            return Convert(value, ValueConverter.ToInt16, valueIfDefault);
        }

        public static short ToInt16(object value, IFormatProvider formatProvider, short valueIfDefault = default(short))
        {
            return Convert(value, ValueConverter.ToInt16, formatProvider, valueIfDefault);
        }

        public static int ToInt32(object value, int valueIfDefault = default(int))
        {
            return Convert(value, ValueConverter.ToInt32, valueIfDefault);
        }

        public static int ToInt32(object value, IFormatProvider formatProvider, int valueIfDefault = default(int))
        {
            return Convert(value, ValueConverter.ToInt32, formatProvider, valueIfDefault);
        }

        public static long ToInt64(object value, long valueIfDefault = default(long))
        {
            return Convert(value, ValueConverter.ToInt64, valueIfDefault);
        }

        public static long ToInt64(object value, IFormatProvider formatProvider, long valueIfDefault = default(long))
        {
            return Convert(value, ValueConverter.ToInt64, formatProvider, valueIfDefault);
        }

        public static bool? ToNullableBoolean(object value, bool? valueIfDefault = default(bool?))
        {
            return Convert(value, ValueConverter.ToNullableBoolean, valueIfDefault);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider, bool? valueIfDefault = default(bool?))
        {
            return Convert(value, ValueConverter.ToNullableBoolean, formatProvider, valueIfDefault);
        }

        public static byte? ToNullableByte(object value, byte? valueIfDefault = default(byte?))
        {
            return Convert(value, ValueConverter.ToNullableByte, valueIfDefault);
        }

        public static byte? ToNullableByte(object value, IFormatProvider formatProvider, byte? valueIfDefault = default(byte?))
        {
            return Convert(value, ValueConverter.ToNullableByte, formatProvider, valueIfDefault);
        }

        public static char? ToNullableChar(object value, char? valueIfDefault = default(char?))
        {
            return Convert(value, ValueConverter.ToNullableChar, valueIfDefault);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider, char? valueIfDefault = default(char?))
        {
            return Convert(value, ValueConverter.ToNullableChar, formatProvider, valueIfDefault);
        }

        public static DateTime? ToNullableDateTime(object value, DateTime? valueIfDefault = default(DateTime?))
        {
            return Convert(value, ValueConverter.ToNullableDateTime, valueIfDefault);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider, DateTime? valueIfDefault = default(DateTime?))
        {
            return Convert(value, ValueConverter.ToNullableDateTime, formatProvider, valueIfDefault);
        }

        public static decimal? ToNullableDecimal(object value, decimal? valueIfDefault = default(decimal?))
        {
            return Convert(value, ValueConverter.ToNullableDecimal, valueIfDefault);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider, decimal? valueIfDefault = default(decimal?))
        {
            return Convert(value, ValueConverter.ToNullableDecimal, formatProvider, valueIfDefault);
        }

        public static double? ToNullableDouble(object value, double? valueIfDefault = default(double?))
        {
            return Convert(value, ValueConverter.ToNullableDouble, valueIfDefault);
        }

        public static double? ToNullableDouble(object value, IFormatProvider formatProvider, double? valueIfDefault = default(double?))
        {
            return Convert(value, ValueConverter.ToNullableDouble, formatProvider, valueIfDefault);
        }

        public static Guid? ToNullableGuid(object value, Guid? valueIfDefault = default(Guid?))
        {
            return Convert(value, ValueConverter.ToNullableGuid, valueIfDefault);
        }

        public static short? ToNullableInt16(object value, short? valueIfDefault = default(short?))
        {
            return Convert(value, ValueConverter.ToNullableInt16, valueIfDefault);
        }

        public static short? ToNullableInt16(object value, IFormatProvider formatProvider, short? valueIfDefault = default(short?))
        {
            return Convert(value, ValueConverter.ToNullableInt16, formatProvider, valueIfDefault);
        }

        public static int? ToNullableInt32(object value, int? valueIfDefault = default(int?))
        {
            return Convert(value, ValueConverter.ToNullableInt32, valueIfDefault);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider, int? valueIfDefault = default(int?))
        {
            return Convert(value, ValueConverter.ToNullableInt32, formatProvider, valueIfDefault);
        }

        public static long? ToNullableInt64(object value, long? valueIfDefault = default(long?))
        {
            return Convert(value, ValueConverter.ToNullableInt64, valueIfDefault);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider, long? valueIfDefault = default(long?))
        {
            return Convert(value, ValueConverter.ToNullableInt64, formatProvider, valueIfDefault);
        }

        public static sbyte? ToNullableSByte(object value, sbyte? valueIfDefault = default(sbyte?))
        {
            return Convert(value, ValueConverter.ToNullableSByte, valueIfDefault);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider, sbyte? valueIfDefault = default(sbyte?))
        {
            return Convert(value, ValueConverter.ToNullableSByte, formatProvider, valueIfDefault);
        }

        public static float? ToNullableSingle(object value, float? valueIfDefault = default(float?))
        {
            return Convert(value, ValueConverter.ToNullableSingle, valueIfDefault);
        }

        public static float? ToNullableSingle(object value, IFormatProvider formatProvider, float? valueIfDefault = default(float?))
        {
            return Convert(value, ValueConverter.ToNullableSingle, formatProvider, valueIfDefault);
        }

        public static TimeSpan? ToNullableTimeSpan(object value, TimeSpan? valueIfDefault = default(TimeSpan?))
        {
            return Convert(value, ValueConverter.ToNullableTimeSpan, valueIfDefault);
        }

        public static TimeSpan? ToNullableTimeSpan(object value, IFormatProvider formatProvider, TimeSpan? valueIfDefault = default(TimeSpan?))
        {
            return Convert(value, ValueConverter.ToNullableTimeSpan, formatProvider, valueIfDefault);
        }

        public static ushort? ToNullableUInt16(object value, ushort? valueIfDefault = default(ushort?))
        {
            return Convert(value, ValueConverter.ToNullableUInt16, valueIfDefault);
        }

        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider, ushort? valueIfDefault = default(ushort?))
        {
            return Convert(value, ValueConverter.ToNullableUInt16, formatProvider, valueIfDefault);
        }

        public static uint? ToNullableUInt32(object value, uint? valueIfDefault = default(uint?))
        {
            return Convert(value, ValueConverter.ToNullableUInt32, valueIfDefault);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider, uint? valueIfDefault = default(uint?))
        {
            return Convert(value, ValueConverter.ToNullableUInt32, formatProvider, valueIfDefault);
        }

        public static ulong? ToNullableUInt64(object value, ulong? valueIfDefault = default(ulong?))
        {
            return Convert(value, ValueConverter.ToNullableUInt64, valueIfDefault);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider, ulong? valueIfDefault = default(ulong?))
        {
            return Convert(value, ValueConverter.ToNullableUInt64, formatProvider, valueIfDefault);
        }

        public static sbyte ToSByte(object value, sbyte valueIfDefault = default(sbyte))
        {
            return Convert(value, ValueConverter.ToSByte, valueIfDefault);
        }

        public static sbyte ToSByte(object value, IFormatProvider formatProvider, sbyte valueIfDefault = default(sbyte))
        {
            return Convert(value, ValueConverter.ToSByte, formatProvider, valueIfDefault);
        }

        public static float ToSingle(object value, float valueIfDefault = default(float))
        {
            return Convert(value, ValueConverter.ToSingle, valueIfDefault);
        }

        public static float ToSingle(object value, IFormatProvider formatProvider, float valueIfDefault = default(float))
        {
            return Convert(value, ValueConverter.ToSingle, formatProvider, valueIfDefault);
        }

        public static Stream ToStream(object value, Stream valueIfDefault = default(Stream))
        {
            return Convert(value, ValueConverter.ToStream, valueIfDefault);
        }

        public static string ToString(object value, string valueIfDefault = default(string))
        {
            return Convert(value, ValueConverter.ToString, valueIfDefault);
        }

        public static string ToString(object value, IFormatProvider formatProvider, string valueIfDefault = default(string))
        {
            return Convert(value, ValueConverter.ToString, formatProvider, valueIfDefault);
        }

        public static TimeSpan ToTimeSpan(object value, TimeSpan valueIfDefault = default(TimeSpan))
        {
            return Convert(value, ValueConverter.ToTimeSpan, valueIfDefault);
        }

        public static TimeSpan ToTimeSpan(object value, IFormatProvider formatProvider, TimeSpan valueIfDefault = default(TimeSpan))
        {
            return Convert(value, ValueConverter.ToTimeSpan, formatProvider, valueIfDefault);
        }

        public static ushort ToUInt16(object value, ushort valueIfDefault = default(ushort))
        {
            return Convert(value, ValueConverter.ToUInt16, valueIfDefault);
        }

        public static ushort ToUInt16(object value, IFormatProvider formatProvider, ushort valueIfDefault = default(ushort))
        {
            return Convert(value, ValueConverter.ToUInt16, formatProvider, valueIfDefault);
        }

        public static uint ToUInt32(object value, uint valueIfDefault = default(uint))
        {
            return Convert(value, ValueConverter.ToUInt32, valueIfDefault);
        }

        public static uint ToUInt32(object value, IFormatProvider formatProvider, uint valueIfDefault = default(uint))
        {
            return Convert(value, ValueConverter.ToUInt32, formatProvider, valueIfDefault);
        }

        public static ulong ToUInt64(object value, ulong valueIfDefault = default(ulong))
        {
            return Convert(value, ValueConverter.ToUInt64, valueIfDefault);
        }

        public static ulong ToUInt64(object value, IFormatProvider formatProvider, ulong valueIfDefault = default(ulong))
        {
            return Convert(value, ValueConverter.ToUInt64, formatProvider, valueIfDefault);
        }
    }
}
