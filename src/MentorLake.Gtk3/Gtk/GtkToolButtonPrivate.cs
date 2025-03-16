namespace MentorLake.Gtk;

public class GtkToolButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkToolButtonPrivateExtensions
{

	public static GtkToolButtonPrivate Dereference(this GtkToolButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkToolButtonPrivateExterns
{
}

public struct GtkToolButtonPrivate
{
}
