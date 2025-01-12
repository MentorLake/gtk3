namespace MentorLake.Gtk3.Gtk3;

public class GtkVPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVPanedHandle GtkVpanedNew()
	{
		return GtkVPanedExterns.gtk_vpaned_new();
	}

}

public static class GtkVPanedHandleExtensions
{
}

internal class GtkVPanedExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVPanedHandle gtk_vpaned_new();

}
