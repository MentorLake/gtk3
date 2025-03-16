namespace MentorLake.Gtk;

public class GtkRendererCellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkRendererCellAccessiblePrivateExtensions
{

	public static GtkRendererCellAccessiblePrivate Dereference(this GtkRendererCellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRendererCellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkRendererCellAccessiblePrivateExterns
{
}

public struct GtkRendererCellAccessiblePrivate
{
}
