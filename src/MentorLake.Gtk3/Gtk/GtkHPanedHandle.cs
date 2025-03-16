namespace MentorLake.Gtk;

public class GtkHPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkHPanedHandle New()
	{
		return GtkHPanedHandleExterns.gtk_hpaned_new();
	}

}

public static class GtkHPanedHandleExtensions
{
}

internal class GtkHPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkHPanedHandle gtk_hpaned_new();

}
