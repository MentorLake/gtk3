namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkGradient is a boxed type that represents a gradient.
/// It is the result of parsing a
/// [gradient expression][gtkcssprovider-gradients].
/// To obtain the gradient represented by a GtkGradient, it has to
/// be resolved with gtk_gradient_resolve(), which replaces all
/// symbolic color references by the colors they refer to (in a given
/// context) and constructs a #cairo_pattern_t value.
/// </para>
/// <para>
/// It is not normally necessary to deal directly with #GtkGradients,
/// since they are mostly used behind the scenes by #GtkStyleContext and
/// #GtkCssProvider.
/// </para>
/// <para>
/// #GtkGradient is deprecated. It was used internally by GTK’s CSS engine
/// to represent gradients. As its handling is not conforming to modern
/// web standards, it is not used anymore. If you want to use gradients in
/// your own code, please use Cairo directly.
/// </para>
/// </summary>

public class GtkGradientHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new linear gradient along the line defined by (x0, y0) and (x1, y1). Before using the gradient
/// a number of stop colors must be added through gtk_gradient_add_color_stop().
/// </para>
/// </summary>

/// <param name="x0">
/// X coordinate of the starting point
/// </param>
/// <param name="y0">
/// Y coordinate of the starting point
/// </param>
/// <param name="x1">
/// X coordinate of the end point
/// </param>
/// <param name="y1">
/// Y coordinate of the end point
/// </param>
/// <return>
/// A newly created #GtkGradient
/// </return>

	public static MentorLake.Gtk.GtkGradientHandle NewLinear(double x0, double y0, double x1, double y1)
	{
		return GtkGradientExterns.gtk_gradient_new_linear(x0, y0, x1, y1);
	}

/// <summary>
/// <para>
/// Creates a new radial gradient along the two circles defined by (x0, y0, radius0) and
/// (x1, y1, radius1). Before using the gradient a number of stop colors must be added
/// through gtk_gradient_add_color_stop().
/// </para>
/// </summary>

/// <param name="x0">
/// X coordinate of the start circle
/// </param>
/// <param name="y0">
/// Y coordinate of the start circle
/// </param>
/// <param name="radius0">
/// radius of the start circle
/// </param>
/// <param name="x1">
/// X coordinate of the end circle
/// </param>
/// <param name="y1">
/// Y coordinate of the end circle
/// </param>
/// <param name="radius1">
/// radius of the end circle
/// </param>
/// <return>
/// A newly created #GtkGradient
/// </return>

	public static MentorLake.Gtk.GtkGradientHandle NewRadial(double x0, double y0, double radius0, double x1, double y1, double radius1)
	{
		return GtkGradientExterns.gtk_gradient_new_radial(x0, y0, radius0, x1, y1, radius1);
	}

}


public static class GtkGradientExtensions
{
/// <summary>
/// <para>
/// Adds a stop color to @gradient.
/// </para>
/// </summary>

/// <param name="gradient">
/// a #GtkGradient
/// </param>
/// <param name="offset">
/// offset for the color stop
/// </param>
/// <param name="color">
/// color to use
/// </param>

	public static void AddColorStop(this MentorLake.Gtk.GtkGradientHandle gradient, double offset, MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (gradient.IsInvalid) throw new Exception("Invalid handle (GtkGradient)");
		GtkGradientExterns.gtk_gradient_add_color_stop(gradient, offset, color);
	}

/// <summary>
/// <para>
/// Increases the reference count of @gradient.
/// </para>
/// </summary>

/// <param name="gradient">
/// a #GtkGradient
/// </param>
/// <return>
/// The same @gradient
/// </return>

