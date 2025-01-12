namespace MentorLake.Gtk3.Gtk3;

public class Gtk3GlobalFunction
{
	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_rc_parse_state(GScannerHandle scanner, out GtkStateType state);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_binary_age();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_get_current_event_state(out GdkModifierType state);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_rc_get_theme_dir();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accelerator_parse(string accelerator, out uint accelerator_key, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_set_row_drag_data(GtkSelectionDataHandle selection_data, GtkTreeModelHandle tree_model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_test_init(ref int argcp, ref string[] argvp, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cairo_should_draw_window(cairo_tHandle cr, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_true();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_main_quit();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_stock(GdkDragContextHandle context, string stock_id, int hot_x, int hot_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_gicon(GdkDragContextHandle context, GIconHandle icon, int hot_x, int hot_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stock_add_static(GtkStockItem[] items, uint n_items);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_main_iteration();

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, GtkRequestedSize[] sizes);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_reparse_all();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_test_create_simple_window(string window_title, string dialog_text);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_current_event_time();

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_rc_get_module_dir();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accelerator_set_default_mod_mask(GdkModifierType default_mod_mask);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_set_debug_flags(uint flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_init_check(ref int argc, ref string[] argv);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_test_list_all_types(out uint n_types);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_pixbuf(GdkDragContextHandle context, GdkPixbufHandle pixbuf, int hot_x, int hot_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_minor_version();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accelerator_parse_with_keycode(string accelerator, out uint accelerator_key, out uint[] accelerator_codes, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_table_free(GtkTargetEntry[] targets, int n_targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_targets_include_image(GdkAtom[] targets, int n_targets, bool writable);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_bindings_activate_event(GObjectHandle @object, GdkEventKeyHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_cancel(GdkDragContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_alternative_dialog_button_order(GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern GOptionGroupHandle gtk_get_option_group(bool open_default_display);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_parse_args(ref int argc, ref string[] argv);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_disable_setlocale();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_targets_include_rich_text(GdkAtom[] targets, int n_targets, GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_test_register_all_types();

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_rc_get_im_module_file();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextDirection gtk_get_locale_direction();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_drag_get_source_widget(GdkDragContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_stock_list_ids();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_events_pending();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_get_row_drag_data(GtkSelectionDataHandle selection_data, out GtkTreeModelHandle tree_model, out GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_accel_groups_from_object(GObjectHandle @object);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_rc_set_default_files(string[] filenames);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_accelerator_get_label(uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_micro_version();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_init(ref int argc, ref string[] argv);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_widget(GdkDragContextHandle context, GtkWidgetHandle widget, int hot_x, int hot_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkModifierType gtk_accelerator_get_default_mod_mask();

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoLanguageHandle gtk_get_default_language();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_targets_include_uri(GdkAtom[] targets, int n_targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cairo_transform_to_window(cairo_tHandle cr, GtkWidgetHandle widget, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_main_do_event(GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_key_snooper_remove(uint snooper_handler_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_false();

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_accelerator_get_label_with_keycode(GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_debug_flags();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_groups_activate(GObjectHandle @object, uint accel_key, GdkModifierType accel_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_rc_parse_string(string rc_string);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_main_iteration_do(bool blocking);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_rc_get_im_module_path();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_grab_get_current();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_rc_add_default_file(string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkEventHandle gtk_get_current_event();

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_accelerator_name(uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_rc_parse_color_full(GScannerHandle scanner, GtkRcStyleHandle style, out GdkColor color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDeviceHandle gtk_get_current_event_device();

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_main_level();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_finish(GdkDragContextHandle context, bool success, bool del, uint time_);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_surface(GdkDragContextHandle context, cairo_surface_tHandle surface);

	[DllImport(Libraries.Gtk3)]
	internal static extern GScannerHandle gtk_rc_scanner_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_owner_set_for_display(GdkDisplayHandle display, GtkWidgetHandle widget, GdkAtom selection, uint time_);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_accelerator_name_with_keycode(GdkDisplayHandle display, uint accelerator_key, uint keycode, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accelerator_valid(uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_rc_parse_color(GScannerHandle scanner, out GdkColor color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_test_create_widget(GType widget_type, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_stock_lookup(string stock_id, out GtkStockItem item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_default(GdkDragContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_rc_get_default_files();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stock_set_translate_func(string domain, GtkTranslateFunc func, IntPtr data, GDestroyNotify notify);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_rgb_to_hsv(double r, double g, double b, out double h, out double s, out double v);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_targets_include_text(GdkAtom[] targets, int n_targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_rc_find_module_in_path(string module_file);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_key_snooper_install(GtkKeySnoopFunc snooper, IntPtr func_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_show_uri(GdkScreenHandle screen, string uri, uint timestamp, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stock_add(GtkStockItem[] items, uint n_items);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_main();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_rc_parse(string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_init_with_args(ref int argc, ref string[] argv, string parameter_string, GOptionEntry[] entries, string translation_domain, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_test_display_button_window(string window_title, string dialog_text, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_major_version();

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_rc_parse_priority(GScannerHandle scanner, ref GtkPathPriorityType priority);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_set_icon_name(GdkDragContextHandle context, string icon_name, int hot_x, int hot_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_get_interface_age();

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_target_table_new_from_list(GtkTargetListHandle list, out int n_targets);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_get_event_widget(GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_bindings_activate(GObjectHandle @object, uint keyval, GdkModifierType modifiers);

}
