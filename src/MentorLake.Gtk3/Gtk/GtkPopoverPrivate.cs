namespace MentorLake.Gtk;

public class GtkPopoverPrivateHandle : BaseSafeHandle
{
}


public static class GtkPopoverPrivateExtensions
{

	public static GtkPopoverPrivate Dereference(this GtkPopoverPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPopoverPrivate>(x.DangerousGetHandle());
}
internal class GtkPopoverPrivateExterns
{
}

public struct GtkPopoverPrivate
{
}
