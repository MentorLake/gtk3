namespace MentorLake.Gtk;

public class GtkColorButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkColorButtonPrivateExtensions
{

	public static GtkColorButtonPrivate Dereference(this GtkColorButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkColorButtonPrivateExterns
{
}

public struct GtkColorButtonPrivate
{
}
