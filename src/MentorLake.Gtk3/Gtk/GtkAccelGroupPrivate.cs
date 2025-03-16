namespace MentorLake.Gtk;

public class GtkAccelGroupPrivateHandle : BaseSafeHandle
{
}


public static class GtkAccelGroupPrivateExtensions
{

	public static GtkAccelGroupPrivate Dereference(this GtkAccelGroupPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelGroupPrivate>(x.DangerousGetHandle());
}
internal class GtkAccelGroupPrivateExterns
{
}

public struct GtkAccelGroupPrivate
{
}
