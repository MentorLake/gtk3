namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkRecentChooserHandle
{
	public static GtkRecentChooserWidgetHandle New()
	{
		return GtkRecentChooserWidgetExterns.gtk_recent_chooser_widget_new();
	}

	public static GtkRecentChooserWidgetHandle NewForManager(GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserWidgetExterns.gtk_recent_chooser_widget_new_for_manager(manager);
	}

}

public static class GtkRecentChooserWidgetHandleExtensions
{
}

internal class GtkRecentChooserWidgetExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new_for_manager(GtkRecentManagerHandle manager);

}
