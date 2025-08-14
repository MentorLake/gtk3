namespace MentorLake.Vulkan;


public class VkImageViewMinLodCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageViewMinLodCreateInfoEXTExtensions
{

	public static VkImageViewMinLodCreateInfoEXT Dereference(this VkImageViewMinLodCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewMinLodCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageViewMinLodCreateInfoEXTExterns
{
}


public struct VkImageViewMinLodCreateInfoEXT
{
}
