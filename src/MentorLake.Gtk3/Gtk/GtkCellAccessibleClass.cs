namespace MentorLake.Gtk;


public class GtkCellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkCellAccessibleClassExtensions
{

	public static GtkCellAccessibleClass Dereference(this GtkCellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkCellAccessibleClassExterns
{
}


public struct GtkCellAccessibleClass
{
	
public GtkAccessibleClass parent_class;
	
public IntPtr update_cache;
}
