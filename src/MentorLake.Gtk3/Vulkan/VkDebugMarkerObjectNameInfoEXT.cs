namespace MentorLake.Vulkan;

public class VkDebugMarkerObjectNameInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugMarkerObjectNameInfoEXTExtensions
{

	public static VkDebugMarkerObjectNameInfoEXT Dereference(this VkDebugMarkerObjectNameInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugMarkerObjectNameInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugMarkerObjectNameInfoEXTExterns
{
}

public struct VkDebugMarkerObjectNameInfoEXT
{
}
