namespace MentorLake.Gtk3.Atk;

public interface AtkTextHandle
{
}

internal class AtkTextHandleImpl : BaseSafeHandle, AtkTextHandle
{
}

public static class AtkTextHandleExtensions
{
	public static bool AddSelection(this AtkTextHandle text, int start_offset, int end_offset)
	{
		return AtkTextExterns.atk_text_add_selection(text, start_offset, end_offset);
	}

	public static IntPtr GetBoundedRanges(this AtkTextHandle text, AtkTextRectangleHandle rect, AtkCoordType coord_type, AtkTextClipType x_clip_type, AtkTextClipType y_clip_type)
	{
		return AtkTextExterns.atk_text_get_bounded_ranges(text, rect, coord_type, x_clip_type, y_clip_type);
	}

	public static int GetCaretOffset(this AtkTextHandle text)
	{
		return AtkTextExterns.atk_text_get_caret_offset(text);
	}

	public static char GetCharacterAtOffset(this AtkTextHandle text, int offset)
	{
		return AtkTextExterns.atk_text_get_character_at_offset(text, offset);
	}

	public static int GetCharacterCount(this AtkTextHandle text)
	{
		return AtkTextExterns.atk_text_get_character_count(text);
	}

	public static AtkTextHandle GetCharacterExtents(this AtkTextHandle text, int offset, out int x, out int y, out int width, out int height, AtkCoordType coords)
	{
		AtkTextExterns.atk_text_get_character_extents(text, offset, out x, out y, out width, out height, coords);
		return text;
	}

	public static AtkAttributeSetHandle GetDefaultAttributes(this AtkTextHandle text)
	{
		return AtkTextExterns.atk_text_get_default_attributes(text);
	}

	public static int GetNSelections(this AtkTextHandle text)
	{
		return AtkTextExterns.atk_text_get_n_selections(text);
	}

	public static int GetOffsetAtPoint(this AtkTextHandle text, int x, int y, AtkCoordType coords)
	{
		return AtkTextExterns.atk_text_get_offset_at_point(text, x, y, coords);
	}

	public static AtkTextHandle GetRangeExtents(this AtkTextHandle text, int start_offset, int end_offset, AtkCoordType coord_type, out AtkTextRectangle rect)
	{
		AtkTextExterns.atk_text_get_range_extents(text, start_offset, end_offset, coord_type, out rect);
		return text;
	}

	public static AtkAttributeSetHandle GetRunAttributes(this AtkTextHandle text, int offset, out int start_offset, out int end_offset)
	{
		return AtkTextExterns.atk_text_get_run_attributes(text, offset, out start_offset, out end_offset);
	}

	public static string GetSelection(this AtkTextHandle text, int selection_num, out int start_offset, out int end_offset)
	{
		return AtkTextExterns.atk_text_get_selection(text, selection_num, out start_offset, out end_offset);
	}

	public static string GetStringAtOffset(this AtkTextHandle text, int offset, AtkTextGranularity granularity, out int start_offset, out int end_offset)
	{
		return AtkTextExterns.atk_text_get_string_at_offset(text, offset, granularity, out start_offset, out end_offset);
	}

	public static string GetText(this AtkTextHandle text, int start_offset, int end_offset)
	{
		return AtkTextExterns.atk_text_get_text(text, start_offset, end_offset);
	}

	public static string GetTextAfterOffset(this AtkTextHandle text, int offset, AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		return AtkTextExterns.atk_text_get_text_after_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

	public static string GetTextAtOffset(this AtkTextHandle text, int offset, AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		return AtkTextExterns.atk_text_get_text_at_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

	public static string GetTextBeforeOffset(this AtkTextHandle text, int offset, AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		return AtkTextExterns.atk_text_get_text_before_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

	public static bool RemoveSelection(this AtkTextHandle text, int selection_num)
	{
		return AtkTextExterns.atk_text_remove_selection(text, selection_num);
	}

	public static bool ScrollSubstringTo(this AtkTextHandle text, int start_offset, int end_offset, AtkScrollType type)
	{
		return AtkTextExterns.atk_text_scroll_substring_to(text, start_offset, end_offset, type);
	}

	public static bool ScrollSubstringToPoint(this AtkTextHandle text, int start_offset, int end_offset, AtkCoordType coords, int x, int y)
	{
		return AtkTextExterns.atk_text_scroll_substring_to_point(text, start_offset, end_offset, coords, x, y);
	}

	public static bool SetCaretOffset(this AtkTextHandle text, int offset)
	{
		return AtkTextExterns.atk_text_set_caret_offset(text, offset);
	}

	public static bool SetSelection(this AtkTextHandle text, int selection_num, int start_offset, int end_offset)
	{
		return AtkTextExterns.atk_text_set_selection(text, selection_num, start_offset, end_offset);
	}

}

internal class AtkTextExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern bool atk_text_add_selection(AtkTextHandle text, int start_offset, int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern IntPtr atk_text_get_bounded_ranges(AtkTextHandle text, AtkTextRectangleHandle rect, AtkCoordType coord_type, AtkTextClipType x_clip_type, AtkTextClipType y_clip_type);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_text_get_caret_offset(AtkTextHandle text);

	[DllImport(Libraries.Atk)]
	internal static extern char atk_text_get_character_at_offset(AtkTextHandle text, int offset);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_text_get_character_count(AtkTextHandle text);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_text_get_character_extents(AtkTextHandle text, int offset, out int x, out int y, out int width, out int height, AtkCoordType coords);

	[DllImport(Libraries.Atk)]
	internal static extern AtkAttributeSetHandle atk_text_get_default_attributes(AtkTextHandle text);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_text_get_n_selections(AtkTextHandle text);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_text_get_offset_at_point(AtkTextHandle text, int x, int y, AtkCoordType coords);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_text_get_range_extents(AtkTextHandle text, int start_offset, int end_offset, AtkCoordType coord_type, out AtkTextRectangle rect);

	[DllImport(Libraries.Atk)]
	internal static extern AtkAttributeSetHandle atk_text_get_run_attributes(AtkTextHandle text, int offset, out int start_offset, out int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_text_get_selection(AtkTextHandle text, int selection_num, out int start_offset, out int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_text_get_string_at_offset(AtkTextHandle text, int offset, AtkTextGranularity granularity, out int start_offset, out int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_text_get_text(AtkTextHandle text, int start_offset, int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_text_get_text_after_offset(AtkTextHandle text, int offset, AtkTextBoundary boundary_type, out int start_offset, out int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_text_get_text_at_offset(AtkTextHandle text, int offset, AtkTextBoundary boundary_type, out int start_offset, out int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_text_get_text_before_offset(AtkTextHandle text, int offset, AtkTextBoundary boundary_type, out int start_offset, out int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_text_remove_selection(AtkTextHandle text, int selection_num);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_text_scroll_substring_to(AtkTextHandle text, int start_offset, int end_offset, AtkScrollType type);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_text_scroll_substring_to_point(AtkTextHandle text, int start_offset, int end_offset, AtkCoordType coords, int x, int y);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_text_set_caret_offset(AtkTextHandle text, int offset);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_text_set_selection(AtkTextHandle text, int selection_num, int start_offset, int end_offset);

}
