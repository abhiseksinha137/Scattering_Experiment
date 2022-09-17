using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using SpinnakerNET;
using SpinnakerNET.GenApi;
using System.Drawing;

namespace Scattering_Experiment
{
    class spinView
    {
        public Bitmap currentImage = null;
        private IManagedCamera managedCamera;
        public int cameraNum = 0;

#if DEBUG
        // Disables heartbeat on GEV cameras so debugging does not incur timeout errors
        static int DisableHeartbeat(IManagedCamera cam, INodeMap nodeMap, INodeMap nodeMapTLDevice)
        {
            ////Console.WriteLine("Checking device type to see if we need to disable the camera's heartbeat...\n\n");

            //
            // Write to boolean node controlling the camera's heartbeat
            //
            // *** NOTES ***
            // This applies only to GEV cameras and only applies when in DEBUG mode.
            // GEV cameras have a heartbeat built in, but when debugging applications the
            // camera may time out due to its heartbeat. Disabling the heartbeat prevents
            // this timeout from occurring, enabling us to continue with any necessary debugging.
            // This procedure does not affect other types of cameras and will prematurely exit
            // if it determines the device in question is not a GEV camera.
            //
            // *** LATER ***
            // Since we only disable the heartbeat on GEV cameras during debug mode, it is better
            // to power cycle the camera after debugging. A power cycle will reset the camera
            // to its default settings.
            //
            IEnum iDeviceType = nodeMapTLDevice.GetNode<IEnum>("DeviceType");
            IEnumEntry iDeviceTypeGEV = iDeviceType.GetEntryByName("GigEVision");
            // We first need to confirm that we're working with a GEV camera
            if (iDeviceType != null && iDeviceType.IsReadable)
            {
                if (iDeviceType.Value == iDeviceTypeGEV.Value)
                {
                    ////Console.WriteLine(
                    //"Working with a GigE camera. Attempting to disable heartbeat before continuing...\n\n");
                    IBool iGEVHeartbeatDisable = nodeMap.GetNode<IBool>("GevGVCPHeartbeatDisable");
                    if (iGEVHeartbeatDisable == null || !iGEVHeartbeatDisable.IsWritable)
                    {
                        //Console.WriteLine(
                        //"Unable to disable heartbeat on camera. Continuing with execution as this may be non-fatal...");
                    }
                    else
                    {
                        iGEVHeartbeatDisable.Value = true;
                        //Console.WriteLine("WARNING: Heartbeat on GigE camera disabled for the rest of Debug Mode.");
                        //Console.WriteLine(
                        //"         Power cycle camera when done debugging to re-enable the heartbeat...");
                    }
                }
                else
                {
                    //Console.WriteLine("Camera does not use GigE interface. Resuming normal execution...\n\n");
                }
            }
            else
            {
                //Console.WriteLine("Unable to access TL device nodemap. Aborting...");
                return -1;
            }

            return 0;
        }
#endif
        // This function acquires and saves 10 images from a device.
        private int AcquireImages(IManagedCamera cam, INodeMap nodeMap, INodeMap nodeMapTLDevice, string saveName)
        {
            int result = 0;

            ////Console.WriteLine("\n*** IMAGE ACQUISITION ***\n");

            try
            {
                //
                // Set acquisition mode to continuous
                //
                // *** NOTES ***
                // Because the example acquires and saves 10 images, setting
                // acquisition mode to continuous lets the example finish. If
                // set to single frame or multiframe (at a lower number of
                // images), the example would just hang. This is because the
                // example has been written to acquire 10 images while the
                // camera would have been programmed to retrieve less than that.
                //
                // Setting the value of an enumeration node is slightly more
                // complicated than other node types. Two nodes are required:
                // first, the enumeration node is retrieved from the nodemap and
                // second, the entry node is retrieved from the enumeration node.
                // The symbolic of the entry node is then set as the new value
                // of the enumeration node.
                //
                // Notice that both the enumeration and entry nodes are checked
                // for availability and readability/writability. Enumeration
                // nodes are generally readable and writable whereas entry
                // nodes are only ever readable.
                //
                // Retrieve enumeration node from nodemap
                IEnum iAcquisitionMode = nodeMap.GetNode<IEnum>("AcquisitionMode");
                if (iAcquisitionMode == null || !iAcquisitionMode.IsWritable)
                {
                    //Console.WriteLine("Unable to set acquisition mode to continuous (node retrieval). Aborting...\n");
                    return -1;
                }

                // Retrieve entry node from enumeration node
                IEnumEntry iAcquisitionModeContinuous = iAcquisitionMode.GetEntryByName("Continuous");
                if (iAcquisitionModeContinuous == null || !iAcquisitionMode.IsReadable)
                {
                    //Console.WriteLine(
                    //"Unable to set acquisition mode to continuous (enum entry retrieval). Aborting...\n");
                    return -1;
                }

                // Set symbolic from entry node as new value for enumeration node
                iAcquisitionMode.Value = iAcquisitionModeContinuous.Symbolic;

                //Console.WriteLine("Acquisition mode set to continuous...");

#if DEBUG
                //Console.WriteLine("\n\n*** DEBUG ***\n\n");
                // If using a GEV camera and debugging, should disable heartbeat first to prevent further issues

                if (DisableHeartbeat(cam, nodeMap, nodeMapTLDevice) != 0)
                {
                    return -1;
                }

                //Console.WriteLine("\n\n*** END OF DEBUG ***\n\n");
#endif
                //
                // Begin acquiring images
                //
                // *** NOTES ***
                // What happens when the camera begins acquiring images depends
                // on which acquisition mode has been set. Single frame captures
                // only a single image, multi frame catures a set number of
                // images, and continuous captures a continuous stream of images.
                // Because the example calls for the retrieval of 10 images,
                // continuous mode has been set for the example.
                //
                // *** LATER ***
                // Image acquisition must be ended when no more images are needed.
                //
                cam.BeginAcquisition();

                //Console.WriteLine("Acquiring images...");

                //
                // Retrieve device serial number for filename
                //
                // *** NOTES ***
                // The device serial number is retrieved in order to keep
                // different cameras from overwriting each other's images.
                // Grabbing image IDs and frame IDs make good alternatives for
                // this purpose.
                //
                String deviceSerialNumber = "";

                IString iDeviceSerialNumber = nodeMapTLDevice.GetNode<IString>("DeviceSerialNumber");
                if (iDeviceSerialNumber != null && iDeviceSerialNumber.IsReadable)
                {
                    deviceSerialNumber = iDeviceSerialNumber.Value;

                    //Console.WriteLine("Device serial number retrieved as {0}...", deviceSerialNumber);
                }
                //Console.WriteLine();

                // Retrieve, convert, and save images
                const int NumImages = 1;

                //
                // Create ImageProcessor instance for post processing images
                //
                IManagedImageProcessor processor = new ManagedImageProcessor();

                //
                // Set default image processor color processing method
                //
                // *** NOTES ***
                // By default, if no specific color processing algorithm is set, the image
                // processor will default to NEAREST_NEIGHBOR method.
                //
                processor.SetColorProcessing(ColorProcessingAlgorithm.HQ_LINEAR);

                for (int imageCnt = 0; imageCnt < NumImages; imageCnt++)
                {
                    try
                    {
                        //
                        // Retrieve next received image
                        //
                        // *** NOTES ***
                        // Capturing an image houses images on the camera buffer.
                        // Trying to capture an image that does not exist will
                        // hang the camera.
                        //
                        // Using-statements help ensure that images are released.
                        // If too many images remain unreleased, the buffer will
                        // fill, causing the camera to hang. Images can also be
                        // released manually by calling Release().
                        //
                        using (IManagedImage rawImage = cam.GetNextImage(1000))
                        {
                            //
                            // Ensure image completion
                            //
                            // *** NOTES ***
                            // Images can easily be checked for completion. This
                            // should be done whenever a complete image is
                            // expected or required. Alternatively, check image
                            // status for a little more insight into what
                            // happened.
                            //
                            if (rawImage.IsIncomplete)
                            {
                                //Console.WriteLine("Image incomplete with image status {0}...", rawImage.ImageStatus);
                            }
                            else
                            {
                                //
                                // Print image information; width and height
                                // recorded in pixels
                                //
                                // *** NOTES ***
                                // Images have quite a bit of available metadata
                                // including CRC, image status, and offset
                                // values to name a few.
                                //
                                uint width = rawImage.Width;

                                uint height = rawImage.Height;

                                //Console.WriteLine(
                                //"Grabbed image {0}, width = {1}, height = {2}", imageCnt, width, height);

                                //
                                // Convert image to mono 8
                                //
                                // *** NOTES ***
                                // Images can be converted between pixel formats
                                // by using the appropriate enumeration value.
                                // Unlike the original image, the converted one
                                // does not need to be released as it does not
                                // affect the camera buffer.
                                //
                                // Using statements are a great way to ensure code
                                // stays clean and avoids memory leaks.
                                // leaks.
                                //
                                using (
                                    IManagedImage convertedImage = processor.Convert(rawImage, PixelFormatEnums.Mono8))
                                {
                                    // Create a unique filename
                                    String filename = "E:/VB.NEt/Scattering_Experiment/Acquisition_CSharp/Images/Acquisition-CSharp-";
                                    if (deviceSerialNumber != "")
                                    {
                                        filename = filename + deviceSerialNumber + "-";
                                    }
                                    filename = filename + imageCnt + ".jpg";

                                    //
                                    // Save image
                                    //
                                    // *** NOTES ***
                                    // The standard practice of the examples is
                                    // to use device serial numbers to keep
                                    // images of one device from overwriting
                                    // those of another.
                                    //
                                    convertedImage.Save(saveName);
                                    currentImage = new Bitmap(convertedImage.bitmap);


                                    //Console.WriteLine("Image saved at {0}\n", filename);
                                }
                            }
                        }
                    }
                    catch (SpinnakerException)
                    {
                        //Console.WriteLine("Error: {0}", ex.Message);
                        result = -1;
                    }
                }

                //
                // End acquisition
                //
                // *** NOTES ***
                // Ending acquisition appropriately helps ensure that devices
                // clean up properly and do not need to be power-cycled to
                // maintain integrity.
                //
                cam.EndAcquisition();
            }
            catch (SpinnakerException)
            {
                //Console.WriteLine("Error: {0}", ex.Message);
                result = -1;
            }

            return result;
        }

