namespace MentorLake.Gtk;


public class GtkNotebookPageAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkNotebookPageAccessiblePrivateExtensions
{

	public static GtkNotebookPageAccessiblePrivate Dereference(this GtkNotebookPageAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNotebookPageAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkNotebookPageAccessiblePrivateExterns
{
}


public struct GtkNotebookPageAccessiblePrivate
{
}
