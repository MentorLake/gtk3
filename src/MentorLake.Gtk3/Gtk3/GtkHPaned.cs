namespace MentorLake.Gtk3.Gtk3;

public class GtkHPanedHandle : GtkPanedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkHPanedHandle GtkHpanedNew()
	{
		return GtkHPanedExterns.gtk_hpaned_new();
	}

}

public static class GtkHPanedHandleExtensions
{
}

internal class GtkHPanedExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHPanedHandle gtk_hpaned_new();

}
