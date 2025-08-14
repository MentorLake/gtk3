namespace MentorLake.Gtk;


public class GtkNotebookPageAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkNotebookPageAccessibleClassExtensions
{

	public static GtkNotebookPageAccessibleClass Dereference(this GtkNotebookPageAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNotebookPageAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkNotebookPageAccessibleClassExterns
{
}


public struct GtkNotebookPageAccessibleClass
{
	
public AtkObjectClass parent_class;
}
