namespace MentorLake.Gtk;

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
	public static T AddPalette<T>(this T chooser, MentorLake.Gtk.GtkOrientation orientation, int colors_per_line, int n_colors, MentorLake.Gdk.GdkRGBA[] colors) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_add_palette(chooser, orientation, colors_per_line, n_colors, colors);
		return chooser;
	}

	public static T GetRgba<T>(this T chooser, out MentorLake.Gdk.GdkRGBA color) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_get_rgba(chooser, out color);
		return chooser;
	}

	public static bool GetUseAlpha(this MentorLake.Gtk.GtkColorChooserHandle chooser)
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		return GtkColorChooserHandleExterns.gtk_color_chooser_get_use_alpha(chooser);
	}

	public static T SetRgba<T>(this T chooser, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkColorChooserHandle
	{
		if (chooser.IsInvalid) throw new Exception("Invalid handle (GtkColorChooserHandle)");
		GtkColorChooserHandleExterns.gtk_color_chooser_set_rgba(chooser, color);
		return chooser;
	}

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
