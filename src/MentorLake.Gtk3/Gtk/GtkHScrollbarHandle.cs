namespace MentorLake.Gtk;

public class GtkHScrollbarHandle : GtkScrollbarHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkHScrollbarHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkHScrollbarHandleExterns.gtk_hscrollbar_new(adjustment);
	}

}

public static class GtkHScrollbarHandleExtensions
{
}

internal class GtkHScrollbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkHScrollbarHandle gtk_hscrollbar_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
