namespace MentorLake.Gio;

public class GIOStreamPrivateHandle : BaseSafeHandle
{
}


public static class GIOStreamPrivateExtensions
{

	public static GIOStreamPrivate Dereference(this GIOStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOStreamPrivate>(x.DangerousGetHandle());
}
internal class GIOStreamPrivateExterns
{
}

public struct GIOStreamPrivate
{
}
