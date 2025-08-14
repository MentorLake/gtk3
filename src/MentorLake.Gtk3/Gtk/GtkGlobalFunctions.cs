namespace MentorLake.Gtk;

public class GtkGlobalFunctions
{
/// <summary>
/// <para>
/// Finds the first accelerator in any #GtkAccelGroup attached
/// to @object that matches @accel_key and @accel_mods, and
/// activates that accelerator.
/// </para>
/// </summary>

/// <param name="@object">
/// the #GObject, usually a #GtkWindow, on which
///     to activate the accelerator
/// </param>
/// <param name="accel_key">
/// accelerator keyval from a key event
/// </param>
/// <param name="accel_mods">
/// keyboard state mask from a key event
/// </param>
/// <return>
/// %TRUE if an accelerator was activated and handled
///     this keypress
/// </return>

	public static bool AccelGroupsActivate(MentorLake.GObject.GObjectHandle @object, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accel_groups_activate(@object, accel_key, accel_mods);
	}

/// <summary>
/// <para>
/// Gets a list of all accel groups which are attached to @object.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject, usually a #GtkWindow
/// </param>
/// <return>
/// a list of
///     all accel groups which are attached to @object
/// </return>

	public static MentorLake.GLib.GSListHandle AccelGroupsFromObject(MentorLake.GObject.GObjectHandle @object)
	{
		return GtkGlobalFunctionsExterns.gtk_accel_groups_from_object(@object);
	}

/// <summary>
/// <para>
/// Gets the modifier mask.
/// </para>
/// <para>
/// The modifier mask determines which modifiers are considered significant
/// for keyboard accelerators. See gtk_accelerator_set_default_mod_mask().
/// </para>
/// </summary>

/// <return>
/// the default accelerator modifier mask
/// </return>

	public static MentorLake.Gdk.GdkModifierType AcceleratorGetDefaultModMask()
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_get_default_mod_mask();
	}

/// <summary>
/// <para>
/// Converts an accelerator keyval and modifier mask into a string
/// which can be used to represent the accelerator to the user.
/// </para>
/// </summary>

/// <param name="accelerator_key">
/// accelerator keyval
/// </param>
/// <param name="accelerator_mods">
/// accelerator modifier mask
/// </param>
/// <return>
/// a newly-allocated string representing the accelerator.
/// </return>

	public static string AcceleratorGetLabel(uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_get_label(accelerator_key, accelerator_mods);
	}

/// <summary>
/// <para>
/// Converts an accelerator keyval and modifier mask
/// into a (possibly translated) string that can be displayed to
/// a user, similarly to gtk_accelerator_get_label(), but handling
/// keycodes.
/// </para>
/// <para>
/// This is only useful for system-level components, applications
/// should use gtk_accelerator_parse() instead.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay or %NULL to use the default display
/// </param>
/// <param name="accelerator_key">
/// accelerator keyval
/// </param>
/// <param name="keycode">
/// accelerator keycode
/// </param>
/// <param name="accelerator_mods">
/// accelerator modifier mask
/// </param>
/// <return>
/// a newly-allocated string representing the accelerator.
/// </return>

	public static string AcceleratorGetLabelWithKeycode(MentorLake.Gdk.GdkDisplayHandle display, uint accelerator_key, uint keycode, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_get_label_with_keycode(display, accelerator_key, keycode, accelerator_mods);
	}

/// <summary>
/// <para>
/// Converts an accelerator keyval and modifier mask into a string
/// parseable by gtk_accelerator_parse(). For example, if you pass in
/// #GDK_KEY_q and #GDK_CONTROL_MASK, this function returns “<Control>q”.
/// </para>
/// <para>
/// If you need to display accelerators in the user interface,
/// see gtk_accelerator_get_label().
/// </para>
/// </summary>

/// <param name="accelerator_key">
/// accelerator keyval
/// </param>
/// <param name="accelerator_mods">
/// accelerator modifier mask
/// </param>
/// <return>
/// a newly-allocated accelerator name
/// </return>

	public static string AcceleratorName(uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_name(accelerator_key, accelerator_mods);
	}

/// <summary>
/// <para>
/// Converts an accelerator keyval and modifier mask
/// into a string parseable by gtk_accelerator_parse_with_keycode(),
/// similarly to gtk_accelerator_name() but handling keycodes.
/// This is only useful for system-level components, applications
/// should use gtk_accelerator_parse() instead.
/// </para>
/// </summary>

/// <param name="display">
/// a #GdkDisplay or %NULL to use the default display
/// </param>
/// <param name="accelerator_key">
/// accelerator keyval
/// </param>
/// <param name="keycode">
/// accelerator keycode
/// </param>
/// <param name="accelerator_mods">
/// accelerator modifier mask
/// </param>
/// <return>
/// a newly allocated accelerator name.
/// </return>

	public static string AcceleratorNameWithKeycode(MentorLake.Gdk.GdkDisplayHandle display, uint accelerator_key, uint keycode, MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_name_with_keycode(display, accelerator_key, keycode, accelerator_mods);
	}

/// <summary>
/// <para>
/// Parses a string representing an accelerator. The format looks like
/// `<Control>a` or `<Shift><Alt>F1` or `<Release>z` (the last one is
/// for key release).
/// </para>
/// <para>
/// The parser is fairly liberal and allows lower or upper case, and also
/// abbreviations such as `<Ctl>` and `<Ctrl>`. Key names are parsed using
/// gdk_keyval_from_name(). For character keys the name is not the symbol,
/// but the lowercase name, e.g. one would use `<Ctrl>minus` instead of
/// `<Ctrl>-`.
/// </para>
/// <para>
/// If the parse fails, @accelerator_key and @accelerator_mods will
/// be set to 0 (zero).
/// </para>
/// </summary>

/// <param name="accelerator">
/// string representing an accelerator
/// </param>
/// <param name="accelerator_key">
/// return location for accelerator
///     keyval, or %NULL
/// </param>
/// <param name="accelerator_mods">
/// return location for accelerator
///     modifier mask, %NULL
/// </param>

	public static void AcceleratorParse(string accelerator, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		GtkGlobalFunctionsExterns.gtk_accelerator_parse(accelerator, out accelerator_key, out accelerator_mods);
	}

/// <summary>
/// <para>
/// Parses a string representing an accelerator, similarly to
/// gtk_accelerator_parse() but handles keycodes as well. This is only
/// useful for system-level components, applications should use
/// gtk_accelerator_parse() instead.
/// </para>
/// <para>
/// If @accelerator_codes is given and the result stored in it is non-%NULL,
/// the result must be freed with g_free().
/// </para>
/// <para>
/// If a keycode is present in the accelerator and no @accelerator_codes
/// is given, the parse will fail.
/// </para>
/// <para>
/// If the parse fails, @accelerator_key, @accelerator_mods and
/// @accelerator_codes will be set to 0 (zero).
/// </para>
/// </summary>

/// <param name="accelerator">
/// string representing an accelerator
/// </param>
/// <param name="accelerator_key">
/// return location for accelerator
///     keyval, or %NULL
/// </param>
/// <param name="accelerator_codes">
/// 
///     return location for accelerator keycodes, or %NULL
/// </param>
/// <param name="accelerator_mods">
/// return location for accelerator
///     modifier mask, %NULL
/// </param>

	public static void AcceleratorParseWithKeycode(string accelerator, out uint accelerator_key, out uint[] accelerator_codes, out MentorLake.Gdk.GdkModifierType accelerator_mods)
	{
		GtkGlobalFunctionsExterns.gtk_accelerator_parse_with_keycode(accelerator, out accelerator_key, out accelerator_codes, out accelerator_mods);
	}

/// <summary>
/// <para>
/// Sets the modifiers that will be considered significant for keyboard
/// accelerators. The default mod mask depends on the GDK backend in use,
/// but will typically include #GDK_CONTROL_MASK | #GDK_SHIFT_MASK |
/// #GDK_MOD1_MASK | #GDK_SUPER_MASK | #GDK_HYPER_MASK | #GDK_META_MASK.
/// In other words, Control, Shift, Alt, Super, Hyper and Meta. Other
/// modifiers will by default be ignored by #GtkAccelGroup.
/// </para>
/// <para>
/// You must include at least the three modifiers Control, Shift
/// and Alt in any value you pass to this function.
/// </para>
/// <para>
/// The default mod mask should be changed on application startup,
/// before using any accelerator groups.
/// </para>
/// </summary>

/// <param name="default_mod_mask">
/// accelerator modifier mask
/// </param>

	public static void AcceleratorSetDefaultModMask(MentorLake.Gdk.GdkModifierType default_mod_mask)
	{
		GtkGlobalFunctionsExterns.gtk_accelerator_set_default_mod_mask(default_mod_mask);
	}

/// <summary>
/// <para>
/// Determines whether a given keyval and modifier mask constitute
/// a valid keyboard accelerator. For example, the #GDK_KEY_a keyval
/// plus #GDK_CONTROL_MASK is valid - this is a “Ctrl+a” accelerator.
/// But, you can't, for instance, use the #GDK_KEY_Control_L keyval
/// as an accelerator.
/// </para>
/// </summary>

/// <param name="keyval">
/// a GDK keyval
/// </param>
/// <param name="modifiers">
/// modifier mask
/// </param>
/// <return>
/// %TRUE if the accelerator is valid
/// </return>

	public static bool AcceleratorValid(uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_accelerator_valid(keyval, modifiers);
	}

/// <summary>
/// <para>
/// Returns %TRUE if dialogs are expected to use an alternative
/// button order on the screen @screen. See
/// gtk_dialog_set_alternative_button_order() for more details
/// about alternative button order.
/// </para>
/// <para>
/// If you need to use this function, you should probably connect
/// to the ::notify:gtk-alternative-button-order signal on the
/// #GtkSettings object associated to @screen, in order to be
/// notified if the button order setting changes.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen, or %NULL to use the default screen
/// </param>
/// <return>
/// Whether the alternative button order should be used
/// </return>

	public static bool AlternativeDialogButtonOrder(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkGlobalFunctionsExterns.gtk_alternative_dialog_button_order(screen);
	}

/// <summary>
/// <para>
/// Parses a signal description from @signal_desc and incorporates
/// it into @binding_set.
/// </para>
/// <para>
/// Signal descriptions may either bind a key combination to
/// one or more signals:
/// |[
///   bind "key" {
///     "signalname" (param, ...)
///     ...
///   }
/// ]|
/// </para>
/// <para>
/// Or they may also unbind a key combination:
/// |[
///   unbind "key"
/// ]|
/// </para>
/// <para>
/// Key combinations must be in a format that can be parsed by
/// gtk_accelerator_parse().
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet
/// </param>
/// <param name="signal_desc">
/// a signal description
/// </param>
/// <return>
/// %G_TOKEN_NONE if the signal was successfully parsed and added,
///     the expected token otherwise
/// </return>

	public static MentorLake.GLib.GTokenType BindingEntryAddSignalFromString(MentorLake.Gtk.GtkBindingSetHandle binding_set, string signal_desc)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_entry_add_signal_from_string(binding_set, signal_desc);
	}

/// <summary>
/// <para>
/// Override or install a new key binding for @keyval with @modifiers on
/// @binding_set.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to add a signal to
/// </param>
/// <param name="keyval">
/// key value
/// </param>
/// <param name="modifiers">
/// key modifier
/// </param>
/// <param name="signal_name">
/// signal name to be bound
/// </param>
/// <param name="binding_args">
/// 
///     list of #GtkBindingArg signal arguments
/// </param>

	public static void BindingEntryAddSignall(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, MentorLake.GLib.GSListHandle binding_args)
	{
		GtkGlobalFunctionsExterns.gtk_binding_entry_add_signall(binding_set, keyval, modifiers, signal_name, binding_args);
	}

/// <summary>
/// <para>
/// Remove a binding previously installed via
/// gtk_binding_entry_add_signal() on @binding_set.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to remove an entry of
/// </param>
/// <param name="keyval">
/// key value of binding to remove
/// </param>
/// <param name="modifiers">
/// key modifier of binding to remove
/// </param>

	public static void BindingEntryRemove(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkGlobalFunctionsExterns.gtk_binding_entry_remove(binding_set, keyval, modifiers);
	}

/// <summary>
/// <para>
/// Install a binding on @binding_set which causes key lookups
/// to be aborted, to prevent bindings from lower priority sets
/// to be activated.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to skip an entry of
/// </param>
/// <param name="keyval">
/// key value of binding to skip
/// </param>
/// <param name="modifiers">
/// key modifier of binding to skip
/// </param>

	public static void BindingEntrySkip(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkGlobalFunctionsExterns.gtk_binding_entry_skip(binding_set, keyval, modifiers);
	}

/// <summary>
/// <para>
/// This function returns the binding set named after the type name of
/// the passed in class structure. New binding sets are created on
/// demand by this function.
/// </para>
/// </summary>

/// <param name="object_class">
/// a valid #GObject class
/// </param>
/// <return>
/// the binding set corresponding to
///     @object_class
/// </return>

	public static MentorLake.Gtk.GtkBindingSetHandle BindingSetByClass(IntPtr object_class)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_set_by_class(object_class);
	}

/// <summary>
/// <para>
/// Find a binding set by its globally unique name.
/// </para>
/// <para>
/// The @set_name can either be a name used for gtk_binding_set_new()
/// or the type name of a class used in gtk_binding_set_by_class().
/// </para>
/// </summary>

/// <param name="set_name">
/// unique binding set name
/// </param>
/// <return>
/// %NULL or the specified binding set
/// </return>

	public static MentorLake.Gtk.GtkBindingSetHandle BindingSetFind(string set_name)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_set_find(set_name);
	}

/// <summary>
/// <para>
/// GTK+ maintains a global list of binding sets. Each binding set has
/// a unique name which needs to be specified upon creation.
/// </para>
/// </summary>

/// <param name="set_name">
/// unique name of this binding set
/// </param>
/// <return>
/// new binding set
/// </return>

	public static MentorLake.Gtk.GtkBindingSetHandle BindingSetNew(string set_name)
	{
		return GtkGlobalFunctionsExterns.gtk_binding_set_new(set_name);
	}

/// <summary>
/// <para>
/// Find a key binding matching @keyval and @modifiers and activate the
/// binding on @object.
/// </para>
/// </summary>

/// <param name="@object">
/// object to activate when binding found
/// </param>
/// <param name="keyval">
/// key value of the binding
/// </param>
/// <param name="modifiers">
/// key modifier of the binding
/// </param>
/// <return>
/// %TRUE if a binding was found and activated
/// </return>

	public static bool BindingsActivate(MentorLake.GObject.GObjectHandle @object, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_bindings_activate(@object, keyval, modifiers);
	}

/// <summary>
/// <para>
/// Looks up key bindings for @object to find one matching
/// @event, and if one was found, activate it.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject (generally must be a widget)
/// </param>
/// <param name="@event">
/// a #GdkEventKey
/// </param>
/// <return>
/// %TRUE if a matching key binding was found
/// </return>

	public static bool BindingsActivateEvent(MentorLake.GObject.GObjectHandle @object, MentorLake.Gdk.GdkEventKeyHandle @event)
	{
		return GtkGlobalFunctionsExterns.gtk_bindings_activate_event(@object, @event);
	}



	public static MentorLake.GLib.GQuark BuilderErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_builder_error_quark();
	}

