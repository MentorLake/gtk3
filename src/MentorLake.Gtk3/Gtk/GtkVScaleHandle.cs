namespace MentorLake.Gtk;

public class GtkVScaleHandle : GtkScaleHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkVScaleHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkVScaleHandleExterns.gtk_vscale_new(adjustment);
	}

	public static MentorLake.Gtk.GtkVScaleHandle NewWithRange(double min, double max, double step)
	{
		return GtkVScaleHandleExterns.gtk_vscale_new_with_range(min, max, step);
	}

}

public static class GtkVScaleHandleExtensions
{
}

internal class GtkVScaleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkVScaleHandle gtk_vscale_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVScaleHandle>))]
	internal static extern MentorLake.Gtk.GtkVScaleHandle gtk_vscale_new_with_range(double min, double max, double step);

}
