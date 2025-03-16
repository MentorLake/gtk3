namespace MentorLake.Gtk;

public class GtkCellRendererComboPrivateHandle : BaseSafeHandle
{
}


public static class GtkCellRendererComboPrivateExtensions
{

	public static GtkCellRendererComboPrivate Dereference(this GtkCellRendererComboPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererComboPrivate>(x.DangerousGetHandle());
}
internal class GtkCellRendererComboPrivateExterns
{
}

public struct GtkCellRendererComboPrivate
{
}
