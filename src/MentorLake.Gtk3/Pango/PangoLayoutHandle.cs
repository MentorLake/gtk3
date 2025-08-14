namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoLayout` structure represents an entire paragraph of text.
/// </para>
/// <para>
/// While complete access to the layout capabilities of Pango is provided
/// using the detailed interfaces for itemization and shaping, using
/// that functionality directly involves writing a fairly large amount
/// of code. `PangoLayout` provides a high-level driver for formatting
/// entire paragraphs of text at once. This includes paragraph-level
/// functionality such as line breaking, justification, alignment and
/// ellipsization.
/// </para>
/// <para>
/// A `PangoLayout` is initialized with a `PangoContext`, UTF-8 string
/// and set of attributes for that string. Once that is done, the set of
/// formatted lines can be extracted from the object, the layout can be
/// rendered, and conversion between logical character positions within
/// the layout's text, and the physical position of the resulting glyphs
/// can be made.
/// </para>
/// <para>
/// There are a number of parameters to adjust the formatting of a
/// `PangoLayout`. The following image shows adjustable parameters
/// (on the left) and font metrics (on the right):
/// </para>
/// <para>
/// <picture>
///   <source srcset="layout-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Pango Layout Parameters" src="layout-light.png">
/// </picture>
/// </para>
/// <para>
/// The following images demonstrate the effect of alignment and
/// justification on the layout of text:
/// </para>
/// <para>
/// | | |
/// | --- | --- |
/// | ![align=left](align-left.png) | ![align=left, justify](align-left-justify.png) |
/// | ![align=center](align-center.png) | ![align=center, justify](align-center-justify.png) |
/// | ![align=right](align-right.png) | ![align=right, justify](align-right-justify.png) |
/// </para>
/// <para>
/// </para>
/// <para>
/// It is possible, as well, to ignore the 2-D setup,
/// and simply treat the results of a `PangoLayout` as a list of lines.
/// </para>
/// </summary>

public class PangoLayoutHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new `PangoLayout` object with attributes initialized to
/// default values for a particular `PangoContext`.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <return>
/// the newly allocated `PangoLayout`
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle New(MentorLake.Pango.PangoContextHandle context)
	{
		return PangoLayoutHandleExterns.pango_layout_new(context);
	}

/// <summary>
/// <para>
/// Loads data previously created via [method@Pango.Layout.serialize].
/// </para>
/// <para>
/// For a discussion of the supported format, see that function.
/// </para>
/// <para>
/// Note: to verify that the returned layout is identical to
/// the one that was serialized, you can compare @bytes to the
/// result of serializing the layout again.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`
/// </param>
/// <param name="bytes">
/// the bytes containing the data
/// </param>
/// <param name="flags">
/// `PangoLayoutDeserializeFlags`
/// </param>
/// <return>
/// a new `PangoLayout`
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle Deserialize(MentorLake.Pango.PangoContextHandle context, MentorLake.GLib.GBytesHandle bytes, MentorLake.Pango.PangoLayoutDeserializeFlags flags)
	{
		var externCallResult = PangoLayoutHandleExterns.pango_layout_deserialize(context, bytes, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class PangoLayoutHandleExtensions
{
/// <summary>
/// <para>
/// Forces recomputation of any state in the `PangoLayout` that
/// might depend on the layout's context.
/// </para>
/// <para>
/// This function should be called if you make changes to the context
/// subsequent to creating the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>

	public static T ContextChanged<T>(this T layout) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_context_changed(layout);
		return layout;
	}

/// <summary>
/// <para>
/// Creates a deep copy-by-value of the layout.
/// </para>
/// <para>
/// The attribute list, tab array, and text from the original layout
/// are all copied by value.
/// </para>
/// </summary>

/// <param name="src">
/// a `PangoLayout`
/// </param>
/// <return>
/// the newly allocated `PangoLayout`
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle Copy(this MentorLake.Pango.PangoLayoutHandle src)
	{
		if (src.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_copy(src);
	}

/// <summary>
/// <para>
/// Gets the alignment for the layout: how partial lines are
/// positioned within the horizontal space available.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the alignment
/// </return>

	public static MentorLake.Pango.PangoAlignment GetAlignment(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_alignment(layout);
	}

/// <summary>
/// <para>
/// Gets the attribute list for the layout, if any.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// a `PangoAttrList`
/// </return>

	public static MentorLake.Pango.PangoAttrListHandle GetAttributes(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_attributes(layout);
	}

/// <summary>
/// <para>
/// Gets whether to calculate the base direction for the layout
/// according to its contents.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_auto_dir].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// %TRUE if the bidirectional base direction
///   is computed from the layout's contents, %FALSE otherwise
/// </return>

	public static bool GetAutoDir(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_auto_dir(layout);
	}

/// <summary>
/// <para>
/// Gets the Y position of baseline of the first line in @layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// baseline of first line, from top of @layout
/// </return>

	public static int GetBaseline(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_baseline(layout);
	}

/// <summary>
/// <para>
/// Given an index within a layout, determines the positions that of the
/// strong and weak cursors if the insertion point is at that index.
/// </para>
/// <para>
/// This is a variant of [method@Pango.Layout.get_cursor_pos] that applies
/// font metric information about caret slope and offset to the positions
/// it returns.
/// </para>
/// <para>
/// <picture>
///   <source srcset="caret-metrics-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Caret metrics" src="caret-metrics-light.png">
/// </picture>
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="index_">
/// the byte index of the cursor
/// </param>
/// <param name="strong_pos">
/// location to store the strong cursor position
/// </param>
/// <param name="weak_pos">
/// location to store the weak cursor position
/// </param>

	public static T GetCaretPos<T>(this T layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_caret_pos(layout, index_, out strong_pos, out weak_pos);
		return layout;
	}

/// <summary>
/// <para>
/// Returns the number of Unicode characters in the
/// the text of @layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the number of Unicode characters
///   in the text of @layout
/// </return>

	public static int GetCharacterCount(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_character_count(layout);
	}

/// <summary>
/// <para>
/// Retrieves the `PangoContext` used for this layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the `PangoContext` for the layout
/// </return>

	public static MentorLake.Pango.PangoContextHandle GetContext(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_context(layout);
	}

/// <summary>
/// <para>
/// Given an index within a layout, determines the positions that of the
/// strong and weak cursors if the insertion point is at that index.
/// </para>
/// <para>
/// The position of each cursor is stored as a zero-width rectangle
/// with the height of the run extents.
/// </para>
/// <para>
/// <picture>
///   <source srcset="cursor-positions-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Cursor positions" src="cursor-positions-light.png">
/// </picture>
/// </para>
/// <para>
/// The strong cursor location is the location where characters of the
/// directionality equal to the base direction of the layout are inserted.
/// The weak cursor location is the location where characters of the
/// directionality opposite to the base direction of the layout are inserted.
/// </para>
/// <para>
/// The following example shows text with both a strong and a weak cursor.
/// </para>
/// <para>
/// <picture>
///   <source srcset="split-cursor-dark.png" media="(prefers-color-scheme: dark)">
///   <img alt="Strong and weak cursors" src="split-cursor-light.png">
/// </picture>
/// </para>
/// <para>
/// The strong cursor has a little arrow pointing to the right, the weak
/// cursor to the left. Typing a 'c' in this situation will insert the
/// character after the 'b', and typing another Hebrew character, like 'ג',
/// will insert it at the end.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="index_">
/// the byte index of the cursor
/// </param>
/// <param name="strong_pos">
/// location to store the strong cursor position
/// </param>
/// <param name="weak_pos">
/// location to store the weak cursor position
/// </param>

	public static T GetCursorPos<T>(this T layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_cursor_pos(layout, index_, out strong_pos, out weak_pos);
		return layout;
	}

/// <summary>
/// <para>
/// Gets the text direction at the given character position in @layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="index">
/// the byte index of the char
/// </param>
/// <return>
/// the text direction at @index
/// </return>

	public static MentorLake.Pango.PangoDirection GetDirection(this MentorLake.Pango.PangoLayoutHandle layout, int index)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_direction(layout, index);
	}

/// <summary>
/// <para>
/// Gets the type of ellipsization being performed for @layout.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_ellipsize].
/// </para>
/// <para>
/// Use [method@Pango.Layout.is_ellipsized] to query whether any
/// paragraphs were actually ellipsized.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the current ellipsization mode for @layout
/// </return>

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_ellipsize(layout);
	}

/// <summary>
/// <para>
/// Computes the logical and ink extents of @layout.
/// </para>
/// <para>
/// Logical extents are usually what you want for positioning things. Note
/// that both extents may have non-zero x and y. You may want to use those
/// to offset where you render the layout. Not doing that is a very typical
/// bug that shows up as right-to-left layouts not being correctly positioned
/// in a layout with a set width.
/// </para>
/// <para>
/// The extents are given in layout coordinates and in Pango units; layout
/// coordinates begin at the top left corner of the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="ink_rect">
/// rectangle used to store the extents of the
///   layout as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to store the logical
///   extents of the layout
/// </param>

	public static T GetExtents<T>(this T layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_extents(layout, out ink_rect, out logical_rect);
		return layout;
	}

/// <summary>
/// <para>
/// Gets the font description for the layout, if any.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// a pointer to the
///   layout's font description, or %NULL if the font description
///   from the layout's context is inherited.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFontDescription(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_font_description(layout);
	}

