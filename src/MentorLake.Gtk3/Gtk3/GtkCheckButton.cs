namespace MentorLake.Gtk3.Gtk3;

public class GtkCheckButtonHandle : GtkToggleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkCheckButtonHandle New()
	{
		return GtkCheckButtonExterns.gtk_check_button_new();
	}

	public static GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_label(label);
	}

	public static GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_mnemonic(label);
	}

}

public static class GtkCheckButtonHandleExtensions
{
}

internal class GtkCheckButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new_with_label(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new_with_mnemonic(string label);

}
