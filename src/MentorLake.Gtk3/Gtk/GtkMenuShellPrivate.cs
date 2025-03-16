namespace MentorLake.Gtk;

public class GtkMenuShellPrivateHandle : BaseSafeHandle
{
}


public static class GtkMenuShellPrivateExtensions
{

	public static GtkMenuShellPrivate Dereference(this GtkMenuShellPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuShellPrivate>(x.DangerousGetHandle());
}
internal class GtkMenuShellPrivateExterns
{
}

public struct GtkMenuShellPrivate
{
}
