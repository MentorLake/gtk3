namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface implemented by components containing user-editable text content.
/// </para>
/// <para>
/// #AtkEditableText should be implemented by UI components which
/// contain text which the user can edit, via the #AtkObject
/// corresponding to that component (see #AtkObject).
/// </para>
/// <para>
/// #AtkEditableText is a subclass of #AtkText, and as such, an object
/// which implements #AtkEditableText is by definition an #AtkText
/// implementor as well.
/// </para>
/// <para>
/// See [iface@AtkText]
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Copy text from @start_pos up to, but not including @end_pos
/// to the clipboard.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="start_pos">
/// start position
/// </param>
/// <param name="end_pos">
/// end position
/// </param>

	public static T CopyText<T>(this T text, int start_pos, int end_pos) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_copy_text(text, start_pos, end_pos);
		return text;
	}

/// <summary>
/// <para>
/// Copy text from @start_pos up to, but not including @end_pos
/// to the clipboard and then delete from the widget.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="start_pos">
/// start position
/// </param>
/// <param name="end_pos">
/// end position
/// </param>

	public static T CutText<T>(this T text, int start_pos, int end_pos) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_cut_text(text, start_pos, end_pos);
		return text;
	}

/// <summary>
/// <para>
/// Delete text @start_pos up to, but not including @end_pos.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="start_pos">
/// start position
/// </param>
/// <param name="end_pos">
/// end position
/// </param>

	public static T DeleteText<T>(this T text, int start_pos, int end_pos) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_delete_text(text, start_pos, end_pos);
		return text;
	}

/// <summary>
/// <para>
/// Insert text at a given position.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="@string">
/// the text to insert
/// </param>
/// <param name="length">
/// the length of text to insert, in bytes
/// </param>
/// <param name="position">
/// The caller initializes this to
/// the position at which to insert the text. After the call it
/// points at the position after the newly inserted text.
/// </param>

	public static T InsertText<T>(this T text, string @string, int length, int position) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_insert_text(text, @string, length, position);
		return text;
	}

/// <summary>
/// <para>
/// Paste text from clipboard to specified @position.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="position">
/// position to paste
/// </param>

	public static T PasteText<T>(this T text, int position) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
		AtkEditableTextHandleExterns.atk_editable_text_paste_text(text, position);
		return text;
	}

/// <summary>
/// <para>
/// Sets the attributes for a specified range. See the ATK_ATTRIBUTE
/// macros (such as #ATK_ATTRIBUTE_LEFT_MARGIN) for examples of attributes
/// that can be set. Note that other attributes that do not have corresponding
/// ATK_ATTRIBUTE macros may also be set for certain text widgets.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="attrib_set">
/// an #AtkAttributeSet
/// </param>
/// <param name="start_offset">
/// start of range in which to set attributes
/// </param>
/// <param name="end_offset">
/// end of range in which to set attributes
/// </param>
/// <return>
/// %TRUE if attributes successfully set for the specified
/// range, otherwise %FALSE
/// </return>

	public static bool SetRunAttributes(this MentorLake.Atk.AtkEditableTextHandle text, MentorLake.Atk.AtkAttributeSetHandle attrib_set, int start_offset, int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
		return AtkEditableTextHandleExterns.atk_editable_text_set_run_attributes(text, attrib_set, start_offset, end_offset);
	}

/// <summary>
/// <para>
/// Set text contents of @text.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkEditableText
/// </param>
/// <param name="@string">
/// string to set for text contents of @text
/// </param>

	public static T SetTextContents<T>(this T text, string @string) where T : AtkEditableTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkEditableTextHandle)");
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
