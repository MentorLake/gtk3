namespace MentorLake.Vulkan;


public class VkMicromapEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapEXTExtensions
{

	public static VkMicromapEXT Dereference(this VkMicromapEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapEXT>(x.DangerousGetHandle());
}
internal class VkMicromapEXTExterns
{
}


public struct VkMicromapEXT
{
}
