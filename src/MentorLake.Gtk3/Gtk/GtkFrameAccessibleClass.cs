namespace MentorLake.Gtk;

public class GtkFrameAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkFrameAccessibleClassExtensions
{

	public static GtkFrameAccessibleClass Dereference(this GtkFrameAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFrameAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkFrameAccessibleClassExterns
{
}

public struct GtkFrameAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
