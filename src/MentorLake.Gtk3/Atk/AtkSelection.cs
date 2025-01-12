namespace MentorLake.Gtk3.Atk;

public interface AtkSelectionHandle
{
}

internal class AtkSelectionHandleImpl : BaseSafeHandle, AtkSelectionHandle
{
}

public static class AtkSelectionHandleExtensions
{
	public static bool AddSelection(this AtkSelectionHandle selection, int i)
	{
		return AtkSelectionExterns.atk_selection_add_selection(selection, i);
	}

	public static bool ClearSelection(this AtkSelectionHandle selection)
	{
		return AtkSelectionExterns.atk_selection_clear_selection(selection);
	}

	public static int GetSelectionCount(this AtkSelectionHandle selection)
	{
		return AtkSelectionExterns.atk_selection_get_selection_count(selection);
	}

	public static bool IsChildSelected(this AtkSelectionHandle selection, int i)
	{
		return AtkSelectionExterns.atk_selection_is_child_selected(selection, i);
	}

	public static AtkObjectHandle RefSelection(this AtkSelectionHandle selection, int i)
	{
		return AtkSelectionExterns.atk_selection_ref_selection(selection, i);
	}

	public static bool RemoveSelection(this AtkSelectionHandle selection, int i)
	{
		return AtkSelectionExterns.atk_selection_remove_selection(selection, i);
	}

	public static bool SelectAllSelection(this AtkSelectionHandle selection)
	{
		return AtkSelectionExterns.atk_selection_select_all_selection(selection);
	}

}

internal class AtkSelectionExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern bool atk_selection_add_selection(AtkSelectionHandle selection, int i);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_selection_clear_selection(AtkSelectionHandle selection);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_selection_get_selection_count(AtkSelectionHandle selection);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_selection_is_child_selected(AtkSelectionHandle selection, int i);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_selection_ref_selection(AtkSelectionHandle selection, int i);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_selection_remove_selection(AtkSelectionHandle selection, int i);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_selection_select_all_selection(AtkSelectionHandle selection);

}
