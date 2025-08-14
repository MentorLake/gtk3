namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkThemingEngine was the object used for rendering themed content
/// in GTK+ widgets. It used to allow overriding GTK+'s default
/// implementation of rendering functions by allowing engines to be
/// loaded as modules.
/// </para>
/// <para>
/// #GtkThemingEngine has been deprecated in GTK+ 3.14 and will be
/// ignored for rendering. The advancements in CSS theming are good
/// enough to allow themers to achieve their goals without the need
/// to modify source code.
/// </para>
/// </summary>

public class GtkThemingEngineHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Loads and initializes a theming engine module from the
/// standard directories.
/// </para>
/// </summary>

/// <param name="name">
/// Theme engine name to load
/// </param>
/// <return>
/// A theming engine, or %NULL if
/// the engine @name doesn’t exist.
/// </return>

	public static MentorLake.Gtk.GtkThemingEngineHandle Load(string name)
	{
		return GtkThemingEngineHandleExterns.gtk_theming_engine_load(name);
	}

/// <summary>
/// <para>
/// Registers a property so it can be used in the CSS file format,
/// on the CSS file the property will look like
/// "-${@name_space}-${property_name}". being
/// ${property_name} the given to @pspec. @name_space will usually
/// be the theme engine name.
/// </para>
/// <para>
/// For any type a @parse_func may be provided, being this function
/// used for turning any property value (between “:” and “;”) in
/// CSS to the #GValue needed. For basic types there is already
/// builtin parsing support, so %NULL may be provided for these
/// cases.
/// </para>
/// <para>
/// Engines must ensure property registration happens exactly once,
/// usually GTK+ deals with theming engines as singletons, so this
/// should be guaranteed to happen once, but bear this in mind
/// when creating #GtkThemeEngines yourself.
/// </para>
/// <para>
/// In order to make use of the custom registered properties in
/// the CSS file, make sure the engine is loaded first by specifying
/// the engine property, either in a previous rule or within the same
/// one.
/// |[
/// * {
///     engine: someengine;
///     -SomeEngine-custom-property: 2;
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="name_space">
/// namespace for the property name
/// </param>
/// <param name="parse_func">
/// parsing function to use, or %NULL
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the new property
/// </param>

	public static void RegisterProperty(string name_space, MentorLake.Gtk.GtkStylePropertyParser parse_func, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GtkThemingEngineHandleExterns.gtk_theming_engine_register_property(name_space, parse_func, pspec);
	}

}

public static class GtkThemingEngineHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves several style property values that apply to the currently
/// rendered element.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve values for
/// </param>
/// <param name="@__arglist">
/// property name /return value pairs, followed by %NULL
/// </param>

	public static T Get<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get(engine, state, @__arglist);
		return engine;
	}

/// <summary>
/// <para>
/// Gets the background color for a given state.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the color for
/// </param>
/// <param name="color">
/// return value for the background color
/// </param>

	public static T GetBackgroundColor<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_background_color(engine, state, out color);
		return engine;
	}

/// <summary>
/// <para>
/// Gets the border for a given state as a #GtkBorder.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the border for
/// </param>
/// <param name="border">
/// return value for the border settings
/// </param>

	public static T GetBorder<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_border(engine, state, out border);
		return engine;
	}

/// <summary>
/// <para>
/// Gets the border color for a given state.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the color for
/// </param>
/// <param name="color">
/// return value for the border color
/// </param>

	public static T GetBorderColor<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_border_color(engine, state, out color);
		return engine;
	}

/// <summary>
/// <para>
/// Gets the foreground color for a given state.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the color for
/// </param>
/// <param name="color">
/// return value for the foreground color
/// </param>

	public static T GetColor<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_color(engine, state, out color);
		return engine;
	}

/// <summary>
/// <para>
/// Returns the widget direction used for rendering.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <return>
/// the widget direction
/// </return>

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_direction(engine);
	}

/// <summary>
/// <para>
/// Returns the font description for a given state.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the font for
/// </param>
/// <return>
/// the #PangoFontDescription for the given
///          state. This object is owned by GTK+ and should not be
///          freed.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFont(this MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_font(engine, state);
	}

/// <summary>
/// <para>
/// Returns the widget direction used for rendering.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <return>
/// the widget direction
/// </return>

	public static MentorLake.Gtk.GtkJunctionSides GetJunctionSides(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_junction_sides(engine);
	}

/// <summary>
/// <para>
/// Gets the margin for a given state as a #GtkBorder.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the border for
/// </param>
/// <param name="margin">
/// return value for the margin settings
/// </param>

	public static T GetMargin<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_margin(engine, state, out margin);
		return engine;
	}

/// <summary>
/// <para>
/// Gets the padding for a given state as a #GtkBorder.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve the padding for
/// </param>
/// <param name="padding">
/// return value for the padding settings
/// </param>

	public static T GetPadding<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_padding(engine, state, out padding);
		return engine;
	}

/// <summary>
/// <para>
/// Returns the widget path used for style matching.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <return>
/// A #GtkWidgetPath
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPath(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_path(engine);
	}

