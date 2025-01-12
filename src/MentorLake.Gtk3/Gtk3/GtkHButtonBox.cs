namespace MentorLake.Gtk3.Gtk3;

public class GtkHButtonBoxHandle : GtkButtonBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkHButtonBoxHandle GtkHbuttonBoxNew()
	{
		return GtkHButtonBoxExterns.gtk_hbutton_box_new();
	}

}

public static class GtkHButtonBoxHandleExtensions
{
}

internal class GtkHButtonBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHButtonBoxHandle gtk_hbutton_box_new();

}
