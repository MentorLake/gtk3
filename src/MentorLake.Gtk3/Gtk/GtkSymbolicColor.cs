namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkSymbolicColor is a boxed type that represents a symbolic color.
/// It is the result of parsing a
/// [color expression][gtkcssprovider-symbolic-colors].
/// To obtain the color represented by a GtkSymbolicColor, it has to
/// be resolved with gtk_symbolic_color_resolve(), which replaces all
/// symbolic color references by the colors they refer to (in a given
/// context) and evaluates mix, shade and other expressions, resulting
/// in a #GdkRGBA value.
/// </para>
/// <para>
/// It is not normally necessary to deal directly with #GtkSymbolicColors,
/// since they are mostly used behind the scenes by #GtkStyleContext and
/// #GtkCssProvider.
/// </para>
/// <para>
/// #GtkSymbolicColor is deprecated. Symbolic colors are considered an
/// implementation detail of GTK+.
/// </para>
/// </summary>

public class GtkSymbolicColorHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a symbolic color by modifying the relative alpha
/// value of @color. A factor < 1.0 would resolve to a more
/// transparent color, while > 1.0 would resolve to a more
/// opaque color.
/// </para>
/// </summary>

/// <param name="color">
/// another #GtkSymbolicColor
/// </param>
/// <param name="factor">
/// factor to apply to @color alpha
/// </param>
/// <return>
/// A newly created #GtkSymbolicColor
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewAlpha(MentorLake.Gtk.GtkSymbolicColorHandle color, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_alpha(color, factor);
	}

/// <summary>
/// <para>
/// Creates a symbolic color pointing to a literal color.
/// </para>
/// </summary>

/// <param name="color">
/// a #GdkRGBA
/// </param>
/// <return>
/// a newly created #GtkSymbolicColor
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewLiteral(MentorLake.Gdk.GdkRGBAHandle color)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_literal(color);
	}

/// <summary>
/// <para>
/// Creates a symbolic color defined as a mix of another
/// two colors. a mix factor of 0 would resolve to @color1,
/// while a factor of 1 would resolve to @color2.
/// </para>
/// </summary>

/// <param name="color1">
/// color to mix
/// </param>
/// <param name="color2">
/// another color to mix
/// </param>
/// <param name="factor">
/// mix factor
/// </param>
/// <return>
/// A newly created #GtkSymbolicColor
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewMix(MentorLake.Gtk.GtkSymbolicColorHandle color1, MentorLake.Gtk.GtkSymbolicColorHandle color2, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_mix(color1, color2, factor);
	}

/// <summary>
/// <para>
/// Creates a symbolic color pointing to an unresolved named
/// color. See gtk_style_context_lookup_color() and
/// gtk_style_properties_lookup_color().
/// </para>
/// </summary>

/// <param name="name">
/// color name
/// </param>
/// <return>
/// a newly created #GtkSymbolicColor
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewName(string name)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_name(name);
	}

/// <summary>
/// <para>
/// Creates a symbolic color defined as a shade of
/// another color. A factor > 1.0 would resolve to
/// a brighter color, while < 1.0 would resolve to
/// a darker color.
/// </para>
/// </summary>

/// <param name="color">
/// another #GtkSymbolicColor
/// </param>
/// <param name="factor">
/// shading factor to apply to @color
/// </param>
/// <return>
/// A newly created #GtkSymbolicColor
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewShade(MentorLake.Gtk.GtkSymbolicColorHandle color, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_shade(color, factor);
	}

/// <summary>
/// <para>
/// Creates a symbolic color based on the current win32
/// theme.
/// </para>
/// <para>
/// Note that while this call is available on all platforms
/// the actual value returned is not reliable on non-win32
/// platforms.
/// </para>
/// </summary>

/// <param name="theme_class">
/// The theme class to pull color from
/// </param>
/// <param name="id">
/// The color id
/// </param>
/// <return>
/// A newly created #GtkSymbolicColor
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewWin32(string theme_class, int id)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_win32(theme_class, id);
	}

}


public static class GtkSymbolicColorExtensions
{
/// <summary>
/// <para>
/// Increases the reference count of @color
/// </para>
/// </summary>

/// <param name="color">
/// a #GtkSymbolicColor
/// </param>
/// <return>
/// the same @color
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle Ref(this MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		return GtkSymbolicColorExterns.gtk_symbolic_color_ref(color);
	}

/// <summary>
/// <para>
/// If @color is resolvable, @resolved_color will be filled in
/// with the resolved color, and %TRUE will be returned. Generally,
/// if @color can’t be resolved, it is due to it being defined on
/// top of a named color that doesn’t exist in @props.
/// </para>
/// <para>
/// When @props is %NULL, resolving of named colors will fail, so if
/// your @color is or references such a color, this function will
/// return %FALSE.
/// </para>
/// </summary>

/// <param name="color">
/// a #GtkSymbolicColor
/// </param>
/// <param name="props">
/// #GtkStyleProperties to use when resolving
///    named colors, or %NULL
/// </param>
/// <param name="resolved_color">
/// return location for the resolved color
/// </param>
/// <return>
/// %TRUE if the color has been resolved
/// </return>

	public static bool Resolve(this MentorLake.Gtk.GtkSymbolicColorHandle color, MentorLake.Gtk.GtkStylePropertiesHandle props, out MentorLake.Gdk.GdkRGBA resolved_color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		return GtkSymbolicColorExterns.gtk_symbolic_color_resolve(color, props, out resolved_color);
	}

/// <summary>
/// <para>
/// Converts the given @color to a string representation. This is useful
/// both for debugging and for serialization of strings. The format of
/// the string may change between different versions of GTK, but it is
/// guaranteed that the GTK css parser is able to read the string and
/// create the same symbolic color from it.
/// </para>
/// </summary>

/// <param name="color">
/// color to convert to a string
/// </param>
/// <return>
/// a new string representing @color
/// </return>

	public static string ToString(this MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		return GtkSymbolicColorExterns.gtk_symbolic_color_to_string(color);
	}

/// <summary>
/// <para>
/// Decreases the reference count of @color, freeing its memory if the
/// reference count reaches 0.
/// </para>
/// </summary>

/// <param name="color">
/// a #GtkSymbolicColor
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		GtkSymbolicColorExterns.gtk_symbolic_color_unref(color);
	}


	public static GtkSymbolicColor Dereference(this GtkSymbolicColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSymbolicColor>(x.DangerousGetHandle());
}
internal class GtkSymbolicColorExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color, double factor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_mix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color2, double factor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_name(string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_shade([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color, double factor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_win32(string theme_class, int id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_symbolic_color_resolve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, out MentorLake.Gdk.GdkRGBA resolved_color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_symbolic_color_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_symbolic_color_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

}

/// <summary>
/// <para>
/// GtkSymbolicColor is a boxed type that represents a symbolic color.
/// It is the result of parsing a
/// [color expression][gtkcssprovider-symbolic-colors].
/// To obtain the color represented by a GtkSymbolicColor, it has to
/// be resolved with gtk_symbolic_color_resolve(), which replaces all
/// symbolic color references by the colors they refer to (in a given
/// context) and evaluates mix, shade and other expressions, resulting
/// in a #GdkRGBA value.
/// </para>
/// <para>
/// It is not normally necessary to deal directly with #GtkSymbolicColors,
/// since they are mostly used behind the scenes by #GtkStyleContext and
/// #GtkCssProvider.
/// </para>
/// <para>
/// #GtkSymbolicColor is deprecated. Symbolic colors are considered an
/// implementation detail of GTK+.
/// </para>
/// </summary>

public struct GtkSymbolicColor
{
}
