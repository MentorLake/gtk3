namespace MentorLake.Gtk;

public class GtkTextCellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkTextCellAccessibleClassExtensions
{

	public static GtkTextCellAccessibleClass Dereference(this GtkTextCellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextCellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkTextCellAccessibleClassExterns
{
}

public struct GtkTextCellAccessibleClass
{
	public GtkRendererCellAccessibleClass parent_class;
}
