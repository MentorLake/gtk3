namespace MentorLake.Gtk;

public class GtkWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkWidgetClassExtensions
{
	public static void BindTemplateCallbackFull(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string callback_name, MentorLake.GObject.GCallback callback_symbol)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_bind_template_callback_full(widget_class, callback_name, callback_symbol);
	}

	public static void BindTemplateChildFull(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string name, bool internal_child, UIntPtr struct_offset)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_bind_template_child_full(widget_class, name, internal_child, struct_offset);
	}

	public static MentorLake.GObject.GParamSpecHandle FindStyleProperty(this MentorLake.Gtk.GtkWidgetClassHandle klass, string property_name)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		return GtkWidgetClassExterns.gtk_widget_class_find_style_property(klass, property_name);
	}

	public static string GetCssName(this MentorLake.Gtk.GtkWidgetClassHandle widget_class)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		return GtkWidgetClassExterns.gtk_widget_class_get_css_name(widget_class);
	}

	public static void InstallStyleProperty(this MentorLake.Gtk.GtkWidgetClassHandle klass, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_install_style_property(klass, pspec);
	}

	public static void InstallStylePropertyParser(this MentorLake.Gtk.GtkWidgetClassHandle klass, MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_install_style_property_parser(klass, pspec, parser);
	}

	public static MentorLake.GObject.GParamSpecHandle[] ListStyleProperties(this MentorLake.Gtk.GtkWidgetClassHandle klass, out uint n_properties)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		return GtkWidgetClassExterns.gtk_widget_class_list_style_properties(klass, out n_properties);
	}

	public static void SetAccessibleRole(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.Atk.AtkRole role)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_accessible_role(widget_class, role);
	}

	public static void SetAccessibleType(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.GObject.GType type)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_accessible_type(widget_class, type);
	}

	public static void SetConnectFunc(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.Gtk.GtkBuilderConnectFunc connect_func, IntPtr connect_data, MentorLake.GLib.GDestroyNotify connect_data_destroy)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_connect_func(widget_class, connect_func, connect_data, connect_data_destroy);
	}

	public static void SetCssName(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, string name)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_css_name(widget_class, name);
	}

	public static void SetTemplate(this MentorLake.Gtk.GtkWidgetClassHandle widget_class, MentorLake.GLib.GBytesHandle template_bytes)
	{
		if (widget_class.IsInvalid) throw new Exception("Invalid handle (GtkWidgetClass)");
		GtkWidgetClassExterns.gtk_widget_class_set_template(widget_class, template_bytes);
	}

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
	public GInitiallyUnownedClass parent_class;
	public uint activate_signal;
	public IntPtr dispatch_child_properties_changed;
	public IntPtr destroy;
	public IntPtr show;
	public IntPtr show_all;
	public IntPtr hide;
	public IntPtr map;
	public IntPtr unmap;
	public IntPtr realize;
	public IntPtr unrealize;
	public IntPtr size_allocate;
	public IntPtr state_changed;
	public IntPtr state_flags_changed;
	public IntPtr parent_set;
	public IntPtr hierarchy_changed;
	public IntPtr style_set;
	public IntPtr direction_changed;
	public IntPtr grab_notify;
	public IntPtr child_notify;
	public IntPtr draw;
	public IntPtr get_request_mode;
	public IntPtr get_preferred_height;
	public IntPtr get_preferred_width_for_height;
	public IntPtr get_preferred_width;
	public IntPtr get_preferred_height_for_width;
	public IntPtr mnemonic_activate;
	public IntPtr grab_focus;
	public IntPtr focus;
	public IntPtr move_focus;
	public IntPtr keynav_failed;
	public IntPtr @event;
	public IntPtr button_press_event;
	public IntPtr button_release_event;
	public IntPtr scroll_event;
	public IntPtr motion_notify_event;
	public IntPtr delete_event;
	public IntPtr destroy_event;
	public IntPtr key_press_event;
	public IntPtr key_release_event;
	public IntPtr enter_notify_event;
	public IntPtr leave_notify_event;
	public IntPtr configure_event;
	public IntPtr focus_in_event;
	public IntPtr focus_out_event;
	public IntPtr map_event;
	public IntPtr unmap_event;
	public IntPtr property_notify_event;
	public IntPtr selection_clear_event;
	public IntPtr selection_request_event;
	public IntPtr selection_notify_event;
	public IntPtr proximity_in_event;
	public IntPtr proximity_out_event;
	public IntPtr visibility_notify_event;
	public IntPtr window_state_event;
	public IntPtr damage_event;
	public IntPtr grab_broken_event;
	public IntPtr selection_get;
	public IntPtr selection_received;
	public IntPtr drag_begin;
	public IntPtr drag_end;
	public IntPtr drag_data_get;
	public IntPtr drag_data_delete;
	public IntPtr drag_leave;
	public IntPtr drag_motion;
	public IntPtr drag_drop;
	public IntPtr drag_data_received;
	public IntPtr drag_failed;
	public IntPtr popup_menu;
	public IntPtr show_help;
	public IntPtr get_accessible;
	public IntPtr screen_changed;
	public IntPtr can_activate_accel;
	public IntPtr composited_changed;
	public IntPtr query_tooltip;
	public IntPtr compute_expand;
	public IntPtr adjust_size_request;
	public IntPtr adjust_size_allocation;
	public IntPtr style_updated;
	public IntPtr touch_event;
	public IntPtr get_preferred_height_and_baseline_for_width;
	public IntPtr adjust_baseline_request;
	public IntPtr adjust_baseline_allocation;
	public IntPtr queue_draw_region;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
}
