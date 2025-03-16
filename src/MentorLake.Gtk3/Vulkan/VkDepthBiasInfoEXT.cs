namespace MentorLake.Vulkan;

public class VkDepthBiasInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDepthBiasInfoEXTExtensions
{

	public static VkDepthBiasInfoEXT Dereference(this VkDepthBiasInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDepthBiasInfoEXT>(x.DangerousGetHandle());
}
internal class VkDepthBiasInfoEXTExterns
{
}

public struct VkDepthBiasInfoEXT
{
}
