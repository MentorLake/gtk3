namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and data
/// types related to the text widget and how they work together.
/// </para>
/// </summary>

public class GtkTextIterHandle : BaseSafeHandle
{
}


public static class GtkTextIterExtensions
{
/// <summary>
/// <para>
/// Assigns the value of @other to @iter.  This function
/// is not useful in applications, because iterators can be assigned
/// with `GtkTextIter i = j;`. The
/// function is used by language bindings.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="other">
/// another #GtkTextIter
/// </param>

	public static void Assign(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle other)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_assign(iter, other);
	}

/// <summary>
/// <para>
/// Moves backward by one character offset. Returns %TRUE if movement
/// was possible; if @iter was the first in the buffer (character
/// offset 0), gtk_text_iter_backward_char() returns %FALSE for convenience when
/// writing loops.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether movement was possible
/// </return>

	public static bool BackwardChar(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_char(iter);
	}

/// <summary>
/// <para>
/// Moves @count characters backward, if possible (if @count would move
/// past the start or end of the buffer, moves to the start or end of
/// the buffer).  The return value indicates whether the iterator moved
/// onto a dereferenceable position; if the iterator didn’t move, or
/// moved onto the end iterator, then %FALSE is returned. If @count is 0,
/// the function does nothing and returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="count">
/// number of characters to move
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool BackwardChars(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_chars(iter, count);
	}

/// <summary>
/// <para>
/// Like gtk_text_iter_forward_cursor_position(), but moves backward.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if we moved
/// </return>

	public static bool BackwardCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_cursor_position(iter);
	}

/// <summary>
/// <para>
/// Moves up to @count cursor positions. See
/// gtk_text_iter_forward_cursor_position() for details.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of positions to move
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool BackwardCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_cursor_positions(iter, count);
	}

/// <summary>
/// <para>
/// Same as gtk_text_iter_forward_find_char(), but goes backward from @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="pred">
/// function to be called on each character
/// </param>
/// <param name="user_data">
/// user data for @pred
/// </param>
/// <param name="limit">
/// search limit, or %NULL for none
/// </param>
/// <return>
/// whether a match was found
/// </return>

	public static bool BackwardFindChar(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextCharPredicate pred, IntPtr user_data, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_find_char(iter, pred, user_data, limit);
	}

/// <summary>
/// <para>
/// Moves @iter to the start of the previous line. Returns %TRUE if
/// @iter could be moved; i.e. if @iter was at character offset 0, this
/// function returns %FALSE. Therefore if @iter was already on line 0,
/// but not at the start of the line, @iter is snapped to the start of
/// the line and the function returns %TRUE. (Note that this implies that
/// in a loop calling this function, the line number may not change on
/// every iteration, if your first iteration is on line 0.)
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter moved
/// </return>

	public static bool BackwardLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_line(iter);
	}

/// <summary>
/// <para>
/// Moves @count lines backward, if possible (if @count would move
/// past the start or end of the buffer, moves to the start or end of
/// the buffer).  The return value indicates whether the iterator moved
/// onto a dereferenceable position; if the iterator didn’t move, or
/// moved onto the end iterator, then %FALSE is returned. If @count is 0,
/// the function does nothing and returns %FALSE. If @count is negative,
/// moves forward by 0 - @count lines.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of lines to move backward
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool BackwardLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_lines(iter, count);
	}

/// <summary>
/// <para>
/// Same as gtk_text_iter_forward_search(), but moves backward.
/// </para>
/// <para>
/// @match_end will never be set to a #GtkTextIter located after @iter, even if
/// there is a possible @match_start before or at @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter where the search begins
/// </param>
/// <param name="str">
/// search string
/// </param>
/// <param name="flags">
/// bitmask of flags affecting the search
/// </param>
/// <param name="match_start">
/// return location for start of match, or %NULL
/// </param>
/// <param name="match_end">
/// return location for end of match, or %NULL
/// </param>
/// <param name="limit">
/// location of last possible @match_start, or %NULL for start of buffer
/// </param>
/// <return>
/// whether a match was found
/// </return>

	public static bool BackwardSearch(this MentorLake.Gtk.GtkTextIterHandle iter, string str, MentorLake.Gtk.GtkTextSearchFlags flags, out MentorLake.Gtk.GtkTextIter match_start, out MentorLake.Gtk.GtkTextIter match_end, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_search(iter, str, flags, out match_start, out match_end, limit);
	}

/// <summary>
/// <para>
/// Moves backward to the previous sentence start; if @iter is already at
/// the start of a sentence, moves backward to the next one.  Sentence
/// boundaries are determined by Pango and should be correct for nearly
/// any language (if not, the correct fix would be to the Pango text
/// boundary algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool BackwardSentenceStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_sentence_start(iter);
	}

/// <summary>
/// <para>
/// Calls gtk_text_iter_backward_sentence_start() up to @count times,
/// or until it returns %FALSE. If @count is negative, moves forward
/// instead of backward.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of sentences to move
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool BackwardSentenceStarts(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_sentence_starts(iter, count);
	}

