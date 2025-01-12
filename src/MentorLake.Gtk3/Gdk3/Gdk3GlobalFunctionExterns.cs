namespace MentorLake.Gtk3.Gdk3;

internal class Gdk3GlobalFunctionExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_set_source_rgba(cairo_tHandle cr, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_query_depths(out int[] depths, out int count);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_pointer_ungrab(uint time_);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_threads_init();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_keyboard_ungrab(uint time_);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_get_program_class();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_notify_startup_complete();

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_surface_tHandle gdk_cairo_surface_create_from_pixbuf(GdkPixbufHandle pixbuf, int scale, GdkWindowHandle for_window);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_flush();

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkPixbufHandle gdk_pixbuf_get_from_surface(cairo_surface_tHandle surface, int src_x, int src_y, int width, int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_add_option_entries_libgtk_only(GOptionGroupHandle group);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_init_check(ref int argc, ref string[] argv);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_unicode_to_keyval(uint wc);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_keyval_to_unicode(uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_set_show_events(bool show_events);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_draw_from_gl(cairo_tHandle cr, GdkWindowHandle window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_threads_add_timeout_full(int priority, uint interval, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_query_visual_types(out GdkVisualType[] visual_types, out int count);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_threads_set_lock_functions(IntPtr enter_fn, IntPtr leave_fn);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_rectangle(cairo_tHandle cr, GdkRectangleHandle rectangle);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_pointer_is_grabbed();

	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_utf8_to_string_target(string str);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_set_source_pixbuf(cairo_tHandle cr, GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y);

	[DllImport(Libraries.Gdk3)]
	internal static extern int gdk_error_trap_pop();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_parse_args(ref int argc, ref string[] argv);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_threads_add_timeout_seconds_full(int priority, uint interval, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_set_program_class(string program_class);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_threads_add_timeout(uint interval, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_keyval_to_upper(uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_pending();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_set_allowed_backends(string backends);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_pango_layout_get_clip_region(PangoLayoutHandle layout, int x_origin, int y_origin, ref int index_ranges, int n_ranges);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_threads_add_timeout_seconds(uint interval, GSourceFunc function, IntPtr data);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_init(ref int argc, ref string[] argv);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_threads_enter();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_pre_parse_libgtk_only();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_beep();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_error_trap_push();

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_cairo_region_create_from_surface(cairo_surface_tHandle surface);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_set_source_window(cairo_tHandle cr, GdkWindowHandle window, double x, double y);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keyval_is_upper(uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern cairo_region_tHandle gdk_pango_layout_line_get_clip_region(PangoLayoutLineHandle line, int x_origin, int y_origin, int[] index_ranges, int n_ranges);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_selection_owner_get(GdkAtom selection);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_set_source_color(cairo_tHandle cr, GdkColorHandle color);

	[DllImport(Libraries.Gdk3)]
	internal static extern PangoContextHandle gdk_pango_context_get();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_threads_leave();

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_threads_add_idle_full(int priority, GSourceFunc function, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_notify_startup_complete_with_id(string startup_id);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_get_distance(GdkEventHandle event1, GdkEventHandle event2, out double distance);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkWindowHandle gdk_get_default_root_window();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_cairo_region(cairo_tHandle cr, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_keyval_is_lower(uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_get_angle(GdkEventHandle event1, GdkEventHandle event2, out double angle);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_cairo_get_clip_rectangle(cairo_tHandle cr, out GdkRectangle rect);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_threads_add_idle(GSourceFunc function, IntPtr data);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_setting_get(string name, GValueHandle value);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_keyval_convert_case(uint symbol, out uint lower, out uint upper);

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_get_display_arg_name();

	[DllImport(Libraries.Gdk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_keyval_name(uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern GListHandle gdk_list_visuals();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_error_trap_pop_ignored();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_disable_multidevice();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_set_double_click_time(uint msec);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_events_get_center(GdkEventHandle event1, GdkEventHandle event2, out double x, out double y);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkDrawingContextHandle gdk_cairo_get_drawing_context(cairo_tHandle cr);

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_keyval_to_lower(uint keyval);

	[DllImport(Libraries.Gdk3)]
	internal static extern bool gdk_get_show_events();

	[DllImport(Libraries.Gdk3)]
	internal static extern uint gdk_keyval_from_name(string keyval_name);

	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_get_display();

}
