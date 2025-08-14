namespace MentorLake.Gtk;


public class GtkWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkWidgetClassExtensions
{
/// <summary>
/// <para>
/// Declares a @callback_symbol to handle @callback_name from the template XML
/// defined for @widget_type. See gtk_builder_add_callback_symbol().
/// </para>
/// <para>
/// Note that this must be called from a composite widget classes class
/// initializer after calling gtk_widget_class_set_template().
/// </para>
/// </summary>

/// <param name="widget_class">
/// A #GtkWidgetClass
/// </param>
/// <param name="callback_name">
/// The name of the callback as expected in the template XML
/// </param>
/// <param name="callback_symbol">
/// The callback symbol
/// </param>

	public static void BindTemplateCallbackFull(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string callback_name, MentorLake.GObject.GCallback callback_symbol)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_bind_template_callback_full(widget_class, callback_name, callback_symbol);
	}

/// <summary>
/// <para>
/// Automatically assign an object declared in the class template XML to be set to a location
/// on a freshly built instance’s private data, or alternatively accessible via gtk_widget_get_template_child().
/// </para>
/// <para>
/// The struct can point either into the public instance, then you should use G_STRUCT_OFFSET(WidgetType, member)
/// for @struct_offset,  or in the private struct, then you should use G_PRIVATE_OFFSET(WidgetType, member).
/// </para>
/// <para>
/// An explicit strong reference will be held automatically for the duration of your
/// instance’s life cycle, it will be released automatically when #GObjectClass.dispose() runs
/// on your instance and if a @struct_offset that is != 0 is specified, then the automatic location
/// in your instance public or private data will be set to %NULL. You can however access an automated child
/// pointer the first time your classes #GObjectClass.dispose() runs, or alternatively in
/// #GtkWidgetClass.destroy().
/// </para>
/// <para>
/// If @internal_child is specified, #GtkBuildableIface.get_internal_child() will be automatically
/// implemented by the #GtkWidget class so there is no need to implement it manually.
/// </para>
/// <para>
/// The wrapper macros gtk_widget_class_bind_template_child(), gtk_widget_class_bind_template_child_internal(),
/// gtk_widget_class_bind_template_child_private() and gtk_widget_class_bind_template_child_internal_private()
/// might be more convenient to use.
/// </para>
/// <para>
/// Note that this must be called from a composite widget classes class
/// initializer after calling gtk_widget_class_set_template().
/// </para>
/// </summary>

/// <param name="widget_class">
/// A #GtkWidgetClass
/// </param>
/// <param name="name">
/// The “id” of the child defined in the template XML
/// </param>
/// <param name="internal_child">
/// Whether the child should be accessible as an “internal-child”
///                  when this class is used in GtkBuilder XML
/// </param>
/// <param name="struct_offset">
/// The structure offset into the composite widget’s instance public or private structure
///                 where the automated child pointer should be set, or 0 to not assign the pointer.
/// </param>

	public static void BindTemplateChildFull(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string name, bool internal_child, UIntPtr struct_offset)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_bind_template_child_full(widget_class, name, internal_child, struct_offset);
	}

/// <summary>
/// <para>
/// Finds a style property of a widget class by name.
/// </para>
/// </summary>

/// <param name="klass">
/// a #GtkWidgetClass
/// </param>
/// <param name="property_name">
/// the name of the style property to find
/// </param>
/// <return>
/// the #GParamSpec of the style property or
///   %NULL if @class has no style property with that name.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle FindStyleProperty(this MentorLake.Gtk.GtkWidgetClassHandle klass, string property_name)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		return GtkWidgetClassExterns.gtk_widget_class_find_style_property(klass, property_name);
	}

/// <summary>
/// <para>
/// Gets the name used by this class for matching in CSS code. See
/// gtk_widget_class_set_css_name() for details.
/// </para>
/// </summary>

/// <param name="widget_class">
/// class to set the name on
/// </param>
/// <return>
/// the CSS name of the given class
/// </return>

	public static string GetCssName(this MentorLake.Gtk.GtkWidgetClassHandle widget_class)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		return GtkWidgetClassExterns.gtk_widget_class_get_css_name(widget_class);
	}

