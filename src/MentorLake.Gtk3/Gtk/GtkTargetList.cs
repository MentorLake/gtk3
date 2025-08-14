namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkTargetList-struct is a reference counted list
/// of #GtkTargetPair and should be treated as
/// opaque.
/// </para>
/// </summary>

public class GtkTargetListHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTargetList from an array of #GtkTargetEntry.
/// </para>
/// </summary>

/// <param name="targets">
/// Pointer to an array
///   of #GtkTargetEntry
/// </param>
/// <param name="ntargets">
/// number of entries in @targets.
/// </param>
/// <return>
/// the new #GtkTargetList.
/// </return>

	public static MentorLake.Gtk.GtkTargetListHandle New(MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets)
	{
		return GtkTargetListExterns.gtk_target_list_new(targets, ntargets);
	}

}


public static class GtkTargetListExtensions
{
/// <summary>
/// <para>
/// Appends another target to a #GtkTargetList.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="target">
/// the interned atom representing the target
/// </param>
/// <param name="flags">
/// the flags for this target
/// </param>
/// <param name="info">
/// an ID that will be passed back to the application
/// </param>

	public static void Add(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target, uint flags, uint info)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add(list, target, flags, info);
	}

/// <summary>
/// <para>
/// Appends the image targets supported by #GtkSelectionData to
/// the target list. All targets are added with the same @info.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="info">
/// an ID that will be passed back to the application
/// </param>
/// <param name="writable">
/// whether to add only targets for which GTK+ knows
///   how to convert a pixbuf into the format
/// </param>

	public static void AddImageTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info, bool writable)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_image_targets(list, info, writable);
	}

/// <summary>
/// <para>
/// Appends the rich text targets registered with
/// gtk_text_buffer_register_serialize_format() or
/// gtk_text_buffer_register_deserialize_format() to the target list. All
/// targets are added with the same @info.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="info">
/// an ID that will be passed back to the application
/// </param>
/// <param name="deserializable">
/// if %TRUE, then deserializable rich text formats
///                  will be added, serializable formats otherwise.
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer.
/// </param>

	public static void AddRichTextTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info, bool deserializable, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_rich_text_targets(list, info, deserializable, buffer);
	}

/// <summary>
/// <para>
/// Prepends a table of #GtkTargetEntry to a target list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="targets">
/// the table of #GtkTargetEntry
/// </param>
/// <param name="ntargets">
/// number of targets in the table
/// </param>

	public static void AddTable(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gtk.GtkTargetEntry[] targets, uint ntargets)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_table(list, targets, ntargets);
	}

/// <summary>
/// <para>
/// Appends the text targets supported by #GtkSelectionData to
/// the target list. All targets are added with the same @info.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="info">
/// an ID that will be passed back to the application
/// </param>

	public static void AddTextTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_text_targets(list, info);
	}

/// <summary>
/// <para>
/// Appends the URI targets supported by #GtkSelectionData to
/// the target list. All targets are added with the same @info.
/// </para>
/// <para>
/// Since 3.24.37, this includes the application/vnd.portal.files
/// target when possible, to allow sending files between sandboxed
/// apps via the FileTransfer portal.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="info">
/// an ID that will be passed back to the application
/// </param>

	public static void AddUriTargets(this MentorLake.Gtk.GtkTargetListHandle list, uint info)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_add_uri_targets(list, info);
	}

/// <summary>
/// <para>
/// Looks up a given target in a #GtkTargetList.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="target">
/// an interned atom representing the target to search for
/// </param>
/// <param name="info">
/// a pointer to the location to store
///        application info for target, or %NULL
/// </param>
/// <return>
/// %TRUE if the target was found, otherwise %FALSE
/// </return>

	public static bool Find(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target, out uint info)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		return GtkTargetListExterns.gtk_target_list_find(list, target, out info);
	}

/// <summary>
/// <para>
/// Increases the reference count of a #GtkTargetList by one.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <return>
/// the passed in #GtkTargetList.
/// </return>

	public static MentorLake.Gtk.GtkTargetListHandle Ref(this MentorLake.Gtk.GtkTargetListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		return GtkTargetListExterns.gtk_target_list_ref(list);
	}

/// <summary>
/// <para>
/// Removes a target from a target list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>
/// <param name="target">
/// the interned atom representing the target
/// </param>

	public static void Remove(this MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_remove(list, target);
	}

/// <summary>
/// <para>
/// Decreases the reference count of a #GtkTargetList by one.
/// If the resulting reference count is zero, frees the list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GtkTargetList
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkTargetListHandle list)
	{
		if (list.IsInvalid) throw new Exception("Invalid handle (GtkTargetList)");
		GtkTargetListExterns.gtk_target_list_unref(list);
	}


	public static GtkTargetList Dereference(this GtkTargetListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTargetList>(x.DangerousGetHandle());
}
internal class GtkTargetListExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_target_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list, MentorLake.Gdk.GdkAtom target);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle list);

}

/// <summary>
/// <para>
/// A #GtkTargetList-struct is a reference counted list
/// of #GtkTargetPair and should be treated as
/// opaque.
/// </para>
/// </summary>

public struct GtkTargetList
{
}
