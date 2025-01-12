namespace MentorLake.Gtk3.Gtk3;

public class GtkModelButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkModelButtonHandle New()
	{
		return GtkModelButtonExterns.gtk_model_button_new();
	}

}

public static class GtkModelButtonHandleExtensions
{
}

internal class GtkModelButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkModelButtonHandle gtk_model_button_new();

}
