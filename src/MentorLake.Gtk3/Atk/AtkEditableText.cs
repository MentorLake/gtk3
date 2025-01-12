namespace MentorLake.Gtk3.Atk;

public interface AtkEditableTextHandle
{
}

internal class AtkEditableTextHandleImpl : BaseSafeHandle, AtkEditableTextHandle
{
}

public static class AtkEditableTextHandleExtensions
{
	public static AtkEditableTextHandle CopyText(this AtkEditableTextHandle text, int start_pos, int end_pos)
	{
		AtkEditableTextExterns.atk_editable_text_copy_text(text, start_pos, end_pos);
		return text;
	}

	public static AtkEditableTextHandle CutText(this AtkEditableTextHandle text, int start_pos, int end_pos)
	{
		AtkEditableTextExterns.atk_editable_text_cut_text(text, start_pos, end_pos);
		return text;
	}

	public static AtkEditableTextHandle DeleteText(this AtkEditableTextHandle text, int start_pos, int end_pos)
	{
		AtkEditableTextExterns.atk_editable_text_delete_text(text, start_pos, end_pos);
		return text;
	}

	public static AtkEditableTextHandle InsertText(this AtkEditableTextHandle text, string @string, int length, ref int position)
	{
		AtkEditableTextExterns.atk_editable_text_insert_text(text, @string, length, ref position);
		return text;
	}

	public static AtkEditableTextHandle PasteText(this AtkEditableTextHandle text, int position)
	{
		AtkEditableTextExterns.atk_editable_text_paste_text(text, position);
		return text;
	}

	public static bool SetRunAttributes(this AtkEditableTextHandle text, AtkAttributeSetHandle attrib_set, int start_offset, int end_offset)
	{
		return AtkEditableTextExterns.atk_editable_text_set_run_attributes(text, attrib_set, start_offset, end_offset);
	}

	public static AtkEditableTextHandle SetTextContents(this AtkEditableTextHandle text, string @string)
	{
		AtkEditableTextExterns.atk_editable_text_set_text_contents(text, @string);
		return text;
	}

}

internal class AtkEditableTextExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern void atk_editable_text_copy_text(AtkEditableTextHandle text, int start_pos, int end_pos);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_editable_text_cut_text(AtkEditableTextHandle text, int start_pos, int end_pos);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_editable_text_delete_text(AtkEditableTextHandle text, int start_pos, int end_pos);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_editable_text_insert_text(AtkEditableTextHandle text, string @string, int length, ref int position);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_editable_text_paste_text(AtkEditableTextHandle text, int position);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_editable_text_set_run_attributes(AtkEditableTextHandle text, AtkAttributeSetHandle attrib_set, int start_offset, int end_offset);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_editable_text_set_text_contents(AtkEditableTextHandle text, string @string);

}
