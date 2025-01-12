namespace MentorLake.Gtk3.Gtk3;

public class GtkSettingsHandle : GObjectHandle, GtkStyleProviderHandle
{
	public static GtkSettingsHandle GetDefault()
	{
		return GtkSettingsExterns.gtk_settings_get_default();
	}

	public static GtkSettingsHandle GetForScreen(GdkScreenHandle screen)
	{
		return GtkSettingsExterns.gtk_settings_get_for_screen(screen);
	}

	public static void InstallProperty(GParamSpecHandle pspec)
	{
		GtkSettingsExterns.gtk_settings_install_property(pspec);
	}

	public static void InstallPropertyParser(GParamSpecHandle pspec, GtkRcPropertyParser parser)
	{
		GtkSettingsExterns.gtk_settings_install_property_parser(pspec, parser);
	}

}

public static class GtkSettingsHandleExtensions
{
	public static GtkSettingsHandle ResetProperty(this GtkSettingsHandle settings, string name)
	{
		GtkSettingsExterns.gtk_settings_reset_property(settings, name);
		return settings;
	}

	public static GtkSettingsHandle SetDoubleProperty(this GtkSettingsHandle settings, string name, double v_double, string origin)
	{
		GtkSettingsExterns.gtk_settings_set_double_property(settings, name, v_double, origin);
		return settings;
	}

	public static GtkSettingsHandle SetLongProperty(this GtkSettingsHandle settings, string name, long v_long, string origin)
	{
		GtkSettingsExterns.gtk_settings_set_long_property(settings, name, v_long, origin);
		return settings;
	}

	public static GtkSettingsHandle SetPropertyValue(this GtkSettingsHandle settings, string name, GtkSettingsValueHandle svalue)
	{
		GtkSettingsExterns.gtk_settings_set_property_value(settings, name, svalue);
		return settings;
	}

	public static GtkSettingsHandle SetStringProperty(this GtkSettingsHandle settings, string name, string v_string, string origin)
	{
		GtkSettingsExterns.gtk_settings_set_string_property(settings, name, v_string, origin);
		return settings;
	}

	public static bool GtkRcReparseAllForSettings(this GtkSettingsHandle settings, bool force_load)
	{
		return GtkSettingsExterns.gtk_rc_reparse_all_for_settings(settings, force_load);
	}

	public static string GtkRcFindPixmapInPath(this GtkSettingsHandle settings, GScannerHandle scanner, string pixmap_file)
	{
		return GtkSettingsExterns.gtk_rc_find_pixmap_in_path(settings, scanner, pixmap_file);
	}

	public static GtkStyleHandle GtkRcGetStyleByPaths(this GtkSettingsHandle settings, string widget_path, string class_path, GType type)
	{
		return GtkSettingsExterns.gtk_rc_get_style_by_paths(settings, widget_path, class_path, type);
	}

	public static GtkSettingsHandle GtkRcResetStyles(this GtkSettingsHandle settings)
	{
		GtkSettingsExterns.gtk_rc_reset_styles(settings);
		return settings;
	}

}

internal class GtkSettingsExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_reset_property(GtkSettingsHandle settings, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_set_double_property(GtkSettingsHandle settings, string name, double v_double, string origin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_set_long_property(GtkSettingsHandle settings, string name, long v_long, string origin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_set_property_value(GtkSettingsHandle settings, string name, GtkSettingsValueHandle svalue);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_set_string_property(GtkSettingsHandle settings, string name, string v_string, string origin);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_rc_reparse_all_for_settings(GtkSettingsHandle settings, bool force_load);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_rc_find_pixmap_in_path(GtkSettingsHandle settings, GScannerHandle scanner, string pixmap_file);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_rc_get_style_by_paths(GtkSettingsHandle settings, string widget_path, string class_path, GType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_rc_reset_styles(GtkSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSettingsHandle gtk_settings_get_default();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSettingsHandle gtk_settings_get_for_screen(GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_install_property(GParamSpecHandle pspec);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_settings_install_property_parser(GParamSpecHandle pspec, GtkRcPropertyParser parser);

}
