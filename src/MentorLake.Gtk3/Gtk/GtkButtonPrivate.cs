namespace MentorLake.Gtk;

public class GtkButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkButtonPrivateExtensions
{

	public static GtkButtonPrivate Dereference(this GtkButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkButtonPrivateExterns
{
}

public struct GtkButtonPrivate
{
}
