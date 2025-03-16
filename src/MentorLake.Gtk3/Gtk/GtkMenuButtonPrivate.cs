namespace MentorLake.Gtk;

public class GtkMenuButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuButtonPrivateExtensions
{

	public static GtkMenuButtonPrivate Dereference(this GtkMenuButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkMenuButtonPrivateExterns
{
}

public struct GtkMenuButtonPrivate
{
}