/// <summary>
/// <para>
/// Installs a style property on a widget class. The parser for the
/// style property is determined by the value type of @pspec.
/// </para>
/// </summary>

/// <param name="klass">
/// a #GtkWidgetClass
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the property
/// </param>

	public static void InstallStyleProperty(this MentorLake.Gtk.GtkWidgetClassHandle klass, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_install_style_property(klass, pspec);
	}

/// <summary>
/// <para>
/// Installs a style property on a widget class.
/// </para>
/// </summary>

/// <param name="klass">
/// a #GtkWidgetClass
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the style property
/// </param>
/// <param name="parser">
/// the parser for the style property
/// </param>

	public static void InstallStylePropertyParser(this MentorLake.Gtk.GtkWidgetClassHandle klass, MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_install_style_property_parser(klass, pspec, parser);
	}

/// <summary>
/// <para>
/// Returns all style properties of a widget class.
/// </para>
/// </summary>

/// <param name="klass">
/// a #GtkWidgetClass
/// </param>
/// <param name="n_properties">
/// location to return the number of style properties found
/// </param>
/// <return>
/// a
///     newly allocated array of #GParamSpec*. The array must be
///     freed with g_free().
/// </return>

	public static MentorLake.GObject.GParamSpecHandle[] ListStyleProperties(this MentorLake.Gtk.GtkWidgetClassHandle klass, out uint n_properties)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		return GtkWidgetClassExterns.gtk_widget_class_list_style_properties(klass, out n_properties);
	}

/// <summary>
/// <para>
/// Sets the default #AtkRole to be set on accessibles created for
/// widgets of @widget_class. Accessibles may decide to not honor this
/// setting if their role reporting is more refined. Calls to
/// gtk_widget_class_set_accessible_type() will reset this value.
/// </para>
/// <para>
/// In cases where you want more fine-grained control over the role of
/// accessibles created for @widget_class, you should provide your own
/// accessible type and use gtk_widget_class_set_accessible_type()
/// instead.
/// </para>
/// <para>
/// If @role is #ATK_ROLE_INVALID, the default role will not be changed
/// and the accessible’s default role will be used instead.
/// </para>
/// <para>
/// This function should only be called from class init functions of widgets.
/// </para>
/// </summary>

/// <param name="widget_class">
/// class to set the accessible role for
/// </param>
/// <param name="role">
/// The role to use for accessibles created for @widget_class
/// </param>

	public static void SetAccessibleRole(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.Atk.AtkRole role)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_accessible_role(widget_class, role);
	}

/// <summary>
/// <para>
/// Sets the type to be used for creating accessibles for widgets of
/// @widget_class. The given @type must be a subtype of the type used for
/// accessibles of the parent class.
/// </para>
/// <para>
/// This function should only be called from class init functions of widgets.
/// </para>
/// </summary>

/// <param name="widget_class">
/// class to set the accessible type for
/// </param>
/// <param name="type">
/// The object type that implements the accessible for @widget_class
/// </param>

	public static void SetAccessibleType(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.GObject.GType type)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_accessible_type(widget_class, type);
	}

/// <summary>
/// <para>
/// For use in language bindings, this will override the default #GtkBuilderConnectFunc to be
/// used when parsing GtkBuilder XML from this class’s template data.
/// </para>
/// <para>
/// Note that this must be called from a composite widget classes class
/// initializer after calling gtk_widget_class_set_template().
/// </para>
/// </summary>

/// <param name="widget_class">
/// A #GtkWidgetClass
/// </param>
/// <param name="connect_func">
/// The #GtkBuilderConnectFunc to use when connecting signals in the class template
/// </param>
/// <param name="connect_data">
/// The data to pass to @connect_func
/// </param>
/// <param name="connect_data_destroy">
/// The #GDestroyNotify to free @connect_data, this will only be used at
///                        class finalization time, when no classes of type @widget_type are in use anymore.
/// </param>

	public static void SetConnectFunc(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.Gtk.GtkBuilderConnectFunc connect_func, IntPtr connect_data, MentorLake.GLib.GDestroyNotify connect_data_destroy)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_connect_func(widget_class, connect_func, connect_data, connect_data_destroy);
	}

