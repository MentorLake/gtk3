namespace MentorLake.Gtk3.Gtk3;

public class GtkPadControllerHandle : GtkEventControllerHandle
{
	public static GtkPadControllerHandle New(GtkWindowHandle window, GActionGroupHandle group, GdkDeviceHandle pad)
	{
		return GtkPadControllerExterns.gtk_pad_controller_new(window, group, pad);
	}

}

public static class GtkPadControllerHandleExtensions
{
	public static GtkPadControllerHandle SetAction(this GtkPadControllerHandle controller, GtkPadActionType type, int index, int mode, string label, string action_name)
	{
		GtkPadControllerExterns.gtk_pad_controller_set_action(controller, type, index, mode, label, action_name);
		return controller;
	}

	public static GtkPadControllerHandle SetActionEntries(this GtkPadControllerHandle controller, GtkPadActionEntry[] entries, int n_entries)
	{
		GtkPadControllerExterns.gtk_pad_controller_set_action_entries(controller, entries, n_entries);
		return controller;
	}

}

internal class GtkPadControllerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPadControllerHandle gtk_pad_controller_new(GtkWindowHandle window, GActionGroupHandle group, GdkDeviceHandle pad);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_pad_controller_set_action(GtkPadControllerHandle controller, GtkPadActionType type, int index, int mode, string label, string action_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_pad_controller_set_action_entries(GtkPadControllerHandle controller, GtkPadActionEntry[] entries, int n_entries);

}
