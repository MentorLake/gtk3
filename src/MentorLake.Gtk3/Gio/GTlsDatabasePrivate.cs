namespace MentorLake.Gio;

public class GTlsDatabasePrivateHandle : BaseSafeHandle
{
}


public static class GTlsDatabasePrivateExtensions
{

	public static GTlsDatabasePrivate Dereference(this GTlsDatabasePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsDatabasePrivate>(x.DangerousGetHandle());
}
internal class GTlsDatabasePrivateExterns
{
}

public struct GTlsDatabasePrivate
{
}
