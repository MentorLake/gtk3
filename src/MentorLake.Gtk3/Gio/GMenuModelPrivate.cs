namespace MentorLake.Gio;

public class GMenuModelPrivateHandle : BaseSafeHandle
{
}


public static class GMenuModelPrivateExtensions
{

	public static GMenuModelPrivate Dereference(this GMenuModelPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMenuModelPrivate>(x.DangerousGetHandle());
}
internal class GMenuModelPrivateExterns
{
}

public struct GMenuModelPrivate
{
}
