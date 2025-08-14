namespace MentorLake.Gio;


public class GTcpWrapperConnectionPrivateHandle : BaseSafeHandle
{
}


public static class GTcpWrapperConnectionPrivateExtensions
{

	public static GTcpWrapperConnectionPrivate Dereference(this GTcpWrapperConnectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTcpWrapperConnectionPrivate>(x.DangerousGetHandle());
}
internal class GTcpWrapperConnectionPrivateExterns
{
}


public struct GTcpWrapperConnectionPrivate
{
}
