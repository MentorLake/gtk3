namespace MentorLake.Gtk;

public class GtkEventBoxPrivateHandle : BaseSafeHandle
{
}


public static class GtkEventBoxPrivateExtensions
{

	public static GtkEventBoxPrivate Dereference(this GtkEventBoxPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEventBoxPrivate>(x.DangerousGetHandle());
}
internal class GtkEventBoxPrivateExterns
{
}

public struct GtkEventBoxPrivate
{
}
