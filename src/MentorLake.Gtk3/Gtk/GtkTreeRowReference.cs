namespace MentorLake.Gtk;

public class GtkTreeRowReferenceHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkTreeRowReferenceHandle New(MentorLake.Gtk.GtkTreeModelHandle model, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new(model, path);
	}

	public static MentorLake.Gtk.GtkTreeRowReferenceHandle NewProxy(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreeModelHandle model, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}

}


public static class GtkTreeRowReferenceExtensions
{
	public static MentorLake.Gtk.GtkTreeRowReferenceHandle Copy(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_copy(reference);
	}

	public static void Free(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_free(reference);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_model(reference);
	}

	public static MentorLake.Gtk.GtkTreePathHandle GetPath(this MentorLake.Gtk.GtkTreeRowReferenceHandle reference)
	{
		if (reference.IsInvalid) throw new Exception("Invalid handle (GtkTreeRowReference)");
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_path(reference);
	}

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

public struct GtkTreeRowReference
{
	public static void Deleted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_deleted(proxy, path);
	}

	public static void Inserted(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_inserted(proxy, path);
	}

	public static void Reordered(MentorLake.GObject.GObjectHandle proxy, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_reordered(proxy, path, iter, new_order);
	}

}
