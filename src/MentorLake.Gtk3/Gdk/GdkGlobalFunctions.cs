namespace MentorLake.Gdk;

public class GdkGlobalFunctions
{
/// <summary>
/// <para>
/// Appends gdk option entries to the passed in option group. This is
/// not public API and must not be used by applications.
/// </para>
/// </summary>

/// <param name="group">
/// An option group.
/// </param>

	public static void AddOptionEntriesLibgtkOnly(MentorLake.GLib.GOptionGroupHandle group)
	{
		GdkGlobalFunctionsExterns.gdk_add_option_entries_libgtk_only(group);
	}

/// <summary>
/// <para>
/// Finds or creates an atom corresponding to a given string.
/// </para>
/// </summary>

/// <param name="atom_name">
/// a string.
/// </param>
/// <param name="only_if_exists">
/// if %TRUE, GDK is allowed to not create a new atom, but
///   just return %GDK_NONE if the requested atom doesn’t already
///   exists. Currently, the flag is ignored, since checking the
///   existance of an atom is as expensive as creating it.
/// </param>
/// <return>
/// the atom corresponding to @atom_name.
/// </return>

	public static MentorLake.Gdk.GdkAtom AtomIntern(string atom_name, bool only_if_exists)
	{
		return GdkGlobalFunctionsExterns.gdk_atom_intern(atom_name, only_if_exists);
	}

/// <summary>
/// <para>
/// Finds or creates an atom corresponding to a given string.
/// </para>
/// <para>
/// Note that this function is identical to gdk_atom_intern() except
/// that if a new #GdkAtom is created the string itself is used rather
/// than a copy. This saves memory, but can only be used if the string
/// will always exist. It can be used with statically
/// allocated strings in the main program, but not with statically
/// allocated memory in dynamically loaded modules, if you expect to
/// ever unload the module again (e.g. do not use this function in
/// GTK+ theme engines).
/// </para>
/// </summary>

/// <param name="atom_name">
/// a static string
/// </param>
/// <return>
/// the atom corresponding to @atom_name
/// </return>

	public static MentorLake.Gdk.GdkAtom AtomInternStaticString(string atom_name)
	{
		return GdkGlobalFunctionsExterns.gdk_atom_intern_static_string(atom_name);
	}

/// <summary>
/// <para>
/// Emits a short beep on the default display.
/// </para>
/// </summary>


	public static void Beep()
	{
		GdkGlobalFunctionsExterns.gdk_beep();
	}

/// <summary>
/// <para>
/// Creates a Cairo context for drawing to @window.
/// </para>
/// <para>
/// Note that calling cairo_reset_clip() on the resulting #cairo_t will
/// produce undefined results, so avoid it at all costs.
/// </para>
/// <para>
/// Typically, this function is used to draw on a #GdkWindow out of the paint
/// cycle of the toolkit; this should be avoided, as it breaks various assumptions
/// and optimizations.
/// </para>
/// <para>
/// If you are drawing on a native #GdkWindow in response to a %GDK_EXPOSE event
/// you should use gdk_window_begin_draw_frame() and gdk_drawing_context_get_cairo_context()
/// instead. GTK will automatically do this for you when drawing a widget.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// A newly created Cairo context. Free with
///  cairo_destroy() when you are done drawing.
/// </return>

	public static MentorLake.cairo.cairo_tHandle CairoCreate(MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_create(window);
	}

/// <summary>
/// <para>
/// This is the main way to draw GL content in GTK+. It takes a render buffer ID
/// (@source_type == #GL_RENDERBUFFER) or a texture id (@source_type == #GL_TEXTURE)
/// and draws it onto @cr with an OVER operation, respecting the current clip.
/// The top left corner of the rectangle specified by @x, @y, @width and @height
/// will be drawn at the current (0,0) position of the cairo_t.
/// </para>
/// <para>
/// This will work for *all* cairo_t, as long as @window is realized, but the
/// fallback implementation that reads back the pixels from the buffer may be
/// used in the general case. In the case of direct drawing to a window with
/// no special effects applied to @cr it will however use a more efficient
/// approach.
/// </para>
/// <para>
/// For #GL_RENDERBUFFER the code will always fall back to software for buffers
/// with alpha components, so make sure you use #GL_TEXTURE if using alpha.
/// </para>
/// <para>
/// Calling this may change the current GL context.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="window">
/// The window we're rendering for (not necessarily into)
/// </param>
/// <param name="source">
/// The GL ID of the source buffer
/// </param>
/// <param name="source_type">
/// The type of the @source
/// </param>
/// <param name="buffer_scale">
/// The scale-factor that the @source buffer is allocated for
/// </param>
/// <param name="x">
/// The source x position in @source to start copying from in GL coordinates
/// </param>
/// <param name="y">
/// The source y position in @source to start copying from in GL coordinates
/// </param>
/// <param name="width">
/// The width of the region to draw
/// </param>
/// <param name="height">
/// The height of the region to draw
/// </param>

	public static void CairoDrawFromGl(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window, int source, int source_type, int buffer_scale, int x, int y, int width, int height)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_draw_from_gl(cr, window, source, source_type, buffer_scale, x, y, width, height);
	}

/// <summary>
/// <para>
/// This is a convenience function around cairo_clip_extents().
/// It rounds the clip extents to integer coordinates and returns
/// a boolean indicating if a clip area exists.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="rect">
/// return location for the clip, or %NULL
/// </param>
/// <return>
/// %TRUE if a clip rectangle exists, %FALSE if all of @cr is
///     clipped and all drawing can be skipped
/// </return>

	public static bool CairoGetClipRectangle(MentorLake.cairo.cairo_tHandle cr, out MentorLake.Gdk.GdkRectangle rect)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_get_clip_rectangle(cr, out rect);
	}

/// <summary>
/// <para>
/// Retrieves the #GdkDrawingContext that created the Cairo
/// context @cr.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <return>
/// a #GdkDrawingContext, if any is set
/// </return>

	public static MentorLake.Gdk.GdkDrawingContextHandle CairoGetDrawingContext(MentorLake.cairo.cairo_tHandle cr)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_get_drawing_context(cr);
	}

/// <summary>
/// <para>
/// Adds the given rectangle to the current path of @cr.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="rectangle">
/// a #GdkRectangle
/// </param>

	public static void CairoRectangle(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRectangleHandle rectangle)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_rectangle(cr, rectangle);
	}

/// <summary>
/// <para>
/// Adds the given region to the current path of @cr.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="region">
/// a #cairo_region_t
/// </param>

	public static void CairoRegion(MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_region_tHandle region)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_region(cr, region);
	}

/// <summary>
/// <para>
/// Creates region that describes covers the area where the given
/// @surface is more than 50% opaque.
/// </para>
/// <para>
/// This function takes into account device offsets that might be
/// set with cairo_surface_set_device_offset().
/// </para>
/// </summary>

/// <param name="surface">
/// a cairo surface
/// </param>
/// <return>
/// A #cairo_region_t; must be freed with cairo_region_destroy()
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle CairoRegionCreateFromSurface(MentorLake.cairo.cairo_surface_tHandle surface)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_region_create_from_surface(surface);
	}

/// <summary>
/// <para>
/// Sets the specified #GdkColor as the source color of @cr.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="color">
/// a #GdkColor
/// </param>

	public static void CairoSetSourceColor(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkColorHandle color)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_color(cr, color);
	}

/// <summary>
/// <para>
/// Sets the given pixbuf as the source pattern for @cr.
/// </para>
/// <para>
/// The pattern has an extend mode of %CAIRO_EXTEND_NONE and is aligned
/// so that the origin of @pixbuf is @pixbuf_x, @pixbuf_y.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>
/// <param name="pixbuf_x">
/// X coordinate of location to place upper left corner of @pixbuf
/// </param>
/// <param name="pixbuf_y">
/// Y coordinate of location to place upper left corner of @pixbuf
/// </param>

	public static void CairoSetSourcePixbuf(MentorLake.cairo.cairo_tHandle cr, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, double pixbuf_x, double pixbuf_y)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_pixbuf(cr, pixbuf, pixbuf_x, pixbuf_y);
	}

/// <summary>
/// <para>
/// Sets the specified #GdkRGBA as the source color of @cr.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="rgba">
/// a #GdkRGBA
/// </param>

	public static void CairoSetSourceRgba(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_rgba(cr, rgba);
	}

/// <summary>
/// <para>
/// Sets the given window as the source pattern for @cr.
/// </para>
/// <para>
/// The pattern has an extend mode of %CAIRO_EXTEND_NONE and is aligned
/// so that the origin of @window is @x, @y. The window contains all its
/// subwindows when rendering.
/// </para>
/// <para>
/// Note that the contents of @window are undefined outside of the
/// visible part of @window, so use this function with care.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="x">
/// X coordinate of location to place upper left corner of @window
/// </param>
/// <param name="y">
/// Y coordinate of location to place upper left corner of @window
/// </param>

	public static void CairoSetSourceWindow(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window, double x, double y)
	{
		GdkGlobalFunctionsExterns.gdk_cairo_set_source_window(cr, window, x, y);
	}

/// <summary>
/// <para>
/// Creates an image surface with the same contents as
/// the pixbuf.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>
/// <param name="scale">
/// the scale of the new surface, or 0 to use same as @window
/// </param>
/// <param name="for_window">
/// The window this will be drawn to, or %NULL
/// </param>
/// <return>
/// a new cairo surface, must be freed with cairo_surface_destroy()
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle CairoSurfaceCreateFromPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int scale, MentorLake.Gdk.GdkWindowHandle for_window)
	{
		return GdkGlobalFunctionsExterns.gdk_cairo_surface_create_from_pixbuf(pixbuf, scale, for_window);
	}

/// <summary>
/// <para>
/// Parses a textual specification of a color and fill in the
/// @red, @green, and @blue fields of a #GdkColor.
/// </para>
/// <para>
/// The string can either one of a large set of standard names
/// (taken from the X11 `rgb.txt` file), or it can be a hexadecimal
/// value in the form “\#rgb” “\#rrggbb”, “\#rrrgggbbb” or
/// “\#rrrrggggbbbb” where “r”, “g” and “b” are hex digits of
/// the red, green, and blue components of the color, respectively.
/// (White in the four forms is “\#fff”, “\#ffffff”, “\#fffffffff”
/// and “\#ffffffffffff”).
/// </para>
/// </summary>

