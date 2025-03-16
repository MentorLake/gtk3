namespace MentorLake.Gtk;

public class GtkRangeAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkRangeAccessiblePrivateExtensions
{

	public static GtkRangeAccessiblePrivate Dereference(this GtkRangeAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRangeAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkRangeAccessiblePrivateExterns
{
}

public struct GtkRangeAccessiblePrivate
{
}
