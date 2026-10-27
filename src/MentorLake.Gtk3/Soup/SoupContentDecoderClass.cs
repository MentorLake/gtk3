namespace MentorLake.Soup;


public class SoupContentDecoderClassHandle : BaseSafeHandle
{
}


public static class SoupContentDecoderClassExtensions
{

	public static SoupContentDecoderClass Dereference(this SoupContentDecoderClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupContentDecoderClass>(x.DangerousGetHandle());
}
internal class SoupContentDecoderClassExterns
{
}


public struct SoupContentDecoderClass
{
	
public GObjectClass parent_class;
}
