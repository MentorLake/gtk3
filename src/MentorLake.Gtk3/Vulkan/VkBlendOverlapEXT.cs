namespace MentorLake.Vulkan;


public class VkBlendOverlapEXTHandle : BaseSafeHandle
{
}


public static class VkBlendOverlapEXTExtensions
{

	public static VkBlendOverlapEXT Dereference(this VkBlendOverlapEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlendOverlapEXT>(x.DangerousGetHandle());
}
internal class VkBlendOverlapEXTExterns
{
}


public struct VkBlendOverlapEXT
{
}
