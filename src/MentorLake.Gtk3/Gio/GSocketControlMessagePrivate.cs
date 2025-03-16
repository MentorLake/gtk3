namespace MentorLake.Gio;

public class GSocketControlMessagePrivateHandle : BaseSafeHandle
{
}


public static class GSocketControlMessagePrivateExtensions
{

	public static GSocketControlMessagePrivate Dereference(this GSocketControlMessagePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketControlMessagePrivate>(x.DangerousGetHandle());
}
internal class GSocketControlMessagePrivateExterns
{
}

public struct GSocketControlMessagePrivate
{
}
