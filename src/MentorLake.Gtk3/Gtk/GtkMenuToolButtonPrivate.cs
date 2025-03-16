namespace MentorLake.Gtk;

public class GtkMenuToolButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuToolButtonPrivateExtensions
{

	public static GtkMenuToolButtonPrivate Dereference(this GtkMenuToolButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuToolButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkMenuToolButtonPrivateExterns
{
}

public struct GtkMenuToolButtonPrivate
{
}
