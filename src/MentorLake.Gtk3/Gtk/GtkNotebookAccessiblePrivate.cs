namespace MentorLake.Gtk;

public class GtkNotebookAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkNotebookAccessiblePrivateExtensions
{

	public static GtkNotebookAccessiblePrivate Dereference(this GtkNotebookAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNotebookAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkNotebookAccessiblePrivateExterns
{
}

public struct GtkNotebookAccessiblePrivate
{
}
