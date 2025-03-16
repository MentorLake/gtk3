namespace MentorLake.Gtk;

public class GtkNotebookPageAccessibleHandle : AtkObjectHandle, AtkComponentHandle
{
	public static MentorLake.Gtk.GtkNotebookPageAccessibleHandle New(MentorLake.Gtk.GtkNotebookAccessibleHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		return GtkNotebookPageAccessibleHandleExterns.gtk_notebook_page_accessible_new(notebook, child);
	}

}

public static class GtkNotebookPageAccessibleHandleExtensions
{
	public static T Invalidate<T>(this T page) where T : GtkNotebookPageAccessibleHandle
	{
		GtkNotebookPageAccessibleHandleExterns.gtk_notebook_page_accessible_invalidate(page);
		return page;
	}

}

internal class GtkNotebookPageAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkNotebookPageAccessibleHandle gtk_notebook_page_accessible_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookAccessibleHandle>))] MentorLake.Gtk.GtkNotebookAccessibleHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_page_accessible_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookPageAccessibleHandle>))] MentorLake.Gtk.GtkNotebookPageAccessibleHandle page);

}
