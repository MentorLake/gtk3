namespace MentorLake.Gtk;

[Flags]
public enum GtkAssistantPageType
{
	GTK_ASSISTANT_PAGE_CONTENT = 0,
	GTK_ASSISTANT_PAGE_INTRO = 1,
	GTK_ASSISTANT_PAGE_CONFIRM = 2,
	GTK_ASSISTANT_PAGE_SUMMARY = 3,
	GTK_ASSISTANT_PAGE_PROGRESS = 4,
	GTK_ASSISTANT_PAGE_CUSTOM = 5
}
