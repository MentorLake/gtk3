namespace MentorLake.Vulkan;


public class VkDeviceFaultVendorInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultVendorInfoEXTExtensions
{

	public static VkDeviceFaultVendorInfoEXT Dereference(this VkDeviceFaultVendorInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultVendorInfoEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultVendorInfoEXTExterns
{
}


public struct VkDeviceFaultVendorInfoEXT
{
}
