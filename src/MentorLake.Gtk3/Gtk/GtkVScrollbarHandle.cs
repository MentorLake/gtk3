namespace MentorLake.Gtk;

public class GtkVScrollbarHandle : GtkScrollbarHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkVScrollbarHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment)
	{
		return GtkVScrollbarHandleExterns.gtk_vscrollbar_new(adjustment);
	}

}

public static class GtkVScrollbarHandleExtensions
{
}

internal class GtkVScrollbarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkVScrollbarHandle>))]
	internal static extern MentorLake.Gtk.GtkVScrollbarHandle gtk_vscrollbar_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

}
