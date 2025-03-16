namespace MentorLake.Gtk;

public class GtkSpinButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkSpinButtonPrivateExtensions
{

	public static GtkSpinButtonPrivate Dereference(this GtkSpinButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkSpinButtonPrivateExterns
{
}

public struct GtkSpinButtonPrivate
{
}
