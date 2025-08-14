namespace MentorLake.Vulkan;


public class VkConditionalRenderingFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkConditionalRenderingFlagBitsEXTExtensions
{

	public static VkConditionalRenderingFlagBitsEXT Dereference(this VkConditionalRenderingFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkConditionalRenderingFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkConditionalRenderingFlagBitsEXTExterns
{
}


public struct VkConditionalRenderingFlagBitsEXT
{
}