/// <summary>
/// <para>
/// This function is supposed to be called in #GtkWidget::draw
/// implementations for widgets that support multiple windows.
/// @cr must be untransformed from invoking of the draw function.
/// This function will return %TRUE if the contents of the given
/// @window are supposed to be drawn and %FALSE otherwise. Note
/// that when the drawing was not initiated by the windowing
/// system this function will return %TRUE for all windows, so
/// you need to draw the bottommost window first. Also, do not
/// use “else if” statements to check which window should be drawn.
/// </para>
/// </summary>

/// <param name="cr">
/// a cairo context
/// </param>
/// <param name="window">
/// the window to check. @window may not be an input-only
///          window.
/// </param>
/// <return>
/// %TRUE if @window should be drawn
/// </return>

	public static bool CairoShouldDrawWindow(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkWindowHandle window)
	{
		return GtkGlobalFunctionsExterns.gtk_cairo_should_draw_window(cr, window);
	}

/// <summary>
/// <para>
/// Transforms the given cairo context @cr that from @widget-relative
/// coordinates to @window-relative coordinates.
/// If the @widget’s window is not an ancestor of @window, no
/// modification will be applied.
/// </para>
/// <para>
/// This is the inverse to the transformation GTK applies when
/// preparing an expose event to be emitted with the #GtkWidget::draw
/// signal. It is intended to help porting multiwindow widgets from
/// GTK+ 2 to the rendering architecture of GTK+ 3.
/// </para>
/// </summary>

/// <param name="cr">
/// the cairo context to transform
/// </param>
/// <param name="widget">
/// the widget the context is currently centered for
/// </param>
/// <param name="window">
/// the window to transform the context to
/// </param>

	public static void CairoTransformToWindow(MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkWindowHandle window)
	{
		GtkGlobalFunctionsExterns.gtk_cairo_transform_to_window(cr, widget, window);
	}

/// <summary>
/// <para>
/// Checks that the GTK+ library in use is compatible with the
/// given version. Generally you would pass in the constants
/// #GTK_MAJOR_VERSION, #GTK_MINOR_VERSION, #GTK_MICRO_VERSION
/// as the three arguments to this function; that produces
/// a check that the library in use is compatible with
/// the version of GTK+ the application or module was compiled
/// against.
/// </para>
/// <para>
/// Compatibility is defined by two things: first the version
/// of the running library is newer than the version
/// @required_major.required_minor.@required_micro. Second
/// the running library must be binary compatible with the
/// version @required_major.required_minor.@required_micro
/// (same major version.)
/// </para>
/// <para>
/// This function is primarily for GTK+ modules; the module
/// can call this function to check that it wasn’t loaded
/// into an incompatible version of GTK+. However, such a
/// check isn’t completely reliable, since the module may be
/// linked against an old version of GTK+ and calling the
/// old version of gtk_check_version(), but still get loaded
/// into an application using a newer version of GTK+.
/// </para>
/// </summary>

/// <param name="required_major">
/// the required major version
/// </param>
/// <param name="required_minor">
/// the required minor version
/// </param>
/// <param name="required_micro">
/// the required micro version
/// </param>
/// <return>
/// %NULL if the GTK+ library is compatible with the
///   given version, or a string describing the version mismatch.
///   The returned string is owned by GTK+ and should not be modified
///   or freed.
/// </return>

	public static string CheckVersion(uint required_major, uint required_minor, uint required_micro)
	{
		return GtkGlobalFunctionsExterns.gtk_check_version(required_major, required_minor, required_micro);
	}



	public static MentorLake.GLib.GQuark CssProviderErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_css_provider_error_quark();
	}

/// <summary>
/// <para>
/// Adds a GTK+ grab on @device, so all the events on @device and its
/// associated pointer or keyboard (if any) are delivered to @widget.
/// If the @block_others parameter is %TRUE, any other devices will be
/// unable to interact with @widget during the grab.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice to grab on.
/// </param>
/// <param name="block_others">
/// %TRUE to prevent other devices to interact with @widget.
/// </param>

	public static void DeviceGrabAdd(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device, bool block_others)
	{
		GtkGlobalFunctionsExterns.gtk_device_grab_add(widget, device, block_others);
	}

/// <summary>
/// <para>
/// Removes a device grab from the given widget.
/// </para>
/// <para>
/// You have to pair calls to gtk_device_grab_add() and
/// gtk_device_grab_remove().
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="device">
/// a #GdkDevice
/// </param>

	public static void DeviceGrabRemove(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		GtkGlobalFunctionsExterns.gtk_device_grab_remove(widget, device);
	}

/// <summary>
/// <para>
/// Prevents gtk_init(), gtk_init_check(), gtk_init_with_args() and
/// gtk_parse_args() from automatically
/// calling `setlocale (LC_ALL, "")`. You would
/// want to use this function if you wanted to set the locale for
/// your program to something other than the user’s locale, or if
/// you wanted to set different values for different locale categories.
/// </para>
/// <para>
/// Most programs should not need to call this function.
/// </para>
/// </summary>


	public static void DisableSetlocale()
	{
		GtkGlobalFunctionsExterns.gtk_disable_setlocale();
	}

/// <summary>
/// <para>
/// Distributes @extra_space to child @sizes by bringing smaller
/// children up to natural size first.
/// </para>
/// <para>
/// The remaining space will be added to the @minimum_size member of the
/// GtkRequestedSize struct. If all sizes reach their natural size then
/// the remaining space is returned.
/// </para>
/// </summary>

/// <param name="extra_space">
/// Extra space to redistribute among children after subtracting
///               minimum sizes and any child padding from the overall allocation
/// </param>
/// <param name="n_requested_sizes">
/// Number of requests to fit into the allocation
/// </param>
/// <param name="sizes">
/// An array of structs with a client pointer and a minimum/natural size
///         in the orientation of the allocation.
/// </param>
/// <return>
/// The remainder of @extra_space after redistributing space
/// to @sizes.
/// </return>

	public static int DistributeNaturalAllocation(int extra_space, uint n_requested_sizes, MentorLake.Gtk.GtkRequestedSizeHandle sizes)
	{
		return GtkGlobalFunctionsExterns.gtk_distribute_natural_allocation(extra_space, n_requested_sizes, sizes);
	}

/// <summary>
/// <para>
/// Cancels an ongoing drag operation on the source side.
/// </para>
/// <para>
/// If you want to be able to cancel a drag operation in this way,
/// you need to keep a pointer to the drag context, either from an
/// explicit call to gtk_drag_begin_with_coordinates(), or by
/// connecting to #GtkWidget::drag-begin.
/// </para>
/// <para>
/// If @context does not refer to an ongoing drag operation, this
/// function does nothing.
/// </para>
/// <para>
/// If a drag is cancelled in this way, the @result argument of
/// #GtkWidget::drag-failed is set to @GTK_DRAG_RESULT_ERROR.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkDragContext, as e.g. returned by gtk_drag_begin_with_coordinates()
/// </param>

	public static void DragCancel(MentorLake.Gdk.GdkDragContextHandle context)
	{
		GtkGlobalFunctionsExterns.gtk_drag_cancel(context);
	}

/// <summary>
/// <para>
/// Informs the drag source that the drop is finished, and
/// that the data of the drag will no longer be required.
/// </para>
/// </summary>

/// <param name="context">
/// the drag context
/// </param>
/// <param name="success">
/// a flag indicating whether the drop was successful
/// </param>
/// <param name="del">
/// a flag indicating whether the source should delete the
///   original data. (This should be %TRUE for a move)
/// </param>
/// <param name="time_">
/// the timestamp from the #GtkWidget::drag-drop signal
/// </param>

	public static void DragFinish(MentorLake.Gdk.GdkDragContextHandle context, bool success, bool del, uint time_)
	{
		GtkGlobalFunctionsExterns.gtk_drag_finish(context, success, del, time_);
	}

/// <summary>
/// <para>
/// Determines the source widget for a drag.
/// </para>
/// </summary>

/// <param name="context">
/// a (destination side) drag context
/// </param>
/// <return>
/// if the drag is occurring
///     within a single application, a pointer to the source widget.
///     Otherwise, %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle DragGetSourceWidget(MentorLake.Gdk.GdkDragContextHandle context)
	{
		return GtkGlobalFunctionsExterns.gtk_drag_get_source_widget(context);
	}

/// <summary>
/// <para>
/// Sets the icon for a particular drag to the default
/// icon.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag (This must be called
///     with a  context for the source side of a drag)
/// </param>

	public static void DragSetIconDefault(MentorLake.Gdk.GdkDragContextHandle context)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_default(context);
	}

/// <summary>
/// <para>
/// Sets the icon for a given drag from the given @icon.
/// See the documentation for gtk_drag_set_icon_name()
/// for more details about using icons in drag and drop.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag (This must be called
///     with a context for the source side of a drag)
/// </param>
/// <param name="icon">
/// a #GIcon
/// </param>
/// <param name="hot_x">
/// the X offset of the hotspot within the icon
/// </param>
/// <param name="hot_y">
/// the Y offset of the hotspot within the icon
/// </param>

	public static void DragSetIconGicon(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gio.GIconHandle icon, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_gicon(context, icon, hot_x, hot_y);
	}

/// <summary>
/// <para>
/// Sets the icon for a given drag from a named themed icon. See
/// the docs for #GtkIconTheme for more details. Note that the
/// size of the icon depends on the icon theme (the icon is
/// loaded at the symbolic size #GTK_ICON_SIZE_DND), thus
/// @hot_x and @hot_y have to be used with care.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag (This must be called
///     with a context for the source side of a drag)
/// </param>
/// <param name="icon_name">
/// name of icon to use
/// </param>
/// <param name="hot_x">
/// the X offset of the hotspot within the icon
/// </param>
/// <param name="hot_y">
/// the Y offset of the hotspot within the icon
/// </param>

	public static void DragSetIconName(MentorLake.Gdk.GdkDragContextHandle context, string icon_name, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_name(context, icon_name, hot_x, hot_y);
	}

/// <summary>
/// <para>
/// Sets @pixbuf as the icon for a given drag.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag (This must be called
///            with a  context for the source side of a drag)
/// </param>
/// <param name="pixbuf">
/// the #GdkPixbuf to use as the drag icon
/// </param>
/// <param name="hot_x">
/// the X offset within @widget of the hotspot
/// </param>
/// <param name="hot_y">
/// the Y offset within @widget of the hotspot
/// </param>

	public static void DragSetIconPixbuf(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_pixbuf(context, pixbuf, hot_x, hot_y);
	}

/// <summary>
/// <para>
/// Sets the icon for a given drag from a stock ID.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag (This must be called
///            with a  context for the source side of a drag)
/// </param>
/// <param name="stock_id">
/// the ID of the stock icon to use for the drag
/// </param>
/// <param name="hot_x">
/// the X offset within the icon of the hotspot
/// </param>
/// <param name="hot_y">
/// the Y offset within the icon of the hotspot
/// </param>

	public static void DragSetIconStock(MentorLake.Gdk.GdkDragContextHandle context, string stock_id, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_stock(context, stock_id, hot_x, hot_y);
	}

/// <summary>
/// <para>
/// Sets @surface as the icon for a given drag. GTK+ retains
/// references for the arguments, and will release them when
/// they are no longer needed.
/// </para>
/// <para>
/// To position the surface relative to the mouse, use
/// cairo_surface_set_device_offset() on @surface. The mouse
/// cursor will be positioned at the (0,0) coordinate of the
/// surface.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag (This must be called
///     with a context for the source side of a drag)
/// </param>
/// <param name="surface">
/// the surface to use as icon
/// </param>

	public static void DragSetIconSurface(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.cairo.cairo_surface_tHandle surface)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_surface(context, surface);
	}

/// <summary>
/// <para>
/// Changes the icon for drag operation to a given widget.
/// GTK+ will not destroy the widget, so if you don’t want
/// it to persist, you should connect to the “drag-end”
/// signal and destroy it yourself.
/// </para>
/// </summary>

/// <param name="context">
/// the context for a drag. (This must be called
///           with a context for the source side of a drag)
/// </param>
/// <param name="widget">
/// a widget to use as an icon
/// </param>
/// <param name="hot_x">
/// the X offset within @widget of the hotspot
/// </param>
/// <param name="hot_y">
/// the Y offset within @widget of the hotspot
/// </param>

	public static void DragSetIconWidget(MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gtk.GtkWidgetHandle widget, int hot_x, int hot_y)
	{
		GtkGlobalFunctionsExterns.gtk_drag_set_icon_widget(context, widget, hot_x, hot_y);
	}

/// <summary>
/// <para>
/// Draws a text caret on @cr at @location. This is not a style function
/// but merely a convenience function for drawing the standard cursor shape.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="cr">
/// cairo context to draw to
/// </param>
/// <param name="location">
/// location where to draw the cursor (@location->width is ignored)
/// </param>
/// <param name="is_primary">
/// if the cursor should be the primary cursor color.
/// </param>
/// <param name="direction">
/// whether the cursor is left-to-right or
///             right-to-left. Should never be #GTK_TEXT_DIR_NONE
/// </param>
/// <param name="draw_arrow">
/// %TRUE to draw a directional arrow on the
///        cursor. Should be %FALSE unless the cursor is split.
/// </param>

	public static void DrawInsertionCursor(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gdk.GdkRectangleHandle location, bool is_primary, MentorLake.Gtk.GtkTextDirection direction, bool draw_arrow)
	{
		GtkGlobalFunctionsExterns.gtk_draw_insertion_cursor(widget, cr, location, is_primary, direction, draw_arrow);
	}

/// <summary>
/// <para>
/// Checks if any events are pending.
/// </para>
/// <para>
/// This can be used to update the UI and invoke timeouts etc.
/// while doing some time intensive computation.
/// </para>
/// <para>
/// ## Updating the UI during a long computation
/// </para>
/// <para>
/// |[<!-- language="C" -->
///  // computation going on...
/// </para>
/// <para>
///  while (gtk_events_pending ())
///    gtk_main_iteration ();
/// </para>
/// <para>
///  // ...computation continued
/// ]|
/// </para>
/// </summary>

/// <return>
/// %TRUE if any events are pending, %FALSE otherwise
/// </return>

	public static bool EventsPending()
	{
		return GtkGlobalFunctionsExterns.gtk_events_pending();
	}

/// <summary>
/// <para>
/// Analogical to gtk_true(), this function does nothing
/// but always returns %FALSE.
/// </para>
/// </summary>

/// <return>
/// %FALSE
/// </return>

	public static bool False()
	{
		return GtkGlobalFunctionsExterns.gtk_false();
	}

/// <summary>
/// <para>
/// Registers an error quark for #GtkFileChooser if necessary.
/// </para>
/// </summary>

/// <return>
/// The error quark used for #GtkFileChooser errors.
/// </return>

	public static MentorLake.GLib.GQuark FileChooserErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_file_chooser_error_quark();
	}

/// <summary>
/// <para>
/// Returns the binary age as passed to `libtool`
/// when building the GTK+ library the process is running against.
/// If `libtool` means nothing to you, don't
/// worry about it.
/// </para>
/// </summary>

/// <return>
/// the binary age of the GTK+ library
/// </return>

	public static uint GetBinaryAge()
	{
		return GtkGlobalFunctionsExterns.gtk_get_binary_age();
	}

/// <summary>
/// <para>
/// Obtains a copy of the event currently being processed by GTK+.
/// </para>
/// <para>
/// For example, if you are handling a #GtkButton::clicked signal,
/// the current event will be the #GdkEventButton that triggered
/// the ::clicked signal.
/// </para>
/// </summary>