/// <summary>
/// <para>
/// Moves backward to the next toggle (on or off) of the
/// #GtkTextTag @tag, or to the next toggle of any tag if
/// @tag is %NULL. If no matching tag toggles are found,
/// returns %FALSE, otherwise %TRUE. Does not return toggles
/// located at @iter, only toggles before @iter. Sets @iter
/// to the location of the toggle, or the start of the buffer
/// if no toggle is found.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="tag">
/// a #GtkTextTag, or %NULL
/// </param>
/// <return>
/// whether we found a tag toggle before @iter
/// </return>

	public static bool BackwardToTagToggle(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_to_tag_toggle(iter, tag);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the previous visible cursor position. See
/// gtk_text_iter_backward_cursor_position() for details.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool BackwardVisibleCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_position(iter);
	}

/// <summary>
/// <para>
/// Moves up to @count visible cursor positions. See
/// gtk_text_iter_backward_cursor_position() for details.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of positions to move
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool BackwardVisibleCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_positions(iter, count);
	}

/// <summary>
/// <para>
/// Moves @iter to the start of the previous visible line. Returns %TRUE if
/// @iter could be moved; i.e. if @iter was at character offset 0, this
/// function returns %FALSE. Therefore if @iter was already on line 0,
/// but not at the start of the line, @iter is snapped to the start of
/// the line and the function returns %TRUE. (Note that this implies that
/// in a loop calling this function, the line number may not change on
/// every iteration, if your first iteration is on line 0.)
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter moved
/// </return>

	public static bool BackwardVisibleLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_line(iter);
	}

/// <summary>
/// <para>
/// Moves @count visible lines backward, if possible (if @count would move
/// past the start or end of the buffer, moves to the start or end of
/// the buffer).  The return value indicates whether the iterator moved
/// onto a dereferenceable position; if the iterator didn’t move, or
/// moved onto the end iterator, then %FALSE is returned. If @count is 0,
/// the function does nothing and returns %FALSE. If @count is negative,
/// moves forward by 0 - @count lines.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of lines to move backward
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool BackwardVisibleLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_lines(iter, count);
	}

/// <summary>
/// <para>
/// Moves backward to the previous visible word start. (If @iter is currently
/// on a word start, moves backward to the next one after that.) Word breaks
/// are determined by Pango and should be correct for nearly any
/// language (if not, the correct fix would be to the Pango word break
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool BackwardVisibleWordStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_word_start(iter);
	}

/// <summary>
/// <para>
/// Calls gtk_text_iter_backward_visible_word_start() up to @count times.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of times to move
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool BackwardVisibleWordStarts(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_word_starts(iter, count);
	}

/// <summary>
/// <para>
/// Moves backward to the previous word start. (If @iter is currently on a
/// word start, moves backward to the next one after that.) Word breaks
/// are determined by Pango and should be correct for nearly any
/// language (if not, the correct fix would be to the Pango word break
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool BackwardWordStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_word_start(iter);
	}

/// <summary>
/// <para>
/// Calls gtk_text_iter_backward_word_start() up to @count times.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of times to move
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool BackwardWordStarts(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_word_starts(iter, count);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @tag is toggled on at exactly this point. If @tag
/// is %NULL, returns %TRUE if any tag is toggled on at this point.
/// </para>
/// <para>
/// Note that if gtk_text_iter_begins_tag() returns %TRUE, it means that @iter is
/// at the beginning of the tagged range, and that the
/// character at @iter is inside the tagged range. In other
/// words, unlike gtk_text_iter_ends_tag(), if gtk_text_iter_begins_tag() returns
/// %TRUE, gtk_text_iter_has_tag() will also return %TRUE for the same
/// parameters.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="tag">
/// a #GtkTextTag, or %NULL
/// </param>
/// <return>
/// whether @iter is the start of a range tagged with @tag
/// </return>

	public static bool BeginsTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_begins_tag(iter, tag);
	}

/// <summary>
/// <para>
/// Considering the default editability of the buffer, and tags that
/// affect editability, determines whether text inserted at @iter would
/// be editable. If text inserted at @iter would be editable then the
/// user should be allowed to insert text at @iter.
/// gtk_text_buffer_insert_interactive() uses this function to decide
/// whether insertions are allowed at a given position.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="default_editability">
/// %TRUE if text is editable by default
/// </param>
/// <return>
/// whether text inserted at @iter would be editable
/// </return>

	public static bool CanInsert(this MentorLake.Gtk.GtkTextIterHandle iter, bool default_editability)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_can_insert(iter, default_editability);
	}

/// <summary>
/// <para>
/// A qsort()-style function that returns negative if @lhs is less than
/// @rhs, positive if @lhs is greater than @rhs, and 0 if they’re equal.
/// Ordering is in character offset order, i.e. the first character in the buffer
/// is less than the second character in the buffer.
/// </para>
/// </summary>

