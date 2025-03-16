namespace MentorLake.Gtk;

public class GtkLockButtonAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkLockButtonAccessibleClassExtensions
{

	public static GtkLockButtonAccessibleClass Dereference(this GtkLockButtonAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLockButtonAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkLockButtonAccessibleClassExterns
{
}

public struct GtkLockButtonAccessibleClass
{
	public GtkButtonAccessibleClass parent_class;
}
