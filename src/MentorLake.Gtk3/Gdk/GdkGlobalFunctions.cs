namespace MentorLake.Gdk;

public class GdkGlobalFunctions
{
	public static void AddOptionEntriesLibgtkOnly(MentorLake.GLib.GOptionGroupHandle group)
	{
		GdkGlobalFunctionsExterns.gdk_add_option_entries_libgtk_only(group);
	}

	public static MentorLake.Gdk.GdkAtom AtomIntern(string atom_name, bool only_if_exists)
	{
		return GdkGlobalFunctionsExterns.gdk_atom_intern(atom_name, only_if_exists);
	}

	public static MentorLake.Gdk.GdkAtom AtomInternStaticString(string atom_name)
	{
		return GdkGlobalFunctionsExterns.gdk_atom_intern_static_string(atom_name);
	}

	public static void Beep()
	{
		GdkGlobalFunctionsExterns.gdk_beep();
	}

	public static MentorLake.cairo.cairo_tHandle CairoCreate(MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_create(window);
	}

	public static void CairoDrawFromGl(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window, int source, int source_type, int buffer_scale, int x, int y, int width, int height)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_draw_from_gl(cr, window, source, source_type, buffer_scale, x, y, width, height);
	}

	public static bool CairoGetClipRectangle(MentorLake.cairo.cairo_tHandle cr, out MentorLake.Gdk.GdkRectangle rect)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_get_clip_rectangle(cr, out rect);
	}

	public static MentorLake.Gdk.GdkDrawingContextHandle CairoGetDrawingContext(MentorLake.cairo.cairo_tHandle cr)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_get_drawing_context(cr);
	}

	public static void CairoRectangle(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRectangleHandle rectangle)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_rectangle(cr, rectangle);
	}

	public static void CairoRegion(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_region_tHandle region)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_region(cr, region);
	}

	public static MentorLake.cairo.cairo_region_tHandle CairoRegionCreateFromSurface(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_region_create_from_surface(surface);
	}

	public static void CairoSetSourceColor(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkColorHandle color)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_color(cr, color);
	}

	public static void CairoSetSourcePixbuf(MentorLake.cairo.cairo_tHandle cr, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_pixbuf(cr, pixbuf, pixbuf_x, pixbuf_y);
	}

	public static void CairoSetSourceRgba(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_rgba(cr, rgba);
	}

	public static void CairoSetSourceWindow(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window, double x, double y)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_window(cr, window, x, y);
	}

	public static MentorLake.cairo.cairo_surface_tHandle CairoSurfaceCreateFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int scale, MentorLake.Gdk.GdkWindowHandle for_window)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_surface_create_from_pixbuf(pixbuf, scale, for_window);
	}

	public static bool ColorParse(string spec, out MentorLake.Gdk.GdkColor color)
	{
		return GdkGlobalFunctionsExterns.gdk_color_parse(spec, out color);
	}

	public static void DisableMultidevice()
	{
		GdkGlobalFunctionsExterns.gdk_disable_multidevice();
	}

	public static void DragAbort(MentorLake.Gdk.GdkDragContextHandle context, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drag_abort(context, time_);
	}

	public static MentorLake.Gdk.GdkDragContextHandle DragBegin(MentorLake.Gdk.GdkWindowHandle window, MentorLake.GLib.GListHandle targets)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_begin(window, targets);
	}

	public static MentorLake.Gdk.GdkDragContextHandle DragBeginForDevice(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.GLib.GListHandle targets)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_begin_for_device(window, device, targets);
	}

	public static MentorLake.Gdk.GdkDragContextHandle DragBeginFromPoint(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.GLib.GListHandle targets, int x_root, int y_root)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_begin_from_point(window, device, targets, x_root, y_root);
	}

	public static void DragDrop(MentorLake.Gdk.GdkDragContextHandle context, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drag_drop(context, time_);
	}

	public static void DragDropDone(MentorLake.Gdk.GdkDragContextHandle context, bool success)
	{
		GdkGlobalFunctionsExterns.gdk_drag_drop_done(context, success);
	}

	public static bool DragDropSucceeded(MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_drop_succeeded(context);
	}

	public static void DragFindWindowForScreen(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkWindowHandle drag_window, MentorLake.Gdk.GdkScreenHandle screen, int x_root, int y_root, out MentorLake.Gdk.GdkWindowHandle dest_window, out MentorLake.Gdk.GdkDragProtocol protocol)
	{
		GdkGlobalFunctionsExterns.gdk_drag_find_window_for_screen(context, drag_window, screen, x_root, y_root, out dest_window, out protocol);
	}

	public static MentorLake.Gdk.GdkAtom DragGetSelection(MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_get_selection(context);
	}

	public static bool DragMotion(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkWindowHandle dest_window, MentorLake.Gdk.GdkDragProtocol protocol, int x_root, int y_root, MentorLake.Gdk.GdkDragAction suggested_action, MentorLake.Gdk.GdkDragAction possible_actions, uint time_)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_motion(context, dest_window, protocol, x_root, y_root, suggested_action, possible_actions, time_);
	}

	public static void DragStatus(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkDragAction action, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drag_status(context, action, time_);
	}

	public static void DropFinish(MentorLake.Gdk.GdkDragContextHandle context, bool success, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drop_finish(context, success, time_);
	}

	public static void DropReply(MentorLake.Gdk.GdkDragContextHandle context, bool accepted, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drop_reply(context, accepted, time_);
	}

	public static int ErrorTrapPop()
	{
		return GdkGlobalFunctionsExterns.gdk_error_trap_pop();
	}

	public static void ErrorTrapPopIgnored()
	{
		GdkGlobalFunctionsExterns.gdk_error_trap_pop_ignored();
	}

	public static void ErrorTrapPush()
	{
		GdkGlobalFunctionsExterns.gdk_error_trap_push();
	}

	public static MentorLake.Gdk.GdkEventHandle EventGet()
	{
		return GdkGlobalFunctionsExterns.gdk_event_get();
	}

	public static void EventHandlerSet(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GdkGlobalFunctionsExterns.gdk_event_handler_set(func, data, notify);
	}

	public static MentorLake.Gdk.GdkEventHandle EventPeek()
	{
		return GdkGlobalFunctionsExterns.gdk_event_peek();
	}

	public static void EventRequestMotions(MentorLake.Gdk.GdkEventMotionHandle @event)
	{
		GdkGlobalFunctionsExterns.gdk_event_request_motions(@event);
	}

	public static bool EventsGetAngle(MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double angle)
	{
		return GdkGlobalFunctionsExterns.gdk_events_get_angle(event1, event2, out angle);
	}

	public static bool EventsGetCenter(MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double x, out double y)
	{
		return GdkGlobalFunctionsExterns.gdk_events_get_center(event1, event2, out x, out y);
	}

	public static bool EventsGetDistance(MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double distance)
	{
		return GdkGlobalFunctionsExterns.gdk_events_get_distance(event1, event2, out distance);
	}

	public static bool EventsPending()
	{
		return GdkGlobalFunctionsExterns.gdk_events_pending();
	}

	public static void Flush()
	{
		GdkGlobalFunctionsExterns.gdk_flush();
	}

	public static MentorLake.Gdk.GdkWindowHandle GetDefaultRootWindow()
	{
		return GdkGlobalFunctionsExterns.gdk_get_default_root_window();
	}

	public static string GetDisplay()
	{
		return GdkGlobalFunctionsExterns.gdk_get_display();
	}

	public static string GetDisplayArgName()
	{
		return GdkGlobalFunctionsExterns.gdk_get_display_arg_name();
	}

	public static string GetProgramClass()
	{
		return GdkGlobalFunctionsExterns.gdk_get_program_class();
	}

	public static bool GetShowEvents()
	{
		return GdkGlobalFunctionsExterns.gdk_get_show_events();
	}

	public static MentorLake.GLib.GQuark GlErrorQuark()
	{
		return GdkGlobalFunctionsExterns.gdk_gl_error_quark();
	}

	public static void Init(ref int argc, ref string[] argv)
	{
		GdkGlobalFunctionsExterns.gdk_init(ref argc, ref argv);
	}

	public static bool InitCheck(ref int argc, ref string[] argv)
	{
		return GdkGlobalFunctionsExterns.gdk_init_check(ref argc, ref argv);
	}

	public static MentorLake.Gdk.GdkGrabStatus KeyboardGrab(MentorLake.Gdk.GdkWindowHandle window, bool owner_events, uint time_)
	{
		return GdkGlobalFunctionsExterns.gdk_keyboard_grab(window, owner_events, time_);
	}

	public static void KeyboardUngrab(uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_keyboard_ungrab(time_);
	}

	public static void KeyvalConvertCase(uint symbol, out uint lower, out uint upper)
	{
		GdkGlobalFunctionsExterns.gdk_keyval_convert_case(symbol, out lower, out upper);
	}

	public static uint KeyvalFromName(string keyval_name)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_from_name(keyval_name);
	}

	public static bool KeyvalIsLower(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_is_lower(keyval);
	}

	public static bool KeyvalIsUpper(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_is_upper(keyval);
	}

	public static string KeyvalName(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_name(keyval);
	}

	public static uint KeyvalToLower(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_to_lower(keyval);
	}

	public static uint KeyvalToUnicode(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_to_unicode(keyval);
	}

	public static uint KeyvalToUpper(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_to_upper(keyval);
	}

	public static MentorLake.GLib.GListHandle ListVisuals()
	{
		return GdkGlobalFunctionsExterns.gdk_list_visuals();
	}

	public static void NotifyStartupComplete()
	{
		GdkGlobalFunctionsExterns.gdk_notify_startup_complete();
	}

	public static void NotifyStartupCompleteWithId(string startup_id)
	{
		GdkGlobalFunctionsExterns.gdk_notify_startup_complete_with_id(startup_id);
	}

	public static MentorLake.Gdk.GdkWindowHandle OffscreenWindowGetEmbedder(MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkGlobalFunctionsExterns.gdk_offscreen_window_get_embedder(window);
	}

	public static MentorLake.cairo.cairo_surface_tHandle OffscreenWindowGetSurface(MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkGlobalFunctionsExterns.gdk_offscreen_window_get_surface(window);
	}

	public static void OffscreenWindowSetEmbedder(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowHandle embedder)
	{
		GdkGlobalFunctionsExterns.gdk_offscreen_window_set_embedder(window, embedder);
	}

	public static MentorLake.Pango.PangoContextHandle PangoContextGet()
	{
		return GdkGlobalFunctionsExterns.gdk_pango_context_get();
	}

	public static MentorLake.Pango.PangoContextHandle PangoContextGetForDisplay(MentorLake.Gdk.GdkDisplayHandle display)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_context_get_for_display(display);
	}

	public static MentorLake.Pango.PangoContextHandle PangoContextGetForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_context_get_for_screen(screen);
	}

	public static MentorLake.cairo.cairo_region_tHandle PangoLayoutGetClipRegion(MentorLake.Pango.PangoLayoutHandle layout, int x_origin, int y_origin, int index_ranges, int n_ranges)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_layout_get_clip_region(layout, x_origin, y_origin, index_ranges, n_ranges);
	}

	public static MentorLake.cairo.cairo_region_tHandle PangoLayoutLineGetClipRegion(MentorLake.Pango.PangoLayoutLineHandle line, int x_origin, int y_origin, int[] index_ranges, int n_ranges)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_layout_line_get_clip_region(line, x_origin, y_origin, index_ranges, n_ranges);
	}

	public static void ParseArgs(ref int argc, ref string[] argv)
	{
		GdkGlobalFunctionsExterns.gdk_parse_args(ref argc, ref argv);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle PixbufGetFromSurface(MentorLake.cairo.cairo_surface_tHandle surface, int src_x, int src_y, int width, int height)
	{
		return GdkGlobalFunctionsExterns.gdk_pixbuf_get_from_surface(surface, src_x, src_y, width, height);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle PixbufGetFromWindow(MentorLake.Gdk.GdkWindowHandle window, int src_x, int src_y, int width, int height)
	{
		return GdkGlobalFunctionsExterns.gdk_pixbuf_get_from_window(window, src_x, src_y, width, height);
	}

	public static MentorLake.Gdk.GdkGrabStatus PointerGrab(MentorLake.Gdk.GdkWindowHandle window, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, MentorLake.Gdk.GdkWindowHandle confine_to, MentorLake.Gdk.GdkCursorHandle cursor, uint time_)
	{
		return GdkGlobalFunctionsExterns.gdk_pointer_grab(window, owner_events, event_mask, confine_to, cursor, time_);
	}

	public static bool PointerIsGrabbed()
	{
		return GdkGlobalFunctionsExterns.gdk_pointer_is_grabbed();
	}

	public static void PointerUngrab(uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_pointer_ungrab(time_);
	}

	public static void PreParseLibgtkOnly()
	{
		GdkGlobalFunctionsExterns.gdk_pre_parse_libgtk_only();
	}

	public static void PropertyChange(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, int format, MentorLake.Gdk.GdkPropMode mode, char data, int nelements)
	{
		GdkGlobalFunctionsExterns.gdk_property_change(window, property, type, format, mode, data, nelements);
	}

	public static void PropertyDelete(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property)
	{
		GdkGlobalFunctionsExterns.gdk_property_delete(window, property);
	}

	public static bool PropertyGet(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, ulong offset, ulong length, int pdelete, out MentorLake.Gdk.GdkAtom actual_property_type, out int actual_format, out int actual_length, out char[] data)
	{
		return GdkGlobalFunctionsExterns.gdk_property_get(window, property, type, offset, length, pdelete, out actual_property_type, out actual_format, out actual_length, out data);
	}

	public static void QueryDepths(out int[] depths, out int count)
	{
		GdkGlobalFunctionsExterns.gdk_query_depths(out depths, out count);
	}

	public static void QueryVisualTypes(out MentorLake.Gdk.GdkVisualType[] visual_types, out int count)
	{
		GdkGlobalFunctionsExterns.gdk_query_visual_types(out visual_types, out count);
	}

	public static void SelectionConvert(MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_selection_convert(requestor, selection, target, time_);
	}

	public static MentorLake.Gdk.GdkWindowHandle SelectionOwnerGet(MentorLake.Gdk.GdkAtom selection)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_get(selection);
	}

	public static MentorLake.Gdk.GdkWindowHandle SelectionOwnerGetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_get_for_display(display, selection);
	}

	public static bool SelectionOwnerSet(MentorLake.Gdk.GdkWindowHandle owner, MentorLake.Gdk.GdkAtom selection, uint time_, bool send_event)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_set(owner, selection, time_, send_event);
	}

	public static bool SelectionOwnerSetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkWindowHandle owner, MentorLake.Gdk.GdkAtom selection, uint time_, bool send_event)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_set_for_display(display, owner, selection, time_, send_event);
	}

	public static int SelectionPropertyGet(MentorLake.Gdk.GdkWindowHandle requestor, char data, MentorLake.Gdk.GdkAtomHandle prop_type, int prop_format)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_property_get(requestor, data, prop_type, prop_format);
	}

	public static void SelectionSendNotify(MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, MentorLake.Gdk.GdkAtom property, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_selection_send_notify(requestor, selection, target, property, time_);
	}

	public static void SelectionSendNotifyForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, MentorLake.Gdk.GdkAtom property, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_selection_send_notify_for_display(display, requestor, selection, target, property, time_);
	}

	public static void SetAllowedBackends(string backends)
	{
		GdkGlobalFunctionsExterns.gdk_set_allowed_backends(backends);
	}

	public static void SetDoubleClickTime(uint msec)
	{
		GdkGlobalFunctionsExterns.gdk_set_double_click_time(msec);
	}

	public static void SetProgramClass(string program_class)
	{
		GdkGlobalFunctionsExterns.gdk_set_program_class(program_class);
	}

	public static void SetShowEvents(bool show_events)
	{
		GdkGlobalFunctionsExterns.gdk_set_show_events(show_events);
	}

	public static bool SettingGet(string name, MentorLake.GObject.GValueHandle value)
	{
		return GdkGlobalFunctionsExterns.gdk_setting_get(name, value);
	}

	public static void SynthesizeWindowState(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowState unset_flags, MentorLake.Gdk.GdkWindowState set_flags)
	{
		GdkGlobalFunctionsExterns.gdk_synthesize_window_state(window, unset_flags, set_flags);
	}

	public static void TestRenderSync(MentorLake.Gdk.GdkWindowHandle window)
	{
		GdkGlobalFunctionsExterns.gdk_test_render_sync(window);
	}

	public static bool TestSimulateButton(MentorLake.Gdk.GdkWindowHandle window, int x, int y, uint button, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.Gdk.GdkEventType button_pressrelease)
	{
		return GdkGlobalFunctionsExterns.gdk_test_simulate_button(window, x, y, button, modifiers, button_pressrelease);
	}

	public static bool TestSimulateKey(MentorLake.Gdk.GdkWindowHandle window, int x, int y, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.Gdk.GdkEventType key_pressrelease)
	{
		return GdkGlobalFunctionsExterns.gdk_test_simulate_key(window, x, y, keyval, modifiers, key_pressrelease);
	}

	public static int TextPropertyToUtf8ListForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, char[] text, int length, out string[] list)
	{
		return GdkGlobalFunctionsExterns.gdk_text_property_to_utf8_list_for_display(display, encoding, format, text, length, out list);
	}

	public static uint ThreadsAddIdle(MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_idle(function, data);
	}

	public static uint ThreadsAddIdleFull(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_idle_full(priority, function, data, notify);
	}

	public static uint ThreadsAddTimeout(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout(interval, function, data);
	}

	public static uint ThreadsAddTimeoutFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout_full(priority, interval, function, data, notify);
	}

	public static uint ThreadsAddTimeoutSeconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout_seconds(interval, function, data);
	}

	public static uint ThreadsAddTimeoutSecondsFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout_seconds_full(priority, interval, function, data, notify);
	}

	public static void ThreadsEnter()
	{
		GdkGlobalFunctionsExterns.gdk_threads_enter();
	}

	public static void ThreadsInit()
	{
		GdkGlobalFunctionsExterns.gdk_threads_init();
	}

	public static void ThreadsLeave()
	{
		GdkGlobalFunctionsExterns.gdk_threads_leave();
	}

	public static void ThreadsSetLockFunctions(MentorLake.GObject.GCallback enter_fn, MentorLake.GObject.GCallback leave_fn)
	{
		GdkGlobalFunctionsExterns.gdk_threads_set_lock_functions(enter_fn, leave_fn);
	}

	public static uint UnicodeToKeyval(uint wc)
	{
		return GdkGlobalFunctionsExterns.gdk_unicode_to_keyval(wc);
	}

	public static string Utf8ToStringTarget(string str)
	{
		return GdkGlobalFunctionsExterns.gdk_utf8_to_string_target(str);
	}

}

internal class GdkGlobalFunctionsExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_add_option_entries_libgtk_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_atom_intern(string atom_name, bool only_if_exists);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_atom_intern_static_string(string atom_name);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_beep();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))]
	internal static extern MentorLake.cairo.cairo_tHandle gdk_cairo_create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_draw_from_gl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int source, int source_type, int buffer_scale, int x, int y, int width, int height);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_cairo_get_clip_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDrawingContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDrawingContextHandle gdk_cairo_get_drawing_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rectangle);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_cairo_region_create_from_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_set_source_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_set_source_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_set_source_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_cairo_set_source_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, double x, double y);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gdk_cairo_surface_create_from_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle for_window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_color_parse(string spec, out MentorLake.Gdk.GdkColor color);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_disable_multidevice();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_abort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, uint time_);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gdk_drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gdk_drag_begin_for_device([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gdk_drag_begin_from_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets, int x_root, int y_root);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_drop_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, bool success);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_drag_drop_succeeded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_find_window_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle drag_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, int x_root, int y_root, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] out MentorLake.Gdk.GdkWindowHandle dest_window, out MentorLake.Gdk.GdkDragProtocol protocol);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_drag_get_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_drag_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle dest_window, MentorLake.Gdk.GdkDragProtocol protocol, int x_root, int y_root, MentorLake.Gdk.GdkDragAction suggested_action, MentorLake.Gdk.GdkDragAction possible_actions, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drag_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkDragAction action, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drop_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, bool success, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_drop_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, bool accepted, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_error_trap_pop();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_error_trap_pop_ignored();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_error_trap_push();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_get();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_handler_set(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))]
	internal static extern MentorLake.Gdk.GdkEventHandle gdk_event_peek();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_event_request_motions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventMotionHandle>))] MentorLake.Gdk.GdkEventMotionHandle @event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_angle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double angle);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_center([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double x, out double y);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_get_distance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle event2, out double distance);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_events_pending();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_flush();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_get_default_root_window();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_get_display();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_get_display_arg_name();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_get_program_class();

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_get_show_events();

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark gdk_gl_error_quark();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_init(ref int argc, ref string[] argv);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_init_check(ref int argc, ref string[] argv);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGrabStatus gdk_keyboard_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool owner_events, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_keyboard_ungrab(uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_keyval_convert_case(uint symbol, out uint lower, out uint upper);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keyval_from_name(string keyval_name);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keyval_is_lower(uint keyval);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keyval_is_upper(uint keyval);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_keyval_name(uint keyval);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keyval_to_lower(uint keyval);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keyval_to_unicode(uint keyval);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keyval_to_upper(uint keyval);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gdk_list_visuals();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_notify_startup_complete();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_notify_startup_complete_with_id(string startup_id);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_offscreen_window_get_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gdk_offscreen_window_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_offscreen_window_set_embedder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle embedder);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gdk_pango_context_get();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gdk_pango_context_get_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle gdk_pango_context_get_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_pango_layout_get_clip_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x_origin, int y_origin, int index_ranges, int n_ranges);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))]
	internal static extern MentorLake.cairo.cairo_region_tHandle gdk_pango_layout_line_get_clip_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int x_origin, int y_origin, int[] index_ranges, int n_ranges);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_parse_args(ref int argc, ref string[] argv);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_get_from_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))] MentorLake.cairo.cairo_surface_tHandle surface, int src_x, int src_y, int width, int height);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_get_from_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int src_x, int src_y, int width, int height);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkGrabStatus gdk_pointer_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle confine_to, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkCursorHandle>))] MentorLake.Gdk.GdkCursorHandle cursor, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_pointer_is_grabbed();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_pointer_ungrab(uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_pre_parse_libgtk_only();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_property_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, int format, MentorLake.Gdk.GdkPropMode mode, char data, int nelements);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_property_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_property_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, ulong offset, ulong length, int pdelete, out MentorLake.Gdk.GdkAtom actual_property_type, out int actual_format, out int actual_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] out char[] data);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_query_depths([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] out int[] depths, out int count);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_query_visual_types([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] out MentorLake.Gdk.GdkVisualType[] visual_types, out int count);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_selection_convert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint time_);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_selection_owner_get(MentorLake.Gdk.GdkAtom selection);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gdk_selection_owner_get_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_selection_owner_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle owner, MentorLake.Gdk.GdkAtom selection, uint time_, bool send_event);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_selection_owner_set_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle owner, MentorLake.Gdk.GdkAtom selection, uint time_, bool send_event);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_selection_property_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle requestor, char data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAtomHandle>))] MentorLake.Gdk.GdkAtomHandle prop_type, int prop_format);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_selection_send_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, MentorLake.Gdk.GdkAtom property, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_selection_send_notify_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, MentorLake.Gdk.GdkAtom property, uint time_);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_set_allowed_backends(string backends);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_set_double_click_time(uint msec);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_set_program_class(string program_class);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_set_show_events(bool show_events);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_setting_get(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_synthesize_window_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowState unset_flags, MentorLake.Gdk.GdkWindowState set_flags);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_test_render_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_test_simulate_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int x, int y, uint button, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.Gdk.GdkEventType button_pressrelease);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_test_simulate_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int x, int y, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.Gdk.GdkEventType key_pressrelease);

	[DllImport(GdkLibrary.Name)]
	internal static extern int gdk_text_property_to_utf8_list_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, char[] text, int length, [MarshalAs(UnmanagedType.LPArray)] out string[] list);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_threads_add_idle(MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_threads_add_idle_full(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_threads_add_timeout(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_threads_add_timeout_full(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_threads_add_timeout_seconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_threads_add_timeout_seconds_full(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_threads_enter();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_threads_init();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_threads_leave();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_threads_set_lock_functions(MentorLake.GObject.GCallback enter_fn, MentorLake.GObject.GCallback leave_fn);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_unicode_to_keyval(uint wc);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_utf8_to_string_target(string str);

}