/// <summary>
/// <para>
/// Gets the height of layout used for ellipsization.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_height] for details.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the height, in Pango units if positive,
///   or number of lines if negative.
/// </return>

	public static int GetHeight(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_height(layout);
	}

/// <summary>
/// <para>
/// Gets the paragraph indent width in Pango units.
/// </para>
/// <para>
/// A negative value indicates a hanging indentation.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the indent in Pango units
/// </return>

	public static int GetIndent(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_indent(layout);
	}

/// <summary>
/// <para>
/// Returns an iterator to iterate over the visual extents of the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the new `PangoLayoutIter`
/// </return>

	public static MentorLake.Pango.PangoLayoutIterHandle GetIter(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_iter(layout);
	}

/// <summary>
/// <para>
/// Gets whether each complete line should be stretched to fill the entire
/// width of the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the justify value
/// </return>

	public static bool GetJustify(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_justify(layout);
	}

/// <summary>
/// <para>
/// Gets whether the last line should be stretched
/// to fill the entire width of the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the justify value
/// </return>

	public static bool GetJustifyLastLine(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_justify_last_line(layout);
	}

/// <summary>
/// <para>
/// Retrieves a particular line from a `PangoLayout`.
/// </para>
/// <para>
/// Use the faster [method@Pango.Layout.get_line_readonly] if you do not
/// plan to modify the contents of the line (glyphs, glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="line">
/// the index of a line, which must be between 0 and
///   `pango_layout_get_line_count(layout) - 1`, inclusive.
/// </param>
/// <return>
/// the requested `PangoLayoutLine`,
///   or %NULL if the index is out of range. This layout line can be ref'ed
///   and retained, but will become invalid if changes are made to the
///   `PangoLayout`.
/// </return>

	public static MentorLake.Pango.PangoLayoutLineHandle GetLine(this MentorLake.Pango.PangoLayoutHandle layout, int line)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_line(layout, line);
	}

