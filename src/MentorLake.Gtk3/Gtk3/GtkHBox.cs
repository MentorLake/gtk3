namespace MentorLake.Gtk3.Gtk3;

public class GtkHBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkHBoxHandle GtkHboxNew(bool homogeneous, int spacing)
	{
		return GtkHBoxExterns.gtk_hbox_new(homogeneous, spacing);
	}

}

public static class GtkHBoxHandleExtensions
{
}

internal class GtkHBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHBoxHandle gtk_hbox_new(bool homogeneous, int spacing);

}
