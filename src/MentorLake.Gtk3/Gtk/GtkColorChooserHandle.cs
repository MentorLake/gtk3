namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkColorChooser is an interface that is implemented by widgets
/// for choosing colors. Depending on the situation, colors may be
/// allowed to have alpha (translucency).
/// </para>
/// <para>
/// In GTK+, the main widgets that implement this interface are
/// #GtkColorChooserWidget, #GtkColorChooserDialog and #GtkColorButton.
/// </para>
/// </summary>

public interface GtkColorChooserHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkColorChooserHandleImpl : BaseSafeHandle, GtkColorChooserHandle
{
}

public static class GtkColorChooserHandleExtensions
{
/// <summary>
/// <para>
/// Adds a palette to the color chooser. If @orientation is horizontal,
/// the colors are grouped in rows, with @colors_per_line colors
/// in each row. If @horizontal is %FALSE, the colors are grouped
/// in columns instead.
/// </para>
/// <para>
/// The default color palette of #GtkColorChooserWidget has
/// 27 colors, organized in columns of 3 colors. The default gray
/// palette has 9 grays in a single row.
/// </para>
/// <para>
/// The layout of the color chooser widget works best when the
/// palettes have 9-10 columns.
/// </para>
/// <para>
/// Calling this function for the first time has the
/// side effect of removing the default color and gray palettes
/// from the color chooser.
/// </para>
/// <para>
/// If @colors is %NULL, removes all previously added palettes.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkColorChooser
/// </param>
/// <param name="orientation">
/// %GTK_ORIENTATION_HORIZONTAL if the palette should
///     be displayed in rows, %GTK_ORIENTATION_VERTICAL for columns
/// </param>
/// <param name="colors_per_line">
/// the number of colors to show in each row/column
/// </param>
/// <param name="n_colors">
/// the total number of elements in @colors
/// </param>
/// <param name="colors">
/// the colors of the palette, or %NULL
/// </param>

	public static T AddPalette<T>(this T chooser, MentorLake.Gtk.GtkOrientation orientation, int colors_per_line, int n_colors, MentorLake.Gdk.GdkRGBA[] colors) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_add_palette(chooser, orientation, colors_per_line, n_colors, colors);
		return chooser;
	}

/// <summary>
/// <para>
/// Gets the currently-selected color.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkColorChooser
/// </param>
/// <param name="color">
/// a #GdkRGBA to fill in with the current color
/// </param>

	public static T GetRgba<T>(this T chooser, out MentorLake.Gdk.GdkRGBA color) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_get_rgba(chooser, out color);
		return chooser;
	}

/// <summary>
/// <para>
/// Returns whether the color chooser shows the alpha channel.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkColorChooser
/// </param>
/// <return>
/// %TRUE if the color chooser uses the alpha channel,
///     %FALSE if not
/// </return>

	public static bool GetUseAlpha(this MentorLake.Gtk.GtkColorChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		return GtkColorChooserHandleExterns.gtk_color_chooser_get_use_alpha(chooser);
	}

/// <summary>
/// <para>
/// Sets the color.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkColorChooser
/// </param>
/// <param name="color">
/// the new color
/// </param>

	public static T SetRgba<T>(this T chooser, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_set_rgba(chooser, color);
		return chooser;
	}

/// <summary>
/// <para>
/// Sets whether or not the color chooser should use the alpha channel.
/// </para>
/// </summary>

/// <param name="chooser">
/// a #GtkColorChooser
/// </param>
/// <param name="use_alpha">
/// %TRUE if color chooser should use alpha channel, %FALSE if not
/// </param>

	public static T SetUseAlpha<T>(this T chooser, bool use_alpha) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_set_use_alpha(chooser, use_alpha);
		return chooser;
	}

}

internal class GtkColorChooserHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_chooser_add_palette([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle chooser, MentorLake.Gtk.GtkOrientation orientation, int colors_per_line, int n_colors, MentorLake.Gdk.GdkRGBA[] colors);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_chooser_get_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle chooser, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_color_chooser_get_use_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle chooser);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_chooser_set_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle chooser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_color_chooser_set_use_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkColorChooserHandleImpl>))] MentorLake.Gtk.GtkColorChooserHandle chooser, bool use_alpha);

}
