namespace MentorLake.Gtk;

public class GtkTreePathHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkTreePathHandle New()
	{
		return GtkTreePathExterns.gtk_tree_path_new();
	}

	public static MentorLake.Gtk.GtkTreePathHandle NewFirst()
	{
		return GtkTreePathExterns.gtk_tree_path_new_first();
	}

	public static MentorLake.Gtk.GtkTreePathHandle NewFromIndices(int first_index, IntPtr @__arglist)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indices(first_index, @__arglist);
	}

	public static MentorLake.Gtk.GtkTreePathHandle NewFromIndicesv(int[] indices, UIntPtr length)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indicesv(indices, length);
	}

	public static MentorLake.Gtk.GtkTreePathHandle NewFromString(string path)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_string(path);
	}

}


public static class GtkTreePathExtensions
{
	public static void AppendIndex(this MentorLake.Gtk.GtkTreePathHandle path, int index_)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_append_index(path, index_);
	}

	public static int Compare(this MentorLake.Gtk.GtkTreePathHandle a, MentorLake.Gtk.GtkTreePathHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_compare(a, b);
	}

	public static MentorLake.Gtk.GtkTreePathHandle Copy(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_copy(path);
	}

	public static void Down(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_down(path);
	}

	public static void Free(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_free(path);
	}

	public static int GetDepth(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_get_depth(path);
	}

	public static int GetIndices(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_get_indices(path);
	}

	public static int[] GetIndicesWithDepth(this MentorLake.Gtk.GtkTreePathHandle path, out int depth)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_get_indices_with_depth(path, out depth);
	}

	public static bool IsAncestor(this MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreePathHandle descendant)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_is_ancestor(path, descendant);
	}

	public static bool IsDescendant(this MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreePathHandle ancestor)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_is_descendant(path, ancestor);
	}

	public static void Next(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_next(path);
	}

	public static void PrependIndex(this MentorLake.Gtk.GtkTreePathHandle path, int index_)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_prepend_index(path, index_);
	}

	public static bool Prev(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_prev(path);
	}

	public static string ToString(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_to_string(path);
	}

	public static bool Up(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_up(path);
	}


	public static GtkTreePath Dereference(this GtkTreePathHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreePath>(x.DangerousGetHandle());
}
internal class GtkTreePathExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_path_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_path_new_first();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_path_new_from_indices(int first_index, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_path_new_from_indicesv(int[] indices, UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_path_new_from_string(string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_path_append_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_path_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle b);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_path_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_path_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_path_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_path_get_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_path_get_indices([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern int[] gtk_tree_path_get_indices_with_depth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, out int depth);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_path_is_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle descendant);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_path_is_descendant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle ancestor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_path_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_path_prepend_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_path_prev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tree_path_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_path_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

}

public struct GtkTreePath
{
}
