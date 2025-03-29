namespace MentorLake.Atk;

public interface AtkEditableTextHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkEditableTextHandleImpl : BaseSafeHandle, AtkEditableTextHandle
{
}

public static class AtkEditableTextHandleExtensions
{
	public static T CopyText<T>(this T text, int start_pos, int end_pos) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_copy_text(text, start_pos, end_pos);
		return text;
	}

	public static T CutText<T>(this T text, int start_pos, int end_pos) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_cut_text(text, start_pos, end_pos);
		return text;
	}

	public static T DeleteText<T>(this T text, int start_pos, int end_pos) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_delete_text(text, start_pos, end_pos);
		return text;
	}

	public static T InsertText<T>(this T text, string @string, int length, int position) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_insert_text(text, @string, length, position);
		return text;
	}

	public static T PasteText<T>(this T text, int position) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_paste_text(text, position);
		return text;
	}

	public static bool SetRunAttributes(this MentorLake.Atk.AtkEditableTextHandle text, MentorLake.Atk.AtkAttributeSetHandle attrib_set, int start_offset, int end_offset)
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		return AtkEditableTextHandleExterns.atk_editable_text_set_run_attributes(text, attrib_set, start_offset, end_offset);
	}

	public static T SetTextContents<T>(this T text, string @string) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid || text.IsClosed) throw new Exception("Invalid or closed handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_set_text_contents(text, @string);
		return text;
	}

}

internal class AtkEditableTextHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_editable_text_copy_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, int start_pos, int end_pos);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_editable_text_cut_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, int start_pos, int end_pos);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_editable_text_delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, int start_pos, int end_pos);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_editable_text_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, string @string, int length, int position);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_editable_text_paste_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, int position);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_editable_text_set_run_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))] MentorLake.Atk.AtkAttributeSetHandle attrib_set, int start_offset, int end_offset);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_editable_text_set_text_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkEditableTextHandleImpl>))] MentorLake.Atk.AtkEditableTextHandle text, string @string);

}
