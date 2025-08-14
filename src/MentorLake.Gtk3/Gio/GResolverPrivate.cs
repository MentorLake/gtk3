namespace MentorLake.Gio;


public class GResolverPrivateHandle : BaseSafeHandle
{
}


public static class GResolverPrivateExtensions
{

	public static GResolverPrivate Dereference(this GResolverPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GResolverPrivate>(x.DangerousGetHandle());
}
internal class GResolverPrivateExterns
{
}


public struct GResolverPrivate
{
}