	public static MentorLake.Gtk.GtkGradientHandle Ref(this MentorLake.Gtk.GtkGradientHandle gradient)
	{
		if (gradient.IsInvalid) throw new Exception("Invalid handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_ref(gradient);
	}

/// <summary>
/// <para>
/// If @gradient is resolvable, @resolved_gradient will be filled in
/// with the resolved gradient as a cairo_pattern_t, and %TRUE will
/// be returned. Generally, if @gradient can’t be resolved, it is
/// due to it being defined on top of a named color that doesn&apos;t
/// exist in @props.
/// </para>
/// </summary>

/// <param name="gradient">
/// a #GtkGradient
/// </param>
/// <param name="props">
/// #GtkStyleProperties to use when resolving named colors
/// </param>
/// <param name="resolved_gradient">
/// return location for the resolved pattern
/// </param>
/// <return>
/// %TRUE if the gradient has been resolved
/// </return>

	public static bool Resolve(this MentorLake.Gtk.GtkGradientHandle gradient, MentorLake.Gtk.GtkStylePropertiesHandle props, out MentorLake.cairo.cairo_pattern_tHandle resolved_gradient)
	{
		if (gradient.IsInvalid) throw new Exception("Invalid handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_resolve(gradient, props, out resolved_gradient);
	}


/// <param name="gradient">
/// </param>
/// <param name="context">
/// </param>

	public static MentorLake.cairo.cairo_pattern_tHandle ResolveForContext(this MentorLake.Gtk.GtkGradientHandle gradient, MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (gradient.IsInvalid) throw new Exception("Invalid handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_resolve_for_context(gradient, context);
	}

/// <summary>
/// <para>
/// Creates a string representation for @gradient that is suitable
/// for using in GTK CSS files.
/// </para>
/// </summary>

/// <param name="gradient">
/// the gradient to print
/// </param>
/// <return>
/// A string representation for @gradient
/// </return>

	public static string ToString(this MentorLake.Gtk.GtkGradientHandle gradient)
	{
		if (gradient.IsInvalid) throw new Exception("Invalid handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_to_string(gradient);
	}

/// <summary>
/// <para>
/// Decreases the reference count of @gradient, freeing its memory
/// if the reference count reaches 0.
/// </para>
/// </summary>

/// <param name="gradient">
/// a #GtkGradient
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkGradientHandle gradient)
	{
		if (gradient.IsInvalid) throw new Exception("Invalid handle (GtkGradient)");
		GtkGradientExterns.gtk_gradient_unref(gradient);
	}


	public static GtkGradient Dereference(this GtkGradientHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGradient>(x.DangerousGetHandle());
}
internal class GtkGradientExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))]
	internal static extern MentorLake.Gtk.GtkGradientHandle gtk_gradient_new_linear(double x0, double y0, double x1, double y1);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))]
	internal static extern MentorLake.Gtk.GtkGradientHandle gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gradient_add_color_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient, double offset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))]
	internal static extern MentorLake.Gtk.GtkGradientHandle gtk_gradient_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gradient_resolve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] out MentorLake.cairo.cairo_pattern_tHandle resolved_gradient);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle gtk_gradient_resolve_for_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_gradient_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gradient_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient);

}

/// <summary>
/// <para>
/// GtkGradient is a boxed type that represents a gradient.
/// It is the result of parsing a
/// [gradient expression][gtkcssprovider-gradients].
/// To obtain the gradient represented by a GtkGradient, it has to
/// be resolved with gtk_gradient_resolve(), which replaces all
/// symbolic color references by the colors they refer to (in a given
/// context) and constructs a #cairo_pattern_t value.
/// </para>
/// <para>
/// It is not normally necessary to deal directly with #GtkGradients,
/// since they are mostly used behind the scenes by #GtkStyleContext and
/// #GtkCssProvider.
/// </para>
/// <para>
/// #GtkGradient is deprecated. It was used internally by GTK’s CSS engine
/// to represent gradients. As its handling is not conforming to modern
/// web standards, it is not used anymore. If you want to use gradients in
/// your own code, please use Cairo directly.
/// </para>
/// </summary>

public struct GtkGradient
{
}
