namespace MentorLake.Vulkan;

public class VkShaderCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkShaderCreateInfoEXTExtensions
{

	public static VkShaderCreateInfoEXT Dereference(this VkShaderCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkShaderCreateInfoEXTExterns
{
}

public struct VkShaderCreateInfoEXT
{
}
