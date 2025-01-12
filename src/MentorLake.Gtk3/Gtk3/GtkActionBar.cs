namespace MentorLake.Gtk3.Gtk3;

public class GtkActionBarHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkActionBarHandle New()
	{
		return GtkActionBarExterns.gtk_action_bar_new();
	}

}

public static class GtkActionBarHandleExtensions
{
	public static GtkWidgetHandle GetCenterWidget(this GtkActionBarHandle action_bar)
	{
		return GtkActionBarExterns.gtk_action_bar_get_center_widget(action_bar);
	}

	public static T PackEnd<T>(this T action_bar, GtkWidgetHandle child) where T : GtkActionBarHandle
	{
		GtkActionBarExterns.gtk_action_bar_pack_end(action_bar, child);
		return action_bar;
	}

	public static T PackStart<T>(this T action_bar, GtkWidgetHandle child) where T : GtkActionBarHandle
	{
		GtkActionBarExterns.gtk_action_bar_pack_start(action_bar, child);
		return action_bar;
	}

	public static T SetCenterWidget<T>(this T action_bar, GtkWidgetHandle center_widget) where T : GtkActionBarHandle
	{
		GtkActionBarExterns.gtk_action_bar_set_center_widget(action_bar, center_widget);
		return action_bar;
	}

}

internal class GtkActionBarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkActionBarHandle gtk_action_bar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_action_bar_get_center_widget(GtkActionBarHandle action_bar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_bar_pack_end(GtkActionBarHandle action_bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_bar_pack_start(GtkActionBarHandle action_bar, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_action_bar_set_center_widget(GtkActionBarHandle action_bar, GtkWidgetHandle center_widget);

}
