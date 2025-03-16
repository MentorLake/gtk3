namespace MentorLake.Gio;

public class GSimpleProxyResolverPrivateHandle : BaseSafeHandle
{
}


public static class GSimpleProxyResolverPrivateExtensions
{

	public static GSimpleProxyResolverPrivate Dereference(this GSimpleProxyResolverPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSimpleProxyResolverPrivate>(x.DangerousGetHandle());
}
internal class GSimpleProxyResolverPrivateExterns
{
}

public struct GSimpleProxyResolverPrivate
{
}
