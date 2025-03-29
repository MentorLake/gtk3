namespace MentorLake.Gtk;

public class GtkTargetListHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkTargetListHandle New(MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets)
	{
		return GtkTargetListExterns.gtk_target_list_new(targets, ntargets);
	}

}


public static class GtkTargetListExtensions
{
	public static void Add(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target, uint flags, uint info)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add(list, target, flags, info);
	}

	public static void AddImageTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info, bool writable)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_image_targets(list, info, writable);
	}

	public static void AddRichTextTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info, bool deserializable, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_rich_text_targets(list, info, deserializable, buffer);
	}

	public static void AddTable(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_table(list, targets, ntargets);
	}

	public static void AddTextTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_text_targets(list, info);
	}

	public static void AddUriTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_uri_targets(list, info);
	}

	public static bool Find(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target, out uint info)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		return GtkTargetListExterns.gtk_target_list_find(list, target, out info);
	}

	public static MentorLake.Gtk.GtkTargetListHandle Ref(this MentorLake.Gtk.GtkTargetListHandle list)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		return GtkTargetListExterns.gtk_target_list_ref(list);
	}

	public static void Remove(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_remove(list, target);
	}

	public static void Unref(this MentorLake.Gtk.GtkTargetListHandle list)
	{
		if (list.IsInvalid || list.IsClosed) throw new Exception("Invalid or closed handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_unref(list);
	}


	public static GtkTargetList Dereference(this GtkTargetListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTargetList>(x.DangerousGetHandle());
}
internal class GtkTargetListExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_target_list_new(MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target, uint flags, uint info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_add_image_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, uint info, bool writable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_add_rich_text_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, uint info, bool deserializable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_add_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_add_text_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, uint info);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_add_uri_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, uint info);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_target_list_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target, out uint info);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_target_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list);

}

public struct GtkTargetList
{
}
