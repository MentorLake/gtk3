namespace MentorLake.Gtk;

public class GtkButtonAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkButtonAccessiblePrivateExtensions
{

	public static GtkButtonAccessiblePrivate Dereference(this GtkButtonAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkButtonAccessiblePrivateExterns
{
}

public struct GtkButtonAccessiblePrivate
{
}
