namespace MentorLake.Gio;


public class GTlsConnectionPrivateHandle : BaseSafeHandle
{
}


public static class GTlsConnectionPrivateExtensions
{

	public static GTlsConnectionPrivate Dereference(this GTlsConnectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsConnectionPrivate>(x.DangerousGetHandle());
}
internal class GTlsConnectionPrivateExterns
{
}


public struct GTlsConnectionPrivate
{
}
