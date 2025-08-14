namespace MentorLake.Vulkan;


public class VkDeviceFaultVendorBinaryHeaderVersionEXTHandle : BaseSafeHandle
{
}


public static class VkDeviceFaultVendorBinaryHeaderVersionEXTExtensions
{

	public static VkDeviceFaultVendorBinaryHeaderVersionEXT Dereference(this VkDeviceFaultVendorBinaryHeaderVersionEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceFaultVendorBinaryHeaderVersionEXT>(x.DangerousGetHandle());
}
internal class VkDeviceFaultVendorBinaryHeaderVersionEXTExterns
{
}


public struct VkDeviceFaultVendorBinaryHeaderVersionEXT
{
}