/// <param name="spec">
/// the string specifying the color
/// </param>
/// <param name="color">
/// the #GdkColor to fill in
/// </param>
/// <return>
/// %TRUE if the parsing succeeded
/// </return>

	public static bool ColorParse(string spec, out MentorLake.Gdk.GdkColor color)
	{
		return GdkGlobalFunctionsExterns.gdk_color_parse(spec, out color);
	}

/// <summary>
/// <para>
/// Disables multidevice support in GDK. This call must happen prior
/// to gdk_display_open(), gtk_init(), gtk_init_with_args() or
/// gtk_init_check() in order to take effect.
/// </para>
/// <para>
/// Most common GTK+ applications won’t ever need to call this. Only
/// applications that do mixed GDK/Xlib calls could want to disable
/// multidevice support if such Xlib code deals with input devices in
/// any way and doesn’t observe the presence of XInput 2.
/// </para>
/// </summary>


	public static void DisableMultidevice()
	{
		GdkGlobalFunctionsExterns.gdk_disable_multidevice();
	}

/// <summary>
/// <para>
/// Aborts a drag without dropping.
/// </para>
/// <para>
/// This function is called by the drag source.
/// </para>
/// <para>
/// This function does not need to be called in managed drag and drop
/// operations. See gdk_drag_context_manage_dnd() for more information.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="time_">
/// the timestamp for this operation
/// </param>

	public static void DragAbort(MentorLake.Gdk.GdkDragContextHandle context, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drag_abort(context, time_);
	}

/// <summary>
/// <para>
/// Starts a drag and creates a new drag context for it.
/// This function assumes that the drag is controlled by the
/// client pointer device, use gdk_drag_begin_for_device() to
/// begin a drag with a different device.
/// </para>
/// <para>
/// This function is called by the drag source.
/// </para>
/// </summary>

/// <param name="window">
/// the source window for this drag.
/// </param>
/// <param name="targets">
/// the offered targets,
///     as list of #GdkAtoms
/// </param>
/// <return>
/// a newly created #GdkDragContext
/// </return>

	public static MentorLake.Gdk.GdkDragContextHandle DragBegin(MentorLake.Gdk.GdkWindowHandle window, MentorLake.GLib.GListHandle targets)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_begin(window, targets);
	}

/// <summary>
/// <para>
/// Starts a drag and creates a new drag context for it.
/// </para>
/// <para>
/// This function is called by the drag source.
/// </para>
/// </summary>

/// <param name="window">
/// the source window for this drag
/// </param>
/// <param name="device">
/// the device that controls this drag
/// </param>
/// <param name="targets">
/// the offered targets,
///     as list of #GdkAtoms
/// </param>
/// <return>
/// a newly created #GdkDragContext
/// </return>

	public static MentorLake.Gdk.GdkDragContextHandle DragBeginForDevice(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.GLib.GListHandle targets)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_begin_for_device(window, device, targets);
	}

/// <summary>
/// <para>
/// Starts a drag and creates a new drag context for it.
/// </para>
/// <para>
/// This function is called by the drag source.
/// </para>
/// </summary>

/// <param name="window">
/// the source window for this drag
/// </param>
/// <param name="device">
/// the device that controls this drag
/// </param>
/// <param name="targets">
/// the offered targets,
///     as list of #GdkAtoms
/// </param>
/// <param name="x_root">
/// the x coordinate where the drag nominally started
/// </param>
/// <param name="y_root">
/// the y coordinate where the drag nominally started
/// </param>
/// <return>
/// a newly created #GdkDragContext
/// </return>

	public static MentorLake.Gdk.GdkDragContextHandle DragBeginFromPoint(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.GLib.GListHandle targets, int x_root, int y_root)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_begin_from_point(window, device, targets, x_root, y_root);
	}

/// <summary>
/// <para>
/// Drops on the current destination.
/// </para>
/// <para>
/// This function is called by the drag source.
/// </para>
/// <para>
/// This function does not need to be called in managed drag and drop
/// operations. See gdk_drag_context_manage_dnd() for more information.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="time_">
/// the timestamp for this operation
/// </param>

	public static void DragDrop(MentorLake.Gdk.GdkDragContextHandle context, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drag_drop(context, time_);
	}

/// <summary>
/// <para>
/// Inform GDK if the drop ended successfully. Passing %FALSE
/// for @success may trigger a drag cancellation animation.
/// </para>
/// <para>
/// This function is called by the drag source, and should
/// be the last call before dropping the reference to the
/// @context.
/// </para>
/// <para>
/// The #GdkDragContext will only take the first gdk_drag_drop_done()
/// call as effective, if this function is called multiple times,
/// all subsequent calls will be ignored.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="success">
/// whether the drag was ultimatively successful
/// </param>

	public static void DragDropDone(MentorLake.Gdk.GdkDragContextHandle context, bool success)
	{
		GdkGlobalFunctionsExterns.gdk_drag_drop_done(context, success);
	}

/// <summary>
/// <para>
/// Returns whether the dropped data has been successfully
/// transferred. This function is intended to be used while
/// handling a %GDK_DROP_FINISHED event, its return value is
/// meaningless at other times.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <return>
/// %TRUE if the drop was successful.
/// </return>

	public static bool DragDropSucceeded(MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_drop_succeeded(context);
	}

/// <summary>
/// <para>
/// Finds the destination window and DND protocol to use at the
/// given pointer position.
/// </para>
/// <para>
/// This function is called by the drag source to obtain the
/// @dest_window and @protocol parameters for gdk_drag_motion().
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="drag_window">
/// a window which may be at the pointer position, but
///     should be ignored, since it is put up by the drag source as an icon
/// </param>
/// <param name="screen">
/// the screen where the destination window is sought
/// </param>
/// <param name="x_root">
/// the x position of the pointer in root coordinates
/// </param>
/// <param name="y_root">
/// the y position of the pointer in root coordinates
/// </param>
/// <param name="dest_window">
/// location to store the destination window in
/// </param>
/// <param name="protocol">
/// location to store the DND protocol in
/// </param>

	public static void DragFindWindowForScreen(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkWindowHandle drag_window, MentorLake.Gdk.GdkScreenHandle screen, int x_root, int y_root, out MentorLake.Gdk.GdkWindowHandle dest_window, out MentorLake.Gdk.GdkDragProtocol protocol)
	{
		GdkGlobalFunctionsExterns.gdk_drag_find_window_for_screen(context, drag_window, screen, x_root, y_root, out dest_window, out protocol);
	}

/// <summary>
/// <para>
/// Returns the selection atom for the current source window.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext.
/// </param>
/// <return>
/// the selection atom, or %GDK_NONE
/// </return>

	public static MentorLake.Gdk.GdkAtom DragGetSelection(MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_get_selection(context);
	}

/// <summary>
/// <para>
/// Updates the drag context when the pointer moves or the
/// set of actions changes.
/// </para>
/// <para>
/// This function is called by the drag source.
/// </para>
/// <para>
/// This function does not need to be called in managed drag and drop
/// operations. See gdk_drag_context_manage_dnd() for more information.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="dest_window">
/// the new destination window, obtained by
///     gdk_drag_find_window()
/// </param>
/// <param name="protocol">
/// the DND protocol in use, obtained by gdk_drag_find_window()
/// </param>
/// <param name="x_root">
/// the x position of the pointer in root coordinates
/// </param>
/// <param name="y_root">
/// the y position of the pointer in root coordinates
/// </param>
/// <param name="suggested_action">
/// the suggested action
/// </param>
/// <param name="possible_actions">
/// the possible actions
/// </param>
/// <param name="time_">
/// the timestamp for this operation
/// </param>

	public static bool DragMotion(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkWindowHandle dest_window, MentorLake.Gdk.GdkDragProtocol protocol, int x_root, int y_root, MentorLake.Gdk.GdkDragAction suggested_action, MentorLake.Gdk.GdkDragAction possible_actions, uint time_)
	{
		return GdkGlobalFunctionsExterns.gdk_drag_motion(context, dest_window, protocol, x_root, y_root, suggested_action, possible_actions, time_);
	}

/// <summary>
/// <para>
/// Selects one of the actions offered by the drag source.
/// </para>
/// <para>
/// This function is called by the drag destination in response to
/// gdk_drag_motion() called by the drag source.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="action">
/// the selected action which will be taken when a drop happens,
///    or 0 to indicate that a drop will not be accepted
/// </param>
/// <param name="time_">
/// the timestamp for this operation
/// </param>

	public static void DragStatus(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkDragAction action, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drag_status(context, action, time_);
	}

/// <summary>
/// <para>
/// Ends the drag operation after a drop.
/// </para>
/// <para>
/// This function is called by the drag destination.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="success">
/// %TRUE if the data was successfully received
/// </param>
/// <param name="time_">
/// the timestamp for this operation
/// </param>

	public static void DropFinish(MentorLake.Gdk.GdkDragContextHandle context, bool success, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drop_finish(context, success, time_);
	}

/// <summary>
/// <para>
/// Accepts or rejects a drop.
/// </para>
/// <para>
/// This function is called by the drag destination in response
/// to a drop initiated by the drag source.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext
/// </param>
/// <param name="accepted">
/// %TRUE if the drop is accepted
/// </param>
/// <param name="time_">
/// the timestamp for this operation
/// </param>

	public static void DropReply(MentorLake.Gdk.GdkDragContextHandle context, bool accepted, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_drop_reply(context, accepted, time_);
	}

/// <summary>
/// <para>
/// Removes an error trap pushed with gdk_error_trap_push().
/// May block until an error has been definitively received
/// or not received from the X server. gdk_error_trap_pop_ignored()
/// is preferred if you don’t need to know whether an error
/// occurred, because it never has to block. If you don't
/// need the return value of gdk_error_trap_pop(), use
/// gdk_error_trap_pop_ignored().
/// </para>
/// <para>
/// Prior to GDK 3.0, this function would not automatically
/// sync for you, so you had to gdk_flush() if your last
/// call to Xlib was not a blocking round trip.
/// </para>
/// </summary>

/// <return>
/// X error code or 0 on success
/// </return>

	public static int ErrorTrapPop()
	{
		return GdkGlobalFunctionsExterns.gdk_error_trap_pop();
	}

/// <summary>
/// <para>
/// Removes an error trap pushed with gdk_error_trap_push(), but
/// without bothering to wait and see whether an error occurred.  If an
/// error arrives later asynchronously that was triggered while the
/// trap was pushed, that error will be ignored.
/// </para>
/// </summary>


	public static void ErrorTrapPopIgnored()
	{
		GdkGlobalFunctionsExterns.gdk_error_trap_pop_ignored();
	}

