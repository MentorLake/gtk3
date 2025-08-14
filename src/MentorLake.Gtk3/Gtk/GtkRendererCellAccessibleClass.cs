namespace MentorLake.Gtk;


public class GtkRendererCellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkRendererCellAccessibleClassExtensions
{

	public static GtkRendererCellAccessibleClass Dereference(this GtkRendererCellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRendererCellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkRendererCellAccessibleClassExterns
{
}


public struct GtkRendererCellAccessibleClass
{
	
public GtkCellAccessibleClass parent_class;
}
