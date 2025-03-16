namespace MentorLake.Gtk;

public class GtkScrollbarHandle : GtkRangeHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkScrollbarHandle New(MentorLake.Gtk.GtkOrientation orientation, MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkScrollbarHandleExterns.gtk_scrollbar_new(orientation, adjustment);
	}

}

public static class GtkScrollbarHandleExtensions
{
}

internal class GtkScrollbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScrollbarHandle gtk_scrollbar_new(MentorLake.Gtk.GtkOrientation orientation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