/// <summary>
/// <para>
/// This function allows X errors to be trapped instead of the normal
/// behavior of exiting the application. It should only be used if it
/// is not possible to avoid the X error in any other way. Errors are
/// ignored on all #GdkDisplay currently known to the
/// #GdkDisplayManager. If you don’t care which error happens and just
/// want to ignore everything, pop with gdk_error_trap_pop_ignored().
/// If you need the error code, use gdk_error_trap_pop() which may have
/// to block and wait for the error to arrive from the X server.
/// </para>
/// <para>
/// This API exists on all platforms but only does anything on X.
/// </para>
/// <para>
/// You can use gdk_x11_display_error_trap_push() to ignore errors
/// on only a single display.
/// </para>
/// <para>
/// ## Trapping an X error
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// gdk_error_trap_push ();
/// </para>
/// <para>
///  // ... Call the X function which may cause an error here ...
/// </para>
/// <para>
/// </para>
/// <para>
/// if (gdk_error_trap_pop ())
///  {
///    // ... Handle the error here ...
///  }
/// ]|
/// </para>
/// </summary>


	public static void ErrorTrapPush()
	{
		GdkGlobalFunctionsExterns.gdk_error_trap_push();
	}

/// <summary>
/// <para>
/// Checks all open displays for a #GdkEvent to process,to be processed
/// on, fetching events from the windowing system if necessary.
/// See gdk_display_get_event().
/// </para>
/// </summary>

/// <return>
/// the next #GdkEvent to be processed, or %NULL
/// if no events are pending. The returned #GdkEvent should be freed
/// with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle EventGet()
	{
		return GdkGlobalFunctionsExterns.gdk_event_get();
	}

/// <summary>
/// <para>
/// Sets the function to call to handle all events from GDK.
/// </para>
/// <para>
/// Note that GTK+ uses this to install its own event handler, so it is
/// usually not useful for GTK+ applications. (Although an application
/// can call this function then call gtk_main_do_event() to pass
/// events to GTK+.)
/// </para>
/// </summary>

/// <param name="func">
/// the function to call to handle events from GDK.
/// </param>
/// <param name="data">
/// user data to pass to the function.
/// </param>
/// <param name="notify">
/// the function to call when the handler function is removed, i.e. when
///          gdk_event_handler_set() is called with another event handler.
/// </param>

	public static void EventHandlerSet(MentorLake.Gdk.GdkEventFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GdkGlobalFunctionsExterns.gdk_event_handler_set(func, data, notify);
	}

/// <summary>
/// <para>
/// If there is an event waiting in the event queue of some open
/// display, returns a copy of it. See gdk_display_peek_event().
/// </para>
/// </summary>

/// <return>
/// a copy of the first #GdkEvent on some event
/// queue, or %NULL if no events are in any queues. The returned
/// #GdkEvent should be freed with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle EventPeek()
	{
		return GdkGlobalFunctionsExterns.gdk_event_peek();
	}

/// <summary>
/// <para>
/// Request more motion notifies if @event is a motion notify hint event.
/// </para>
/// <para>
/// This function should be used instead of gdk_window_get_pointer() to
/// request further motion notifies, because it also works for extension
/// events where motion notifies are provided for devices other than the
/// core pointer. Coordinate extraction, processing and requesting more
/// motion events from a %GDK_MOTION_NOTIFY event usually works like this:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// {
///   // motion_event handler
///   x = motion_event->x;
///   y = motion_event->y;
///   // handle (x,y) motion
///   gdk_event_request_motions (motion_event); // handles is_hint events
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="@event">
/// a valid #GdkEvent
/// </param>

	public static void EventRequestMotions(MentorLake.Gdk.GdkEventMotionHandle @event)
	{
		GdkGlobalFunctionsExterns.gdk_event_request_motions(@event);
	}

/// <summary>
/// <para>
/// If both events contain X/Y information, this function will return %TRUE
/// and return in @angle the relative angle from @event1 to @event2. The rotation
/// direction for positive angles is from the positive X axis towards the positive
/// Y axis.
/// </para>
/// </summary>

/// <param name="event1">
/// first #GdkEvent
/// </param>
/// <param name="event2">
/// second #GdkEvent
/// </param>
/// <param name="angle">
/// return location for the relative angle between both events
/// </param>
/// <return>
/// %TRUE if the angle could be calculated.
/// </return>

	public static bool EventsGetAngle(MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double angle)
	{
		return GdkGlobalFunctionsExterns.gdk_events_get_angle(event1, event2, out angle);
	}

/// <summary>
/// <para>
/// If both events contain X/Y information, the center of both coordinates
/// will be returned in @x and @y.
/// </para>
/// </summary>

/// <param name="event1">
/// first #GdkEvent
/// </param>
/// <param name="event2">
/// second #GdkEvent
/// </param>
/// <param name="x">
/// return location for the X coordinate of the center
/// </param>
/// <param name="y">
/// return location for the Y coordinate of the center
/// </param>
/// <return>
/// %TRUE if the center could be calculated.
/// </return>

	public static bool EventsGetCenter(MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double x, out double y)
	{
		return GdkGlobalFunctionsExterns.gdk_events_get_center(event1, event2, out x, out y);
	}

/// <summary>
/// <para>
/// If both events have X/Y information, the distance between both coordinates
/// (as in a straight line going from @event1 to @event2) will be returned.
/// </para>
/// </summary>

/// <param name="event1">
/// first #GdkEvent
/// </param>
/// <param name="event2">
/// second #GdkEvent
/// </param>
/// <param name="distance">
/// return location for the distance
/// </param>
/// <return>
/// %TRUE if the distance could be calculated.
/// </return>

	public static bool EventsGetDistance(MentorLake.Gdk.GdkEventHandle event1, MentorLake.Gdk.GdkEventHandle event2, out double distance)
	{
		return GdkGlobalFunctionsExterns.gdk_events_get_distance(event1, event2, out distance);
	}

/// <summary>
/// <para>
/// Checks if any events are ready to be processed for any display.
/// </para>
/// </summary>

/// <return>
/// %TRUE if any events are pending.
/// </return>

	public static bool EventsPending()
	{
		return GdkGlobalFunctionsExterns.gdk_events_pending();
	}

/// <summary>
/// <para>
/// Flushes the output buffers of all display connections and waits
/// until all requests have been processed.
/// This is rarely needed by applications.
/// </para>
/// </summary>


	public static void Flush()
	{
		GdkGlobalFunctionsExterns.gdk_flush();
	}

/// <summary>
/// <para>
/// Obtains the root window (parent all other windows are inside)
/// for the default display and screen.
/// </para>
/// </summary>

/// <return>
/// the default root window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetDefaultRootWindow()
	{
		return GdkGlobalFunctionsExterns.gdk_get_default_root_window();
	}

/// <summary>
/// <para>
/// Gets the name of the display, which usually comes from the
/// `DISPLAY` environment variable or the
/// `--display` command line option.
/// </para>
/// </summary>

/// <return>
/// the name of the display.
/// </return>

	public static string GetDisplay()
	{
		return GdkGlobalFunctionsExterns.gdk_get_display();
	}

/// <summary>
/// <para>
/// Gets the display name specified in the command line arguments passed
/// to gdk_init() or gdk_parse_args(), if any.
/// </para>
/// </summary>

/// <return>
/// the display name, if specified explicitly,
///   otherwise %NULL this string is owned by GTK+ and must not be
///   modified or freed.
/// </return>

	public static string GetDisplayArgName()
	{
		return GdkGlobalFunctionsExterns.gdk_get_display_arg_name();
	}

/// <summary>
/// <para>
/// Gets the program class. Unless the program class has explicitly
/// been set with gdk_set_program_class() or with the `--class`
/// commandline option, the default value is the program name (determined
/// with g_get_prgname()) with the first character converted to uppercase.
/// </para>
/// </summary>

/// <return>
/// the program class.
/// </return>

	public static string GetProgramClass()
	{
		return GdkGlobalFunctionsExterns.gdk_get_program_class();
	}

/// <summary>
/// <para>
/// Gets whether event debugging output is enabled.
/// </para>
/// </summary>

/// <return>
/// %TRUE if event debugging output is enabled.
/// </return>

	public static bool GetShowEvents()
	{
		return GdkGlobalFunctionsExterns.gdk_get_show_events();
	}



	public static MentorLake.GLib.GQuark GlErrorQuark()
	{
		return GdkGlobalFunctionsExterns.gdk_gl_error_quark();
	}

/// <summary>
/// <para>
/// Initializes the GDK library and connects to the windowing system.
/// If initialization fails, a warning message is output and the application
/// terminates with a call to `exit(1)`.
/// </para>
/// <para>
/// Any arguments used by GDK are removed from the array and @argc and @argv
/// are updated accordingly.
/// </para>
/// <para>
/// GTK+ initializes GDK in gtk_init() and so this function is not usually
/// needed by GTK+ applications.
/// </para>
/// </summary>

/// <param name="argc">
/// the number of command line arguments.
/// </param>
/// <param name="argv">
/// the array of command line arguments.
/// </param>

	public static void Init(ref int argc, ref string[] argv)
	{
		GdkGlobalFunctionsExterns.gdk_init(ref argc, ref argv);
	}

/// <summary>
/// <para>
/// Initializes the GDK library and connects to the windowing system,
/// returning %TRUE on success.
/// </para>
/// <para>
/// Any arguments used by GDK are removed from the array and @argc and @argv
/// are updated accordingly.
/// </para>
/// <para>
/// GTK+ initializes GDK in gtk_init() and so this function is not usually
/// needed by GTK+ applications.
/// </para>
/// </summary>

/// <param name="argc">
/// the number of command line arguments.
/// </param>
/// <param name="argv">
/// the array of command line arguments.
/// </param>
/// <return>
/// %TRUE if initialization succeeded.
/// </return>

	public static bool InitCheck(ref int argc, ref string[] argv)
	{
		return GdkGlobalFunctionsExterns.gdk_init_check(ref argc, ref argv);
	}

/// <summary>
/// <para>
/// Grabs the keyboard so that all events are passed to this
/// application until the keyboard is ungrabbed with gdk_keyboard_ungrab().
/// This overrides any previous keyboard grab by this client.
/// </para>
/// <para>
/// If you set up anything at the time you take the grab that needs to be cleaned
/// up when the grab ends, you should handle the #GdkEventGrabBroken events that
/// are emitted when the grab ends unvoluntarily.
/// </para>
/// </summary>

