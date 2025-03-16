namespace MentorLake.Gtk;

public class GtkSettingsHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static MentorLake.Gtk.GtkSettingsHandle GetDefault()
	{
		return GtkSettingsHandleExterns.gtk_settings_get_default();
	}

	public static MentorLake.Gtk.GtkSettingsHandle GetForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkSettingsHandleExterns.gtk_settings_get_for_screen(screen);
	}

	public static void InstallProperty(MentorLake.GObject.GParamSpecHandle pspec)
	{
		GtkSettingsHandleExterns.gtk_settings_install_property(pspec);
	}

	public static void InstallPropertyParser(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser)
	{
		GtkSettingsHandleExterns.gtk_settings_install_property_parser(pspec, parser);
	}

}

public static class GtkSettingsHandleExtensions
{
	public static T ResetProperty<T>(this T settings, string name) where T : GtkSettingsHandle
	{
		GtkSettingsHandleExterns.gtk_settings_reset_property(settings, name);
		return settings;
	}

	public static T SetDoubleProperty<T>(this T settings, string name, double v_double, string origin) where T : GtkSettingsHandle
	{
		GtkSettingsHandleExterns.gtk_settings_set_double_property(settings, name, v_double, origin);
		return settings;
	}

	public static T SetLongProperty<T>(this T settings, string name, long v_long, string origin) where T : GtkSettingsHandle
	{
		GtkSettingsHandleExterns.gtk_settings_set_long_property(settings, name, v_long, origin);
		return settings;
	}

	public static T SetPropertyValue<T>(this T settings, string name, MentorLake.Gtk.GtkSettingsValueHandle svalue) where T : GtkSettingsHandle
	{
		GtkSettingsHandleExterns.gtk_settings_set_property_value(settings, name, svalue);
		return settings;
	}

	public static T SetStringProperty<T>(this T settings, string name, string v_string, string origin) where T : GtkSettingsHandle
	{
		GtkSettingsHandleExterns.gtk_settings_set_string_property(settings, name, v_string, origin);
		return settings;
	}

}

internal class GtkSettingsHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_reset_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_set_double_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, string name, double v_double, string origin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_set_long_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, string name, long v_long, string origin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_set_property_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsValueHandle>))] MentorLake.Gtk.GtkSettingsValueHandle svalue);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_set_string_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))] MentorLake.Gtk.GtkSettingsHandle settings, string name, string v_string, string origin);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSettingsHandle gtk_settings_get_default();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSettingsHandle gtk_settings_get_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_install_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_install_property_parser([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser);

}
