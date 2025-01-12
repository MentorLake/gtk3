namespace MentorLake.Gtk3.Gtk3;

public class GtkThemingEngineHandle : GObjectHandle
{
	public static GtkThemingEngineHandle Load(string name)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_load(name);
	}

	public static void RegisterProperty(string name_space, GtkStylePropertyParser parse_func, GParamSpecHandle pspec)
	{
		GtkThemingEngineExterns.gtk_theming_engine_register_property(name_space, parse_func, pspec);
	}

}

public static class GtkThemingEngineHandleExtensions
{
	public static T Get<T>(this T engine, GtkStateFlags state, IntPtr @__arglist) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get(engine, state, @__arglist);
		return engine;
	}

	public static T GetBackgroundColor<T>(this T engine, GtkStateFlags state, out GdkRGBA color) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_background_color(engine, state, out color);
		return engine;
	}

	public static T GetBorder<T>(this T engine, GtkStateFlags state, out GtkBorder border) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_border(engine, state, out border);
		return engine;
	}

	public static T GetBorderColor<T>(this T engine, GtkStateFlags state, out GdkRGBA color) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_border_color(engine, state, out color);
		return engine;
	}

	public static T GetColor<T>(this T engine, GtkStateFlags state, out GdkRGBA color) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_color(engine, state, out color);
		return engine;
	}

	public static GtkTextDirection GetDirection(this GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_get_direction(engine);
	}

	public static PangoFontDescriptionHandle GetFont(this GtkThemingEngineHandle engine, GtkStateFlags state)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_get_font(engine, state);
	}

	public static GtkJunctionSides GetJunctionSides(this GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_get_junction_sides(engine);
	}

	public static T GetMargin<T>(this T engine, GtkStateFlags state, out GtkBorder margin) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_margin(engine, state, out margin);
		return engine;
	}

	public static T GetPadding<T>(this T engine, GtkStateFlags state, out GtkBorder padding) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_padding(engine, state, out padding);
		return engine;
	}

	public static GtkWidgetPathHandle GetPath(this GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_get_path(engine);
	}

	public static T GetProperty<T>(this T engine, string property, GtkStateFlags state, out GValue value) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_property(engine, property, state, out value);
		return engine;
	}

	public static GdkScreenHandle GetScreen(this GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_get_screen(engine);
	}

	public static GtkStateFlags GetState(this GtkThemingEngineHandle engine)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_get_state(engine);
	}

	public static T GetStyle<T>(this T engine, IntPtr @__arglist) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_style(engine, @__arglist);
		return engine;
	}

	public static T GetStyleProperty<T>(this T engine, string property_name, out GValue value) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_style_property(engine, property_name, out value);
		return engine;
	}

	public static T GetStyleValist<T>(this T engine, IntPtr args) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_style_valist(engine, args);
		return engine;
	}

	public static T GetValist<T>(this T engine, GtkStateFlags state, IntPtr args) where T : GtkThemingEngineHandle
	{
		GtkThemingEngineExterns.gtk_theming_engine_get_valist(engine, state, args);
		return engine;
	}

	public static bool HasClass(this GtkThemingEngineHandle engine, string style_class)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_has_class(engine, style_class);
	}

	public static bool HasRegion(this GtkThemingEngineHandle engine, string style_region, out GtkRegionFlags flags)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_has_region(engine, style_region, out flags);
	}

	public static bool LookupColor(this GtkThemingEngineHandle engine, string color_name, out GdkRGBA color)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_lookup_color(engine, color_name, out color);
	}

	public static bool StateIsRunning(this GtkThemingEngineHandle engine, GtkStateType state, out double progress)
	{
		return GtkThemingEngineExterns.gtk_theming_engine_state_is_running(engine, state, out progress);
	}

}

internal class GtkThemingEngineExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get(GtkThemingEngineHandle engine, GtkStateFlags state, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_background_color(GtkThemingEngineHandle engine, GtkStateFlags state, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_border(GtkThemingEngineHandle engine, GtkStateFlags state, out GtkBorder border);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_border_color(GtkThemingEngineHandle engine, GtkStateFlags state, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_color(GtkThemingEngineHandle engine, GtkStateFlags state, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextDirection gtk_theming_engine_get_direction(GtkThemingEngineHandle engine);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontDescriptionHandle gtk_theming_engine_get_font(GtkThemingEngineHandle engine, GtkStateFlags state);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkJunctionSides gtk_theming_engine_get_junction_sides(GtkThemingEngineHandle engine);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_margin(GtkThemingEngineHandle engine, GtkStateFlags state, out GtkBorder margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_padding(GtkThemingEngineHandle engine, GtkStateFlags state, out GtkBorder padding);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_theming_engine_get_path(GtkThemingEngineHandle engine);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_property(GtkThemingEngineHandle engine, string property, GtkStateFlags state, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_theming_engine_get_screen(GtkThemingEngineHandle engine);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateFlags gtk_theming_engine_get_state(GtkThemingEngineHandle engine);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_style(GtkThemingEngineHandle engine, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_style_property(GtkThemingEngineHandle engine, string property_name, out GValue value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_style_valist(GtkThemingEngineHandle engine, IntPtr args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_get_valist(GtkThemingEngineHandle engine, GtkStateFlags state, IntPtr args);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_theming_engine_has_class(GtkThemingEngineHandle engine, string style_class);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_theming_engine_has_region(GtkThemingEngineHandle engine, string style_region, out GtkRegionFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_theming_engine_lookup_color(GtkThemingEngineHandle engine, string color_name, out GdkRGBA color);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_theming_engine_state_is_running(GtkThemingEngineHandle engine, GtkStateType state, out double progress);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkThemingEngineHandle gtk_theming_engine_load(string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_theming_engine_register_property(string name_space, GtkStylePropertyParser parse_func, GParamSpecHandle pspec);

}
