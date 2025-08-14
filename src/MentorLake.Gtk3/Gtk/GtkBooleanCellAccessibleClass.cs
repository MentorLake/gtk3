namespace MentorLake.Gtk;


public class GtkBooleanCellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkBooleanCellAccessibleClassExtensions
{

	public static GtkBooleanCellAccessibleClass Dereference(this GtkBooleanCellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBooleanCellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkBooleanCellAccessibleClassExterns
{
}


public struct GtkBooleanCellAccessibleClass
{
	
public GtkRendererCellAccessibleClass parent_class;
}
