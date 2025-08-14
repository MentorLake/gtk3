namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface implemented by components with text content.
/// </para>
/// <para>
/// #AtkText should be implemented by #AtkObjects on behalf of widgets
/// that have text content which is either attributed or otherwise
/// non-trivial.  #AtkObjects whose text content is simple,
/// unattributed, and very brief may expose that content via
/// #atk_object_get_name instead; however if the text is editable,
/// multi-line, typically longer than three or four words, attributed,
/// selectable, or if the object already uses the 'name' ATK property
/// for other information, the #AtkText interface should be used to
/// expose the text content.  In the case of editable text content,
/// #AtkEditableText (a subtype of the #AtkText interface) should be
/// implemented instead.
/// </para>
/// <para>
///  #AtkText provides not only traversal facilities and change
/// notification for text content, but also caret tracking and glyph
/// bounding box calculations.  Note that the text strings are exposed
/// as UTF-8, and are therefore potentially multi-byte, and
/// caret-to-byte offset mapping makes no assumptions about the
/// character length; also bounding box glyph-to-offset mapping may be
/// complex for languages which use ligatures.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Adds a selection bounded by the specified offsets.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="start_offset">
/// the starting character offset of the selected region
/// </param>
/// <param name="end_offset">
/// the offset of the first character after the selected region.
/// </param>
/// <return>
/// %TRUE if successful, %FALSE otherwise
/// </return>

	public static bool AddSelection(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_add_selection(text, start_offset, end_offset);
	}

/// <summary>
/// <para>
/// Get the ranges of text in the specified bounding box.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="rect">
/// An AtkTextRectangle giving the dimensions of the bounding box.
/// </param>
/// <param name="coord_type">
/// Specify whether coordinates are relative to the screen or widget window.
/// </param>
/// <param name="x_clip_type">
/// Specify the horizontal clip type.
/// </param>
/// <param name="y_clip_type">
/// Specify the vertical clip type.
/// </param>
/// <return>
/// Array of AtkTextRange. The last
///          element of the array returned by this function will be NULL.
/// </return>

	public static MentorLake.Atk.AtkTextRangeHandle[] GetBoundedRanges(this MentorLake.Atk.AtkTextHandle text, MentorLake.Atk.AtkTextRectangleHandle rect, MentorLake.Atk.AtkCoordType coord_type, MentorLake.Atk.AtkTextClipType x_clip_type, MentorLake.Atk.AtkTextClipType y_clip_type)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_bounded_ranges(text, rect, coord_type, x_clip_type, y_clip_type);
	}

/// <summary>
/// <para>
/// Gets the offset of the position of the caret (cursor).
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <return>
/// the character offset of the position of the caret or -1 if
///          the caret is not located inside the element or in the case of
///          any other failure.
/// </return>

	public static int GetCaretOffset(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_caret_offset(text);
	}

/// <summary>
/// <para>
/// Gets the specified text.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// a character offset within @text
/// </param>
/// <return>
/// the character at @offset or 0 in the case of failure.
/// </return>

	public static char GetCharacterAtOffset(this MentorLake.Atk.AtkTextHandle text, int offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_character_at_offset(text, offset);
	}

/// <summary>
/// <para>
/// Gets the character count.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <return>
/// the number of characters or -1 in case of failure.
/// </return>

	public static int GetCharacterCount(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_character_count(text);
	}

/// <summary>
/// <para>
/// If the extent can not be obtained (e.g. missing support), all of x, y, width,
/// height are set to -1.
/// </para>
/// <para>
/// Get the bounding box containing the glyph representing the character at
///     a particular text offset.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// The offset of the text character for which bounding information is required.
/// </param>
/// <param name="x">
/// Pointer for the x coordinate of the bounding box
/// </param>
/// <param name="y">
/// Pointer for the y coordinate of the bounding box
/// </param>
/// <param name="width">
/// Pointer for the width of the bounding box
/// </param>
/// <param name="height">
/// Pointer for the height of the bounding box
/// </param>
/// <param name="coords">
/// specify whether coordinates are relative to the screen or widget window
/// </param>

	public static T GetCharacterExtents<T>(this T text, int offset, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coords) where T : AtkTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		AtkTextHandleExterns.atk_text_get_character_extents(text, offset, out x, out y, out width, out height, coords);
		return text;
	}

/// <summary>
/// <para>
/// Creates an #AtkAttributeSet which consists of the default values of
/// attributes for the text. See the enum AtkTextAttribute for types of text
/// attributes that can be returned. Note that other attributes may also be
/// returned.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <return>
/// an #AtkAttributeSet which contains the default text
///          attributes for this #AtkText. This #AtkAttributeSet should be freed by
///          a call to atk_attribute_set_free().
/// </return>

	public static MentorLake.Atk.AtkAttributeSetHandle GetDefaultAttributes(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_default_attributes(text);
	}

