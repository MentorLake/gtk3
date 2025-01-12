namespace MentorLake.Gtk3.Gtk3;

public class GtkVButtonBoxHandle : GtkButtonBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVButtonBoxHandle GtkVbuttonBoxNew()
	{
		return GtkVButtonBoxExterns.gtk_vbutton_box_new();
	}

}

public static class GtkVButtonBoxHandleExtensions
{
}

internal class GtkVButtonBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVButtonBoxHandle gtk_vbutton_box_new();

}
