namespace MentorLake.Gtk;


public class GtkFrameAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkFrameAccessiblePrivateExtensions
{

	public static GtkFrameAccessiblePrivate Dereference(this GtkFrameAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFrameAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkFrameAccessiblePrivateExterns
{
}


public struct GtkFrameAccessiblePrivate
{
}
