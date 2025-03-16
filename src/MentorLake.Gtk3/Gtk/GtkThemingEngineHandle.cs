namespace MentorLake.Gtk;

public class GtkThemingEngineHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkThemingEngineHandle Load(string name)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_load(name);
	}

	public static void RegisterProperty(string name_space, MentorLake.Gtk.GtkStylePropertyParser parse_func, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_register_property(name_space, parse_func, pspec);
	}

}

public static class GtkThemingEngineHandleExtensions
{
	public static T Get<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get(engine, state, @__arglist);
		return engine;
	}

	public static T GetBackgroundColor<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_background_color(engine, state, out color);
		return engine;
	}

	public static T GetBorder<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_border(engine, state, out border);
		return engine;
	}

	public static T GetBorderColor<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_border_color(engine, state, out color);
		return engine;
	}

	public static T GetColor<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_color(engine, state, out color);
		return engine;
	}

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_direction(engine);
	}

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFont(this MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_font(engine, state);
	}

	public static MentorLake.Gtk.GtkJunctionSides GetJunctionSides(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_junction_sides(engine);
	}

	public static T GetMargin<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_margin(engine, state, out margin);
		return engine;
	}

	public static T GetPadding<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_padding(engine, state, out padding);
		return engine;
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPath(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_path(engine);
	}

	public static T GetProperty<T>(this T engine, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_property(engine, property, state, out value);
		return engine;
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_screen(engine);
	}

	public static MentorLake.Gtk.GtkStateFlags GetState(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_state(engine);
	}

	public static T GetStyle<T>(this T engine, IntPtr @__arglist) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_style(engine, @__arglist);
		return engine;
	}

	public static T GetStyleProperty<T>(this T engine, string property_name, out MentorLake.GObject.GValue value) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_style_property(engine, property_name, out value);
		return engine;
	}

	public static T GetStyleValist<T>(this T engine, IntPtr args) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_style_valist(engine, args);
		return engine;
	}

	public static T GetValist<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_valist(engine, state, args);
		return engine;
	}

	public static bool HasClass(this MentorLake.Gtk.GtkThemingEngineHandle engine, string style_class)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_has_class(engine, style_class);
	}

	public static bool HasRegion(this MentorLake.Gtk.GtkThemingEngineHandle engine, string style_region, out MentorLake.Gtk.GtkRegionFlags flags)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_has_region(engine, style_region, out flags);
	}

	public static bool LookupColor(this MentorLake.Gtk.GtkThemingEngineHandle engine, string color_name, out MentorLake.Gdk.GdkRGBA color)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_lookup_color(engine, color_name, out color);
	}

	public static bool StateIsRunning(this MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateType state, out double progress)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_state_is_running(engine, state, out progress);
	}

}

internal class GtkThemingEngineHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_border_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_theming_engine_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle gtk_theming_engine_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJunctionSides gtk_theming_engine_get_junction_sides([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_theming_engine_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_theming_engine_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_theming_engine_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_style_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_theming_engine_has_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, string style_class);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_theming_engine_has_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, string style_region, out MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_theming_engine_lookup_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, string color_name, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_theming_engine_state_is_running([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateType state, out double progress);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkThemingEngineHandle gtk_theming_engine_load(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_register_property(string name_space, MentorLake.Gtk.GtkStylePropertyParser parse_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

}
