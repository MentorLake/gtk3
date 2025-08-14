namespace MentorLake.Vulkan;


public class VkDepthBiasRepresentationInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDepthBiasRepresentationInfoEXTExtensions
{

	public static VkDepthBiasRepresentationInfoEXT Dereference(this VkDepthBiasRepresentationInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDepthBiasRepresentationInfoEXT>(x.DangerousGetHandle());
}
internal class VkDepthBiasRepresentationInfoEXTExterns
{
}


public struct VkDepthBiasRepresentationInfoEXT
{
}
