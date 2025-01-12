namespace MentorLake.Gtk3.Gtk3;

public class GtkGradientHandle : BaseSafeHandle
{
	public static GtkGradientHandle NewLinear(double x0, double y0, double x1, double y1)
	{
		return GtkGradientExterns.gtk_gradient_new_linear(x0, y0, x1, y1);
	}

	public static GtkGradientHandle NewRadial(double x0, double y0, double radius0, double x1, double y1, double radius1)
	{
		return GtkGradientExterns.gtk_gradient_new_radial(x0, y0, radius0, x1, y1, radius1);
	}

}


public static class GtkGradientHandleExtensions
{
	public static T AddColorStop<T>(this T gradient, double offset, GtkSymbolicColorHandle color) where T : GtkGradientHandle
	{
		GtkGradientExterns.gtk_gradient_add_color_stop(gradient, offset, color);
		return gradient;
	}

	public static GtkGradientHandle Ref(this GtkGradientHandle gradient)
	{
		return GtkGradientExterns.gtk_gradient_ref(gradient);
	}

	public static bool Resolve(this GtkGradientHandle gradient, GtkStylePropertiesHandle props, out cairo_pattern_tHandle resolved_gradient)
	{
		return GtkGradientExterns.gtk_gradient_resolve(gradient, props, out resolved_gradient);
	}

	public static cairo_pattern_tHandle ResolveForContext(this GtkGradientHandle gradient, GtkStyleContextHandle context)
	{
		return GtkGradientExterns.gtk_gradient_resolve_for_context(gradient, context);
	}

	public static string ToString(this GtkGradientHandle gradient)
	{
		return GtkGradientExterns.gtk_gradient_to_string(gradient);
	}

	public static T Unref<T>(this T gradient) where T : GtkGradientHandle
	{
		GtkGradientExterns.gtk_gradient_unref(gradient);
		return gradient;
	}

}
internal class GtkGradientExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGradientHandle gtk_gradient_new_linear(double x0, double y0, double x1, double y1);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGradientHandle gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gradient_add_color_stop(GtkGradientHandle gradient, double offset, GtkSymbolicColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkGradientHandle gtk_gradient_ref(GtkGradientHandle gradient);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_gradient_resolve(GtkGradientHandle gradient, GtkStylePropertiesHandle props, out cairo_pattern_tHandle resolved_gradient);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_pattern_tHandle gtk_gradient_resolve_for_context(GtkGradientHandle gradient, GtkStyleContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_gradient_to_string(GtkGradientHandle gradient);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_gradient_unref(GtkGradientHandle gradient);

}

public struct GtkGradient
{
}
