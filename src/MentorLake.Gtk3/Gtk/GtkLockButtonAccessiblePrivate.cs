namespace MentorLake.Gtk;


public class GtkLockButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkLockButtonAccessiblePrivateExtensions
{

	public static GtkLockButtonAccessiblePrivate Dereference(this GtkLockButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLockButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkLockButtonAccessiblePrivateExterns
{
}


public struct GtkLockButtonAccessiblePrivate
{
}