/// <summary>
/// <para>
/// Retrieves the count of lines for the @layout.
/// </para>
/// </summary>

/// <param name="layout">
/// `PangoLayout`
/// </param>
/// <return>
/// the line count
/// </return>

	public static int GetLineCount(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_line_count(layout);
	}

/// <summary>
/// <para>
/// Retrieves a particular line from a `PangoLayout`.
/// </para>
/// <para>
/// This is a faster alternative to [method@Pango.Layout.get_line],
/// but the user is not expected to modify the contents of the line
/// (glyphs, glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="line">
/// the index of a line, which must be between 0 and
///   `pango_layout_get_line_count(layout) - 1`, inclusive.
/// </param>
/// <return>
/// the requested `PangoLayoutLine`,
///   or %NULL if the index is out of range. This layout line can be ref'ed
///   and retained, but will become invalid if changes are made to the
///   `PangoLayout`. No changes should be made to the line.
/// </return>

	public static MentorLake.Pango.PangoLayoutLineHandle GetLineReadonly(this MentorLake.Pango.PangoLayoutHandle layout, int line)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_line_readonly(layout, line);
	}

/// <summary>
/// <para>
/// Gets the line spacing factor of @layout.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_line_spacing].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>

	public static float GetLineSpacing(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_line_spacing(layout);
	}

/// <summary>
/// <para>
/// Returns the lines of the @layout as a list.
/// </para>
/// <para>
/// Use the faster [method@Pango.Layout.get_lines_readonly] if you do not
/// plan to modify the contents of the lines (glyphs, glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// a `GSList`
///   containing the lines in the layout. This points to internal data of the
///   `PangoLayout` and must be used with care. It will become invalid on any
///   change to the layout's text or properties.
/// </return>

	public static MentorLake.GLib.GSListHandle GetLines(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_lines(layout);
	}

/// <summary>
/// <para>
/// Returns the lines of the @layout as a list.
/// </para>
/// <para>
/// This is a faster alternative to [method@Pango.Layout.get_lines],
/// but the user is not expected to modify the contents of the lines
/// (glyphs, glyph widths, etc.).
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// a `GSList`
///   containing the lines in the layout. This points to internal data of the
///   `PangoLayout` and must be used with care. It will become invalid on any
///   change to the layout's text or properties. No changes should be made to
///   the lines.
/// </return>

	public static MentorLake.GLib.GSListHandle GetLinesReadonly(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_lines_readonly(layout);
	}

/// <summary>
/// <para>
/// Retrieves an array of logical attributes for each character in
/// the @layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="attrs">
/// 
///   location to store a pointer to an array of logical attributes.
///   This value must be freed with g_free().
/// </param>
/// <param name="n_attrs">
/// location to store the number of the attributes in the
///   array. (The stored value will be one more than the total number
///   of characters in the layout, since there need to be attributes
///   corresponding to both the position before the first character
///   and the position after the last character.)
/// </param>

	public static T GetLogAttrs<T>(this T layout, out MentorLake.Pango.PangoLogAttr[] attrs, out int n_attrs) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_log_attrs(layout, out attrs, out n_attrs);
		return layout;
	}

/// <summary>
/// <para>
/// Retrieves an array of logical attributes for each character in
/// the @layout.
/// </para>
/// <para>
/// This is a faster alternative to [method@Pango.Layout.get_log_attrs].
/// The returned array is part of @layout and must not be modified.
/// Modifying the layout will invalidate the returned array.
/// </para>
/// <para>
/// The number of attributes returned in @n_attrs will be one more
/// than the total number of characters in the layout, since there
/// need to be attributes corresponding to both the position before
/// the first character and the position after the last character.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="n_attrs">
/// location to store the number of the attributes in
///   the array
/// </param>
/// <return>
/// an array of logical attributes
/// </return>

	public static MentorLake.Pango.PangoLogAttr[] GetLogAttrsReadonly(this MentorLake.Pango.PangoLayoutHandle layout, out int n_attrs)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_log_attrs_readonly(layout, out n_attrs);
	}

/// <summary>
/// <para>
/// Computes the logical and ink extents of @layout in device units.
/// </para>
/// <para>
/// This function just calls [method@Pango.Layout.get_extents] followed by
/// two [func@extents_to_pixels] calls, rounding @ink_rect and @logical_rect
/// such that the rounded rectangles fully contain the unrounded one (that is,
/// passes them as first argument to [func@Pango.extents_to_pixels]).
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="ink_rect">
/// rectangle used to store the extents of the
///   layout as drawn
/// </param>
/// <param name="logical_rect">
/// rectangle used to store the logical
///   extents of the layout
/// </param>

	public static T GetPixelExtents<T>(this T layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_pixel_extents(layout, out ink_rect, out logical_rect);
		return layout;
	}

