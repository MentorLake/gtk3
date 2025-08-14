namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// An enum for determining the page role inside the #GtkAssistant. It's
/// used to handle buttons sensitivity and visibility.
/// </para>
/// <para>
/// Note that an assistant needs to end its page flow with a page of type
/// %GTK_ASSISTANT_PAGE_CONFIRM, %GTK_ASSISTANT_PAGE_SUMMARY or
/// %GTK_ASSISTANT_PAGE_PROGRESS to be correct.
/// </para>
/// <para>
/// The Cancel button will only be shown if the page isn’t “committed”.
/// See gtk_assistant_commit() for details.
/// </para>
/// </summary>

[Flags]
public enum GtkAssistantPageType
{
/// <summary>
/// <para>
/// The page has regular contents. Both the
///  Back and forward buttons will be shown.
/// </para>
/// </summary>

	GTK_ASSISTANT_PAGE_CONTENT = 0,
/// <summary>
/// <para>
/// The page contains an introduction to the
///  assistant task. Only the Forward button will be shown if there is a
///   next page.
/// </para>
/// </summary>

	GTK_ASSISTANT_PAGE_INTRO = 1,
/// <summary>
/// <para>
/// The page lets the user confirm or deny the
///  changes. The Back and Apply buttons will be shown.
/// </para>
/// </summary>

	GTK_ASSISTANT_PAGE_CONFIRM = 2,
/// <summary>
/// <para>
/// The page informs the user of the changes
///  done. Only the Close button will be shown.
/// </para>
/// </summary>

	GTK_ASSISTANT_PAGE_SUMMARY = 3,
/// <summary>
/// <para>
/// Used for tasks that take a long time to
///  complete, blocks the assistant until the page is marked as complete.
///   Only the back button will be shown.
/// </para>
/// </summary>

	GTK_ASSISTANT_PAGE_PROGRESS = 4,
/// <summary>
/// <para>
/// Used for when other page types are not
///  appropriate. No buttons will be shown, and the application must
///  add its own buttons through gtk_assistant_add_action_widget().
/// </para>
/// </summary>

	GTK_ASSISTANT_PAGE_CUSTOM = 5
}
