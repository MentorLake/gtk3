namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// An icon factory manages a collection of #GtkIconSet; a #GtkIconSet manages a
/// set of variants of a particular icon (i.e. a #GtkIconSet contains variants for
/// different sizes and widget states). Icons in an icon factory are named by a
/// stock ID, which is a simple string identifying the icon. Each #GtkStyle has a
/// list of #GtkIconFactory derived from the current theme; those icon factories
/// are consulted first when searching for an icon. If the theme doesn’t set a
/// particular icon, GTK+ looks for the icon in a list of default icon factories,
/// maintained by gtk_icon_factory_add_default() and
/// gtk_icon_factory_remove_default(). Applications with icons should add a default
/// icon factory with their icons, which will allow themes to override the icons
/// for the application.
/// </para>
/// <para>
/// To display an icon, always use gtk_style_lookup_icon_set() on the widget that
/// will display the icon, or the convenience function
/// gtk_widget_render_icon(). These functions take the theme into account when
/// looking up the icon to use for a given stock ID.
/// </para>
/// <para>
/// # GtkIconFactory as GtkBuildable # {#GtkIconFactory-BUILDER-UI}
/// </para>
/// <para>
/// GtkIconFactory supports a custom `&amp;lt;sources&amp;gt;` element, which can contain
/// multiple `&amp;lt;source&amp;gt;` elements. The following attributes are allowed:
/// </para>
/// <para>
/// - stock-id
/// </para>
/// <para>
///     The stock id of the source, a string. This attribute is
///     mandatory
/// </para>
/// <para>
/// - filename
/// </para>
/// <para>
///     The filename of the source, a string.  This attribute is
///     optional
/// </para>
/// <para>
/// - icon-name
/// </para>
/// <para>
///     The icon name for the source, a string.  This attribute is
///     optional.
/// </para>
/// <para>
/// - size
/// </para>
/// <para>
///     Size of the icon, a #GtkIconSize enum value.  This attribute is
///     optional.
/// </para>
/// <para>
/// - direction
/// </para>
/// <para>
///     Direction of the source, a #GtkTextDirection enum value.  This
///     attribute is optional.
/// </para>
/// <para>
/// - state
/// </para>
/// <para>
///     State of the source, a #GtkStateType enum value.  This
///     attribute is optional.
/// </para>
/// 
/// <para>
/// ## A #GtkIconFactory UI definition fragment. ##
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkIconFactory&quot; id=&quot;iconfactory1&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkIconFactory&quot; id=&quot;iconfactory1&quot;&amp;gt;
///   &amp;lt;sources&amp;gt;
///     &amp;lt;source stock-id=&quot;apple-red&quot; filename=&quot;apple-red.png&quot;/&amp;gt;
///   &amp;lt;/sources&amp;gt;
/// &amp;lt;/object&amp;gt;
/// &amp;lt;object class=&quot;GtkWindow&quot; id=&quot;window1&quot;&amp;gt;
///   &amp;lt;child&amp;gt;
///     &amp;lt;object class=&quot;GtkButton&quot; id=&quot;apple_button&quot;&amp;gt;
///       &amp;lt;property name=&quot;label&quot;&amp;gt;apple-red&amp;lt;/property&amp;gt;
///       &amp;lt;property name=&quot;use-stock&quot;&amp;gt;True&amp;lt;/property&amp;gt;
///     &amp;lt;/object&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// </summary>

public class GtkIconFactoryHandle : GObjectHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkIconFactory. An icon factory manages a collection
/// of #GtkIconSets; a #GtkIconSet manages a set of variants of a
/// particular icon (i.e. a #GtkIconSet contains variants for different
/// sizes and widget states). Icons in an icon factory are named by a
/// stock ID, which is a simple string identifying the icon. Each
/// #GtkStyle has a list of #GtkIconFactorys derived from the current
/// theme; those icon factories are consulted first when searching for
/// an icon. If the theme doesn’t set a particular icon, GTK+ looks for
/// the icon in a list of default icon factories, maintained by
/// gtk_icon_factory_add_default() and
/// gtk_icon_factory_remove_default(). Applications with icons should
/// add a default icon factory with their icons, which will allow
/// themes to override the icons for the application.
/// </para>
/// </summary>

/// <return>
/// a new #GtkIconFactory
/// </return>

	public static MentorLake.Gtk.GtkIconFactoryHandle New()
	{
		return GtkIconFactoryHandleExterns.gtk_icon_factory_new();
	}

