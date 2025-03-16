namespace MentorLake.Gtk;

public class GtkSocketAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkSocketAccessiblePrivateExtensions
{

	public static GtkSocketAccessiblePrivate Dereference(this GtkSocketAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSocketAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkSocketAccessiblePrivateExterns
{
}

public struct GtkSocketAccessiblePrivate
{
}
