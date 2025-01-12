namespace MentorLake.Gtk3.Gtk3;

public class GtkVolumeButtonHandle : GtkScaleButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVolumeButtonHandle New()
	{
		return GtkVolumeButtonExterns.gtk_volume_button_new();
	}

}

public static class GtkVolumeButtonHandleExtensions
{
}

internal class GtkVolumeButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVolumeButtonHandle gtk_volume_button_new();

}
