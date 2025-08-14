namespace MentorLake.Vulkan;


public class VkDeviceFaultAddressTypeEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultAddressTypeEXTExtensions
{

	public static VkDeviceFaultAddressTypeEXT Dereference(this VkDeviceFaultAddressTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultAddressTypeEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultAddressTypeEXTExterns
{
}


public struct VkDeviceFaultAddressTypeEXT
{
}
