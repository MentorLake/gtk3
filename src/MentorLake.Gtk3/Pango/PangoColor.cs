namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoColor` structure is used to
/// represent a color in an uncalibrated RGB color-space.
/// </para>
/// </summary>

public class PangoColorHandle : BaseSafeHandle
{
}


public static class PangoColorExtensions
{
/// <summary>
/// <para>
/// Creates a copy of @src.
/// </para>
/// <para>
/// The copy should be freed with [method@Pango.Color.free].
/// Primarily used by language bindings, not that useful
/// otherwise (since colors can just be copied by assignment
/// in C).
/// </para>
/// </summary>

/// <param name="src">
/// color to copy
/// </param>
/// <return>
/// the newly allocated `PangoColor`,
///   which should be freed with [method@Pango.Color.free]
/// </return>

	public static MentorLake.Pango.PangoColorHandle Copy(this MentorLake.Pango.PangoColorHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (PangoColor)");
		return PangoColorExterns.pango_color_copy(src);
	}

/// <summary>
/// <para>
/// Frees a color allocated by [method@Pango.Color.copy].
/// </para>
/// </summary>

/// <param name="color">
/// an allocated `PangoColor`
/// </param>

	public static void Free(this MentorLake.Pango.PangoColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (PangoColor)");
		PangoColorExterns.pango_color_free(color);
	}

/// <summary>
/// <para>
/// Fill in the fields of a color from a string specification.
/// </para>
/// <para>
/// The string can either one of a large set of standard names.
/// (Taken from the CSS Color [specification](https://www.w3.org/TR/css-color-4/#named-colors),
/// or it can be a value in the form `#rgb`, `#rrggbb`,
/// `#rrrgggbbb` or `#rrrrggggbbbb`, where `r`, `g` and `b`
/// are hex digits of the red, green, and blue components
/// of the color, respectively. (White in the four forms is
/// `#fff`, `#ffffff`, `#fffffffff` and `#ffffffffffff`.)
/// </para>
/// </summary>

/// <param name="color">
/// a `PangoColor` structure in which
///   to store the result
/// </param>
/// <param name="spec">
/// a string specifying the new color
/// </param>
/// <return>
/// %TRUE if parsing of the specifier succeeded,
///   otherwise %FALSE
/// </return>

	public static bool Parse(this MentorLake.Pango.PangoColorHandle color, string spec)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (PangoColor)");
		return PangoColorExterns.pango_color_parse(color, spec);
	}

/// <summary>
/// <para>
/// Fill in the fields of a color from a string specification.
/// </para>
/// <para>
/// The string can either one of a large set of standard names.
/// (Taken from the CSS Color [specification](https://www.w3.org/TR/css-color-4/#named-colors),
/// or it can be a hexadecimal value in the form `#rgb`,
/// `#rrggbb`, `#rrrgggbbb` or `#rrrrggggbbbb` where `r`, `g`
/// and `b` are hex digits of the red, green, and blue components
/// of the color, respectively. (White in the four forms is
/// `#fff`, `#ffffff`, `#fffffffff` and `#ffffffffffff`.)
/// </para>
/// <para>
/// Additionally, parse strings of the form `#rgba`, `#rrggbbaa`,
/// `#rrrrggggbbbbaaaa`, if @alpha is not %NULL, and set @alpha
/// to the value specified by the hex digits for `a`. If no alpha
/// component is found in @spec, @alpha is set to 0xffff (for a
/// solid color).
/// </para>
/// </summary>

/// <param name="color">
/// a `PangoColor` structure in which
///   to store the result
/// </param>
/// <param name="alpha">
/// return location for alpha
/// </param>
/// <param name="spec">
/// a string specifying the new color
/// </param>
/// <return>
/// %TRUE if parsing of the specifier succeeded,
///   otherwise %FALSE
/// </return>

	public static bool ParseWithAlpha(this MentorLake.Pango.PangoColorHandle color, out ushort alpha, string spec)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (PangoColor)");
		return PangoColorExterns.pango_color_parse_with_alpha(color, out alpha, spec);
	}

/// <summary>
/// <para>
/// Returns a textual specification of @color.
/// </para>
/// <para>
/// The string is in the hexadecimal form `#rrrrggggbbbb`,
/// where `r`, `g` and `b` are hex digits representing the
/// red, green, and blue components respectively.
/// </para>
/// </summary>

/// <param name="color">
/// a `PangoColor`
/// </param>
/// <return>
/// a newly-allocated text string that must
///   be freed with g_free().
/// </return>

	public static string ToString(this MentorLake.Pango.PangoColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (PangoColor)");
		return PangoColorExterns.pango_color_to_string(color);
	}


	public static PangoColor Dereference(this PangoColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoColor>(x.DangerousGetHandle());
}
internal class PangoColorExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))]
	internal static extern MentorLake.Pango.PangoColorHandle pango_color_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle src);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_color_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_color_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color, string spec);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_color_parse_with_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color, out ushort alpha, string spec);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_color_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color);

}

/// <summary>
/// <para>
/// The `PangoColor` structure is used to
/// represent a color in an uncalibrated RGB color-space.
/// </para>
/// </summary>

public struct PangoColor
{
	/// <summary>
/// <para>
/// value of red component
/// </para>
/// </summary>

public ushort red;
	/// <summary>
/// <para>
/// value of green component
/// </para>
/// </summary>

public ushort green;
	/// <summary>
/// <para>
/// value of blue component
/// </para>
/// </summary>

public ushort blue;
}