/// <param name="lhs">
/// a #GtkTextIter
/// </param>
/// <param name="rhs">
/// another #GtkTextIter
/// </param>
/// <return>
/// -1 if @lhs is less than @rhs, 1 if @lhs is greater, 0 if they are equal
/// </return>

	public static int Compare(this MentorLake.Gtk.GtkTextIterHandle lhs, MentorLake.Gtk.GtkTextIterHandle rhs)
	{
		if (lhs.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_compare(lhs, rhs);
	}

/// <summary>
/// <para>
/// Creates a dynamically-allocated copy of an iterator. This function
/// is not useful in applications, because iterators can be copied with a
/// simple assignment (`GtkTextIter i = j;`). The
/// function is used by language bindings.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// a copy of the @iter, free with gtk_text_iter_free()
/// </return>

	public static MentorLake.Gtk.GtkTextIterHandle Copy(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_copy(iter);
	}

/// <summary>
/// <para>
/// Returns whether the character at @iter is within an editable region
/// of text.  Non-editable text is “locked” and can’t be changed by the
/// user via #GtkTextView. This function is simply a convenience
/// wrapper around gtk_text_iter_get_attributes(). If no tags applied
/// to this text affect editability, @default_setting will be returned.
/// </para>
/// <para>
/// You don’t want to use this function to decide whether text can be
/// inserted at @iter, because for insertion you don’t want to know
/// whether the char at @iter is inside an editable range, you want to
/// know whether a new character inserted at @iter would be inside an
/// editable range. Use gtk_text_iter_can_insert() to handle this
/// case.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="default_setting">
/// %TRUE if text is editable by default
/// </param>
/// <return>
/// whether @iter is inside an editable range
/// </return>

	public static bool Editable(this MentorLake.Gtk.GtkTextIterHandle iter, bool default_setting)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_editable(iter, default_setting);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter points to the start of the paragraph
/// delimiter characters for a line (delimiters will be either a
/// newline, a carriage return, a carriage return followed by a
/// newline, or a Unicode paragraph separator character). Note that an
/// iterator pointing to the \n of a \r\n pair will not be counted as
/// the end of a line, the line ends before the \r. The end iterator is
/// considered to be at the end of a line, even though there are no
/// paragraph delimiter chars there.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter is at the end of a line
/// </return>

	public static bool EndsLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_line(iter);
	}

/// <summary>
/// <para>
/// Determines whether @iter ends a sentence.  Sentence boundaries are
/// determined by Pango and should be correct for nearly any language
/// (if not, the correct fix would be to the Pango text boundary
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter is at the end of a sentence.
/// </return>

	public static bool EndsSentence(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_sentence(iter);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @tag is toggled off at exactly this point. If @tag
/// is %NULL, returns %TRUE if any tag is toggled off at this point.
/// </para>
/// <para>
/// Note that if gtk_text_iter_ends_tag() returns %TRUE, it means that @iter is
/// at the end of the tagged range, but that the character
/// at @iter is outside the tagged range. In other words,
/// unlike gtk_text_iter_starts_tag(), if gtk_text_iter_ends_tag() returns %TRUE,
/// gtk_text_iter_has_tag() will return %FALSE for the same parameters.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="tag">
/// a #GtkTextTag, or %NULL
/// </param>
/// <return>
/// whether @iter is the end of a range tagged with @tag
/// </return>

	public static bool EndsTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_tag(iter, tag);
	}

/// <summary>
/// <para>
/// Determines whether @iter ends a natural-language word.  Word breaks
/// are determined by Pango and should be correct for nearly any
/// language (if not, the correct fix would be to the Pango word break
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter is at the end of a word
/// </return>

	public static bool EndsWord(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_word(iter);
	}

/// <summary>
/// <para>
/// Tests whether two iterators are equal, using the fastest possible
/// mechanism. This function is very fast; you can expect it to perform
/// better than e.g. getting the character offset for each iterator and
/// comparing the offsets yourself. Also, it’s a bit faster than
/// gtk_text_iter_compare().
/// </para>
/// </summary>

/// <param name="lhs">
/// a #GtkTextIter
/// </param>
/// <param name="rhs">
/// another #GtkTextIter
/// </param>
/// <return>
/// %TRUE if the iterators point to the same place in the buffer
/// </return>

	public static bool Equal(this MentorLake.Gtk.GtkTextIterHandle lhs, MentorLake.Gtk.GtkTextIterHandle rhs)
	{
		if (lhs.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_equal(lhs, rhs);
	}

/// <summary>
/// <para>
/// Moves @iter forward by one character offset. Note that images
/// embedded in the buffer occupy 1 character slot, so
/// gtk_text_iter_forward_char() may actually move onto an image instead
/// of a character, if you have images in your buffer.  If @iter is the
/// end iterator or one character before it, @iter will now point at
/// the end iterator, and gtk_text_iter_forward_char() returns %FALSE for
/// convenience when writing loops.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool ForwardChar(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_char(iter);
	}

/// <summary>
/// <para>
/// Moves @count characters if possible (if @count would move past the
/// start or end of the buffer, moves to the start or end of the
/// buffer). The return value indicates whether the new position of
/// @iter is different from its original position, and dereferenceable
/// (the last iterator in the buffer is not dereferenceable). If @count
/// is 0, the function does nothing and returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="count">
/// number of characters to move, may be negative
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool ForwardChars(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_chars(iter, count);
	}

/// <summary>
/// <para>
/// Moves @iter forward by a single cursor position. Cursor positions
/// are (unsurprisingly) positions where the cursor can appear. Perhaps
/// surprisingly, there may not be a cursor position between all
/// characters. The most common example for European languages would be
/// a carriage return/newline sequence. For some Unicode characters,
/// the equivalent of say the letter “a” with an accent mark will be
/// represented as two characters, first the letter then a "combining
/// mark" that causes the accent to be rendered; so the cursor can’t go
/// between those two characters. See also the #PangoLogAttr-struct and
/// pango_break() function.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool ForwardCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_cursor_position(iter);
	}

/// <summary>
/// <para>
/// Moves up to @count cursor positions. See
/// gtk_text_iter_forward_cursor_position() for details.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of positions to move
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool ForwardCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_cursor_positions(iter, count);
	}

