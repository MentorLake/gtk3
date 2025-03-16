namespace MentorLake.Gtk;

public class GtkStatusbarAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkStatusbarAccessiblePrivateExtensions
{

	public static GtkStatusbarAccessiblePrivate Dereference(this GtkStatusbarAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStatusbarAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkStatusbarAccessiblePrivateExterns
{
}

public struct GtkStatusbarAccessiblePrivate
{
}
