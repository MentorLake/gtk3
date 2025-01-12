namespace MentorLake.Gtk3.Gtk3;

public class GtkBinHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkBinHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkBinHandle bin)
	{
		return GtkBinExterns.gtk_bin_get_child(bin);
	}

}

internal class GtkBinExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_bin_get_child(GtkBinHandle bin);

}
