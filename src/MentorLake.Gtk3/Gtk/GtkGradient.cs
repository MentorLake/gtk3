namespace MentorLake.Gtk;

public class GtkGradientHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkGradientHandle NewLinear(double x0, double y0, double x1, double y1)
	{
		return GtkGradientExterns.gtk_gradient_new_linear(x0, y0, x1, y1);
	}

	public static MentorLake.Gtk.GtkGradientHandle NewRadial(double x0, double y0, double radius0, double x1, double y1, double radius1)
	{
		return GtkGradientExterns.gtk_gradient_new_radial(x0, y0, radius0, x1, y1, radius1);
	}

}


public static class GtkGradientExtensions
{
	public static void AddColorStop(this MentorLake.Gtk.GtkGradientHandle gradient, double offset, MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (gradient.IsInvalid || gradient.IsClosed) throw new Exception("Invalid or closed handle (GtkGradient)");
		GtkGradientExterns.gtk_gradient_add_color_stop(gradient, offset, color);
	}

	public static MentorLake.Gtk.GtkGradientHandle Ref(this MentorLake.Gtk.GtkGradientHandle gradient)
	{
		if (gradient.IsInvalid || gradient.IsClosed) throw new Exception("Invalid or closed handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_ref(gradient);
	}

	public static bool Resolve(this MentorLake.Gtk.GtkGradientHandle gradient, MentorLake.Gtk.GtkStylePropertiesHandle props, out MentorLake.cairo.cairo_pattern_tHandle resolved_gradient)
	{
		if (gradient.IsInvalid || gradient.IsClosed) throw new Exception("Invalid or closed handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_resolve(gradient, props, out resolved_gradient);
	}

	public static MentorLake.cairo.cairo_pattern_tHandle ResolveForContext(this MentorLake.Gtk.GtkGradientHandle gradient, MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (gradient.IsInvalid || gradient.IsClosed) throw new Exception("Invalid or closed handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_resolve_for_context(gradient, context);
	}

	public static string ToString(this MentorLake.Gtk.GtkGradientHandle gradient)
	{
		if (gradient.IsInvalid || gradient.IsClosed) throw new Exception("Invalid or closed handle (GtkGradient)");
		return GtkGradientExterns.gtk_gradient_to_string(gradient);
	}

	public static void Unref(this MentorLake.Gtk.GtkGradientHandle gradient)
	{
		if (gradient.IsInvalid || gradient.IsClosed) throw new Exception("Invalid or closed handle (GtkGradient)");
		GtkGradientExterns.gtk_gradient_unref(gradient);
	}


	public static GtkGradient Dereference(this GtkGradientHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkGradient>(x.DangerousGetHandle());
}
internal class GtkGradientExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGradientHandle gtk_gradient_new_linear(double x0, double y0, double x1, double y1);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGradientHandle gtk_gradient_new_radial(double x0, double y0, double radius0, double x1, double y1, double radius1);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gradient_add_color_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient, double offset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkGradientHandle gtk_gradient_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_gradient_resolve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_pattern_tHandle>))] out MentorLake.cairo.cairo_pattern_tHandle resolved_gradient);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_pattern_tHandle gtk_gradient_resolve_for_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_gradient_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_gradient_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkGradientHandle>))] MentorLake.Gtk.GtkGradientHandle gradient);

}

public struct GtkGradient
{
}