/// <param name="window">
/// the #GdkWindow which will own the grab (the grab window).
/// </param>
/// <param name="owner_events">
/// if %FALSE then all keyboard events are reported with respect to
///   @window. If %TRUE then keyboard events for this application are
///   reported as normal, but keyboard events outside this application
///   are reported with respect to @window. Both key press and key
///   release events are always reported, independant of the event mask
///   set by the application.
/// </param>
/// <param name="time_">
/// a timestamp from a #GdkEvent, or %GDK_CURRENT_TIME if no timestamp is
///   available.
/// </param>
/// <return>
/// %GDK_GRAB_SUCCESS if the grab was successful.
/// </return>

	public static MentorLake.Gdk.GdkGrabStatus KeyboardGrab(MentorLake.Gdk.GdkWindowHandle window, bool owner_events, uint time_)
	{
		return GdkGlobalFunctionsExterns.gdk_keyboard_grab(window, owner_events, time_);
	}

/// <summary>
/// <para>
/// Ungrabs the keyboard on the default display, if it is grabbed by this
/// application.
/// </para>
/// </summary>

/// <param name="time_">
/// a timestamp from a #GdkEvent, or %GDK_CURRENT_TIME if no
///        timestamp is available.
/// </param>

	public static void KeyboardUngrab(uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_keyboard_ungrab(time_);
	}

/// <summary>
/// <para>
/// Obtains the upper- and lower-case versions of the keyval @symbol.
/// Examples of keyvals are #GDK_KEY_a, #GDK_KEY_Enter, #GDK_KEY_F1, etc.
/// </para>
/// </summary>

/// <param name="symbol">
/// a keyval
/// </param>
/// <param name="lower">
/// return location for lowercase version of @symbol
/// </param>
/// <param name="upper">
/// return location for uppercase version of @symbol
/// </param>

	public static void KeyvalConvertCase(uint symbol, out uint lower, out uint upper)
	{
		GdkGlobalFunctionsExterns.gdk_keyval_convert_case(symbol, out lower, out upper);
	}

/// <summary>
/// <para>
/// Converts a key name to a key value.
/// </para>
/// <para>
/// The names are the same as those in the
/// `gdk/gdkkeysyms.h` header file
/// but without the leading “GDK_KEY_”.
/// </para>
/// </summary>

/// <param name="keyval_name">
/// a key name
/// </param>
/// <return>
/// the corresponding key value, or %GDK_KEY_VoidSymbol
///     if the key name is not a valid key
/// </return>

	public static uint KeyvalFromName(string keyval_name)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_from_name(keyval_name);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the given key value is in lower case.
/// </para>
/// </summary>

/// <param name="keyval">
/// a key value.
/// </param>
/// <return>
/// %TRUE if @keyval is in lower case, or if @keyval is not
///   subject to case conversion.
/// </return>

	public static bool KeyvalIsLower(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_is_lower(keyval);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the given key value is in upper case.
/// </para>
/// </summary>

/// <param name="keyval">
/// a key value.
/// </param>
/// <return>
/// %TRUE if @keyval is in upper case, or if @keyval is not subject to
///  case conversion.
/// </return>

	public static bool KeyvalIsUpper(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_is_upper(keyval);
	}

/// <summary>
/// <para>
/// Converts a key value into a symbolic name.
/// </para>
/// <para>
/// The names are the same as those in the
/// `gdk/gdkkeysyms.h` header file
/// but without the leading “GDK_KEY_”.
/// </para>
/// </summary>

/// <param name="keyval">
/// a key value
/// </param>
/// <return>
/// a string containing the name
///     of the key, or %NULL if @keyval is not a valid key. The string
///     should not be modified.
/// </return>

	public static string KeyvalName(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_name(keyval);
	}

/// <summary>
/// <para>
/// Converts a key value to lower case, if applicable.
/// </para>
/// </summary>

/// <param name="keyval">
/// a key value.
/// </param>
/// <return>
/// the lower case form of @keyval, or @keyval itself if it is already
///  in lower case or it is not subject to case conversion.
/// </return>

	public static uint KeyvalToLower(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_to_lower(keyval);
	}

/// <summary>
/// <para>
/// Convert from a GDK key symbol to the corresponding ISO10646 (Unicode)
/// character.
/// </para>
/// </summary>

/// <param name="keyval">
/// a GDK key symbol
/// </param>
/// <return>
/// the corresponding unicode character, or 0 if there
///               is no corresponding character.
/// </return>

	public static uint KeyvalToUnicode(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_to_unicode(keyval);
	}

/// <summary>
/// <para>
/// Converts a key value to upper case, if applicable.
/// </para>
/// </summary>

/// <param name="keyval">
/// a key value.
/// </param>
/// <return>
/// the upper case form of @keyval, or @keyval itself if it is already
///   in upper case or it is not subject to case conversion.
/// </return>

	public static uint KeyvalToUpper(uint keyval)
	{
		return GdkGlobalFunctionsExterns.gdk_keyval_to_upper(keyval);
	}

/// <summary>
/// <para>
/// Lists the available visuals for the default screen.
/// (See gdk_screen_list_visuals())
/// A visual describes a hardware image data format.
/// For example, a visual might support 24-bit color, or 8-bit color,
/// and might expect pixels to be in a certain format.
/// </para>
/// <para>
/// Call g_list_free() on the return value when you’re finished with it.
/// </para>
/// </summary>

/// <return>
/// 
///     a list of visuals; the list must be freed, but not its contents
/// </return>

	public static MentorLake.GLib.GListHandle ListVisuals()
	{
		return GdkGlobalFunctionsExterns.gdk_list_visuals();
	}

/// <summary>
/// <para>
/// Indicates to the GUI environment that the application has finished
/// loading. If the applications opens windows, this function is
/// normally called after opening the application’s initial set of
/// windows.
/// </para>
/// <para>
/// GTK+ will call this function automatically after opening the first
/// #GtkWindow unless gtk_window_set_auto_startup_notification() is called
/// to disable that feature.
/// </para>
/// </summary>


	public static void NotifyStartupComplete()
	{
		GdkGlobalFunctionsExterns.gdk_notify_startup_complete();
	}

/// <summary>
/// <para>
/// Indicates to the GUI environment that the application has
/// finished loading, using a given identifier.
/// </para>
/// <para>
/// GTK+ will call this function automatically for #GtkWindow
/// with custom startup-notification identifier unless
/// gtk_window_set_auto_startup_notification() is called to
/// disable that feature.
/// </para>
/// </summary>

/// <param name="startup_id">
/// a startup-notification identifier, for which
///     notification process should be completed
/// </param>

	public static void NotifyStartupCompleteWithId(string startup_id)
	{
		GdkGlobalFunctionsExterns.gdk_notify_startup_complete_with_id(startup_id);
	}

/// <summary>
/// <para>
/// Gets the window that @window is embedded in.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// the embedding #GdkWindow, or
///     %NULL if @window is not an mbedded offscreen window
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle OffscreenWindowGetEmbedder(MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkGlobalFunctionsExterns.gdk_offscreen_window_get_embedder(window);
	}

/// <summary>
/// <para>
/// Gets the offscreen surface that an offscreen window renders into.
/// If you need to keep this around over window resizes, you need to
/// add a reference to it.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <return>
/// The offscreen surface, or
///   %NULL if not offscreen
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle OffscreenWindowGetSurface(MentorLake.Gdk.GdkWindowHandle window)
	{
		return GdkGlobalFunctionsExterns.gdk_offscreen_window_get_surface(window);
	}

/// <summary>
/// <para>
/// Sets @window to be embedded in @embedder.
/// </para>
/// <para>
/// To fully embed an offscreen window, in addition to calling this
/// function, it is also necessary to handle the #GdkWindow::pick-embedded-child
/// signal on the @embedder and the #GdkWindow::to-embedder and
/// #GdkWindow::from-embedder signals on @window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="embedder">
/// the #GdkWindow that @window gets embedded in
/// </param>

	public static void OffscreenWindowSetEmbedder(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowHandle embedder)
	{
		GdkGlobalFunctionsExterns.gdk_offscreen_window_set_embedder(window, embedder);
	}

/// <summary>
/// <para>
/// Creates a #PangoContext for the default GDK screen.
/// </para>
/// <para>
/// The context must be freed when you’re finished with it.
/// </para>
/// <para>
/// When using GTK+, normally you should use gtk_widget_get_pango_context()
/// instead of this function, to get the appropriate context for
/// the widget you intend to render text onto.
/// </para>
/// <para>
/// The newly created context will have the default font options (see
/// #cairo_font_options_t) for the default screen; if these options
/// change it will not be updated. Using gtk_widget_get_pango_context()
/// is more convenient if you want to keep a context around and track
/// changes to the screen’s font rendering settings.
/// </para>
/// </summary>

/// <return>
/// a new #PangoContext for the default display
/// </return>

	public static MentorLake.Pango.PangoContextHandle PangoContextGet()
	{
		return GdkGlobalFunctionsExterns.gdk_pango_context_get();
	}

/// <summary>
/// <para>
/// Creates a #PangoContext for @display.
/// </para>
/// <para>
/// The context must be freed when you’re finished with it.
/// </para>
/// <para>
/// When using GTK+, normally you should use gtk_widget_get_pango_context()
/// instead of this function, to get the appropriate context for
/// the widget you intend to render text onto.
/// </para>
/// <para>
/// The newly created context will have the default font options
/// (see #cairo_font_options_t) for the display; if these options
/// change it will not be updated. Using gtk_widget_get_pango_context()
/// is more convenient if you want to keep a context around and track
/// changes to the font rendering settings.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay for which the context is to be created
/// </param>
/// <return>
/// a new #PangoContext for @display
/// </return>

	public static MentorLake.Pango.PangoContextHandle PangoContextGetForDisplay(MentorLake.Gdk.GdkDisplayHandle display)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_context_get_for_display(display);
	}

