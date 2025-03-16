namespace MentorLake.Vulkan;

public class VkConditionalRenderingFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkConditionalRenderingFlagsEXTExtensions
{

	public static VkConditionalRenderingFlagsEXT Dereference(this VkConditionalRenderingFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkConditionalRenderingFlagsEXT>(x.DangerousGetHandle());
}
internal class VkConditionalRenderingFlagsEXTExterns
{
}

public struct VkConditionalRenderingFlagsEXT
{
}
