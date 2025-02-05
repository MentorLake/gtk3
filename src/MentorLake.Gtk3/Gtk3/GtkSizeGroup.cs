namespace MentorLake.Gtk3.Gtk3;

public class GtkSizeGroupHandle : GObjectHandle, GtkBuildableHandle
{
	public static GtkSizeGroupHandle New(GtkSizeGroupMode mode)
	{
		return GtkSizeGroupExterns.gtk_size_group_new(mode);
	}

}

public static class GtkSizeGroupHandleExtensions
{
	public static T AddWidget<T>(this T size_group, GtkWidgetHandle widget) where T : GtkSizeGroupHandle
	{
		GtkSizeGroupExterns.gtk_size_group_add_widget(size_group, widget);
		return size_group;
	}

	public static bool GetIgnoreHidden(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_ignore_hidden(size_group);
	}

	public static GtkSizeGroupMode GetMode(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_mode(size_group);
	}

	public static GSListHandle GetWidgets(this GtkSizeGroupHandle size_group)
	{
		return GtkSizeGroupExterns.gtk_size_group_get_widgets(size_group);
	}

	public static T RemoveWidget<T>(this T size_group, GtkWidgetHandle widget) where T : GtkSizeGroupHandle
	{
		GtkSizeGroupExterns.gtk_size_group_remove_widget(size_group, widget);
		return size_group;
	}

	public static T SetIgnoreHidden<T>(this T size_group, bool ignore_hidden) where T : GtkSizeGroupHandle
	{
		GtkSizeGroupExterns.gtk_size_group_set_ignore_hidden(size_group, ignore_hidden);
		return size_group;
	}

	public static T SetMode<T>(this T size_group, GtkSizeGroupMode mode) where T : GtkSizeGroupHandle
	{
		GtkSizeGroupExterns.gtk_size_group_set_mode(size_group, mode);
		return size_group;
	}

}

internal class GtkSizeGroupExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeGroupHandle gtk_size_group_new(GtkSizeGroupMode mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_size_group_add_widget(GtkSizeGroupHandle size_group, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_size_group_get_ignore_hidden(GtkSizeGroupHandle size_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeGroupMode gtk_size_group_get_mode(GtkSizeGroupHandle size_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_size_group_get_widgets(GtkSizeGroupHandle size_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_size_group_remove_widget(GtkSizeGroupHandle size_group, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_size_group_set_ignore_hidden(GtkSizeGroupHandle size_group, bool ignore_hidden);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_size_group_set_mode(GtkSizeGroupHandle size_group, GtkSizeGroupMode mode);

}
