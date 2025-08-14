namespace MentorLake.Vulkan;


public class VkMultisampledRenderToSingleSampledInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMultisampledRenderToSingleSampledInfoEXTExtensions
{

	public static VkMultisampledRenderToSingleSampledInfoEXT Dereference(this VkMultisampledRenderToSingleSampledInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMultisampledRenderToSingleSampledInfoEXT>(x.DangerousGetHandle());
}
internal class VkMultisampledRenderToSingleSampledInfoEXTExterns
{
}


public struct VkMultisampledRenderToSingleSampledInfoEXT
{
}
