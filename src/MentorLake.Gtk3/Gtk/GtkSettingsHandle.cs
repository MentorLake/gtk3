namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkSettings provide a mechanism to share global settings between
/// applications.
/// </para>
/// <para>
/// On the X window system, this sharing is realized by an
/// [XSettings](http://www.freedesktop.org/wiki/Specifications/xsettings-spec)
/// manager that is usually part of the desktop environment, along with
/// utilities that let the user change these settings. In the absence of
/// an Xsettings manager, GTK+ reads default values for settings from
/// `settings.ini` files in
/// `/etc/gtk-3.0`, `$XDG_CONFIG_DIRS/gtk-3.0`
/// and `$XDG_CONFIG_HOME/gtk-3.0`.
/// These files must be valid key files (see #GKeyFile), and have
/// a section called Settings. Themes can also provide default values
/// for settings by installing a `settings.ini` file
/// next to their `gtk.css` file.
/// </para>
/// <para>
/// Applications can override system-wide settings by setting the property
/// of the GtkSettings object with g_object_set(). This should be restricted
/// to special cases though; GtkSettings are not meant as an application
/// configuration facility. When doing so, you need to be aware that settings
/// that are specific to individual widgets may not be available before the
/// widget type has been realized at least once. The following example
/// demonstrates a way to do this:
/// |[<!-- language="C" -->
///   gtk_init (&argc, &argv);
/// </para>
/// <para>
///   // make sure the type is realized
///   g_type_class_unref (g_type_class_ref (GTK_TYPE_IMAGE_MENU_ITEM));
/// </para>
/// <para>
///   g_object_set (gtk_settings_get_default (), "gtk-enable-animations", FALSE, NULL);
/// ]|
/// </para>
/// <para>
/// There is one GtkSettings instance per screen. It can be obtained with
/// gtk_settings_get_for_screen(), but in many cases, it is more convenient
/// to use gtk_widget_get_settings(). gtk_settings_get_default() returns the
/// GtkSettings instance for the default screen.
/// </para>
/// </summary>

public class GtkSettingsHandle : GObjectHandle, GtkStyleProviderHandle
{
/// <summary>
/// <para>
/// Gets the #GtkSettings object for the default GDK screen, creating
/// it if necessary. See gtk_settings_get_for_screen().
/// </para>
/// </summary>

/// <return>
/// a #GtkSettings object. If there is
/// no default screen, then returns %NULL.
/// </return>

	public static MentorLake.Gtk.GtkSettingsHandle GetDefault()
	{
		return GtkSettingsHandleExterns.gtk_settings_get_default();
	}

/// <summary>
/// <para>
/// Gets the #GtkSettings object for @screen, creating it if necessary.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen.
/// </param>
/// <return>
/// a #GtkSettings object.
/// </return>

	public static MentorLake.Gtk.GtkSettingsHandle GetForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkSettingsHandleExterns.gtk_settings_get_for_screen(screen);
	}


/// <param name="pspec">
/// </param>

	public static void InstallProperty(MentorLake.GObject.GParamSpecHandle pspec)
	{
		GtkSettingsHandleExterns.gtk_settings_install_property(pspec);
	}


/// <param name="pspec">
/// </param>
/// <param name="parser">
/// </param>

	public static void InstallPropertyParser(MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser)
	{
		GtkSettingsHandleExterns.gtk_settings_install_property_parser(pspec, parser);
	}

}

public static class GtkSettingsHandleExtensions
{
/// <summary>
/// <para>
/// Undoes the effect of calling g_object_set() to install an
/// application-specific value for a setting. After this call,
/// the setting will again follow the session-wide value for
/// this setting.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkSettings object
/// </param>
/// <param name="name">
/// the name of the setting to reset
/// </param>

	public static T ResetProperty<T>(this T settings, string name) where T : GtkSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkSettingsHandle)");
		GtkSettingsHandleExterns.gtk_settings_reset_property(settings, name);
		return settings;
	}


/// <param name="settings">
/// </param>
/// <param name="name">
/// </param>
/// <param name="v_double">
/// </param>
/// <param name="origin">
/// </param>

	public static T SetDoubleProperty<T>(this T settings, string name, double v_double, string origin) where T : GtkSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkSettingsHandle)");
		GtkSettingsHandleExterns.gtk_settings_set_double_property(settings, name, v_double, origin);
		return settings;
	}


/// <param name="settings">
/// </param>
/// <param name="name">
/// </param>
/// <param name="v_long">
/// </param>
/// <param name="origin">
/// </param>

	public static T SetLongProperty<T>(this T settings, string name, long v_long, string origin) where T : GtkSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkSettingsHandle)");
		GtkSettingsHandleExterns.gtk_settings_set_long_property(settings, name, v_long, origin);
		return settings;
	}


/// <param name="settings">
/// </param>
/// <param name="name">
/// </param>
/// <param name="svalue">
/// </param>

	public static T SetPropertyValue<T>(this T settings, string name, MentorLake.Gtk.GtkSettingsValueHandle svalue) where T : GtkSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkSettingsHandle)");
		GtkSettingsHandleExterns.gtk_settings_set_property_value(settings, name, svalue);
		return settings;
	}


/// <param name="settings">
/// </param>
/// <param name="name">
/// </param>
/// <param name="v_string">
/// </param>
/// <param name="origin">
/// </param>

	public static T SetStringProperty<T>(this T settings, string name, string v_string, string origin) where T : GtkSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkSettingsHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkSettingsHandle gtk_settings_get_default();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkSettingsHandle gtk_settings_get_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_install_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_settings_install_property_parser([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.Gtk.GtkRcPropertyParser parser);

}
