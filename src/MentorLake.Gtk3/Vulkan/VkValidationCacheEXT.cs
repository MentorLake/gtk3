namespace MentorLake.Vulkan;

public class VkValidationCacheEXTHandle : BaseSafeHandle
{
}


public static class VkValidationCacheEXTExtensions
{

	public static VkValidationCacheEXT Dereference(this VkValidationCacheEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationCacheEXT>(x.DangerousGetHandle());
}
internal class VkValidationCacheEXTExterns
{
}

public struct VkValidationCacheEXT
{
}
