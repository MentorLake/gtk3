namespace MentorLake.Gtk3.Gtk3;

public class GtkVScaleHandle : GtkScaleHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkVScaleHandle GtkVscaleNew(GtkAdjustmentHandle adjustment)
	{
		return GtkVScaleExterns.gtk_vscale_new(adjustment);
	}

	public static GtkVScaleHandle GtkVscaleNewWithRange(double min, double max, double step)
	{
		return GtkVScaleExterns.gtk_vscale_new_with_range(min, max, step);
	}

}

public static class GtkVScaleHandleExtensions
{
}

internal class GtkVScaleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVScaleHandle gtk_vscale_new(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkVScaleHandle gtk_vscale_new_with_range(double min, double max, double step);

}
