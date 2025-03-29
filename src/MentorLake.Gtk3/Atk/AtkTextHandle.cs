namespace MentorLake.Atk;

public interface AtkTextHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkTextHandleImpl : BaseSafeHandle, AtkTextHandle
{
}

public static class AtkTextHandleExtensions
{
	public static bool AddSelection(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_add_selection(text, start_offset, end_offset);
	}

	public static MentorLake.Atk.AtkTextRangeHandle[] GetBoundedRanges(this MentorLake.Atk.AtkTextHandle text, MentorLake.Atk.AtkTextRectangleHandle rect, MentorLake.Atk.AtkCoordType coord_type, MentorLake.Atk.AtkTextClipType x_clip_type, MentorLake.Atk.AtkTextClipType y_clip_type)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_bounded_ranges(text, rect, coord_type, x_clip_type, y_clip_type);
	}

	public static int GetCaretOffset(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_caret_offset(text);
	}

	public static char GetCharacterAtOffset(this MentorLake.Atk.AtkTextHandle text, int offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_character_at_offset(text, offset);
	}

	public static int GetCharacterCount(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_character_count(text);
	}

	public static T GetCharacterExtents<T>(this T text, int offset, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coords) where T : AtkTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		AtkTextHandleExterns.atk_text_get_character_extents(text, offset, out x, out y, out width, out height, coords);
		return text;
	}

	public static MentorLake.Atk.AtkAttributeSetHandle GetDefaultAttributes(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_default_attributes(text);
	}

	public static int GetNSelections(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_n_selections(text);
	}

	public static int GetOffsetAtPoint(this MentorLake.Atk.AtkTextHandle text, int x, int y, MentorLake.Atk.AtkCoordType coords)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_offset_at_point(text, x, y, coords);
	}

	public static T GetRangeExtents<T>(this T text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coord_type, out MentorLake.Atk.AtkTextRectangle rect) where T : AtkTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		AtkTextHandleExterns.atk_text_get_range_extents(text, start_offset, end_offset, coord_type, out rect);
		return text;
	}

	public static MentorLake.Atk.AtkAttributeSetHandle GetRunAttributes(this MentorLake.Atk.AtkTextHandle text, int offset, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_run_attributes(text, offset, out start_offset, out end_offset);
	}

	public static string GetSelection(this MentorLake.Atk.AtkTextHandle text, int selection_num, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_selection(text, selection_num, out start_offset, out end_offset);
	}

	public static string GetStringAtOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextGranularity granularity, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_string_at_offset(text, offset, granularity, out start_offset, out end_offset);
	}

	public static string GetText(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text(text, start_offset, end_offset);
	}

	public static string GetTextAfterOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text_after_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

	public static string GetTextAtOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text_at_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

	public static string GetTextBeforeOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text_before_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

	public static bool RemoveSelection(this MentorLake.Atk.AtkTextHandle text, int selection_num)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_remove_selection(text, selection_num);
	}

	public static bool ScrollSubstringTo(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkScrollType type)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_scroll_substring_to(text, start_offset, end_offset, type);
	}

	public static bool ScrollSubstringToPoint(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coords, int x, int y)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_scroll_substring_to_point(text, start_offset, end_offset, coords, x, y);
	}

	public static bool SetCaretOffset(this MentorLake.Atk.AtkTextHandle text, int offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_set_caret_offset(text, offset);
	}

	public static bool SetSelection(this MentorLake.Atk.AtkTextHandle text, int selection_num, int start_offset, int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_set_selection(text, selection_num, start_offset, end_offset);
	}

	public static void FreeRanges(MentorLake.Atk.AtkTextRangeHandle[] ranges)
	{
		AtkTextHandleExterns.atk_text_free_ranges(ranges);
	}

}

internal class AtkTextHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_text_add_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkTextRangeHandle[] atk_text_get_bounded_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextRectangleHandle>))] MentorLake.Atk.AtkTextRectangleHandle rect, MentorLake.Atk.AtkCoordType coord_type, MentorLake.Atk.AtkTextClipType x_clip_type, MentorLake.Atk.AtkTextClipType y_clip_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_text_get_caret_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text);

	[DllImport(AtkLibrary.Name)]
	internal static extern char atk_text_get_character_at_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_text_get_character_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_text_get_character_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coords);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkAttributeSetHandle atk_text_get_default_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_text_get_n_selections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_text_get_offset_at_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int x, int y, MentorLake.Atk.AtkCoordType coords);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_text_get_range_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coord_type, out MentorLake.Atk.AtkTextRectangle rect);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkAttributeSetHandle atk_text_get_run_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset, out int start_offset, out int end_offset);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_get_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int selection_num, out int start_offset, out int end_offset);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_get_string_at_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextGranularity granularity, out int start_offset, out int end_offset);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_get_text_after_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_get_text_at_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_text_get_text_before_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_text_remove_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int selection_num);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_text_scroll_substring_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkScrollType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_text_scroll_substring_to_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coords, int x, int y);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_text_set_caret_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int offset);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_text_set_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int selection_num, int start_offset, int end_offset);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_text_free_ranges([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextRangeHandle>))] MentorLake.Atk.AtkTextRangeHandle[] ranges);

}
