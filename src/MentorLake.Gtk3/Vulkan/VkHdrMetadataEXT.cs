namespace MentorLake.Vulkan;


public class VkHdrMetadataEXTHandle : BaseSafeHandle
{
}


public static class VkHdrMetadataEXTExtensions
{

	public static VkHdrMetadataEXT Dereference(this VkHdrMetadataEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHdrMetadataEXT>(x.DangerousGetHandle());
}
internal class VkHdrMetadataEXTExterns
{
}


public struct VkHdrMetadataEXT
{
}
