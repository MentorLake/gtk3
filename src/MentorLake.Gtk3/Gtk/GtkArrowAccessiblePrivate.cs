namespace MentorLake.Gtk;

public class GtkArrowAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkArrowAccessiblePrivateExtensions
{

	public static GtkArrowAccessiblePrivate Dereference(this GtkArrowAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkArrowAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkArrowAccessiblePrivateExterns
{
}

public struct GtkArrowAccessiblePrivate
{
}