/// <summary>
/// <para>
/// Determines the logical width and height of a `PangoLayout` in device
/// units.
/// </para>
/// <para>
/// [method@Pango.Layout.get_size] returns the width and height
/// scaled by %PANGO_SCALE. This is simply a convenience function
/// around [method@Pango.Layout.get_pixel_extents].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="width">
/// location to store the logical width
/// </param>
/// <param name="height">
/// location to store the logical height
/// </param>

	public static T GetPixelSize<T>(this T layout, out int width, out int height) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_pixel_size(layout, out width, out height);
		return layout;
	}

/// <summary>
/// <para>
/// Returns the current serial number of @layout.
/// </para>
/// <para>
/// The serial number is initialized to an small number larger than zero
/// when a new layout is created and is increased whenever the layout is
/// changed using any of the setter functions, or the `PangoContext` it
/// uses has changed. The serial may wrap, but will never have the value 0.
/// Since it can wrap, never compare it with "less than", always use "not equals".
/// </para>
/// <para>
/// This can be used to automatically detect changes to a `PangoLayout`,
/// and is useful for example to decide whether a layout needs redrawing.
/// To force the serial to be increased, use
/// [method@Pango.Layout.context_changed].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// The current serial number of @layout.
/// </return>

	public static uint GetSerial(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_serial(layout);
	}

/// <summary>
/// <para>
/// Obtains whether @layout is in single paragraph mode.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_single_paragraph_mode].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// %TRUE if the layout does not break paragraphs
///   at paragraph separator characters, %FALSE otherwise
/// </return>

	public static bool GetSingleParagraphMode(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_single_paragraph_mode(layout);
	}

/// <summary>
/// <para>
/// Determines the logical width and height of a `PangoLayout` in Pango
/// units.
/// </para>
/// <para>
/// This is simply a convenience function around [method@Pango.Layout.get_extents].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="width">
/// location to store the logical width
/// </param>
/// <param name="height">
/// location to store the logical height
/// </param>

	public static T GetSize<T>(this T layout, out int width, out int height) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_get_size(layout, out width, out height);
		return layout;
	}

/// <summary>
/// <para>
/// Gets the amount of spacing between the lines of the layout.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the spacing in Pango units
/// </return>

	public static int GetSpacing(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_spacing(layout);
	}

/// <summary>
/// <para>
/// Gets the current `PangoTabArray` used by this layout.
/// </para>
/// <para>
/// If no `PangoTabArray` has been set, then the default tabs are
/// in use and %NULL is returned. Default tabs are every 8 spaces.
/// </para>
/// <para>
/// The return value should be freed with [method@Pango.TabArray.free].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// a copy of the tabs for this layout
/// </return>

	public static MentorLake.Pango.PangoTabArrayHandle GetTabs(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_tabs(layout);
	}

/// <summary>
/// <para>
/// Gets the text in the layout.
/// </para>
/// <para>
/// The returned text should not be freed or modified.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the text in the @layout
/// </return>

	public static string GetText(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_text(layout);
	}

/// <summary>
/// <para>
/// Counts the number of unknown glyphs in @layout.
/// </para>
/// <para>
/// This function can be used to determine if there are any fonts
/// available to render all characters in a certain string, or when
/// used in combination with %PANGO_ATTR_FALLBACK, to check if a
/// certain font supports all the characters in the string.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// The number of unknown glyphs in @layout
/// </return>

	public static int GetUnknownGlyphsCount(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_unknown_glyphs_count(layout);
	}

/// <summary>
/// <para>
/// Gets the width to which the lines of the `PangoLayout` should wrap.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// the width in Pango units, or -1 if no width set.
/// </return>

	public static int GetWidth(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_width(layout);
	}

/// <summary>
/// <para>
/// Gets the wrap mode for the layout.
/// </para>
/// <para>
/// Use [method@Pango.Layout.is_wrapped] to query whether
/// any paragraphs were actually wrapped.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// active wrap mode.
/// </return>

	public static MentorLake.Pango.PangoWrapMode GetWrap(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_get_wrap(layout);
	}

/// <summary>
/// <para>
/// Converts from byte @index_ within the @layout to line and X position.
/// </para>
/// <para>
/// The X position is measured from the left edge of the line.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="index_">
/// the byte index of a grapheme within the layout
/// </param>
/// <param name="trailing">
/// an integer indicating the edge of the grapheme to retrieve the
///   position of. If > 0, the trailing edge of the grapheme, if 0,
///   the leading of the grapheme
/// </param>
/// <param name="line">
/// location to store resulting line index. (which will
///   between 0 and pango_layout_get_line_count(layout) - 1)
/// </param>
/// <param name="x_pos">
/// location to store resulting position within line
///   (%PANGO_SCALE units per device unit)
/// </param>

	public static T IndexToLineX<T>(this T layout, int index_, bool trailing, out int line, out int x_pos) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_index_to_line_x(layout, index_, trailing, out line, out x_pos);
		return layout;
	}

/// <summary>
/// <para>
/// Converts from an index within a `PangoLayout` to the onscreen position
/// corresponding to the grapheme at that index.
/// </para>
/// <para>
/// The returns is represented as rectangle. Note that `pos->x` is
/// always the leading edge of the grapheme and `pos->x + pos->width` the
/// trailing edge of the grapheme. If the directionality of the grapheme
/// is right-to-left, then `pos->width` will be negative.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="index_">
/// byte index within @layout
/// </param>
/// <param name="pos">
/// rectangle in which to store the position of the grapheme
/// </param>

	public static T IndexToPos<T>(this T layout, int index_, out MentorLake.Pango.PangoRectangle pos) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_index_to_pos(layout, index_, out pos);
		return layout;
	}

