namespace MentorLake.Gtk3.Gtk3;

public class GtkAccessibleHandle : AtkObjectHandle
{
}

public static class GtkAccessibleHandleExtensions
{
	public static T ConnectWidgetDestroyed<T>(this T accessible) where T : GtkAccessibleHandle
	{
		GtkAccessibleExterns.gtk_accessible_connect_widget_destroyed(accessible);
		return accessible;
	}

	public static GtkWidgetHandle GetWidget(this GtkAccessibleHandle accessible)
	{
		return GtkAccessibleExterns.gtk_accessible_get_widget(accessible);
	}

	public static T SetWidget<T>(this T accessible, GtkWidgetHandle widget) where T : GtkAccessibleHandle
	{
		GtkAccessibleExterns.gtk_accessible_set_widget(accessible, widget);
		return accessible;
	}

}

internal class GtkAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accessible_connect_widget_destroyed(GtkAccessibleHandle accessible);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_accessible_get_widget(GtkAccessibleHandle accessible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accessible_set_widget(GtkAccessibleHandle accessible, GtkWidgetHandle widget);

}