/// <summary>
/// <para>
/// Advances @iter, calling @pred on each character. If
/// @pred returns %TRUE, returns %TRUE and stops scanning.
/// If @pred never returns %TRUE, @iter is set to @limit if
/// @limit is non-%NULL, otherwise to the end iterator.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="pred">
/// a function to be called on each character
/// </param>
/// <param name="user_data">
/// user data for @pred
/// </param>
/// <param name="limit">
/// search limit, or %NULL for none
/// </param>
/// <return>
/// whether a match was found
/// </return>

	public static bool ForwardFindChar(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextCharPredicate pred, IntPtr user_data, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_find_char(iter, pred, user_data, limit);
	}

/// <summary>
/// <para>
/// Moves @iter to the start of the next line. If the iter is already on the
/// last line of the buffer, moves the iter to the end of the current line.
/// If after the operation, the iter is at the end of the buffer and not
/// dereferencable, returns %FALSE. Otherwise, returns %TRUE.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter can be dereferenced
/// </return>

	public static bool ForwardLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_line(iter);
	}

/// <summary>
/// <para>
/// Moves @count lines forward, if possible (if @count would move
/// past the start or end of the buffer, moves to the start or end of
/// the buffer).  The return value indicates whether the iterator moved
/// onto a dereferenceable position; if the iterator didn’t move, or
/// moved onto the end iterator, then %FALSE is returned. If @count is 0,
/// the function does nothing and returns %FALSE. If @count is negative,
/// moves backward by 0 - @count lines.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of lines to move forward
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool ForwardLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_lines(iter, count);
	}

/// <summary>
/// <para>
/// Searches forward for @str. Any match is returned by setting
/// @match_start to the first character of the match and @match_end to the
/// first character after the match. The search will not continue past
/// @limit. Note that a search is a linear or O(n) operation, so you
/// may wish to use @limit to avoid locking up your UI on large
/// buffers.
/// </para>
/// <para>
/// @match_start will never be set to a #GtkTextIter located before @iter, even if
/// there is a possible @match_end after or at @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// start of search
/// </param>
/// <param name="str">
/// a search string
/// </param>
/// <param name="flags">
/// flags affecting how the search is done
/// </param>
/// <param name="match_start">
/// return location for start of match, or %NULL
/// </param>
/// <param name="match_end">
/// return location for end of match, or %NULL
/// </param>
/// <param name="limit">
/// location of last possible @match_end, or %NULL for the end of the buffer
/// </param>
/// <return>
/// whether a match was found
/// </return>

	public static bool ForwardSearch(this MentorLake.Gtk.GtkTextIterHandle iter, string str, MentorLake.Gtk.GtkTextSearchFlags flags, out MentorLake.Gtk.GtkTextIter match_start, out MentorLake.Gtk.GtkTextIter match_end, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_search(iter, str, flags, out match_start, out match_end, limit);
	}

/// <summary>
/// <para>
/// Moves forward to the next sentence end. (If @iter is at the end of
/// a sentence, moves to the next end of sentence.)  Sentence
/// boundaries are determined by Pango and should be correct for nearly
/// any language (if not, the correct fix would be to the Pango text
/// boundary algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool ForwardSentenceEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_sentence_end(iter);
	}

/// <summary>
/// <para>
/// Calls gtk_text_iter_forward_sentence_end() @count times (or until
/// gtk_text_iter_forward_sentence_end() returns %FALSE). If @count is
/// negative, moves backward instead of forward.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of sentences to move
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool ForwardSentenceEnds(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_sentence_ends(iter, count);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the “end iterator,” which points one past the last
/// valid character in the buffer. gtk_text_iter_get_char() called on the
/// end iterator returns 0, which is convenient for writing loops.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>

	public static void ForwardToEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_forward_to_end(iter);
	}

/// <summary>
/// <para>
/// Moves the iterator to point to the paragraph delimiter characters,
/// which will be either a newline, a carriage return, a carriage
/// return/newline in sequence, or the Unicode paragraph separator
/// character. If the iterator is already at the paragraph delimiter
/// characters, moves to the paragraph delimiter characters for the
/// next line. If @iter is on the last line in the buffer, which does
/// not end in paragraph delimiters, moves to the end iterator (end of
/// the last line), and returns %FALSE.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if we moved and the new location is not the end iterator
/// </return>

	public static bool ForwardToLineEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_to_line_end(iter);
	}

/// <summary>
/// <para>
/// Moves forward to the next toggle (on or off) of the
/// #GtkTextTag @tag, or to the next toggle of any tag if
/// @tag is %NULL. If no matching tag toggles are found,
/// returns %FALSE, otherwise %TRUE. Does not return toggles
/// located at @iter, only toggles after @iter. Sets @iter to
/// the location of the toggle, or to the end of the buffer
/// if no toggle is found.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="tag">
/// a #GtkTextTag, or %NULL
/// </param>
/// <return>
/// whether we found a tag toggle after @iter
/// </return>

	public static bool ForwardToTagToggle(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_to_tag_toggle(iter, tag);
	}

/// <summary>
/// <para>
/// Moves @iter forward to the next visible cursor position. See
/// gtk_text_iter_forward_cursor_position() for details.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool ForwardVisibleCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_position(iter);
	}

/// <summary>
/// <para>
/// Moves up to @count visible cursor positions. See
/// gtk_text_iter_forward_cursor_position() for details.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of positions to move
/// </param>
/// <return>
/// %TRUE if we moved and the new position is dereferenceable
/// </return>

	public static bool ForwardVisibleCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_positions(iter, count);
	}

