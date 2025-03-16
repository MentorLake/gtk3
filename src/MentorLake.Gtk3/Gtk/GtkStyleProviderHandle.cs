namespace MentorLake.Gtk;

public interface GtkStyleProviderHandle
{
}

internal class GtkStyleProviderHandleImpl : BaseSafeHandle, GtkStyleProviderHandle
{
}

public static class GtkStyleProviderHandleExtensions
{
	public static MentorLake.Gtk.GtkIconFactoryHandle GetIconFactory(this MentorLake.Gtk.GtkStyleProviderHandle provider, MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		return GtkStyleProviderHandleExterns.gtk_style_provider_get_icon_factory(provider, path);
	}

	public static MentorLake.Gtk.GtkStylePropertiesHandle GetStyle(this MentorLake.Gtk.GtkStyleProviderHandle provider, MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		return GtkStyleProviderHandleExterns.gtk_style_provider_get_style(provider, path);
	}

	public static bool GetStyleProperty(this MentorLake.Gtk.GtkStyleProviderHandle provider, MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkStateFlags state, MentorLake.GObject.GParamSpecHandle pspec, out MentorLake.GObject.GValue value)
	{
		return GtkStyleProviderHandleExterns.gtk_style_provider_get_style_property(provider, path, state, pspec, out value);
	}

}

internal class GtkStyleProviderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIconFactoryHandle gtk_style_provider_get_icon_factory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStylePropertiesHandle gtk_style_provider_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_provider_get_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, out MentorLake.GObject.GValue value);

}
