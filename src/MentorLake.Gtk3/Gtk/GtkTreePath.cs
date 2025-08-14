namespace MentorLake.Gtk;


public class GtkTreePathHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTreePath-struct.
/// This refers to a row.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkTreePath-struct.
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle New()
	{
		return GtkTreePathExterns.gtk_tree_path_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreePath-struct.
/// </para>
/// <para>
/// The string representation of this path is “0”.
/// </para>
/// </summary>

/// <return>
/// A new #GtkTreePath-struct
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle NewFirst()
	{
		return GtkTreePathExterns.gtk_tree_path_new_first();
	}

/// <summary>
/// <para>
/// Creates a new path with @first_index and @varargs as indices.
/// </para>
/// </summary>

/// <param name="first_index">
/// first integer
/// </param>
/// <param name="@__arglist">
/// list of integers terminated by -1
/// </param>
/// <return>
/// A newly created #GtkTreePath-struct
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle NewFromIndices(int first_index, IntPtr @__arglist)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indices(first_index, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new path with the given @indices array of @length.
/// </para>
/// </summary>

/// <param name="indices">
/// array of indices
/// </param>
/// <param name="length">
/// length of @indices array
/// </param>
/// <return>
/// A newly created #GtkTreePath-struct
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle NewFromIndicesv(int[] indices, UIntPtr length)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indicesv(indices, length);
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreePath-struct initialized to @path.
/// </para>
/// <para>
/// @path is expected to be a colon separated list of numbers.
/// For example, the string “10:4:0” would create a path of depth
/// 3 pointing to the 11th child of the root node, the 5th
/// child of that 11th child, and the 1st child of that 5th child.
/// If an invalid path string is passed in, %NULL is returned.
/// </para>
/// </summary>

/// <param name="path">
/// The string representation of a path
/// </param>
/// <return>
/// A newly-created #GtkTreePath-struct, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle NewFromString(string path)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_string(path);
	}

}


public static class GtkTreePathExtensions
{
/// <summary>
/// <para>
/// Appends a new index to a path.
/// </para>
/// <para>
/// As a result, the depth of the path is increased.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <param name="index_">
/// the index
/// </param>

	public static void AppendIndex(this MentorLake.Gtk.GtkTreePathHandle path, int index_)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_append_index(path, index_);
	}

/// <summary>
/// <para>
/// Compares two paths.
/// </para>
/// <para>
/// If @a appears before @b in a tree, then -1 is returned.
/// If @b appears before @a, then 1 is returned.
/// If the two nodes are equal, then 0 is returned.
/// </para>
/// </summary>

/// <param name="a">
/// a #GtkTreePath-struct
/// </param>
/// <param name="b">
/// a #GtkTreePath-struct to compare with
/// </param>
/// <return>
/// the relative positions of @a and @b
/// </return>

	public static int Compare(this MentorLake.Gtk.GtkTreePathHandle a, MentorLake.Gtk.GtkTreePathHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_compare(a, b);
	}

/// <summary>
/// <para>
/// Creates a new #GtkTreePath-struct as a copy of @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <return>
/// a new #GtkTreePath-struct
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle Copy(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_copy(path);
	}

/// <summary>
/// <para>
/// Moves @path to point to the first child of the current path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>

	public static void Down(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_down(path);
	}

/// <summary>
/// <para>
/// Frees @path. If @path is %NULL, it simply returns.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>

	public static void Free(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_free(path);
	}

/// <summary>
/// <para>
/// Returns the current depth of @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <return>
/// The depth of @path
/// </return>

	public static int GetDepth(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_get_depth(path);
	}

/// <summary>
/// <para>
/// Returns the current indices of @path.
/// </para>
/// <para>
/// This is an array of integers, each representing a node in a tree.
/// This value should not be freed.
/// </para>
/// <para>
/// The length of the array can be obtained with gtk_tree_path_get_depth().
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <return>
/// The current indices, or %NULL
/// </return>

	public static int GetIndices(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_get_indices(path);
	}

/// <summary>
/// <para>
/// Returns the current indices of @path.
/// </para>
/// <para>
/// This is an array of integers, each representing a node in a tree.
/// It also returns the number of elements in the array.
/// The array should not be freed.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <param name="depth">
/// return location for number of elements
///     returned in the integer array, or %NULL
/// </param>
/// <return>
/// The current
///     indices, or %NULL
/// </return>

	public static int[] GetIndicesWithDepth(this MentorLake.Gtk.GtkTreePathHandle path, out int depth)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_get_indices_with_depth(path, out depth);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @descendant is a descendant of @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <param name="descendant">
/// another #GtkTreePath-struct
/// </param>
/// <return>
/// %TRUE if @descendant is contained inside @path
/// </return>

	public static bool IsAncestor(this MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreePathHandle descendant)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_is_ancestor(path, descendant);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @path is a descendant of @ancestor.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <param name="ancestor">
/// another #GtkTreePath-struct
/// </param>
/// <return>
/// %TRUE if @ancestor contains @path somewhere below it
/// </return>

	public static bool IsDescendant(this MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreePathHandle ancestor)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_is_descendant(path, ancestor);
	}

/// <summary>
/// <para>
/// Moves the @path to point to the next node at the current depth.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>

	public static void Next(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_next(path);
	}

/// <summary>
/// <para>
/// Prepends a new index to a path.
/// </para>
/// <para>
/// As a result, the depth of the path is increased.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <param name="index_">
/// the index
/// </param>

	public static void PrependIndex(this MentorLake.Gtk.GtkTreePathHandle path, int index_)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		GtkTreePathExterns.gtk_tree_path_prepend_index(path, index_);
	}

/// <summary>
/// <para>
/// Moves the @path to point to the previous node at the
/// current depth, if it exists.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <return>
/// %TRUE if @path has a previous node, and
///     the move was made
/// </return>

	public static bool Prev(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_prev(path);
	}

/// <summary>
/// <para>
/// Generates a string representation of the path.
/// </para>
/// <para>
/// This string is a “:” separated list of numbers.
/// For example, “4:10:0:3” would be an acceptable
/// return value for this string.
/// </para>
/// </summary>

/// <param name="path">
/// A #GtkTreePath-struct
/// </param>
/// <return>
/// A newly-allocated string.
///     Must be freed with g_free().
/// </return>

	public static string ToString(this MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkTreePath)");
		return GtkTreePathExterns.gtk_tree_path_to_string(path);
	}

/// <summary>
/// <para>
/// Moves the @path to point to its parent node, if it has a parent.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkTreePath-struct
/// </param>
/// <return>
/// %TRUE if @path has a parent, and the move was made
/// </return>

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