/// <summary>
/// <para>
/// Moves @iter to the start of the next visible line. Returns %TRUE if there
/// was a next line to move to, and %FALSE if @iter was simply moved to
/// the end of the buffer and is now not dereferenceable, or if @iter was
/// already at the end of the buffer.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter can be dereferenced
/// </return>

	public static bool ForwardVisibleLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_line(iter);
	}

/// <summary>
/// <para>
/// Moves @count visible lines forward, if possible (if @count would move
/// past the start or end of the buffer, moves to the start or end of
/// the buffer).  The return value indicates whether the iterator moved
/// onto a dereferenceable position; if the iterator didn’t move, or
/// moved onto the end iterator, then %FALSE is returned. If @count is 0,
/// the function does nothing and returns %FALSE. If @count is negative,
/// moves backward by 0 - @count lines.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of lines to move forward
/// </param>
/// <return>
/// whether @iter moved and is dereferenceable
/// </return>

	public static bool ForwardVisibleLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_lines(iter, count);
	}

/// <summary>
/// <para>
/// Moves forward to the next visible word end. (If @iter is currently on a
/// word end, moves forward to the next one after that.) Word breaks
/// are determined by Pango and should be correct for nearly any
/// language (if not, the correct fix would be to the Pango word break
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool ForwardVisibleWordEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_word_end(iter);
	}

/// <summary>
/// <para>
/// Calls gtk_text_iter_forward_visible_word_end() up to @count times.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of times to move
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool ForwardVisibleWordEnds(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_word_ends(iter, count);
	}

/// <summary>
/// <para>
/// Moves forward to the next word end. (If @iter is currently on a
/// word end, moves forward to the next one after that.) Word breaks
/// are determined by Pango and should be correct for nearly any
/// language (if not, the correct fix would be to the Pango word break
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool ForwardWordEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_word_end(iter);
	}

/// <summary>
/// <para>
/// Calls gtk_text_iter_forward_word_end() up to @count times.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="count">
/// number of times to move
/// </param>
/// <return>
/// %TRUE if @iter moved and is not the end iterator
/// </return>

	public static bool ForwardWordEnds(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_word_ends(iter, count);
	}

/// <summary>
/// <para>
/// Free an iterator allocated on the heap. This function
/// is intended for use in language bindings, and is not
/// especially useful for applications, because iterators can
/// simply be allocated on the stack.
/// </para>
/// </summary>

/// <param name="iter">
/// a dynamically-allocated iterator
/// </param>

	public static void Free(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_free(iter);
	}

/// <summary>
/// <para>
/// Computes the effect of any tags applied to this spot in the
/// text. The @values parameter should be initialized to the default
/// settings you wish to use if no tags are in effect. You’d typically
/// obtain the defaults from gtk_text_view_get_default_attributes().
/// </para>
/// <para>
/// gtk_text_iter_get_attributes() will modify @values, applying the
/// effects of any tags present at @iter. If any tags affected @values,
/// the function returns %TRUE.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="values">
/// a #GtkTextAttributes to be filled in
/// </param>
/// <return>
/// %TRUE if @values was modified
/// </return>

	public static bool GetAttributes(this MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gtk.GtkTextAttributes values)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_attributes(iter, out values);
	}

/// <summary>
/// <para>
/// Returns the #GtkTextBuffer this iterator is associated with.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// the buffer
/// </return>

	public static MentorLake.Gtk.GtkTextBufferHandle GetBuffer(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_buffer(iter);
	}

/// <summary>
/// <para>
/// Returns the number of bytes in the line containing @iter,
/// including the paragraph delimiters.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// number of bytes in the line
/// </return>

	public static int GetBytesInLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_bytes_in_line(iter);
	}

/// <summary>
/// <para>
/// The Unicode character at this iterator is returned.  (Equivalent to
/// operator* on a C++ iterator.)  If the element at this iterator is a
/// non-character element, such as an image embedded in the buffer, the
/// Unicode “unknown” character 0xFFFC is returned. If invoked on
/// the end iterator, zero is returned; zero is not a valid Unicode character.
/// So you can write a loop which ends when gtk_text_iter_get_char()
/// returns 0.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// a Unicode character, or 0 if @iter is not dereferenceable
/// </return>

	public static char GetChar(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_char(iter);
	}

/// <summary>
/// <para>
/// Returns the number of characters in the line containing @iter,
/// including the paragraph delimiters.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// number of characters in the line
/// </return>

	public static int GetCharsInLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_chars_in_line(iter);
	}

/// <summary>
/// <para>
/// If the location at @iter contains a child anchor, the
/// anchor is returned (with no new reference count added). Otherwise,
/// %NULL is returned.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// the anchor at @iter
/// </return>

	public static MentorLake.Gtk.GtkTextChildAnchorHandle GetChildAnchor(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_child_anchor(iter);
	}

/// <summary>
/// <para>
/// A convenience wrapper around gtk_text_iter_get_attributes(),
/// which returns the language in effect at @iter. If no tags affecting
/// language apply to @iter, the return value is identical to that of
/// gtk_get_default_language().
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// language in effect at @iter
/// </return>

	public static MentorLake.Pango.PangoLanguageHandle GetLanguage(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_language(iter);
	}

/// <summary>
/// <para>
/// Returns the line number containing the iterator. Lines in
/// a #GtkTextBuffer are numbered beginning with 0 for the first
/// line in the buffer.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// a line number
/// </return>

	public static int GetLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_line(iter);
	}