/// <summary>
/// <para>
/// Gets the number of selected regions.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <return>
/// The number of selected regions, or -1 in the case of failure.
/// </return>

	public static int GetNSelections(this MentorLake.Atk.AtkTextHandle text)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_n_selections(text);
	}

/// <summary>
/// <para>
/// Gets the offset of the character located at coordinates @x and @y. @x and @y
/// are interpreted as being relative to the screen or this widget's window
/// depending on @coords.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="x">
/// screen x-position of character
/// </param>
/// <param name="y">
/// screen y-position of character
/// </param>
/// <param name="coords">
/// specify whether coordinates are relative to the screen or
/// widget window
/// </param>
/// <return>
/// the offset to the character which is located at  the specified
///          @x and @y coordinates of -1 in case of failure.
/// </return>

	public static int GetOffsetAtPoint(this MentorLake.Atk.AtkTextHandle text, int x, int y, MentorLake.Atk.AtkCoordType coords)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_offset_at_point(text, x, y, coords);
	}

/// <summary>
/// <para>
/// Get the bounding box for text within the specified range.
/// </para>
/// <para>
/// If the extents can not be obtained (e.g. or missing support), the rectangle
/// fields are set to -1.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="start_offset">
/// The offset of the first text character for which boundary
///        information is required.
/// </param>
/// <param name="end_offset">
/// The offset of the text character after the last character
///        for which boundary information is required.
/// </param>
/// <param name="coord_type">
/// Specify whether coordinates are relative to the screen or widget window.
/// </param>
/// <param name="rect">
/// A pointer to a AtkTextRectangle which is filled in by this function.
/// </param>

	public static T GetRangeExtents<T>(this T text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coord_type, out MentorLake.Atk.AtkTextRectangle rect) where T : AtkTextHandle
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		AtkTextHandleExterns.atk_text_get_range_extents(text, start_offset, end_offset, coord_type, out rect);
		return text;
	}

/// <summary>
/// <para>
/// Creates an #AtkAttributeSet which consists of the attributes explicitly
/// set at the position @offset in the text. @start_offset and @end_offset are
/// set to the start and end of the range around @offset where the attributes are
/// invariant. Note that @end_offset is the offset of the first character
/// after the range.  See the enum AtkTextAttribute for types of text
/// attributes that can be returned. Note that other attributes may also be
/// returned.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// the character offset at which to get the attributes, -1 means the offset of
/// the character to be inserted at the caret location.
/// </param>
/// <param name="start_offset">
/// the address to put the start offset of the range
/// </param>
/// <param name="end_offset">
/// the address to put the end offset of the range
/// </param>
/// <return>
/// an #AtkAttributeSet which contains the attributes
///         explicitly set at @offset. This #AtkAttributeSet should be freed by
///         a call to atk_attribute_set_free().
/// </return>

	public static MentorLake.Atk.AtkAttributeSetHandle GetRunAttributes(this MentorLake.Atk.AtkTextHandle text, int offset, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_run_attributes(text, offset, out start_offset, out end_offset);
	}

/// <summary>
/// <para>
/// Gets the text from the specified selection.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="selection_num">
/// The selection number.  The selected regions are
/// assigned numbers that correspond to how far the region is from the
/// start of the text.  The selected region closest to the beginning
/// of the text region is assigned the number 0, etc.  Note that adding,
/// moving or deleting a selected region can change the numbering.
/// </param>
/// <param name="start_offset">
/// passes back the starting character offset of the selected region
/// </param>
/// <param name="end_offset">
/// passes back the ending character offset (offset immediately past)
/// of the selected region
/// </param>
/// <return>
/// a newly allocated string containing the selected text. Use g_free()
///          to free the returned string.
/// </return>

	public static string GetSelection(this MentorLake.Atk.AtkTextHandle text, int selection_num, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_selection(text, selection_num, out start_offset, out end_offset);
	}

