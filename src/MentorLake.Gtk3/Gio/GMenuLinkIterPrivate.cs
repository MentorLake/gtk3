namespace MentorLake.Gio;


public class GMenuLinkIterPrivateHandle : BaseSafeHandle
{
}


public static class GMenuLinkIterPrivateExtensions
{

	public static GMenuLinkIterPrivate Dereference(this GMenuLinkIterPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMenuLinkIterPrivate>(x.DangerousGetHandle());
}
internal class GMenuLinkIterPrivateExterns
{
}


public struct GMenuLinkIterPrivate
{
}
