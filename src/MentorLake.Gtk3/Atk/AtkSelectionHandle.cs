namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface implemented by container objects whose #AtkObject children can be selected.
/// </para>
/// <para>
/// #AtkSelection should be implemented by UI components with children
/// which are exposed by #atk_object_ref_child and
/// #atk_object_get_n_children, if the use of the parent UI component
/// ordinarily involves selection of one or more of the objects
/// corresponding to those #AtkObject children - for example,
/// selectable lists.
/// </para>
/// <para>
/// Note that other types of "selection" (for instance text selection)
/// are accomplished a other ATK interfaces - #AtkSelection is limited
/// to the selection/deselection of children.
/// </para>
/// </summary>

public interface AtkSelectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkSelectionHandleImpl : BaseSafeHandle, AtkSelectionHandle
{
}

public static class AtkSelectionHandleExtensions
{
/// <summary>
/// <para>
/// Adds the specified accessible child of the object to the
/// object's selection.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <param name="i">
/// a #gint specifying the child index.
/// </param>
/// <return>
/// TRUE if success, FALSE otherwise.
/// </return>

	public static bool AddSelection(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_add_selection(selection, i);
	}

/// <summary>
/// <para>
/// Clears the selection in the object so that no children in the object
/// are selected.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <return>
/// TRUE if success, FALSE otherwise.
/// </return>

	public static bool ClearSelection(this MentorLake.Atk.AtkSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_clear_selection(selection);
	}

/// <summary>
/// <para>
/// Gets the number of accessible children currently selected.
/// Note: callers should not rely on %NULL or on a zero value for
/// indication of whether AtkSelectionIface is implemented, they should
/// use type checking/interface checking macros or the
/// atk_get_accessible_value() convenience method.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <return>
/// a gint representing the number of items selected, or 0
/// if @selection does not implement this interface.
/// </return>

	public static int GetSelectionCount(this MentorLake.Atk.AtkSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_get_selection_count(selection);
	}

/// <summary>
/// <para>
/// Determines if the current child of this object is selected
/// Note: callers should not rely on %NULL or on a zero value for
/// indication of whether AtkSelectionIface is implemented, they should
/// use type checking/interface checking macros or the
/// atk_get_accessible_value() convenience method.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <param name="i">
/// a #gint specifying the child index.
/// </param>
/// <return>
/// a gboolean representing the specified child is selected, or 0
/// if @selection does not implement this interface.
/// </return>

	public static bool IsChildSelected(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_is_child_selected(selection, i);
	}

/// <summary>
/// <para>
/// Gets a reference to the accessible object representing the specified
/// selected child of the object.
/// Note: callers should not rely on %NULL or on a zero value for
/// indication of whether AtkSelectionIface is implemented, they should
/// use type checking/interface checking macros or the
/// atk_get_accessible_value() convenience method.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <param name="i">
/// a #gint specifying the index in the selection set.  (e.g. the
/// ith selection as opposed to the ith child).
/// </param>
/// <return>
/// an #AtkObject representing the
/// selected accessible, or %NULL if @selection does not implement this
/// interface.
/// </return>

	public static MentorLake.Atk.AtkObjectHandle RefSelection(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_ref_selection(selection, i);
	}

/// <summary>
/// <para>
/// Removes the specified child of the object from the object's selection.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <param name="i">
/// a #gint specifying the index in the selection set.  (e.g. the
/// ith selection as opposed to the ith child).
/// </param>
/// <return>
/// TRUE if success, FALSE otherwise.
/// </return>

	public static bool RemoveSelection(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_remove_selection(selection, i);
	}

/// <summary>
/// <para>
/// Causes every child of the object to be selected if the object
/// supports multiple selections.
/// </para>
/// </summary>

/// <param name="selection">
/// a #GObject instance that implements AtkSelectionIface
/// </param>
/// <return>
/// TRUE if success, FALSE otherwise.
/// </return>

	public static bool SelectAllSelection(this MentorLake.Atk.AtkSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_select_all_selection(selection);
	}

}

internal class AtkSelectionHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_selection_add_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_selection_clear_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_selection_get_selection_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_selection_is_child_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_selection_ref_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_selection_remove_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_selection_select_all_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle selection);

}
