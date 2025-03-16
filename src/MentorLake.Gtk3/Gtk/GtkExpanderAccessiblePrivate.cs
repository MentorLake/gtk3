namespace MentorLake.Gtk;

public class GtkExpanderAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkExpanderAccessiblePrivateExtensions
{

	public static GtkExpanderAccessiblePrivate Dereference(this GtkExpanderAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkExpanderAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkExpanderAccessiblePrivateExterns
{
}

public struct GtkExpanderAccessiblePrivate
{
}
