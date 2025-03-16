namespace MentorLake.Gio;

public class GTlsPasswordPrivateHandle : BaseSafeHandle
{
}


public static class GTlsPasswordPrivateExtensions
{

	public static GTlsPasswordPrivate Dereference(this GTlsPasswordPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsPasswordPrivate>(x.DangerousGetHandle());
}
internal class GTlsPasswordPrivateExterns
{
}

public struct GTlsPasswordPrivate
{
}
