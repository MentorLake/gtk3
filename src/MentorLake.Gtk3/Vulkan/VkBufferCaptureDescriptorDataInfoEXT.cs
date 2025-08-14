namespace MentorLake.Vulkan;


public class VkBufferCaptureDescriptorDataInfoEXTHandle : BaseSafeHandle
{
}


public static class VkBufferCaptureDescriptorDataInfoEXTExtensions
{

	public static VkBufferCaptureDescriptorDataInfoEXT Dereference(this VkBufferCaptureDescriptorDataInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBufferCaptureDescriptorDataInfoEXT>(x.DangerousGetHandle());
}
internal class VkBufferCaptureDescriptorDataInfoEXTExterns
{
}


public struct VkBufferCaptureDescriptorDataInfoEXT
{
}
