namespace MentorLake.Atk;

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
	public static bool AddSelection(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_add_selection(selection, i);
	}

	public static bool ClearSelection(this MentorLake.Atk.AtkSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_clear_selection(selection);
	}

	public static int GetSelectionCount(this MentorLake.Atk.AtkSelectionHandle selection)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_get_selection_count(selection);
	}

	public static bool IsChildSelected(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_is_child_selected(selection, i);
	}

	public static MentorLake.Atk.AtkObjectHandle RefSelection(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_ref_selection(selection, i);
	}

	public static bool RemoveSelection(this MentorLake.Atk.AtkSelectionHandle selection, int i)
	{
		if (selection.IsInvalid) throw new Exception("Invalid handle (AtkSelectionHandle)");
		return AtkSelectionHandleExterns.atk_selection_remove_selection(selection, i);
	}

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
