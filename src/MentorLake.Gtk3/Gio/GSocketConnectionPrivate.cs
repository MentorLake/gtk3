namespace MentorLake.Gio;


public class GSocketConnectionPrivateHandle : BaseSafeHandle
{
}


public static class GSocketConnectionPrivateExtensions
{

	public static GSocketConnectionPrivate Dereference(this GSocketConnectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketConnectionPrivate>(x.DangerousGetHandle());
}
internal class GSocketConnectionPrivateExterns
{
}


public struct GSocketConnectionPrivate
{
}