/// <summary>
/// <para>
/// Returns the byte index of the iterator, counting
/// from the start of a newline-terminated line.
/// Remember that #GtkTextBuffer encodes text in
/// UTF-8, and that characters can require a variable
/// number of bytes to represent.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// distance from start of line, in bytes
/// </return>

	public static int GetLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_line_index(iter);
	}

/// <summary>
/// <para>
/// Returns the character offset of the iterator,
/// counting from the start of a newline-terminated line.
/// The first character on the line has offset 0.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// offset from start of line
/// </return>

	public static int GetLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_line_offset(iter);
	}

/// <summary>
/// <para>
/// Returns a list of all #GtkTextMark at this location. Because marks
/// are not iterable (they don’t take up any "space" in the buffer,
/// they are just marks in between iterable locations), multiple marks
/// can exist in the same place. The returned list is not in any
/// meaningful order.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// list of #GtkTextMark
/// </return>

	public static MentorLake.GLib.GSListHandle GetMarks(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_marks(iter);
	}

/// <summary>
/// <para>
/// Returns the character offset of an iterator.
/// Each character in a #GtkTextBuffer has an offset,
/// starting with 0 for the first character in the buffer.
/// Use gtk_text_buffer_get_iter_at_offset() to convert an
/// offset back into an iterator.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// a character offset
/// </return>

	public static int GetOffset(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_offset(iter);
	}

/// <summary>
/// <para>
/// If the element at @iter is a pixbuf, the pixbuf is returned
/// (with no new reference count added). Otherwise,
/// %NULL is returned.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// the pixbuf at @iter
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_pixbuf(iter);
	}

/// <summary>
/// <para>
/// Returns the text in the given range. A “slice” is an array of
/// characters encoded in UTF-8 format, including the Unicode “unknown”
/// character 0xFFFC for iterable non-character elements in the buffer,
/// such as images.  Because images are encoded in the slice, byte and
/// character offsets in the returned array will correspond to byte
/// offsets in the text buffer. Note that 0xFFFC can occur in normal
/// text as well, so it is not a reliable indicator that a pixbuf or
/// widget is in the buffer.
/// </para>
/// </summary>

/// <param name="start">
/// iterator at start of a range
/// </param>
/// <param name="end">
/// iterator at end of a range
/// </param>
/// <return>
/// slice of text from the buffer
/// </return>

	public static string GetSlice(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_slice(start, end);
	}

/// <summary>
/// <para>
/// Returns a list of tags that apply to @iter, in ascending order of
/// priority (highest-priority tags are last). The #GtkTextTag in the
/// list don’t have a reference added, but you have to free the list
/// itself.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// list of #GtkTextTag
/// </return>

	public static MentorLake.GLib.GSListHandle GetTags(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_tags(iter);
	}

/// <summary>
/// <para>
/// Returns text in the given range.  If the range
/// contains non-text elements such as images, the character and byte
/// offsets in the returned string will not correspond to character and
/// byte offsets in the buffer. If you want offsets to correspond, see
/// gtk_text_iter_get_slice().
/// </para>
/// </summary>

/// <param name="start">
/// iterator at start of a range
/// </param>
/// <param name="end">
/// iterator at end of a range
/// </param>
/// <return>
/// array of characters from the buffer
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_text(start, end);
	}

/// <summary>
/// <para>
/// Returns a list of #GtkTextTag that are toggled on or off at this
/// point.  (If @toggled_on is %TRUE, the list contains tags that are
/// toggled on.) If a tag is toggled on at @iter, then some non-empty
/// range of characters following @iter has that tag applied to it.  If
/// a tag is toggled off, then some non-empty range following @iter
/// does not have the tag applied to it.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="toggled_on">
/// %TRUE to get toggled-on tags
/// </param>
/// <return>
/// tags toggled at this point
/// </return>

	public static MentorLake.GLib.GSListHandle GetToggledTags(this MentorLake.Gtk.GtkTextIterHandle iter, bool toggled_on)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_toggled_tags(iter, toggled_on);
	}

/// <summary>
/// <para>
/// Returns the number of bytes from the start of the
/// line to the given @iter, not counting bytes that
/// are invisible due to tags with the “invisible” flag
/// toggled on.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// byte index of @iter with respect to the start of the line
/// </return>

	public static int GetVisibleLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_line_index(iter);
	}

/// <summary>
/// <para>
/// Returns the offset in characters from the start of the
/// line to the given @iter, not counting characters that
/// are invisible due to tags with the “invisible” flag
/// toggled on.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// offset in visible characters from the start of the line
/// </return>

	public static int GetVisibleLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_line_offset(iter);
	}

/// <summary>
/// <para>
/// Like gtk_text_iter_get_slice(), but invisible text is not included.
/// Invisible text is usually invisible because a #GtkTextTag with the
/// “invisible” attribute turned on has been applied to it.
/// </para>
/// </summary>

/// <param name="start">
/// iterator at start of range
/// </param>
/// <param name="end">
/// iterator at end of range
/// </param>
/// <return>
/// slice of text from the buffer
/// </return>

	public static string GetVisibleSlice(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_slice(start, end);
	}

/// <summary>
/// <para>
/// Like gtk_text_iter_get_text(), but invisible text is not included.
/// Invisible text is usually invisible because a #GtkTextTag with the
/// “invisible” attribute turned on has been applied to it.
/// </para>
/// </summary>

