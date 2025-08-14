namespace MentorLake.Vulkan;


public class VkValidationCacheHeaderVersionEXTHandle : BaseSafeHandle
{
}


public static class VkValidationCacheHeaderVersionEXTExtensions
{

	public static VkValidationCacheHeaderVersionEXT Dereference(this VkValidationCacheHeaderVersionEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationCacheHeaderVersionEXT>(x.DangerousGetHandle());
}
internal class VkValidationCacheHeaderVersionEXTExterns
{
}


public struct VkValidationCacheHeaderVersionEXT
{
}
