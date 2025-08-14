namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkDrawingArea widget is used for creating custom user interface
/// elements. It’s essentially a blank widget; you can draw on it. After
/// creating a drawing area, the application may want to connect to:
/// </para>
/// <para>
/// - Mouse and button press signals to respond to input from
///   the user. (Use gtk_widget_add_events() to enable events
///   you wish to receive.)
/// </para>
/// <para>
/// - The #GtkWidget::realize signal to take any necessary actions
///   when the widget is instantiated on a particular display.
///   (Create GDK resources in response to this signal.)
/// </para>
/// <para>
/// - The #GtkWidget::size-allocate signal to take any necessary
///   actions when the widget changes size.
/// </para>
/// <para>
/// - The #GtkWidget::draw signal to handle redrawing the
///   contents of the widget.
/// </para>
/// <para>
/// The following code portion demonstrates using a drawing
/// area to display a circle in the normal widget foreground
/// color.
/// </para>
/// <para>
/// Note that GDK automatically clears the exposed area before sending
/// the expose event, and that drawing is implicitly clipped to the exposed
/// area. If you want to have a theme-provided background, you need
/// to call gtk_render_background() in your ::draw method.
/// </para>
/// <para>
/// ## Simple GtkDrawingArea usage
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// gboolean
/// draw_callback (GtkWidget *widget, cairo_t *cr, gpointer data)
/// {
///   guint width, height;
///   GdkRGBA color;
///   GtkStyleContext *context;
/// </para>
/// <para>
///   context = gtk_widget_get_style_context (widget);
/// </para>
/// <para>
///   width = gtk_widget_get_allocated_width (widget);
///   height = gtk_widget_get_allocated_height (widget);
/// </para>
/// <para>
///   gtk_render_background (context, cr, 0, 0, width, height);
/// </para>
/// <para>
///   cairo_arc (cr,
///              width / 2.0, height / 2.0,
///              MIN (width, height) / 2.0,
///              0, 2 * G_PI);
/// </para>
/// <para>
///   gtk_style_context_get_color (context,
///                                gtk_style_context_get_state (context),
///                                &color);
///   gdk_cairo_set_source_rgba (cr, &color);
/// </para>
/// <para>
///   cairo_fill (cr);
/// </para>
/// <para>
///  return FALSE;
/// }
/// [...]
///   GtkWidget *drawing_area = gtk_drawing_area_new ();
///   gtk_widget_set_size_request (drawing_area, 100, 100);
///   g_signal_connect (G_OBJECT (drawing_area), "draw",
///                     G_CALLBACK (draw_callback), NULL);
/// ]|
/// </para>
/// <para>
/// Draw signals are normally delivered when a drawing area first comes
/// onscreen, or when it’s covered by another window and then uncovered.
/// You can also force an expose event by adding to the “damage region”
/// of the drawing area’s window; gtk_widget_queue_draw_area() and
/// gdk_window_invalidate_rect() are equally good ways to do this.
/// You’ll then get a draw signal for the invalid region.
/// </para>
/// <para>
/// The available routines for drawing are documented on the
/// [GDK Drawing Primitives][gdk3-Cairo-Interaction] page
/// and the cairo documentation.
/// </para>
/// <para>
/// To receive mouse events on a drawing area, you will need to enable
/// them with gtk_widget_add_events(). To receive keyboard events, you
/// will need to set the “can-focus” property on the drawing area, and you
/// should probably draw some user-visible indication that the drawing
/// area is focused. Use gtk_widget_has_focus() in your expose event
/// handler to decide whether to draw the focus indicator. See
/// gtk_render_focus() for one way to draw focus.
/// </para>
/// </summary>

public class GtkDrawingAreaHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new drawing area.
/// </para>
/// </summary>

/// <return>
/// a new #GtkDrawingArea
/// </return>

	public static MentorLake.Gtk.GtkDrawingAreaHandle New()
	{
		return GtkDrawingAreaHandleExterns.gtk_drawing_area_new();
	}

}

public static class GtkDrawingAreaHandleExtensions
{
}

internal class GtkDrawingAreaHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkDrawingAreaHandle>))]
	internal static extern MentorLake.Gtk.GtkDrawingAreaHandle gtk_drawing_area_new();

}
