namespace MentorLake.Gtk;

public class GtkBorderHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}

}


public static class GtkBorderExtensions
{
	public static MentorLake.Gtk.GtkBorderHandle Copy(this MentorLake.Gtk.GtkBorderHandle border_)
	{
		return GtkBorderExterns.gtk_border_copy(border_);
	}

	public static void Free(this MentorLake.Gtk.GtkBorderHandle border_)
	{
		GtkBorderExterns.gtk_border_free(border_);
	}


	public static GtkBorder Dereference(this GtkBorderHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBorder>(x.DangerousGetHandle());
}
internal class GtkBorderExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBorderHandle gtk_border_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBorderHandle gtk_border_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))] MentorLake.Gtk.GtkBorderHandle border_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_border_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))] MentorLake.Gtk.GtkBorderHandle border_);

}

public struct GtkBorder
{
	public short left;
	public short right;
	public short top;
	public short bottom;
}
