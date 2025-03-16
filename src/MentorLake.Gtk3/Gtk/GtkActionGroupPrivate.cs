namespace MentorLake.Gtk;

public class GtkActionGroupPrivateHandle : BaseSafeHandle
{
}


public static class GtkActionGroupPrivateExtensions
{

	public static GtkActionGroupPrivate Dereference(this GtkActionGroupPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionGroupPrivate>(x.DangerousGetHandle());
}
internal class GtkActionGroupPrivateExterns
{
}

public struct GtkActionGroupPrivate
{
}
