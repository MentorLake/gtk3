namespace MentorLake.Gtk3.Gtk3;

public interface GtkColorChooserHandle
{
}

internal class GtkColorChooserHandleImpl : BaseSafeHandle, GtkColorChooserHandle
{
}

public static class GtkColorChooserHandleExtensions
{
	public static T AddPalette<T>(this T chooser, GtkOrientation orientation, int colors_per_line, int n_colors, GdkRGBA[] colors) where T : GtkColorChooserHandle
	{
		GtkColorChooserExterns.gtk_color_chooser_add_palette(chooser, orientation, colors_per_line, n_colors, colors);
		return chooser;
	}

	public static T GetRgba<T>(this T chooser, out GdkRGBA color) where T : GtkColorChooserHandle
	{
		GtkColorChooserExterns.gtk_color_chooser_get_rgba(chooser, out color);
		return chooser;
	}

	public static bool GetUseAlpha(this GtkColorChooserHandle chooser)
	{
		return GtkColorChooserExterns.gtk_color_chooser_get_use_alpha(chooser);
	}

	public static T SetRgba<T>(this T chooser, GdkRGBAHandle color) where T : GtkColorChooserHandle
	{
		GtkColorChooserExterns.gtk_color_chooser_set_rgba(chooser, color);
		return chooser;
	}

	public static T SetUseAlpha<T>(this T chooser, bool use_alpha) where T : GtkColorChooserHandle
	{
		GtkColorChooserExterns.gtk_color_chooser_set_use_alpha(chooser, use_alpha);
		return chooser;
	}

}

internal class GtkColorChooserExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_chooser_add_palette(GtkColorChooserHandle chooser, GtkOrientation orientation, int colors_per_line, int n_colors, GdkRGBA[] colors);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_chooser_get_rgba(GtkColorChooserHandle chooser, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_color_chooser_get_use_alpha(GtkColorChooserHandle chooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_chooser_set_rgba(GtkColorChooserHandle chooser, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_color_chooser_set_use_alpha(GtkColorChooserHandle chooser, bool use_alpha);

}
