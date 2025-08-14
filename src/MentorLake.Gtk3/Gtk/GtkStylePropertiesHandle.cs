namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkStyleProperties provides the storage for style information
/// that is used by #GtkStyleContext and other #GtkStyleProvider
/// implementations.
/// </para>
/// <para>
/// Before style properties can be stored in GtkStyleProperties, they
/// must be registered with gtk_style_properties_register_property().
/// </para>
/// <para>
/// Unless you are writing a #GtkStyleProvider implementation, you
/// are unlikely to use this API directly, as gtk_style_context_get()
/// and its variants are the preferred way to access styling information
/// from widget implementations and theming engine implementations
/// should use the APIs provided by #GtkThemingEngine instead.
/// </para>
/// <para>
/// #GtkStyleProperties has been deprecated in GTK 3.16. The CSS
/// machinery does not use it anymore and all users of this object
/// have been deprecated.
/// </para>
/// </summary>

public class GtkStylePropertiesHandle : GObjectHandle, GtkStyleProviderHandle
{
/// <summary>
/// <para>
/// Returns a newly created #GtkStyleProperties
/// </para>
/// </summary>

/// <return>
/// a new #GtkStyleProperties
/// </return>

	public static MentorLake.Gtk.GtkStylePropertiesHandle New()
	{
		return GtkStylePropertiesHandleExterns.gtk_style_properties_new();
	}

/// <summary>
/// <para>
/// Returns %TRUE if a property has been registered, if @pspec or
/// @parse_func are not %NULL, the #GParamSpec and parsing function
/// will be respectively returned.
/// </para>
/// </summary>

/// <param name="property_name">
/// property name to look up
/// </param>
/// <param name="parse_func">
/// return location for the parse function
/// </param>
/// <param name="pspec">
/// return location for the #GParamSpec
/// </param>
/// <return>
/// %TRUE if the property is registered, %FALSE otherwise
/// </return>

	public static bool LookupProperty(string property_name, out MentorLake.Gtk.GtkStylePropertyParser parse_func, out MentorLake.GObject.GParamSpecHandle pspec)
	{
		return GtkStylePropertiesHandleExterns.gtk_style_properties_lookup_property(property_name, out parse_func, out pspec);
	}

/// <summary>
/// <para>
/// Registers a property so it can be used in the CSS file format.
/// This function is the low-level equivalent of
/// gtk_theming_engine_register_property(), if you are implementing
/// a theming engine, you want to use that function instead.
/// </para>
/// </summary>

/// <param name="parse_func">
/// parsing function to use, or %NULL
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the new property
/// </param>

	public static void RegisterProperty(MentorLake.Gtk.GtkStylePropertyParser parse_func, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GtkStylePropertiesHandleExterns.gtk_style_properties_register_property(parse_func, pspec);
	}

}

public static class GtkStylePropertiesHandleExtensions
{
/// <summary>
/// <para>
/// Clears all style information from @props.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>

	public static T Clear<T>(this T props) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_clear(props);
		return props;
	}

/// <summary>
/// <para>
/// Retrieves several style property values from @props for a
/// given state.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="state">
/// state to retrieve the property values for
/// </param>
/// <param name="@__arglist">
/// property name /return value pairs, followed by %NULL
/// </param>

	public static T Get<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_get(props, state, @__arglist);
		return props;
	}

/// <summary>
/// <para>
/// Gets a style property from @props for the given state. When done with @value,
/// g_value_unset() needs to be called to free any allocated memory.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="property">
/// style property name
/// </param>
/// <param name="state">
/// state to retrieve the property value for
/// </param>
/// <param name="value">
/// return location for the style property value.
/// </param>
/// <return>
/// %TRUE if the property exists in @props, %FALSE otherwise
/// </return>

	public static bool GetProperty(this MentorLake.Gtk.GtkStylePropertiesHandle props, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value)
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		return GtkStylePropertiesHandleExterns.gtk_style_properties_get_property(props, property, state, out value);
	}

/// <summary>
/// <para>
/// Retrieves several style property values from @props for a given state.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="state">
/// state to retrieve the property values for
/// </param>
/// <param name="args">
/// va_list of property name/return location pairs, followed by %NULL
/// </param>

	public static T GetValist<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_get_valist(props, state, args);
		return props;
	}

/// <summary>
/// <para>
/// Returns the symbolic color that is mapped
/// to @name.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="name">
/// color name to lookup
/// </param>
/// <return>
/// The mapped color
/// </return>

	public static MentorLake.Gtk.GtkSymbolicColorHandle LookupColor(this MentorLake.Gtk.GtkStylePropertiesHandle props, string name)
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		return GtkStylePropertiesHandleExterns.gtk_style_properties_lookup_color(props, name);
	}

/// <summary>
/// <para>
/// Maps @color so it can be referenced by @name. See
/// gtk_style_properties_lookup_color()
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="name">
/// color name
/// </param>
/// <param name="color">
/// #GtkSymbolicColor to map @name to
/// </param>

	public static T MapColor<T>(this T props, string name, MentorLake.Gtk.GtkSymbolicColorHandle color) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_map_color(props, name, color);
		return props;
	}

/// <summary>
/// <para>
/// Merges into @props all the style information contained
/// in @props_to_merge. If @replace is %TRUE, the values
/// will be overwritten, if it is %FALSE, the older values
/// will prevail.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="props_to_merge">
/// a second #GtkStyleProperties
/// </param>
/// <param name="replace">
/// whether to replace values or not
/// </param>

	public static T Merge<T>(this T props, MentorLake.Gtk.GtkStylePropertiesHandle props_to_merge, bool replace) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_merge(props, props_to_merge, replace);
		return props;
	}

/// <summary>
/// <para>
/// Sets several style properties on @props.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="state">
/// state to set the values for
/// </param>
/// <param name="@__arglist">
/// property name/value pairs, followed by %NULL
/// </param>

	public static T Set<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_set(props, state, @__arglist);
		return props;
	}

/// <summary>
/// <para>
/// Sets a styling property in @props.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="property">
/// styling property to set
/// </param>
/// <param name="state">
/// state to set the value for
/// </param>
/// <param name="value">
/// new value for the property
/// </param>

	public static T SetProperty<T>(this T props, string property, MentorLake.Gtk.GtkStateFlags state, MentorLake.GObject.GValueHandle value) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_set_property(props, property, state, value);
		return props;
	}

/// <summary>
/// <para>
/// Sets several style properties on @props.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="state">
/// state to set the values for
/// </param>
/// <param name="args">
/// va_list of property name/value pairs, followed by %NULL
/// </param>

	public static T SetValist<T>(this T props, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_set_valist(props, state, args);
		return props;
	}

/// <summary>
/// <para>
/// Unsets a style property in @props.
/// </para>
/// </summary>

/// <param name="props">
/// a #GtkStyleProperties
/// </param>
/// <param name="property">
/// property to unset
/// </param>
/// <param name="state">
/// state to unset
/// </param>

	public static T UnsetProperty<T>(this T props, string property, MentorLake.Gtk.GtkStateFlags state) where T : GtkStylePropertiesHandle
	{
		if (props.IsInvalid) throw new Exception("Invalid handle (GtkStylePropertiesHandle)");
		GtkStylePropertiesHandleExterns.gtk_style_properties_unset_property(props, property, state);
		return props;
	}

}

internal class GtkStylePropertiesHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
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
