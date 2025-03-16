namespace MentorLake.Vulkan;

public class VkSampleLocationsInfoEXTHandle : BaseSafeHandle
{
}


public static class VkSampleLocationsInfoEXTExtensions
{

	public static VkSampleLocationsInfoEXT Dereference(this VkSampleLocationsInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSampleLocationsInfoEXT>(x.DangerousGetHandle());
}
internal class VkSampleLocationsInfoEXTExterns
{
}

public struct VkSampleLocationsInfoEXT
{
}
