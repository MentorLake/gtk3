namespace MentorLake.Vulkan;


public class VkRenderPassSampleLocationsBeginInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassSampleLocationsBeginInfoEXTExtensions
{

	public static VkRenderPassSampleLocationsBeginInfoEXT Dereference(this VkRenderPassSampleLocationsBeginInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassSampleLocationsBeginInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassSampleLocationsBeginInfoEXTExterns
{
}


public struct VkRenderPassSampleLocationsBeginInfoEXT
{
}