/// <summary>
/// <para>
/// Queries whether the layout had to ellipsize any paragraphs.
/// </para>
/// <para>
/// This returns %TRUE if the ellipsization mode for @layout
/// is not %PANGO_ELLIPSIZE_NONE, a positive width is set on @layout,
/// and there are paragraphs exceeding that width that have to be
/// ellipsized.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// %TRUE if any paragraphs had to be ellipsized,
///   %FALSE otherwise
/// </return>

	public static bool IsEllipsized(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_is_ellipsized(layout);
	}

/// <summary>
/// <para>
/// Queries whether the layout had to wrap any paragraphs.
/// </para>
/// <para>
/// This returns %TRUE if a positive width is set on @layout,
/// and there are paragraphs exceeding the layout width that have
/// to be wrapped.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <return>
/// %TRUE if any paragraphs had to be wrapped, %FALSE
///   otherwise
/// </return>

	public static bool IsWrapped(this MentorLake.Pango.PangoLayoutHandle layout)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_is_wrapped(layout);
	}

/// <summary>
/// <para>
/// Computes a new cursor position from an old position and a direction.
/// </para>
/// <para>
/// If @direction is positive, then the new position will cause the strong
/// or weak cursor to be displayed one position to right of where it was
/// with the old cursor position. If @direction is negative, it will be
/// moved to the left.
/// </para>
/// <para>
/// In the presence of bidirectional text, the correspondence between
/// logical and visual order will depend on the direction of the current
/// run, and there may be jumps when the cursor is moved off of the end
/// of a run.
/// </para>
/// <para>
/// Motion here is in cursor positions, not in characters, so a single
/// call to this function may move the cursor over multiple characters
/// when multiple characters combine to form a single grapheme.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="strong">
/// whether the moving cursor is the strong cursor or the
///   weak cursor. The strong cursor is the cursor corresponding
///   to text insertion in the base direction for the layout.
/// </param>
/// <param name="old_index">
/// the byte index of the current cursor position
/// </param>
/// <param name="old_trailing">
/// if 0, the cursor was at the leading edge of the
///   grapheme indicated by @old_index, if > 0, the cursor
///   was at the trailing edge.
/// </param>
/// <param name="direction">
/// direction to move cursor. A negative
///   value indicates motion to the left
/// </param>
/// <param name="new_index">
/// location to store the new cursor byte index.
///   A value of -1 indicates that the cursor has been moved off the
///   beginning of the layout. A value of %G_MAXINT indicates that
///   the cursor has been moved off the end of the layout.
/// </param>
/// <param name="new_trailing">
/// number of characters to move forward from
///   the location returned for @new_index to get the position where
///   the cursor should be displayed. This allows distinguishing the
///   position at the beginning of one line from the position at the
///   end of the preceding line. @new_index is always on the line where
///   the cursor should be displayed.
/// </param>

	public static T MoveCursorVisually<T>(this T layout, bool strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_move_cursor_visually(layout, strong, old_index, old_trailing, direction, out new_index, out new_trailing);
		return layout;
	}

/// <summary>
/// <para>
/// Serializes the @layout for later deserialization via [func@Pango.Layout.deserialize].
/// </para>
/// <para>
/// There are no guarantees about the format of the output across different
/// versions of Pango and [func@Pango.Layout.deserialize] will reject data
/// that it cannot parse.
/// </para>
/// <para>
/// The intended use of this function is testing, benchmarking and debugging.
/// The format is not meant as a permanent storage format.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="flags">
/// `PangoLayoutSerializeFlags`
/// </param>
/// <return>
/// a `GBytes` containing the serialized form of @layout
/// </return>

	public static MentorLake.GLib.GBytesHandle Serialize(this MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_serialize(layout, flags);
	}

/// <summary>
/// <para>
/// Sets the alignment for the layout: how partial lines are
/// positioned within the horizontal space available.
/// </para>
/// <para>
/// The default alignment is %PANGO_ALIGN_LEFT.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="alignment">
/// the alignment
/// </param>

	public static T SetAlignment<T>(this T layout, MentorLake.Pango.PangoAlignment alignment) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_alignment(layout, alignment);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the text attributes for a layout object.
/// </para>
/// <para>
/// References @attrs, so the caller can unref its reference.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="attrs">
/// a `PangoAttrList`
/// </param>

	public static T SetAttributes<T>(this T layout, MentorLake.Pango.PangoAttrListHandle attrs) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_attributes(layout, attrs);
		return layout;
	}

/// <summary>
/// <para>
/// Sets whether to calculate the base direction
/// for the layout according to its contents.
/// </para>
/// <para>
/// When this flag is on (the default), then paragraphs in @layout that
/// begin with strong right-to-left characters (Arabic and Hebrew principally),
/// will have right-to-left layout, paragraphs with letters from other scripts
/// will have left-to-right layout. Paragraphs with only neutral characters
/// get their direction from the surrounding paragraphs.
/// </para>
/// <para>
/// When %FALSE, the choice between left-to-right and right-to-left
/// layout is done according to the base direction of the layout's
/// `PangoContext`. (See [method@Pango.Context.set_base_dir]).
/// </para>
/// <para>
/// When the auto-computed direction of a paragraph differs from the
/// base direction of the context, the interpretation of
/// %PANGO_ALIGN_LEFT and %PANGO_ALIGN_RIGHT are swapped.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="auto_dir">
/// if %TRUE, compute the bidirectional base direction
///   from the layout's contents
/// </param>

	public static T SetAutoDir<T>(this T layout, bool auto_dir) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_auto_dir(layout, auto_dir);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the type of ellipsization being performed for @layout.
