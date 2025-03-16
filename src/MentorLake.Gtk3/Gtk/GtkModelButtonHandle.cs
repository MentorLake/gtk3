namespace MentorLake.Gtk;

public class GtkModelButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkModelButtonHandle New()
	{
		return GtkModelButtonHandleExterns.gtk_model_button_new();
	}

}

public static class GtkModelButtonHandleExtensions
{
}

internal class GtkModelButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkModelButtonHandle gtk_model_button_new();

}