/// <summary>
/// <para>
/// Creates a #PangoContext for @screen.
/// </para>
/// <para>
/// The context must be freed when you’re finished with it.
/// </para>
/// <para>
/// When using GTK+, normally you should use gtk_widget_get_pango_context()
/// instead of this function, to get the appropriate context for
/// the widget you intend to render text onto.
/// </para>
/// <para>
/// The newly created context will have the default font options
/// (see #cairo_font_options_t) for the screen; if these options
/// change it will not be updated. Using gtk_widget_get_pango_context()
/// is more convenient if you want to keep a context around and track
/// changes to the screen’s font rendering settings.
/// </para>
/// </summary>

/// <param name="screen">
/// the #GdkScreen for which the context is to be created.
/// </param>
/// <return>
/// a new #PangoContext for @screen
/// </return>

	public static MentorLake.Pango.PangoContextHandle PangoContextGetForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_context_get_for_screen(screen);
	}

/// <summary>
/// <para>
/// Obtains a clip region which contains the areas where the given ranges
/// of text would be drawn. @x_origin and @y_origin are the top left point
/// to center the layout. @index_ranges should contain
/// ranges of bytes in the layout’s text.
/// </para>
/// <para>
/// Note that the regions returned correspond to logical extents of the text
/// ranges, not ink extents. So the drawn layout may in fact touch areas out of
/// the clip region.  The clip region is mainly useful for highlightling parts
/// of text, such as when text is selected.
/// </para>
/// </summary>

/// <param name="layout">
/// a #PangoLayout
/// </param>
/// <param name="x_origin">
/// X pixel where you intend to draw the layout with this clip
/// </param>
/// <param name="y_origin">
/// Y pixel where you intend to draw the layout with this clip
/// </param>
/// <param name="index_ranges">
/// array of byte indexes into the layout, where even members of array are start indexes and odd elements are end indexes
/// </param>
/// <param name="n_ranges">
/// number of ranges in @index_ranges, i.e. half the size of @index_ranges
/// </param>
/// <return>
/// a clip region containing the given ranges
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle PangoLayoutGetClipRegion(MentorLake.Pango.PangoLayoutHandle layout, int x_origin, int y_origin, int index_ranges, int n_ranges)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_layout_get_clip_region(layout, x_origin, y_origin, index_ranges, n_ranges);
	}

/// <summary>
/// <para>
/// Obtains a clip region which contains the areas where the given
/// ranges of text would be drawn. @x_origin and @y_origin are the top left
/// position of the layout. @index_ranges
/// should contain ranges of bytes in the layout’s text. The clip
/// region will include space to the left or right of the line (to the
/// layout bounding box) if you have indexes above or below the indexes
/// contained inside the line. This is to draw the selection all the way
/// to the side of the layout. However, the clip region is in line coordinates,
/// not layout coordinates.
/// </para>
/// <para>
/// Note that the regions returned correspond to logical extents of the text
/// ranges, not ink extents. So the drawn line may in fact touch areas out of
/// the clip region.  The clip region is mainly useful for highlightling parts
/// of text, such as when text is selected.
/// </para>
/// </summary>

/// <param name="line">
/// a #PangoLayoutLine
/// </param>
/// <param name="x_origin">
/// X pixel where you intend to draw the layout line with this clip
/// </param>
/// <param name="y_origin">
/// baseline pixel where you intend to draw the layout line with this clip
/// </param>
/// <param name="index_ranges">
/// array of byte indexes into the layout,
///     where even members of array are start indexes and odd elements
///     are end indexes
/// </param>
/// <param name="n_ranges">
/// number of ranges in @index_ranges, i.e. half the size of @index_ranges
/// </param>
/// <return>
/// a clip region containing the given ranges
/// </return>

	public static MentorLake.cairo.cairo_region_tHandle PangoLayoutLineGetClipRegion(MentorLake.Pango.PangoLayoutLineHandle line, int x_origin, int y_origin, int[] index_ranges, int n_ranges)
	{
		return GdkGlobalFunctionsExterns.gdk_pango_layout_line_get_clip_region(line, x_origin, y_origin, index_ranges, n_ranges);
	}

/// <summary>
/// <para>
/// Parse command line arguments, and store for future
/// use by calls to gdk_display_open().
/// </para>
/// <para>
/// Any arguments used by GDK are removed from the array and @argc and @argv are
/// updated accordingly.
/// </para>
/// <para>
/// You shouldn’t call this function explicitly if you are using
/// gtk_init(), gtk_init_check(), gdk_init(), or gdk_init_check().
/// </para>
/// </summary>

/// <param name="argc">
/// the number of command line arguments.
/// </param>
/// <param name="argv">
/// the array of command line arguments.
/// </param>

	public static void ParseArgs(ref int argc, ref string[] argv)
	{
		GdkGlobalFunctionsExterns.gdk_parse_args(ref argc, ref argv);
	}

/// <summary>
/// <para>
/// Transfers image data from a #cairo_surface_t and converts it to an RGB(A)
/// representation inside a #GdkPixbuf. This allows you to efficiently read
/// individual pixels from cairo surfaces. For #GdkWindows, use
/// gdk_pixbuf_get_from_window() instead.
/// </para>
/// <para>
/// This function will create an RGB pixbuf with 8 bits per channel.
/// The pixbuf will contain an alpha channel if the @surface contains one.
/// </para>
/// </summary>

/// <param name="surface">
/// surface to copy from
/// </param>
/// <param name="src_x">
/// Source X coordinate within @surface
/// </param>
/// <param name="src_y">
/// Source Y coordinate within @surface
/// </param>
/// <param name="width">
/// Width in pixels of region to get
/// </param>
/// <param name="height">
/// Height in pixels of region to get
/// </param>
/// <return>
/// A newly-created pixbuf with a
///     reference count of 1, or %NULL on error
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle PixbufGetFromSurface(MentorLake.cairo.cairo_surface_tHandle surface, int src_x, int src_y, int width, int height)
	{
		return GdkGlobalFunctionsExterns.gdk_pixbuf_get_from_surface(surface, src_x, src_y, width, height);
	}

/// <summary>
/// <para>
/// Transfers image data from a #GdkWindow and converts it to an RGB(A)
/// representation inside a #GdkPixbuf.
/// </para>
/// <para>
/// In other words, copies image data from a server-side drawable to a
/// client-side RGB(A) buffer. This allows you to efficiently read
/// individual pixels on the client side.
/// </para>
/// <para>
/// This function will create an RGB pixbuf with 8 bits per channel with
/// the size specified by the @width and @height arguments scaled by the
/// scale factor of @window. The pixbuf will contain an alpha channel if
/// the @window contains one.
/// </para>
/// <para>
/// If the window is off the screen, then there is no image data in the
/// obscured/offscreen regions to be placed in the pixbuf. The contents of
/// portions of the pixbuf corresponding to the offscreen region are
/// undefined.
/// </para>
/// <para>
/// If the window you’re obtaining data from is partially obscured by
/// other windows, then the contents of the pixbuf areas corresponding
/// to the obscured regions are undefined.
/// </para>
/// <para>
/// If the window is not mapped (typically because it’s iconified/minimized
/// or not on the current workspace), then %NULL will be returned.
/// </para>
/// <para>
/// If memory can’t be allocated for the return value, %NULL will be returned
/// instead.
/// </para>
/// <para>
/// In short, there are several ways this function can fail, and if it fails
/// it returns %NULL; so check the return value.
/// </para>
/// <para>
/// You should rarely, if ever, need to call this function.
/// </para>
/// </summary>

/// <param name="window">
/// Source window
/// </param>
/// <param name="src_x">
/// Source X coordinate within @window
/// </param>
/// <param name="src_y">
/// Source Y coordinate within @window
/// </param>
/// <param name="width">
/// Width in pixels of region to get
/// </param>
/// <param name="height">
/// Height in pixels of region to get
/// </param>
/// <return>
/// A newly-created pixbuf with a
///   reference count of 1, or %NULL on error
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle PixbufGetFromWindow(MentorLake.Gdk.GdkWindowHandle window, int src_x, int src_y, int width, int height)
	{
		return GdkGlobalFunctionsExterns.gdk_pixbuf_get_from_window(window, src_x, src_y, width, height);
	}

/// <summary>
/// <para>
/// Grabs the pointer (usually a mouse) so that all events are passed to this
/// application until the pointer is ungrabbed with gdk_pointer_ungrab(), or
/// the grab window becomes unviewable.
/// This overrides any previous pointer grab by this client.
/// </para>
/// <para>
/// Pointer grabs are used for operations which need complete control over mouse
/// events, even if the mouse leaves the application.
/// For example in GTK+ it is used for Drag and Drop, for dragging the handle in
/// the #GtkHPaned and #GtkVPaned widgets.
/// </para>
/// <para>
/// Note that if the event mask of an X window has selected both button press and
/// button release events, then a button press event will cause an automatic
/// pointer grab until the button is released.
/// X does this automatically since most applications expect to receive button
/// press and release events in pairs.
/// It is equivalent to a pointer grab on the window with @owner_events set to
/// %TRUE.
/// </para>
/// <para>
/// If you set up anything at the time you take the grab that needs to be cleaned
/// up when the grab ends, you should handle the #GdkEventGrabBroken events that
/// are emitted when the grab ends unvoluntarily.
/// </para>
/// </summary>