/// </para>
/// <para>
/// Depending on the ellipsization mode @ellipsize text is
/// removed from the start, middle, or end of text so they
/// fit within the width and height of layout set with
/// [method@Pango.Layout.set_width] and [method@Pango.Layout.set_height].
/// </para>
/// <para>
/// If the layout contains characters such as newlines that
/// force it to be layed out in multiple paragraphs, then whether
/// each paragraph is ellipsized separately or the entire layout
/// is ellipsized as a whole depends on the set height of the layout.
/// </para>
/// <para>
/// The default value is %PANGO_ELLIPSIZE_NONE.
/// </para>
/// <para>
/// See [method@Pango.Layout.set_height] for details.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="ellipsize">
/// the new ellipsization mode for @layout
/// </param>

	public static T SetEllipsize<T>(this T layout, MentorLake.Pango.PangoEllipsizeMode ellipsize) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_ellipsize(layout, ellipsize);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the default font description for the layout.
/// </para>
/// <para>
/// If no font description is set on the layout, the
/// font description from the layout's context is used.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="desc">
/// the new `PangoFontDescription`
///   to unset the current font description
/// </param>

	public static T SetFontDescription<T>(this T layout, MentorLake.Pango.PangoFontDescriptionHandle desc) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_font_description(layout, desc);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the height to which the `PangoLayout` should be ellipsized at.
/// </para>
/// <para>
/// There are two different behaviors, based on whether @height is positive
/// or negative.
/// </para>
/// <para>
/// If @height is positive, it will be the maximum height of the layout. Only
/// lines would be shown that would fit, and if there is any text omitted,
/// an ellipsis added. At least one line is included in each paragraph regardless
/// of how small the height value is. A value of zero will render exactly one
/// line for the entire layout.
/// </para>
/// <para>
/// If @height is negative, it will be the (negative of) maximum number of lines
/// per paragraph. That is, the total number of lines shown may well be more than
/// this value if the layout contains multiple paragraphs of text.
/// The default value of -1 means that the first line of each paragraph is ellipsized.
/// This behavior may be changed in the future to act per layout instead of per
/// paragraph. File a bug against pango at
/// [https://gitlab.gnome.org/gnome/pango](https://gitlab.gnome.org/gnome/pango)
/// if your code relies on this behavior.
/// </para>
/// <para>
/// Height setting only has effect if a positive width is set on
/// @layout and ellipsization mode of @layout is not %PANGO_ELLIPSIZE_NONE.
/// The behavior is undefined if a height other than -1 is set and
/// ellipsization mode is set to %PANGO_ELLIPSIZE_NONE, and may change in the
/// future.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`.
/// </param>
/// <param name="height">
/// the desired height of the layout in Pango units if positive,
///   or desired number of lines if negative.
/// </param>

	public static T SetHeight<T>(this T layout, int height) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_height(layout, height);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the width in Pango units to indent each paragraph.
/// </para>
/// <para>
/// A negative value of @indent will produce a hanging indentation.
/// That is, the first line will have the full width, and subsequent
/// lines will be indented by the absolute value of @indent.
/// </para>
/// <para>
/// The indent setting is ignored if layout alignment is set to
/// %PANGO_ALIGN_CENTER.
/// </para>
/// <para>
/// The default value is 0.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="indent">
/// the amount by which to indent
/// </param>

	public static T SetIndent<T>(this T layout, int indent) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_indent(layout, indent);
		return layout;
	}

/// <summary>
/// <para>
/// Sets whether each complete line should be stretched to fill the
/// entire width of the layout.
/// </para>
/// <para>
/// Stretching is typically done by adding whitespace, but for some scripts
/// (such as Arabic), the justification may be done in more complex ways,
/// like extending the characters.
/// </para>
/// <para>
/// Note that this setting is not implemented and so is ignored in
/// Pango older than 1.18.
/// </para>
/// <para>
/// Note that tabs and justification conflict with each other:
/// Justification will move content away from its tab-aligned
/// positions.
/// </para>
/// <para>
/// The default value is %FALSE.
/// </para>
/// <para>
/// Also see [method@Pango.Layout.set_justify_last_line].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="justify">
/// whether the lines in the layout should be justified
/// </param>

	public static T SetJustify<T>(this T layout, bool justify) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_justify(layout, justify);
		return layout;
	}

/// <summary>
/// <para>
/// Sets whether the last line should be stretched to fill the
/// entire width of the layout.
/// </para>
/// <para>
/// This only has an effect if [method@Pango.Layout.set_justify] has
/// been called as well.
/// </para>
/// <para>
/// The default value is %FALSE.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="justify">
/// whether the last line in the layout should be justified
/// </param>

	public static T SetJustifyLastLine<T>(this T layout, bool justify) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_justify_last_line(layout, justify);
		return layout;
	}

/// <summary>
/// <para>
/// Sets a factor for line spacing.
/// </para>
/// <para>
/// Typical values are: 0, 1, 1.5, 2. The default values is 0.
/// </para>
/// <para>
/// If @factor is non-zero, lines are placed so that
/// </para>
/// <para>
///     baseline2 = baseline1 + factor * height2
/// </para>
/// <para>
/// where height2 is the line height of the second line
/// (as determined by the font(s)). In this case, the spacing
/// set with [method@Pango.Layout.set_spacing] is ignored.
/// </para>
/// <para>
/// If @factor is zero (the default), spacing is applied as before.
/// </para>
/// <para>
/// Note: for semantics that are closer to the CSS line-height
/// property, see [func@Pango.attr_line_height_new].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="factor">
/// the new line spacing factor
/// </param>

	public static T SetLineSpacing<T>(this T layout, float factor) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_line_spacing(layout, factor);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the layout text and attribute list from marked-up text.
