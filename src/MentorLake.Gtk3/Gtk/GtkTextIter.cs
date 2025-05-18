namespace MentorLake.Gtk;

public class GtkTextIterHandle : BaseSafeHandle
{
}


public static class GtkTextIterExtensions
{
	public static void Assign(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle other)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_assign(iter, other);
	}

	public static bool BackwardChar(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_char(iter);
	}

	public static bool BackwardChars(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_chars(iter, count);
	}

	public static bool BackwardCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_cursor_position(iter);
	}

	public static bool BackwardCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_cursor_positions(iter, count);
	}

	public static bool BackwardFindChar(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextCharPredicate pred, IntPtr user_data, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_find_char(iter, pred, user_data, limit);
	}

	public static bool BackwardLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_line(iter);
	}

	public static bool BackwardLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_lines(iter, count);
	}

	public static bool BackwardSearch(this MentorLake.Gtk.GtkTextIterHandle iter, string str, MentorLake.Gtk.GtkTextSearchFlags flags, out MentorLake.Gtk.GtkTextIter match_start, out MentorLake.Gtk.GtkTextIter match_end, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_search(iter, str, flags, out match_start, out match_end, limit);
	}

	public static bool BackwardSentenceStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_sentence_start(iter);
	}

	public static bool BackwardSentenceStarts(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_sentence_starts(iter, count);
	}

	public static bool BackwardToTagToggle(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_to_tag_toggle(iter, tag);
	}

	public static bool BackwardVisibleCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_position(iter);
	}

	public static bool BackwardVisibleCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_cursor_positions(iter, count);
	}

	public static bool BackwardVisibleLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_line(iter);
	}

	public static bool BackwardVisibleLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_lines(iter, count);
	}

	public static bool BackwardVisibleWordStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_word_start(iter);
	}

	public static bool BackwardVisibleWordStarts(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_visible_word_starts(iter, count);
	}

	public static bool BackwardWordStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_word_start(iter);
	}

	public static bool BackwardWordStarts(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_backward_word_starts(iter, count);
	}

	public static bool BeginsTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_begins_tag(iter, tag);
	}

	public static bool CanInsert(this MentorLake.Gtk.GtkTextIterHandle iter, bool default_editability)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_can_insert(iter, default_editability);
	}

	public static int Compare(this MentorLake.Gtk.GtkTextIterHandle lhs, MentorLake.Gtk.GtkTextIterHandle rhs)
	{
		if (lhs.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_compare(lhs, rhs);
	}

	public static MentorLake.Gtk.GtkTextIterHandle Copy(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_copy(iter);
	}

	public static bool Editable(this MentorLake.Gtk.GtkTextIterHandle iter, bool default_setting)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_editable(iter, default_setting);
	}

	public static bool EndsLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_line(iter);
	}

	public static bool EndsSentence(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_sentence(iter);
	}

	public static bool EndsTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_tag(iter, tag);
	}

	public static bool EndsWord(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_ends_word(iter);
	}

	public static bool Equal(this MentorLake.Gtk.GtkTextIterHandle lhs, MentorLake.Gtk.GtkTextIterHandle rhs)
	{
		if (lhs.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_equal(lhs, rhs);
	}

	public static bool ForwardChar(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_char(iter);
	}

	public static bool ForwardChars(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_chars(iter, count);
	}

	public static bool ForwardCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_cursor_position(iter);
	}

	public static bool ForwardCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_cursor_positions(iter, count);
	}

	public static bool ForwardFindChar(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextCharPredicate pred, IntPtr user_data, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_find_char(iter, pred, user_data, limit);
	}

	public static bool ForwardLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_line(iter);
	}

	public static bool ForwardLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_lines(iter, count);
	}

	public static bool ForwardSearch(this MentorLake.Gtk.GtkTextIterHandle iter, string str, MentorLake.Gtk.GtkTextSearchFlags flags, out MentorLake.Gtk.GtkTextIter match_start, out MentorLake.Gtk.GtkTextIter match_end, MentorLake.Gtk.GtkTextIterHandle limit)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_search(iter, str, flags, out match_start, out match_end, limit);
	}

	public static bool ForwardSentenceEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_sentence_end(iter);
	}

	public static bool ForwardSentenceEnds(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_sentence_ends(iter, count);
	}

	public static void ForwardToEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_forward_to_end(iter);
	}

	public static bool ForwardToLineEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_to_line_end(iter);
	}

	public static bool ForwardToTagToggle(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_to_tag_toggle(iter, tag);
	}

	public static bool ForwardVisibleCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_position(iter);
	}

	public static bool ForwardVisibleCursorPositions(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_cursor_positions(iter, count);
	}

	public static bool ForwardVisibleLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_line(iter);
	}

	public static bool ForwardVisibleLines(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_lines(iter, count);
	}

	public static bool ForwardVisibleWordEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_word_end(iter);
	}

	public static bool ForwardVisibleWordEnds(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_visible_word_ends(iter, count);
	}

	public static bool ForwardWordEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_word_end(iter);
	}

	public static bool ForwardWordEnds(this MentorLake.Gtk.GtkTextIterHandle iter, int count)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_forward_word_ends(iter, count);
	}

	public static void Free(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_free(iter);
	}

	public static bool GetAttributes(this MentorLake.Gtk.GtkTextIterHandle iter, out MentorLake.Gtk.GtkTextAttributes values)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_attributes(iter, out values);
	}

	public static MentorLake.Gtk.GtkTextBufferHandle GetBuffer(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_buffer(iter);
	}

	public static int GetBytesInLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_bytes_in_line(iter);
	}

	public static char GetChar(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_char(iter);
	}

	public static int GetCharsInLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_chars_in_line(iter);
	}

	public static MentorLake.Gtk.GtkTextChildAnchorHandle GetChildAnchor(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_child_anchor(iter);
	}

	public static MentorLake.Pango.PangoLanguageHandle GetLanguage(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_language(iter);
	}

	public static int GetLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_line(iter);
	}

	public static int GetLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_line_index(iter);
	}

	public static int GetLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_line_offset(iter);
	}

	public static MentorLake.GLib.GSListHandle GetMarks(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_marks(iter);
	}

	public static int GetOffset(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_offset(iter);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_pixbuf(iter);
	}

	public static string GetSlice(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_slice(start, end);
	}

	public static MentorLake.GLib.GSListHandle GetTags(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_tags(iter);
	}

	public static string GetText(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_text(start, end);
	}

	public static MentorLake.GLib.GSListHandle GetToggledTags(this MentorLake.Gtk.GtkTextIterHandle iter, bool toggled_on)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_toggled_tags(iter, toggled_on);
	}

	public static int GetVisibleLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_line_index(iter);
	}

	public static int GetVisibleLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_line_offset(iter);
	}

	public static string GetVisibleSlice(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_slice(start, end);
	}

	public static string GetVisibleText(this MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (start.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_get_visible_text(start, end);
	}

	public static bool HasTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_has_tag(iter, tag);
	}

	public static bool InRange(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextIterHandle start, MentorLake.Gtk.GtkTextIterHandle end)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_in_range(iter, start, end);
	}

	public static bool InsideSentence(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_inside_sentence(iter);
	}

	public static bool InsideWord(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_inside_word(iter);
	}

	public static bool IsCursorPosition(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_is_cursor_position(iter);
	}

	public static bool IsEnd(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_is_end(iter);
	}

	public static bool IsStart(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_is_start(iter);
	}

	public static void Order(this MentorLake.Gtk.GtkTextIterHandle first, MentorLake.Gtk.GtkTextIterHandle second)
	{
		if (first.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_order(first, second);
	}

	public static void SetLine(this MentorLake.Gtk.GtkTextIterHandle iter, int line_number)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_line(iter, line_number);
	}

	public static void SetLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter, int byte_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_line_index(iter, byte_on_line);
	}

	public static void SetLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter, int char_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_line_offset(iter, char_on_line);
	}

	public static void SetOffset(this MentorLake.Gtk.GtkTextIterHandle iter, int char_offset)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_offset(iter, char_offset);
	}

	public static void SetVisibleLineIndex(this MentorLake.Gtk.GtkTextIterHandle iter, int byte_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_visible_line_index(iter, byte_on_line);
	}

	public static void SetVisibleLineOffset(this MentorLake.Gtk.GtkTextIterHandle iter, int char_on_line)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		GtkTextIterExterns.gtk_text_iter_set_visible_line_offset(iter, char_on_line);
	}

	public static bool StartsLine(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_line(iter);
	}

	public static bool StartsSentence(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_sentence(iter);
	}

	public static bool StartsTag(this MentorLake.Gtk.GtkTextIterHandle iter, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_tag(iter, tag);
	}

	public static bool StartsWord(this MentorLake.Gtk.GtkTextIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GtkTextIter)");
		return GtkTextIterExterns.gtk_text_iter_starts_word(iter);
	}

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

public struct GtkTextIter
{
}
