namespace MentorLake.Gtk3.Gtk3;

public class GtkVBoxHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVBoxHandle GtkVboxNew(bool homogeneous, int spacing)
	{
		return GtkVBoxExterns.gtk_vbox_new(homogeneous, spacing);
	}

}

public static class GtkVBoxHandleExtensions
{
}

internal class GtkVBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVBoxHandle gtk_vbox_new(bool homogeneous, int spacing);

}
