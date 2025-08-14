namespace MentorLake.Gio;


public class GMenuAttributeIterPrivateHandle : BaseSafeHandle
{
}


public static class GMenuAttributeIterPrivateExtensions
{

	public static GMenuAttributeIterPrivate Dereference(this GMenuAttributeIterPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMenuAttributeIterPrivate>(x.DangerousGetHandle());
}
internal class GMenuAttributeIterPrivateExterns
{
}


public struct GMenuAttributeIterPrivate
{
}
