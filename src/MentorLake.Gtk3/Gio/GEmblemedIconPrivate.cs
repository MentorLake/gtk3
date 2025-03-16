namespace MentorLake.Gio;

public class GEmblemedIconPrivateHandle : BaseSafeHandle
{
}


public static class GEmblemedIconPrivateExtensions
{

	public static GEmblemedIconPrivate Dereference(this GEmblemedIconPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEmblemedIconPrivate>(x.DangerousGetHandle());
}
internal class GEmblemedIconPrivateExterns
{
}

public struct GEmblemedIconPrivate
{
}
