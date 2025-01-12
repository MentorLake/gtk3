namespace MentorLake.Gtk3.Gtk3;

public class GtkVSeparatorHandle : GtkSeparatorHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVSeparatorHandle GtkVseparatorNew()
	{
		return GtkVSeparatorExterns.gtk_vseparator_new();
	}

}

public static class GtkVSeparatorHandleExtensions
{
}

internal class GtkVSeparatorExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVSeparatorHandle gtk_vseparator_new();

}
