namespace MentorLake.Gtk;

public class GtkStylePropertiesHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static MentorLake.Gtk.GtkStylePropertiesHandle New()
	{
		return GtkStylePropertiesHandleExterns.gtk_style_properties_new();
	}

	public static bool LookupProperty(string property_name, out MentorLake.Gtk.GtkStylePropertyParser parse_func, out MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GtkStylePropertiesHandleExterns.gtk_style_properties_lookup_property(property_name, out parse_func, out pspec);
	}

	public static void RegisterProperty(MentorLake.Gtk.GtkStylePropertyParser parse_func, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_register_property(parse_func, pspec);
	}

}

public static class GtkStylePropertiesHandleExtensions
{
	public static T Clear<T>(this T props) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_clear(props);
		return props;
	}

	public static T Get<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_get(props, state, @__arglist);
		return props;
	}

	public static bool GetProperty(this MentorLake.Gtk.GtkStylePropertiesHandle props, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value)
	{
		return GtkStylePropertiesHandleExterns.gtk_style_properties_get_property(props, property, state, out value);
	}

	public static T GetValist<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_get_valist(props, state, args);
		return props;
	}

	public static MentorLake.Gtk.GtkSymbolicColorHandle LookupColor(this MentorLake.Gtk.GtkStylePropertiesHandle props, string name)
	{
		return GtkStylePropertiesHandleExterns.gtk_style_properties_lookup_color(props, name);
	}

	public static T MapColor<T>(this T props, string name, MentorLake.Gtk.GtkSymbolicColorHandle color) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_map_color(props, name, color);
		return props;
	}

	public static T Merge<T>(this T props, MentorLake.Gtk.GtkStylePropertiesHandle props_to_merge, bool replace) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_merge(props, props_to_merge, replace);
		return props;
	}

	public static T Set<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_set(props, state, @__arglist);
		return props;
	}

	public static T SetProperty<T>(this T props, string property, MentorLake.Gtk.GtkStateFlags state, MentorLake.GObject.GValueHandle value) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_set_property(props, property, state, value);
		return props;
	}

	public static T SetValist<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_set_valist(props, state, args);
		return props;
	}

	public static T UnsetProperty<T>(this T props, string property, MentorLake.Gtk.GtkStateFlags state) where T : GtkStylePropertiesHandle
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_unset_property(props, property, state);
		return props;
	}

}

internal class GtkStylePropertiesHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStylePropertiesHandle gtk_style_properties_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_properties_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, MentorLake.Gtk.GtkStateFlags state, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_style_properties_lookup_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_map_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_merge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props_to_merge, bool replace);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, string property, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, MentorLake.Gtk.GtkStateFlags state, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_unset_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, string property, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_properties_lookup_property(string property_name, out MentorLake.Gtk.GtkStylePropertyParser parse_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] out MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_properties_register_property(MentorLake.Gtk.GtkStylePropertyParser parse_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

}