/// <param name="window">
/// the #GdkWindow which will own the grab (the grab window).
/// </param>
/// <param name="owner_events">
/// if %FALSE then all pointer events are reported with respect to
///                @window and are only reported if selected by @event_mask. If %TRUE then pointer
///                events for this application are reported as normal, but pointer events outside
///                this application are reported with respect to @window and only if selected by
///                @event_mask. In either mode, unreported events are discarded.
/// </param>
/// <param name="event_mask">
/// specifies the event mask, which is used in accordance with
///              @owner_events. Note that only pointer events (i.e. button and motion events)
///              may be selected.
/// </param>
/// <param name="confine_to">
/// If non-%NULL, the pointer will be confined to this
///              window during the grab. If the pointer is outside @confine_to, it will
///              automatically be moved to the closest edge of @confine_to and enter
///              and leave events will be generated as necessary.
/// </param>
/// <param name="cursor">
/// the cursor to display while the grab is active. If this is %NULL then
///          the normal cursors are used for @window and its descendants, and the cursor
///          for @window is used for all other windows.
/// </param>
/// <param name="time_">
/// the timestamp of the event which led to this pointer grab. This usually
///         comes from a #GdkEventButton struct, though %GDK_CURRENT_TIME can be used if
///         the time isn’t known.
/// </param>
/// <return>
/// %GDK_GRAB_SUCCESS if the grab was successful.
/// </return>

	public static MentorLake.Gdk.GdkGrabStatus PointerGrab(MentorLake.Gdk.GdkWindowHandle window, bool owner_events, MentorLake.Gdk.GdkEventMask event_mask, MentorLake.Gdk.GdkWindowHandle confine_to, MentorLake.Gdk.GdkCursorHandle cursor, uint time_)
	{
		return GdkGlobalFunctionsExterns.gdk_pointer_grab(window, owner_events, event_mask, confine_to, cursor, time_);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the pointer on the default display is currently
/// grabbed by this application.
/// </para>
/// <para>
/// Note that this does not take the inmplicit pointer grab on button
/// presses into account.
/// </para>
/// </summary>

/// <return>
/// %TRUE if the pointer is currently grabbed by this application.
/// </return>

	public static bool PointerIsGrabbed()
	{
		return GdkGlobalFunctionsExterns.gdk_pointer_is_grabbed();
	}

/// <summary>
/// <para>
/// Ungrabs the pointer on the default display, if it is grabbed by this
/// application.
/// </para>
/// </summary>

/// <param name="time_">
/// a timestamp from a #GdkEvent, or %GDK_CURRENT_TIME if no
///  timestamp is available.
/// </param>

	public static void PointerUngrab(uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_pointer_ungrab(time_);
	}

/// <summary>
/// <para>
/// Prepare for parsing command line arguments for GDK. This is not
/// public API and should not be used in application code.
/// </para>
/// </summary>


	public static void PreParseLibgtkOnly()
	{
		GdkGlobalFunctionsExterns.gdk_pre_parse_libgtk_only();
	}

/// <summary>
/// <para>
/// Changes the contents of a property on a window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="property">
/// the property to change
/// </param>
/// <param name="type">
/// the new type for the property. If @mode is
///   %GDK_PROP_MODE_PREPEND or %GDK_PROP_MODE_APPEND, then this
///   must match the existing type or an error will occur.
/// </param>
/// <param name="format">
/// the new format for the property. If @mode is
///   %GDK_PROP_MODE_PREPEND or %GDK_PROP_MODE_APPEND, then this
///   must match the existing format or an error will occur.
/// </param>
/// <param name="mode">
/// a value describing how the new data is to be combined
///   with the current data.
/// </param>
/// <param name="data">
/// the data (a `guchar *`
///   `gushort *`, or `gulong *`,
///   depending on @format), cast to a `guchar *`.
/// </param>
/// <param name="nelements">
/// the number of elements of size determined by the format,
///   contained in @data.
/// </param>

	public static void PropertyChange(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, int format, MentorLake.Gdk.GdkPropMode mode, byte data, int nelements)
	{
		GdkGlobalFunctionsExterns.gdk_property_change(window, property, type, format, mode, data, nelements);
	}

/// <summary>
/// <para>
/// Deletes a property from a window.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="property">
/// the property to delete
/// </param>

	public static void PropertyDelete(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property)
	{
		GdkGlobalFunctionsExterns.gdk_property_delete(window, property);
	}

/// <summary>
/// <para>
/// Retrieves a portion of the contents of a property. If the
/// property does not exist, then the function returns %FALSE,
/// and %GDK_NONE will be stored in @actual_property_type.
/// </para>
/// <para>
/// The XGetWindowProperty() function that gdk_property_get()
/// uses has a very confusing and complicated set of semantics.
/// Unfortunately, gdk_property_get() makes the situation
/// worse instead of better (the semantics should be considered
/// undefined), and also prints warnings to stderr in cases where it
/// should return a useful error to the program. You are advised to use
/// XGetWindowProperty() directly until a replacement function for
/// gdk_property_get() is provided.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="property">
/// the property to retrieve
/// </param>
/// <param name="type">
/// the desired property type, or %GDK_NONE, if any type of data
///   is acceptable. If this does not match the actual
///   type, then @actual_format and @actual_length will
///   be filled in, a warning will be printed to stderr
///   and no data will be returned.
/// </param>
/// <param name="offset">
/// the offset into the property at which to begin
///   retrieving data, in 4 byte units.
/// </param>
/// <param name="length">
/// the length of the data to retrieve in bytes.  Data is
///   considered to be retrieved in 4 byte chunks, so @length
///   will be rounded up to the next highest 4 byte boundary
///   (so be careful not to pass a value that might overflow
///   when rounded up).
/// </param>
/// <param name="pdelete">
/// if %TRUE, delete the property after retrieving the
///   data.
/// </param>
/// <param name="actual_property_type">
/// location to store the
///   actual type of the property.
/// </param>
/// <param name="actual_format">
/// location to store the actual return format of the
///   data; either 8, 16 or 32 bits.
/// </param>
/// <param name="actual_length">
/// location to store the length of the retrieved data, in
///   bytes.  Data returned in the 32 bit format is stored
///   in a long variable, so the actual number of 32 bit
///   elements should be be calculated via
///   @actual_length / sizeof(glong) to ensure portability to
///   64 bit systems.
/// </param>
/// <param name="data">
/// location
///   to store a pointer to the data. The retrieved data should be
///   freed with g_free() when you are finished using it.
/// </param>
/// <return>
/// %TRUE if data was successfully received and stored
///   in @data, otherwise %FALSE.
/// </return>

	public static bool PropertyGet(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, ulong offset, ulong length, int pdelete, out MentorLake.Gdk.GdkAtom actual_property_type, out int actual_format, out int actual_length, out byte[] data)
	{
		return GdkGlobalFunctionsExterns.gdk_property_get(window, property, type, offset, length, pdelete, out actual_property_type, out actual_format, out actual_length, out data);
	}

/// <summary>
/// <para>
/// This function returns the available bit depths for the default
/// screen. It’s equivalent to listing the visuals
/// (gdk_list_visuals()) and then looking at the depth field in each
/// visual, removing duplicates.
/// </para>
/// <para>
/// The array returned by this function should not be freed.
/// </para>
/// </summary>

/// <param name="depths">
/// return
///     location for available depths
/// </param>
/// <param name="count">
/// return location for number of available depths
/// </param>

	public static void QueryDepths(out int[] depths, out int count)
	{
		GdkGlobalFunctionsExterns.gdk_query_depths(out depths, out count);
	}

/// <summary>
/// <para>
/// This function returns the available visual types for the default
/// screen. It’s equivalent to listing the visuals
/// (gdk_list_visuals()) and then looking at the type field in each
/// visual, removing duplicates.
/// </para>
/// <para>
/// The array returned by this function should not be freed.
/// </para>
/// </summary>

/// <param name="visual_types">
/// return
///     location for the available visual types
/// </param>
/// <param name="count">
/// return location for the number of available visual types
/// </param>

	public static void QueryVisualTypes(out MentorLake.Gdk.GdkVisualType[] visual_types, out int count)
	{
		GdkGlobalFunctionsExterns.gdk_query_visual_types(out visual_types, out count);
	}

/// <summary>
/// <para>
/// Retrieves the contents of a selection in a given
/// form.
/// </para>
/// </summary>

/// <param name="requestor">
/// a #GdkWindow.
/// </param>
/// <param name="selection">
/// an atom identifying the selection to get the
///   contents of.
/// </param>
/// <param name="target">
/// the form in which to retrieve the selection.
/// </param>
/// <param name="time_">
/// the timestamp to use when retrieving the
///   selection. The selection owner may refuse the
///   request if it did not own the selection at
///   the time indicated by the timestamp.
/// </param>

	public static void SelectionConvert(MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_selection_convert(requestor, selection, target, time_);
	}

/// <summary>
/// <para>
/// Determines the owner of the given selection.
/// </para>
/// </summary>

/// <param name="selection">
/// an atom indentifying a selection.
/// </param>
/// <return>
/// if there is a selection owner
///   for this window, and it is a window known to the current process,
///   the #GdkWindow that owns the selection, otherwise %NULL. Note
///   that the return value may be owned by a different process if a
///   foreign window was previously created for that window, but a new
///   foreign window will never be created by this call.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle SelectionOwnerGet(MentorLake.Gdk.GdkAtom selection)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_get(selection);
	}

/// <summary>
/// <para>
/// Determine the owner of the given selection.
/// </para>
/// <para>
/// Note that the return value may be owned by a different
/// process if a foreign window was previously created for that
/// window, but a new foreign window will never be created by this call.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="selection">
/// an atom indentifying a selection
/// </param>
/// <return>
/// if there is a selection owner
///    for this window, and it is a window known to the current
///    process, the #GdkWindow that owns the selection, otherwise
///    %NULL.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle SelectionOwnerGetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom selection)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_get_for_display(display, selection);
	}

/// <summary>
/// <para>
/// Sets the owner of the given selection.
/// </para>
/// </summary>

/// <param name="owner">
/// a #GdkWindow or %NULL to indicate that the
///   the owner for the given should be unset.
/// </param>
/// <param name="selection">
/// an atom identifying a selection.
/// </param>
/// <param name="time_">
/// timestamp to use when setting the selection.
///   If this is older than the timestamp given last
///   time the owner was set for the given selection, the
///   request will be ignored.
/// </param>
/// <param name="send_event">
/// if %TRUE, and the new owner is different
///   from the current owner, the current owner
///   will be sent a SelectionClear event.
/// </param>
/// <return>
/// %TRUE if the selection owner was successfully
///   changed to @owner, otherwise %FALSE.
/// </return>

	public static bool SelectionOwnerSet(MentorLake.Gdk.GdkWindowHandle owner, MentorLake.Gdk.GdkAtom selection, uint time_, bool send_event)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_set(owner, selection, time_, send_event);
	}

/// <summary>
/// <para>
/// Sets the #GdkWindow @owner as the current owner of the selection @selection.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay
/// </param>
/// <param name="owner">
/// a #GdkWindow or %NULL to indicate that the owner for
///         the given should be unset
/// </param>
/// <param name="selection">
/// an atom identifying a selection
/// </param>
/// <param name="time_">
/// timestamp to use when setting the selection
///         If this is older than the timestamp given last time the owner was
///         set for the given selection, the request will be ignored
/// </param>
/// <param name="send_event">
/// if %TRUE, and the new owner is different from the current
///              owner, the current owner will be sent a SelectionClear event
/// </param>
/// <return>
/// %TRUE if the selection owner was successfully changed to owner,
///    otherwise %FALSE.
/// </return>

	public static bool SelectionOwnerSetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkWindowHandle owner, MentorLake.Gdk.GdkAtom selection, uint time_, bool send_event)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_owner_set_for_display(display, owner, selection, time_, send_event);
	}

