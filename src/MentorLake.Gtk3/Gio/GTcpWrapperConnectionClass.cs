namespace MentorLake.Gio;


public class GTcpWrapperConnectionClassHandle : BaseSafeHandle
{
}


public static class GTcpWrapperConnectionClassExtensions
{

	public static GTcpWrapperConnectionClass Dereference(this GTcpWrapperConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTcpWrapperConnectionClass>(x.DangerousGetHandle());
}
internal class GTcpWrapperConnectionClassExterns
{
}


public struct GTcpWrapperConnectionClass
{
	
public GTcpConnectionClass parent_class;
}
