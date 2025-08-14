namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkTreeRowReference tracks model changes so that it always refers to the
/// same row (a #GtkTreePath refers to a position, not a fixed row). Create a
/// new GtkTreeRowReference with gtk_tree_row_reference_new().
/// </para>
/// </summary>

public class GtkTreeRowReferenceHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a row reference based on @path.
/// </para>
/// <para>
/// This reference will keep pointing to the node pointed to
/// by @path, so long as it exists. Any changes that occur on @model are
/// propagated, and the path is updated appropriately. If
/// @path isn’t a valid path in @model, then %NULL is returned.
/// </para>
/// </summary>

/// <param name="model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a valid #GtkTreePath-struct to monitor
/// </param>
/// <return>
/// a newly allocated #GtkTreeRowReference, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreeRowReferenceHandle New(MentorLake.Gtk.GtkTreeModelHandle model, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new(model, path);
	}

/// <summary>
/// <para>
/// You do not need to use this function.
/// </para>
/// <para>
/// Creates a row reference based on @path.
/// </para>
/// <para>
/// This reference will keep pointing to the node pointed to
/// by @path, so long as it exists. If @path isn’t a valid
/// path in @model, then %NULL is returned. However, unlike
/// references created with gtk_tree_row_reference_new(), it
/// does not listen to the model for changes. The creator of
/// the row reference must do this explicitly using
/// gtk_tree_row_reference_inserted(), gtk_tree_row_reference_deleted(),
/// gtk_tree_row_reference_reordered().
/// </para>
/// <para>
/// These functions must be called exactly once per proxy when the
/// corresponding signal on the model is emitted. This single call
/// updates all row references for that proxy. Since built-in GTK+
/// objects like #GtkTreeView already use this mechanism internally,
/// using them as the proxy object will produce unpredictable results.
/// Further more, passing the same object as @model and @proxy
/// doesn’t work for reasons of internal implementation.
/// </para>
/// <para>
/// This type of row reference is primarily meant by structures that
/// need to carefully monitor exactly when a row reference updates
/// itself, and is not generally needed by most applications.
/// </para>
/// </summary>

/// <param name="proxy">
/// a proxy #GObject
/// </param>
/// <param name="model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a valid #GtkTreePath-struct to monitor
/// </param>
/// <return>
/// a newly allocated #GtkTreeRowReference, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreeRowReferenceHandle NewProxy(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreeModelHandle model, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}

}


public static class GtkTreeRowReferenceExtensions
{
/// <summary>
/// <para>
/// Copies a #GtkTreeRowReference.
/// </para>
/// </summary>

/// <param name="reference">
/// a #GtkTreeRowReference
/// </param>
/// <return>
/// a copy of @reference
/// </return>

	public static MentorLake.Gtk.GtkTreeRowReferenceHandle Copy(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_copy(reference);
	}

/// <summary>
/// <para>
/// Free’s @reference. @reference may be %NULL
/// </para>
/// </summary>

/// <param name="reference">
/// a #GtkTreeRowReference, or %NULL
/// </param>

	public static void Free(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_free(reference);
	}

/// <summary>
/// <para>
/// Returns the model that the row reference is monitoring.
/// </para>
/// </summary>

/// <param name="reference">
/// a #GtkTreeRowReference
/// </param>
/// <return>
/// the model
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_model(reference);
	}

/// <summary>
/// <para>
/// Returns a path that the row reference currently points to,
/// or %NULL if the path pointed to is no longer valid.
/// </para>
/// </summary>

/// <param name="reference">
/// a #GtkTreeRowReference
/// </param>
/// <return>
/// a current path, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle GetPath(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_path(reference);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the @reference is non-%NULL and refers to
/// a current valid path.
/// </para>
/// </summary>

/// <param name="reference">
/// a #GtkTreeRowReference, or %NULL
/// </param>
/// <return>
/// %TRUE if @reference points to a valid path
/// </return>

	public static bool Valid(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_valid(reference);
	}


	public static GtkTreeRowReference Dereference(this GtkTreeRowReferenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeRowReference>(x.DangerousGetHandle());
}
internal class GtkTreeRowReferenceExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeRowReferenceHandle gtk_tree_row_reference_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeRowReferenceHandle gtk_tree_row_reference_new_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))]
	internal static extern MentorLake.Gtk.GtkTreeRowReferenceHandle gtk_tree_row_reference_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))] MentorLake.Gtk.GtkTreeRowReferenceHandle reference);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))] MentorLake.Gtk.GtkTreeRowReferenceHandle reference);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_row_reference_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))] MentorLake.Gtk.GtkTreeRowReferenceHandle reference);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_row_reference_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))] MentorLake.Gtk.GtkTreeRowReferenceHandle reference);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_row_reference_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeRowReferenceHandle>))] MentorLake.Gtk.GtkTreeRowReferenceHandle reference);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_row_reference_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order);

}

/// <summary>
/// <para>
/// A GtkTreeRowReference tracks model changes so that it always refers to the
/// same row (a #GtkTreePath refers to a position, not a fixed row). Create a
/// new GtkTreeRowReference with gtk_tree_row_reference_new().
/// </para>
/// </summary>

public struct GtkTreeRowReference
{
/// <summary>
/// <para>
/// Lets a set of row reference created by
/// gtk_tree_row_reference_new_proxy() know that the
/// model emitted the #GtkTreeModel::row-deleted signal.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GObject
/// </param>
/// <param name="path">
/// the path position that was deleted
/// </param>

	public static void Deleted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_deleted(proxy, path);
	}

/// <summary>
/// <para>
/// Lets a set of row reference created by
/// gtk_tree_row_reference_new_proxy() know that the
/// model emitted the #GtkTreeModel::row-inserted signal.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GObject
/// </param>
/// <param name="path">
/// the row position that was inserted
/// </param>

	public static void Inserted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_inserted(proxy, path);
	}

/// <summary>
/// <para>
/// Lets a set of row reference created by
/// gtk_tree_row_reference_new_proxy() know that the
/// model emitted the #GtkTreeModel::rows-reordered signal.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GObject
/// </param>
/// <param name="path">
/// the parent path of the reordered signal
/// </param>
/// <param name="iter">
/// the iter pointing to the parent of the reordered
/// </param>
/// <param name="new_order">
/// the new order of rows
/// </param>

	public static void Reordered(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_reordered(proxy, path, iter, new_order);
	}

}
