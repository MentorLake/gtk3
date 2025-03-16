namespace MentorLake.Gtk;

public class GtkCheckButtonHandle : GtkToggleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkCheckButtonHandle New()
	{
		return GtkCheckButtonHandleExterns.gtk_check_button_new();
	}

	public static MentorLake.Gtk.GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonHandleExterns.gtk_check_button_new_with_label(label);
	}

	public static MentorLake.Gtk.GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonHandleExterns.gtk_check_button_new_with_mnemonic(label);
	}

}

public static class GtkCheckButtonHandleExtensions
{
}

internal class GtkCheckButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCheckButtonHandle gtk_check_button_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCheckButtonHandle gtk_check_button_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCheckButtonHandle gtk_check_button_new_with_mnemonic(string label);

}