/// <summary>
/// <para>
/// Gets a property value as retrieved from the style settings that apply
/// to the currently rendered element.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="property">
/// the property name
/// </param>
/// <param name="state">
/// state to retrieve the value for
/// </param>
/// <param name="value">
/// return location for the property value,
///         you must free this memory using g_value_unset() once you are
///         done with it.
/// </param>

	public static T GetProperty<T>(this T engine, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_property(engine, property, state, out value);
		return engine;
	}

/// <summary>
/// <para>
/// Returns the #GdkScreen to which @engine currently rendering to.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <return>
/// a #GdkScreen, or %NULL.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_screen(engine);
	}

/// <summary>
/// <para>
/// returns the state used when rendering.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <return>
/// the state flags
/// </return>

	public static MentorLake.Gtk.GtkStateFlags GetState(this MentorLake.Gtk.GtkThemingEngineHandle engine)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_get_state(engine);
	}

/// <summary>
/// <para>
/// Retrieves several widget style properties from @engine according
/// to the currently rendered content’s style.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="@__arglist">
/// property name /return value pairs, followed by %NULL
/// </param>

	public static T GetStyle<T>(this T engine, IntPtr @__arglist) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_style(engine, @__arglist);
		return engine;
	}

/// <summary>
/// <para>
/// Gets the value for a widget style property.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="property_name">
/// the name of the widget style property
/// </param>
/// <param name="value">
/// Return location for the property value, free with
///         g_value_unset() after use.
/// </param>

	public static T GetStyleProperty<T>(this T engine, string property_name, out MentorLake.GObject.GValue value) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_style_property(engine, property_name, out value);
		return engine;
	}

/// <summary>
/// <para>
/// Retrieves several widget style properties from @engine according to the
/// currently rendered content’s style.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="args">
/// va_list of property name/return location pairs, followed by %NULL
/// </param>

	public static T GetStyleValist<T>(this T engine, IntPtr args) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_style_valist(engine, args);
		return engine;
	}

/// <summary>
/// <para>
/// Retrieves several style property values that apply to the currently
/// rendered element.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// state to retrieve values for
/// </param>
/// <param name="args">
/// va_list of property name/return location pairs, followed by %NULL
/// </param>

	public static T GetValist<T>(this T engine, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkThemingEngineHandle
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		GtkThemingEngineHandleExterns.gtk_theming_engine_get_valist(engine, state, args);
		return engine;
	}

/// <summary>
/// <para>
/// Returns %TRUE if the currently rendered contents have
/// defined the given class name.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="style_class">
/// class name to look up
/// </param>
/// <return>
/// %TRUE if @engine has @class_name defined
/// </return>

	public static bool HasClass(this MentorLake.Gtk.GtkThemingEngineHandle engine, string style_class)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_has_class(engine, style_class);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the currently rendered contents have the
/// region defined. If @flags_return is not %NULL, it is set
/// to the flags affecting the region.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="style_region">
/// a region name
/// </param>
/// <param name="flags">
/// return location for region flags
/// </param>
/// <return>
/// %TRUE if region is defined
/// </return>

	public static bool HasRegion(this MentorLake.Gtk.GtkThemingEngineHandle engine, string style_region, out MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_has_region(engine, style_region, out flags);
	}

/// <summary>
/// <para>
/// Looks up and resolves a color name in the current style’s color map.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="color_name">
/// color name to lookup
/// </param>
/// <param name="color">
/// Return location for the looked up color
/// </param>
/// <return>
/// %TRUE if @color_name was found and resolved, %FALSE otherwise
/// </return>

	public static bool LookupColor(this MentorLake.Gtk.GtkThemingEngineHandle engine, string color_name, out MentorLake.Gdk.GdkRGBA color)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
		return GtkThemingEngineHandleExterns.gtk_theming_engine_lookup_color(engine, color_name, out color);
	}

/// <summary>
/// <para>
/// Returns %TRUE if there is a transition animation running for the
/// current region (see gtk_style_context_push_animatable_region()).
/// </para>
/// <para>
/// If @progress is not %NULL, the animation progress will be returned
/// there, 0.0 means the state is closest to being %FALSE, while 1.0 means
/// it’s closest to being %TRUE. This means transition animations will
/// run from 0 to 1 when @state is being set to %TRUE and from 1 to 0 when
/// it’s being set to %FALSE.
/// </para>
/// </summary>

/// <param name="engine">
/// a #GtkThemingEngine
/// </param>
/// <param name="state">
/// a widget state
/// </param>
/// <param name="progress">
/// return location for the transition progress
/// </param>
/// <return>
/// %TRUE if there is a running transition animation for @state.
/// </return>

	public static bool StateIsRunning(this MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateType state, out double progress)
	{
		if (engine.IsInvalid) throw new Exception("Invalid handle (GtkThemingEngineHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle gtk_theming_engine_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJunctionSides gtk_theming_engine_get_junction_sides([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_theming_engine_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))] MentorLake.Gtk.GtkThemingEngineHandle engine, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkThemingEngineHandle>))]
	internal static extern MentorLake.Gtk.GtkThemingEngineHandle gtk_theming_engine_load(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_theming_engine_register_property(string name_space, MentorLake.Gtk.GtkStylePropertyParser parse_func, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

}