        // This function prints the device information of the camera from the
        // transport layer; please see NodeMapInfo_CSharp example for more
        // in-depth comments on printing device information from the nodemap.


        // This function acts as the body of the example; please see
        // NodeMapInfo_CSharp example for more in-depth comments on setting up
        // cameras.
        public int RunSingleCamera(string savePath)
        {
            IManagedCamera cam = managedCamera;
            int result = 0;

            try
            {
                // Retrieve TL device nodemap and print device information
                INodeMap nodeMapTLDevice = cam.GetTLDeviceNodeMap();



                // Initialize camera
                cam.Init();

                // Retrieve GenICam nodemap
                INodeMap nodeMap = cam.GetNodeMap();

                // Acquire images
                result = result | AcquireImages(cam, nodeMap, nodeMapTLDevice, savePath);

                // Deinitialize camera
                cam.DeInit();
                result = 1;
            }
            catch (SpinnakerException)
            {
                //Console.WriteLine("Error: {0}", ex.Message);
                result = -1;
            }

            return result;
        }

        // Constructor
        public spinView()
        {
            int result = 0;
            // Retrieve singleton reference to system object
            ManagedSystem system = new ManagedSystem();
            // Print out current library version
            LibraryVersion spinVersion = system.GetLibraryVersion();
            //Console.WriteLine(
            //"Spinnaker library version: {0}.{1}.{2}.{3}\n\n",
            //spinVersion.major,
            //spinVersion.minor,
            //spinVersion.type,
            //spinVersion.build);

            // Retrieve list of cameras from the system
            ManagedCameraList camList = system.GetCameras();

            //Console.WriteLine("Number of cameras detected: {0}\n\n", camList.Count);

            // Finish if there are no cameras

            if (camList.Count == 0)
            {
                cameraNum = 0;
                // Clear camera list before releasing system
                camList.Clear();

                // Release system
                system.Dispose();

                //Console.WriteLine("Not enough cameras!");
                //Console.WriteLine("Done! Press Enter to exit...");

            }
            if (camList.Count == 1)
            {
                cameraNum = 1;
                managedCamera = camList[0];
            }


            // Clear camera list before releasing system
            camList.Clear();

            // Release system
            system.Dispose();

            //Console.WriteLine("\nDone! Press Enter to exit...");

        }
    }



}
