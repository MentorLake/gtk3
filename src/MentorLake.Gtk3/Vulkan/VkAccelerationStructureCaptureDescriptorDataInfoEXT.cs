namespace MentorLake.Vulkan;


public class VkAccelerationStructureCaptureDescriptorDataInfoEXTHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureCaptureDescriptorDataInfoEXTExtensions
{

	public static VkAccelerationStructureCaptureDescriptorDataInfoEXT Dereference(this VkAccelerationStructureCaptureDescriptorDataInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureCaptureDescriptorDataInfoEXT>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureCaptureDescriptorDataInfoEXTExterns
{
}


public struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
{
}