/// <param name="start">
/// iterator at start of range
/// </param>
/// <param name="end">
/// iterator at end of range
/// </param>
/// <return>
/// string containing visible text in the
/// range
/// </return>

	public static string GetVisibleText(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_text(start, end);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter points to a character that is part of a range tagged
/// with @tag. See also gtk_text_iter_starts_tag() and gtk_text_iter_ends_tag().
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="tag">
/// a #GtkTextTag
/// </param>
/// <return>
/// whether @iter is tagged with @tag
/// </return>

	public static bool HasTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_has_tag(iter, tag);
	}

/// <summary>
/// <para>
/// Checks whether @iter falls in the range [@start, @end).
/// @start and @end must be in ascending order.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="start">
/// start of range
/// </param>
/// <param name="end">
/// end of range
/// </param>
/// <return>
/// %TRUE if @iter is in the range
/// </return>

	public static bool InRange(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_in_range(iter, start, end);
	}

/// <summary>
/// <para>
/// Determines whether @iter is inside a sentence (as opposed to in
/// between two sentences, e.g. after a period and before the first
/// letter of the next sentence).  Sentence boundaries are determined
/// by Pango and should be correct for nearly any language (if not, the
/// correct fix would be to the Pango text boundary algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter is inside a sentence.
/// </return>

	public static bool InsideSentence(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_inside_sentence(iter);
	}

/// <summary>
/// <para>
/// Determines whether the character pointed by @iter is part of a
/// natural-language word (as opposed to say inside some whitespace).  Word
/// breaks are determined by Pango and should be correct for nearly any language
/// (if not, the correct fix would be to the Pango word break algorithms).
/// </para>
/// <para>
/// Note that if gtk_text_iter_starts_word() returns %TRUE, then this function
/// returns %TRUE too, since @iter points to the first character of the word.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter is inside a word
/// </return>

	public static bool InsideWord(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_inside_word(iter);
	}

/// <summary>
/// <para>
/// See gtk_text_iter_forward_cursor_position() or #PangoLogAttr or
/// pango_break() for details on what a cursor position is.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if the cursor can be placed at @iter
/// </return>

	public static bool IsCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_is_cursor_position(iter);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter is the end iterator, i.e. one past the last
/// dereferenceable iterator in the buffer. gtk_text_iter_is_end() is
/// the most efficient way to check whether an iterator is the end
/// iterator.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter is the end iterator
/// </return>

	public static bool IsEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_is_end(iter);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter is the first iterator in the buffer, that is
/// if @iter has a character offset of 0.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter is the first in the buffer
/// </return>

	public static bool IsStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_is_start(iter);
	}

/// <summary>
/// <para>
/// Swaps the value of @first and @second if @second comes before
/// @first in the buffer. That is, ensures that @first and @second are
/// in sequence. Most text buffer functions that take a range call this
/// automatically on your behalf, so there’s no real reason to call it yourself
/// in those cases. There are some exceptions, such as gtk_text_iter_in_range(),
/// that expect a pre-sorted range.
/// </para>
/// </summary>

/// <param name="first">
/// a #GtkTextIter
/// </param>
/// <param name="second">
/// another #GtkTextIter
/// </param>

	public static void Order(this MentorLake.Gtk.GtkTextIterHandle first, MentorLake.Gtk.GtkTextIterHandle second)
	{
		if (first.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_order(first, second);
	}

/// <summary>
/// <para>
/// Moves iterator @iter to the start of the line @line_number.  If
/// @line_number is negative or larger than the number of lines in the
/// buffer, moves @iter to the start of the last line in the buffer.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="line_number">
/// line number (counted from 0)
/// </param>

	public static void SetLine(this MentorLake.Gtk.GtkTextIterHandle iter, int line_number)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_line(iter, line_number);
	}

/// <summary>
/// <para>
/// Same as gtk_text_iter_set_line_offset(), but works with a
/// byte index. The given byte index must be at
/// the start of a character, it can’t be in the middle of a UTF-8
/// encoded character.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="byte_on_line">
/// a byte index relative to the start of @iter’s current line
/// </param>

	public static void SetLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter, int byte_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_line_index(iter, byte_on_line);
	}

/// <summary>
/// <para>
/// Moves @iter within a line, to a new character
/// (not byte) offset. The given character offset must be less than or
/// equal to the number of characters in the line; if equal, @iter
/// moves to the start of the next line. See
/// gtk_text_iter_set_line_index() if you have a byte index rather than
/// a character offset.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="char_on_line">
/// a character offset relative to the start of @iter’s current line
/// </param>

	public static void SetLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter, int char_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_line_offset(iter, char_on_line);
	}

/// <summary>
/// <para>
/// Sets @iter to point to @char_offset. @char_offset counts from the start
/// of the entire text buffer, starting with 0.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="char_offset">
/// a character number
/// </param>

	public static void SetOffset(this MentorLake.Gtk.GtkTextIterHandle iter, int char_offset)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_offset(iter, char_offset);
	}

/// <summary>
/// <para>
/// Like gtk_text_iter_set_line_index(), but the index is in visible
/// bytes, i.e. text with a tag making it invisible is not counted
/// in the index.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="byte_on_line">
/// a byte index
/// </param>

	public static void SetVisibleLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter, int byte_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_visible_line_index(iter, byte_on_line);
	}

