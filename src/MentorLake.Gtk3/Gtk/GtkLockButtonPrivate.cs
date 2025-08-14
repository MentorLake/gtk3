namespace MentorLake.Gtk;


public class GtkLockButtonPrivateHandle : BaseSafeHandle
{
}


public static class GtkLockButtonPrivateExtensions
{

	public static GtkLockButtonPrivate Dereference(this GtkLockButtonPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLockButtonPrivate>(x.DangerousGetHandle());
}
internal class GtkLockButtonPrivateExterns
{
}


public struct GtkLockButtonPrivate
{
}
