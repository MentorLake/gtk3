namespace MentorLake.Vulkan;


public class VkVendorIdHandle : BaseSafeHandle
{
}


public static class VkVendorIdExtensions
{

	public static VkVendorId Dereference(this VkVendorIdHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVendorId>(x.DangerousGetHandle());
}
internal class VkVendorIdExterns
{
}


public struct VkVendorId
{
}
