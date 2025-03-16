namespace MentorLake.Vulkan;

public class VkValidationCacheCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkValidationCacheCreateInfoEXTExtensions
{

	public static VkValidationCacheCreateInfoEXT Dereference(this VkValidationCacheCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationCacheCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkValidationCacheCreateInfoEXTExterns
{
}

public struct VkValidationCacheCreateInfoEXT
{
}