/// <summary>
/// <para>
/// Gets a portion of the text exposed through an #AtkText according to a given @offset
/// and a specific @granularity, along with the start and end offsets defining the
/// boundaries of such a portion of text.
/// </para>
/// <para>
/// If @granularity is ATK_TEXT_GRANULARITY_CHAR the character at the
/// offset is returned.
/// </para>
/// <para>
/// If @granularity is ATK_TEXT_GRANULARITY_WORD the returned string
/// is from the word start at or before the offset to the word start after
/// the offset.
/// </para>
/// <para>
/// The returned string will contain the word at the offset if the offset
/// is inside a word and will contain the word before the offset if the
/// offset is not inside a word.
/// </para>
/// <para>
/// If @granularity is ATK_TEXT_GRANULARITY_SENTENCE the returned string
/// is from the sentence start at or before the offset to the sentence
/// start after the offset.
/// </para>
/// <para>
/// The returned string will contain the sentence at the offset if the offset
/// is inside a sentence and will contain the sentence before the offset
/// if the offset is not inside a sentence.
/// </para>
/// <para>
/// If @granularity is ATK_TEXT_GRANULARITY_LINE the returned string
/// is from the line start at or before the offset to the line
/// start after the offset.
/// </para>
/// <para>
/// If @granularity is ATK_TEXT_GRANULARITY_PARAGRAPH the returned string
/// is from the start of the paragraph at or before the offset to the start
/// of the following paragraph after the offset.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// position
/// </param>
/// <param name="granularity">
/// An #AtkTextGranularity
/// </param>
/// <param name="start_offset">
/// the starting character offset of the returned string, or -1
///                in the case of error (e.g. invalid offset, not implemented)
/// </param>
/// <param name="end_offset">
/// the offset of the first character after the returned string,
///              or -1 in the case of error (e.g. invalid offset, not implemented)
/// </param>
/// <return>
/// a newly allocated string containing the text at
///          the @offset bounded by the specified @granularity. Use g_free()
///          to free the returned string.  Returns %NULL if the offset is invalid
///          or no implementation is available.
/// </return>

	public static string GetStringAtOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextGranularity granularity, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_string_at_offset(text, offset, granularity, out start_offset, out end_offset);
	}

/// <summary>
/// <para>
/// Gets the specified text.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="start_offset">
/// a starting character offset within @text
/// </param>
/// <param name="end_offset">
/// an ending character offset within @text, or -1 for the end of the string.
/// </param>
/// <return>
/// a newly allocated string containing the text from @start_offset up
///          to, but not including @end_offset. Use g_free() to free the returned
///          string.
/// </return>

	public static string GetText(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text(text, start_offset, end_offset);
	}

/// <summary>
/// <para>
/// Gets the specified text.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// position
/// </param>
/// <param name="boundary_type">
/// An #AtkTextBoundary
/// </param>
/// <param name="start_offset">
/// the starting character offset of the returned string
/// </param>
/// <param name="end_offset">
/// the offset of the first character after the
///              returned substring
/// </param>
/// <return>
/// a newly allocated string containing the text after @offset bounded
///          by the specified @boundary_type. Use g_free() to free the returned
///          string.
/// </return>

	public static string GetTextAfterOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text_after_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

/// <summary>
/// <para>
/// Gets the specified text.
/// </para>
/// <para>
/// If the boundary_type if ATK_TEXT_BOUNDARY_CHAR the character at the
/// offset is returned.
/// </para>
/// <para>
/// If the boundary_type is ATK_TEXT_BOUNDARY_WORD_START the returned string
/// is from the word start at or before the offset to the word start after
/// the offset.
/// </para>
/// <para>
/// The returned string will contain the word at the offset if the offset
/// is inside a word and will contain the word before the offset if the
/// offset is not inside a word.
/// </para>
/// <para>
/// If the boundary type is ATK_TEXT_BOUNDARY_SENTENCE_START the returned
/// string is from the sentence start at or before the offset to the sentence
/// start after the offset.
/// </para>
/// <para>
/// The returned string will contain the sentence at the offset if the offset
/// is inside a sentence and will contain the sentence before the offset
/// if the offset is not inside a sentence.
/// </para>
/// <para>
/// If the boundary type is ATK_TEXT_BOUNDARY_LINE_START the returned
/// string is from the line start at or before the offset to the line
/// start after the offset.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// position
/// </param>
/// <param name="boundary_type">
/// An #AtkTextBoundary
/// </param>
/// <param name="start_offset">
/// the starting character offset of the returned string
/// </param>
/// <param name="end_offset">
/// the offset of the first character after the
///              returned substring
/// </param>
/// <return>
/// a newly allocated string containing the text at @offset bounded
///          by the specified @boundary_type. Use g_free() to free the returned
///          string.
/// </return>

	public static string GetTextAtOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text_at_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

/// <summary>
/// <para>
/// Gets the specified text.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// position
/// </param>
/// <param name="boundary_type">
/// An #AtkTextBoundary
/// </param>
/// <param name="start_offset">
/// the starting character offset of the returned string
/// </param>
/// <param name="end_offset">
/// the offset of the first character after the
///              returned substring
/// </param>
/// <return>
/// a newly allocated string containing the text before @offset bounded
///          by the specified @boundary_type. Use g_free() to free the returned
///          string.
/// </return>

	public static string GetTextBeforeOffset(this MentorLake.Atk.AtkTextHandle text, int offset, MentorLake.Atk.AtkTextBoundary boundary_type, out int start_offset, out int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_get_text_before_offset(text, offset, boundary_type, out start_offset, out end_offset);
	}

