namespace MentorLake.Vulkan;

public class VkPipelineSampleLocationsStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineSampleLocationsStateCreateInfoEXTExtensions
{

	public static VkPipelineSampleLocationsStateCreateInfoEXT Dereference(this VkPipelineSampleLocationsStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineSampleLocationsStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineSampleLocationsStateCreateInfoEXTExterns
{
}

public struct VkPipelineSampleLocationsStateCreateInfoEXT
{
}
