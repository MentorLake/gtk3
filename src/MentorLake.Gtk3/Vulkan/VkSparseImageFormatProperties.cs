namespace MentorLake.Vulkan;


public class VkSparseImageFormatPropertiesHandle : BaseSafeHandle
{
}


public static class VkSparseImageFormatPropertiesExtensions
{

	public static VkSparseImageFormatProperties Dereference(this VkSparseImageFormatPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSparseImageFormatProperties>(x.DangerousGetHandle());
}
internal class VkSparseImageFormatPropertiesExterns
{
}


public struct VkSparseImageFormatProperties
{
}