/// <summary>
/// <para>
/// Retrieves selection data that was stored by the selection
/// data in response to a call to gdk_selection_convert(). This function
/// will not be used by applications, who should use the #GtkClipboard
/// API instead.
/// </para>
/// </summary>

/// <param name="requestor">
/// the window on which the data is stored
/// </param>
/// <param name="data">
/// location to store a pointer to the retrieved data.
///        If the retrieval failed, %NULL we be stored here, otherwise, it
///        will be non-%NULL and the returned data should be freed with g_free()
///        when you are finished using it. The length of the
///        allocated memory is one more than the length
///        of the returned data, and the final byte will always
///        be zero, to ensure nul-termination of strings
/// </param>
/// <param name="prop_type">
/// location to store the type of the property
/// </param>
/// <param name="prop_format">
/// location to store the format of the property
/// </param>
/// <return>
/// the length of the retrieved data.
/// </return>

	public static int SelectionPropertyGet(MentorLake.Gdk.GdkWindowHandle requestor, byte data, MentorLake.Gdk.GdkAtomHandle prop_type, int prop_format)
	{
		return GdkGlobalFunctionsExterns.gdk_selection_property_get(requestor, data, prop_type, prop_format);
	}

/// <summary>
/// <para>
/// Sends a response to SelectionRequest event.
/// </para>
/// </summary>

/// <param name="requestor">
/// window to which to deliver response.
/// </param>
/// <param name="selection">
/// selection that was requested.
/// </param>
/// <param name="target">
/// target that was selected.
/// </param>
/// <param name="property">
/// property in which the selection owner stored the
///   data, or %GDK_NONE to indicate that the request
///   was rejected.
/// </param>
/// <param name="time_">
/// timestamp.
/// </param>

	public static void SelectionSendNotify(MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, MentorLake.Gdk.GdkAtom property, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_selection_send_notify(requestor, selection, target, property, time_);
	}

/// <summary>
/// <para>
/// Send a response to SelectionRequest event.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay where @requestor is realized
/// </param>
/// <param name="requestor">
/// window to which to deliver response
/// </param>
/// <param name="selection">
/// selection that was requested
/// </param>
/// <param name="target">
/// target that was selected
/// </param>
/// <param name="property">
/// property in which the selection owner stored the data,
///            or %GDK_NONE to indicate that the request was rejected
/// </param>
/// <param name="time_">
/// timestamp
/// </param>

	public static void SelectionSendNotifyForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkWindowHandle requestor, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, MentorLake.Gdk.GdkAtom property, uint time_)
	{
		GdkGlobalFunctionsExterns.gdk_selection_send_notify_for_display(display, requestor, selection, target, property, time_);
	}

/// <summary>
/// <para>
/// Sets a list of backends that GDK should try to use.
/// </para>
/// <para>
/// This can be be useful if your application does not
/// work with certain GDK backends.
/// </para>
/// <para>
/// By default, GDK tries all included backends.
/// </para>
/// <para>
/// For example,
/// |[<!-- language="C" -->
/// gdk_set_allowed_backends ("wayland,quartz,*");
/// ]|
/// instructs GDK to try the Wayland backend first,
/// followed by the Quartz backend, and then all
/// others.
/// </para>
/// <para>
/// If the `GDK_BACKEND` environment variable
/// is set, it determines what backends are tried in what
/// order, while still respecting the set of allowed backends
/// that are specified by this function.
/// </para>
/// <para>
/// The possible backend names are x11, win32, quartz,
/// broadway, wayland. You can also include a * in the
/// list to try all remaining backends.
/// </para>
/// <para>
/// This call must happen prior to gdk_display_open(),
/// gtk_init(), gtk_init_with_args() or gtk_init_check()
/// in order to take effect.
/// </para>
/// </summary>

/// <param name="backends">
/// a comma-separated list of backends
/// </param>

	public static void SetAllowedBackends(string backends)
	{
		GdkGlobalFunctionsExterns.gdk_set_allowed_backends(backends);
	}

/// <summary>
/// <para>
/// Set the double click time for the default display. See
/// gdk_display_set_double_click_time().
/// See also gdk_display_set_double_click_distance().
/// Applications should not set this, it is a
/// global user-configured setting.
/// </para>
/// </summary>

/// <param name="msec">
/// double click time in milliseconds (thousandths of a second)
/// </param>

	public static void SetDoubleClickTime(uint msec)
	{
		GdkGlobalFunctionsExterns.gdk_set_double_click_time(msec);
	}

/// <summary>
/// <para>
/// Sets the program class. The X11 backend uses the program class to set
/// the class name part of the `WM_CLASS` property on
/// toplevel windows; see the ICCCM.
/// </para>
/// <para>
/// The program class can still be overridden with the --class command
/// line option.
/// </para>
/// </summary>

/// <param name="program_class">
/// a string.
/// </param>

	public static void SetProgramClass(string program_class)
	{
		GdkGlobalFunctionsExterns.gdk_set_program_class(program_class);
	}

/// <summary>
/// <para>
/// Sets whether a trace of received events is output.
/// Note that GTK+ must be compiled with debugging (that is,
/// configured using the `--enable-debug` option)
/// to use this option.
/// </para>
/// </summary>

/// <param name="show_events">
/// %TRUE to output event debugging information.
/// </param>

	public static void SetShowEvents(bool show_events)
	{
		GdkGlobalFunctionsExterns.gdk_set_show_events(show_events);
	}

/// <summary>
/// <para>
/// Obtains a desktop-wide setting, such as the double-click time,
/// for the default screen. See gdk_screen_get_setting().
/// </para>
/// </summary>

/// <param name="name">
/// the name of the setting.
/// </param>
/// <param name="value">
/// location to store the value of the setting.
/// </param>
/// <return>
/// %TRUE if the setting existed and a value was stored
///   in @value, %FALSE otherwise.
/// </return>

	public static bool SettingGet(string name, MentorLake.GObject.GValueHandle value)
	{
		return GdkGlobalFunctionsExterns.gdk_setting_get(name, value);
	}


/// <param name="window">
/// </param>
/// <param name="unset_flags">
/// </param>
/// <param name="set_flags">
/// </param>

	public static void SynthesizeWindowState(MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkWindowState unset_flags, MentorLake.Gdk.GdkWindowState set_flags)
	{
		GdkGlobalFunctionsExterns.gdk_synthesize_window_state(window, unset_flags, set_flags);
	}

/// <summary>
/// <para>
/// Retrieves a pixel from @window to force the windowing
/// system to carry out any pending rendering commands.
/// </para>
/// <para>
/// This function is intended to be used to synchronize with rendering
/// pipelines, to benchmark windowing system rendering operations.
/// </para>
/// </summary>

/// <param name="window">
/// a mapped #GdkWindow
/// </param>

	public static void TestRenderSync(MentorLake.Gdk.GdkWindowHandle window)
	{
		GdkGlobalFunctionsExterns.gdk_test_render_sync(window);
	}

/// <summary>
/// <para>
/// This function is intended to be used in GTK+ test programs.
/// It will warp the mouse pointer to the given (@x,@y) coordinates
/// within @window and simulate a button press or release event.
/// Because the mouse pointer needs to be warped to the target
/// location, use of this function outside of test programs that
/// run in their own virtual windowing system (e.g. Xvfb) is not
/// recommended.
/// </para>
/// <para>
/// Also, gdk_test_simulate_button() is a fairly low level function,
/// for most testing purposes, gtk_test_widget_click() is the right
/// function to call which will generate a button press event followed
/// by its accompanying button release event.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow to simulate a button event for
/// </param>
/// <param name="x">
/// x coordinate within @window for the button event
/// </param>
/// <param name="y">
/// y coordinate within @window for the button event
/// </param>
/// <param name="button">
/// Number of the pointer button for the event, usually 1, 2 or 3
/// </param>
/// <param name="modifiers">
/// Keyboard modifiers the event is setup with
/// </param>
/// <param name="button_pressrelease">
/// either %GDK_BUTTON_PRESS or %GDK_BUTTON_RELEASE
/// </param>
/// <return>
/// whether all actions necessary for a button event simulation
///     were carried out successfully
/// </return>

	public static bool TestSimulateButton(MentorLake.Gdk.GdkWindowHandle window, int x, int y, uint button, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.Gdk.GdkEventType button_pressrelease)
	{
		return GdkGlobalFunctionsExterns.gdk_test_simulate_button(window, x, y, button, modifiers, button_pressrelease);
	}

/// <summary>
/// <para>
/// This function is intended to be used in GTK+ test programs.
/// If (@x,@y) are > (-1,-1), it will warp the mouse pointer to
/// the given (@x,@y) coordinates within @window and simulate a
/// key press or release event.
/// </para>
/// <para>
/// When the mouse pointer is warped to the target location, use
/// of this function outside of test programs that run in their
/// own virtual windowing system (e.g. Xvfb) is not recommended.
/// If (@x,@y) are passed as (-1,-1), the mouse pointer will not
/// be warped and @window origin will be used as mouse pointer
/// location for the event.
/// </para>
/// <para>
/// Also, gdk_test_simulate_key() is a fairly low level function,
/// for most testing purposes, gtk_test_widget_send_key() is the
/// right function to call which will generate a key press event
/// followed by its accompanying key release event.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow to simulate a key event for
/// </param>
/// <param name="x">
/// x coordinate within @window for the key event
/// </param>
/// <param name="y">
/// y coordinate within @window for the key event
/// </param>
/// <param name="keyval">
/// A GDK keyboard value
/// </param>
/// <param name="modifiers">
/// Keyboard modifiers the event is setup with
/// </param>
/// <param name="key_pressrelease">
/// either %GDK_KEY_PRESS or %GDK_KEY_RELEASE
/// </param>
/// <return>
/// whether all actions necessary for a key event simulation
///     were carried out successfully
/// </return>

	public static bool TestSimulateKey(MentorLake.Gdk.GdkWindowHandle window, int x, int y, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.Gdk.GdkEventType key_pressrelease)
	{
		return GdkGlobalFunctionsExterns.gdk_test_simulate_key(window, x, y, keyval, modifiers, key_pressrelease);
	}

