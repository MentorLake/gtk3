namespace MentorLake.Vulkan;

public class VkImageViewSlicedCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkImageViewSlicedCreateInfoEXTExtensions
{

	public static VkImageViewSlicedCreateInfoEXT Dereference(this VkImageViewSlicedCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewSlicedCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkImageViewSlicedCreateInfoEXTExterns
{
}

public struct VkImageViewSlicedCreateInfoEXT
{
}