/// <return>
/// a copy of the current event, or
///     %NULL if there is no current event. The returned event must be
///     freed with gdk_event_free().
/// </return>

	public static MentorLake.Gdk.GdkEventHandle GetCurrentEvent()
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event();
	}

/// <summary>
/// <para>
/// If there is a current event and it has a device, return that
/// device, otherwise return %NULL.
/// </para>
/// </summary>

/// <return>
/// a #GdkDevice, or %NULL
/// </return>

	public static MentorLake.Gdk.GdkDeviceHandle GetCurrentEventDevice()
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event_device();
	}

/// <summary>
/// <para>
/// If there is a current event and it has a state field, place
/// that state field in @state and return %TRUE, otherwise return
/// %FALSE.
/// </para>
/// </summary>

/// <param name="state">
/// a location to store the state of the current event
/// </param>
/// <return>
/// %TRUE if there was a current event and it
///     had a state field
/// </return>

	public static bool GetCurrentEventState(out MentorLake.Gdk.GdkModifierType state)
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event_state(out state);
	}

/// <summary>
/// <para>
/// If there is a current event and it has a timestamp,
/// return that timestamp, otherwise return %GDK_CURRENT_TIME.
/// </para>
/// </summary>

/// <return>
/// the timestamp from the current event,
///     or %GDK_CURRENT_TIME.
/// </return>

	public static uint GetCurrentEventTime()
	{
		return GtkGlobalFunctionsExterns.gtk_get_current_event_time();
	}

/// <summary>
/// <para>
/// Returns the GTK+ debug flags.
/// </para>
/// <para>
/// This function is intended for GTK+ modules that want
/// to adjust their debug output based on GTK+ debug flags.
/// </para>
/// </summary>

/// <return>
/// the GTK+ debug flags.
/// </return>

	public static uint GetDebugFlags()
	{
		return GtkGlobalFunctionsExterns.gtk_get_debug_flags();
	}

/// <summary>
/// <para>
/// Returns the #PangoLanguage for the default language currently in
/// effect. (Note that this can change over the life of an
/// application.) The default language is derived from the current
/// locale. It determines, for example, whether GTK+ uses the
/// right-to-left or left-to-right text direction.
/// </para>
/// <para>
/// This function is equivalent to pango_language_get_default().
/// See that function for details.
/// </para>
/// </summary>

/// <return>
/// the default language as a #PangoLanguage,
///     must not be freed
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle GetDefaultLanguage()
	{
		return GtkGlobalFunctionsExterns.gtk_get_default_language();
	}

/// <summary>
/// <para>
/// If @event is %NULL or the event was not associated with any widget,
/// returns %NULL, otherwise returns the widget that received the event
/// originally.
/// </para>
/// </summary>

/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// the widget that originally
///     received @event, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetEventWidget(MentorLake.Gdk.GdkEventHandle @event)
	{
		return GtkGlobalFunctionsExterns.gtk_get_event_widget(@event);
	}

/// <summary>
/// <para>
/// Returns the interface age as passed to `libtool`
/// when building the GTK+ library the process is running against.
/// If `libtool` means nothing to you, don't
/// worry about it.
/// </para>
/// </summary>

/// <return>
/// the interface age of the GTK+ library
/// </return>

	public static uint GetInterfaceAge()
	{
		return GtkGlobalFunctionsExterns.gtk_get_interface_age();
	}

/// <summary>
/// <para>
/// Get the direction of the current locale. This is the expected
/// reading direction for text and UI.
/// </para>
/// <para>
/// This function depends on the current locale being set with
/// setlocale() and will default to setting the %GTK_TEXT_DIR_LTR
/// direction otherwise. %GTK_TEXT_DIR_NONE will never be returned.
/// </para>
/// <para>
/// GTK+ sets the default text direction according to the locale
/// during gtk_init(), and you should normally use
/// gtk_widget_get_direction() or gtk_widget_get_default_direction()
/// to obtain the current direcion.
/// </para>
/// <para>
/// This function is only needed rare cases when the locale is
/// changed after GTK+ has already been initialized. In this case,
/// you can use it to update the default text direction as follows:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// setlocale (LC_ALL, new_locale);
/// direction = gtk_get_locale_direction ();
/// gtk_widget_set_default_direction (direction);
/// ]|
/// </para>
/// </summary>

/// <return>
/// the #GtkTextDirection of the current locale
/// </return>

	public static MentorLake.Gtk.GtkTextDirection GetLocaleDirection()
	{
		return GtkGlobalFunctionsExterns.gtk_get_locale_direction();
	}

/// <summary>
/// <para>
/// Returns the major version number of the GTK+ library.
/// (e.g. in GTK+ version 3.1.5 this is 3.)
/// </para>
/// <para>
/// This function is in the library, so it represents the GTK+ library
/// your code is running against. Contrast with the #GTK_MAJOR_VERSION
/// macro, which represents the major version of the GTK+ headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the major version number of the GTK+ library
/// </return>

	public static uint GetMajorVersion()
	{
		return GtkGlobalFunctionsExterns.gtk_get_major_version();
	}

/// <summary>
/// <para>
/// Returns the micro version number of the GTK+ library.
/// (e.g. in GTK+ version 3.1.5 this is 5.)
/// </para>
/// <para>
/// This function is in the library, so it represents the GTK+ library
/// your code is are running against. Contrast with the
/// #GTK_MICRO_VERSION macro, which represents the micro version of the
/// GTK+ headers you have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the micro version number of the GTK+ library
/// </return>

	public static uint GetMicroVersion()
	{
		return GtkGlobalFunctionsExterns.gtk_get_micro_version();
	}

/// <summary>
/// <para>
/// Returns the minor version number of the GTK+ library.
/// (e.g. in GTK+ version 3.1.5 this is 1.)
/// </para>
/// <para>
/// This function is in the library, so it represents the GTK+ library
/// your code is are running against. Contrast with the
/// #GTK_MINOR_VERSION macro, which represents the minor version of the
/// GTK+ headers you have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the minor version number of the GTK+ library
/// </return>

	public static uint GetMinorVersion()
	{
		return GtkGlobalFunctionsExterns.gtk_get_minor_version();
	}

/// <summary>
/// <para>
/// Returns a #GOptionGroup for the commandline arguments recognized
/// by GTK+ and GDK.
/// </para>
/// <para>
/// You should add this group to your #GOptionContext
/// with g_option_context_add_group(), if you are using
/// g_option_context_parse() to parse your commandline arguments.
/// </para>
/// </summary>

/// <param name="open_default_display">
/// whether to open the default display
///     when parsing the commandline arguments
/// </param>
/// <return>
/// a #GOptionGroup for the commandline
///     arguments recognized by GTK+
/// </return>

	public static MentorLake.GLib.GOptionGroupHandle GetOptionGroup(bool open_default_display)
	{
		return GtkGlobalFunctionsExterns.gtk_get_option_group(open_default_display);
	}

/// <summary>
/// <para>
/// Queries the current grab of the default window group.
/// </para>
/// </summary>

/// <return>
/// The widget which currently
///     has the grab or %NULL if no grab is active
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GrabGetCurrent()
	{
		return GtkGlobalFunctionsExterns.gtk_grab_get_current();
	}

/// <summary>
/// <para>
/// Looks up the icon size associated with @name.
/// </para>
/// </summary>

/// <param name="name">
/// the name to look up.
/// </param>
/// <return>
/// the icon size (#GtkIconSize)
/// </return>

	public static MentorLake.Gtk.GtkIconSize IconSizeFromName(string name)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_from_name(name);
	}

/// <summary>
/// <para>
/// Gets the canonical name of the given icon size. The returned string
/// is statically allocated and should not be freed.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkIconSize.
/// </param>
/// <return>
/// the name of the given icon size.
/// </return>

	public static string IconSizeGetName(MentorLake.Gtk.GtkIconSize size)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_get_name(size);
	}

/// <summary>
/// <para>
/// Obtains the pixel size of a semantic icon size @size:
/// #GTK_ICON_SIZE_MENU, #GTK_ICON_SIZE_BUTTON, etc.  This function
/// isn’t normally needed, gtk_icon_theme_load_icon() is the usual
/// way to get an icon for rendering, then just look at the size of
/// the rendered pixbuf. The rendered pixbuf may not even correspond to
/// the width/height returned by gtk_icon_size_lookup(), because themes
/// are free to render the pixbuf however they like, including changing
/// the usual size.
/// </para>
/// </summary>

/// <param name="size">
/// an icon size (#GtkIconSize)
/// </param>
/// <param name="width">
/// location to store icon width
/// </param>
/// <param name="height">
/// location to store icon height
/// </param>
/// <return>
/// %TRUE if @size was a valid size
/// </return>

	public static bool IconSizeLookup(MentorLake.Gtk.GtkIconSize size, out int width, out int height)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_lookup(size, out width, out height);
	}

/// <summary>
/// <para>
/// Obtains the pixel size of a semantic icon size, possibly
/// modified by user preferences for a particular
/// #GtkSettings. Normally @size would be
/// #GTK_ICON_SIZE_MENU, #GTK_ICON_SIZE_BUTTON, etc.  This function
/// isn’t normally needed, gtk_widget_render_icon_pixbuf() is the usual
/// way to get an icon for rendering, then just look at the size of
/// the rendered pixbuf. The rendered pixbuf may not even correspond to
/// the width/height returned by gtk_icon_size_lookup(), because themes
/// are free to render the pixbuf however they like, including changing
/// the usual size.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkSettings object, used to determine
///   which set of user preferences to used.
/// </param>
/// <param name="size">
/// an icon size (#GtkIconSize)
/// </param>
/// <param name="width">
/// location to store icon width
/// </param>
/// <param name="height">
/// location to store icon height
/// </param>
/// <return>
/// %TRUE if @size was a valid size
/// </return>

	public static bool IconSizeLookupForSettings(MentorLake.Gtk.GtkSettingsHandle settings, MentorLake.Gtk.GtkIconSize size, out int width, out int height)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_lookup_for_settings(settings, size, out width, out height);
	}

/// <summary>
/// <para>
/// Registers a new icon size, along the same lines as #GTK_ICON_SIZE_MENU,
/// etc. Returns the integer value for the size.
/// </para>
/// </summary>

/// <param name="name">
/// name of the icon size
/// </param>
/// <param name="width">
/// the icon width
/// </param>
/// <param name="height">
/// the icon height
/// </param>
/// <return>
/// integer value representing the size (#GtkIconSize)
/// </return>

	public static MentorLake.Gtk.GtkIconSize IconSizeRegister(string name, int width, int height)
	{
		return GtkGlobalFunctionsExterns.gtk_icon_size_register(name, width, height);
	}

/// <summary>
/// <para>
/// Registers @alias as another name for @target.
/// So calling gtk_icon_size_from_name() with @alias as argument
/// will return @target.
/// </para>
/// </summary>

/// <param name="alias">
/// an alias for @target
/// </param>
/// <param name="target">
/// an existing icon size (#GtkIconSize)
/// </param>

	public static void IconSizeRegisterAlias(string alias, MentorLake.Gtk.GtkIconSize target)
	{
		GtkGlobalFunctionsExterns.gtk_icon_size_register_alias(alias, target);
	}



	public static MentorLake.GLib.GQuark IconThemeErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_icon_theme_error_quark();
	}

/// <summary>
/// <para>
/// Call this function before using any other GTK+ functions in your GUI
/// applications.  It will initialize everything needed to operate the
/// toolkit and parses some standard command line options.
/// </para>
/// <para>
/// Although you are expected to pass the @argc, @argv parameters from main() to
/// this function, it is possible to pass %NULL if @argv is not available or
/// commandline handling is not required.
/// </para>
/// <para>
/// @argc and @argv are adjusted accordingly so your own code will
/// never see those standard arguments.
/// </para>
/// <para>
/// Note that there are some alternative ways to initialize GTK+:
/// if you are calling gtk_parse_args(), gtk_init_check(),
/// gtk_init_with_args() or g_option_context_parse() with
/// the option group returned by gtk_get_option_group(),
/// you don’t have to call gtk_init().
/// </para>
/// <para>
/// And if you are using #GtkApplication, you don't have to call any of the
/// initialization functions either; the #GtkApplication::startup handler
/// does it for you.
/// </para>
/// <para>
/// This function will terminate your program if it was unable to
/// initialize the windowing system for some reason. If you want
/// your program to fall back to a textual interface you want to
/// call gtk_init_check() instead.
/// </para>
/// <para>
/// Since 2.18, GTK+ calls `signal (SIGPIPE, SIG_IGN)`
/// during initialization, to ignore SIGPIPE signals, since these are
/// almost never wanted in graphical applications. If you do need to
/// handle SIGPIPE for some reason, reset the handler after gtk_init(),
/// but notice that other libraries (e.g. libdbus or gvfs) might do
/// similar things.
/// </para>
/// </summary>

/// <param name="argc">
/// Address of the `argc` parameter of
///     your main() function (or 0 if @argv is %NULL). This will be changed if
///     any arguments were handled.
/// </param>
/// <param name="argv">
/// Address of the
///     `argv` parameter of main(), or %NULL. Any options
///     understood by GTK+ are stripped before return.
/// </param>

	public static void Init(ref int argc, ref string[] argv)
	{
		GtkGlobalFunctionsExterns.gtk_init(ref argc, ref argv);
	}

/// <summary>
/// <para>
/// This function does the same work as gtk_init() with only a single
/// change: It does not terminate the program if the commandline
/// arguments couldn’t be parsed or the windowing system can’t be
/// initialized. Instead it returns %FALSE on failure.
/// </para>
/// <para>
/// This way the application can fall back to some other means of
/// communication with the user - for example a curses or command line
/// interface.
/// </para>
/// <para>
/// Note that calling any GTK function or instantiating any GTK type after
/// this function returns %FALSE results in undefined behavior.
/// </para>
/// </summary>

/// <param name="argc">
/// Address of the `argc` parameter of
///     your main() function (or 0 if @argv is %NULL). This will be changed if
///     any arguments were handled.
/// </param>
/// <param name="argv">
/// Address of the
///     `argv` parameter of main(), or %NULL. Any options
///     understood by GTK+ are stripped before return.
/// </param>
/// <return>
/// %TRUE if the commandline arguments (if any) were valid and
///     the windowing system has been successfully initialized, %FALSE
///     otherwise
/// </return>

	public static bool InitCheck(ref int argc, ref string[] argv)
	{
		return GtkGlobalFunctionsExterns.gtk_init_check(ref argc, ref argv);
	}

/// <summary>
/// <para>
/// This function does the same work as gtk_init_check().
/// Additionally, it allows you to add your own commandline options,
/// and it automatically generates nicely formatted
/// `--help` output. Note that your program will
/// be terminated after writing out the help output.
/// </para>
/// </summary>

