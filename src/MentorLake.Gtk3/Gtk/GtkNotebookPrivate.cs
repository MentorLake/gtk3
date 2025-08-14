namespace MentorLake.Gtk;


public class GtkNotebookPrivateHandle : BaseSafeHandle
{
}


public static class GtkNotebookPrivateExtensions
{

	public static GtkNotebookPrivate Dereference(this GtkNotebookPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNotebookPrivate>(x.DangerousGetHandle());
}
internal class GtkNotebookPrivateExterns
{
}


public struct GtkNotebookPrivate
{
}
