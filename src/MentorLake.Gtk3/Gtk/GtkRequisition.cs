namespace MentorLake.Gtk;

public class GtkRequisitionHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}

}


public static class GtkRequisitionExtensions
{
	public static MentorLake.Gtk.GtkRequisitionHandle Copy(this MentorLake.Gtk.GtkRequisitionHandle requisition)
	{
		return GtkRequisitionExterns.gtk_requisition_copy(requisition);
	}

	public static void Free(this MentorLake.Gtk.GtkRequisitionHandle requisition)
	{
		GtkRequisitionExterns.gtk_requisition_free(requisition);
	}


	public static GtkRequisition Dereference(this GtkRequisitionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRequisition>(x.DangerousGetHandle());
}
internal class GtkRequisitionExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRequisitionHandle gtk_requisition_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRequisitionHandle gtk_requisition_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequisitionHandle>))] MentorLake.Gtk.GtkRequisitionHandle requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_requisition_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequisitionHandle>))] MentorLake.Gtk.GtkRequisitionHandle requisition);

}

public struct GtkRequisition
{
	public int width;
	public int height;
}