/// <param name="argc">
/// Address of the `argc` parameter of
///     your main() function (or 0 if @argv is %NULL). This will be changed if
///     any arguments were handled.
/// </param>
/// <param name="argv">
/// Address of the
///     `argv` parameter of main(), or %NULL. Any options
///     understood by GTK+ are stripped before return.
/// </param>
/// <param name="parameter_string">
/// a string which is displayed in
///    the first line of `--help` output, after
///    `programname [OPTION...]`
/// </param>
/// <param name="entries">
/// a %NULL-terminated array
///    of #GOptionEntrys describing the options of your program
/// </param>
/// <param name="translation_domain">
/// a translation domain to use for translating
///    the `--help` output for the options in @entries
///    and the @parameter_string with gettext(), or %NULL
/// </param>
/// <return>
/// %TRUE if the commandline arguments (if any) were valid and
///     if the windowing system has been successfully initialized,
///     %FALSE otherwise
/// </return>

	public static bool InitWithArgs(ref int argc, ref string[] argv, string parameter_string, MentorLake.GLib.GOptionEntry[] entries, string translation_domain)
	{
		var externCallResult = GtkGlobalFunctionsExterns.gtk_init_with_args(ref argc, ref argv, parameter_string, entries, translation_domain, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Installs a key snooper function, which will get called on all
/// key events before delivering them normally.
/// </para>
/// </summary>

/// <param name="snooper">
/// a #GtkKeySnoopFunc
/// </param>
/// <param name="func_data">
/// data to pass to @snooper
/// </param>
/// <return>
/// a unique id for this key snooper for use with
///    gtk_key_snooper_remove().
/// </return>

	public static uint KeySnooperInstall(MentorLake.Gtk.GtkKeySnoopFunc snooper, IntPtr func_data)
	{
		return GtkGlobalFunctionsExterns.gtk_key_snooper_install(snooper, func_data);
	}

/// <summary>
/// <para>
/// Removes the key snooper function with the given id.
/// </para>
/// </summary>

/// <param name="snooper_handler_id">
/// Identifies the key snooper to remove
/// </param>

	public static void KeySnooperRemove(uint snooper_handler_id)
	{
		GtkGlobalFunctionsExterns.gtk_key_snooper_remove(snooper_handler_id);
	}

/// <summary>
/// <para>
/// Runs the main loop until gtk_main_quit() is called.
/// </para>
/// <para>
/// You can nest calls to gtk_main(). In that case gtk_main_quit()
/// will make the innermost invocation of the main loop return.
/// </para>
/// </summary>


	public static void Main()
	{
		GtkGlobalFunctionsExterns.gtk_main();
	}

/// <summary>
/// <para>
/// Processes a single GDK event.
/// </para>
/// <para>
/// This is public only to allow filtering of events between GDK and GTK+.
/// You will not usually need to call this function directly.
/// </para>
/// <para>
/// While you should not call this function directly, you might want to
/// know how exactly events are handled. So here is what this function
/// does with the event:
/// </para>
/// <para>
/// 1. Compress enter/leave notify events. If the event passed build an
///    enter/leave pair together with the next event (peeked from GDK), both
///    events are thrown away. This is to avoid a backlog of (de-)highlighting
///    widgets crossed by the pointer.
/// </para>
/// <para>
/// 2. Find the widget which got the event. If the widget can’t be determined
///    the event is thrown away unless it belongs to a INCR transaction.
/// </para>
/// <para>
/// 3. Then the event is pushed onto a stack so you can query the currently
///    handled event with gtk_get_current_event().
/// </para>
/// <para>
/// 4. The event is sent to a widget. If a grab is active all events for widgets
///    that are not in the contained in the grab widget are sent to the latter
///    with a few exceptions:
///    - Deletion and destruction events are still sent to the event widget for
///      obvious reasons.
///    - Events which directly relate to the visual representation of the event
///      widget.
///    - Leave events are delivered to the event widget if there was an enter
///      event delivered to it before without the paired leave event.
///    - Drag events are not redirected because it is unclear what the semantics
///      of that would be.
///    Another point of interest might be that all key events are first passed
///    through the key snooper functions if there are any. Read the description
///    of gtk_key_snooper_install() if you need this feature.
/// </para>
/// <para>
/// 5. After finishing the delivery the event is popped from the event stack.
/// </para>
/// </summary>

/// <param name="@event">
/// An event to process (normally passed by GDK)
/// </param>

	public static void MainDoEvent(MentorLake.Gdk.GdkEventHandle @event)
	{
		GtkGlobalFunctionsExterns.gtk_main_do_event(@event);
	}

/// <summary>
/// <para>
/// Runs a single iteration of the mainloop.
/// </para>
/// <para>
/// If no events are waiting to be processed GTK+ will block
/// until the next event is noticed. If you don’t want to block
/// look at gtk_main_iteration_do() or check if any events are
/// pending with gtk_events_pending() first.
/// </para>
/// </summary>

/// <return>
/// %TRUE if gtk_main_quit() has been called for the
///     innermost mainloop
/// </return>

	public static bool MainIteration()
	{
		return GtkGlobalFunctionsExterns.gtk_main_iteration();
	}

/// <summary>
/// <para>
/// Runs a single iteration of the mainloop.
/// If no events are available either return or block depending on
/// the value of @blocking.
/// </para>
/// </summary>

/// <param name="blocking">
/// %TRUE if you want GTK+ to block if no events are pending
/// </param>
/// <return>
/// %TRUE if gtk_main_quit() has been called for the
///     innermost mainloop
/// </return>

	public static bool MainIterationDo(bool blocking)
	{
		return GtkGlobalFunctionsExterns.gtk_main_iteration_do(blocking);
	}

/// <summary>
/// <para>
/// Asks for the current nesting level of the main loop.
/// </para>
/// </summary>

/// <return>
/// the nesting level of the current invocation
///     of the main loop
/// </return>

	public static uint MainLevel()
	{
		return GtkGlobalFunctionsExterns.gtk_main_level();
	}

/// <summary>
/// <para>
/// Makes the innermost invocation of the main loop return
/// when it regains control.
/// </para>
/// </summary>


	public static void MainQuit()
	{
		GtkGlobalFunctionsExterns.gtk_main_quit();
	}

/// <summary>
/// <para>
/// Draws an arrow in the given rectangle on @cr using the given
/// parameters. @arrow_type determines the direction of the arrow.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="arrow_type">
/// the type of arrow to draw
/// </param>
/// <param name="fill">
/// %TRUE if the arrow tip should be filled
/// </param>
/// <param name="x">
/// x origin of the rectangle to draw the arrow in
/// </param>
/// <param name="y">
/// y origin of the rectangle to draw the arrow in
/// </param>
/// <param name="width">
/// width of the rectangle to draw the arrow in
/// </param>
/// <param name="height">
/// height of the rectangle to draw the arrow in
/// </param>

	public static void PaintArrow(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, MentorLake.Gtk.GtkArrowType arrow_type, bool fill, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_arrow(style, cr, state_type, shadow_type, widget, detail, arrow_type, fill, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a box on @cr with the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the box
/// </param>
/// <param name="y">
/// y origin of the box
/// </param>
/// <param name="width">
/// the width of the box
/// </param>
/// <param name="height">
/// the height of the box
/// </param>

	public static void PaintBox(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_box(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a box in @cr using the given style and state and shadow type,
/// leaving a gap in one side.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle
/// </param>
/// <param name="y">
/// y origin of the rectangle
/// </param>
/// <param name="width">
/// width of the rectangle
/// </param>
/// <param name="height">
/// width of the rectangle
/// </param>
/// <param name="gap_side">
/// side in which to leave the gap
/// </param>
/// <param name="gap_x">
/// starting position of the gap
/// </param>
/// <param name="gap_width">
/// width of the gap
/// </param>

	public static void PaintBoxGap(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side, int gap_x, int gap_width)
	{
		GtkGlobalFunctionsExterns.gtk_paint_box_gap(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side, gap_x, gap_width);
	}

/// <summary>
/// <para>
/// Draws a check button indicator in the given rectangle on @cr with
/// the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle to draw the check in
/// </param>
/// <param name="y">
/// y origin of the rectangle to draw the check in
/// </param>
/// <param name="width">
/// the width of the rectangle to draw the check in
/// </param>
/// <param name="height">
/// the height of the rectangle to draw the check in
/// </param>

	public static void PaintCheck(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_check(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a diamond in the given rectangle on @window using the given
/// parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle to draw the diamond in
/// </param>
/// <param name="y">
/// y origin of the rectangle to draw the diamond in
/// </param>
/// <param name="width">
/// width of the rectangle to draw the diamond in
/// </param>
/// <param name="height">
/// height of the rectangle to draw the diamond in
/// </param>

	public static void PaintDiamond(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_diamond(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws an expander as used in #GtkTreeView. @x and @y specify the
/// center the expander. The size of the expander is determined by the
/// “expander-size” style property of @widget.  (If widget is not
/// specified or doesn’t have an “expander-size” property, an
/// unspecified default size will be used, since the caller doesn't
/// have sufficient information to position the expander, this is
/// likely not useful.) The expander is expander_size pixels tall
/// in the collapsed position and expander_size pixels wide in the
/// expanded position.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// the x position to draw the expander at
/// </param>
/// <param name="y">
/// the y position to draw the expander at
/// </param>
/// <param name="expander_style">
/// the style to draw the expander in; determines
///   whether the expander is collapsed, expanded, or in an
///   intermediate state.
/// </param>

	public static void PaintExpander(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, MentorLake.Gtk.GtkExpanderStyle expander_style)
	{
		GtkGlobalFunctionsExterns.gtk_paint_expander(style, cr, state_type, widget, detail, x, y, expander_style);
	}

/// <summary>
/// <para>
/// Draws an extension, i.e. a notebook tab.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the extension
/// </param>
/// <param name="y">
/// y origin of the extension
/// </param>
/// <param name="width">
/// width of the extension
/// </param>
/// <param name="height">
/// width of the extension
/// </param>
/// <param name="gap_side">
/// the side on to which the extension is attached
/// </param>

	public static void PaintExtension(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side)
	{
		GtkGlobalFunctionsExterns.gtk_paint_extension(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side);
	}

/// <summary>
/// <para>
/// Draws a flat box on @cr with the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the box
/// </param>
/// <param name="y">
/// y origin of the box
/// </param>
/// <param name="width">
/// the width of the box
/// </param>
/// <param name="height">
/// the height of the box
/// </param>

	public static void PaintFlatBox(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_flat_box(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a focus indicator around the given rectangle on @cr using the
/// given style.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// the x origin of the rectangle around which to draw a focus indicator
/// </param>
/// <param name="y">
/// the y origin of the rectangle around which to draw a focus indicator
/// </param>
/// <param name="width">
/// the width of the rectangle around which to draw a focus indicator
/// </param>
/// <param name="height">
/// the height of the rectangle around which to draw a focus indicator
/// </param>

	public static void PaintFocus(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_focus(style, cr, state_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a handle as used in #GtkHandleBox and #GtkPaned.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the handle
/// </param>
/// <param name="y">
/// y origin of the handle
/// </param>
/// <param name="width">
/// with of the handle
/// </param>
/// <param name="height">
/// height of the handle
/// </param>
/// <param name="orientation">
/// the orientation of the handle
/// </param>

	public static void PaintHandle(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkOrientation orientation)
	{
		GtkGlobalFunctionsExterns.gtk_paint_handle(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, orientation);
	}

/// <summary>
/// <para>
/// Draws a horizontal line from (@x1, @y) to (@x2, @y) in @cr
/// using the given style and state.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #caio_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x1">
/// the starting x coordinate
/// </param>
/// <param name="x2">
/// the ending x coordinate
/// </param>
/// <param name="y">
/// the y coordinate
/// </param>

	public static void PaintHline(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x1, int x2, int y)
	{
		GtkGlobalFunctionsExterns.gtk_paint_hline(style, cr, state_type, widget, detail, x1, x2, y);
	}

/// <summary>
/// <para>
/// Draws a layout on @cr using the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="use_text">
/// whether to use the text or foreground
///            graphics context of @style
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin
/// </param>
/// <param name="y">
/// y origin
/// </param>
/// <param name="layout">
/// the layout to draw
/// </param>

	public static void PaintLayout(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, bool use_text, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, MentorLake.Pango.PangoLayoutHandle layout)
	{
		GtkGlobalFunctionsExterns.gtk_paint_layout(style, cr, state_type, use_text, widget, detail, x, y, layout);
	}

/// <summary>
/// <para>
/// Draws a radio button indicator in the given rectangle on @cr with
/// the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle to draw the option in
/// </param>
/// <param name="y">
/// y origin of the rectangle to draw the option in
/// </param>
/// <param name="width">
/// the width of the rectangle to draw the option in
/// </param>
/// <param name="height">
/// the height of the rectangle to draw the option in
/// </param>

	public static void PaintOption(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_option(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a resize grip in the given rectangle on @cr using the given
/// parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="edge">
/// the edge in which to draw the resize grip
/// </param>
/// <param name="x">
/// the x origin of the rectangle in which to draw the resize grip
/// </param>
/// <param name="y">
/// the y origin of the rectangle in which to draw the resize grip
/// </param>
/// <param name="width">
/// the width of the rectangle in which to draw the resize grip
/// </param>
/// <param name="height">
/// the height of the rectangle in which to draw the resize grip
/// </param>

	public static void PaintResizeGrip(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, MentorLake.Gdk.GdkWindowEdge edge, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_resize_grip(style, cr, state_type, widget, detail, edge, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a shadow around the given rectangle in @cr
/// using the given style and state and shadow type.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle
/// </param>
/// <param name="y">
/// y origin of the rectangle
/// </param>
/// <param name="width">
/// width of the rectangle
/// </param>
/// <param name="height">
/// width of the rectangle
/// </param>

	public static void PaintShadow(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_shadow(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a shadow around the given rectangle in @cr
/// using the given style and state and shadow type, leaving a
/// gap in one side.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle
/// </param>
/// <param name="y">
/// y origin of the rectangle
/// </param>
/// <param name="width">
/// width of the rectangle
/// </param>
/// <param name="height">
/// width of the rectangle
/// </param>
/// <param name="gap_side">
/// side in which to leave the gap
/// </param>
/// <param name="gap_x">
/// starting position of the gap
/// </param>
/// <param name="gap_width">
/// width of the gap
/// </param>

	public static void PaintShadowGap(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkPositionType gap_side, int gap_x, int gap_width)
	{
		GtkGlobalFunctionsExterns.gtk_paint_shadow_gap(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, gap_side, gap_x, gap_width);
	}

/// <summary>
/// <para>
/// Draws a slider in the given rectangle on @cr using the
/// given style and orientation.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// a shadow
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// the x origin of the rectangle in which to draw a slider
/// </param>
/// <param name="y">
/// the y origin of the rectangle in which to draw a slider
/// </param>
/// <param name="width">
/// the width of the rectangle in which to draw a slider
/// </param>
/// <param name="height">
/// the height of the rectangle in which to draw a slider
/// </param>
/// <param name="orientation">
/// the orientation to be used
/// </param>

	public static void PaintSlider(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height, MentorLake.Gtk.GtkOrientation orientation)
	{
		GtkGlobalFunctionsExterns.gtk_paint_slider(style, cr, state_type, shadow_type, widget, detail, x, y, width, height, orientation);
	}

/// <summary>
/// <para>
/// Draws a spinner on @window using the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="widget">
/// the widget (may be %NULL)
/// </param>
/// <param name="detail">
/// a style detail (may be %NULL)
/// </param>
/// <param name="step">
/// the nth step
/// </param>
/// <param name="x">
/// the x origin of the rectangle in which to draw the spinner
/// </param>
/// <param name="y">
/// the y origin of the rectangle in which to draw the spinner
/// </param>
/// <param name="width">
/// the width of the rectangle in which to draw the spinner
/// </param>
/// <param name="height">
/// the height of the rectangle in which to draw the spinner
/// </param>

	public static void PaintSpinner(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, uint step, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_spinner(style, cr, state_type, widget, detail, step, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws an option menu tab (i.e. the up and down pointing arrows)
/// in the given rectangle on @cr using the given parameters.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="shadow_type">
/// the type of shadow to draw
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="x">
/// x origin of the rectangle to draw the tab in
/// </param>
/// <param name="y">
/// y origin of the rectangle to draw the tab in
/// </param>
/// <param name="width">
/// the width of the rectangle to draw the tab in
/// </param>
/// <param name="height">
/// the height of the rectangle to draw the tab in
/// </param>

	public static void PaintTab(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkShadowType shadow_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int x, int y, int width, int height)
	{
		GtkGlobalFunctionsExterns.gtk_paint_tab(style, cr, state_type, shadow_type, widget, detail, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws a vertical line from (@x, @y1_) to (@x, @y2_) in @cr
/// using the given style and state.
/// </para>
/// </summary>

/// <param name="style">
/// a #GtkStyle
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="state_type">
/// a state
/// </param>
/// <param name="widget">
/// the widget
/// </param>
/// <param name="detail">
/// a style detail
/// </param>
/// <param name="y1_">
/// the starting y coordinate
/// </param>
/// <param name="y2_">
/// the ending y coordinate
/// </param>
/// <param name="x">
/// the x coordinate
/// </param>

	public static void PaintVline(MentorLake.Gtk.GtkStyleHandle style, MentorLake.cairo.cairo_tHandle cr, MentorLake.Gtk.GtkStateType state_type, MentorLake.Gtk.GtkWidgetHandle widget, string detail, int y1_, int y2_, int x)
	{
		GtkGlobalFunctionsExterns.gtk_paint_vline(style, cr, state_type, widget, detail, y1_, y2_, x);
	}

/// <summary>
/// <para>
/// Returns the name of the default paper size, which
/// depends on the current locale.
/// </para>
/// </summary>

/// <return>
/// the name of the default paper size. The string
/// is owned by GTK+ and should not be modified.
/// </return>

	public static string PaperSizeGetDefault()
	{
		return GtkGlobalFunctionsExterns.gtk_paper_size_get_default();
	}

/// <summary>
/// <para>
/// Creates a list of known paper sizes.
/// </para>
/// </summary>

/// <param name="include_custom">
/// whether to include custom paper sizes
///     as defined in the page setup dialog
/// </param>
/// <return>
/// a newly allocated list of newly
///    allocated #GtkPaperSize objects
/// </return>

	public static MentorLake.GLib.GListHandle PaperSizeGetPaperSizes(bool include_custom)
	{
		return GtkGlobalFunctionsExterns.gtk_paper_size_get_paper_sizes(include_custom);
	}

/// <summary>
/// <para>
/// Parses command line arguments, and initializes global
/// attributes of GTK+, but does not actually open a connection
/// to a display. (See gdk_display_open(), gdk_get_display_arg_name())
/// </para>
/// <para>
/// Any arguments used by GTK+ or GDK are removed from the array and
/// @argc and @argv are updated accordingly.
/// </para>
/// <para>
/// There is no need to call this function explicitly if you are using
/// gtk_init(), or gtk_init_check().
/// </para>
/// <para>
/// Note that many aspects of GTK+ require a display connection to
/// function, so this way of initializing GTK+ is really only useful
/// for specialized use cases.
/// </para>
/// </summary>

/// <param name="argc">
/// a pointer to the number of command line arguments
/// </param>
/// <param name="argv">
/// a pointer to the array of
///     command line arguments
/// </param>
/// <return>
/// %TRUE if initialization succeeded, otherwise %FALSE
/// </return>

	public static bool ParseArgs(ref int argc, ref string[] argv)
	{
		return GtkGlobalFunctionsExterns.gtk_parse_args(ref argc, ref argv);
	}

/// <summary>
/// <para>
/// Registers an error quark for #GtkPrintOperation if necessary.
/// </para>
/// </summary>

/// <return>
/// The error quark used for #GtkPrintOperation errors.
/// </return>

	public static MentorLake.GLib.GQuark PrintErrorQuark()
	{
		return GtkGlobalFunctionsExterns.gtk_print_error_quark();
	}

/// <summary>
/// <para>
/// Runs a page setup dialog, letting the user modify the values from
/// @page_setup. If the user cancels the dialog, the returned #GtkPageSetup
/// is identical to the passed in @page_setup, otherwise it contains the
/// modifications done in the dialog.
/// </para>
/// <para>
/// Note that this function may use a recursive mainloop to show the page
/// setup dialog. See gtk_print_run_page_setup_dialog_async() if this is
/// a problem.
/// </para>
/// </summary>

/// <param name="parent">
/// transient parent
/// </param>
/// <param name="page_setup">
/// an existing #GtkPageSetup
/// </param>
/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// a new #GtkPageSetup
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle PrintRunPageSetupDialog(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkPageSetupHandle page_setup, MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkGlobalFunctionsExterns.gtk_print_run_page_setup_dialog(parent, page_setup, settings);
	}

/// <summary>
/// <para>
/// Runs a page setup dialog, letting the user modify the values from @page_setup.
/// </para>
/// <para>
/// In contrast to gtk_print_run_page_setup_dialog(), this function  returns after
/// showing the page setup dialog on platforms that support this, and calls @done_cb
/// from a signal handler for the ::response signal of the dialog.
/// </para>
/// </summary>

/// <param name="parent">
/// transient parent, or %NULL
/// </param>
/// <param name="page_setup">
/// an existing #GtkPageSetup, or %NULL
/// </param>
/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="done_cb">
/// a function to call when the user saves
///           the modified page setup
/// </param>
/// <param name="data">
/// user data to pass to @done_cb
/// </param>

	public static void PrintRunPageSetupDialogAsync(MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkPageSetupHandle page_setup, MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPageSetupDoneFunc done_cb, IntPtr data)
	{
		GtkGlobalFunctionsExterns.gtk_print_run_page_setup_dialog_async(parent, page_setup, settings, done_cb, data);
	}

/// <summary>
/// <para>
/// Sends an event to a widget, propagating the event to parent widgets
/// if the event remains unhandled.
/// </para>
/// <para>
/// Events received by GTK+ from GDK normally begin in gtk_main_do_event().
/// Depending on the type of event, existence of modal dialogs, grabs, etc.,
/// the event may be propagated; if so, this function is used.
/// </para>
/// <para>
/// gtk_propagate_event() calls gtk_widget_event() on each widget it
/// decides to send the event to. So gtk_widget_event() is the lowest-level
/// function; it simply emits the #GtkWidget::event and possibly an
/// event-specific signal on a widget. gtk_propagate_event() is a bit
/// higher-level, and gtk_main_do_event() is the highest level.
/// </para>
/// <para>
/// All that said, you most likely don’t want to use any of these
/// functions; synthesizing events is rarely needed. There are almost
/// certainly better ways to achieve your goals. For example, use
/// gdk_window_invalidate_rect() or gtk_widget_queue_draw() instead
/// of making up expose events.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="@event">
/// an event
/// </param>

	public static void PropagateEvent(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		GtkGlobalFunctionsExterns.gtk_propagate_event(widget, @event);
	}

/// <summary>
/// <para>
/// Adds a file to the list of files to be parsed at the
/// end of gtk_init().
/// </para>
/// </summary>

/// <param name="filename">
/// the pathname to the file. If @filename
///    is not absolute, it is searched in the current directory.
/// </param>

	public static void RcAddDefaultFile(string filename)
	{
		GtkGlobalFunctionsExterns.gtk_rc_add_default_file(filename);
	}

/// <summary>
/// <para>
/// Searches for a theme engine in the GTK+ search path. This function
/// is not useful for applications and should not be used.
/// </para>
/// </summary>

/// <param name="module_file">
/// name of a theme engine
/// </param>
/// <return>
/// The filename, if found (must be
///   freed with g_free()), otherwise %NULL.
/// </return>

	public static string RcFindModuleInPath(string module_file)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_find_module_in_path(module_file);
	}

/// <summary>
/// <para>
/// Looks up a file in pixmap path for the specified #GtkSettings.
/// If the file is not found, it outputs a warning message using
/// g_warning() and returns %NULL.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkSettings
/// </param>
/// <param name="scanner">
/// Scanner used to get line number information for the
///   warning message, or %NULL
/// </param>
/// <param name="pixmap_file">
/// name of the pixmap file to locate.
/// </param>
/// <return>
/// the filename.
/// </return>

	public static string RcFindPixmapInPath(MentorLake.Gtk.GtkSettingsHandle settings, MentorLake.GLib.GScannerHandle scanner, string pixmap_file)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_find_pixmap_in_path(settings, scanner, pixmap_file);
	}

/// <summary>
/// <para>
/// Retrieves the current list of RC files that will be parsed
/// at the end of gtk_init().
/// </para>
/// </summary>

/// <return>
/// 
///      A %NULL-terminated array of filenames.  This memory is owned
///     by GTK+ and must not be freed by the application.  If you want
///     to store this information, you should make a copy.
/// </return>

	public static string[] RcGetDefaultFiles()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_default_files();
	}

/// <summary>
/// <para>
/// Obtains the path to the IM modules file. See the documentation
/// of the `GTK_IM_MODULE_FILE`
/// environment variable for more details.
/// </para>
/// </summary>

/// <return>
/// a newly-allocated string containing the
///    name of the file listing the IM modules available for loading
/// </return>

	public static string RcGetImModuleFile()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_im_module_file();
	}

/// <summary>
/// <para>
/// Obtains the path in which to look for IM modules. See the documentation
/// of the `GTK_PATH`
/// environment variable for more details about looking up modules. This
/// function is useful solely for utilities supplied with GTK+ and should
/// not be used by applications under normal circumstances.
/// </para>
/// </summary>

/// <return>
/// a newly-allocated string containing the
///    path in which to look for IM modules.
/// </return>

	public static string RcGetImModulePath()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_im_module_path();
	}

/// <summary>
/// <para>
/// Returns a directory in which GTK+ looks for theme engines.
/// For full information about the search for theme engines,
/// see the docs for `GTK_PATH` in [Running GTK+ Applications][gtk-running].
/// </para>
/// </summary>

/// <return>
/// the directory. (Must be freed with g_free())
/// </return>

	public static string RcGetModuleDir()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_module_dir();
	}

/// <summary>
/// <para>
/// Finds all matching RC styles for a given widget,
/// composites them together, and then creates a
/// #GtkStyle representing the composite appearance.
/// (GTK+ actually keeps a cache of previously
/// created styles, so a new style may not be
/// created.)
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <return>
/// the resulting style. No refcount is added
///   to the returned style, so if you want to save this style around,
///   you should add a reference yourself.
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle RcGetStyle(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_style(widget);
	}

/// <summary>
/// <para>
/// Creates up a #GtkStyle from styles defined in a RC file by providing
/// the raw components used in matching. This function may be useful
/// when creating pseudo-widgets that should be themed like widgets but
/// don’t actually have corresponding GTK+ widgets. An example of this
/// would be items inside a GNOME canvas widget.
/// </para>
/// <para>
/// The action of gtk_rc_get_style() is similar to:
/// |[<!-- language="C" -->
///  gtk_widget_path (widget, NULL, &path, NULL);
///  gtk_widget_class_path (widget, NULL, &class_path, NULL);
///  gtk_rc_get_style_by_paths (gtk_widget_get_settings (widget),
///                             path, class_path,
///                             G_OBJECT_TYPE (widget));
/// ]|
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkSettings object
/// </param>
/// <param name="widget_path">
/// the widget path to use when looking up the
///     style, or %NULL if no matching against the widget path should be done
/// </param>
/// <param name="class_path">
/// the class path to use when looking up the style,
///     or %NULL if no matching against the class path should be done.
/// </param>
/// <param name="type">
/// a type that will be used along with parent types of this type
///     when matching against class styles, or #G_TYPE_NONE
/// </param>
/// <return>
/// A style created by matching
///     with the supplied paths, or %NULL if nothing matching was
///     specified and the default style should be used. The returned
///     value is owned by GTK+ as part of an internal cache, so you
///     must call g_object_ref() on the returned value if you want to
///     keep a reference to it.
/// </return>

	public static MentorLake.Gtk.GtkStyleHandle RcGetStyleByPaths(MentorLake.Gtk.GtkSettingsHandle settings, string widget_path, string class_path, MentorLake.GObject.GType type)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_style_by_paths(settings, widget_path, class_path, type);
	}

/// <summary>
/// <para>
/// Returns the standard directory in which themes should
/// be installed. (GTK+ does not actually use this directory
/// itself.)
/// </para>
/// </summary>

/// <return>
/// The directory (must be freed with g_free()).
/// </return>

	public static string RcGetThemeDir()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_get_theme_dir();
	}

/// <summary>
/// <para>
/// Parses a given resource file.
/// </para>
/// </summary>

/// <param name="filename">
/// the filename of a file to parse. If @filename is not absolute, it
///  is searched in the current directory.
/// </param>

	public static void RcParse(string filename)
	{
		GtkGlobalFunctionsExterns.gtk_rc_parse(filename);
	}

/// <summary>
/// <para>
/// Parses a color in the format expected
/// in a RC file.
/// </para>
/// <para>
/// Note that theme engines should use gtk_rc_parse_color_full() in
/// order to support symbolic colors.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="color">
/// a pointer to a #GdkColor in which to store
///     the result
/// </param>
/// <return>
/// %G_TOKEN_NONE if parsing succeeded, otherwise the token
///     that was expected but not found
/// </return>

	public static uint RcParseColor(MentorLake.GLib.GScannerHandle scanner, out MentorLake.Gdk.GdkColor color)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_color(scanner, out color);
	}

/// <summary>
/// <para>
/// Parses a color in the format expected
/// in a RC file. If @style is not %NULL, it will be consulted to resolve
/// references to symbolic colors.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="style">
/// a #GtkRcStyle, or %NULL
/// </param>
/// <param name="color">
/// a pointer to a #GdkColor in which to store
///     the result
/// </param>
/// <return>
/// %G_TOKEN_NONE if parsing succeeded, otherwise the token
///     that was expected but not found
/// </return>

	public static uint RcParseColorFull(MentorLake.GLib.GScannerHandle scanner, MentorLake.Gtk.GtkRcStyleHandle style, out MentorLake.Gdk.GdkColor color)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_color_full(scanner, style, out color);
	}

/// <summary>
/// <para>
/// Parses a #GtkPathPriorityType variable from the format expected
/// in a RC file.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner (must be initialized for parsing an RC file)
/// </param>
/// <param name="priority">
/// A pointer to #GtkPathPriorityType variable in which
///  to store the result.
/// </param>
/// <return>
/// %G_TOKEN_NONE if parsing succeeded, otherwise the token
///   that was expected but not found.
/// </return>

	public static uint RcParsePriority(MentorLake.GLib.GScannerHandle scanner, ref MentorLake.Gtk.GtkPathPriorityType priority)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_priority(scanner, ref priority);
	}

/// <summary>
/// <para>
/// Parses a #GtkStateType variable from the format expected
/// in a RC file.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner (must be initialized for parsing an RC file)
/// </param>
/// <param name="state">
/// A pointer to a #GtkStateType variable in which to
///  store the result.
/// </param>
/// <return>
/// %G_TOKEN_NONE if parsing succeeded, otherwise the token
///   that was expected but not found.
/// </return>

	public static uint RcParseState(MentorLake.GLib.GScannerHandle scanner, out MentorLake.Gtk.GtkStateType state)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_parse_state(scanner, out state);
	}

/// <summary>
/// <para>
/// Parses resource information directly from a string.
/// </para>
/// </summary>

/// <param name="rc_string">
/// a string to parse.
/// </param>

	public static void RcParseString(string rc_string)
	{
		GtkGlobalFunctionsExterns.gtk_rc_parse_string(rc_string);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses
/// borders in the form
/// `"{ left, right, top, bottom }"` for integers
/// left, right, top and bottom.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold boxed values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GtkBorder.
/// </return>

	public static bool RcPropertyParseBorder(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_border(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses a
/// color given either by its name or in the form
/// `{ red, green, blue }` where red, green and
/// blue are integers between 0 and 65535 or floating-point numbers
/// between 0 and 1.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold #GdkColor values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GdkColor.
/// </return>

	public static bool RcPropertyParseColor(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_color(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses a single
/// enumeration value.
/// </para>
/// <para>
/// The enumeration value can be specified by its name, its nickname or
/// its numeric value. For consistency with flags parsing, the value
/// may be surrounded by parentheses.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold enum values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GEnumValue.
/// </return>

	public static bool RcPropertyParseEnum(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_enum(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses flags.
/// </para>
/// <para>
/// Flags can be specified by their name, their nickname or
/// numerically. Multiple flags can be specified in the form
/// `"( flag1 | flag2 | ... )"`.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold flags values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting flags value.
/// </return>

	public static bool RcPropertyParseFlags(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_flags(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// A #GtkRcPropertyParser for use with gtk_settings_install_property_parser()
/// or gtk_widget_class_install_style_property_parser() which parses a
/// requisition in the form
/// `"{ width, height }"` for integers %width and %height.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GParamSpec
/// </param>
/// <param name="gstring">
/// the #GString to be parsed
/// </param>
/// <param name="property_value">
/// a #GValue which must hold boxed values.
/// </param>
/// <return>
/// %TRUE if @gstring could be parsed and @property_value
/// has been set to the resulting #GtkRequisition.
/// </return>

	public static bool RcPropertyParseRequisition(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GLib.GStringHandle gstring, MentorLake.GObject.GValueHandle property_value)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_property_parse_requisition(pspec, gstring, property_value);
	}

/// <summary>
/// <para>
/// If the modification time on any previously read file for the
/// default #GtkSettings has changed, discard all style information
/// and then reread all previously read RC files.
/// </para>
/// </summary>

/// <return>
/// %TRUE if the files were reread.
/// </return>

	public static bool RcReparseAll()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_reparse_all();
	}

/// <summary>
/// <para>
/// If the modification time on any previously read file
/// for the given #GtkSettings has changed, discard all style information
/// and then reread all previously read RC files.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkSettings
/// </param>
/// <param name="force_load">
/// load whether or not anything changed
/// </param>
/// <return>
/// %TRUE if the files were reread.
/// </return>

	public static bool RcReparseAllForSettings(MentorLake.Gtk.GtkSettingsHandle settings, bool force_load)
	{
		return GtkGlobalFunctionsExterns.gtk_rc_reparse_all_for_settings(settings, force_load);
	}

/// <summary>
/// <para>
/// This function recomputes the styles for all widgets that use a
/// particular #GtkSettings object. (There is one #GtkSettings object
/// per #GdkScreen, see gtk_settings_get_for_screen()); It is useful
/// when some global parameter has changed that affects the appearance
/// of all widgets, because when a widget gets a new style, it will
/// both redraw and recompute any cached information about its
/// appearance. As an example, it is used when the default font size
/// set by the operating system changes. Note that this function
/// doesn’t affect widgets that have a style set explicitly on them
/// with gtk_widget_set_style().
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkSettings
/// </param>

	public static void RcResetStyles(MentorLake.Gtk.GtkSettingsHandle settings)
	{
		GtkGlobalFunctionsExterns.gtk_rc_reset_styles(settings);
	}



	public static MentorLake.GLib.GScannerHandle RcScannerNew()
	{
		return GtkGlobalFunctionsExterns.gtk_rc_scanner_new();
	}

/// <summary>
/// <para>
/// Sets the list of files that GTK+ will read at the
/// end of gtk_init().
/// </para>
/// </summary>

/// <param name="filenames">
/// A
///     %NULL-terminated list of filenames.
/// </param>

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

/// <summary>
/// <para>
/// Renders an activity indicator (such as in #GtkSpinner).
/// The state %GTK_STATE_FLAG_CHECKED determines whether there is
/// activity going on.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderActivity(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_activity(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders an arrow pointing to @angle.
/// </para>
/// <para>
/// Typical arrow rendering at 0, 1⁄2 π;, π; and 3⁄2 π:
/// </para>
/// <para>
/// ![](arrows.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="angle">
/// arrow angle from 0 to 2 * %G_PI, being 0 the arrow pointing to the north
/// </param>
/// <param name="x">
/// X origin of the render area
/// </param>
/// <param name="y">
/// Y origin of the render area
/// </param>
/// <param name="size">
/// square side for render area
/// </param>

	public static void RenderArrow(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double angle, double x, double y, double size)
	{
		GtkGlobalFunctionsExterns.gtk_render_arrow(context, cr, angle, x, y, size);
	}

/// <summary>
/// <para>
/// Renders the background of an element.
/// </para>
/// <para>
/// Typical background rendering, showing the effect of
/// `background-image`, `border-width` and `border-radius`:
/// </para>
/// <para>
/// ![](background.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderBackground(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_background(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Returns the area that will be affected (i.e. drawn to) when
/// calling gtk_render_background() for the given @context and
/// rectangle.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>
/// <param name="out_clip">
/// return location for the clip
/// </param>

	public static void RenderBackgroundGetClip(MentorLake.Gtk.GtkStyleContextHandle context, double x, double y, double width, double height, out MentorLake.Gdk.GdkRectangle out_clip)
	{
		GtkGlobalFunctionsExterns.gtk_render_background_get_clip(context, x, y, width, height, out out_clip);
	}

/// <summary>
/// <para>
/// Renders a checkmark (as in a #GtkCheckButton).
/// </para>
/// <para>
/// The %GTK_STATE_FLAG_CHECKED state determines whether the check is
/// on or off, and %GTK_STATE_FLAG_INCONSISTENT determines whether it
/// should be marked as undefined.
/// </para>
/// <para>
/// Typical checkmark rendering:
/// </para>
/// <para>
/// ![](checks.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderCheck(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_check(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders an expander (as used in #GtkTreeView and #GtkExpander) in the area
/// defined by @x, @y, @width, @height. The state %GTK_STATE_FLAG_CHECKED
/// determines whether the expander is collapsed or expanded.
/// </para>
/// <para>
/// Typical expander rendering:
/// </para>
/// <para>
/// ![](expanders.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderExpander(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_expander(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders a extension (as in a #GtkNotebook tab) in the rectangle
/// defined by @x, @y, @width, @height. The side where the extension
/// connects to is defined by @gap_side.
/// </para>
/// <para>
/// Typical extension rendering:
/// </para>
/// <para>
/// ![](extensions.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>
/// <param name="gap_side">
/// side where the gap is
/// </param>

	public static void RenderExtension(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkPositionType gap_side)
	{
		GtkGlobalFunctionsExterns.gtk_render_extension(context, cr, x, y, width, height, gap_side);
	}

/// <summary>
/// <para>
/// Renders a focus indicator on the rectangle determined by @x, @y, @width, @height.
/// </para>
/// <para>
/// Typical focus rendering:
/// </para>
/// <para>
/// ![](focus.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderFocus(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_focus(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders a frame around the rectangle defined by @x, @y, @width, @height.
/// </para>
/// <para>
/// Examples of frame rendering, showing the effect of `border-image`,
/// `border-color`, `border-width`, `border-radius` and junctions:
/// </para>
/// <para>
/// ![](frames.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderFrame(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_frame(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders a frame around the rectangle defined by (@x, @y, @width, @height),
/// leaving a gap on one side. @xy0_gap and @xy1_gap will mean X coordinates
/// for %GTK_POS_TOP and %GTK_POS_BOTTOM gap sides, and Y coordinates for
/// %GTK_POS_LEFT and %GTK_POS_RIGHT.
/// </para>
/// <para>
/// Typical rendering of a frame with a gap:
/// </para>
/// <para>
/// ![](frame-gap.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>
/// <param name="gap_side">
/// side where the gap is
/// </param>
/// <param name="xy0_gap">
/// initial coordinate (X or Y depending on @gap_side) for the gap
/// </param>
/// <param name="xy1_gap">
/// end coordinate (X or Y depending on @gap_side) for the gap
/// </param>

	public static void RenderFrameGap(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkPositionType gap_side, double xy0_gap, double xy1_gap)
	{
		GtkGlobalFunctionsExterns.gtk_render_frame_gap(context, cr, x, y, width, height, gap_side, xy0_gap, xy1_gap);
	}

/// <summary>
/// <para>
/// Renders a handle (as in #GtkHandleBox, #GtkPaned and
/// #GtkWindow’s resize grip), in the rectangle
/// determined by @x, @y, @width, @height.
/// </para>
/// <para>
/// Handles rendered for the paned and grip classes:
/// </para>
/// <para>
/// ![](handles.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderHandle(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_handle(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders the icon in @pixbuf at the specified @x and @y coordinates.
/// </para>
/// <para>
/// This function will render the icon in @pixbuf at exactly its size,
/// regardless of scaling factors, which may not be appropriate when
/// drawing on displays with high pixel densities.
/// </para>
/// <para>
/// You probably want to use gtk_render_icon_surface() instead, if you
/// already have a Cairo surface.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf containing the icon to draw
/// </param>
/// <param name="x">
/// X position for the @pixbuf
/// </param>
/// <param name="y">
/// Y position for the @pixbuf
/// </param>

	public static void RenderIcon(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, double x, double y)
	{
		GtkGlobalFunctionsExterns.gtk_render_icon(context, cr, pixbuf, x, y);
	}

/// <summary>
/// <para>
/// Renders the icon specified by @source at the given @size, returning the result
/// in a pixbuf.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="source">
/// the #GtkIconSource specifying the icon to render
/// </param>
/// <param name="size">
/// the size (#GtkIconSize) to render the icon at.
///        A size of `(GtkIconSize) -1` means render at the size of the source
///        and don’t scale.
/// </param>
/// <return>
/// a newly-created #GdkPixbuf containing the rendered icon
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIconPixbuf(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkIconSourceHandle source, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkGlobalFunctionsExterns.gtk_render_icon_pixbuf(context, source, size);
	}

/// <summary>
/// <para>
/// Renders the icon in @surface at the specified @x and @y coordinates.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="surface">
/// a #cairo_surface_t containing the icon to draw
/// </param>
/// <param name="x">
/// X position for the @icon
/// </param>
/// <param name="y">
/// Y position for the @incon
/// </param>

	public static void RenderIconSurface(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, MentorLake.cairo.cairo_surface_tHandle surface, double x, double y)
	{
		GtkGlobalFunctionsExterns.gtk_render_icon_surface(context, cr, surface, x, y);
	}

/// <summary>
/// <para>
/// Draws a text caret on @cr at the specified index of @layout.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin
/// </param>
/// <param name="y">
/// Y origin
/// </param>
/// <param name="layout">
/// the #PangoLayout of the text
/// </param>
/// <param name="index">
/// the index in the #PangoLayout
/// </param>
/// <param name="direction">
/// the #PangoDirection of the text
/// </param>

	public static void RenderInsertionCursor(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, MentorLake.Pango.PangoLayoutHandle layout, int index, MentorLake.Pango.PangoDirection direction)
	{
		GtkGlobalFunctionsExterns.gtk_render_insertion_cursor(context, cr, x, y, layout, index, direction);
	}

/// <summary>
/// <para>
/// Renders @layout on the coordinates @x, @y
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin
/// </param>
/// <param name="y">
/// Y origin
/// </param>
/// <param name="layout">
/// the #PangoLayout to render
/// </param>

	public static void RenderLayout(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, MentorLake.Pango.PangoLayoutHandle layout)
	{
		GtkGlobalFunctionsExterns.gtk_render_layout(context, cr, x, y, layout);
	}

/// <summary>
/// <para>
/// Renders a line from (x0, y0) to (x1, y1).
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x0">
/// X coordinate for the origin of the line
/// </param>
/// <param name="y0">
/// Y coordinate for the origin of the line
/// </param>
/// <param name="x1">
/// X coordinate for the end of the line
/// </param>
/// <param name="y1">
/// Y coordinate for the end of the line
/// </param>

	public static void RenderLine(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x0, double y0, double x1, double y1)
	{
		GtkGlobalFunctionsExterns.gtk_render_line(context, cr, x0, y0, x1, y1);
	}

/// <summary>
/// <para>
/// Renders an option mark (as in a #GtkRadioButton), the %GTK_STATE_FLAG_CHECKED
/// state will determine whether the option is on or off, and
/// %GTK_STATE_FLAG_INCONSISTENT whether it should be marked as undefined.
/// </para>
/// <para>
/// Typical option mark rendering:
/// </para>
/// <para>
/// ![](options.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>

	public static void RenderOption(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		GtkGlobalFunctionsExterns.gtk_render_option(context, cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Renders a slider (as in #GtkScale) in the rectangle defined by @x, @y,
/// @width, @height. @orientation defines whether the slider is vertical
/// or horizontal.
/// </para>
/// <para>
/// Typical slider rendering:
/// </para>
/// <para>
/// ![](sliders.png)
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="cr">
/// a #cairo_t
/// </param>
/// <param name="x">
/// X origin of the rectangle
/// </param>
/// <param name="y">
/// Y origin of the rectangle
/// </param>
/// <param name="width">
/// rectangle width
/// </param>
/// <param name="height">
/// rectangle height
/// </param>
/// <param name="orientation">
/// orientation of the slider
/// </param>

	public static void RenderSlider(MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height, MentorLake.Gtk.GtkOrientation orientation)
	{
		GtkGlobalFunctionsExterns.gtk_render_slider(context, cr, x, y, width, height, orientation);
	}

/// <summary>
/// <para>
/// Converts a color from RGB space to HSV.
/// </para>
/// <para>
/// Input values must be in the [0.0, 1.0] range;
/// output values will be in the same range.
/// </para>
/// </summary>

/// <param name="r">
/// Red
/// </param>
/// <param name="g">
/// Green
/// </param>
/// <param name="b">
/// Blue
/// </param>
/// <param name="h">
/// Return value for the hue component
/// </param>
/// <param name="s">
/// Return value for the saturation component
/// </param>
/// <param name="v">
/// Return value for the value component
/// </param>

	public static void RgbToHsv(double r, double g, double b, out double h, out double s, out double v)
	{
		GtkGlobalFunctionsExterns.gtk_rgb_to_hsv(r, g, b, out h, out s, out v);
	}

/// <summary>
/// <para>
/// Appends a specified target to the list of supported targets for a
/// given widget and selection.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="selection">
/// the selection
/// </param>
/// <param name="target">
/// target to add.
/// </param>
/// <param name="info">
/// A unsigned integer which will be passed back to the application.
/// </param>

	public static void SelectionAddTarget(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint info)
	{
		GtkGlobalFunctionsExterns.gtk_selection_add_target(widget, selection, target, info);
	}

/// <summary>
/// <para>
/// Prepends a table of targets to the list of supported targets
/// for a given widget and selection.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="selection">
/// the selection
/// </param>
/// <param name="targets">
/// a table of targets to add
/// </param>
/// <param name="ntargets">
/// number of entries in @targets
/// </param>

	public static void SelectionAddTargets(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets)
	{
		GtkGlobalFunctionsExterns.gtk_selection_add_targets(widget, selection, targets, ntargets);
	}

/// <summary>
/// <para>
/// Remove all targets registered for the given selection for the
/// widget.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="selection">
/// an atom representing a selection
/// </param>

	public static void SelectionClearTargets(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection)
	{
		GtkGlobalFunctionsExterns.gtk_selection_clear_targets(widget, selection);
	}

/// <summary>
/// <para>
/// Requests the contents of a selection. When received,
/// a “selection-received” signal will be generated.
/// </para>
/// </summary>

/// <param name="widget">
/// The widget which acts as requestor
/// </param>
/// <param name="selection">
/// Which selection to get
/// </param>
/// <param name="target">
/// Form of information desired (e.g., STRING)
/// </param>
/// <param name="time_">
/// Time of request (usually of triggering event)
///        In emergency, you could use #GDK_CURRENT_TIME
/// </param>
/// <return>
/// %TRUE if requested succeeded. %FALSE if we could not process
///          request. (e.g., there was already a request in process for
///          this widget).
/// </return>

	public static bool SelectionConvert(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, MentorLake.Gdk.GdkAtom target, uint time_)
	{
		return GtkGlobalFunctionsExterns.gtk_selection_convert(widget, selection, target, time_);
	}

/// <summary>
/// <para>
/// Claims ownership of a given selection for a particular widget,
/// or, if @widget is %NULL, release ownership of the selection.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget, or %NULL.
/// </param>
/// <param name="selection">
/// an interned atom representing the selection to claim
/// </param>
/// <param name="time_">
/// timestamp with which to claim the selection
/// </param>
/// <return>
/// %TRUE if the operation succeeded
/// </return>

	public static bool SelectionOwnerSet(MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, uint time_)
	{
		return GtkGlobalFunctionsExterns.gtk_selection_owner_set(widget, selection, time_);
	}

/// <summary>
/// <para>
/// Claim ownership of a given selection for a particular widget, or,
/// if @widget is %NULL, release ownership of the selection.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay where the selection is set
/// </param>
/// <param name="widget">
/// new selection owner (a #GtkWidget), or %NULL.
/// </param>
/// <param name="selection">
/// an interned atom representing the selection to claim.
/// </param>
/// <param name="time_">
/// timestamp with which to claim the selection
/// </param>
/// <return>
/// TRUE if the operation succeeded
/// </return>

	public static bool SelectionOwnerSetForDisplay(MentorLake.Gdk.GdkDisplayHandle display, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection, uint time_)
	{
		return GtkGlobalFunctionsExterns.gtk_selection_owner_set_for_display(display, widget, selection, time_);
	}

/// <summary>
/// <para>
/// Removes all handlers and unsets ownership of all
/// selections for a widget. Called when widget is being
/// destroyed. This function will not generally be
/// called by applications.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>

	public static void SelectionRemoveAll(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		GtkGlobalFunctionsExterns.gtk_selection_remove_all(widget);
	}

/// <summary>
/// <para>
/// Sets the GTK+ debug flags.
/// </para>
/// </summary>

/// <param name="flags">
/// </param>

	public static void SetDebugFlags(uint flags)
	{
		GtkGlobalFunctionsExterns.gtk_set_debug_flags(flags);
	}

/// <summary>
/// <para>
/// This is a convenience function for showing an application’s about box.
/// The constructed dialog is associated with the parent window and
/// reused for future invocations of this function.
/// </para>
/// </summary>

/// <param name="parent">
/// transient parent, or %NULL for none
/// </param>
/// <param name="first_property_name">
/// the name of the first property
/// </param>
/// <param name="@__arglist">
/// value of first property, followed by more properties, %NULL-terminated
/// </param>

	public static void ShowAboutDialog(MentorLake.Gtk.GtkWindowHandle parent, string first_property_name, IntPtr @__arglist)
	{
		GtkGlobalFunctionsExterns.gtk_show_about_dialog(parent, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// A convenience function for launching the default application
/// to show the uri. Like gtk_show_uri_on_window(), but takes a screen
/// as transient parent instead of a window.
/// </para>
/// <para>
/// Note that this function is deprecated as it does not pass the necessary
/// information for helpers to parent their dialog properly, when run from
/// sandboxed applications for example.
/// </para>
/// </summary>

/// <param name="screen">
/// screen to show the uri on
///     or %NULL for the default screen
/// </param>
/// <param name="uri">
/// the uri to show
/// </param>
/// <param name="timestamp">
/// a timestamp to prevent focus stealing
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error
/// </return>

	public static bool ShowUri(MentorLake.Gdk.GdkScreenHandle screen, string uri, uint timestamp)
	{
		var externCallResult = GtkGlobalFunctionsExterns.gtk_show_uri(screen, uri, timestamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is a convenience function for launching the default application
/// to show the uri. The uri must be of a form understood by GIO (i.e. you
/// need to install gvfs to get support for uri schemes such as http://
/// or ftp://, as only local files are handled by GIO itself).
/// Typical examples are
/// - `file:///home/gnome/pict.jpg`
/// - `http://www.gnome.org`
/// - `mailto:me@gnome.org`
/// </para>
/// <para>
/// Ideally the timestamp is taken from the event triggering
/// the gtk_show_uri() call. If timestamp is not known you can take
/// %GDK_CURRENT_TIME.
/// </para>
/// <para>
/// This is the recommended call to be used as it passes information
/// necessary for sandbox helpers to parent their dialogs properly.
/// </para>
/// </summary>

/// <param name="parent">
/// parent window
/// </param>
/// <param name="uri">
/// the uri to show
/// </param>
/// <param name="timestamp">
/// a timestamp to prevent focus stealing
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error
/// </return>

	public static bool ShowUriOnWindow(MentorLake.Gtk.GtkWindowHandle parent, string uri, uint timestamp)
	{
		var externCallResult = GtkGlobalFunctionsExterns.gtk_show_uri_on_window(parent, uri, timestamp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Registers each of the stock items in @items. If an item already
/// exists with the same stock ID as one of the @items, the old item
/// gets replaced. The stock items are copied, so GTK+ does not hold
/// any pointer into @items and @items can be freed. Use
/// gtk_stock_add_static() if @items is persistent and GTK+ need not
/// copy the array.
/// </para>
/// </summary>

/// <param name="items">
/// a #GtkStockItem or array of items
/// </param>
/// <param name="n_items">
/// number of #GtkStockItem in @items
/// </param>

	public static void StockAdd(MentorLake.Gtk.GtkStockItem[] items, uint n_items)
	{
		GtkGlobalFunctionsExterns.gtk_stock_add(items, n_items);
	}

/// <summary>
/// <para>
/// Same as gtk_stock_add(), but doesn’t copy @items, so
/// @items must persist until application exit.
/// </para>
/// </summary>

/// <param name="items">
/// a #GtkStockItem or array of #GtkStockItem
/// </param>
/// <param name="n_items">
/// number of items
/// </param>

	public static void StockAddStatic(MentorLake.Gtk.GtkStockItem[] items, uint n_items)
	{
		GtkGlobalFunctionsExterns.gtk_stock_add_static(items, n_items);
	}

/// <summary>
/// <para>
/// Retrieves a list of all known stock IDs added to a #GtkIconFactory
/// or registered with gtk_stock_add(). The list must be freed with g_slist_free(),
/// and each string in the list must be freed with g_free().
/// </para>
/// </summary>

/// <return>
/// a list of known stock IDs
/// </return>

	public static MentorLake.GLib.GSListHandle StockListIds()
	{
		return GtkGlobalFunctionsExterns.gtk_stock_list_ids();
	}

/// <summary>
/// <para>
/// Fills @item with the registered values for @stock_id, returning %TRUE
/// if @stock_id was known.
/// </para>
/// </summary>

/// <param name="stock_id">
/// a stock item name
/// </param>
/// <param name="item">
/// stock item to initialize with values
/// </param>
/// <return>
/// %TRUE if @item was initialized
/// </return>

	public static bool StockLookup(string stock_id, out MentorLake.Gtk.GtkStockItem item)
	{
		return GtkGlobalFunctionsExterns.gtk_stock_lookup(stock_id, out item);
	}

/// <summary>
/// <para>
/// Sets a function to be used for translating the @label of
/// a stock item.
/// </para>
/// <para>
/// If no function is registered for a translation domain,
/// g_dgettext() is used.
/// </para>
/// <para>
/// The function is used for all stock items whose
/// @translation_domain matches @domain. Note that it is possible
/// to use strings different from the actual gettext translation domain
/// of your application for this, as long as your #GtkTranslateFunc uses
/// the correct domain when calling dgettext(). This can be useful, e.g.
/// when dealing with message contexts:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkStockItem items[] = {
///  { MY_ITEM1, NC_("odd items", "Item 1"), 0, 0, "odd-item-domain" },
///  { MY_ITEM2, NC_("even items", "Item 2"), 0, 0, "even-item-domain" },
/// };
/// </para>
/// <para>
/// gchar *
/// my_translate_func (const gchar *msgid,
///                    gpointer     data)
/// {
///   gchar *msgctxt = data;
/// </para>
/// <para>
///   return (gchar*)g_dpgettext2 (GETTEXT_PACKAGE, msgctxt, msgid);
/// }
/// </para>
/// <para>
/// ...
/// </para>
/// <para>
/// gtk_stock_add (items, G_N_ELEMENTS (items));
/// gtk_stock_set_translate_func ("odd-item-domain", my_translate_func, "odd items");
/// gtk_stock_set_translate_func ("even-item-domain", my_translate_func, "even items");
/// ]|
/// </para>
/// </summary>

/// <param name="domain">
/// the translation domain for which @func shall be used
/// </param>
/// <param name="func">
/// a #GtkTranslateFunc
/// </param>
/// <param name="data">
/// data to pass to @func
/// </param>
/// <param name="notify">
/// a #GDestroyNotify that is called when @data is
///   no longer needed
/// </param>

	public static void StockSetTranslateFunc(string domain, MentorLake.Gtk.GtkTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		GtkGlobalFunctionsExterns.gtk_stock_set_translate_func(domain, func, data, notify);
	}

/// <summary>
/// <para>
/// This function frees a target table as returned by
/// gtk_target_table_new_from_list()
/// </para>
/// </summary>

/// <param name="targets">
/// a #GtkTargetEntry array
/// </param>
/// <param name="n_targets">
/// the number of entries in the array
/// </param>

	public static void TargetTableFree(MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets)
	{
		GtkGlobalFunctionsExterns.gtk_target_table_free(targets, n_targets);
	}

/// <summary>
/// <para>
/// This function creates an #GtkTargetEntry array that contains the
/// same targets as the passed %list. The returned table is newly
/// allocated and should be freed using gtk_target_table_free() when no
/// longer needed.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="n_targets">
/// return location for the number ot targets in the table
/// </param>
/// <return>
/// the new table.
/// </return>

	public static MentorLake.Gtk.GtkTargetEntry[] TargetTableNewFromList(MentorLake.Gtk.GtkTargetListHandle list, out int n_targets)
	{
		return GtkGlobalFunctionsExterns.gtk_target_table_new_from_list(list, out n_targets);
	}

/// <summary>
/// <para>
/// Determines if any of the targets in @targets can be used to
/// provide a #GdkPixbuf.
/// </para>
/// </summary>

/// <param name="targets">
/// an array of #GdkAtoms
/// </param>
/// <param name="n_targets">
/// the length of @targets
/// </param>
/// <param name="writable">
/// whether to accept only targets for which GTK+ knows
///   how to convert a pixbuf into the format
/// </param>
/// <return>
/// %TRUE if @targets include a suitable target for images,
///   otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeImage(MentorLake.Gdk.GdkAtom[] targets, int n_targets, bool writable)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_image(targets, n_targets, writable);
	}

/// <summary>
/// <para>
/// Determines if any of the targets in @targets can be used to
/// provide rich text.
/// </para>
/// </summary>

/// <param name="targets">
/// an array of #GdkAtoms
/// </param>
/// <param name="n_targets">
/// the length of @targets
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// %TRUE if @targets include a suitable target for rich text,
///               otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeRichText(MentorLake.Gdk.GdkAtom[] targets, int n_targets, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_rich_text(targets, n_targets, buffer);
	}

/// <summary>
/// <para>
/// Determines if any of the targets in @targets can be used to
/// provide text.
/// </para>
/// </summary>

/// <param name="targets">
/// an array of #GdkAtoms
/// </param>
/// <param name="n_targets">
/// the length of @targets
/// </param>
/// <return>
/// %TRUE if @targets include a suitable target for text,
///   otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeText(MentorLake.Gdk.GdkAtom[] targets, int n_targets)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_text(targets, n_targets);
	}

/// <summary>
/// <para>
/// Determines if any of the targets in @targets can be used to
/// provide an uri list.
/// </para>
/// </summary>

/// <param name="targets">
/// an array of #GdkAtoms
/// </param>
/// <param name="n_targets">
/// the length of @targets
/// </param>
/// <return>
/// %TRUE if @targets include a suitable target for uri lists,
///   otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeUri(MentorLake.Gdk.GdkAtom[] targets, int n_targets)
	{
		return GtkGlobalFunctionsExterns.gtk_targets_include_uri(targets, n_targets);
	}

/// <summary>
/// <para>
/// Create a simple window with window title @window_title and
/// text contents @dialog_text.
/// The window will quit any running gtk_main()-loop when destroyed, and it
/// will automatically be destroyed upon test function teardown.
/// </para>
/// </summary>

/// <param name="window_title">
/// Title of the window to be displayed.
/// </param>
/// <param name="dialog_text">
/// Text inside the window to be displayed.
/// </param>
/// <return>
/// a widget pointer to the newly created GtkWindow.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle TestCreateSimpleWindow(string window_title, string dialog_text)
	{
		return GtkGlobalFunctionsExterns.gtk_test_create_simple_window(window_title, dialog_text);
	}

/// <summary>
/// <para>
/// This function wraps g_object_new() for widget types.
/// It’ll automatically show all created non window widgets, also
/// g_object_ref_sink() them (to keep them alive across a running test)
/// and set them up for destruction during the next test teardown phase.
/// </para>
/// </summary>

/// <param name="widget_type">
/// a valid widget type.
/// </param>
/// <param name="first_property_name">
/// Name of first property to set or %NULL
/// </param>
/// <param name="@__arglist">
/// value to set the first property to, followed by more
///    name-value pairs, terminated by %NULL
/// </param>
/// <return>
/// a newly created widget.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle TestCreateWidget(MentorLake.GObject.GType widget_type, string first_property_name, IntPtr @__arglist)
	{
		return GtkGlobalFunctionsExterns.gtk_test_create_widget(widget_type, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// Create a window with window title @window_title, text contents @dialog_text,
/// and a number of buttons, according to the paired argument list given
/// as @... parameters.
/// Each button is created with a @label and a ::clicked signal handler that
/// incremrents the integer stored in @nump.
/// The window will be automatically shown with gtk_widget_show_now() after
/// creation, so when this function returns it has already been mapped,
/// resized and positioned on screen.
/// The window will quit any running gtk_main()-loop when destroyed, and it
/// will automatically be destroyed upon test function teardown.
/// </para>
/// </summary>

/// <param name="window_title">
/// Title of the window to be displayed.
/// </param>
/// <param name="dialog_text">
/// Text inside the window to be displayed.
/// </param>
/// <param name="@__arglist">
/// %NULL terminated list of (const char *label, int *nump) pairs.
/// </param>
/// <return>
/// a widget pointer to the newly created GtkWindow.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle TestDisplayButtonWindow(string window_title, string dialog_text, IntPtr @__arglist)
	{
		return GtkGlobalFunctionsExterns.gtk_test_display_button_window(window_title, dialog_text, @__arglist);
	}

/// <summary>
/// <para>
/// This function will search @widget and all its descendants for a GtkLabel
/// widget with a text string matching @label_pattern.
/// The @label_pattern may contain asterisks “*” and question marks “?” as
/// placeholders, g_pattern_match() is used for the matching.
/// Note that locales other than "C“ tend to alter (translate” label strings,
/// so this function is genrally only useful in test programs with
/// predetermined locales, see gtk_test_init() for more details.
/// </para>
/// </summary>

/// <param name="widget">
/// Valid label or container widget.
/// </param>
/// <param name="label_pattern">
/// Shell-glob pattern to match a label string.
/// </param>
/// <return>
/// a GtkLabel widget if any is found.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle TestFindLabel(MentorLake.Gtk.GtkWidgetHandle widget, string label_pattern)
	{
		return GtkGlobalFunctionsExterns.gtk_test_find_label(widget, label_pattern);
	}

/// <summary>
/// <para>
/// This function will search siblings of @base_widget and siblings of its
/// ancestors for all widgets matching @widget_type.
/// Of the matching widgets, the one that is geometrically closest to
/// @base_widget will be returned.
/// The general purpose of this function is to find the most likely “action”
/// widget, relative to another labeling widget. Such as finding a
/// button or text entry widget, given its corresponding label widget.
/// </para>
/// </summary>

/// <param name="base_widget">
/// Valid widget, part of a widget hierarchy
/// </param>
/// <param name="widget_type">
/// Type of a aearched for sibling widget
/// </param>
/// <return>
/// a widget of type @widget_type if any is found.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle TestFindSibling(MentorLake.Gtk.GtkWidgetHandle base_widget, MentorLake.GObject.GType widget_type)
	{
		return GtkGlobalFunctionsExterns.gtk_test_find_sibling(base_widget, widget_type);
	}

/// <summary>
/// <para>
/// This function will search the descendants of @widget for a widget
/// of type @widget_type that has a label matching @label_pattern next
/// to it. This is most useful for automated GUI testing, e.g. to find
/// the “OK” button in a dialog and synthesize clicks on it.
/// However see gtk_test_find_label(), gtk_test_find_sibling() and
/// gtk_test_widget_click() for possible caveats involving the search of
/// such widgets and synthesizing widget events.
/// </para>
/// </summary>

/// <param name="widget">
/// Container widget, usually a GtkWindow.
/// </param>
/// <param name="label_pattern">
/// Shell-glob pattern to match a label string.
/// </param>
/// <param name="widget_type">
/// Type of a aearched for label sibling widget.
/// </param>
/// <return>
/// a valid widget if any is found or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle TestFindWidget(MentorLake.Gtk.GtkWidgetHandle widget, string label_pattern, MentorLake.GObject.GType widget_type)
	{
		return GtkGlobalFunctionsExterns.gtk_test_find_widget(widget, label_pattern, widget_type);
	}

/// <summary>
/// <para>
/// This function is used to initialize a GTK+ test program.
/// </para>
/// <para>
/// It will in turn call g_test_init() and gtk_init() to properly
/// initialize the testing framework and graphical toolkit. It’ll
/// also set the program’s locale to “C” and prevent loading of rc
/// files and Gtk+ modules. This is done to make tets program
/// environments as deterministic as possible.
/// </para>
/// <para>
/// Like gtk_init() and g_test_init(), any known arguments will be
/// processed and stripped from @argc and @argv.
/// </para>
/// </summary>

/// <param name="argcp">
/// Address of the `argc` parameter of the
///        main() function. Changed if any arguments were handled.
/// </param>
/// <param name="argvp">
/// Address of the
///        `argv` parameter of main().
///        Any parameters understood by g_test_init() or gtk_init() are
///        stripped before return.
/// </param>
/// <param name="@__arglist">
/// currently unused
/// </param>

	public static void TestInit(ref int argcp, ref string[] argvp, IntPtr @__arglist)
	{
		GtkGlobalFunctionsExterns.gtk_test_init(ref argcp, ref argvp, @__arglist);
	}

/// <summary>
/// <para>
/// Return the type ids that have been registered after
/// calling gtk_test_register_all_types().
/// </para>
/// </summary>

/// <param name="n_types">
/// location to store number of types
/// </param>
/// <return>
/// 
///    0-terminated array of type ids
/// </return>

	public static MentorLake.GObject.GType[] TestListAllTypes(out uint n_types)
	{
		return GtkGlobalFunctionsExterns.gtk_test_list_all_types(out n_types);
	}

/// <summary>
/// <para>
/// Force registration of all core Gtk+ and Gdk object types.
/// This allowes to refer to any of those object types via
/// g_type_from_name() after calling this function.
/// </para>
/// </summary>


	public static void TestRegisterAllTypes()
	{
		GtkGlobalFunctionsExterns.gtk_test_register_all_types();
	}

/// <summary>
/// <para>
/// Retrive the literal adjustment value for GtkRange based
/// widgets and spin buttons. Note that the value returned by
/// this function is anything between the lower and upper bounds
/// of the adjustment belonging to @widget, and is not a percentage
/// as passed in to gtk_test_slider_set_perc().
/// </para>
/// </summary>

/// <param name="widget">
/// valid widget pointer.
/// </param>
/// <return>
/// gtk_adjustment_get_value (adjustment) for an adjustment belonging to @widget.
/// </return>

	public static double TestSliderGetValue(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGlobalFunctionsExterns.gtk_test_slider_get_value(widget);
	}

/// <summary>
/// <para>
/// This function will adjust the slider position of all GtkRange
/// based widgets, such as scrollbars or scales, it’ll also adjust
/// spin buttons. The adjustment value of these widgets is set to
/// a value between the lower and upper limits, according to the
/// @percentage argument.
/// </para>
/// </summary>

/// <param name="widget">
/// valid widget pointer.
/// </param>
/// <param name="percentage">
/// value between 0 and 100.
/// </param>

	public static void TestSliderSetPerc(MentorLake.Gtk.GtkWidgetHandle widget, double percentage)
	{
		GtkGlobalFunctionsExterns.gtk_test_slider_set_perc(widget, percentage);
	}

/// <summary>
/// <para>
/// This function will generate a @button click in the upwards or downwards
/// spin button arrow areas, usually leading to an increase or decrease of
/// spin button’s value.
/// </para>
/// </summary>

/// <param name="spinner">
/// valid GtkSpinButton widget.
/// </param>
/// <param name="button">
/// Number of the pointer button for the event, usually 1, 2 or 3.
/// </param>
/// <param name="upwards">
/// %TRUE for upwards arrow click, %FALSE for downwards arrow click.
/// </param>
/// <return>
/// whether all actions neccessary for the button click simulation were carried out successfully.
/// </return>

	public static bool TestSpinButtonClick(MentorLake.Gtk.GtkSpinButtonHandle spinner, uint button, bool upwards)
	{
		return GtkGlobalFunctionsExterns.gtk_test_spin_button_click(spinner, button, upwards);
	}

/// <summary>
/// <para>
/// Retrive the text string of @widget if it is a GtkLabel,
/// GtkEditable (entry and text widgets) or GtkTextView.
/// </para>
/// </summary>

/// <param name="widget">
/// valid widget pointer.
/// </param>
/// <return>
/// new 0-terminated C string, needs to be released with g_free().
/// </return>

	public static string TestTextGet(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkGlobalFunctionsExterns.gtk_test_text_get(widget);
	}

/// <summary>
/// <para>
/// Set the text string of @widget to @string if it is a GtkLabel,
/// GtkEditable (entry and text widgets) or GtkTextView.
/// </para>
/// </summary>

/// <param name="widget">
/// valid widget pointer.
/// </param>
/// <param name="@string">
/// a 0-terminated C string
/// </param>

	public static void TestTextSet(MentorLake.Gtk.GtkWidgetHandle widget, string @string)
	{
		GtkGlobalFunctionsExterns.gtk_test_text_set(widget, @string);
	}

/// <summary>
/// <para>
/// This function will generate a @button click (button press and button
/// release event) in the middle of the first GdkWindow found that belongs
/// to @widget.
/// For windowless widgets like #GtkButton (which returns %FALSE from
/// gtk_widget_get_has_window()), this will often be an
/// input-only event window. For other widgets, this is usually widget->window.
/// Certain caveats should be considered when using this function, in
/// particular because the mouse pointer is warped to the button click
/// location, see gdk_test_simulate_button() for details.
/// </para>
/// </summary>

/// <param name="widget">
/// Widget to generate a button click on.
/// </param>
/// <param name="button">
/// Number of the pointer button for the event, usually 1, 2 or 3.
/// </param>
/// <param name="modifiers">
/// Keyboard modifiers the event is setup with.
/// </param>
/// <return>
/// whether all actions neccessary for the button click simulation were carried out successfully.
/// </return>

	public static bool TestWidgetClick(MentorLake.Gtk.GtkWidgetHandle widget, uint button, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_test_widget_click(widget, button, modifiers);
	}

/// <summary>
/// <para>
/// This function will generate keyboard press and release events in
/// the middle of the first GdkWindow found that belongs to @widget.
/// For windowless widgets like #GtkButton (which returns %FALSE from
/// gtk_widget_get_has_window()), this will often be an
/// input-only event window. For other widgets, this is usually widget->window.
/// Certain caveats should be considered when using this function, in
/// particular because the mouse pointer is warped to the key press
/// location, see gdk_test_simulate_key() for details.
/// </para>
/// </summary>

/// <param name="widget">
/// Widget to generate a key press and release on.
/// </param>
/// <param name="keyval">
/// A Gdk keyboard value.
/// </param>
/// <param name="modifiers">
/// Keyboard modifiers the event is setup with.
/// </param>
/// <return>
/// whether all actions neccessary for the key event simulation were carried out successfully.
/// </return>

	public static bool TestWidgetSendKey(MentorLake.Gtk.GtkWidgetHandle widget, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		return GtkGlobalFunctionsExterns.gtk_test_widget_send_key(widget, keyval, modifiers);
	}

/// <summary>
/// <para>
/// Enters the main loop and waits for @widget to be “drawn”. In this
/// context that means it waits for the frame clock of @widget to have
/// run a full styling, layout and drawing cycle.
/// </para>
/// <para>
/// This function is intended to be used for syncing with actions that
/// depend on @widget relayouting or on interaction with the display
/// server.
/// </para>
/// </summary>

/// <param name="widget">
/// the widget to wait for
/// </param>

	public static void TestWidgetWaitForDraw(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		GtkGlobalFunctionsExterns.gtk_test_widget_wait_for_draw(widget);
	}

/// <summary>
/// <para>
/// Obtains a @tree_model and @path from selection data of target type
/// %GTK_TREE_MODEL_ROW. Normally called from a drag_data_received handler.
/// This function can only be used if @selection_data originates from the same
/// process that’s calling this function, because a pointer to the tree model
/// is being passed around. If you aren’t in the same process, then you'll
/// get memory corruption. In the #GtkTreeDragDest drag_data_received handler,
/// you can assume that selection data of type %GTK_TREE_MODEL_ROW is
/// in from the current process. The returned path must be freed with
/// gtk_tree_path_free().
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// row in @tree_model
/// </param>
/// <return>
/// %TRUE if @selection_data had target type %GTK_TREE_MODEL_ROW and
///  is otherwise valid
/// </return>

	public static bool TreeGetRowDragData(MentorLake.Gtk.GtkSelectionDataHandle selection_data, out MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkGlobalFunctionsExterns.gtk_tree_get_row_drag_data(selection_data, out tree_model, out path);
	}

/// <summary>
/// <para>
/// Lets a set of row reference created by
/// gtk_tree_row_reference_new_proxy() know that the
/// model emitted the #GtkTreeModel::row-deleted signal.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GObject
/// </param>
/// <param name="path">
/// the path position that was deleted
/// </param>

	public static void TreeRowReferenceDeleted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkGlobalFunctionsExterns.gtk_tree_row_reference_deleted(proxy, path);
	}

/// <summary>
/// <para>
/// Lets a set of row reference created by
/// gtk_tree_row_reference_new_proxy() know that the
/// model emitted the #GtkTreeModel::row-inserted signal.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GObject
/// </param>
/// <param name="path">
/// the row position that was inserted
/// </param>

	public static void TreeRowReferenceInserted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkGlobalFunctionsExterns.gtk_tree_row_reference_inserted(proxy, path);
	}

/// <summary>
/// <para>
/// Lets a set of row reference created by
/// gtk_tree_row_reference_new_proxy() know that the
/// model emitted the #GtkTreeModel::rows-reordered signal.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GObject
/// </param>
/// <param name="path">
/// the parent path of the reordered signal
/// </param>
/// <param name="iter">
/// the iter pointing to the parent of the reordered
/// </param>
/// <param name="new_order">
/// the new order of rows
/// </param>

	public static void TreeRowReferenceReordered(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order)
	{
		GtkGlobalFunctionsExterns.gtk_tree_row_reference_reordered(proxy, path, iter, new_order);
	}

/// <summary>
/// <para>
/// Sets selection data of target type %GTK_TREE_MODEL_ROW. Normally used
/// in a drag_data_get handler.
/// </para>
/// </summary>

/// <param name="selection_data">
/// some #GtkSelectionData
/// </param>
/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a row in @tree_model
/// </param>
/// <return>
/// %TRUE if the #GtkSelectionData had the proper target type to allow us to set a tree row
/// </return>

	public static bool TreeSetRowDragData(MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkGlobalFunctionsExterns.gtk_tree_set_row_drag_data(selection_data, tree_model, path);
	}

/// <summary>
/// <para>
/// All this function does it to return %TRUE.
/// </para>
/// <para>
/// This can be useful for example if you want to inhibit the deletion
/// of a window. Of course you should not do this as the user expects
/// a reaction from clicking the close icon of the window...
/// </para>
/// <para>
/// ## A persistent window
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// #include <gtk/gtk.h>
/// </para>
/// <para>
/// int
/// main (int argc, char **argv)
/// {
///   GtkWidget *win, *but;
///   const char *text = "Close yourself. I mean it!";
/// </para>
/// <para>
///   gtk_init (&argc, &argv);
/// </para>
/// <para>
///   win = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   g_signal_connect (win,
///                     "delete-event",
///                     G_CALLBACK (gtk_true),
///                     NULL);
///   g_signal_connect (win, "destroy",
///                     G_CALLBACK (gtk_main_quit),
///                     NULL);
/// </para>
/// <para>
///   but = gtk_button_new_with_label (text);
///   g_signal_connect_swapped (but, "clicked",
///                             G_CALLBACK (gtk_object_destroy),
///                             win);
///   gtk_container_add (GTK_CONTAINER (win), but);
/// </para>
/// <para>
///   gtk_widget_show_all (win);
/// </para>
/// <para>
///   gtk_main ();
/// </para>
/// <para>
///   return 0;
/// }
/// ]|
/// </para>
/// </summary>

/// <return>
/// %TRUE
/// </return>

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
