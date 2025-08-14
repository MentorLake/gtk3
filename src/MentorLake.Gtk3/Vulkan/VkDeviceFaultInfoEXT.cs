namespace MentorLake.Vulkan;


public class VkDeviceFaultInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultInfoEXTExtensions
{

	public static VkDeviceFaultInfoEXT Dereference(this VkDeviceFaultInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultInfoEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultInfoEXTExterns
{
}


public struct VkDeviceFaultInfoEXT
{
}
