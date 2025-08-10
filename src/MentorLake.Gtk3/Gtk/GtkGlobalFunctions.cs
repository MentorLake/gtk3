namespace MentorLake.Gtk;

public class GtkGlobalFunctions
{
	public static bool AccelGroupsActivate(MentorLake.GObject.GObjectHandle @object, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accel_groups_activate(@object, accel_key, accel_mods);
	}

	public static MentorLake.GLib.GSListHandle AccelGroupsFromObject(MentorLake.GObject.GObjectHandle @object)
	{
		return GtkGlobalFunctionsExterns.gtk_accel_groups_from_object(@object);
	}

	public static MentorLake.Gdk.GdkModifierType AcceleratorGetDefaultModMask()
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_get_default_mod_mask();
	}

	public static string AcceleratorGetLabel(uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_get_label(accelerator_key, accelerator_mods);
	}

	public static string AcceleratorGetLabelWithKeycode(MentorLake.Gdk.GdkDisplayHandle display, uint accelerator_key, uint keycode, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_get_label_with_keycode(display, accelerator_key, keycode, accelerator_mods);
	}

	public static string AcceleratorName(uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_name(accelerator_key, accelerator_mods);
	}

	public static string AcceleratorNameWithKeycode(MentorLake.Gdk.GdkDisplayHandle display, uint accelerator_key, uint keycode, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_name_with_keycode(display, accelerator_key, keycode, accelerator_mods);
	}

	public static void AcceleratorParse(string accelerator, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		GtkGlobalFunctionsExterns.gtk_accelerator_parse(accelerator, out accelerator_key, out accelerator_mods);
	}

	public static void AcceleratorParseWithKeycode(string accelerator, out uint accelerator_key, out uint[] accelerator_codes, out MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		GtkGlobalFunctionsExterns.gtk_accelerator_parse_with_keycode(accelerator, out accelerator_key, out accelerator_codes, out accelerator_mods);
	}

	public static void AcceleratorSetDefaultModMask(MentorLake.Gdk.GdkModifierType default_mod_mask)
	{
		GtkGlobalFunctionsExterns.gtk_accelerator_set_default_mod_mask(default_mod_mask);
	}

	public static bool AcceleratorValid(uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_valid(keyval, modifiers);
	}

	public static bool AlternativeDialogButtonOrder(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkGlobalFunctionsExterns.gtk_alternative_dialog_button_order(screen);
	}

	public static MentorLake.GLib.GTokenType BindingEntryAddSignalFromString(MentorLake.Gtk.GtkBindingSetHandle binding_set, string signal_desc)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_entry_add_signal_from_string(binding_set, signal_desc);
	}

	public static void BindingEntryAddSignall(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, MentorLake.GLib.GSListHandle binding_args)
	{
		GtkGlobalFunctionsExterns.gtk_binding_entry_add_signall(binding_set, keyval, modifiers, signal_name, binding_args);
	}

	public static void BindingEntryRemove(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkGlobalFunctionsExterns.gtk_binding_entry_remove(binding_set, keyval, modifiers);
	}

	public static void BindingEntrySkip(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkGlobalFunctionsExterns.gtk_binding_entry_skip(binding_set, keyval, modifiers);
	}

	public static MentorLake.Gtk.GtkBindingSetHandle BindingSetByClass(IntPtr object_class)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_set_by_class(object_class);
	}

	public static MentorLake.Gtk.GtkBindingSetHandle BindingSetFind(string set_name)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_set_find(set_name);
	}

	public static MentorLake.Gtk.GtkBindingSetHandle BindingSetNew(string set_name)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_set_new(set_name);
	}

	public static bool BindingsActivate(MentorLake.GObject.GObjectHandle @object, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_bindings_activate(@object, keyval, modifiers);
	}

	public static bool BindingsActivateEvent(MentorLake.GObject.GObjectHandle @object, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		return GtkGlobalFunctionsExterns.gtk_bindings_activate_event(@object, @event);
	}

	public static MentorLake.GLib.GQuark BuilderErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_builder_error_quark();
	}

	public static bool CairoShouldDrawWindow(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window)
	{
		return GtkGlobalFunctionsExterns.gtk_cairo_should_draw_window(cr, window);
	}

	public static void CairoTransformToWindow(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkWindowHandle window)
	{
		GtkGlobalFunctionsExterns.gtk_cairo_transform_to_window(cr, widget, window);
	}

	public static string CheckVersion(uint required_major, uint required_minor, uint required_micro)
	{
		return GtkGlobalFunctionsExterns.gtk_check_version(required_major, required_minor, required_micro);
	}

	public static MentorLake.GLib.GQuark CssProviderErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_css_provider_error_quark();
	}

	public static void DeviceGrabAdd(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device, bool block_others)
	{
		GtkGlobalFunctionsExterns.gtk_device_grab_add(widget, device, block_others);
	}

	public static void DeviceGrabRemove(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		GtkGlobalFunctionsExterns.gtk_device_grab_remove(widget, device);
	}

	public static void DisableSetlocale()
	{
		GtkGlobalFunctionsExterns.gtk_disable_setlocale();
	}

	public static int DistributeNaturalAllocation(int extra_space, uint n_requested_sizes, MentorLake.Gtk.GtkRequestedSizeHandle sizes)
	{
		return GtkGlobalFunctionsExterns.gtk_distribute_natural_allocation(extra_space, n_requested_sizes, sizes);
	}

	public static void DragCancel(MentorLake.Gdk.GdkDragContextHandle context)
	{
		GtkGlobalFunctionsExterns.gtk_drag_cancel(context);
	}

	public static void DragFinish(MentorLake.Gdk.GdkDragContextHandle context, bool success, bool del, uint time_)
	{
		GtkGlobalFunctionsExterns.gtk_drag_finish(context, success, del, time_);
	}

	public static MentorLake.Gtk.GtkWidgetHandle DragGetSourceWidget(MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GtkGlobalFunctionsExterns.gtk_drag_get_source_widget(context);
	}

	public static void DragSetIconDefault(MentorLake.Gdk.GdkDragContextHandle context)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_default(context);
	}

	public static void DragSetIconGicon(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gio.GIconHandle icon, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_gicon(context, icon, hot_x, hot_y);
	}

	public static void DragSetIconName(MentorLake.Gdk.GdkDragContextHandle context, string icon_name, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_name(context, icon_name, hot_x, hot_y);
	}

	public static void DragSetIconPixbuf(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_pixbuf(context, pixbuf, hot_x, hot_y);
	}

	public static void DragSetIconStock(MentorLake.Gdk.GdkDragContextHandle context, string stock_id, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_stock(context, stock_id, hot_x, hot_y);
	}

	public static void DragSetIconSurface(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.cairo.cairo_surface_tHandle surface)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_surface(context, surface);
	}

	public static void DragSetIconWidget(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_widget(context, widget, hot_x, hot_y);
	}

	public static void DrawInsertionCursor(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRectangleHandle location, bool is_primary, MentorLake.Gtk.GtkTextDirection direction, bool draw_arrow)
	{
		GtkGlobalFunctionsExterns.gtk_draw_insertion_cursor(widget, cr, location, is_primary, direction, draw_arrow);
	}

	public static bool EventsPending()
	{
		return GtkGlobalFunctionsExterns.gtk_events_pending();
	}

	public static bool False()
	{
		return GtkGlobalFunctionsExterns.gtk_false();
	}

	public static MentorLake.GLib.GQuark FileChooserErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_file_chooser_error_quark();
	}

	public static uint GetBinaryAge()
	{
		return GtkGlobalFunctionsExterns.gtk_get_binary_age();
	}

	public static MentorLake.Gdk.GdkEventHandle GetCurrentEvent()
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event();
	}

	public static MentorLake.Gdk.GdkDeviceHandle GetCurrentEventDevice()
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event_device();
	}

	public static bool GetCurrentEventState(out MentorLake.Gdk.GdkModifierType state)
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event_state(out state);
	}

	public static uint GetCurrentEventTime()
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event_time();
	}

	public static uint GetDebugFlags()
	{
		return GtkGlobalFunctionsExterns.gtk_get_debug_flags();
	}

	public static MentorLake.Pango.PangoLanguageHandle GetDefaultLanguage()
	{
		return GtkGlobalFunctionsExterns.gtk_get_default_language();
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetEventWidget(MentorLake.Gdk.GdkEventHandle @event)
	{
		return GtkGlobalFunctionsExterns.gtk_get_event_widget(@event);
	}

	public static uint GetInterfaceAge()
	{
		return GtkGlobalFunctionsExterns.gtk_get_interface_age();
	}

	public static MentorLake.Gtk.GtkTextDirection GetLocaleDirection()
	{
		return GtkGlobalFunctionsExterns.gtk_get_locale_direction();
	}

	public static uint GetMajorVersion()
	{
		return GtkGlobalFunctionsExterns.gtk_get_major_version();
	}

	public static uint GetMicroVersion()
	{
		return GtkGlobalFunctionsExterns.gtk_get_micro_version();
	}

	public static uint GetMinorVersion()
	{
		return GtkGlobalFunctionsExterns.gtk_get_minor_version();
	}

	public static MentorLake.GLib.GOptionGroupHandle GetOptionGroup(bool open_default_display)
	{
		return GtkGlobalFunctionsExterns.gtk_get_option_group(open_default_display);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GrabGetCurrent()
	{
		return GtkGlobalFunctionsExterns.gtk_grab_get_current();
	}

	public static MentorLake.Gtk.GtkIconSize IconSizeFromName(string name)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_from_name(name);
	}

	public static string IconSizeGetName(MentorLake.Gtk.GtkIconSize size)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_get_name(size);
	}

	public static bool IconSizeLookup(MentorLake.Gtk.GtkIconSize size, out int width, out int height)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_lookup(size, out width, out height);
	}

	public static bool IconSizeLookupForSettings(MentorLake.Gtk.GtkSettingsHandle settings, MentorLake.Gtk.GtkIconSize size, out int width, out int height)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_lookup_for_settings(settings, size, out width, out height);
	}

	public static MentorLake.Gtk.GtkIconSize IconSizeRegister(string name, int width, int height)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_register(name, width, height);
	}

	public static void IconSizeRegisterAlias(string alias, MentorLake.Gtk.GtkIconSize target)
	{
		GtkGlobalFunctionsExterns.gtk_icon_size_register_alias(alias, target);
	}

	public static MentorLake.GLib.GQuark IconThemeErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_icon_theme_error_quark();
	}

	public static void Init(ref int argc, ref string[] argv)
	{
		GtkGlobalFunctionsExterns.gtk_init(ref argc, ref argv);
	}

	public static bool InitCheck(ref int argc, ref string[] argv)
	{
		return GtkGlobalFunctionsExterns.gtk_init_check(ref argc, ref argv);
	}

	public static bool InitWithArgs(ref int argc, ref string[] argv, string parameter_string, MentorLake.GLib.GOptionEntry[] entries, string translation_domain)
	{
		var externCallResult = GtkGlobalFunctionsExterns.gtk_init_with_args(ref argc, ref argv, parameter_string, entries, translation_domain, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static uint KeySnooperInstall(MentorLake.Gtk.GtkKeySnoopFunc snooper, IntPtr func_data)
	{
		return GtkGlobalFunctionsExterns.gtk_key_snooper_install(snooper, func_data);
	}

	public static void KeySnooperRemove(uint snooper_handler_id)
	{
		GtkGlobalFunctionsExterns.gtk_key_snooper_remove(snooper_handler_id);
	}

	public static void Main()
	{
		GtkGlobalFunctionsExterns.gtk_main();
	}

	public static void MainDoEvent(MentorLake.Gdk.GdkEventHandle @event)
	{
		GtkGlobalFunctionsExterns.gtk_main_do_event(@event);
	}

	public static bool MainIteration()
	{
		return GtkGlobalFunctionsExterns.gtk_main_iteration();
	}

	public static bool MainIterationDo(bool blocking)
	{
		return GtkGlobalFunctionsExterns.gtk_main_iteration_do(blocking);
	}

	public static uint MainLevel()
	{
		return GtkGlobalFunctionsExterns.gtk_main_level();
	}

	public static void MainQuit()
	{
		GtkGlobalFunctionsExterns.gtk_main_quit();
	}

	public static void PaintArrow(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, MentorLake.Gtk.GtkArrowType arrow_type, bool fill, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_arrow(style, cr, state_type, shadow_type, widget, detail, arrow_type, fill, x, y, width, height);
	}

	public static void PaintBox(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_box(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintBoxGap(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side, int gap_x, int gap_width)
	{
		GtkGlobalFunctionsExterns.gtk_paint_box_gap(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side, gap_x, gap_width);
	}

	public static void PaintCheck(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_check(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintDiamond(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_diamond(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintExpander(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, MentorLake.Gtk.GtkExpanderStyle expander_style)
	{
		GtkGlobalFunctionsExterns.gtk_paint_expander(style, cr, state_type, widget, detail, x, y, expander_style);
	}

	public static void PaintExtension(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side)
	{
		GtkGlobalFunctionsExterns.gtk_paint_extension(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side);
	}

	public static void PaintFlatBox(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_flat_box(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintFocus(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_focus(style, cr, state_type, widget, detail, x, y, width, height);
	}

	public static void PaintHandle(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkOrientation orientation)
	{
		GtkGlobalFunctionsExterns.gtk_paint_handle(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, orientation);
	}

	public static void PaintHline(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x1, int x2, int y)
	{
		GtkGlobalFunctionsExterns.gtk_paint_hline(style, cr, state_type, widget, detail, x1, x2, y);
	}

	public static void PaintLayout(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, bool use_text, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, MentorLake.Pango.PangoLayoutHandle layout)
	{
		GtkGlobalFunctionsExterns.gtk_paint_layout(style, cr, state_type, use_text, widget, detail, x, y, layout);
	}

	public static void PaintOption(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_option(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintResizeGrip(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, MentorLake.Gdk.GdkWindowEdge edge, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_resize_grip(style, cr, state_type, widget, detail, edge, x, y, width, height);
	}

	public static void PaintShadow(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_shadow(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintShadowGap(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side, int gap_x, int gap_width)
	{
		GtkGlobalFunctionsExterns.gtk_paint_shadow_gap(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side, gap_x, gap_width);
	}

	public static void PaintSlider(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkOrientation orientation)
	{
		GtkGlobalFunctionsExterns.gtk_paint_slider(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, orientation);
	}

	public static void PaintSpinner(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, uint step, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_spinner(style, cr, state_type, widget, detail, step, x, y, width, height);
	}

	public static void PaintTab(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_tab(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

	public static void PaintVline(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int y1_, int y2_, int x)
	{
		GtkGlobalFunctionsExterns.gtk_paint_vline(style, cr, state_type, widget, detail, y1_, y2_, x);
	}

	public static string PaperSizeGetDefault()
	{
		return GtkGlobalFunctionsExterns.gtk_paper_size_get_default();
	}

	public static MentorLake.GLib.GListHandle PaperSizeGetPaperSizes(bool include_custom)
	{
		return GtkGlobalFunctionsExterns.gtk_paper_size_get_paper_sizes(include_custom);
	}

	public static bool ParseArgs(ref int argc, ref string[] argv)
	{
		return GtkGlobalFunctionsExterns.gtk_parse_args(ref argc, ref argv);
	}

	public static MentorLake.GLib.GQuark PrintErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_print_error_quark();
	}

	public static MentorLake.Gtk.GtkPageSetupHandle PrintRunPageSetupDialog(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkPageSetupHandle page_setup, MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkGlobalFunctionsExterns.gtk_print_run_page_setup_dialog(parent, page_setup, settings);
	}

	public static void PrintRunPageSetupDialogAsync(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkPageSetupHandle page_setup, MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPageSetupDoneFunc done_cb, IntPtr data)
	{
		GtkGlobalFunctionsExterns.gtk_print_run_page_setup_dialog_async(parent, page_setup, settings, done_cb, data);
	}

	public static void PropagateEvent(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		GtkGlobalFunctionsExterns.gtk_propagate_event(widget, @event);
	}

	public static void RcAddDefaultFile(string filename)
	{
		GtkGlobalFunctionsExterns.gtk_rc_add_default_file(filename);
	}

	public static string RcFindModuleInPath(string module_file)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_find_module_in_path(module_file);
	}

	public static string RcFindPixmapInPath(MentorLake.Gtk.GtkSettingsHandle settings, MentorLake.GLib.GScannerHandle scanner, string pixmap_file)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_find_pixmap_in_path(settings, scanner, pixmap_file);
	}

	public static string[] RcGetDefaultFiles()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_default_files();
	}

	public static string RcGetImModuleFile()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_im_module_file();
	}

	public static string RcGetImModulePath()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_im_module_path();
	}

	public static string RcGetModuleDir()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_module_dir();
	}

	public static MentorLake.Gtk.GtkStyleHandle RcGetStyle(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_style(widget);
	}

	public static MentorLake.Gtk.GtkStyleHandle RcGetStyleByPaths(MentorLake.Gtk.GtkSettingsHandle settings, string widget_path, string class_path, MentorLake.GObject.GType type)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_style_by_paths(settings, widget_path, class_path, type);
	}

	public static string RcGetThemeDir()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_theme_dir();
	}

	public static void RcParse(string filename)
	{
		GtkGlobalFunctionsExterns.gtk_rc_parse(filename);
	}

	public static uint RcParseColor(MentorLake.GLib.GScannerHandle scanner, out MentorLake.Gdk.GdkColor color)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_color(scanner, out color);
	}

	public static uint RcParseColorFull(MentorLake.GLib.GScannerHandle scanner, MentorLake.Gtk.GtkRcStyleHandle style, out MentorLake.Gdk.GdkColor color)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_color_full(scanner, style, out color);
	}

	public static uint RcParsePriority(MentorLake.GLib.GScannerHandle scanner, ref MentorLake.Gtk.GtkPathPriorityType priority)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_priority(scanner, ref priority);
	}

	public static uint RcParseState(MentorLake.GLib.GScannerHandle scanner, out MentorLake.Gtk.GtkStateType state)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_state(scanner, out state);
	}

	public static void RcParseString(string rc_string)
	{
		GtkGlobalFunctionsExterns.gtk_rc_parse_string(rc_string);
	}

	public static bool RcPropertyParseBorder(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_border(pspec, gstring, property_value);
	}

	public static bool RcPropertyParseColor(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_color(pspec, gstring, property_value);
	}

	public static bool RcPropertyParseEnum(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_enum(pspec, gstring, property_value);
	}

	public static bool RcPropertyParseFlags(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_flags(pspec, gstring, property_value);
	}

	public static bool RcPropertyParseRequisition(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_requisition(pspec, gstring, property_value);
	}

	public static bool RcReparseAll()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_reparse_all();
	}

	public static bool RcReparseAllForSettings(MentorLake.Gtk.GtkSettingsHandle settings, bool force_load)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_reparse_all_for_settings(settings, force_load);
	}

	public static void RcResetStyles(MentorLake.Gtk.GtkSettingsHandle settings)
	{
		GtkGlobalFunctionsExterns.gtk_rc_reset_styles(settings);
	}

	public static MentorLake.GLib.GScannerHandle RcScannerNew()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_scanner_new();
	}

	public static void RcSetDefaultFiles(string[] filenames)
	{
		GtkGlobalFunctionsExterns.gtk_rc_set_default_files(filenames);
	}

	public static MentorLake.GLib.GQuark RecentChooserErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_recent_chooser_error_quark();
	}

	public static MentorLake.GLib.GQuark RecentManagerErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_recent_manager_error_quark();
	}

	public static void RenderActivity(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_activity(context, cr, x, y, width, height);
	}

	public static void RenderArrow(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double angle, double x, double y, double size)
	{
		GtkGlobalFunctionsExterns.gtk_render_arrow(context, cr, angle, x, y, size);
	}

	public static void RenderBackground(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_background(context, cr, x, y, width, height);
	}

	public static void RenderBackgroundGetClip(MentorLake.Gtk.GtkStyleContextHandle context, double x, double y, double width, double height, out MentorLake.Gdk.GdkRectangle out_clip)
	{
		GtkGlobalFunctionsExterns.gtk_render_background_get_clip(context, x, y, width, height, out out_clip);
	}

	public static void RenderCheck(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_check(context, cr, x, y, width, height);
	}

	public static void RenderExpander(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_expander(context, cr, x, y, width, height);
	}

	public static void RenderExtension(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkPositionType gap_side)
	{
		GtkGlobalFunctionsExterns.gtk_render_extension(context, cr, x, y, width, height, gap_side);
	}

	public static void RenderFocus(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_focus(context, cr, x, y, width, height);
	}

	public static void RenderFrame(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_frame(context, cr, x, y, width, height);
	}

	public static void RenderFrameGap(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkPositionType gap_side, double xy0_gap, double xy1_gap)
	{
		GtkGlobalFunctionsExterns.gtk_render_frame_gap(context, cr, x, y, width, height, gap_side, xy0_gap, xy1_gap);
	}

	public static void RenderHandle(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_handle(context, cr, x, y, width, height);
	}

	public static void RenderIcon(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, double x, double y)
	{
		GtkGlobalFunctionsExterns.gtk_render_icon(context, cr, pixbuf, x, y);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIconPixbuf(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkGlobalFunctionsExterns.gtk_render_icon_pixbuf(context, source, size);
	}

	public static void RenderIconSurface(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_surface_tHandle surface, double x, double y)
	{
		GtkGlobalFunctionsExterns.gtk_render_icon_surface(context, cr, surface, x, y);
	}

	public static void RenderInsertionCursor(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, MentorLake.Pango.PangoLayoutHandle layout, int index, MentorLake.Pango.PangoDirection direction)
	{
		GtkGlobalFunctionsExterns.gtk_render_insertion_cursor(context, cr, x, y, layout, index, direction);
	}

	public static void RenderLayout(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, MentorLake.Pango.PangoLayoutHandle layout)
	{
		GtkGlobalFunctionsExterns.gtk_render_layout(context, cr, x, y, layout);
	}

	public static void RenderLine(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x0, double y0, double x1, double y1)
	{
		GtkGlobalFunctionsExterns.gtk_render_line(context, cr, x0, y0, x1, y1);
	}

	public static void RenderOption(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_option(context, cr, x, y, width, height);
	}

	public static void RenderSlider(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkOrientation orientation)
	{
		GtkGlobalFunctionsExterns.gtk_render_slider(context, cr, x, y, width, height, orientation);
	}

	public static void RgbToHsv(double r, double g, double b, out double h, out double s, out double v)
	{
		GtkGlobalFunctionsExterns.gtk_rgb_to_hsv(r, g, b, out h, out s, out v);
	}

	public static void SelectionAddTarget(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint info)
	{
		GtkGlobalFunctionsExterns.gtk_selection_add_target(widget, selection, target, info);
	}

	public static void SelectionAddTargets(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets)
	{
		GtkGlobalFunctionsExterns.gtk_selection_add_targets(widget, selection, targets, ntargets);
	}

	public static void SelectionClearTargets(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection)
	{
		GtkGlobalFunctionsExterns.gtk_selection_clear_targets(widget, selection);
	}

	public static bool SelectionConvert(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint time_)
	{
		return GtkGlobalFunctionsExterns.gtk_selection_convert(widget, selection, target, time_);
	}

	public static bool SelectionOwnerSet(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, uint time_)
	{
		return GtkGlobalFunctionsExterns.gtk_selection_owner_set(widget, selection, time_);
	}

	public static bool SelectionOwnerSetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, uint time_)
	{
		return GtkGlobalFunctionsExterns.gtk_selection_owner_set_for_display(display, widget, selection, time_);
	}

	public static void SelectionRemoveAll(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		GtkGlobalFunctionsExterns.gtk_selection_remove_all(widget);
	}

	public static void SetDebugFlags(uint flags)
	{
		GtkGlobalFunctionsExterns.gtk_set_debug_flags(flags);
	}

	public static void ShowAboutDialog(MentorLake.Gtk.GtkWindowHandle parent, string first_property_name, IntPtr @__arglist)
	{
		GtkGlobalFunctionsExterns.gtk_show_about_dialog(parent, first_property_name, @__arglist);
	}

	public static bool ShowUri(MentorLake.Gdk.GdkScreenHandle screen, string uri, uint timestamp)
	{
		var externCallResult = GtkGlobalFunctionsExterns.gtk_show_uri(screen, uri, timestamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool ShowUriOnWindow(MentorLake.Gtk.GtkWindowHandle parent, string uri, uint timestamp)
	{
		var externCallResult = GtkGlobalFunctionsExterns.gtk_show_uri_on_window(parent, uri, timestamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void StockAdd(MentorLake.Gtk.GtkStockItem[] items, uint n_items)
	{
		GtkGlobalFunctionsExterns.gtk_stock_add(items, n_items);
	}

	public static void StockAddStatic(MentorLake.Gtk.GtkStockItem[] items, uint n_items)
	{
		GtkGlobalFunctionsExterns.gtk_stock_add_static(items, n_items);
	}

	public static MentorLake.GLib.GSListHandle StockListIds()
	{
		return GtkGlobalFunctionsExterns.gtk_stock_list_ids();
	}

	public static bool StockLookup(string stock_id, out MentorLake.Gtk.GtkStockItem item)
	{
		return GtkGlobalFunctionsExterns.gtk_stock_lookup(stock_id, out item);
	}

	public static void StockSetTranslateFunc(string domain, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GtkGlobalFunctionsExterns.gtk_stock_set_translate_func(domain, func, data, notify);
	}

	public static void TargetTableFree(MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets)
	{
		GtkGlobalFunctionsExterns.gtk_target_table_free(targets, n_targets);
	}

	public static MentorLake.Gtk.GtkTargetEntry[] TargetTableNewFromList(MentorLake.Gtk.GtkTargetListHandle list, out int n_targets)
	{
		return GtkGlobalFunctionsExterns.gtk_target_table_new_from_list(list, out n_targets);
	}

	public static bool TargetsIncludeImage(MentorLake.Gdk.GdkAtom[] targets, int n_targets, bool writable)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_image(targets, n_targets, writable);
	}

	public static bool TargetsIncludeRichText(MentorLake.Gdk.GdkAtom[] targets, int n_targets, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_rich_text(targets, n_targets, buffer);
	}

	public static bool TargetsIncludeText(MentorLake.Gdk.GdkAtom[] targets, int n_targets)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_text(targets, n_targets);
	}

	public static bool TargetsIncludeUri(MentorLake.Gdk.GdkAtom[] targets, int n_targets)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_uri(targets, n_targets);
	}

	public static MentorLake.Gtk.GtkWidgetHandle TestCreateSimpleWindow(string window_title, string dialog_text)
	{
		return GtkGlobalFunctionsExterns.gtk_test_create_simple_window(window_title, dialog_text);
	}

	public static MentorLake.Gtk.GtkWidgetHandle TestCreateWidget(MentorLake.GObject.GType widget_type, string first_property_name, IntPtr @__arglist)
	{
		return GtkGlobalFunctionsExterns.gtk_test_create_widget(widget_type, first_property_name, @__arglist);
	}

	public static MentorLake.Gtk.GtkWidgetHandle TestDisplayButtonWindow(string window_title, string dialog_text, IntPtr @__arglist)
	{
		return GtkGlobalFunctionsExterns.gtk_test_display_button_window(window_title, dialog_text, @__arglist);
	}

	public static MentorLake.Gtk.GtkWidgetHandle TestFindLabel(MentorLake.Gtk.GtkWidgetHandle widget, string label_pattern)
	{
		return GtkGlobalFunctionsExterns.gtk_test_find_label(widget, label_pattern);
	}

	public static MentorLake.Gtk.GtkWidgetHandle TestFindSibling(MentorLake.Gtk.GtkWidgetHandle base_widget, MentorLake.GObject.GType widget_type)
	{
		return GtkGlobalFunctionsExterns.gtk_test_find_sibling(base_widget, widget_type);
	}

	public static MentorLake.Gtk.GtkWidgetHandle TestFindWidget(MentorLake.Gtk.GtkWidgetHandle widget, string label_pattern, MentorLake.GObject.GType widget_type)
	{
		return GtkGlobalFunctionsExterns.gtk_test_find_widget(widget, label_pattern, widget_type);
	}

	public static void TestInit(ref int argcp, ref string[] argvp, IntPtr @__arglist)
	{
		GtkGlobalFunctionsExterns.gtk_test_init(ref argcp, ref argvp, @__arglist);
	}

	public static MentorLake.GObject.GType[] TestListAllTypes(out uint n_types)
	{
		return GtkGlobalFunctionsExterns.gtk_test_list_all_types(out n_types);
	}

	public static void TestRegisterAllTypes()
	{
		GtkGlobalFunctionsExterns.gtk_test_register_all_types();
	}

	public static double TestSliderGetValue(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGlobalFunctionsExterns.gtk_test_slider_get_value(widget);
	}

	public static void TestSliderSetPerc(MentorLake.Gtk.GtkWidgetHandle widget, double percentage)
	{
		GtkGlobalFunctionsExterns.gtk_test_slider_set_perc(widget, percentage);
	}

	public static bool TestSpinButtonClick(MentorLake.Gtk.GtkSpinButtonHandle spinner, uint button, bool upwards)
	{
		return GtkGlobalFunctionsExterns.gtk_test_spin_button_click(spinner, button, upwards);
	}

	public static string TestTextGet(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGlobalFunctionsExterns.gtk_test_text_get(widget);
	}

	public static void TestTextSet(MentorLake.Gtk.GtkWidgetHandle widget, string @string)
	{
		GtkGlobalFunctionsExterns.gtk_test_text_set(widget, @string);
	}

	public static bool TestWidgetClick(MentorLake.Gtk.GtkWidgetHandle widget, uint button, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_test_widget_click(widget, button, modifiers);
	}

	public static bool TestWidgetSendKey(MentorLake.Gtk.GtkWidgetHandle widget, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_test_widget_send_key(widget, keyval, modifiers);
	}

	public static void TestWidgetWaitForDraw(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		GtkGlobalFunctionsExterns.gtk_test_widget_wait_for_draw(widget);
	}

	public static bool TreeGetRowDragData(MentorLake.Gtk.GtkSelectionDataHandle selection_data, out MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkGlobalFunctionsExterns.gtk_tree_get_row_drag_data(selection_data, out tree_model, out path);
	}

	public static void TreeRowReferenceDeleted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkGlobalFunctionsExterns.gtk_tree_row_reference_deleted(proxy, path);
	}

	public static void TreeRowReferenceInserted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkGlobalFunctionsExterns.gtk_tree_row_reference_inserted(proxy, path);
	}

	public static void TreeRowReferenceReordered(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order)
	{
		GtkGlobalFunctionsExterns.gtk_tree_row_reference_reordered(proxy, path, iter, new_order);
	}

	public static bool TreeSetRowDragData(MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkGlobalFunctionsExterns.gtk_tree_set_row_drag_data(selection_data, tree_model, path);
	}

	public static bool True()
	{
		return GtkGlobalFunctionsExterns.gtk_true();
	}

}

internal class GtkGlobalFunctionsExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_groups_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_accel_groups_from_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gtk_accelerator_get_default_mod_mask();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_accelerator_get_label(uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_accelerator_get_label_with_keycode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, uint accelerator_key, uint keycode, MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_accelerator_name(uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_accelerator_name_with_keycode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, uint accelerator_key, uint keycode, MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accelerator_parse(string accelerator, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accelerator_parse_with_keycode(string accelerator, out uint accelerator_key, [MarshalAs(UnmanagedType.LPArray)] out uint[] accelerator_codes, out MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accelerator_set_default_mod_mask(MentorLake.Gdk.GdkModifierType default_mod_mask);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accelerator_valid(uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_alternative_dialog_button_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GTokenType gtk_binding_entry_add_signal_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, string signal_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_add_signall([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle binding_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_skip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_by_class(IntPtr object_class);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_find(string set_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_new(string set_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_bindings_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_bindings_activate_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_builder_error_quark();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cairo_should_draw_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cairo_transform_to_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_css_provider_error_quark();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_device_grab_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, bool block_others);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_device_grab_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_disable_setlocale();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_distribute_natural_allocation(int extra_space, uint n_requested_sizes, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequestedSizeHandle>))] MentorLake.Gtk.GtkRequestedSizeHandle sizes);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, bool success, bool del, uint time_);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_drag_get_source_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, int hot_x, int hot_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, string icon_name, int hot_x, int hot_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int hot_x, int hot_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, string stock_id, int hot_x, int hot_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_set_icon_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int hot_x, int hot_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_draw_insertion_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle location, bool is_primary, MentorLake.Gtk.GtkTextDirection direction, bool draw_arrow);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_events_pending();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_false();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_file_chooser_error_quark();

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_binary_age();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gtk_get_current_event();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))]
	internal static extern MentorLake.Gdk.GdkDeviceHandle gtk_get_current_event_device();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_get_current_event_state(out MentorLake.Gdk.GdkModifierType state);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_current_event_time();

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_debug_flags();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle gtk_get_default_language();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_get_event_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_interface_age();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_get_locale_direction();

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_major_version();

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_micro_version();

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_get_minor_version();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))]
	internal static extern MentorLake.GLib.GOptionGroupHandle gtk_get_option_group(bool open_default_display);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_grab_get_current();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_icon_size_from_name(string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_size_get_name(MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_size_lookup(MentorLake.Gtk.GtkIconSize size, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_size_lookup_for_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, MentorLake.Gtk.GtkIconSize size, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconSize gtk_icon_size_register(string name, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_size_register_alias(string alias, MentorLake.Gtk.GtkIconSize target);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_icon_theme_error_quark();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_init(ref int argc, ref string[] argv);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_init_check(ref int argc, ref string[] argv);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_init_with_args(ref int argc, ref string[] argv, string parameter_string, MentorLake.GLib.GOptionEntry[] entries, string translation_domain, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_key_snooper_install(MentorLake.Gtk.GtkKeySnoopFunc snooper, IntPtr func_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_key_snooper_remove(uint snooper_handler_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_main();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_main_do_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_main_iteration();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_main_iteration_do(bool blocking);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_main_level();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_main_quit();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_arrow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, MentorLake.Gtk.GtkArrowType arrow_type, bool fill, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_box_gap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side, int gap_x, int gap_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_diamond([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_expander([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, MentorLake.Gtk.GtkExpanderStyle expander_style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_flat_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_hline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x1, int x2, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, bool use_text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_resize_grip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, MentorLake.Gdk.GdkWindowEdge edge, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_shadow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_shadow_gap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side, int gap_x, int gap_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_slider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_spinner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, uint step, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paint_vline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string detail, int y1_, int y2_, int x);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_default();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_paper_size_get_paper_sizes(bool include_custom);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_parse_args(ref int argc, ref string[] argv);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_print_error_quark();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_print_run_page_setup_dialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle page_setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_run_page_setup_dialog_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle page_setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPageSetupDoneFunc done_cb, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_propagate_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_rc_add_default_file(string filename);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_rc_find_module_in_path(string module_file);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_rc_find_pixmap_in_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, string pixmap_file);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_rc_get_default_files();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_rc_get_im_module_file();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_rc_get_im_module_path();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_rc_get_module_dir();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_rc_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_rc_get_style_by_paths([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, string widget_path, string class_path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_rc_get_theme_dir();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_rc_parse(string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_rc_parse_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_rc_parse_color_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))] MentorLake.Gtk.GtkRcStyleHandle style, out MentorLake.Gdk.GdkColor color);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_rc_parse_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, ref MentorLake.Gtk.GtkPathPriorityType priority);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_rc_parse_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, out MentorLake.Gtk.GtkStateType state);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_rc_parse_string(string rc_string);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_property_parse_requisition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle gstring, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle property_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_reparse_all();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_rc_reparse_all_for_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, bool force_load);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_rc_reset_styles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))]
	internal static extern MentorLake.GLib.GScannerHandle gtk_rc_scanner_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_rc_set_default_files(string[] filenames);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_recent_chooser_error_quark();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gtk_recent_manager_error_quark();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_activity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_arrow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double angle, double x, double y, double size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_background_get_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, double x, double y, double width, double height, out MentorLake.Gdk.GdkRectangle out_clip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_expander([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkPositionType gap_side);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_frame_gap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkPositionType gap_side, double xy0_gap, double xy1_gap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, double x, double y);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_render_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSourceHandle>))] MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_icon_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, double x, double y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_insertion_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index, MentorLake.Pango.PangoDirection direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x0, double y0, double x1, double y1);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_render_slider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_rgb_to_hsv(double r, double g, double b, out double h, out double s, out double v);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_selection_add_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_selection_add_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_selection_clear_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_convert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint time_);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_owner_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, uint time_);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_owner_set_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, uint time_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_selection_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_set_debug_flags(uint flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_show_about_dialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_show_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, string uri, uint timestamp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_show_uri_on_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, string uri, uint timestamp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stock_add(MentorLake.Gtk.GtkStockItem[] items, uint n_items);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stock_add_static(MentorLake.Gtk.GtkStockItem[] items, uint n_items);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_stock_list_ids();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_stock_lookup(string stock_id, out MentorLake.Gtk.GtkStockItem item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stock_set_translate_func(string domain, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_table_free(MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetEntry[] gtk_target_table_new_from_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, out int n_targets);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_targets_include_image(MentorLake.Gdk.GdkAtom[] targets, int n_targets, bool writable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_targets_include_rich_text(MentorLake.Gdk.GdkAtom[] targets, int n_targets, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_targets_include_text(MentorLake.Gdk.GdkAtom[] targets, int n_targets);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_targets_include_uri(MentorLake.Gdk.GdkAtom[] targets, int n_targets);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_test_create_simple_window(string window_title, string dialog_text);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_test_create_widget(MentorLake.GObject.GType widget_type, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_test_display_button_window(string window_title, string dialog_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_test_find_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string label_pattern);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_test_find_sibling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle base_widget, MentorLake.GObject.GType widget_type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_test_find_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string label_pattern, MentorLake.GObject.GType widget_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_test_init(ref int argcp, ref string[] argvp, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType[] gtk_test_list_all_types(out uint n_types);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_test_register_all_types();

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_test_slider_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_test_slider_set_perc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, double percentage);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_test_spin_button_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spinner, uint button, bool upwards);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_test_text_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_test_text_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string @string);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_test_widget_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint button, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_test_widget_send_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_test_widget_wait_for_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_get_row_drag_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] out MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_set_row_drag_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_true();

}
