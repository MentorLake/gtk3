namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These values are used as “info” for the targets contained in the
/// lists returned by gtk_text_buffer_get_copy_target_list() and
/// gtk_text_buffer_get_paste_target_list().
/// </para>
/// <para>
/// The values counts down from `-1` to avoid clashes
/// with application added drag destinations which usually start at 0.
/// </para>
/// </summary>

[Flags]
public enum GtkTextBufferTargetInfo
{
/// <summary>
/// <para>
/// Buffer contents
/// </para>
/// </summary>

	GTK_TEXT_BUFFER_TARGET_INFO_BUFFER_CONTENTS = -1,
/// <summary>
/// <para>
/// Rich text
/// </para>
/// </summary>

	GTK_TEXT_BUFFER_TARGET_INFO_RICH_TEXT = -2,
/// <summary>
/// <para>
/// Text
/// </para>
/// </summary>

	GTK_TEXT_BUFFER_TARGET_INFO_TEXT = -3
}
