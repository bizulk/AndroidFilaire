#ifndef DEVICE_LIBUSB_H
#define DEVICE_LIBUSB_H

#ifdef __cplusplus
extern "C" {
#endif


/// We created _this device specifically for android.
/// 17/12/2020 - Using the official libusb implementation 1.0.24 
/// archived - Implementation using Linux libusb **modified for android**
///		https://gitlab.com/madresistor/libusb/-/blob/android/README

#include "proto_iodevice.h"
#include "libcomm_global.h"
///
/// \brief Return a interface instance
/// \return Instance de notre device
///
proto_Device_t LIBCOMM_EXPORT devlibusb_create(void);

/// \brief Retrieve externally installed interface to device
/// \param _this device instance
/// \param ep_in endpoint number device to host
/// \param ep_out endpoint host to device
/// \param max_pkt_size max packet size, so the transfert can split data. If <=0 no limitation is set 
/// \return 0 si ok, -1 if not validated (for now just check those number are > 0)
///	TODO : Handle max packet size
int LIBCOMM_EXPORT devlibusb_setFD(proto_Device_t _this, int fd, int ep_in, int ep_out, int max_pkt_size);

/// \brief return assigned file descriptor
/// \return > 0 if exist, otherwise < 0
///
int LIBCOMM_EXPORT devlibusb_getFD(proto_Device_t _this);



#ifdef __cplusplus
} // extern "C"
#endif

#endif // DEVICE_SERIAL_H