/// <summary>
/// <para>
/// Removes the specified selection.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="selection_num">
/// The selection number.  The selected regions are
/// assigned numbers that correspond to how far the region is from the
/// start of the text.  The selected region closest to the beginning
/// of the text region is assigned the number 0, etc.  Note that adding,
/// moving or deleting a selected region can change the numbering.
/// </param>
/// <return>
/// %TRUE if successful, %FALSE otherwise
/// </return>

	public static bool RemoveSelection(this MentorLake.Atk.AtkTextHandle text, int selection_num)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_remove_selection(text, selection_num);
	}

/// <summary>
/// <para>
/// Makes a substring of @text visible on the screen by scrolling all necessary parents.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="start_offset">
/// start offset in the @text
/// </param>
/// <param name="end_offset">
/// end offset in the @text, or -1 for the end of the text.
/// </param>
/// <param name="type">
/// specify where the object should be made visible.
/// </param>
/// <return>
/// whether scrolling was successful.
/// </return>

	public static bool ScrollSubstringTo(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkScrollType type)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_scroll_substring_to(text, start_offset, end_offset, type);
	}

/// <summary>
/// <para>
/// Move the top-left of a substring of @text to a given position of the screen
/// by scrolling all necessary parents.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="start_offset">
/// start offset in the @text
/// </param>
/// <param name="end_offset">
/// end offset in the @text, or -1 for the end of the text.
/// </param>
/// <param name="coords">
/// specify whether coordinates are relative to the screen or to the
/// parent object.
/// </param>
/// <param name="x">
/// x-position where to scroll to
/// </param>
/// <param name="y">
/// y-position where to scroll to
/// </param>
/// <return>
/// whether scrolling was successful.
/// </return>

	public static bool ScrollSubstringToPoint(this MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coords, int x, int y)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_scroll_substring_to_point(text, start_offset, end_offset, coords, x, y);
	}

/// <summary>
/// <para>
/// Sets the caret (cursor) position to the specified @offset.
/// </para>
/// <para>
/// In the case of rich-text content, this method should either grab focus
/// or move the sequential focus navigation starting point (if the application
/// supports this concept) as if the user had clicked on the new caret position.
/// Typically, this means that the target of this operation is the node containing
/// the new caret position or one of its ancestors. In other words, after this
/// method is called, if the user advances focus, it should move to the first
/// focusable node following the new caret position.
/// </para>
/// <para>
/// Calling this method should also scroll the application viewport in a way
/// that matches the behavior of the application's typical caret motion or tab
/// navigation as closely as possible. This also means that if the application's
/// caret motion or focus navigation does not trigger a scroll operation, this
/// method should not trigger one either. If the application does not have a caret
/// motion or focus navigation operation, this method should try to scroll the new
/// caret position into view while minimizing unnecessary scroll motion.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="offset">
/// the character offset of the new caret position
/// </param>
/// <return>
/// %TRUE if successful, %FALSE otherwise.
/// </return>

	public static bool SetCaretOffset(this MentorLake.Atk.AtkTextHandle text, int offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_set_caret_offset(text, offset);
	}

/// <summary>
/// <para>
/// Changes the start and end offset of the specified selection.
/// </para>
/// </summary>

/// <param name="text">
/// an #AtkText
/// </param>
/// <param name="selection_num">
/// The selection number.  The selected regions are
/// assigned numbers that correspond to how far the region is from the
/// start of the text.  The selected region closest to the beginning
/// of the text region is assigned the number 0, etc.  Note that adding,
/// moving or deleting a selected region can change the numbering.
/// </param>
/// <param name="start_offset">
/// the new starting character offset of the selection
/// </param>
/// <param name="end_offset">
/// the new end position of (e.g. offset immediately past)
/// the selection
/// </param>
/// <return>
/// %TRUE if successful, %FALSE otherwise
/// </return>

	public static bool SetSelection(this MentorLake.Atk.AtkTextHandle text, int selection_num, int start_offset, int end_offset)
	{
		if (text.IsInvalid) throw new Exception("Invalid handle (AtkTextHandle)");
		return AtkTextHandleExterns.atk_text_set_selection(text, selection_num, start_offset, end_offset);
	}

/// <summary>
/// <para>
/// Frees the memory associated with an array of AtkTextRange. It is assumed
/// that the array was returned by the function atk_text_get_bounded_ranges
/// and is NULL terminated.
/// </para>
/// </summary>

/// <param name="ranges">
/// A pointer to an array of #AtkTextRange which is
///   to be freed.
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))]
	internal static extern MentorLake.Atk.AtkAttributeSetHandle atk_text_get_default_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_text_get_n_selections([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_text_get_offset_at_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int x, int y, MentorLake.Atk.AtkCoordType coords);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_text_get_range_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle text, int start_offset, int end_offset, MentorLake.Atk.AtkCoordType coord_type, out MentorLake.Atk.AtkTextRectangle rect);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkAttributeSetHandle>))]
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
