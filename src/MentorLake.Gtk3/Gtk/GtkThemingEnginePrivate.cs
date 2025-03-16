namespace MentorLake.Gtk;

public class GtkThemingEnginePrivateHandle : BaseSafeHandle
{
}


public static class GtkThemingEnginePrivateExtensions
{

	public static GtkThemingEnginePrivate Dereference(this GtkThemingEnginePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkThemingEnginePrivate>(x.DangerousGetHandle());
}
internal class GtkThemingEnginePrivateExterns
{
}

public struct GtkThemingEnginePrivate
{
}
