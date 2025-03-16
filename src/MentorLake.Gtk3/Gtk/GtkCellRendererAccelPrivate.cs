namespace MentorLake.Gtk;

public class GtkCellRendererAccelPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererAccelPrivateExtensions
{

	public static GtkCellRendererAccelPrivate Dereference(this GtkCellRendererAccelPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererAccelPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererAccelPrivateExterns
{
}

public struct GtkCellRendererAccelPrivate
{
}
