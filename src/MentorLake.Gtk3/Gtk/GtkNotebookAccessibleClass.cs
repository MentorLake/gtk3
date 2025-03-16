namespace MentorLake.Gtk;

public class GtkNotebookAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkNotebookAccessibleClassExtensions
{

	public static GtkNotebookAccessibleClass Dereference(this GtkNotebookAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNotebookAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkNotebookAccessibleClassExterns
{
}

public struct GtkNotebookAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
