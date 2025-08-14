namespace MentorLake.Vulkan;


public class VkSubpassSampleLocationsEXTHandle : BaseSafeHandle
{
}


public static class VkSubpassSampleLocationsEXTExtensions
{

	public static VkSubpassSampleLocationsEXT Dereference(this VkSubpassSampleLocationsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassSampleLocationsEXT>(x.DangerousGetHandle());
}
internal class VkSubpassSampleLocationsEXTExterns
{
}


public struct VkSubpassSampleLocationsEXT
{
}
