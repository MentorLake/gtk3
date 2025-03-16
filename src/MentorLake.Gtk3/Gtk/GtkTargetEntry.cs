namespace MentorLake.Gtk;

public class GtkTargetEntryHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkTargetEntryHandle New(string target, uint flags, uint info)
	{
		return GtkTargetEntryExterns.gtk_target_entry_new(target, flags, info);
	}

}


public static class GtkTargetEntryExtensions
{
	public static MentorLake.Gtk.GtkTargetEntryHandle Copy(this MentorLake.Gtk.GtkTargetEntryHandle data)
	{
		return GtkTargetEntryExterns.gtk_target_entry_copy(data);
	}

	public static void Free(this MentorLake.Gtk.GtkTargetEntryHandle data)
	{
		GtkTargetEntryExterns.gtk_target_entry_free(data);
	}


	public static GtkTargetEntry Dereference(this GtkTargetEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTargetEntry>(x.DangerousGetHandle());
}
internal class GtkTargetEntryExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetEntryHandle gtk_target_entry_new(string target, uint flags, uint info);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetEntryHandle gtk_target_entry_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))] MentorLake.Gtk.GtkTargetEntryHandle data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_entry_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))] MentorLake.Gtk.GtkTargetEntryHandle data);

}

public struct GtkTargetEntry
{
	public string target;
	public uint flags;
	public uint info;
}
