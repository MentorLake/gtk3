namespace MentorLake.Gtk;


public class GtkContainerAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkContainerAccessiblePrivateExtensions
{

	public static GtkContainerAccessiblePrivate Dereference(this GtkContainerAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkContainerAccessiblePrivateExterns
{
}


public struct GtkContainerAccessiblePrivate
{
}
