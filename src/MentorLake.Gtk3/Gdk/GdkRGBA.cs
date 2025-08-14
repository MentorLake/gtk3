namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkRGBA is used to represent a (possibly translucent)
/// color, in a way that is compatible with cairo’s notion of color.
/// </para>
/// </summary>

public class GdkRGBAHandle : BaseSafeHandle
{
}


public static class GdkRGBAExtensions
{
/// <summary>
/// <para>
/// Makes a copy of a #GdkRGBA.
/// </para>
/// <para>
/// The result must be freed through gdk_rgba_free().
/// </para>
/// </summary>

/// <param name="rgba">
/// a #GdkRGBA
/// </param>
/// <return>
/// A newly allocated #GdkRGBA, with the same contents as @rgba
/// </return>

	public static MentorLake.Gdk.GdkRGBAHandle Copy(this MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (rgba.IsInvalid) throw new Exception("Invalid handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_copy(rgba);
	}

/// <summary>
/// <para>
/// Compares two RGBA colors.
/// </para>
/// </summary>

/// <param name="p1">
/// a #GdkRGBA pointer
/// </param>
/// <param name="p2">
/// another #GdkRGBA pointer
/// </param>
/// <return>
/// %TRUE if the two colors compare equal
/// </return>

	public static bool Equal(this MentorLake.Gdk.GdkRGBAHandle p1, MentorLake.Gdk.GdkRGBAHandle p2)
	{
		if (p1.IsInvalid) throw new Exception("Invalid handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_equal(p1, p2);
	}

/// <summary>
/// <para>
/// Frees a #GdkRGBA created with gdk_rgba_copy()
/// </para>
/// </summary>

/// <param name="rgba">
/// a #GdkRGBA
/// </param>

	public static void Free(this MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (rgba.IsInvalid) throw new Exception("Invalid handle (GdkRGBA)");
		GdkRGBAExterns.gdk_rgba_free(rgba);
	}

/// <summary>
/// <para>
/// A hash function suitable for using for a hash
/// table that stores #GdkRGBAs.
/// </para>
/// </summary>

/// <param name="p">
/// a #GdkRGBA pointer
/// </param>
/// <return>
/// The hash value for @p
/// </return>

	public static uint Hash(this MentorLake.Gdk.GdkRGBAHandle p)
	{
		if (p.IsInvalid) throw new Exception("Invalid handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_hash(p);
	}

/// <summary>
/// <para>
/// Parses a textual representation of a color, filling in
/// the @red, @green, @blue and @alpha fields of the @rgba #GdkRGBA.
/// </para>
/// <para>
/// The string can be either one of:
/// - A standard name (Taken from the X11 rgb.txt file).
/// - A hexadecimal value in the form “\#rgb”, “\#rrggbb”,
///   “\#rrrgggbbb” or ”\#rrrrggggbbbb”
/// - A RGB color in the form “rgb(r,g,b)” (In this case the color will
///   have full opacity)
/// - A RGBA color in the form “rgba(r,g,b,a)”
/// </para>
/// <para>
/// Where “r”, “g”, “b” and “a” are respectively the red, green, blue and
/// alpha color values. In the last two cases, “r”, “g”, and “b” are either integers
/// in the range 0 to 255 or percentage values in the range 0% to 100%, and
/// a is a floating point value in the range 0 to 1.
/// </para>
/// </summary>

/// <param name="rgba">
/// the #GdkRGBA to fill in
/// </param>
/// <param name="spec">
/// the string specifying the color
/// </param>
/// <return>
/// %TRUE if the parsing succeeded
/// </return>

	public static bool Parse(this MentorLake.Gdk.GdkRGBAHandle rgba, string spec)
	{
		if (rgba.IsInvalid) throw new Exception("Invalid handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_parse(rgba, spec);
	}

/// <summary>
/// <para>
/// Returns a textual specification of @rgba in the form
/// `rgb(r,g,b)` or
/// `rgba(r g,b,a)`,
/// where “r”, “g”, “b” and “a” represent the red, green,
/// blue and alpha values respectively. “r”, “g”, and “b” are
/// represented as integers in the range 0 to 255, and “a”
/// is represented as a floating point value in the range 0 to 1.
/// </para>
/// <para>
/// These string forms are string forms that are supported by
/// the CSS3 colors module, and can be parsed by gdk_rgba_parse().
/// </para>
/// <para>
/// Note that this string representation may lose some
/// precision, since “r”, “g” and “b” are represented as 8-bit
/// integers. If this is a concern, you should use a
/// different representation.
/// </para>
/// </summary>

/// <param name="rgba">
/// a #GdkRGBA
/// </param>
/// <return>
/// A newly allocated text string
/// </return>

	public static string ToString(this MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (rgba.IsInvalid) throw new Exception("Invalid handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_to_string(rgba);
	}


	public static GdkRGBA Dereference(this GdkRGBAHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkRGBA>(x.DangerousGetHandle());
}
internal class GdkRGBAExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))]
	internal static extern MentorLake.Gdk.GdkRGBAHandle gdk_rgba_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rgba_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle p1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle p2);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_rgba_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_rgba_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle p);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rgba_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba, string spec);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_rgba_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

}

/// <summary>
/// <para>
/// A #GdkRGBA is used to represent a (possibly translucent)
/// color, in a way that is compatible with cairo’s notion of color.
/// </para>
/// </summary>

public struct GdkRGBA
{
	/// <summary>
/// <para>
/// The intensity of the red channel from 0.0 to 1.0 inclusive
/// </para>
/// </summary>

public double red;
	/// <summary>
/// <para>
/// The intensity of the green channel from 0.0 to 1.0 inclusive
/// </para>
/// </summary>

public double green;
	/// <summary>
/// <para>
/// The intensity of the blue channel from 0.0 to 1.0 inclusive
/// </para>
/// </summary>

public double blue;
	/// <summary>
/// <para>
/// The opacity of the color from 0.0 for completely translucent to
///   1.0 for opaque
/// </para>
/// </summary>

public double alpha;
}
