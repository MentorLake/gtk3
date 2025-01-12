namespace MentorLake.Gtk3.Gtk3;

public class GtkStylePropertiesHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static GtkStylePropertiesHandle New()
	{
		return GtkStylePropertiesExterns.gtk_style_properties_new();
	}

	public static bool LookupProperty(string property_name, out GtkStylePropertyParser parse_func, out GParamSpecHandle pspec)
	{
		return GtkStylePropertiesExterns.gtk_style_properties_lookup_property(property_name, out parse_func, out pspec);
	}

	public static void RegisterProperty(GtkStylePropertyParser parse_func, GParamSpecHandle pspec)
	{
		GtkStylePropertiesExterns.gtk_style_properties_register_property(parse_func, pspec);
	}

}

public static class GtkStylePropertiesHandleExtensions
{
	public static GtkStylePropertiesHandle Clear(this GtkStylePropertiesHandle props)
	{
		GtkStylePropertiesExterns.gtk_style_properties_clear(props);
		return props;
	}

	public static GtkStylePropertiesHandle Get(this GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr @__arglist)
	{
		GtkStylePropertiesExterns.gtk_style_properties_get(props, state, @__arglist);
		return props;
	}

	public static bool GetProperty(this GtkStylePropertiesHandle props, string property, GtkStateFlags state, out GValue value)
	{
		return GtkStylePropertiesExterns.gtk_style_properties_get_property(props, property, state, out value);
	}

	public static GtkStylePropertiesHandle GetValist(this GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr args)
	{
		GtkStylePropertiesExterns.gtk_style_properties_get_valist(props, state, args);
		return props;
	}

	public static GtkSymbolicColorHandle LookupColor(this GtkStylePropertiesHandle props, string name)
	{
		return GtkStylePropertiesExterns.gtk_style_properties_lookup_color(props, name);
	}

	public static GtkStylePropertiesHandle MapColor(this GtkStylePropertiesHandle props, string name, GtkSymbolicColorHandle color)
	{
		GtkStylePropertiesExterns.gtk_style_properties_map_color(props, name, color);
		return props;
	}

	public static GtkStylePropertiesHandle Merge(this GtkStylePropertiesHandle props, GtkStylePropertiesHandle props_to_merge, bool replace)
	{
		GtkStylePropertiesExterns.gtk_style_properties_merge(props, props_to_merge, replace);
		return props;
	}

	public static GtkStylePropertiesHandle Set(this GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr @__arglist)
	{
		GtkStylePropertiesExterns.gtk_style_properties_set(props, state, @__arglist);
		return props;
	}

	public static GtkStylePropertiesHandle SetProperty(this GtkStylePropertiesHandle props, string property, GtkStateFlags state, GValueHandle value)
	{
		GtkStylePropertiesExterns.gtk_style_properties_set_property(props, property, state, value);
		return props;
	}

	public static GtkStylePropertiesHandle SetValist(this GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr args)
	{
		GtkStylePropertiesExterns.gtk_style_properties_set_valist(props, state, args);
		return props;
	}

	public static GtkStylePropertiesHandle UnsetProperty(this GtkStylePropertiesHandle props, string property, GtkStateFlags state)
	{
		GtkStylePropertiesExterns.gtk_style_properties_unset_property(props, property, state);
		return props;
	}

}

internal class GtkStylePropertiesExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStylePropertiesHandle gtk_style_properties_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_clear(GtkStylePropertiesHandle props);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_get(GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_properties_get_property(GtkStylePropertiesHandle props, string property, GtkStateFlags state, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_get_valist(GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr args);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSymbolicColorHandle gtk_style_properties_lookup_color(GtkStylePropertiesHandle props, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_map_color(GtkStylePropertiesHandle props, string name, GtkSymbolicColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_merge(GtkStylePropertiesHandle props, GtkStylePropertiesHandle props_to_merge, bool replace);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_set(GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_set_property(GtkStylePropertiesHandle props, string property, GtkStateFlags state, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_set_valist(GtkStylePropertiesHandle props, GtkStateFlags state, IntPtr args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_unset_property(GtkStylePropertiesHandle props, string property, GtkStateFlags state);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_properties_lookup_property(string property_name, out GtkStylePropertyParser parse_func, out GParamSpecHandle pspec);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_style_properties_register_property(GtkStylePropertyParser parse_func, GParamSpecHandle pspec);

}