/// </para>
/// <para>
/// See [Pango Markup](pango_markup.html)).
/// </para>
/// <para>
/// Replaces the current text and attribute list.
/// </para>
/// <para>
/// This is the same as [method@Pango.Layout.set_markup_with_accel],
/// but the markup text isn't scanned for accelerators.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="markup">
/// marked-up text
/// </param>
/// <param name="length">
/// length of marked-up text in bytes, or -1 if @markup is
///   `NUL`-terminated
/// </param>

	public static T SetMarkup<T>(this T layout, string markup, int length) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_markup(layout, markup, length);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the layout text and attribute list from marked-up text.
/// </para>
/// <para>
/// See [Pango Markup](pango_markup.html)).
/// </para>
/// <para>
/// Replaces the current text and attribute list.
/// </para>
/// <para>
/// If @accel_marker is nonzero, the given character will mark the
/// character following it as an accelerator. For example, @accel_marker
/// might be an ampersand or underscore. All characters marked
/// as an accelerator will receive a %PANGO_UNDERLINE_LOW attribute,
/// and the first character so marked will be returned in @accel_char.
/// Two @accel_marker characters following each other produce a single
/// literal @accel_marker character.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="markup">
/// marked-up text (see [Pango Markup](pango_markup.html))
/// </param>
/// <param name="length">
/// length of marked-up text in bytes, or -1 if @markup is
///   `NUL`-terminated
/// </param>
/// <param name="accel_marker">
/// marker for accelerators in the text
/// </param>
/// <param name="accel_char">
/// return location
///   for first located accelerator
/// </param>

	public static T SetMarkupWithAccel<T>(this T layout, string markup, int length, char accel_marker, out char accel_char) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_markup_with_accel(layout, markup, length, accel_marker, out accel_char);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the single paragraph mode of @layout.
/// </para>
/// <para>
/// If @setting is %TRUE, do not treat newlines and similar characters
/// as paragraph separators; instead, keep all text in a single paragraph,
/// and display a glyph for paragraph separator characters. Used when
/// you want to allow editing of newlines on a single text line.
/// </para>
/// <para>
/// The default value is %FALSE.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="setting">
/// new setting
/// </param>

	public static T SetSingleParagraphMode<T>(this T layout, bool setting) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_single_paragraph_mode(layout, setting);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the amount of spacing in Pango units between
/// the lines of the layout.
/// </para>
/// <para>
/// When placing lines with spacing, Pango arranges things so that
/// </para>
/// <para>
///     line2.top = line1.bottom + spacing
/// </para>
/// <para>
/// The default value is 0.
/// </para>
/// <para>
/// Note: Since 1.44, Pango is using the line height (as determined
/// by the font) for placing lines when the line spacing factor is set
/// to a non-zero value with [method@Pango.Layout.set_line_spacing].
/// In that case, the @spacing set with this function is ignored.
/// </para>
/// <para>
/// Note: for semantics that are closer to the CSS line-height
/// property, see [func@Pango.attr_line_height_new].
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="spacing">
/// the amount of spacing
/// </param>

	public static T SetSpacing<T>(this T layout, int spacing) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_spacing(layout, spacing);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the tabs to use for @layout, overriding the default tabs.
/// </para>
/// <para>
/// `PangoLayout` will place content at the next tab position
/// whenever it meets a Tab character (U+0009).
/// </para>
/// <para>
/// By default, tabs are every 8 spaces. If @tabs is %NULL, the
/// default tabs are reinstated. @tabs is copied into the layout;
/// you must free your copy of @tabs yourself.
/// </para>
/// <para>
/// Note that tabs and justification conflict with each other:
/// Justification will move content away from its tab-aligned
/// positions. The same is true for alignments other than
/// %PANGO_ALIGN_LEFT.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="tabs">
/// a `PangoTabArray`
/// </param>

	public static T SetTabs<T>(this T layout, MentorLake.Pango.PangoTabArrayHandle tabs) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_tabs(layout, tabs);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the text of the layout.
/// </para>
/// <para>
/// This function validates @text and renders invalid UTF-8
/// with a placeholder glyph.
/// </para>
/// <para>
/// Note that if you have used [method@Pango.Layout.set_markup] or
/// [method@Pango.Layout.set_markup_with_accel] on @layout before, you
/// may want to call [method@Pango.Layout.set_attributes] to clear the
/// attributes set on the layout from the markup as this function does
/// not clear attributes.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="text">
/// the text
/// </param>
/// <param name="length">
/// maximum length of @text, in bytes. -1 indicates that
///   the string is nul-terminated and the length should be calculated.
///   The text will also be truncated on encountering a nul-termination
///   even when @length is positive.
/// </param>

	public static T SetText<T>(this T layout, string text, int length) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_text(layout, text, length);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the width to which the lines of the `PangoLayout` should wrap or
/// get ellipsized.
/// </para>
/// <para>
/// The default value is -1: no width set.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`.
/// </param>
/// <param name="width">
/// the desired width in Pango units, or -1 to indicate that no
///   wrapping or ellipsization should be performed.
/// </param>

	public static T SetWidth<T>(this T layout, int width) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_width(layout, width);
		return layout;
	}

