namespace MentorLake.Vulkan;


public class VkFlags64Handle : BaseSafeHandle
{
}


public static class VkFlags64Extensions
{

	public static VkFlags64 Dereference(this VkFlags64Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFlags64>(x.DangerousGetHandle());
}
internal class VkFlags64Externs
{
}


public struct VkFlags64
{
}
