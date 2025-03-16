namespace MentorLake.Gtk;

public class GtkToggleToolButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkToggleToolButtonPrivateExtensions
{

	public static GtkToggleToolButtonPrivate Dereference(this GtkToggleToolButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleToolButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkToggleToolButtonPrivateExterns
{
}

public struct GtkToggleToolButtonPrivate
{
}
