namespace MentorLake.Gtk;


public class GtkContainerCellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkContainerCellAccessibleClassExtensions
{

	public static GtkContainerCellAccessibleClass Dereference(this GtkContainerCellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerCellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkContainerCellAccessibleClassExterns
{
}


public struct GtkContainerCellAccessibleClass
{
	
public GtkCellAccessibleClass parent_class;
}
