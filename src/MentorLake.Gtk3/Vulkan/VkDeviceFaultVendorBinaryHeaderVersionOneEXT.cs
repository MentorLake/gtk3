namespace MentorLake.Vulkan;


public class VkDeviceFaultVendorBinaryHeaderVersionOneEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultVendorBinaryHeaderVersionOneEXTExtensions
{

	public static VkDeviceFaultVendorBinaryHeaderVersionOneEXT Dereference(this VkDeviceFaultVendorBinaryHeaderVersionOneEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultVendorBinaryHeaderVersionOneEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultVendorBinaryHeaderVersionOneEXTExterns
{
}


public struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
}
