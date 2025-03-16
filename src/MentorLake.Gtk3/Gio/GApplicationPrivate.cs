namespace MentorLake.Gio;

public class GApplicationPrivateHandle : BaseSafeHandle
{
}


public static class GApplicationPrivateExtensions
{

	public static GApplicationPrivate Dereference(this GApplicationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GApplicationPrivate>(x.DangerousGetHandle());
}
internal class GApplicationPrivateExterns
{
}

public struct GApplicationPrivate
{
}