/// <summary>
/// <para>
/// Converts a text property in the given encoding to
/// a list of UTF-8 strings.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay
/// </param>
/// <param name="encoding">
/// an atom representing the encoding of the text
/// </param>
/// <param name="format">
/// the format of the property
/// </param>
/// <param name="text">
/// the text to convert
/// </param>
/// <param name="length">
/// the length of @text, in bytes
/// </param>
/// <param name="list">
/// location to store the list
///            of strings or %NULL. The list should be freed with
///            g_strfreev().
/// </param>
/// <return>
/// the number of strings in the resulting list
/// </return>

	public static int TextPropertyToUtf8ListForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, byte[] text, int length, out string[] list)
	{
		return GdkGlobalFunctionsExterns.gdk_text_property_to_utf8_list_for_display(display, encoding, format, text, length, out list);
	}

/// <summary>
/// <para>
/// A wrapper for the common usage of gdk_threads_add_idle_full()
/// assigning the default priority, #G_PRIORITY_DEFAULT_IDLE.
/// </para>
/// <para>
/// See gdk_threads_add_idle_full().
/// </para>
/// </summary>

/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ThreadsAddIdle(MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_idle(function, data);
	}

/// <summary>
/// <para>
/// Adds a function to be called whenever there are no higher priority
/// events pending.  If the function returns %FALSE it is automatically
/// removed from the list of event sources and will not be called again.
/// </para>
/// <para>
/// This variant of g_idle_add_full() calls @function with the GDK lock
/// held. It can be thought of a MT-safe version for GTK+ widgets for the
/// following use case, where you have to worry about idle_callback()
/// running in thread A and accessing @self after it has been finalized
/// in thread B:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gboolean
/// idle_callback (gpointer data)
/// {
///    // gdk_threads_enter(); would be needed for g_idle_add()
/// </para>
/// <para>
///    SomeWidget *self = data;
///    // do stuff with self
/// </para>
/// <para>
///    self->idle_id = 0;
/// </para>
/// <para>
///    // gdk_threads_leave(); would be needed for g_idle_add()
///    return FALSE;
/// }
/// </para>
/// <para>
/// static void
/// some_widget_do_stuff_later (SomeWidget *self)
/// {
///    self->idle_id = gdk_threads_add_idle (idle_callback, self)
///    // using g_idle_add() here would require thread protection in the callback
/// }
/// </para>
/// <para>
/// static void
/// some_widget_finalize (GObject *object)
/// {
///    SomeWidget *self = SOME_WIDGET (object);
///    if (self->idle_id)
///      g_source_remove (self->idle_id);
///    G_OBJECT_CLASS (parent_class)->finalize (object);
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the idle source. Typically this will be in the
///            range between #G_PRIORITY_DEFAULT_IDLE and #G_PRIORITY_HIGH_IDLE
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the idle is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ThreadsAddIdleFull(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_idle_full(priority, function, data, notify);
	}

/// <summary>
/// <para>
/// A wrapper for the common usage of gdk_threads_add_timeout_full()
/// assigning the default priority, #G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// See gdk_threads_add_timeout_full().
/// </para>
/// </summary>

/// <param name="interval">
/// the time between calls to the function, in milliseconds
///             (1/1000ths of a second)
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ThreadsAddTimeout(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout(interval, function, data);
	}

/// <summary>
/// <para>
/// Sets a function to be called at regular intervals holding the GDK lock,
/// with the given priority.  The function is called repeatedly until it
/// returns %FALSE, at which point the timeout is automatically destroyed
/// and the function will not be called again.  The @notify function is
/// called when the timeout is destroyed.  The first call to the
/// function will be at the end of the first @interval.
/// </para>
/// <para>
/// Note that timeout functions may be delayed, due to the processing of other
/// event sources. Thus they should not be relied on for precise timing.
/// After each call to the timeout function, the time of the next
/// timeout is recalculated based on the current time and the given interval
/// (it does not try to “catch up” time lost in delays).
/// </para>
/// <para>
/// This variant of g_timeout_add_full() can be thought of a MT-safe version
/// for GTK+ widgets for the following use case:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static gboolean timeout_callback (gpointer data)
/// {
///    SomeWidget *self = data;
/// </para>
/// <para>
///    // do stuff with self
/// </para>
/// <para>
///    self->timeout_id = 0;
/// </para>
/// <para>
///    return G_SOURCE_REMOVE;
/// }
/// </para>
/// <para>
/// static void some_widget_do_stuff_later (SomeWidget *self)
/// {
///    self->timeout_id = g_timeout_add (timeout_callback, self)
/// }
/// </para>
/// <para>
/// static void some_widget_finalize (GObject *object)
/// {
///    SomeWidget *self = SOME_WIDGET (object);
/// </para>
/// <para>
///    if (self->timeout_id)
///      g_source_remove (self->timeout_id);
/// </para>
/// <para>
///    G_OBJECT_CLASS (parent_class)->finalize (object);
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the timeout source. Typically this will be in the
///            range between #G_PRIORITY_DEFAULT_IDLE and #G_PRIORITY_HIGH_IDLE.
/// </param>
/// <param name="interval">
/// the time between calls to the function, in milliseconds
///             (1/1000ths of a second)
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the timeout is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ThreadsAddTimeoutFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout_full(priority, interval, function, data, notify);
	}

/// <summary>
/// <para>
/// A wrapper for the common usage of gdk_threads_add_timeout_seconds_full()
/// assigning the default priority, #G_PRIORITY_DEFAULT.
/// </para>
/// <para>
/// For details, see gdk_threads_add_timeout_full().
/// </para>
/// </summary>

/// <param name="interval">
/// the time between calls to the function, in seconds
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ThreadsAddTimeoutSeconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout_seconds(interval, function, data);
	}

/// <summary>
/// <para>
/// A variant of gdk_threads_add_timeout_full() with second-granularity.
/// See g_timeout_add_seconds_full() for a discussion of why it is
/// a good idea to use this function if you don’t need finer granularity.
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the timeout source. Typically this will be in the
///            range between #G_PRIORITY_DEFAULT_IDLE and #G_PRIORITY_HIGH_IDLE.
/// </param>
/// <param name="interval">
/// the time between calls to the function, in seconds
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the timeout is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ThreadsAddTimeoutSecondsFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GdkGlobalFunctionsExterns.gdk_threads_add_timeout_seconds_full(priority, interval, function, data, notify);
	}

/// <summary>
/// <para>
/// This function marks the beginning of a critical section in which
/// GDK and GTK+ functions can be called safely and without causing race
/// conditions. Only one thread at a time can be in such a critial
/// section.
/// </para>
/// </summary>


	public static void ThreadsEnter()
	{
		GdkGlobalFunctionsExterns.gdk_threads_enter();
	}

/// <summary>
/// <para>
/// Initializes GDK so that it can be used from multiple threads
/// in conjunction with gdk_threads_enter() and gdk_threads_leave().
/// </para>
/// <para>
/// This call must be made before any use of the main loop from
/// GTK+; to be safe, call it before gtk_init().
/// </para>
/// </summary>


	public static void ThreadsInit()
	{
		GdkGlobalFunctionsExterns.gdk_threads_init();
	}

/// <summary>
/// <para>
/// Leaves a critical region begun with gdk_threads_enter().
/// </para>
/// </summary>


	public static void ThreadsLeave()
	{
		GdkGlobalFunctionsExterns.gdk_threads_leave();
	}

/// <summary>
/// <para>
/// Allows the application to replace the standard method that
/// GDK uses to protect its data structures. Normally, GDK
/// creates a single #GMutex that is locked by gdk_threads_enter(),
/// and released by gdk_threads_leave(); using this function an
/// application provides, instead, a function @enter_fn that is
/// called by gdk_threads_enter() and a function @leave_fn that is
/// called by gdk_threads_leave().
/// </para>
/// <para>
/// The functions must provide at least same locking functionality
/// as the default implementation, but can also do extra application
/// specific processing.
/// </para>
/// <para>
/// As an example, consider an application that has its own recursive
/// lock that when held, holds the GTK+ lock as well. When GTK+ unlocks
/// the GTK+ lock when entering a recursive main loop, the application
/// must temporarily release its lock as well.
/// </para>
/// <para>
/// Most threaded GTK+ apps won’t need to use this method.
/// </para>
/// <para>
/// This method must be called before gdk_threads_init(), and cannot
/// be called multiple times.
/// </para>
/// </summary>

/// <param name="enter_fn">
/// function called to guard GDK
/// </param>
/// <param name="leave_fn">
/// function called to release the guard
/// </param>

	public static void ThreadsSetLockFunctions(MentorLake.GObject.GCallback enter_fn, MentorLake.GObject.GCallback leave_fn)
	{
		GdkGlobalFunctionsExterns.gdk_threads_set_lock_functions(enter_fn, leave_fn);
	}

/// <summary>
/// <para>
/// Convert from a ISO10646 character to a key symbol.
/// </para>
/// </summary>

/// <param name="wc">
/// a ISO10646 encoded character
/// </param>
/// <return>
/// the corresponding GDK key symbol, if one exists.
///               or, if there is no corresponding symbol,
///               wc | 0x01000000
/// </return>

	public static uint UnicodeToKeyval(uint wc)
	{
		return GdkGlobalFunctionsExterns.gdk_unicode_to_keyval(wc);
	}

/// <summary>
/// <para>
/// Converts an UTF-8 string into the best possible representation
/// as a STRING. The representation of characters not in STRING
/// is not specified; it may be as pseudo-escape sequences
/// \x{ABCD}, or it may be in some other form of approximation.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 string
/// </param>
/// <return>
/// the newly-allocated string, or %NULL if the
///          conversion failed. (It should not fail for any properly
///          formed UTF-8 string unless system limits like memory or
///          file descriptors are exceeded.)
/// </return>

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
	internal static extern void gdk_property_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, int format, MentorLake.Gdk.GdkPropMode mode, byte data, int nelements);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_property_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_property_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, MentorLake.Gdk.GdkAtom property, MentorLake.Gdk.GdkAtom type, ulong offset, ulong length, int pdelete, out MentorLake.Gdk.GdkAtom actual_property_type, out int actual_format, out int actual_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 8)] out byte[] data);

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
	internal static extern int gdk_selection_property_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle requestor, byte data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAtomHandle>))] MentorLake.Gdk.GdkAtomHandle prop_type, int prop_format);

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
	internal static extern int gdk_text_property_to_utf8_list_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gdk.GdkAtom encoding, int format, byte[] text, int length, [MarshalAs(UnmanagedType.LPArray)] out string[] list);

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
