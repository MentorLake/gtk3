namespace MentorLake.Gtk3.Gtk3;

public class GtkSymbolicColorHandle : BaseSafeHandle
{
	public static GtkSymbolicColorHandle NewAlpha(GtkSymbolicColorHandle color, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_alpha(color, factor);
	}

	public static GtkSymbolicColorHandle NewLiteral(GdkRGBAHandle color)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_literal(color);
	}

	public static GtkSymbolicColorHandle NewMix(GtkSymbolicColorHandle color1, GtkSymbolicColorHandle color2, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_mix(color1, color2, factor);
	}

	public static GtkSymbolicColorHandle NewName(string name)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_name(name);
	}

	public static GtkSymbolicColorHandle NewShade(GtkSymbolicColorHandle color, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_shade(color, factor);
	}

	public static GtkSymbolicColorHandle NewWin32(string theme_class, int id)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_win32(theme_class, id);
	}

}


public static class GtkSymbolicColorHandleExtensions
{
	public static GtkSymbolicColorHandle Ref(this GtkSymbolicColorHandle color)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_ref(color);
	}

	public static bool Resolve(this GtkSymbolicColorHandle color, GtkStylePropertiesHandle props, out GdkRGBA resolved_color)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_resolve(color, props, out resolved_color);
	}

	public static string ToString(this GtkSymbolicColorHandle color)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_to_string(color);
	}

	public static GtkSymbolicColorHandle Unref(this GtkSymbolicColorHandle color)
	{
		GtkSymbolicColorExterns.gtk_symbolic_color_unref(color);
		return color;
	}

}
internal class GtkSymbolicColorExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_new_alpha(GtkSymbolicColorHandle color, double factor);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_new_literal(GdkRGBAHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_new_mix(GtkSymbolicColorHandle color1, GtkSymbolicColorHandle color2, double factor);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_new_name(string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_new_shade(GtkSymbolicColorHandle color, double factor);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_new_win32(string theme_class, int id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_symbolic_color_ref(GtkSymbolicColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_symbolic_color_resolve(GtkSymbolicColorHandle color, GtkStylePropertiesHandle props, out GdkRGBA resolved_color);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_symbolic_color_to_string(GtkSymbolicColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_symbolic_color_unref(GtkSymbolicColorHandle color);

}

public struct GtkSymbolicColor
{
}
