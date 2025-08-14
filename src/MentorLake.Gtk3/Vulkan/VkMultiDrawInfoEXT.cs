namespace MentorLake.Vulkan;


public class VkMultiDrawInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMultiDrawInfoEXTExtensions
{

	public static VkMultiDrawInfoEXT Dereference(this VkMultiDrawInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMultiDrawInfoEXT>(x.DangerousGetHandle());
}
internal class VkMultiDrawInfoEXTExterns
{
}


public struct VkMultiDrawInfoEXT
{
}