/// <summary>
/// <para>
/// Sets the wrap mode.
/// </para>
/// <para>
/// The wrap mode only has effect if a width is set on the layout
/// with [method@Pango.Layout.set_width]. To turn off wrapping,
/// set the width to -1.
/// </para>
/// <para>
/// The default value is %PANGO_WRAP_WORD.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="wrap">
/// the wrap mode
/// </param>

	public static T SetWrap<T>(this T layout, MentorLake.Pango.PangoWrapMode wrap) where T : PangoLayoutHandle
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		PangoLayoutHandleExterns.pango_layout_set_wrap(layout, wrap);
		return layout;
	}

/// <summary>
/// <para>
/// A convenience method to serialize a layout to a file.
/// </para>
/// <para>
/// It is equivalent to calling [method@Pango.Layout.serialize]
/// followed by [func@GLib.file_set_contents].
/// </para>
/// <para>
/// See those two functions for details on the arguments.
/// </para>
/// <para>
/// It is mostly intended for use inside a debugger to quickly dump
/// a layout to a file for later inspection.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="flags">
/// `PangoLayoutSerializeFlags`
/// </param>
/// <param name="filename">
/// the file to save it to
/// </param>
/// <return>
/// %TRUE if saving was successful
/// </return>

	public static bool WriteToFile(this MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags, string filename)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		var externCallResult = PangoLayoutHandleExterns.pango_layout_write_to_file(layout, flags, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts from X and Y position within a layout to the byte index to the
/// character at that logical position.
/// </para>
/// <para>
/// If the Y position is not inside the layout, the closest position is
/// chosen (the position will be clamped inside the layout). If the X position
/// is not within the layout, then the start or the end of the line is
/// chosen as described for [method@Pango.LayoutLine.x_to_index]. If either
/// the X or Y positions were not inside the layout, then the function returns
/// %FALSE; on an exact hit, it returns %TRUE.
/// </para>
/// </summary>

/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="x">
/// the X offset (in Pango units) from the left edge of the layout
/// </param>
/// <param name="y">
/// the Y offset (in Pango units) from the top edge of the layout
/// </param>
/// <param name="index_">
/// location to store calculated byte index
/// </param>
/// <param name="trailing">
/// location to store a integer indicating where
///   in the grapheme the user clicked. It will either be zero, or the
///   number of characters in the grapheme. 0 represents the leading edge
///   of the grapheme.
/// </param>
/// <return>
/// %TRUE if the coordinates were inside text, %FALSE otherwise
/// </return>

	public static bool XyToIndex(this MentorLake.Pango.PangoLayoutHandle layout, int x, int y, out int index_, out int trailing)
	{
		if (layout.IsInvalid) throw new Exception("Invalid handle (PangoLayoutHandle)");
		return PangoLayoutHandleExterns.pango_layout_xy_to_index(layout, x, y, out index_, out trailing);
	}

}

internal class PangoLayoutHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_context_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle src);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAlignment pango_layout_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))]
	internal static extern MentorLake.Pango.PangoAttrListHandle pango_layout_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_auto_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_caret_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_character_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_layout_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_cursor_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, out MentorLake.Pango.PangoRectangle strong_pos, out MentorLake.Pango.PangoRectangle weak_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection pango_layout_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode pango_layout_get_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_layout_get_font_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutIterHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutIterHandle pango_layout_get_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_justify_last_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_get_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int line);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_line_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_layout_get_line_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int line);

	[DllImport(PangoLibrary.Name)]
	internal static extern float pango_layout_get_line_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle pango_layout_get_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle pango_layout_get_lines_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_log_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.Pango.PangoLogAttr[] attrs, out int n_attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLogAttr[] pango_layout_get_log_attrs_readonly([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out int n_attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_pixel_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out MentorLake.Pango.PangoRectangle ink_rect, out MentorLake.Pango.PangoRectangle logical_rect);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_pixel_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out int width, out int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_layout_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_get_single_paragraph_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, out int width, out int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))]
	internal static extern MentorLake.Pango.PangoTabArrayHandle pango_layout_get_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_layout_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_unknown_glyphs_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_layout_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoWrapMode pango_layout_get_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_index_to_line_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, bool trailing, out int line, out int x_pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_index_to_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int index_, out MentorLake.Pango.PangoRectangle pos);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_is_ellipsized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_is_wrapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_move_cursor_visually([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool strong, int old_index, int old_trailing, int direction, out int new_index, out int new_trailing);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle pango_layout_serialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoAlignment alignment);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrListHandle>))] MentorLake.Pango.PangoAttrListHandle attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_auto_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool auto_dir);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoEllipsizeMode ellipsize);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_font_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_indent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int indent);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_justify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool justify);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_justify_last_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool justify);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_line_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, float factor);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, string markup, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_markup_with_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, string markup, int length, char accel_marker, out char accel_char);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_single_paragraph_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, bool setting);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int spacing);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoTabArrayHandle>))] MentorLake.Pango.PangoTabArrayHandle tabs);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, string text, int length);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int width);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_layout_set_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoWrapMode wrap);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_write_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, MentorLake.Pango.PangoLayoutSerializeFlags flags, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_layout_xy_to_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x, int y, out int index_, out int trailing);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_layout_deserialize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, MentorLake.Pango.PangoLayoutDeserializeFlags flags, out MentorLake.GLib.GErrorHandle error);

}
