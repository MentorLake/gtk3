namespace MentorLake.Gtk;

public class GtkPrintContextHandle : GObjectHandle
{
}

public static class GtkPrintContextHandleExtensions
{
	public static MentorLake.Pango.PangoContextHandle CreatePangoContext(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_create_pango_context(context);
	}

	public static MentorLake.Pango.PangoLayoutHandle CreatePangoLayout(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_create_pango_layout(context);
	}

	public static MentorLake.cairo.cairo_tHandle GetCairoContext(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_cairo_context(context);
	}

	public static double GetDpiX(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_dpi_x(context);
	}

	public static double GetDpiY(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_dpi_y(context);
	}

	public static bool GetHardMargins(this MentorLake.Gtk.GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_hard_margins(context, out top, out bottom, out left, out right);
	}

	public static double GetHeight(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_height(context);
	}

	public static MentorLake.Gtk.GtkPageSetupHandle GetPageSetup(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_page_setup(context);
	}

	public static MentorLake.Pango.PangoFontMapHandle GetPangoFontmap(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_pango_fontmap(context);
	}

	public static double GetWidth(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_width(context);
	}

	public static T SetCairoContext<T>(this T context, MentorLake.cairo.cairo_tHandle cr, double dpi_x, double dpi_y) where T : GtkPrintContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		GtkPrintContextHandleExterns.gtk_print_context_set_cairo_context(context, cr, dpi_x, dpi_y);
		return context;
	}

}

internal class GtkPrintContextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gtk_print_context_create_pango_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_print_context_create_pango_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))]
	internal static extern MentorLake.cairo.cairo_tHandle gtk_print_context_get_cairo_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_context_get_dpi_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_context_get_dpi_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_context_get_hard_margins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_context_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_print_context_get_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle gtk_print_context_get_pango_fontmap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_context_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_context_set_cairo_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double dpi_x, double dpi_y);

}
