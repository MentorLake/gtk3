namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkColor is used to describe a color,
/// similar to the XColor struct used in the X11 drawing API.
/// </para>
/// </summary>

public class GdkColorHandle : BaseSafeHandle
{
}


public static class GdkColorExtensions
{
/// <summary>
/// <para>
/// Makes a copy of a #GdkColor.
/// </para>
/// <para>
/// The result must be freed using gdk_color_free().
/// </para>
/// </summary>

/// <param name="color">
/// a #GdkColor
/// </param>
/// <return>
/// a copy of @color
/// </return>

	public static MentorLake.Gdk.GdkColorHandle Copy(this MentorLake.Gdk.GdkColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GdkColor)");
		return GdkColorExterns.gdk_color_copy(color);
	}

/// <summary>
/// <para>
/// Compares two colors.
/// </para>
/// </summary>

/// <param name="colora">
/// a #GdkColor
/// </param>
/// <param name="colorb">
/// another #GdkColor
/// </param>
/// <return>
/// %TRUE if the two colors compare equal
/// </return>

	public static bool Equal(this MentorLake.Gdk.GdkColorHandle colora, MentorLake.Gdk.GdkColorHandle colorb)
	{
		if (colora.IsInvalid) throw new Exception("Invalid handle (GdkColor)");
		return GdkColorExterns.gdk_color_equal(colora, colorb);
	}

/// <summary>
/// <para>
/// Frees a #GdkColor created with gdk_color_copy().
/// </para>
/// </summary>

/// <param name="color">
/// a #GdkColor
/// </param>

	public static void Free(this MentorLake.Gdk.GdkColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GdkColor)");
		GdkColorExterns.gdk_color_free(color);
	}

/// <summary>
/// <para>
/// A hash function suitable for using for a hash
/// table that stores #GdkColors.
/// </para>
/// </summary>

/// <param name="color">
/// a #GdkColor
/// </param>
/// <return>
/// The hash function applied to @color
/// </return>

	public static uint Hash(this MentorLake.Gdk.GdkColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GdkColor)");
		return GdkColorExterns.gdk_color_hash(color);
	}

/// <summary>
/// <para>
/// Returns a textual specification of @color in the hexadecimal
/// form “\#rrrrggggbbbb” where “r”, “g” and “b” are hex digits
/// representing the red, green and blue components respectively.
/// </para>
/// <para>
/// The returned string can be parsed by gdk_color_parse().
/// </para>
/// </summary>

/// <param name="color">
/// a #GdkColor
/// </param>
/// <return>
/// a newly-allocated text string
/// </return>

	public static string ToString(this MentorLake.Gdk.GdkColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GdkColor)");
		return GdkColorExterns.gdk_color_to_string(color);
	}


	public static GdkColor Dereference(this GdkColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkColor>(x.DangerousGetHandle());
}
internal class GdkColorExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))]
	internal static extern MentorLake.Gdk.GdkColorHandle gdk_color_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_color_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle colora, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle colorb);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_color_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_color_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_color_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_color_parse(string spec, out MentorLake.Gdk.GdkColor color);

}

/// <summary>
/// <para>
/// A #GdkColor is used to describe a color,
/// similar to the XColor struct used in the X11 drawing API.
/// </para>
/// </summary>

public struct GdkColor
{
	/// <summary>
/// <para>
/// For allocated colors, the pixel value used to
///     draw this color on the screen. Not used anymore.
/// </para>
/// </summary>

public uint pixel;
	/// <summary>
/// <para>
/// The red component of the color. This is
///     a value between 0 and 65535, with 65535 indicating
///     full intensity
/// </para>
/// </summary>

public ushort red;
	/// <summary>
/// <para>
/// The green component of the color
/// </para>
/// </summary>

public ushort green;
	/// <summary>
/// <para>
/// The blue component of the color
/// </para>
/// </summary>

public ushort blue;
/// <summary>
/// <para>
/// Parses a textual specification of a color and fill in the
/// @red, @green, and @blue fields of a #GdkColor.
/// </para>
/// <para>
/// The string can either one of a large set of standard names
/// (taken from the X11 `rgb.txt` file), or it can be a hexadecimal
/// value in the form “\#rgb” “\#rrggbb”, “\#rrrgggbbb” or
/// “\#rrrrggggbbbb” where “r”, “g” and “b” are hex digits of
/// the red, green, and blue components of the color, respectively.
/// (White in the four forms is “\#fff”, “\#ffffff”, “\#fffffffff”
/// and “\#ffffffffffff”).
/// </para>
/// </summary>

/// <param name="spec">
/// the string specifying the color
/// </param>
/// <param name="color">
/// the #GdkColor to fill in
/// </param>
/// <return>
/// %TRUE if the parsing succeeded
/// </return>

	public static bool Parse(string spec, out MentorLake.Gdk.GdkColor color)
	{
		return GdkColorExterns.gdk_color_parse(spec, out color);
	}

}
