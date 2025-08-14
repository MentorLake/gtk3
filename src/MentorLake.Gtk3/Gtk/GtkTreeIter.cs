namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTreeIter is the primary structure
/// for accessing a #GtkTreeModel. Models are expected to put a unique
/// integer in the @stamp member, and put
/// model-specific data in the three @user_data
/// members.
/// </para>
/// </summary>

public class GtkTreeIterHandle : BaseSafeHandle
{
}


public static class GtkTreeIterExtensions
{
/// <summary>
/// <para>
/// Creates a dynamically allocated tree iterator as a copy of @iter.
/// </para>
/// <para>
/// This function is not intended for use in applications,
/// because you can just copy the structs by value
/// (`GtkTreeIter new_iter = iter;`).
/// You must free this iter with gtk_tree_iter_free().
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTreeIter-struct
/// </param>
/// <return>
/// a newly-allocated copy of @iter
/// </return>

	public static MentorLake.Gtk.GtkTreeIterHandle Copy(this MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTreeIter)");
		return GtkTreeIterExterns.gtk_tree_iter_copy(iter);
	}

/// <summary>
/// <para>
/// Frees an iterator that has been allocated by gtk_tree_iter_copy().
/// </para>
/// <para>
/// This function is mainly used for language bindings.
/// </para>
/// </summary>

/// <param name="iter">
/// a dynamically allocated tree iterator
/// </param>

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

/// <summary>
/// <para>
/// The #GtkTreeIter is the primary structure
/// for accessing a #GtkTreeModel. Models are expected to put a unique
/// integer in the @stamp member, and put
/// model-specific data in the three @user_data
/// members.
/// </para>
/// </summary>

public struct GtkTreeIter
{
	/// <summary>
/// <para>
/// a unique stamp to catch invalid iterators
/// </para>
/// </summary>

public int stamp;
	/// <summary>
/// <para>
/// model-specific data
/// </para>
/// </summary>

public IntPtr user_data;
	/// <summary>
/// <para>
/// model-specific data
/// </para>
/// </summary>

public IntPtr user_data2;
	/// <summary>
/// <para>
/// model-specific data
/// </para>
/// </summary>

public IntPtr user_data3;
}
