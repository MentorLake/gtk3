namespace MentorLake.Vulkan;


public class VkConditionalRenderingBeginInfoEXTHandle : BaseSafeHandle
{
}


public static class VkConditionalRenderingBeginInfoEXTExtensions
{

	public static VkConditionalRenderingBeginInfoEXT Dereference(this VkConditionalRenderingBeginInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkConditionalRenderingBeginInfoEXT>(x.DangerousGetHandle());
}
internal class VkConditionalRenderingBeginInfoEXTExterns
{
}


public struct VkConditionalRenderingBeginInfoEXT
{
}
