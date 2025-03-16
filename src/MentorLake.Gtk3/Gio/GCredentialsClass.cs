namespace MentorLake.Gio;

public class GCredentialsClassHandle : BaseSafeHandle
{
}


public static class GCredentialsClassExtensions
{

	public static GCredentialsClass Dereference(this GCredentialsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCredentialsClass>(x.DangerousGetHandle());
}
internal class GCredentialsClassExterns
{
}

public struct GCredentialsClass
{
}