/// <summary>
/// <para>
/// Sets the name to be used for CSS matching of widgets.
/// </para>
/// <para>
/// If this function is not called for a given class, the name
/// of the parent class is used.
/// </para>
/// </summary>

/// <param name="widget_class">
/// class to set the name on
/// </param>
/// <param name="name">
/// name to use
/// </param>

	public static void SetCssName(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string name)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_css_name(widget_class, name);
	}

/// <summary>
/// <para>
/// This should be called at class initialization time to specify
/// the GtkBuilder XML to be used to extend a widget.
/// </para>
/// <para>
/// For convenience, gtk_widget_class_set_template_from_resource() is also provided.
/// </para>
/// <para>
/// Note that any class that installs templates must call gtk_widget_init_template()
/// in the widget’s instance initializer.
/// </para>
/// </summary>

/// <param name="widget_class">
/// A #GtkWidgetClass
/// </param>
/// <param name="template_bytes">
/// A #GBytes holding the #GtkBuilder XML
/// </param>

	public static void SetTemplate(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.GLib.GBytesHandle template_bytes)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_template(widget_class, template_bytes);
	}

/// <summary>
/// <para>
/// A convenience function to call gtk_widget_class_set_template().
/// </para>
/// <para>
/// Note that any class that installs templates must call gtk_widget_init_template()
/// in the widget’s instance initializer.
/// </para>
/// </summary>

/// <param name="widget_class">
/// A #GtkWidgetClass
/// </param>
/// <param name="resource_name">
/// The name of the resource to load the template from
/// </param>

	public static void SetTemplateFromResource(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string resource_name)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_template_from_resource(widget_class, resource_name);
	}


	public static GtkWidgetClass Dereference(this GtkWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetClass>(x.DangerousGetHandle());
}
internal class GtkWidgetClassExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_bind_template_callback_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, string callback_name, MentorLake.GObject.GCallback callback_symbol);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_bind_template_child_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, string name, bool internal_child, UIntPtr struct_offset);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle gtk_widget_class_find_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle klass, string property_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_class_get_css_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_install_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle klass, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_install_style_property_parser([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle klass, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] gtk_widget_class_list_style_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle klass, out uint n_properties);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_set_accessible_role([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.Atk.AtkRole role);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_set_accessible_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_set_connect_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.Gtk.GtkBuilderConnectFunc connect_func, IntPtr connect_data, MentorLake.GLib.GDestroyNotify connect_data_destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_set_css_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_set_template([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle template_bytes);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_set_template_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetClassHandle>))] MentorLake.Gtk.GtkWidgetClassHandle widget_class, string resource_name);

}


