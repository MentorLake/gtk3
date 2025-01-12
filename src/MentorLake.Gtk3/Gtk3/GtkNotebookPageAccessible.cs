namespace MentorLake.Gtk3.Gtk3;

public class GtkNotebookPageAccessibleHandle : AtkObjectHandle, AtkComponentHandle
{
	public static GtkNotebookPageAccessibleHandle New(GtkNotebookAccessibleHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookPageAccessibleExterns.gtk_notebook_page_accessible_new(notebook, child);
	}

}

public static class GtkNotebookPageAccessibleHandleExtensions
{
	public static T Invalidate<T>(this T page) where T : GtkNotebookPageAccessibleHandle
	{
		GtkNotebookPageAccessibleExterns.gtk_notebook_page_accessible_invalidate(page);
		return page;
	}

}

internal class GtkNotebookPageAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkNotebookPageAccessibleHandle gtk_notebook_page_accessible_new(GtkNotebookAccessibleHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_page_accessible_invalidate(GtkNotebookPageAccessibleHandle page);

}
