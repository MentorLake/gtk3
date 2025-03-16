namespace MentorLake.Gtk;

public class GtkHButtonBoxHandle : GtkButtonBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkHButtonBoxHandle New()
	{
		return GtkHButtonBoxHandleExterns.gtk_hbutton_box_new();
	}

}

public static class GtkHButtonBoxHandleExtensions
{
}

internal class GtkHButtonBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkHButtonBoxHandle gtk_hbutton_box_new();

}