public struct GtkWidgetClass
{
	/// <summary>
/// <para>
/// The object class structure needs to be the first
///   element in the widget class structure in order for the class mechanism
///   to work correctly. This allows a GtkWidgetClass pointer to be cast to
///   a GObjectClass pointer.
/// </para>
/// </summary>

public GInitiallyUnownedClass parent_class;
	/// <summary>
/// <para>
/// The signal to emit when a widget of this class is
///   activated, gtk_widget_activate() handles the emission.
///   Implementation of this signal is optional.
/// </para>
/// </summary>

public uint activate_signal;
	/// <summary>
/// <para>
/// Seldomly overidden.
/// </para>
/// </summary>

public IntPtr dispatch_child_properties_changed;
	/// <summary>
/// <para>
/// Signals that all holders of a reference to the widget
///   should release the reference that they hold.
/// </para>
/// </summary>

public IntPtr destroy;
	/// <summary>
/// <para>
/// Signal emitted when widget is shown
/// </para>
/// </summary>

public IntPtr show;
	/// <summary>
/// <para>
/// Recursively shows a widget, and any child widgets (if the widget is
/// a container).
/// </para>
/// </summary>

public IntPtr show_all;
	/// <summary>
/// <para>
/// Signal emitted when widget is hidden.
/// </para>
/// </summary>

public IntPtr hide;
	/// <summary>
/// <para>
/// Signal emitted when widget is going to be mapped, that is
///   when the widget is visible (which is controlled with
///   gtk_widget_set_visible()) and all its parents up to the toplevel
///   widget are also visible.
/// </para>
/// </summary>

public IntPtr map;
	/// <summary>
/// <para>
/// Signal emitted when widget is going to be unmapped, which
///   means that either it or any of its parents up to the toplevel
///   widget have been set as hidden.
/// </para>
/// </summary>

public IntPtr unmap;
	/// <summary>
/// <para>
/// Signal emitted when widget is associated with a
///   #GdkWindow, which means that gtk_widget_realize() has been called or
///   the widget has been mapped (that is, it is going to be drawn).
/// </para>
/// </summary>

public IntPtr realize;
	/// <summary>
/// <para>
/// Signal emitted when the GdkWindow associated with
///   widget is destroyed, which means that gtk_widget_unrealize() has
///   been called or the widget has been unmapped (that is, it is going
///   to be hidden).
/// </para>
/// </summary>

public IntPtr unrealize;
	/// <summary>
/// <para>
/// Signal emitted to get the widget allocation.
/// </para>
/// </summary>

public IntPtr size_allocate;
	/// <summary>
/// <para>
/// Signal emitted when the widget state
///   changes. Deprecated: 3.0
/// </para>
/// </summary>

public IntPtr state_changed;
	/// <summary>
/// <para>
/// Signal emitted when the widget state changes,
///   see gtk_widget_get_state_flags().
/// </para>
/// </summary>

public IntPtr state_flags_changed;
	/// <summary>
/// <para>
/// Signal emitted when a new parent has been set on a
///   widget.
/// </para>
/// </summary>

public IntPtr parent_set;
	/// <summary>
/// <para>
/// Signal emitted when the anchored state of a
///   widget changes.
/// </para>
/// </summary>

public IntPtr hierarchy_changed;
	/// <summary>
/// <para>
/// Signal emitted when a new style has been set on a
/// widget. Deprecated: 3.0
/// </para>
/// </summary>

public IntPtr style_set;
	/// <summary>
/// <para>
/// Signal emitted when the text direction of a
///   widget changes.
/// </para>
/// </summary>

public IntPtr direction_changed;
	/// <summary>
/// <para>
/// Signal emitted when a widget becomes shadowed by a
///   GTK+ grab (not a pointer or keyboard grab) on another widget, or
///   when it becomes unshadowed due to a grab being removed.
/// </para>
/// </summary>

public IntPtr grab_notify;
	/// <summary>
/// <para>
/// Signal emitted for each child property that has
///   changed on an object.
/// </para>
/// </summary>

public IntPtr child_notify;
	/// <summary>
/// <para>
/// Signal emitted when a widget is supposed to render itself.
/// </para>
/// </summary>

public IntPtr draw;
	/// <summary>
/// <para>
/// This allows a widget to tell its parent container whether
///   it prefers to be allocated in %GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH or
///   %GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT mode.
///   %GTK_SIZE_REQUEST_HEIGHT_FOR_WIDTH means the widget prefers to have
///   #GtkWidgetClass.get_preferred_width() called and then
///   #GtkWidgetClass.get_preferred_height_for_width().
///   %GTK_SIZE_REQUEST_CONSTANT_SIZE disables any height-for-width or
///   width-for-height geometry management for a said widget and is the
///   default return.
///   It’s important to note (as described below) that any widget
///   which trades height-for-width or width-for-height must respond properly
///   to both of the virtual methods #GtkWidgetClass.get_preferred_height_for_width()
///   and #GtkWidgetClass.get_preferred_width_for_height() since it might be
///   queried in either #GtkSizeRequestMode by its parent container.
/// </para>
/// </summary>

public IntPtr get_request_mode;
	/// <summary>
/// <para>
/// This is called by containers to obtain the minimum
///   and natural height of a widget. A widget that does not actually trade
///   any height for width or width for height only has to implement these
///   two virtual methods (#GtkWidgetClass.get_preferred_width() and
///   #GtkWidgetClass.get_preferred_height()).
/// </para>
/// </summary>

public IntPtr get_preferred_height;
	/// <summary>
/// <para>
/// This is analogous to
///   #GtkWidgetClass.get_preferred_height_for_width() except that it
///   operates in the oposite orientation. It’s rare that a widget actually
///   does %GTK_SIZE_REQUEST_WIDTH_FOR_HEIGHT requests but this can happen
///   when, for example, a widget or container gets additional columns to
///   compensate for a smaller allocated height.
/// </para>
/// </summary>

public IntPtr get_preferred_width_for_height;
	/// <summary>
/// <para>
/// This is called by containers to obtain the minimum
///   and natural width of a widget. A widget will never be allocated a width
///   less than its minimum and will only ever be allocated a width greater
///   than the natural width once all of the said widget’s siblings have
///   received their natural widths.
///   Furthermore, a widget will only ever be allocated a width greater than
///   its natural width if it was configured to receive extra expand space
///   from its parent container.
/// </para>
/// </summary>

public IntPtr get_preferred_width;
	/// <summary>
/// <para>
/// This is similar to
///   #GtkWidgetClass.get_preferred_height() except that it is passed a
///   contextual width to request height for. By implementing this virtual
///   method it is possible for a #GtkLabel to tell its parent how much height
///   would be required if the label were to be allocated a said width.
/// </para>
/// </summary>

public IntPtr get_preferred_height_for_width;
	/// <summary>
/// <para>
/// Activates the @widget if @group_cycling is
///   %FALSE, and just grabs the focus if @group_cycling is %TRUE.
/// </para>
/// </summary>

public IntPtr mnemonic_activate;
	/// <summary>
/// <para>
/// Causes @widget to have the keyboard focus for the
///   #GtkWindow it’s inside.
/// </para>
/// </summary>

public IntPtr grab_focus;
	
public IntPtr focus;
	/// <summary>
/// <para>
/// Signal emitted when a change of focus is requested
/// </para>
/// </summary>

public IntPtr move_focus;
	/// <summary>
/// <para>
/// Signal emitted if keyboard navigation fails.
/// </para>
/// </summary>

public IntPtr keynav_failed;
	/// <summary>
/// <para>
/// The GTK+ main loop will emit three signals for each GDK
///   event delivered to a widget: one generic ::event signal, another,
///   more specific, signal that matches the type of event delivered
///   (e.g. "key-press-event") and finally a generic "event-after"
///   signal.
/// </para>
/// </summary>

public IntPtr @event;
	/// <summary>
/// <para>
/// Signal will be emitted when a button
///   (typically from a mouse) is pressed.
/// </para>
/// </summary>

public IntPtr button_press_event;
	/// <summary>
/// <para>
/// Signal will be emitted when a button
///   (typically from a mouse) is released.
/// </para>
/// </summary>

public IntPtr button_release_event;
	/// <summary>
/// <para>
/// Signal emitted when a button in the 4 to 7 range is
///   pressed.
/// </para>
/// </summary>

public IntPtr scroll_event;
	/// <summary>
/// <para>
/// Signal emitted when the pointer moves over
///   the widget’s #GdkWindow.
/// </para>
/// </summary>

public IntPtr motion_notify_event;
	/// <summary>
/// <para>
/// Signal emitted if a user requests that a toplevel
///   window is closed.
/// </para>
/// </summary>

public IntPtr delete_event;
	/// <summary>
/// <para>
/// Signal is emitted when a #GdkWindow is destroyed.
/// </para>
/// </summary>

public IntPtr destroy_event;
	/// <summary>
/// <para>
/// Signal emitted when a key is pressed.
/// </para>
/// </summary>

public IntPtr key_press_event;
	/// <summary>
/// <para>
/// Signal is emitted when a key is released.
/// </para>
/// </summary>

public IntPtr key_release_event;
	/// <summary>
/// <para>
/// Signal event will be emitted when the pointer
///   enters the widget’s window.
/// </para>
/// </summary>

public IntPtr enter_notify_event;
	/// <summary>
/// <para>
/// Will be emitted when the pointer leaves the
///   widget’s window.
/// </para>
/// </summary>

public IntPtr leave_notify_event;
	/// <summary>
/// <para>
/// Signal will be emitted when the size, position or
///   stacking of the widget’s window has changed.
/// </para>
/// </summary>

public IntPtr configure_event;
	/// <summary>
/// <para>
/// Signal emitted when the keyboard focus enters the
/// widget’s window.
/// </para>
/// </summary>

public IntPtr focus_in_event;
	/// <summary>
/// <para>
/// Signal emitted when the keyboard focus leaves the
/// widget’s window.
/// </para>
/// </summary>

public IntPtr focus_out_event;
	/// <summary>
/// <para>
/// Signal emitted when the widget’s window is mapped.
/// </para>
/// </summary>

public IntPtr map_event;
	/// <summary>
/// <para>
/// Signal will be emitted when the widget’s window is
///   unmapped.
/// </para>
/// </summary>

public IntPtr unmap_event;
	/// <summary>
/// <para>
/// Signal will be emitted when a property on
///   the widget’s window has been changed or deleted.
/// </para>
/// </summary>

public IntPtr property_notify_event;
	/// <summary>
/// <para>
/// Signal will be emitted when the the
///   widget’s window has lost ownership of a selection.
/// </para>
/// </summary>

public IntPtr selection_clear_event;
	/// <summary>
/// <para>
/// Signal will be emitted when another
///   client requests ownership of the selection owned by the widget's
///   window.
/// </para>
/// </summary>

public IntPtr selection_request_event;
	
public IntPtr selection_notify_event;
	
public IntPtr proximity_in_event;
	
public IntPtr proximity_out_event;
	/// <summary>
/// <para>
/// Signal emitted when the widget’s window is
///   obscured or unobscured.
/// </para>
/// </summary>

public IntPtr visibility_notify_event;
	/// <summary>
/// <para>
/// Signal emitted when the state of the toplevel
///   window associated to the widget changes.
/// </para>
/// </summary>

public IntPtr window_state_event;
	/// <summary>
/// <para>
/// Signal emitted when a redirected window belonging to
///   widget gets drawn into.
/// </para>
/// </summary>

public IntPtr damage_event;
	/// <summary>
/// <para>
/// Signal emitted when a pointer or keyboard grab
///   on a window belonging to widget gets broken.
/// </para>
/// </summary>

public IntPtr grab_broken_event;
	
public IntPtr selection_get;
	
public IntPtr selection_received;
	/// <summary>
/// <para>
/// Signal emitted on the drag source when a drag is
///   started.
/// </para>
/// </summary>

public IntPtr drag_begin;
	/// <summary>
/// <para>
/// Signal emitted on the drag source when a drag is
///   finished.
/// </para>
/// </summary>

public IntPtr drag_end;
	/// <summary>
/// <para>
/// Signal emitted on the drag source when the drop
///   site requests the data which is dragged.
/// </para>
/// </summary>

public IntPtr drag_data_get;
	/// <summary>
/// <para>
/// Signal emitted on the drag source when a drag
///   with the action %GDK_ACTION_MOVE is successfully completed.
/// </para>
/// </summary>

public IntPtr drag_data_delete;
	/// <summary>
/// <para>
/// Signal emitted on the drop site when the cursor leaves
///   the widget.
/// </para>
/// </summary>

public IntPtr drag_leave;
	/// <summary>
/// <para>
/// signal emitted on the drop site when the user moves
///   the cursor over the widget during a drag.
/// </para>
/// </summary>

public IntPtr drag_motion;
	/// <summary>
/// <para>
/// Signal emitted on the drop site when the user drops the
///   data onto the widget.
/// </para>
/// </summary>

public IntPtr drag_drop;
	/// <summary>
/// <para>
/// Signal emitted on the drop site when the
///   dragged data has been received.
/// </para>
/// </summary>

public IntPtr drag_data_received;
	/// <summary>
/// <para>
/// Signal emitted on the drag source when a drag has
///   failed.
/// </para>
/// </summary>

public IntPtr drag_failed;
	/// <summary>
/// <para>
/// Signal emitted whenever a widget should pop up a
///   context menu.
/// </para>
/// </summary>

public IntPtr popup_menu;
	
public IntPtr show_help;
	/// <summary>
/// <para>
/// Returns the accessible object that describes the
///   widget to an assistive technology.
/// </para>
/// </summary>

public IntPtr get_accessible;
	/// <summary>
/// <para>
/// Signal emitted when the screen of a widget has
///   changed.
/// </para>
/// </summary>

public IntPtr screen_changed;
	/// <summary>
/// <para>
/// Signal allows applications and derived widgets
///   to override the default GtkWidget handling for determining whether
///   an accelerator can be activated.
/// </para>
/// </summary>

public IntPtr can_activate_accel;
	/// <summary>
/// <para>
/// Signal emitted when the composited status of
///   widgets screen changes. See gdk_screen_is_composited().
/// </para>
/// </summary>

public IntPtr composited_changed;
	/// <summary>
/// <para>
/// Signal emitted when “has-tooltip” is %TRUE and the
///   hover timeout has expired with the cursor hovering “above”
///   widget; or emitted when widget got focus in keyboard mode.
/// </para>
/// </summary>

public IntPtr query_tooltip;
	/// <summary>
/// <para>
/// Computes whether a container should give this
///   widget extra space when possible.
/// </para>
/// </summary>

public IntPtr compute_expand;
	/// <summary>
/// <para>
/// Convert an initial size request from a widget's
///   #GtkSizeRequestMode virtual method implementations into a size request to
///   be used by parent containers in laying out the widget.
///   adjust_size_request adjusts from a child widget's
///   original request to what a parent container should
///   use for layout. The @for_size argument will be -1 if the request should
///   not be for a particular size in the opposing orientation, i.e. if the
///   request is not height-for-width or width-for-height. If @for_size is
///   greater than -1, it is the proposed allocation in the opposing
///   orientation that we need the request for. Implementations of
///   adjust_size_request should chain up to the default implementation,
///   which applies #GtkWidget’s margin properties and imposes any values
///   from gtk_widget_set_size_request(). Chaining up should be last,
///   after your subclass adjusts the request, so
///   #GtkWidget can apply constraints and add the margin properly.
/// </para>
/// </summary>

public IntPtr adjust_size_request;
	/// <summary>
/// <para>
/// Convert an initial size allocation assigned
///   by a #GtkContainer using gtk_widget_size_allocate(), into an actual
///   size allocation to be used by the widget. adjust_size_allocation
///   adjusts to a child widget’s actual allocation
///   from what a parent container computed for the
///   child. The adjusted allocation must be entirely within the original
///   allocation. In any custom implementation, chain up to the default
///   #GtkWidget implementation of this method, which applies the margin
///   and alignment properties of #GtkWidget. Chain up
///   before performing your own adjustments so your
///   own adjustments remove more allocation after the #GtkWidget base
///   class has already removed margin and alignment. The natural size
///   passed in should be adjusted in the same way as the allocated size,
///   which allows adjustments to perform alignments or other changes
///   based on natural size.
/// </para>
/// </summary>

public IntPtr adjust_size_allocation;
	/// <summary>
/// <para>
/// Signal emitted when the GtkStyleContext of a widget
///   is changed.
/// </para>
/// </summary>

public IntPtr style_updated;
	/// <summary>
/// <para>
/// Signal emitted when a touch event happens
/// </para>
/// </summary>

public IntPtr touch_event;
	
public IntPtr get_preferred_height_and_baseline_for_width;
	
public IntPtr adjust_baseline_request;
	
public IntPtr adjust_baseline_allocation;
	/// <summary>
/// <para>
/// Invalidates the area of widget defined by
///   region by calling gdk_window_invalidate_region() on the widget's
///   window and all its child windows.
/// </para>
/// </summary>

public IntPtr queue_draw_region;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
}
