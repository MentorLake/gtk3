namespace MentorLake.GLib;

public class GTreeHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GTreeHandle New(MentorLake.GLib.GCompareFunc key_compare_func)
	{
		return GTreeExterns.g_tree_new(key_compare_func);
	}

	public static MentorLake.GLib.GTreeHandle NewFull(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func)
	{
		return GTreeExterns.g_tree_new_full(key_compare_func, key_compare_data, key_destroy_func, value_destroy_func);
	}

	public static MentorLake.GLib.GTreeHandle NewWithData(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data)
	{
		return GTreeExterns.g_tree_new_with_data(key_compare_func, key_compare_data);
	}

}


public static class GTreeExtensions
{
	public static void Destroy(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_destroy(tree);
	}

	public static void Foreach(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc func, IntPtr user_data)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_foreach(tree, func, user_data);
	}

	public static void ForeachNode(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseNodeFunc func, IntPtr user_data)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_foreach_node(tree, func, user_data);
	}

	public static int Height(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_height(tree);
	}

	public static void Insert(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_insert(tree, key, value);
	}

	public static MentorLake.GLib.GTreeNodeHandle InsertNode(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_insert_node(tree, key, value);
	}

	public static IntPtr Lookup(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_lookup(tree, key);
	}

	public static bool LookupExtended(this MentorLake.GLib.GTreeHandle tree, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_lookup_extended(tree, lookup_key, out orig_key, out value);
	}

	public static MentorLake.GLib.GTreeNodeHandle LookupNode(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_lookup_node(tree, key);
	}

	public static MentorLake.GLib.GTreeNodeHandle LowerBound(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_lower_bound(tree, key);
	}

	public static int Nnodes(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_nnodes(tree);
	}

	public static MentorLake.GLib.GTreeNodeHandle NodeFirst(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_node_first(tree);
	}

	public static MentorLake.GLib.GTreeNodeHandle NodeLast(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_node_last(tree);
	}

	public static MentorLake.GLib.GTreeHandle Ref(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_ref(tree);
	}

	public static bool Remove(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_remove(tree, key);
	}

	public static void RemoveAll(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_remove_all(tree);
	}

	public static void Replace(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_replace(tree, key, value);
	}

	public static MentorLake.GLib.GTreeNodeHandle ReplaceNode(this MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_replace_node(tree, key, value);
	}

	public static IntPtr Search(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_search(tree, search_func, user_data);
	}

	public static MentorLake.GLib.GTreeNodeHandle SearchNode(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_search_node(tree, search_func, user_data);
	}

	public static bool Steal(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_steal(tree, key);
	}

	public static void Traverse(this MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc traverse_func, MentorLake.GLib.GTraverseType traverse_type, IntPtr user_data)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_traverse(tree, traverse_func, traverse_type, user_data);
	}

	public static void Unref(this MentorLake.GLib.GTreeHandle tree)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		GTreeExterns.g_tree_unref(tree);
	}

	public static MentorLake.GLib.GTreeNodeHandle UpperBound(this MentorLake.GLib.GTreeHandle tree, IntPtr key)
	{
		if (tree.IsInvalid || tree.IsClosed) throw new Exception("Invalid or closed handle (GTree)");
		return GTreeExterns.g_tree_upper_bound(tree, key);
	}


	public static GTree Dereference(this GTreeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTree>(x.DangerousGetHandle());
}
internal class GTreeExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_new(MentorLake.GLib.GCompareFunc key_compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_new_full(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data, MentorLake.GLib.GDestroyNotify key_destroy_func, MentorLake.GLib.GDestroyNotify value_destroy_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_new_with_data(MentorLake.GLib.GCompareDataFunc key_compare_func, IntPtr key_compare_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_foreach_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseNodeFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_tree_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_insert_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tree_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_tree_lookup_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_lookup_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_lower_bound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_tree_nnodes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_node_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_node_last([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeHandle g_tree_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_tree_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_replace_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_tree_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_search_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GCompareFunc search_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_tree_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_traverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, MentorLake.GLib.GTraverseFunc traverse_func, MentorLake.GLib.GTraverseType traverse_type, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_tree_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTreeNodeHandle g_tree_upper_bound([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr key);

}

public struct GTree
{
}
