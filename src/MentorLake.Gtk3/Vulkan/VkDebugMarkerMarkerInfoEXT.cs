namespace MentorLake.Vulkan;


public class VkDebugMarkerMarkerInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDebugMarkerMarkerInfoEXTExtensions
{

	public static VkDebugMarkerMarkerInfoEXT Dereference(this VkDebugMarkerMarkerInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDebugMarkerMarkerInfoEXT>(x.DangerousGetHandle());
}
internal class VkDebugMarkerMarkerInfoEXTExterns
{
}


public struct VkDebugMarkerMarkerInfoEXT
{
}
