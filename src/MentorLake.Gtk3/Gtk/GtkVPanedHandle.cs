namespace MentorLake.Gtk;

public class GtkVPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkVPanedHandle New()
	{
		return GtkVPanedHandleExterns.gtk_vpaned_new();
	}

}

public static class GtkVPanedHandleExtensions
{
}

internal class GtkVPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkVPanedHandle gtk_vpaned_new();

}
