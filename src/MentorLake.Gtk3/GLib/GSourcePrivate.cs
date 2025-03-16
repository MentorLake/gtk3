namespace MentorLake.GLib;

public class GSourcePrivateHandle : BaseSafeHandle
{
}


public static class GSourcePrivateExtensions
{

	public static GSourcePrivate Dereference(this GSourcePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSourcePrivate>(x.DangerousGetHandle());
}
internal class GSourcePrivateExterns
{
}

public struct GSourcePrivate
{
}
