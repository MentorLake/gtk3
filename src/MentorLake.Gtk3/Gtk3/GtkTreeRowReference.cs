namespace MentorLake.Gtk3.Gtk3;

public class GtkTreeRowReferenceHandle : BaseSafeHandle
{
	public static GtkTreeRowReferenceHandle New(GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new(model, path);
	}

	public static GtkTreeRowReferenceHandle NewProxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}

}


public static class GtkTreeRowReferenceHandleExtensions
{
	public static GtkTreeRowReferenceHandle Copy(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_copy(reference);
	}

	public static T Free<T>(this T reference) where T : GtkTreeRowReferenceHandle
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_free(reference);
		return reference;
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_model(reference);
	}

	public static GtkTreePathHandle GetPath(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_path(reference);
	}

	public static bool Valid(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_valid(reference);
	}

	public static void Deleted(GObjectHandle proxy, GtkTreePathHandle path)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_deleted(proxy, path);
	}

	public static void Inserted(GObjectHandle proxy, GtkTreePathHandle path)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_inserted(proxy, path);
	}

	public static void Reordered(GObjectHandle proxy, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_reordered(proxy, path, iter, new_order);
	}

}
internal class GtkTreeRowReferenceExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new(GtkTreeModelHandle model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new_proxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_copy(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_row_reference_free(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_tree_row_reference_get_model(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreePathHandle gtk_tree_row_reference_get_path(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tree_row_reference_valid(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_row_reference_deleted(GObjectHandle proxy, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_row_reference_inserted(GObjectHandle proxy, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_row_reference_reordered(GObjectHandle proxy, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order);

}

public struct GtkTreeRowReference
{
}
