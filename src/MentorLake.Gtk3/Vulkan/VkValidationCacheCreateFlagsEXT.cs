namespace MentorLake.Vulkan;

public class VkValidationCacheCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkValidationCacheCreateFlagsEXTExtensions
{

	public static VkValidationCacheCreateFlagsEXT Dereference(this VkValidationCacheCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationCacheCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkValidationCacheCreateFlagsEXTExterns
{
}

public struct VkValidationCacheCreateFlagsEXT
{
}
