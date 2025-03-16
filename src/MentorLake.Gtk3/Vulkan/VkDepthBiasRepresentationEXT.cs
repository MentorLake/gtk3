namespace MentorLake.Vulkan;

public class VkDepthBiasRepresentationEXTHandle : BaseSafeHandle
{
}


public static class VkDepthBiasRepresentationEXTExtensions
{

	public static VkDepthBiasRepresentationEXT Dereference(this VkDepthBiasRepresentationEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDepthBiasRepresentationEXT>(x.DangerousGetHandle());
}
internal class VkDepthBiasRepresentationEXTExterns
{
}

public struct VkDepthBiasRepresentationEXT
{
}
