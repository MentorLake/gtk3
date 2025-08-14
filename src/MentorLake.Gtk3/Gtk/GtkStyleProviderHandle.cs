namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkStyleProvider is an interface used to provide style information to a #GtkStyleContext.
/// See gtk_style_context_add_provider() and gtk_style_context_add_provider_for_screen().
/// </para>
/// </summary>

public interface GtkStyleProviderHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkStyleProviderHandleImpl : BaseSafeHandle, GtkStyleProviderHandle
{
}

public static class GtkStyleProviderHandleExtensions
{
/// <summary>
/// <para>
/// Returns the #GtkIconFactory defined to be in use for @path, or %NULL if none
/// is defined.
/// </para>
/// </summary>

/// <param name="provider">
/// a #GtkStyleProvider
/// </param>
/// <param name="path">
/// #GtkWidgetPath to query
/// </param>
/// <return>
/// The icon factory to use for @path, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkIconFactoryHandle GetIconFactory(this MentorLake.Gtk.GtkStyleProviderHandle provider, MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (provider.IsInvalid) throw new Exception("Invalid handle (GtkStyleProviderHandle)");
		return GtkStyleProviderHandleExterns.gtk_style_provider_get_icon_factory(provider, path);
	}

/// <summary>
/// <para>
/// Returns the style settings affecting a widget defined by @path, or %NULL if
/// @provider doesn’t contemplate styling @path.
/// </para>
/// </summary>

/// <param name="provider">
/// a #GtkStyleProvider
/// </param>
/// <param name="path">
/// #GtkWidgetPath to query
/// </param>
/// <return>
/// a #GtkStyleProperties containing the
/// style settings affecting @path
/// </return>

	public static MentorLake.Gtk.GtkStylePropertiesHandle GetStyle(this MentorLake.Gtk.GtkStyleProviderHandle provider, MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (provider.IsInvalid) throw new Exception("Invalid handle (GtkStyleProviderHandle)");
		return GtkStyleProviderHandleExterns.gtk_style_provider_get_style(provider, path);
	}

/// <summary>
/// <para>
/// Looks up a widget style property as defined by @provider for
/// the widget represented by @path.
/// </para>
/// </summary>

/// <param name="provider">
/// a #GtkStyleProvider
/// </param>
/// <param name="path">
/// #GtkWidgetPath to query
/// </param>
/// <param name="state">
/// state to query the style property for
/// </param>
/// <param name="pspec">
/// The #GParamSpec to query
/// </param>
/// <param name="value">
/// return location for the property value
/// </param>
/// <return>
/// %TRUE if the property was found and has a value, %FALSE otherwise
/// </return>

	public static bool GetStyleProperty(this MentorLake.Gtk.GtkStyleProviderHandle provider, MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkStateFlags state, MentorLake.GObject.GParamSpecHandle pspec, out MentorLake.GObject.GValue value)
	{
		if (provider.IsInvalid) throw new Exception("Invalid handle (GtkStyleProviderHandle)");
		return GtkStyleProviderHandleExterns.gtk_style_provider_get_style_property(provider, path, state, pspec, out value);
	}

}

internal class GtkStyleProviderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconFactoryHandle>))]
	internal static extern MentorLake.Gtk.GtkIconFactoryHandle gtk_style_provider_get_icon_factory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))]
	internal static extern MentorLake.Gtk.GtkStylePropertiesHandle gtk_style_provider_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_provider_get_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, out MentorLake.GObject.GValue value);

}
