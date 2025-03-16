namespace MentorLake.Gio;

public class GUnixCredentialsMessagePrivateHandle : BaseSafeHandle
{
}


public static class GUnixCredentialsMessagePrivateExtensions
{

	public static GUnixCredentialsMessagePrivate Dereference(this GUnixCredentialsMessagePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixCredentialsMessagePrivate>(x.DangerousGetHandle());
}
internal class GUnixCredentialsMessagePrivateExterns
{
}

public struct GUnixCredentialsMessagePrivate
{
}
