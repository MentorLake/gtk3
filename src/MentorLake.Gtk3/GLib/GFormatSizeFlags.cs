namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags to modify the format of the string returned by g_format_size_full().
/// </para>
/// </summary>

[Flags]
public enum GFormatSizeFlags : uint
{
/// <summary>
/// <para>
/// behave the same as g_format_size()
/// </para>
/// </summary>

	G_FORMAT_SIZE_DEFAULT = 0,
/// <summary>
/// <para>
/// include the exact number of bytes as part
///     of the returned string.  For example, &quot;45.6 kB (45,612 bytes)&quot;.
/// </para>
/// </summary>

	G_FORMAT_SIZE_LONG_FORMAT = 1,
/// <summary>
/// <para>
/// use IEC (base 1024) units with &quot;KiB&quot;-style
///     suffixes. IEC units should only be used for reporting things with
///     a strong &quot;power of 2&quot; basis, like RAM sizes or RAID stripe sizes.
///     Network and storage sizes should be reported in the normal SI units.
/// </para>
/// </summary>

	G_FORMAT_SIZE_IEC_UNITS = 2,
/// <summary>
/// <para>
/// set the size as a quantity in bits, rather than
///     bytes, and return units in bits. For example, ‘Mbit’ rather than ‘MB’.
/// </para>
/// </summary>

	G_FORMAT_SIZE_BITS = 4,
/// <summary>
/// <para>
/// return only value, without unit; this should
///     not be used together with @G_FORMAT_SIZE_LONG_FORMAT
///     nor @G_FORMAT_SIZE_ONLY_UNIT. Since: 2.74
/// </para>
/// </summary>

	G_FORMAT_SIZE_ONLY_VALUE = 8,
/// <summary>
/// <para>
/// return only unit, without value; this should
///     not be used together with @G_FORMAT_SIZE_LONG_FORMAT
///     nor @G_FORMAT_SIZE_ONLY_VALUE. Since: 2.74
/// </para>
/// </summary>

	G_FORMAT_SIZE_ONLY_UNIT = 16
}
