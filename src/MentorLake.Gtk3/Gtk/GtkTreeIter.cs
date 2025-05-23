namespace MentorLake.Gtk;

public class GtkTreeIterHandle : BaseSafeHandle
{
}


public static class GtkTreeIterExtensions
{
	public static MentorLake.Gtk.GtkTreeIterHandle Copy(this MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTreeIter)");
		return GtkTreeIterExterns.gtk_tree_iter_copy(iter);
	}

	public static void Free(this MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTreeIter)");
		GtkTreeIterExterns.gtk_tree_iter_free(iter);
	}


	public static GtkTreeIter Dereference(this GtkTreeIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeIter>(x.DangerousGetHandle());
}
internal class GtkTreeIterExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeIterHandle gtk_tree_iter_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

}

public struct GtkTreeIter
{
	public int stamp;
	public IntPtr user_data;
	public IntPtr user_data2;
	public IntPtr user_data3;
}
