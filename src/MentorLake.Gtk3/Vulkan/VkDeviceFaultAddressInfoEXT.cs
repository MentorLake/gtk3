namespace MentorLake.Vulkan;


public class VkDeviceFaultAddressInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultAddressInfoEXTExtensions
{

	public static VkDeviceFaultAddressInfoEXT Dereference(this VkDeviceFaultAddressInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultAddressInfoEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultAddressInfoEXTExterns
{
}


public struct VkDeviceFaultAddressInfoEXT
{
}
