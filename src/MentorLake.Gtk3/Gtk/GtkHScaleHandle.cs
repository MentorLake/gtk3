namespace MentorLake.Gtk;

public class GtkHScaleHandle : GtkScaleHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkHScaleHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkHScaleHandleExterns.gtk_hscale_new(adjustment);
	}

	public static MentorLake.Gtk.GtkHScaleHandle NewWithRange(double min, double max, double step)
	{
		return GtkHScaleHandleExterns.gtk_hscale_new_with_range(min, max, step);
	}

}

public static class GtkHScaleHandleExtensions
{
}

internal class GtkHScaleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkHScaleHandle gtk_hscale_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkHScaleHandle gtk_hscale_new_with_range(double min, double max, double step);

}