/// <summary>
/// <para>
/// Looks for an icon in the list of default icon factories.  For
/// display to the user, you should use gtk_style_lookup_icon_set() on
/// the #GtkStyle for the widget that will display the icon, instead of
/// using this function directly, so that themes are taken into
/// account.
/// </para>
/// </summary>

/// <param name="stock_id">
/// an icon name
/// </param>
/// <return>
/// a #GtkIconSet, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle LookupDefault(string stock_id)
	{
		return GtkIconFactoryHandleExterns.gtk_icon_factory_lookup_default(stock_id);
	}

}

public static class GtkIconFactoryHandleExtensions
{
/// <summary>
/// <para>
/// Adds the given @icon_set to the icon factory, under the name
/// @stock_id.  @stock_id should be namespaced for your application,
/// e.g. “myapp-whatever-icon”.  Normally applications create a
/// #GtkIconFactory, then add it to the list of default factories with
/// gtk_icon_factory_add_default(). Then they pass the @stock_id to
/// widgets such as #GtkImage to display the icon. Themes can provide
/// an icon with the same name (such as &quot;myapp-whatever-icon&quot;) to
/// override your application’s default icons. If an icon already
/// existed in @factory for @stock_id, it is unreferenced and replaced
/// with the new @icon_set.
/// </para>
/// </summary>

/// <param name="factory">
/// a #GtkIconFactory
/// </param>
/// <param name="stock_id">
/// icon name
/// </param>
/// <param name="icon_set">
/// icon set
/// </param>

	public static T Add<T>(this T factory, string stock_id, MentorLake.Gtk.GtkIconSetHandle icon_set) where T : GtkIconFactoryHandle
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (GtkIconFactoryHandle)");
		GtkIconFactoryHandleExterns.gtk_icon_factory_add(factory, stock_id, icon_set);
		return factory;
	}

/// <summary>
/// <para>
/// Adds an icon factory to the list of icon factories searched by
/// gtk_style_lookup_icon_set(). This means that, for example,
/// gtk_image_new_from_stock() will be able to find icons in @factory.
/// There will normally be an icon factory added for each library or
/// application that comes with icons. The default icon factories
/// can be overridden by themes.
/// </para>
/// </summary>

/// <param name="factory">
/// a #GtkIconFactory
/// </param>

	public static T AddDefault<T>(this T factory) where T : GtkIconFactoryHandle
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (GtkIconFactoryHandle)");
		GtkIconFactoryHandleExterns.gtk_icon_factory_add_default(factory);
		return factory;
	}

/// <summary>
/// <para>
/// Looks up @stock_id in the icon factory, returning an icon set
/// if found, otherwise %NULL. For display to the user, you should
/// use gtk_style_lookup_icon_set() on the #GtkStyle for the
/// widget that will display the icon, instead of using this
/// function directly, so that themes are taken into account.
/// </para>
/// </summary>

/// <param name="factory">
/// a #GtkIconFactory
/// </param>
/// <param name="stock_id">
/// an icon name
/// </param>
/// <return>
/// icon set of @stock_id.
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle Lookup(this MentorLake.Gtk.GtkIconFactoryHandle factory, string stock_id)
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (GtkIconFactoryHandle)");
		return GtkIconFactoryHandleExterns.gtk_icon_factory_lookup(factory, stock_id);
	}

/// <summary>
/// <para>
/// Removes an icon factory from the list of default icon
/// factories. Not normally used; you might use it for a library that
/// can be unloaded or shut down.
/// </para>
/// </summary>

/// <param name="factory">
/// a #GtkIconFactory previously added with gtk_icon_factory_add_default()
/// </param>

	public static T RemoveDefault<T>(this T factory) where T : GtkIconFactoryHandle
	{
		if (factory.IsInvalid) throw new Exception("Invalid handle (GtkIconFactoryHandle)");
		GtkIconFactoryHandleExterns.gtk_icon_factory_remove_default(factory);
		return factory;
	}

}

internal class GtkIconFactoryHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))]
	internal static extern MentorLake.Gtk.GtkIconFactoryHandle gtk_icon_factory_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_factory_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory, string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))] MentorLake.Gtk.GtkIconSetHandle icon_set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_factory_add_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_factory_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_factory_remove_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))] MentorLake.Gtk.GtkIconFactoryHandle factory);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_icon_factory_lookup_default(string stock_id);

}
