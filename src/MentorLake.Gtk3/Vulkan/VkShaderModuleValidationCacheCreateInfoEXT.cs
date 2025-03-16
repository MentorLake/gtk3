namespace MentorLake.Vulkan;

public class VkShaderModuleValidationCacheCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkShaderModuleValidationCacheCreateInfoEXTExtensions
{

	public static VkShaderModuleValidationCacheCreateInfoEXT Dereference(this VkShaderModuleValidationCacheCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderModuleValidationCacheCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkShaderModuleValidationCacheCreateInfoEXTExterns
{
}

public struct VkShaderModuleValidationCacheCreateInfoEXT
{
}
