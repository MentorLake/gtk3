namespace MentorLake.Vulkan;

public class VkDebugMarkerObjectTagInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugMarkerObjectTagInfoEXTExtensions
{

	public static VkDebugMarkerObjectTagInfoEXT Dereference(this VkDebugMarkerObjectTagInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugMarkerObjectTagInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugMarkerObjectTagInfoEXTExterns
{
}

public struct VkDebugMarkerObjectTagInfoEXT
{
}
