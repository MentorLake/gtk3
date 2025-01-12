namespace MentorLake.Gtk3.Gtk3;

public class GtkHScaleHandle : GtkScaleHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkHScaleHandle GtkHscaleNew(GtkAdjustmentHandle adjustment)
	{
		return GtkHScaleExterns.gtk_hscale_new(adjustment);
	}

	public static GtkHScaleHandle GtkHscaleNewWithRange(double min, double max, double step)
	{
		return GtkHScaleExterns.gtk_hscale_new_with_range(min, max, step);
	}

}

public static class GtkHScaleHandleExtensions
{
}

internal class GtkHScaleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHScaleHandle gtk_hscale_new(GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHScaleHandle gtk_hscale_new_with_range(double min, double max, double step);

}
