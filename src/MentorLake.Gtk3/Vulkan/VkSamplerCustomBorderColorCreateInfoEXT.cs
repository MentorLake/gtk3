namespace MentorLake.Vulkan;


public class VkSamplerCustomBorderColorCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSamplerCustomBorderColorCreateInfoEXTExtensions
{

	public static VkSamplerCustomBorderColorCreateInfoEXT Dereference(this VkSamplerCustomBorderColorCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerCustomBorderColorCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkSamplerCustomBorderColorCreateInfoEXTExterns
{
}


public struct VkSamplerCustomBorderColorCreateInfoEXT
{
}
