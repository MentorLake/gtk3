namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkPrintContext encapsulates context information that is required when
/// drawing pages for printing, such as the cairo context and important
/// parameters like page size and resolution. It also lets you easily
/// create #PangoLayout and #PangoContext objects that match the font metrics
/// of the cairo surface.
/// </para>
/// <para>
/// GtkPrintContext objects gets passed to the #GtkPrintOperation::begin-print,
/// #GtkPrintOperation::end-print, #GtkPrintOperation::request-page-setup and
/// #GtkPrintOperation::draw-page signals on the #GtkPrintOperation.
/// </para>
/// <para>
/// ## Using GtkPrintContext in a #GtkPrintOperation::draw-page callback
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static void
/// draw_page (GtkPrintOperation *operation,
/// 	   GtkPrintContext   *context,
/// 	   int                page_nr)
/// {
///   cairo_t *cr;
///   PangoLayout *layout;
///   PangoFontDescription *desc;
/// </para>
/// <para>
///   cr = gtk_print_context_get_cairo_context (context);
/// </para>
/// <para>
///   // Draw a red rectangle, as wide as the paper (inside the margins)
///   cairo_set_source_rgb (cr, 1.0, 0, 0);
///   cairo_rectangle (cr, 0, 0, gtk_print_context_get_width (context), 50);
/// </para>
/// <para>
///   cairo_fill (cr);
/// </para>
/// <para>
///   // Draw some lines
///   cairo_move_to (cr, 20, 10);
///   cairo_line_to (cr, 40, 20);
///   cairo_arc (cr, 60, 60, 20, 0, M_PI);
///   cairo_line_to (cr, 80, 20);
/// </para>
/// <para>
///   cairo_set_source_rgb (cr, 0, 0, 0);
///   cairo_set_line_width (cr, 5);
///   cairo_set_line_cap (cr, CAIRO_LINE_CAP_ROUND);
///   cairo_set_line_join (cr, CAIRO_LINE_JOIN_ROUND);
/// </para>
/// <para>
///   cairo_stroke (cr);
/// </para>
/// <para>
///   // Draw some text
///   layout = gtk_print_context_create_pango_layout (context);
///   pango_layout_set_text (layout, "Hello World! Printing is easy", -1);
///   desc = pango_font_description_from_string ("sans 28");
///   pango_layout_set_font_description (layout, desc);
///   pango_font_description_free (desc);
/// </para>
/// <para>
///   cairo_move_to (cr, 30, 20);
///   pango_cairo_layout_path (cr, layout);
/// </para>
/// <para>
///   // Font Outline
///   cairo_set_source_rgb (cr, 0.93, 1.0, 0.47);
///   cairo_set_line_width (cr, 0.5);
///   cairo_stroke_preserve (cr);
/// </para>
/// <para>
///   // Font Fill
///   cairo_set_source_rgb (cr, 0, 0.0, 1.0);
///   cairo_fill (cr);
/// </para>
/// <para>
///   g_object_unref (layout);
/// }
/// ]|
/// </para>
/// <para>
/// Printing support was added in GTK+ 2.10.
/// </para>
/// </summary>

public class GtkPrintContextHandle : GObjectHandle
{
}

public static class GtkPrintContextHandleExtensions
{
/// <summary>
/// <para>
/// Creates a new #PangoContext that can be used with the
/// #GtkPrintContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// a new Pango context for @context
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreatePangoContext(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_create_pango_context(context);
	}

/// <summary>
/// <para>
/// Creates a new #PangoLayout that is suitable for use
/// with the #GtkPrintContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// a new Pango layout for @context
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle CreatePangoLayout(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_create_pango_layout(context);
	}

/// <summary>
/// <para>
/// Obtains the cairo context that is associated with the
/// #GtkPrintContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the cairo context of @context
/// </return>

	public static MentorLake.cairo.cairo_tHandle GetCairoContext(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_cairo_context(context);
	}

/// <summary>
/// <para>
/// Obtains the horizontal resolution of the #GtkPrintContext,
/// in dots per inch.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the horizontal resolution of @context
/// </return>

	public static double GetDpiX(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_dpi_x(context);
	}

/// <summary>
/// <para>
/// Obtains the vertical resolution of the #GtkPrintContext,
/// in dots per inch.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the vertical resolution of @context
/// </return>

	public static double GetDpiY(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_dpi_y(context);
	}

/// <summary>
/// <para>
/// Obtains the hardware printer margins of the #GtkPrintContext, in units.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <param name="top">
/// top hardware printer margin
/// </param>
/// <param name="bottom">
/// bottom hardware printer margin
/// </param>
/// <param name="left">
/// left hardware printer margin
/// </param>
/// <param name="right">
/// right hardware printer margin
/// </param>
/// <return>
/// %TRUE if the hard margins were retrieved
/// </return>

	public static bool GetHardMargins(this MentorLake.Gtk.GtkPrintContextHandle context, out double top, out double bottom, out double left, out double right)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_hard_margins(context, out top, out bottom, out left, out right);
	}

/// <summary>
/// <para>
/// Obtains the height of the #GtkPrintContext, in pixels.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the height of @context
/// </return>

	public static double GetHeight(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_height(context);
	}

/// <summary>
/// <para>
/// Obtains the #GtkPageSetup that determines the page
/// dimensions of the #GtkPrintContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the page setup of @context
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle GetPageSetup(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_page_setup(context);
	}

/// <summary>
/// <para>
/// Returns a #PangoFontMap that is suitable for use
/// with the #GtkPrintContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the font map of @context
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetPangoFontmap(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_pango_fontmap(context);
	}

/// <summary>
/// <para>
/// Obtains the width of the #GtkPrintContext, in pixels.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <return>
/// the width of @context
/// </return>

	public static double GetWidth(this MentorLake.Gtk.GtkPrintContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkPrintContextHandle)");
		return GtkPrintContextHandleExterns.gtk_print_context_get_width(context);
	}

/// <summary>
/// <para>
/// Sets a new cairo context on a print context.
/// </para>
/// <para>
/// This function is intended to be used when implementing
/// an internal print preview, it is not needed for printing,
/// since GTK+ itself creates a suitable cairo context in that
/// case.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkPrintContext
/// </param>
/// <param name="cr">
/// the cairo context
/// </param>
/// <param name="dpi_x">
/// the horizontal resolution to use with @cr
/// </param>
/// <param name="dpi_y">
/// the vertical resolution to use with @cr
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gtk_print_context_create_pango_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
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