/// <summary>
/// <para>
/// Like gtk_text_iter_set_line_offset(), but the offset is in visible
/// characters, i.e. text with a tag making it invisible is not
/// counted in the offset.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <param name="char_on_line">
/// a character offset
/// </param>

	public static void SetVisibleLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter, int char_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_visible_line_offset(iter, char_on_line);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter begins a paragraph,
/// i.e. if gtk_text_iter_get_line_offset() would return 0.
/// However this function is potentially more efficient than
/// gtk_text_iter_get_line_offset() because it doesn’t have to compute
/// the offset, it just has to see whether it’s 0.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <return>
/// whether @iter begins a line
/// </return>

	public static bool StartsLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_line(iter);
	}

/// <summary>
/// <para>
/// Determines whether @iter begins a sentence.  Sentence boundaries are
/// determined by Pango and should be correct for nearly any language
/// (if not, the correct fix would be to the Pango text boundary
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter is at the start of a sentence.
/// </return>

	public static bool StartsSentence(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_sentence(iter);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @tag is toggled on at exactly this point. If @tag
/// is %NULL, returns %TRUE if any tag is toggled on at this point.
/// </para>
/// <para>
/// Note that if gtk_text_iter_starts_tag() returns %TRUE, it means that @iter is
/// at the beginning of the tagged range, and that the
/// character at @iter is inside the tagged range. In other
/// words, unlike gtk_text_iter_ends_tag(), if gtk_text_iter_starts_tag() returns
/// %TRUE, gtk_text_iter_has_tag() will also return %TRUE for the same
/// parameters.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="tag">
/// a #GtkTextTag, or %NULL
/// </param>
/// <return>
/// whether @iter is the start of a range tagged with @tag
/// </return>

	public static bool StartsTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_tag(iter, tag);
	}

/// <summary>
/// <para>
/// Determines whether @iter begins a natural-language word.  Word
/// breaks are determined by Pango and should be correct for nearly any
/// language (if not, the correct fix would be to the Pango word break
/// algorithms).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GtkTextIter
/// </param>
/// <return>
/// %TRUE if @iter is at the start of a word
/// </return>

	public static bool StartsWord(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_word(iter);
	}

/// <summary>
/// <para>
/// This is equivalent to (gtk_text_iter_starts_tag() ||
/// gtk_text_iter_ends_tag()), i.e. it tells you whether a range with
/// @tag applied to it begins or ends at @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// an iterator
/// </param>
/// <param name="tag">
/// a #GtkTextTag, or %NULL
/// </param>
/// <return>
/// whether @tag is toggled on or off at @iter
/// </return>

	public static bool TogglesTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_toggles_tag(iter, tag);
	}


	public static GtkTextIter Dereference(this GtkTextIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextIter>(x.DangerousGetHandle());
}
internal class GtkTextIterExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_assign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle other);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_cursor_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_cursor_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_find_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextCharPredicate pred, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle limit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string str, MentorLake.Gtk.GtkTextSearchFlags flags, out MentorLake.Gtk.GtkTextIter match_start, out MentorLake.Gtk.GtkTextIter match_end, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle limit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_sentence_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_sentence_starts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_to_tag_toggle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_visible_cursor_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_visible_cursor_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_visible_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_visible_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_visible_word_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_visible_word_starts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_word_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_backward_word_starts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_begins_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_can_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, bool default_editability);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle lhs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle rhs);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))]
	internal static extern MentorLake.Gtk.GtkTextIterHandle gtk_text_iter_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, bool default_setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_ends_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_ends_sentence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_ends_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_ends_word([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle lhs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle rhs);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_cursor_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_cursor_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_find_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextCharPredicate pred, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle limit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, string str, MentorLake.Gtk.GtkTextSearchFlags flags, out MentorLake.Gtk.GtkTextIter match_start, out MentorLake.Gtk.GtkTextIter match_end, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle limit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_sentence_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_sentence_ends([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_forward_to_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_to_line_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_to_tag_toggle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_visible_cursor_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_visible_cursor_positions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_visible_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_visible_lines([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_visible_word_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_visible_word_ends([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_word_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_forward_word_ends([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_get_attributes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gtk.GtkTextAttributes values);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))]
	internal static extern MentorLake.Gtk.GtkTextBufferHandle gtk_text_iter_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_bytes_in_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern char gtk_text_iter_get_char([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_chars_in_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))]
	internal static extern MentorLake.Gtk.GtkTextChildAnchorHandle gtk_text_iter_get_child_anchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoLanguageHandle gtk_text_iter_get_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_line_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_line_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_text_iter_get_marks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_text_iter_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_iter_get_slice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_text_iter_get_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_iter_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_text_iter_get_toggled_tags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, bool toggled_on);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_visible_line_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_iter_get_visible_line_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_iter_get_visible_slice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_iter_get_visible_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_has_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_in_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle start, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle end);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_inside_sentence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_inside_word([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_is_cursor_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_is_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_is_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle first, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle second);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_set_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int line_number);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_set_line_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int byte_on_line);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_set_line_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int char_on_line);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_set_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int char_offset);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_set_visible_line_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int byte_on_line);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_iter_set_visible_line_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, int char_on_line);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_starts_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_starts_sentence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_starts_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_starts_word([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_iter_toggles_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextIterHandle>))] MentorLake.Gtk.GtkTextIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

}

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and data
/// types related to the text widget and how they work together.
/// </para>
/// </summary>

public struct GtkTextIter
{
}
